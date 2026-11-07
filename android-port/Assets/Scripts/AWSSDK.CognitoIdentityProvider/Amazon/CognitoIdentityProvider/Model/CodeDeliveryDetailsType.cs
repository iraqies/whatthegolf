using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200006E")]
	public class CodeDeliveryDetailsType
	{
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x10")]
		private string _attributeName;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x18")]
		private DeliveryMediumType _deliveryMedium;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x20")]
		private string _destination;

		[Token(Token = "0x170000A8")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C7DC", Offset = "0x1C7DC")]
		public string AttributeName
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x10E2EDC", Offset = "0x10E2EDC", VA = "0x10E2EDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x10E2EE4", Offset = "0x10E2EE4", VA = "0x10E2EE4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public DeliveryMediumType DeliveryMedium
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x10E2EFC", Offset = "0x10E2EFC", VA = "0x10E2EFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x10E2F04", Offset = "0x10E2F04", VA = "0x10E2F04")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public string Destination
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x10E2F88", Offset = "0x10E2F88", VA = "0x10E2F88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x10E2F90", Offset = "0x10E2F90", VA = "0x10E2F90")]
			set
			{
			}
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x10E2EEC", Offset = "0x10E2EEC", VA = "0x10E2EEC")]
		internal bool IsSetAttributeName()
		{
			return default;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x10E2F0C", Offset = "0x10E2F0C", VA = "0x10E2F0C")]
		internal bool IsSetDeliveryMedium()
		{
			return default;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x10E2F98", Offset = "0x10E2F98", VA = "0x10E2F98")]
		internal bool IsSetDestination()
		{
			return default;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x10E2FA8", Offset = "0x10E2FA8", VA = "0x10E2FA8")]
		public CodeDeliveryDetailsType()
		{
		}
	}
}
