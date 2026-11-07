using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	internal class BsonObject : BsonToken
	{
		private readonly List<BsonProperty> _children;

		public override BsonType Type => (BsonType)0;

		public void Add(string name, BsonToken token)
		{
		}
	}
}
