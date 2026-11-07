using System;

namespace PlayFab.Json
{
	public class JsonProperty : Attribute
	{
		public string PropertyName;

		public NullValueHandling NullValueHandling;
	}
}
