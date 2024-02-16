using IoTPayloadDecoder;
using System;

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
            IPayloadDecoder decoder;

			switch (input.DeviceModel)
            {
                case DeviceModel.Elsys:
					decoder = DecoderFactory.Create(DeviceModel.Elsys, 0);
					return decoder.Decode(input.Payload, false);
                case DeviceModel.Nas10:
					decoder = DecoderFactory.Create(DeviceModel.Nas10, 0);
					return decoder.Decode(input.Payload, false);
				case DeviceModel.Nas11:
					decoder = DecoderFactory.Create(DeviceModel.Nas11, 0);
					return decoder.Decode(input.Payload, false);
				default:
                    throw new ArgumentException("Unknown device model", nameof(input.DeviceModel));
            }
        }
    }
}

