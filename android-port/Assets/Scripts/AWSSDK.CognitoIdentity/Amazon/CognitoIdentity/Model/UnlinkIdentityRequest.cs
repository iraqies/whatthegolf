using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000050")]
	public class UnlinkIdentityRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x30")]
		private string _identityId;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _logins;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x40")]
		private List<string> _loginsToRemove;

		[Token(Token = "0x1700008C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23AD0", Offset = "0x23AD0")]
		public string IdentityId
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x11830E0", Offset = "0x11830E0", VA = "0x11830E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x11830E8", Offset = "0x11830E8", VA = "0x11830E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23B20", Offset = "0x23B20")]
		public Dictionary<string, string> Logins
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x1183100", Offset = "0x1183100", VA = "0x1183100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x1183108", Offset = "0x1183108", VA = "0x1183108")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23B60", Offset = "0x23B60")]
		public List<string> LoginsToRemove
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x118316C", Offset = "0x118316C", VA = "0x118316C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x1183174", Offset = "0x1183174", VA = "0x1183174")]
			set
			{
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x11830F0", Offset = "0x11830F0", VA = "0x11830F0")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1183110", Offset = "0x1183110", VA = "0x1183110")]
		internal bool IsSetLogins()
		{
			return default;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x118317C", Offset = "0x118317C", VA = "0x118317C")]
		internal bool IsSetLoginsToRemove()
		{
			return default;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x11831D4", Offset = "0x11831D4", VA = "0x11831D4")]
		public UnlinkIdentityRequest()
		{
		}
	}
}
