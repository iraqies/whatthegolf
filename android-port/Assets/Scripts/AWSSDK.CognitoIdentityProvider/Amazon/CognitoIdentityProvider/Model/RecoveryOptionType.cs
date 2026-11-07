using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000FD")]
	public class RecoveryOptionType
	{
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x10")]
		private RecoveryOptionNameType _name;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x18")]
		private int? _priority;

		[Token(Token = "0x170001EA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FCA8", Offset = "0x1FCA8")]
		public RecoveryOptionNameType Name
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x1142150", Offset = "0x1142150", VA = "0x1142150")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1142158", Offset = "0x1142158", VA = "0x1142158")]
			set
			{
			}
		}

		[Token(Token = "0x170001EB")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FCDC", Offset = "0x1FCDC")]
		public int Priority
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x11421DC", Offset = "0x11421DC", VA = "0x11421DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x114221C", Offset = "0x114221C", VA = "0x114221C")]
			set
			{
			}
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1142160", Offset = "0x1142160", VA = "0x1142160")]
		internal bool IsSetName()
		{
			return default;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x1142290", Offset = "0x1142290", VA = "0x1142290")]
		internal bool IsSetPriority()
		{
			return default;
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x11422D0", Offset = "0x11422D0", VA = "0x11422D0")]
		public RecoveryOptionType()
		{
		}
	}
}
