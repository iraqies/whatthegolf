using System;

namespace ThirdParty.Json.LitJson
{
	public class JsonPropertyAttribute : Attribute
	{
		public bool Required { get; set; }
	}
}
