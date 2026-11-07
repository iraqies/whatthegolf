using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class HashKeyRange
	{
		private string _endingHashKey;

		private string _startingHashKey;

		[AWSProperty]
		public string EndingHashKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string StartingHashKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetEndingHashKey()
		{
			return false;
		}

		internal bool IsSetStartingHashKey()
		{
			return false;
		}
	}
}
