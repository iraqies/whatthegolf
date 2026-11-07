using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class RulesConfigurationType
	{
		private List<MappingRule> _rules;

		[AWSProperty]
		public List<MappingRule> Rules
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetRules()
		{
			return false;
		}
	}
}
