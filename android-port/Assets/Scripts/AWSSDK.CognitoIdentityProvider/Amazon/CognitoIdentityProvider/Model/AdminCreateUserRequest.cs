using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000033")]
	public class AdminCreateUserRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x38")]
		private List<string> _desiredDeliveryMediums;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x40")]
		private bool? _forceAliasCreation;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x48")]
		private MessageActionType _messageAction;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x50")]
		private string _temporaryPassword;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x58")]
		private List<AttributeType> _userAttributes;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x60")]
		private string _username;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x68")]
		private string _userPoolId;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x70")]
		private List<AttributeType> _validationData;

		[Token(Token = "0x17000018")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x109E6B4", Offset = "0x109E6B4", VA = "0x109E6B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x109E6BC", Offset = "0x109E6BC", VA = "0x109E6BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public List<string> DesiredDeliveryMediums
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x109E720", Offset = "0x109E720", VA = "0x109E720")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x109E728", Offset = "0x109E728", VA = "0x109E728")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool ForceAliasCreation
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x109E788", Offset = "0x109E788", VA = "0x109E788")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x109E7C8", Offset = "0x109E7C8", VA = "0x109E7C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public MessageActionType MessageAction
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x109E87C", Offset = "0x109E87C", VA = "0x109E87C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x109E884", Offset = "0x109E884", VA = "0x109E884")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AF58", Offset = "0x1AF58")]
		public string TemporaryPassword
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x109E908", Offset = "0x109E908", VA = "0x109E908")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x109E910", Offset = "0x109E910", VA = "0x109E910")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public List<AttributeType> UserAttributes
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x109E928", Offset = "0x109E928", VA = "0x109E928")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x109E930", Offset = "0x109E930", VA = "0x109E930")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AFA0", Offset = "0x1AFA0")]
		public string Username
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x109E990", Offset = "0x109E990", VA = "0x109E990")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x109E998", Offset = "0x109E998", VA = "0x109E998")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AFF0", Offset = "0x1AFF0")]
		public string UserPoolId
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x109E9B0", Offset = "0x109E9B0", VA = "0x109E9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x109E9B8", Offset = "0x109E9B8", VA = "0x109E9B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public List<AttributeType> ValidationData
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x109E9D0", Offset = "0x109E9D0", VA = "0x109E9D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x109E9D8", Offset = "0x109E9D8", VA = "0x109E9D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x109E6C4", Offset = "0x109E6C4", VA = "0x109E6C4")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x109E730", Offset = "0x109E730", VA = "0x109E730")]
		internal bool IsSetDesiredDeliveryMediums()
		{
			return default;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x109E83C", Offset = "0x109E83C", VA = "0x109E83C")]
		internal bool IsSetForceAliasCreation()
		{
			return default;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x109E88C", Offset = "0x109E88C", VA = "0x109E88C")]
		internal bool IsSetMessageAction()
		{
			return default;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x109E918", Offset = "0x109E918", VA = "0x109E918")]
		internal bool IsSetTemporaryPassword()
		{
			return default;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x109E938", Offset = "0x109E938", VA = "0x109E938")]
		internal bool IsSetUserAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x109E9A0", Offset = "0x109E9A0", VA = "0x109E9A0")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x109E9C0", Offset = "0x109E9C0", VA = "0x109E9C0")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x109E9E0", Offset = "0x109E9E0", VA = "0x109E9E0")]
		internal bool IsSetValidationData()
		{
			return default;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x109EA38", Offset = "0x109EA38", VA = "0x109EA38")]
		public AdminCreateUserRequest()
		{
		}
	}
}
