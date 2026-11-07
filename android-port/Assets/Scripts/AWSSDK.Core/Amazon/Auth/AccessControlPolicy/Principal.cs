using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy
{
	[Token(Token = "0x2000266")]
	public class Principal
	{
		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Principal AllUsers;

		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Principal Anonymous;

		[Token(Token = "0x40008B7")]
		public const string AWS_PROVIDER = "AWS";

		[Token(Token = "0x40008B8")]
		public const string CANONICAL_USER_PROVIDER = "CanonicalUser";

		[Token(Token = "0x40008B9")]
		public const string FEDERATED_PROVIDER = "Federated";

		[Token(Token = "0x40008BA")]
		public const string SERVICE_PROVIDER = "Service";

		[Token(Token = "0x40008BB")]
		public const string ANONYMOUS_PROVIDER = "__ANONYMOUS__";

		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x10")]
		private string id;

		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x18")]
		private string provider;

		[Token(Token = "0x17000469")]
		public string Provider
		{
			[Token(Token = "0x60011EF")]
			[Address(RVA = "0x124E47C", Offset = "0x124E47C", VA = "0x124E47C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011F0")]
			[Address(RVA = "0x124E484", Offset = "0x124E484", VA = "0x124E484")]
			set
			{
			}
		}

		[Token(Token = "0x1700046A")]
		public string Id
		{
			[Token(Token = "0x60011F1")]
			[Address(RVA = "0x124E48C", Offset = "0x124E48C", VA = "0x124E48C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x124E23C", Offset = "0x124E23C", VA = "0x124E23C")]
		public Principal(string accountId)
		{
		}

		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x124E2EC", Offset = "0x124E2EC", VA = "0x124E2EC")]
		public Principal(string provider, string id)
		{
		}

		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x124E3D0", Offset = "0x124E3D0", VA = "0x124E3D0")]
		public Principal(string provider, string id, bool stripHyphen)
		{
		}
	}
}
