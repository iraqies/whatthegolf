using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CreateIdentityProviderRequest : AmazonCognitoIdentityProviderRequest
	{
		private Dictionary<string, string> _attributeMapping;

		private List<string> _idpIdentifiers;

		private Dictionary<string, string> _providerDetails;

		private string _providerName;

		private IdentityProviderTypeType _providerType;

		private string _userPoolId;

		public Dictionary<string, string> AttributeMapping
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
		public List<string> IdpIdentifiers
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
		public Dictionary<string, string> ProviderDetails
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
		public string ProviderName
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
		public IdentityProviderTypeType ProviderType
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

		internal bool IsSetAttributeMapping()
		{
			return false;
		}

		internal bool IsSetIdpIdentifiers()
		{
			return false;
		}

		internal bool IsSetProviderDetails()
		{
			return false;
		}

		internal bool IsSetProviderName()
		{
			return false;
		}

		internal bool IsSetProviderType()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
