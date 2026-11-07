using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000F2")]
	public class MFAOptionType
	{
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x10")]
		private string _attributeName;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x18")]
		private DeliveryMediumType _deliveryMedium;

		[Token(Token = "0x170001CE")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F9C8", Offset = "0x1F9C8")]
		public string AttributeName
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x113CE30", Offset = "0x113CE30", VA = "0x113CE30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x113CE38", Offset = "0x113CE38", VA = "0x113CE38")]
			set
			{
			}
		}

		[Token(Token = "0x170001CF")]
		public DeliveryMediumType DeliveryMedium
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x113CE50", Offset = "0x113CE50", VA = "0x113CE50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x113CE58", Offset = "0x113CE58", VA = "0x113CE58")]
			set
			{
			}
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x113CE40", Offset = "0x113CE40", VA = "0x113CE40")]
		internal bool IsSetAttributeName()
		{
			return default;
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x113CE60", Offset = "0x113CE60", VA = "0x113CE60")]
		internal bool IsSetDeliveryMedium()
		{
			return default;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x113CEDC", Offset = "0x113CEDC", VA = "0x113CEDC")]
		public MFAOptionType()
		{
		}
	}
}
