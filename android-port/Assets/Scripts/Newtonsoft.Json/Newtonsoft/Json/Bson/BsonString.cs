namespace Newtonsoft.Json.Bson
{
	internal class BsonString : BsonValue
	{
		private readonly bool IncludeLength;

		public BsonString(object value, bool includeLength)
			: base(null, (BsonType)0)
		{
		}
	}
}
