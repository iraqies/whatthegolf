using System;

namespace Rewired.Utils.Attributes
{
	public class SerializationTypeAttribute : Attribute
	{
		public enum SerializationType
		{
			Default = 0,
			Object = 1
		}

		private SerializationType _serializationType;

		public SerializationType serializationType => SerializationType.Default;

		public SerializationTypeAttribute(SerializationType P_0)
		{
		}
	}
}
