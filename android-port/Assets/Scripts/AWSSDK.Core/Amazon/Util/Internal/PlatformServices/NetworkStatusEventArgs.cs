using System;
using Il2CppDummyDll;

namespace Amazon.Util.Internal.PlatformServices
{
	[Token(Token = "0x2000090")]
	public class NetworkStatusEventArgs : EventArgs
	{
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26688", Offset = "0x26688")]
		private NetworkStatus Status__BackingField;

		[Token(Token = "0x1700014F")]
		public NetworkStatus Status
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x1243258", Offset = "0x1243258", VA = "0x1243258")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2896C", Offset = "0x2896C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1243260", Offset = "0x1243260", VA = "0x1243260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2897C", Offset = "0x2897C")]
			private set
			{
			}
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1243268", Offset = "0x1243268", VA = "0x1243268")]
		public NetworkStatusEventArgs(NetworkStatus status)
		{
		}
	}
}
