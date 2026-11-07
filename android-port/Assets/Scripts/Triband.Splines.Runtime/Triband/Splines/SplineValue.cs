using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Token(Token = "0x2000009")]
	public struct SplineValue
	{
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x0")]
		public readonly Vector3 position;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xC")]
		public readonly Quaternion rotation;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x1C")]
		public readonly Vector3 normal;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x28")]
		public readonly Vector3 tangent;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x34")]
		public readonly Vector3 binormal;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B023C", Offset = "0x1B023C")]
		private float t__BackingField;

		[Token(Token = "0x1700001E")]
		public float t
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x2A0D2F8", Offset = "0x2A0D2F8", VA = "0x2A0D2F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B072C", Offset = "0x1B072C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x2A0D300", Offset = "0x2A0D300", VA = "0x2A0D300")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B073C", Offset = "0x1B073C")]
			internal set
			{
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2A0ABD0", Offset = "0x2A0ABD0", VA = "0x2A0ABD0")]
		public SplineValue(Vector3 position, Quaternion rotation, Vector3 normal, Vector3 tangent, Vector3 binormal)
		{
		}
	}
}
