using System.Collections.Generic;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
	public class ListDatasetsResponse : AmazonWebServiceResponse
	{
		private int? _count;

		private List<Dataset> _datasets;

		private string _nextToken;

		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<Dataset> Datasets
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NextToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCount()
		{
			return false;
		}

		internal bool IsSetDatasets()
		{
			return false;
		}

		internal bool IsSetNextToken()
		{
			return false;
		}
	}
}
