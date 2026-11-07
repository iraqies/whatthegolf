using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001373")]
	public class FlyoffAudio : MonoBehaviour
	{
		[Token(Token = "0x400683F")]
		[FieldOffset(Offset = "0x18")]
		public AudioSource audioSource;

		[Token(Token = "0x4006840")]
		[FieldOffset(Offset = "0x20")]
		public RandomAudioClips clips;

		[Token(Token = "0x4006841")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody rigid;

		[Token(Token = "0x4006842")]
		[FieldOffset(Offset = "0x30")]
		public Rigidbody2D rigid2D;

		[Token(Token = "0x4006843")]
		[FieldOffset(Offset = "0x38")]
		public float threshold;

		[Token(Token = "0x4006844")]
		[FieldOffset(Offset = "0x3C")]
		public float timeAboveThreshold;

		[Token(Token = "0x4006845")]
		[FieldOffset(Offset = "0x40")]
		private float timer;

		[Token(Token = "0x4006846")]
		[FieldOffset(Offset = "0x44")]
		private bool played;

		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0x146E61C", Offset = "0x146E61C", VA = "0x146E61C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0x146E79C", Offset = "0x146E79C", VA = "0x146E79C")]
		public FlyoffAudio()
		{
		}
	}
}
