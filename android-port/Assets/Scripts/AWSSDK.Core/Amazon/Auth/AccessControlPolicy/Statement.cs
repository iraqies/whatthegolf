using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy
{
	[Token(Token = "0x2000269")]
	public class Statement
	{
		[Token(Token = "0x200026A")]
		public enum StatementEffect
		{
			[Token(Token = "0x40008C6")]
			Allow = 0,
			[Token(Token = "0x40008C7")]
			Deny = 1
		}

		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x10")]
		private string id;

		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x18")]
		private StatementEffect effect;

		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x20")]
		private IList<Principal> principals;

		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x28")]
		private IList<ActionIdentifier> actions;

		[Token(Token = "0x40008C3")]
		[FieldOffset(Offset = "0x30")]
		private IList<Resource> resources;

		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0x38")]
		private IList<Condition> conditions;

		[Token(Token = "0x1700046C")]
		public string Id
		{
			[Token(Token = "0x60011FA")]
			[Address(RVA = "0x12798AC", Offset = "0x12798AC", VA = "0x12798AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011FB")]
			[Address(RVA = "0x12798B4", Offset = "0x12798B4", VA = "0x12798B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700046D")]
		public StatementEffect Effect
		{
			[Token(Token = "0x60011FD")]
			[Address(RVA = "0x12798C4", Offset = "0x12798C4", VA = "0x12798C4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011FE")]
			[Address(RVA = "0x12798CC", Offset = "0x12798CC", VA = "0x12798CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700046E")]
		public IList<ActionIdentifier> Actions
		{
			[Token(Token = "0x60011FF")]
			[Address(RVA = "0x12798D4", Offset = "0x12798D4", VA = "0x12798D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001200")]
			[Address(RVA = "0x12798DC", Offset = "0x12798DC", VA = "0x12798DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700046F")]
		public IList<Resource> Resources
		{
			[Token(Token = "0x6001202")]
			[Address(RVA = "0x1279A6C", Offset = "0x1279A6C", VA = "0x1279A6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001203")]
			[Address(RVA = "0x1279A74", Offset = "0x1279A74", VA = "0x1279A74")]
			set
			{
			}
		}

		[Token(Token = "0x17000470")]
		public IList<Condition> Conditions
		{
			[Token(Token = "0x6001205")]
			[Address(RVA = "0x1279C04", Offset = "0x1279C04", VA = "0x1279C04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001206")]
			[Address(RVA = "0x1279C0C", Offset = "0x1279C0C", VA = "0x1279C0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000471")]
		public IList<Principal> Principals
		{
			[Token(Token = "0x6001208")]
			[Address(RVA = "0x1279D9C", Offset = "0x1279D9C", VA = "0x1279D9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001209")]
			[Address(RVA = "0x1279DA4", Offset = "0x1279DA4", VA = "0x1279DA4")]
			set
			{
			}
		}

		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x12796B4", Offset = "0x12796B4", VA = "0x12796B4")]
		public Statement(StatementEffect effect)
		{
		}

		[Token(Token = "0x60011FC")]
		[Address(RVA = "0x12798BC", Offset = "0x12798BC", VA = "0x12798BC")]
		public Statement WithId(string id)
		{
			return null;
		}

		[Token(Token = "0x6001201")]
		[Address(RVA = "0x12798E4", Offset = "0x12798E4", VA = "0x12798E4")]
		public Statement WithActionIdentifiers(params ActionIdentifier[] actions)
		{
			return null;
		}

		[Token(Token = "0x6001204")]
		[Address(RVA = "0x1279A7C", Offset = "0x1279A7C", VA = "0x1279A7C")]
		public Statement WithResources(params Resource[] resources)
		{
			return null;
		}

		[Token(Token = "0x6001207")]
		[Address(RVA = "0x1279C14", Offset = "0x1279C14", VA = "0x1279C14")]
		public Statement WithConditions(params Condition[] conditions)
		{
			return null;
		}

		[Token(Token = "0x600120A")]
		[Address(RVA = "0x1279DAC", Offset = "0x1279DAC", VA = "0x1279DAC")]
		public Statement WithPrincipals(params Principal[] principals)
		{
			return null;
		}
	}
}
