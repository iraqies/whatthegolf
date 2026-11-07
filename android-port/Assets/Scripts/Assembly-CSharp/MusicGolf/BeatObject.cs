using Il2CppDummyDll;
using UnityEngine;

namespace MusicGolf
{
	[Token(Token = "0x20010B6")]
	public class BeatObject : MonoBehaviour
	{
		[Token(Token = "0x4005806")]
		[FieldOffset(Offset = "0x18")]
		public int Beat;

		[Token(Token = "0x4005807")]
		[FieldOffset(Offset = "0x1C")]
		public int Duration;

		[Token(Token = "0x4005808")]
		[FieldOffset(Offset = "0x20")]
		public AudioSource StartClip;

		[Token(Token = "0x4005809")]
		[FieldOffset(Offset = "0x28")]
		public AudioSource StopClip;

		[Token(Token = "0x400580A")]
		[FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x400580B")]
		[FieldOffset(Offset = "0x31")]
		public bool IsPlaying;

		[Token(Token = "0x400580C")]
		[FieldOffset(Offset = "0x38")]
		public double LastStartTime;

		[Token(Token = "0x6004AE7")]
		[Address(RVA = "0x160D3E8", Offset = "0x160D3E8", VA = "0x160D3E8", Slot = "4")]
		public virtual void PlayStart()
		{
		}

		[Token(Token = "0x6004AE8")]
		[Address(RVA = "0x160D3EC", Offset = "0x160D3EC", VA = "0x160D3EC", Slot = "5")]
		public virtual void PlayProgress(float t)
		{
		}

		[Token(Token = "0x6004AE9")]
		[Address(RVA = "0x160D3F0", Offset = "0x160D3F0", VA = "0x160D3F0", Slot = "6")]
		public virtual void PlayStop()
		{
		}

		[Token(Token = "0x6004AEA")]
		[Address(RVA = "0x160D3F4", Offset = "0x160D3F4", VA = "0x160D3F4")]
		public BeatObject()
		{
		}
	}
}
