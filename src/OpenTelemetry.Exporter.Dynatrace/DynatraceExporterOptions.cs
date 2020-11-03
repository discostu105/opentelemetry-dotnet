namespace OpenTelemetry.Exporter.Dynatrace
{
    /// <summary>
    /// Options to run dynatrace exporter.
    /// </summary>
    public class DynatraceExporterOptions
    {
        /// <summary>
        /// Gets or sets the dynatrace endpoint to send data to.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the dynatrace api-token for authentication.
        /// </summary>
        public string ApiToken { get; set; }
    }
}
