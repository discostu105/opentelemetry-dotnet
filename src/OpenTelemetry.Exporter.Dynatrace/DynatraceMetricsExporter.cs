using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenTelemetry.Metrics.Export;

namespace OpenTelemetry.Exporter.Dynatrace {
    public class DynatraceMetricsExporter : MetricExporter
    {
        public override async Task<ExportResult> ExportAsync(IEnumerable<Metric> metrics, CancellationToken cancellationToken)
        {
            Console.WriteLine("DynatraceMetricsExporter.ExportAsync()");
            return ExportResult.Success;
        }
    }
}
