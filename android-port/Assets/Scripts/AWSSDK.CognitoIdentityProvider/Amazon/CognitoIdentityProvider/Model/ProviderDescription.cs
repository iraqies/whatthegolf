using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ProviderDescription
	{
		private DateTime? _creationDate;

		private DateTime? _lastModifiedDate;

		private string _providerName;

		private IdentityProviderTypeType _providerType;

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

		internal bool IsSetCreationDate()
		{
			return false;
		}

		internal bool IsSetLastModifiedDate()
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
	}
}
