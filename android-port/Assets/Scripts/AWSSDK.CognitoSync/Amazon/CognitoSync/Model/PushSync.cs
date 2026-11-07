using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class PushSync
	{
		private List<string> _applicationArns;

		private string _roleArn;

		public List<string> ApplicationArns
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

		internal bool IsSetApplicationArns()
		{
			return false;
		}

		internal bool IsSetRoleArn()
		{
			return false;
		}
	}
}
