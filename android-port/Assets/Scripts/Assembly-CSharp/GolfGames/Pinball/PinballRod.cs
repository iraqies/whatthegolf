using Il2CppDummyDll;
using UnityEngine;

namespace GolfGames.Pinball
{
	[Token(Token = "0x20010B3")]
	public class PinballRod : MonoBehaviour
	{
		[Token(Token = "0x40057F2")]
		[FieldOffset(Offset = "0x18")]
		public bool ModifyScaleWhenHit;

		[Token(Token = "0x40057F3")]
		[FieldOffset(Offset = "0x20")]
		private AudioSource source;

		[Token(Token = "0x40057F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float vel;

		[Token(Token = "0x6004AD9")]
		[Address(RVA = "0x15E2990", Offset = "0x15E2990", VA = "0x15E2990")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004ADA")]
		[Address(RVA = "0x15E29EC", Offset = "0x15E29EC", VA = "0x15E29EC")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6004ADB")]
		[Address(RVA = "0x15E2BC8", Offset = "0x15E2BC8", VA = "0x15E2BC8")]
		public PinballRod()
		{
		}

		[Token(Token = "0x6004ADC")]
		[Address(RVA = "0x15E2BD8", Offset = "0x15E2BD8", VA = "0x15E2BD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F774", Offset = "0x6F774")]
		private void _003COnCollisionEnter2D_003Eb__4_0(float t)
		{
		}
	}
}
