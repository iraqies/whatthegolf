using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000C1")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x183E90", Offset = "0x183E90")]
	[Attribute(Name = "NullableAttribute", RVA = "0x183E90", Offset = "0x183E90")]
	public abstract class NamingStrategy
	{
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187FC0", Offset = "0x187FC0")]
		private bool ProcessDictionaryKeys__BackingField;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x11")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187FD0", Offset = "0x187FD0")]
		private bool ProcessExtensionDataNames__BackingField;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x12")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x187FE0", Offset = "0x187FE0")]
		private bool OverrideSpecifiedNames__BackingField;

		[Token(Token = "0x170000ED")]
		public bool ProcessDictionaryKeys
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x231C298", Offset = "0x231C298", VA = "0x231C298")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A36C", Offset = "0x18A36C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x231C2A0", Offset = "0x231C2A0", VA = "0x231C2A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A37C", Offset = "0x18A37C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public bool ProcessExtensionDataNames
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x231C2A8", Offset = "0x231C2A8", VA = "0x231C2A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A38C", Offset = "0x18A38C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x231C2B0", Offset = "0x231C2B0", VA = "0x231C2B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A39C", Offset = "0x18A39C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public bool OverrideSpecifiedNames
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x231C2B8", Offset = "0x231C2B8", VA = "0x231C2B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A3AC", Offset = "0x18A3AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x231C2C0", Offset = "0x231C2C0", VA = "0x231C2C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A3BC", Offset = "0x18A3BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x231C2C8", Offset = "0x231C2C8", VA = "0x231C2C8", Slot = "4")]
		public virtual string GetPropertyName(string name, bool hasSpecifiedName)
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x231C2EC", Offset = "0x231C2EC", VA = "0x231C2EC", Slot = "5")]
		public virtual string GetExtensionDataName(string name)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x231C30C", Offset = "0x231C30C", VA = "0x231C30C", Slot = "6")]
		public virtual string GetDictionaryKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		protected abstract string ResolvePropertyName(string name);

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x231C32C", Offset = "0x231C32C", VA = "0x231C32C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x231C3DC", Offset = "0x231C3DC", VA = "0x231C3DC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x231C46C", Offset = "0x231C46C", VA = "0x231C46C")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18A3CC", Offset = "0x18A3CC")]
		protected bool Equals(NamingStrategy other)
		{
			return default;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x231A018", Offset = "0x231A018", VA = "0x231A018")]
		protected NamingStrategy()
		{
		}
	}
}
