using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class PasswordPolicyType
	{
		private int? _minimumLength;

		private bool? _requireLowercase;

		private bool? _requireNumbers;

		private bool? _requireSymbols;

		private bool? _requireUppercase;

		private int? _temporaryPasswordValidityDays;

		[AWSProperty]
		public int MinimumLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool RequireLowercase
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RequireNumbers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RequireSymbols
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RequireUppercase
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[AWSProperty]
		public int TemporaryPasswordValidityDays
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal bool IsSetMinimumLength()
		{
			return false;
		}

		internal bool IsSetRequireLowercase()
		{
			return false;
		}

		internal bool IsSetRequireNumbers()
		{
			return false;
		}

		internal bool IsSetRequireSymbols()
		{
			return false;
		}

		internal bool IsSetRequireUppercase()
		{
			return false;
		}

		internal bool IsSetTemporaryPasswordValidityDays()
		{
			return false;
		}
	}
}
