using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000101")]
	public class ResourceServerScopeType
	{
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x10")]
		private string _scopeDescription;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x18")]
		private string _scopeName;

		[Token(Token = "0x170001F3")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FE14", Offset = "0x1FE14")]
		public string ScopeDescription
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x1144C84", Offset = "0x1144C84", VA = "0x1144C84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x1144C8C", Offset = "0x1144C8C", VA = "0x1144C8C")]
			set
			{
			}
		}

		[Token(Token = "0x170001F4")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FE64", Offset = "0x1FE64")]
		public string ScopeName
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x1144CA4", Offset = "0x1144CA4", VA = "0x1144CA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x1144CAC", Offset = "0x1144CAC", VA = "0x1144CAC")]
			set
			{
			}
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1144C94", Offset = "0x1144C94", VA = "0x1144C94")]
		internal bool IsSetScopeDescription()
		{
			return default;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x1144CB4", Offset = "0x1144CB4", VA = "0x1144CB4")]
		internal bool IsSetScopeName()
		{
			return default;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x1144CC4", Offset = "0x1144CC4", VA = "0x1144CC4")]
		public ResourceServerScopeType()
		{
		}
	}
}
