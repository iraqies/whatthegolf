using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	internal class BsonProperty
	{
		[CompilerGenerated]
		private BsonString Name__BackingField;

		[CompilerGenerated]
		private BsonToken Value__BackingField;

		public BsonString Name
		{
			[CompilerGenerated]
			set
			{
				Name__BackingField = value;
			}
		}

		public BsonToken Value
		{
			[CompilerGenerated]
			set
			{
				Value__BackingField = value;
			}
		}
	}
}
