using Il2CppDummyDll;
using UnityEngine;

namespace BeatFighter
{
	[Token(Token = "0x20010E3")]
	public class ActionIndicator : MonoBehaviour
	{
		[Token(Token = "0x20010E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47BB4", Offset = "0x47BB4")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x4005904")]
			[FieldOffset(Offset = "0x10")]
			public Material material;

			[Token(Token = "0x4005905")]
			[FieldOffset(Offset = "0x18")]
			public Color color;

			[Token(Token = "0x4005906")]
			[FieldOffset(Offset = "0x28")]
			public ActionIndicator _003C_003E4__this;

			[Token(Token = "0x4005907")]
			[FieldOffset(Offset = "0x30")]
			public Vector3 scale;

			[Token(Token = "0x6004BAA")]
			[Address(RVA = "0x17686BC", Offset = "0x17686BC", VA = "0x17686BC")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6004BAB")]
			[Address(RVA = "0x17686C4", Offset = "0x17686C4", VA = "0x17686C4")]
			internal void _003CPlayHitEffect_003Eb__0(float t)
			{
			}
		}

		[Token(Token = "0x4005900")]
		[FieldOffset(Offset = "0x18")]
		public GameObject arrowGameObject;

		[Token(Token = "0x4005901")]
		[FieldOffset(Offset = "0x20")]
		public Transform outlineTransform;

		[Token(Token = "0x4005902")]
		[FieldOffset(Offset = "0x28")]
		public Renderer outlineRenderer;

		[Token(Token = "0x4005903")]
		[FieldOffset(Offset = "0x30")]
		private float scaleupFactor;

		[Token(Token = "0x6004BA8")]
		[Address(RVA = "0x1404610", Offset = "0x1404610", VA = "0x1404610")]
		public void PlayHitEffect()
		{
		}

		[Token(Token = "0x6004BA9")]
		[Address(RVA = "0x140477C", Offset = "0x140477C", VA = "0x140477C")]
		public ActionIndicator()
		{
		}
	}
}
