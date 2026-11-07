namespace Amazon.CognitoIdentityProvider.Model
{
	public class AuthenticationResultType
	{
		private string _accessToken;

		private int? _expiresIn;

		private string _idToken;

		private NewDeviceMetadataType _newDeviceMetadata;

		private string _refreshToken;

		private string _tokenType;

		public string AccessToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ExpiresIn
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string IdToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NewDeviceMetadataType NewDeviceMetadata
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string RefreshToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TokenType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAccessToken()
		{
			return false;
		}

		internal bool IsSetExpiresIn()
		{
			return false;
		}

		internal bool IsSetIdToken()
		{
			return false;
		}

		internal bool IsSetNewDeviceMetadata()
		{
			return false;
		}

		internal bool IsSetRefreshToken()
		{
			return false;
		}

		internal bool IsSetTokenType()
		{
			return false;
		}
	}
}
