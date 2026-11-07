using System;

namespace Newtonsoft.Json
{
	public class JsonExtensionDataAttribute : Attribute
	{
		public bool WriteData { get; }

		public bool ReadData { get; }
	}
}
