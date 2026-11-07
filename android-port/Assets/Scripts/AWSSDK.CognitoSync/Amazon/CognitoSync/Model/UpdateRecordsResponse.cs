using System.Collections.Generic;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class UpdateRecordsResponse : AmazonWebServiceResponse
	{
		private List<Record> _records;

		public List<Record> Records
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetRecords()
		{
			return false;
		}
	}
}
