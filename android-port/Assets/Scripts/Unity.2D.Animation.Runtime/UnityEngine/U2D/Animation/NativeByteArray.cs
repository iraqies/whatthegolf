using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.U2D.Animation
{
	[Token(Token = "0x200000B")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x1B0900", Offset = "0x1B0900")]
	internal class NativeByteArray
	{
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B09B8", Offset = "0x1B09B8")]
		private readonly NativeArray<byte> array__BackingField;

		[Token(Token = "0x17000010")]
		public int Length
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2A0E634", Offset = "0x2A0E634", VA = "0x2A0E634")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000011")]
		public bool IsCreated
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2A0E63C", Offset = "0x2A0E63C", VA = "0x2A0E63C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000012")]
		public NativeArray<byte> array
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2A0E6A4", Offset = "0x2A0E6A4", VA = "0x2A0E6A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B09E8", Offset = "0x1B09E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2A0E6B0", Offset = "0x2A0E6B0", VA = "0x2A0E6B0")]
		public NativeByteArray(NativeArray<byte> array)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2A0E6E8", Offset = "0x2A0E6E8", VA = "0x2A0E6E8")]
		public void Dispose()
		{
		}
	}
}
