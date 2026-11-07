using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200139F")]
	public class PlayAudioSourceOnPull : MonoBehaviour
	{
		[Token(Token = "0x400697B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x400697C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GolfBallController controller;

		[Token(Token = "0x400697D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool pauseOnStopAim;

		[Token(Token = "0x400697E")]
		[FieldOffset(Offset = "0x2C")]
		private int lastSampleTime;

		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0x15E9754", Offset = "0x15E9754", VA = "0x15E9754")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B9F")]
		[Address(RVA = "0x15E9908", Offset = "0x15E9908", VA = "0x15E9908")]
		private void Controller_OnCancel()
		{
		}

		[Token(Token = "0x6005BA0")]
		[Address(RVA = "0x15E99D8", Offset = "0x15E99D8", VA = "0x15E99D8")]
		private void Controller_OnPreShoot(Vector3 obj)
		{
		}

		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0x15E9AA8", Offset = "0x15E9AA8", VA = "0x15E9AA8")]
		private void Controller_OnAimStart()
		{
		}

		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0x15E9B8C", Offset = "0x15E9B8C", VA = "0x15E9B8C")]
		public PlayAudioSourceOnPull()
		{
		}
	}
}
