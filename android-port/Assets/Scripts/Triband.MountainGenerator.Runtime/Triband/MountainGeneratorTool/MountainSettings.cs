using Il2CppDummyDll;
using UnityEngine;

namespace Triband.MountainGeneratorTool
{
	[Token(Token = "0x2000005")]
	public sealed class MountainSettings : ScriptableObject
	{
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		public float TopBevelSize;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x1C")]
		public float TopBevelHeight;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		public float BottomBevelSize;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x24")]
		public float BottomBevelHeight;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x28")]
		public bool RoundCorners;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x2C")]
		public float Roundness;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1AFE84", Offset = "0x1AFE84")]
		public float CornerSize;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x38")]
		public Material TopMaterial;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x40")]
		public Material CornerMaterial;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x48")]
		public Material SidesMaterial;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x50")]
		public string Notes;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A01A48", Offset = "0x2A01A48", VA = "0x2A01A48")]
		public MountainSettings()
		{
		}
	}
}
