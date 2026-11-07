namespace Newtonsoft.Json.Linq
{
	public class JRaw : JValue
	{
		public JRaw(JRaw other)
			: base(null, JTokenType.None)
		{
		}

		public JRaw(object rawJson)
			: base(null, JTokenType.None)
		{
		}

		public static JRaw Create(JsonReader reader)
		{
			return null;
		}

		internal override JToken CloneToken()
		{
			return null;
		}
	}
}
