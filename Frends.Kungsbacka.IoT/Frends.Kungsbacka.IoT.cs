using System;
using System.ComponentModel;
using System.Threading;
using Microsoft.CSharp; // You can remove this if you don't need dynamic type in .NET Standard frends Tasks
using Newtonsoft.Json.Linq;
using IoTPayloadDecoder;

#pragma warning disable 1591

namespace Frends.Kungsbacka.IoT
{
    public static class Decoder
    {

        /// <summary>
        /// Decodes IoT payload
        /// </summary>
        /// <param name="input">Required parameters</param>
        /// <returns>dynamic</returns>
        /// <exception cref="ArgumentException"></exception>
        public static dynamic DecodePayload(DecodeParameters input)
        {
            switch (input.DeviceModel)
            {
                case DeviceModel.Elsys:
                    return ElsysDecoder.Decode(input.Payload);
                case DeviceModel.Nas:
                    return NasDecoder.Decode(input.Payload, input.Port);
                default:
                    throw new ArgumentException("Unknown device model", nameof(input.DeviceModel));
            }
        }
    }
}

