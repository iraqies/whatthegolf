using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x20013F6")]
	public class OverworldMainComputerRumble : MonoBehaviour
	{
		[Token(Token = "0x4006B40")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RumbleEventAsset explosionRumble;

		[Token(Token = "0x6005CFA")]
		[Address(RVA = "0x15BD484", Offset = "0x15BD484", VA = "0x15BD484")]
		public void PlayExplosion()
		{
		}

		[Token(Token = "0x6005CFB")]
		[Address(RVA = "0x15BD488", Offset = "0x15BD488", VA = "0x15BD488")]
		public OverworldMainComputerRumble()
		{
		}
	}
}
