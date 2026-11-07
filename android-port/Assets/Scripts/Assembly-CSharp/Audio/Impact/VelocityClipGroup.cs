using System;
using Il2CppDummyDll;

namespace Audio.Impact
{
	[Serializable]
	[Token(Token = "0x2001410")]
	public class VelocityClipGroup
	{
		[Token(Token = "0x4006BA2")]
		[FieldOffset(Offset = "0x10")]
		public IgnoreCurve ignoreCurve;

		[Token(Token = "0x4006BA3")]
		[FieldOffset(Offset = "0x14")]
		public float minVelocityNormalized;

		[Token(Token = "0x4006BA4")]
		[FieldOffset(Offset = "0x18")]
		public float maxVelocityNormalized;

		[Token(Token = "0x4006BA5")]
		[FieldOffset(Offset = "0x20")]
		public AudioEventAsset asset;

		[Token(Token = "0x4006BA6")]
		[FieldOffset(Offset = "0x28")]
		public ClipSettingsCollection collection;

		[Token(Token = "0x6005D54")]
		[Address(RVA = "0x174A3AC", Offset = "0x174A3AC", VA = "0x174A3AC")]
		public VelocityClipGroup()
		{
		}

		[Token(Token = "0x6005D55")]
		[Address(RVA = "0x174A3B4", Offset = "0x174A3B4", VA = "0x174A3B4")]
		public VelocityClipGroup(float minVelocityNormalized, float maxVelocityNormalized)
		{
		}
	}
}
