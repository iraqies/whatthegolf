using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class MappingRule
	{
		private string _claim;

		private MappingRuleMatchType _matchType;

		private string _roleARN;

		private string _value;

		[AWSProperty]
		public string Claim
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
		public MappingRuleMatchType MatchType
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
		public string RoleARN
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
		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetClaim()
		{
			return false;
		}

		internal bool IsSetMatchType()
		{
			return false;
		}

		internal bool IsSetRoleARN()
		{
			return false;
		}

		internal bool IsSetValue()
		{
			return false;
		}
	}
}
