using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminCreateUserRequest : AmazonCognitoIdentityProviderRequest
	{
		private Dictionary<string, string> _clientMetadata;

		private List<string> _desiredDeliveryMediums;

		private bool? _forceAliasCreation;

		private MessageActionType _messageAction;

		private string _temporaryPassword;

		private List<AttributeType> _userAttributes;

		private string _username;

		private string _userPoolId;

		private List<AttributeType> _validationData;

		public Dictionary<string, string> ClientMetadata
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> DesiredDeliveryMediums
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ForceAliasCreation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MessageActionType MessageAction
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
		public string TemporaryPassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<AttributeType> UserAttributes
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
		public string Username
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

		public List<AttributeType> ValidationData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetClientMetadata()
		{
			return false;
		}

		internal bool IsSetDesiredDeliveryMediums()
		{
			return false;
		}

		internal bool IsSetForceAliasCreation()
		{
			return false;
		}

		internal bool IsSetMessageAction()
		{
			return false;
		}

		internal bool IsSetTemporaryPassword()
		{
			return false;
		}

		internal bool IsSetUserAttributes()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}

		internal bool IsSetValidationData()
		{
			return false;
		}
	}
}
