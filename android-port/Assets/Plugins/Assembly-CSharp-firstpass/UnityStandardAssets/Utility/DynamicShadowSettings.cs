using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200004B")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1365FEC", Offset = "0x1365FEC", VA = "0x1365FEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1366020", Offset = "0x1366020", VA = "0x1366020")]
		private void Update()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x13661CC", Offset = "0x13661CC", VA = "0x13661CC")]
		public DynamicShadowSettings()
		{
		}
	}
}
