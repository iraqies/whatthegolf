using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy
{
	[Token(Token = "0x2000261")]
	public class Policy
	{
		[Token(Token = "0x2000262")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x260A8", Offset = "0x260A8")]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			[Token(Token = "0x40008B1")]
			[FieldOffset(Offset = "0x10")]
			public Resource resource;

			[Token(Token = "0x60011E4")]
			[Address(RVA = "0x1290EC8", Offset = "0x1290EC8", VA = "0x1290EC8")]
			public _003C_003Ec__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60011E5")]
			[Address(RVA = "0x1290ED0", Offset = "0x1290ED0", VA = "0x1290ED0")]
			internal bool _003CStatementContainsResources_003Eb__0(Resource x)
			{
				return default;
			}
		}

		[Token(Token = "0x2000263")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x260B8", Offset = "0x260B8")]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			[Token(Token = "0x40008B2")]
			[FieldOffset(Offset = "0x10")]
			public ActionIdentifier action;

			[Token(Token = "0x60011E6")]
			[Address(RVA = "0x1290EFC", Offset = "0x1290EFC", VA = "0x1290EFC")]
			public _003C_003Ec__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60011E7")]
			[Address(RVA = "0x1290F04", Offset = "0x1290F04", VA = "0x1290F04")]
			internal bool _003CStatementContainsActions_003Eb__0(ActionIdentifier x)
			{
				return default;
			}
		}

		[Token(Token = "0x2000264")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x260C8", Offset = "0x260C8")]
		private sealed class _003C_003Ec__DisplayClass20_0
		{
			[Token(Token = "0x40008B3")]
			[FieldOffset(Offset = "0x10")]
			public Condition condition;

			[Token(Token = "0x60011E8")]
			[Address(RVA = "0x1290F30", Offset = "0x1290F30", VA = "0x1290F30")]
			public _003C_003Ec__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60011E9")]
			[Address(RVA = "0x1290F38", Offset = "0x1290F38", VA = "0x1290F38")]
			internal bool _003CStatementContainsConditions_003Eb__0(Condition x)
			{
				return default;
			}
		}

		[Token(Token = "0x2000265")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x260D8", Offset = "0x260D8")]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			[Token(Token = "0x40008B4")]
			[FieldOffset(Offset = "0x10")]
			public Principal principal;

			[Token(Token = "0x60011EA")]
			[Address(RVA = "0x129101C", Offset = "0x129101C", VA = "0x129101C")]
			public _003C_003Ec__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60011EB")]
			[Address(RVA = "0x1291024", Offset = "0x1291024", VA = "0x1291024")]
			internal bool _003CStatementContainsPrincipals_003Eb__0(Principal x)
			{
				return default;
			}
		}

		[Token(Token = "0x40008AD")]
		private const string DEFAULT_POLICY_VERSION = "2012-10-17";

		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x10")]
		private string id;

		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x18")]
		private string version;

		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x20")]
		private IList<Statement> statements;

		[Token(Token = "0x17000466")]
		public string Id
		{
			[Token(Token = "0x60011D4")]
			[Address(RVA = "0x124C6B4", Offset = "0x124C6B4", VA = "0x124C6B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011D5")]
			[Address(RVA = "0x124C6BC", Offset = "0x124C6BC", VA = "0x124C6BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000467")]
		public string Version
		{
			[Token(Token = "0x60011D7")]
			[Address(RVA = "0x124C6CC", Offset = "0x124C6CC", VA = "0x124C6CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011D8")]
			[Address(RVA = "0x124C6D4", Offset = "0x124C6D4", VA = "0x124C6D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000468")]
		public IList<Statement> Statements
		{
			[Token(Token = "0x60011D9")]
			[Address(RVA = "0x124C6DC", Offset = "0x124C6DC", VA = "0x124C6DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011DA")]
			[Address(RVA = "0x124C6E4", Offset = "0x124C6E4", VA = "0x124C6E4")]
			set
			{
			}
		}

		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x124C4A0", Offset = "0x124C4A0", VA = "0x124C4A0")]
		public Policy()
		{
		}

		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x124C544", Offset = "0x124C544", VA = "0x124C544")]
		public Policy(string id)
		{
		}

		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x124C5F4", Offset = "0x124C5F4", VA = "0x124C5F4")]
		public Policy(string id, IList<Statement> statements)
		{
		}

		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x124C6C4", Offset = "0x124C6C4", VA = "0x124C6C4")]
		public Policy WithId(string id)
		{
			return null;
		}

		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x124C6EC", Offset = "0x124C6EC", VA = "0x124C6EC")]
		public bool CheckIfStatementExists(Statement statement)
		{
			return default;
		}

		[Token(Token = "0x60011DC")]
		[Address(RVA = "0x124CAA0", Offset = "0x124CAA0", VA = "0x124CAA0")]
		private static bool StatementContainsResources(Statement statement, IList<Resource> resources)
		{
			return default;
		}

		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x124CEA8", Offset = "0x124CEA8", VA = "0x124CEA8")]
		private static bool StatementContainsActions(Statement statement, IList<ActionIdentifier> actions)
		{
			return default;
		}

		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x124D2B0", Offset = "0x124D2B0", VA = "0x124D2B0")]
		private static bool StatementContainsConditions(Statement statement, IList<Condition> conditions)
		{
			return default;
		}

		[Token(Token = "0x60011DF")]
		[Address(RVA = "0x124D6B8", Offset = "0x124D6B8", VA = "0x124D6B8")]
		private static bool StatementContainsPrincipals(Statement statement, IList<Principal> principals)
		{
			return default;
		}

		[Token(Token = "0x60011E0")]
		[Address(RVA = "0x124DAC0", Offset = "0x124DAC0", VA = "0x124DAC0")]
		public Policy WithStatements(params Statement[] statements)
		{
			return null;
		}

		[Token(Token = "0x60011E1")]
		[Address(RVA = "0x124DC48", Offset = "0x124DC48", VA = "0x124DC48")]
		public string ToJson()
		{
			return null;
		}

		[Token(Token = "0x60011E2")]
		[Address(RVA = "0x124DC58", Offset = "0x124DC58", VA = "0x124DC58")]
		public string ToJson(bool prettyPrint)
		{
			return null;
		}

		[Token(Token = "0x60011E3")]
		[Address(RVA = "0x124DC6C", Offset = "0x124DC6C", VA = "0x124DC6C")]
		public static Policy FromJson(string json)
		{
			return null;
		}
	}
}
