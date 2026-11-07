using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200001C")]
	public class AssumeRoleWithWebIdentityResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x28")]
		private AssumedRoleUser _assumedRoleUser;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x30")]
		private string _audience;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x38")]
		private Credentials _credentials;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x40")]
		private int? _packedPolicySize;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x48")]
		private string _provider;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x50")]
		private string _subjectFromWebIdentityToken;

		[Token(Token = "0x17000035")]
		public AssumedRoleUser AssumedRoleUser
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x12DBC28", Offset = "0x12DBC28", VA = "0x12DBC28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x12DBC30", Offset = "0x12DBC30", VA = "0x12DBC30")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public string Audience
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x12DBC48", Offset = "0x12DBC48", VA = "0x12DBC48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x12DBC50", Offset = "0x12DBC50", VA = "0x12DBC50")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Credentials Credentials
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x12DBC68", Offset = "0x12DBC68", VA = "0x12DBC68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x12DBC70", Offset = "0x12DBC70", VA = "0x12DBC70")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3134C", Offset = "0x3134C")]
		public int PackedPolicySize
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x12DBC88", Offset = "0x12DBC88", VA = "0x12DBC88")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x12DBCC8", Offset = "0x12DBCC8", VA = "0x12DBCC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public string Provider
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x12DBD7C", Offset = "0x12DBD7C", VA = "0x12DBD7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x12DBD84", Offset = "0x12DBD84", VA = "0x12DBD84")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x31384", Offset = "0x31384")]
		public string SubjectFromWebIdentityToken
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x12DBD9C", Offset = "0x12DBD9C", VA = "0x12DBD9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x12DBDA4", Offset = "0x12DBDA4", VA = "0x12DBDA4")]
			set
			{
			}
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x12DBC38", Offset = "0x12DBC38", VA = "0x12DBC38")]
		internal bool IsSetAssumedRoleUser()
		{
			return default;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x12DBC58", Offset = "0x12DBC58", VA = "0x12DBC58")]
		internal bool IsSetAudience()
		{
			return default;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x12DBC78", Offset = "0x12DBC78", VA = "0x12DBC78")]
		internal bool IsSetCredentials()
		{
			return default;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x12DBD3C", Offset = "0x12DBD3C", VA = "0x12DBD3C")]
		internal bool IsSetPackedPolicySize()
		{
			return default;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x12DBD8C", Offset = "0x12DBD8C", VA = "0x12DBD8C")]
		internal bool IsSetProvider()
		{
			return default;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x12DBDAC", Offset = "0x12DBDAC", VA = "0x12DBDAC")]
		internal bool IsSetSubjectFromWebIdentityToken()
		{
			return default;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x12DBDBC", Offset = "0x12DBDBC", VA = "0x12DBDBC")]
		public AssumeRoleWithWebIdentityResponse()
		{
		}
	}
}
