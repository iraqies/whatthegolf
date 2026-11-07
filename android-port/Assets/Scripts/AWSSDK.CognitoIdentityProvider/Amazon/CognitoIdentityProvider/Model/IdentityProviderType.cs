using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class IdentityProviderType
	{
		private Dictionary<string, string> _attributeMapping;

		private DateTime? _creationDate;

		private List<string> _idpIdentifiers;

		private DateTime? _lastModifiedDate;

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

		public DateTime CreationDate
		{
			get
			{
				return default;
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

		public DateTime LastModifiedDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

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

		internal bool IsSetCreationDate()
		{
			return false;
		}

		internal bool IsSetIdpIdentifiers()
		{
			return false;
		}

		internal bool IsSetLastModifiedDate()
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
