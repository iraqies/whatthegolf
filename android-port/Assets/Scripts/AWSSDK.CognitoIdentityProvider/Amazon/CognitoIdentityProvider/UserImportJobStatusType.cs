using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class UserImportJobStatusType : ConstantClass
	{
		public static readonly UserImportJobStatusType Created;

		public static readonly UserImportJobStatusType Expired;

		public static readonly UserImportJobStatusType Failed;

		public static readonly UserImportJobStatusType InProgress;

		public static readonly UserImportJobStatusType Pending;

		public static readonly UserImportJobStatusType Stopped;

		public static readonly UserImportJobStatusType Stopping;

		public static readonly UserImportJobStatusType Succeeded;

		public UserImportJobStatusType(string value)
			: base(null)
		{
		}

		public static UserImportJobStatusType FindValue(string value)
		{
			return null;
		}

		public static implicit operator UserImportJobStatusType(string value)
		{
			return null;
		}
	}
}
