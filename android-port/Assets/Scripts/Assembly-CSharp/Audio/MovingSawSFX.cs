using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200133C")]
	public class MovingSawSFX : MonoBehaviour
	{
		[Token(Token = "0x40066E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClipSettingsCollection sfxOnTurn;

		[Token(Token = "0x40066E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource loopAudioSource;

		[Token(Token = "0x40066E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MovingPlatform movingPlatform;

		[Token(Token = "0x40066EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float randomPitchRange;

		[Token(Token = "0x60059B8")]
		[Address(RVA = "0x1578310", Offset = "0x1578310", VA = "0x1578310")]
		private void Awake()
		{
		}

		[Token(Token = "0x60059B9")]
		[Address(RVA = "0x1578490", Offset = "0x1578490", VA = "0x1578490")]
		private void OnTurn()
		{
		}

		[Token(Token = "0x60059BA")]
		[Address(RVA = "0x15784D8", Offset = "0x15784D8", VA = "0x15784D8")]
		public MovingSawSFX()
		{
		}
	}
}
