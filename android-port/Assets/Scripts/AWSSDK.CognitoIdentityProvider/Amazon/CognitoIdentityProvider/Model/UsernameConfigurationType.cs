using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000140")]
	public class UsernameConfigurationType
	{
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x10")]
		private bool? _caseSensitive;

		[Token(Token = "0x170002A3")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2168C", Offset = "0x2168C")]
		public bool CaseSensitive
		{
			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x117979C", Offset = "0x117979C", VA = "0x117979C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x11797DC", Offset = "0x11797DC", VA = "0x11797DC")]
			set
			{
			}
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x1179850", Offset = "0x1179850", VA = "0x1179850")]
		internal bool IsSetCaseSensitive()
		{
			return default;
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x1179890", Offset = "0x1179890", VA = "0x1179890")]
		public UsernameConfigurationType()
		{
		}
	}
}
