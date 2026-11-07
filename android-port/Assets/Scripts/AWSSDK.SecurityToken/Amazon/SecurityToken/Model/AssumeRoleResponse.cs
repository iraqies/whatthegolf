using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000018")]
	public class AssumeRoleResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x28")]
		private AssumedRoleUser _assumedRoleUser;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x30")]
		private Credentials _credentials;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x38")]
		private int? _packedPolicySize;

		[Token(Token = "0x1700001D")]
		public AssumedRoleUser AssumedRoleUser
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x12D6B7C", Offset = "0x12D6B7C", VA = "0x12D6B7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x12D6B84", Offset = "0x12D6B84", VA = "0x12D6B84")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Credentials Credentials
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x12D6B9C", Offset = "0x12D6B9C", VA = "0x12D6B9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x12D6BA4", Offset = "0x12D6BA4", VA = "0x12D6BA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30F90", Offset = "0x30F90")]
		public int PackedPolicySize
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x12D6BBC", Offset = "0x12D6BBC", VA = "0x12D6BBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x12D6BFC", Offset = "0x12D6BFC", VA = "0x12D6BFC")]
			set
			{
			}
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x12D6B8C", Offset = "0x12D6B8C", VA = "0x12D6B8C")]
		internal bool IsSetAssumedRoleUser()
		{
			return default;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x12D6BAC", Offset = "0x12D6BAC", VA = "0x12D6BAC")]
		internal bool IsSetCredentials()
		{
			return default;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x12D6C70", Offset = "0x12D6C70", VA = "0x12D6C70")]
		internal bool IsSetPackedPolicySize()
		{
			return default;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x12D6CB0", Offset = "0x12D6CB0", VA = "0x12D6CB0")]
		public AssumeRoleResponse()
		{
		}
	}
}
