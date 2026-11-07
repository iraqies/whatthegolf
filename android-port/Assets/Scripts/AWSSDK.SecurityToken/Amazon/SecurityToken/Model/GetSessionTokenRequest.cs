using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class GetSessionTokenRequest : AmazonSecurityTokenServiceRequest
	{
		private int? _durationSeconds;

		private string _serialNumber;

		private string _tokenCode;

		[AWSProperty]
		public int DurationSeconds
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string SerialNumber
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
		public string TokenCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDurationSeconds()
		{
			return false;
		}

		internal bool IsSetSerialNumber()
		{
			return false;
		}

		internal bool IsSetTokenCode()
		{
			return false;
		}
	}
}
