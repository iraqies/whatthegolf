using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200001A")]
	public class AssumeRoleWithSAMLResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x28")]
		private AssumedRoleUser _assumedRoleUser;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x30")]
		private string _audience;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x38")]
		private Credentials _credentials;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x40")]
		private string _issuer;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x48")]
		private string _nameQualifier;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x50")]
		private int? _packedPolicySize;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x58")]
		private string _subject;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x60")]
		private string _subjectType;

		[Token(Token = "0x17000026")]
		public AssumedRoleUser AssumedRoleUser
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x12D93E8", Offset = "0x12D93E8", VA = "0x12D93E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x12D93F0", Offset = "0x12D93F0", VA = "0x12D93F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public string Audience
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x12D9408", Offset = "0x12D9408", VA = "0x12D9408")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x12D9410", Offset = "0x12D9410", VA = "0x12D9410")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Credentials Credentials
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x12D9428", Offset = "0x12D9428", VA = "0x12D9428")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x12D9430", Offset = "0x12D9430", VA = "0x12D9430")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public string Issuer
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x12D9448", Offset = "0x12D9448", VA = "0x12D9448")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x12D9450", Offset = "0x12D9450", VA = "0x12D9450")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public string NameQualifier
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x12D9468", Offset = "0x12D9468", VA = "0x12D9468")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x12D9470", Offset = "0x12D9470", VA = "0x12D9470")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3114C", Offset = "0x3114C")]
		public int PackedPolicySize
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x12D9488", Offset = "0x12D9488", VA = "0x12D9488")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x12D94C8", Offset = "0x12D94C8", VA = "0x12D94C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public string Subject
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x12D957C", Offset = "0x12D957C", VA = "0x12D957C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x12D9584", Offset = "0x12D9584", VA = "0x12D9584")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public string SubjectType
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x12D959C", Offset = "0x12D959C", VA = "0x12D959C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x12D95A4", Offset = "0x12D95A4", VA = "0x12D95A4")]
			set
			{
			}
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x12D93F8", Offset = "0x12D93F8", VA = "0x12D93F8")]
		internal bool IsSetAssumedRoleUser()
		{
			return default;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x12D9418", Offset = "0x12D9418", VA = "0x12D9418")]
		internal bool IsSetAudience()
		{
			return default;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x12D9438", Offset = "0x12D9438", VA = "0x12D9438")]
		internal bool IsSetCredentials()
		{
			return default;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x12D9458", Offset = "0x12D9458", VA = "0x12D9458")]
		internal bool IsSetIssuer()
		{
			return default;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x12D9478", Offset = "0x12D9478", VA = "0x12D9478")]
		internal bool IsSetNameQualifier()
		{
			return default;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x12D953C", Offset = "0x12D953C", VA = "0x12D953C")]
		internal bool IsSetPackedPolicySize()
		{
			return default;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x12D958C", Offset = "0x12D958C", VA = "0x12D958C")]
		internal bool IsSetSubject()
		{
			return default;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x12D95AC", Offset = "0x12D95AC", VA = "0x12D95AC")]
		internal bool IsSetSubjectType()
		{
			return default;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x12D95BC", Offset = "0x12D95BC", VA = "0x12D95BC")]
		public AssumeRoleWithSAMLResponse()
		{
		}
	}
}
