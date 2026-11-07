using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UICustomizationType
	{
		private string _clientId;

		private DateTime? _creationDate;

		private string _css;

		private string _cssVersion;

		private string _imageUrl;

		private DateTime? _lastModifiedDate;

		private string _userPoolId;

		[AWSProperty]
		public string ClientId
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

		public string CSS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CSSVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ImageUrl
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

		internal bool IsSetClientId()
		{
			return false;
		}

		internal bool IsSetCreationDate()
		{
			return false;
		}

		internal bool IsSetCSS()
		{
			return false;
		}

		internal bool IsSetCSSVersion()
		{
			return false;
		}

		internal bool IsSetImageUrl()
		{
			return false;
		}

		internal bool IsSetLastModifiedDate()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
