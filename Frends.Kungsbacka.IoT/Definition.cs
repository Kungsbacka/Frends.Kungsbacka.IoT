using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frends.Kungsbacka.IoT
{
    /// <summary>
    /// Required parameters
    /// </summary>
    public class DecodeParameters
    {

        /// <summary>
        /// Device model
        /// </summary>
        public IoTPayloadDecoder.DeviceModel DeviceModel { get; set; }

        /// <summary>
        /// Device port
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Payload as a hex string
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [Description("Payload as a hex string")]
        public string Payload { get; set; }
    }
}
