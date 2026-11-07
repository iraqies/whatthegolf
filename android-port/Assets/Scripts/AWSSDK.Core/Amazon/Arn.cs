using System;
using Il2CppDummyDll;

namespace Amazon
{
	[Token(Token = "0x2000034")]
	public class Arn
	{
		[Serializable]
		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x256F4", Offset = "0x256F4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40000DC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40000DD")]
			[FieldOffset(Offset = "0x8")]
			public static Func<char, bool> _003C_003E9__15_0;

			[Token(Token = "0x6000216")]
			[Address(RVA = "0x1286FBC", Offset = "0x1286FBC", VA = "0x1286FBC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x1286FC4", Offset = "0x1286FC4", VA = "0x1286FC4")]
			internal bool _003Cset_AccountId_003Eb__15_0(char x)
			{
				return default;
			}
		}

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26108", Offset = "0x26108")]
		private string Partition__BackingField;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26118", Offset = "0x26118")]
		private string Service__BackingField;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26128", Offset = "0x26128")]
		private string Region__BackingField;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x28")]
		private string _accountId;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26138", Offset = "0x26138")]
		private string Resource__BackingField;

		[Token(Token = "0x17000061")]
		public string Partition
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x11CEB20", Offset = "0x11CEB20", VA = "0x11CEB20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27DB0", Offset = "0x27DB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x11CEB28", Offset = "0x11CEB28", VA = "0x11CEB28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27DC0", Offset = "0x27DC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public string Service
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x11CEB30", Offset = "0x11CEB30", VA = "0x11CEB30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27DD0", Offset = "0x27DD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x11CEB38", Offset = "0x11CEB38", VA = "0x11CEB38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27DE0", Offset = "0x27DE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public string Region
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x11CEB40", Offset = "0x11CEB40", VA = "0x11CEB40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27DF0", Offset = "0x27DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x11CEB48", Offset = "0x11CEB48", VA = "0x11CEB48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27E00", Offset = "0x27E00")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public string AccountId
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x11CEB50", Offset = "0x11CEB50", VA = "0x11CEB50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x11CEB58", Offset = "0x11CEB58", VA = "0x11CEB58")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public string Resource
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x11CED44", Offset = "0x11CED44", VA = "0x11CED44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27E10", Offset = "0x27E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x11CED4C", Offset = "0x11CED4C", VA = "0x11CED4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27E20", Offset = "0x27E20")]
			set
			{
			}
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x11CED54", Offset = "0x11CED54", VA = "0x11CED54")]
		public static bool IsArn(string arn)
		{
			return default;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x11CEDB8", Offset = "0x11CEDB8", VA = "0x11CEDB8")]
		public static bool TryParse(string arnString, out Arn arn)
		{
			return default;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x11CEEB4", Offset = "0x11CEEB4", VA = "0x11CEEB4")]
		public static Arn Parse(string arnString)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x11CF1D0", Offset = "0x11CF1D0", VA = "0x11CF1D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x11CF30C", Offset = "0x11CF30C", VA = "0x11CF30C", Slot = "0")]
		public override bool Equals(object o)
		{
			return default;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x11CF42C", Offset = "0x11CF42C", VA = "0x11CF42C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x11CF168", Offset = "0x11CF168", VA = "0x11CF168")]
		public Arn()
		{
		}
	}
}
