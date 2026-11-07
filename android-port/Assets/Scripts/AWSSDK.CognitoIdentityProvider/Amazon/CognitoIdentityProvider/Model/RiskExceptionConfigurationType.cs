using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class RiskExceptionConfigurationType
	{
		private List<string> _blockedIPRangeList;

		private List<string> _skippedIPRangeList;

		[AWSProperty]
		public List<string> BlockedIPRangeList
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
		public List<string> SkippedIPRangeList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetBlockedIPRangeList()
		{
			return false;
		}

		internal bool IsSetSkippedIPRangeList()
		{
			return false;
		}
	}
}
