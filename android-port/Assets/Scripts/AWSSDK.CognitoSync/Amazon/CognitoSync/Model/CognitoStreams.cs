using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class CognitoStreams
	{
		private string _roleArn;

		private StreamingStatus _streamingStatus;

		private string _streamName;

		[AWSProperty]
		public string RoleArn
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StreamingStatus StreamingStatus
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
		public string StreamName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetRoleArn()
		{
			return false;
		}

		internal bool IsSetStreamingStatus()
		{
			return false;
		}

		internal bool IsSetStreamName()
		{
			return false;
		}
	}
}
