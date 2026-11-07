using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class SetIdentityPoolRolesRequest : AmazonCognitoIdentityRequest
	{
		private string _identityPoolId;

		private Dictionary<string, RoleMapping> _roleMappings;

		private Dictionary<string, string> _roles;

		[AWSProperty]
		public string IdentityPoolId
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
		public Dictionary<string, RoleMapping> RoleMappings
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
		public Dictionary<string, string> Roles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}

		internal bool IsSetRoleMappings()
		{
			return false;
		}

		internal bool IsSetRoles()
		{
			return false;
		}
	}
}
