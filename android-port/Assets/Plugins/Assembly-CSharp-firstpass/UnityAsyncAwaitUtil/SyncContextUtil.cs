using System.Threading;
using Il2CppDummyDll;

namespace UnityAsyncAwaitUtil
{
	[Token(Token = "0x20002C9")]
	public static class SyncContextUtil
	{
		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x375D0", Offset = "0x375D0")]
		private static int UnityThreadId__BackingField;

		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x375E0", Offset = "0x375E0")]
		private static SynchronizationContext UnitySynchronizationContext__BackingField;

		[Token(Token = "0x1700027A")]
		public static int UnityThreadId
		{
			[Token(Token = "0x60012AC")]
			[Address(RVA = "0x131800C", Offset = "0x131800C", VA = "0x131800C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BC60", Offset = "0x3BC60")]
			get
			{
				return default;
			}
			[Token(Token = "0x60012AD")]
			[Address(RVA = "0x1318058", Offset = "0x1318058", VA = "0x1318058")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BC70", Offset = "0x3BC70")]
			private set
			{
			}
		}

		[Token(Token = "0x1700027B")]
		public static SynchronizationContext UnitySynchronizationContext
		{
			[Token(Token = "0x60012AE")]
			[Address(RVA = "0x13180B0", Offset = "0x13180B0", VA = "0x13180B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BC80", Offset = "0x3BC80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012AF")]
			[Address(RVA = "0x13180FC", Offset = "0x13180FC", VA = "0x13180FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BC90", Offset = "0x3BC90")]
			private set
			{
			}
		}

		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x1317F64", Offset = "0x1317F64", VA = "0x1317F64")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x3BC4C", Offset = "0x3BC4C")]
		private static void Install()
		{
		}
	}
}
