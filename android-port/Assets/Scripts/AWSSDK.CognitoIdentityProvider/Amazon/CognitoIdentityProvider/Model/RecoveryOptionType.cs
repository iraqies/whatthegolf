using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class RecoveryOptionType
	{
		private RecoveryOptionNameType _name;

		private int? _priority;

		[AWSProperty]
		public RecoveryOptionNameType Name
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
		public int Priority
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal bool IsSetName()
		{
			return false;
		}

		internal bool IsSetPriority()
		{
			return false;
		}
	}
}
