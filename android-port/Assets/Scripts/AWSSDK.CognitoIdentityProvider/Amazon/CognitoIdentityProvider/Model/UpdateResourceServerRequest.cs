using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UpdateResourceServerRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _identifier;

		private string _name;

		private List<ResourceServerScopeType> _scopes;

		private string _userPoolId;

		[AWSProperty]
		public string Identifier
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
		public string Name
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
		public List<ResourceServerScopeType> Scopes
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
		public string UserPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetIdentifier()
		{
			return false;
		}

		internal bool IsSetName()
		{
			return false;
		}

		internal bool IsSetScopes()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
