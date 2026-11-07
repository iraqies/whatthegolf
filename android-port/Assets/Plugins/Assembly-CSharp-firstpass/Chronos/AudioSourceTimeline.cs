using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002B0")]
	public class AudioSourceTimeline : ComponentTimeline<AudioSource>
	{
		[Token(Token = "0x400117E")]
		[FieldOffset(Offset = "0x20")]
		private float _pitch;

		[Token(Token = "0x17000244")]
		public float pitch
		{
			[Token(Token = "0x600120D")]
			[Address(RVA = "0x12F36A0", Offset = "0x12F36A0", VA = "0x12F36A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600120E")]
		[Address(RVA = "0x12F36A8", Offset = "0x12F36A8", VA = "0x12F36A8")]
		public AudioSourceTimeline(Timeline timeline, AudioSource component)
		{
		}

		[Token(Token = "0x600120F")]
		[Address(RVA = "0x12F3718", Offset = "0x12F3718", VA = "0x12F3718", Slot = "16")]
		public override void CopyProperties(AudioSource source)
		{
		}

		[Token(Token = "0x6001210")]
		[Address(RVA = "0x12F374C", Offset = "0x12F374C", VA = "0x12F374C", Slot = "17")]
		public override void AdjustProperties(float timeScale)
		{
		}
	}
}
