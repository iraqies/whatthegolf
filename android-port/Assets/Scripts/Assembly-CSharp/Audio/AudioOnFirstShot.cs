using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200139B")]
	public class AudioOnFirstShot : MonoBehaviour
	{
		[Token(Token = "0x4006948")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClipSettingsCollection clips;

		[Token(Token = "0x4006949")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GolfBallController controller;

		[Token(Token = "0x400694A")]
		[FieldOffset(Offset = "0x28")]
		private bool didShoot;

		[Token(Token = "0x6005B7A")]
		[Address(RVA = "0x1509FCC", Offset = "0x1509FCC", VA = "0x1509FCC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B7B")]
		[Address(RVA = "0x150A0DC", Offset = "0x150A0DC", VA = "0x150A0DC")]
		private void Controller_OnShoot(Vector3 obj)
		{
		}

		[Token(Token = "0x6005B7C")]
		[Address(RVA = "0x150A16C", Offset = "0x150A16C", VA = "0x150A16C")]
		public AudioOnFirstShot()
		{
		}
	}
}
