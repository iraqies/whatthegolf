using System.Collections.Generic;

namespace Amazon.Runtime
{
	public class ResponseMetadata
	{
		private string requestIdField;

		private IDictionary<string, string> _metadata;

		public string RequestId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IDictionary<string, string> Metadata => null;
	}
}
