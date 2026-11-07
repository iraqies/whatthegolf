using System;
using Il2CppDummyDll;

namespace Audio
{
	[Serializable]
	[Token(Token = "0x20013B5")]
	public struct AudioAttribute
	{
		[Token(Token = "0x4006A18")]
		[FieldOffset(Offset = "0x0")]
		public float Value;

		[Token(Token = "0x4006A19")]
		[FieldOffset(Offset = "0x8")]
		public MinMax RandomRange;

		[Token(Token = "0x17000A5F")]
		public float GetResult
		{
			[Token(Token = "0x6005C04")]
			[Address(RVA = "0x142C258", Offset = "0x142C258", VA = "0x142C258")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C03")]
		[Address(RVA = "0x142C1CC", Offset = "0x142C1CC", VA = "0x142C1CC")]
		public AudioAttribute(float val, float min, float max)
		{
		}
	}
}
