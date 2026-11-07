namespace Newtonsoft.Json.Bson
{
	internal class BsonValue : BsonToken
	{
		private readonly object _value;

		private readonly BsonType _type;

		public override BsonType Type => (BsonType)0;

		public BsonValue(object value, BsonType type)
		{
		}
	}
}
