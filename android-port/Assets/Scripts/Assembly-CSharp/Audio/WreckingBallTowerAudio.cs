using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013E5")]
	public class WreckingBallTowerAudio : MonoBehaviour
	{
		[Token(Token = "0x4006B0A")]
		[FieldOffset(Offset = "0x18")]
		public IntroLoopOutro rotationAudio;

		[Token(Token = "0x4006B0B")]
		[FieldOffset(Offset = "0x20")]
		public AudioValueRigidbody rotationValue;

		[Token(Token = "0x4006B0C")]
		[FieldOffset(Offset = "0x28")]
		public float timeToStartLoop;

		[Token(Token = "0x4006B0D")]
		[FieldOffset(Offset = "0x2C")]
		public float minValue;

		[Token(Token = "0x4006B0E")]
		[FieldOffset(Offset = "0x30")]
		public float maxValue;

		[Token(Token = "0x4006B0F")]
		[FieldOffset(Offset = "0x34")]
		public float timeToEndLoop;

		[Token(Token = "0x4006B10")]
		[FieldOffset(Offset = "0x38")]
		public Transform Extendable;

		[Token(Token = "0x4006B11")]
		[FieldOffset(Offset = "0x40")]
		public AudioSource extendableSource;

		[Token(Token = "0x4006B12")]
		[FieldOffset(Offset = "0x48")]
		public float volume;

		[Token(Token = "0x4006B13")]
		[FieldOffset(Offset = "0x4C")]
		private float rot_value;

		[Token(Token = "0x4006B14")]
		[FieldOffset(Offset = "0x50")]
		private float offTimer;

		[Token(Token = "0x4006B15")]
		[FieldOffset(Offset = "0x54")]
		private float onTimer;

		[Token(Token = "0x4006B16")]
		[FieldOffset(Offset = "0x58")]
		private float ext_pos_Z;

		[Token(Token = "0x4006B17")]
		[FieldOffset(Offset = "0x5C")]
		private float ext_delta;

		[Token(Token = "0x4006B18")]
		[FieldOffset(Offset = "0x60")]
		private float ext_vol;

		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0x175B280", Offset = "0x175B280", VA = "0x175B280")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0x175B3A8", Offset = "0x175B3A8", VA = "0x175B3A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005CCB")]
		[Address(RVA = "0x175B4D0", Offset = "0x175B4D0", VA = "0x175B4D0")]
		private void OnRotationValueChange(float v)
		{
		}

		[Token(Token = "0x6005CCC")]
		[Address(RVA = "0x175B4D8", Offset = "0x175B4D8", VA = "0x175B4D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6005CCD")]
		[Address(RVA = "0x175B66C", Offset = "0x175B66C", VA = "0x175B66C")]
		public WreckingBallTowerAudio()
		{
		}
	}
}
