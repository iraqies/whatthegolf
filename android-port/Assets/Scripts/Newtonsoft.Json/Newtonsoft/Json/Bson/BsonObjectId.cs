using System;

namespace Newtonsoft.Json.Bson
{
	[Obsolete]
	public class BsonObjectId
	{
		public byte[] Value { get; }

		public BsonObjectId(byte[] value)
		{
		}
	}
}
