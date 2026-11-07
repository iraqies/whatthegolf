using System.IO;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SetUICustomizationRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _clientId;

		private string _css;

		private MemoryStream _imageFile;

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

		public MemoryStream ImageFile
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

		internal bool IsSetClientId()
		{
			return false;
		}

		internal bool IsSetCSS()
		{
			return false;
		}

		internal bool IsSetImageFile()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
