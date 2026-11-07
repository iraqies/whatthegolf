using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000045")]
	public class CSMConfig
	{
		[Token(Token = "0x4000150")]
		internal const string DEFAULT_HOST = "127.0.0.1";

		[Token(Token = "0x4000151")]
		internal const int DEFAULT_PORT = 31000;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x262B8", Offset = "0x262B8")]
		private string CSMHost__BackingField;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x262C8", Offset = "0x262C8")]
		private int CSMPort__BackingField;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x262D8", Offset = "0x262D8")]
		private string CSMClientId__BackingField;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x262E8", Offset = "0x262E8")]
		private bool? CSMEnabled__BackingField;

		[Token(Token = "0x1700009B")]
		public string CSMHost
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x11DA654", Offset = "0x11DA654", VA = "0x11DA654")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28110", Offset = "0x28110")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x11DA65C", Offset = "0x11DA65C", VA = "0x11DA65C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28120", Offset = "0x28120")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public int CSMPort
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x11DA664", Offset = "0x11DA664", VA = "0x11DA664")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28130", Offset = "0x28130")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x11DA66C", Offset = "0x11DA66C", VA = "0x11DA66C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28140", Offset = "0x28140")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public string CSMClientId
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x11DA674", Offset = "0x11DA674", VA = "0x11DA674")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28150", Offset = "0x28150")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x11DA67C", Offset = "0x11DA67C", VA = "0x11DA67C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28160", Offset = "0x28160")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public bool? CSMEnabled
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x11DA684", Offset = "0x11DA684", VA = "0x11DA684")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28170", Offset = "0x28170")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x11DA68C", Offset = "0x11DA68C", VA = "0x11DA68C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28180", Offset = "0x28180")]
			set
			{
			}
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x11DA694", Offset = "0x11DA694", VA = "0x11DA694")]
		public CSMConfig()
		{
		}
	}
}
