using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x200004B")]
	public class AWSPublicIpAddressRange
	{
		[Token(Token = "0x200004C")]
		public enum AddressFormat
		{
			[Token(Token = "0x4000173")]
			Ipv4 = 0,
			[Token(Token = "0x4000174")]
			Ipv6 = 1
		}

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26318", Offset = "0x26318")]
		private string IpPrefix__BackingField;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26328", Offset = "0x26328")]
		private AddressFormat IpAddressFormat__BackingField;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26338", Offset = "0x26338")]
		private string Region__BackingField;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26348", Offset = "0x26348")]
		private string Service__BackingField;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26358", Offset = "0x26358")]
		private string NetworkBorderGroup__BackingField;

		[Token(Token = "0x170000A2")]
		public string IpPrefix
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x11C18AC", Offset = "0x11C18AC", VA = "0x11C18AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x281D0", Offset = "0x281D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x11C18B4", Offset = "0x11C18B4", VA = "0x11C18B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x281E0", Offset = "0x281E0")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public AddressFormat IpAddressFormat
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x11C18BC", Offset = "0x11C18BC", VA = "0x11C18BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x281F0", Offset = "0x281F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x11C18C4", Offset = "0x11C18C4", VA = "0x11C18C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28200", Offset = "0x28200")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public string Region
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x11C18CC", Offset = "0x11C18CC", VA = "0x11C18CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28210", Offset = "0x28210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x11C18D4", Offset = "0x11C18D4", VA = "0x11C18D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28220", Offset = "0x28220")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public string Service
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x11C18DC", Offset = "0x11C18DC", VA = "0x11C18DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28230", Offset = "0x28230")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x11C18E4", Offset = "0x11C18E4", VA = "0x11C18E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28240", Offset = "0x28240")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public string NetworkBorderGroup
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x11C18EC", Offset = "0x11C18EC", VA = "0x11C18EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28250", Offset = "0x28250")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x11C18F4", Offset = "0x11C18F4", VA = "0x11C18F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28260", Offset = "0x28260")]
			internal set
			{
			}
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x11C18FC", Offset = "0x11C18FC", VA = "0x11C18FC")]
		public AWSPublicIpAddressRange()
		{
		}
	}
}
