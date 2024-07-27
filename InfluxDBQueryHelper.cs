using InfluxDB.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineControl
{
    public class InfluxDBHelper
    {
        private static readonly string queryCount = "from(bucket: \"RealTime_{0}\")" + Environment.NewLine +
                    "|> range(start: {1}, stop: {2})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] != \"quality\")" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"name\"] == \"{3}\")" + Environment.NewLine +
                    "|> count()";

        private static readonly string queryTimeSeries = "from(bucket: \"RealTime_{0}\")" + Environment.NewLine +
                    "|> range(start: {1}, stop: {2})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] == \"ivalue\" or r[\"_field\"] == \"bvalue\" or r[\"_field\"] == \"dvalue\")" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"name\"] == \"{3}\")";

        private static readonly string queryAggregateMax = "from(bucket: \"RealTime_{0}\")" + Environment.NewLine +
                    "|> range(start: {1}, stop: {2})" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"_field\"] == \"ivalue\" or r[\"_field\"] == \"bvalue\" or r[\"_field\"] == \"dvalue\")" + Environment.NewLine +
                    "|> filter(fn: (r) => r[\"name\"] == \"{3}\")" + Environment.NewLine +
                    "|> aggregateWindow(every: {4}s, fn: {5})";

        public static async Task<int> GetLinePointCount(DateTimePicker dtpStart, DateTimePicker dtpEnd, string lineName)
        {
            var count = 0;
            using (var influxDBClient = new InfluxDBClient(ConfigInfo.InfluxDBUrl, ConfigInfo.Token))
            {
                var fluxQuery = string.Format(queryCount, ConfigInfo.ProjectGuid,
                    GetInfluxDBDatetime(dtpStart), GetInfluxDBDatetime(dtpEnd), lineName);

                var fluxCountTable = await influxDBClient.GetQueryApi().QueryAsync(fluxQuery, ConfigInfo.OrgID);
                fluxCountTable.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        int.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out count);
                    });
                });
            }
            return count;
        }

        public static async Task<TimeSeriesData> GetTimeSeriesHistorian(DateTimePicker dtpStart, DateTimePicker dtpEnd,string lineName)
        {
            var dateTimes = new List<DateTime>();
            var yValues = new List<double>();

            using (var influxDBClient = new InfluxDBClient(ConfigInfo.InfluxDBUrl, ConfigInfo.Token))
            {
                var fluxQuery = string.Format(queryTimeSeries, ConfigInfo.ProjectGuid,
                    GetInfluxDBDatetime(dtpStart), GetInfluxDBDatetime(dtpEnd), lineName);

                var fluxCountTable = await influxDBClient.GetQueryApi().QueryAsync(fluxQuery, ConfigInfo.OrgID);
                fluxCountTable.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        DateTime.TryParse(fluxRecord.GetValueByKey("_time").ToString(), out var dateTime);

                        double yValue = 0;
                        if (null != fluxRecord.GetValueByKey("_value"))
                        {
                            double.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out yValue);
                        }

                        dateTimes.Add(dateTime);
                        yValues.Add(yValue);
                    });
                });
            }

            return new TimeSeriesData { dateTimes = dateTimes, yValues = yValues };
        }

        public static async Task<AggregateData> GetAggregateData(DateTimePicker dtpStart, DateTimePicker dtpEnd, double gapSecond, string lineName)
        {
            var dateTimes = new List<DateTime>();
            var yMaxValues = new List<double>();
            var yMinValues = new List<double>();

            using (var influxDBClient = new InfluxDBClient(ConfigInfo.InfluxDBUrl, ConfigInfo.Token))
            {
                var fluxQueryMax = string.Format(queryAggregateMax, ConfigInfo.ProjectGuid,
                    GetInfluxDBDatetime(dtpStart), GetInfluxDBDatetime(dtpEnd), lineName, gapSecond,"max");

                var fluxCountTable = await influxDBClient.GetQueryApi().QueryAsync(fluxQueryMax, ConfigInfo.OrgID);
                fluxCountTable.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        DateTime.TryParse(fluxRecord.GetValueByKey("_time").ToString(), out var dateTime);

                        double yValue = 0;
                        if (null != fluxRecord.GetValueByKey("_value"))
                        {
                            double.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out yValue);
                        }

                        dateTimes.Add(dateTime);
                        yMaxValues.Add(yValue);
                    });
                });

                var fluxQueryMin = string.Format(queryAggregateMax, ConfigInfo.ProjectGuid,
                    GetInfluxDBDatetime(dtpStart), GetInfluxDBDatetime(dtpEnd), lineName, gapSecond, "min");

                var fluxCountTableMin = await influxDBClient.GetQueryApi().QueryAsync(fluxQueryMin, ConfigInfo.OrgID);

                fluxCountTableMin.ForEach(fluxTable =>
                {
                    var fluxRecords = fluxTable.Records;
                    fluxRecords.ForEach(fluxRecord =>
                    {
                        DateTime.TryParse(fluxRecord.GetValueByKey("_time").ToString(), out var dateTime);

                        double yValue = 0;
                        if (null != fluxRecord.GetValueByKey("_value"))
                        {
                            double.TryParse(fluxRecord.GetValueByKey("_value").ToString(), out yValue);
                        }

                        yMinValues.Add(yValue);
                    });
                });
            }

            return new AggregateData { dateTimes = dateTimes, yMaxValues = yMaxValues,yMinValues = yMinValues };
        }

        private static string GetInfluxDBDatetime(DateTimePicker timePicker)
        {
            return timePicker.Value.ToUniversalTime().ToString("s") + "Z";
        }

    }
}
