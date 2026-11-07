using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	internal class BsonArray : BsonToken
	{
		private readonly List<BsonToken> _children;

		public override BsonType Type => (BsonType)0;

		public void Add(BsonToken token)
		{
		}
	}
}
