using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013AE")]
	public class SoccerPlayerAudio : MonoBehaviour
	{
		[Token(Token = "0x40069FA")]
		[FieldOffset(Offset = "0x18")]
		public SoccerPlayer soccerPlayer;

		[Token(Token = "0x40069FB")]
		[FieldOffset(Offset = "0x20")]
		public AudioSource gruntLoopAudioSource;

		[Token(Token = "0x40069FC")]
		[FieldOffset(Offset = "0x28")]
		public ClipSettingsCollection sfxGruntOnKick;

		[Token(Token = "0x40069FD")]
		[FieldOffset(Offset = "0x30")]
		public ClipSettingsCollection sfxKickSfx;

		[Token(Token = "0x6005BE8")]
		[Address(RVA = "0x16BF808", Offset = "0x16BF808", VA = "0x16BF808")]
		private void Start()
		{
		}

		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0x16BF91C", Offset = "0x16BF91C", VA = "0x16BF91C")]
		private void OnSoccerPlayerKick()
		{
		}

		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0x16BF99C", Offset = "0x16BF99C", VA = "0x16BF99C")]
		public SoccerPlayerAudio()
		{
		}
	}
}
