using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000026")]
	public class GetFederationTokenResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x28")]
		private Credentials _credentials;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x30")]
		private FederatedUser _federatedUser;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x38")]
		private int? _packedPolicySize;

		[Token(Token = "0x17000049")]
		public Credentials Credentials
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x12E19E8", Offset = "0x12E19E8", VA = "0x12E19E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x12E19F0", Offset = "0x12E19F0", VA = "0x12E19F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public FederatedUser FederatedUser
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x12E1A08", Offset = "0x12E1A08", VA = "0x12E1A08")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x12E1A10", Offset = "0x12E1A10", VA = "0x12E1A10")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x31670", Offset = "0x31670")]
		public int PackedPolicySize
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x12E1A28", Offset = "0x12E1A28", VA = "0x12E1A28")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x12E1A68", Offset = "0x12E1A68", VA = "0x12E1A68")]
			set
			{
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x12E19F8", Offset = "0x12E19F8", VA = "0x12E19F8")]
		internal bool IsSetCredentials()
		{
			return default;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x12E1A18", Offset = "0x12E1A18", VA = "0x12E1A18")]
		internal bool IsSetFederatedUser()
		{
			return default;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x12E1ADC", Offset = "0x12E1ADC", VA = "0x12E1ADC")]
		internal bool IsSetPackedPolicySize()
		{
			return default;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x12E1B1C", Offset = "0x12E1B1C", VA = "0x12E1B1C")]
		public GetFederationTokenResponse()
		{
		}
	}
}
