using System.Collections.Generic;
using System.ComponentModel;

namespace PlayFab.Json
{
	[EditorBrowsable]
	public class JsonArray : List<object>
	{
		public override string ToString()
		{
			return null;
		}
	}
}
