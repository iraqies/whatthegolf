using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class SequenceNumberRange
	{
		private string _endingSequenceNumber;

		private string _startingSequenceNumber;

		public string EndingSequenceNumber
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
		public string StartingSequenceNumber
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetEndingSequenceNumber()
		{
			return false;
		}

		internal bool IsSetStartingSequenceNumber()
		{
			return false;
		}
	}
}
