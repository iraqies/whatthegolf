using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001348")]
	public class AutoRunnerSFX : MonoBehaviour
	{
		[Token(Token = "0x400673C")]
		[FieldOffset(Offset = "0x18")]
		public Runner runner;

		[Token(Token = "0x400673D")]
		[FieldOffset(Offset = "0x20")]
		public PlayAudioClipsByFrequency player;

		[Token(Token = "0x6005A06")]
		[Address(RVA = "0x1515174", Offset = "0x1515174", VA = "0x1515174")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A07")]
		[Address(RVA = "0x1515258", Offset = "0x1515258", VA = "0x1515258")]
		private void OnRunnerChangeState(Runner.RunnerState state)
		{
		}

		[Token(Token = "0x6005A08")]
		[Address(RVA = "0x1515320", Offset = "0x1515320", VA = "0x1515320")]
		public AutoRunnerSFX()
		{
		}
	}
}
