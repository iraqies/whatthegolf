using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	internal class BsonRegex : BsonToken
	{
		[CompilerGenerated]
		private BsonString Pattern__BackingField;

		[CompilerGenerated]
		private BsonString Options__BackingField;

		public BsonString Pattern
		{
			[CompilerGenerated]
			set
			{
				Pattern__BackingField = value;
			}
		}

		public BsonString Options
		{
			[CompilerGenerated]
			set
			{
				Options__BackingField = value;
			}
		}

		public override BsonType Type => (BsonType)0;

		public BsonRegex(string pattern, string options)
		{
		}
	}
}
