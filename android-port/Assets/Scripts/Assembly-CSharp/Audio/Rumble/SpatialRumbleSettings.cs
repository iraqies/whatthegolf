using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x2001404")]
	public class SpatialRumbleSettings : MonoBehaviour
	{
		[Token(Token = "0x4006B74")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Component audioEventComponent;

		[Token(Token = "0x4006B75")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RumbleEventAsset rumbleSettings;

		[Token(Token = "0x4006B76")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float range;

		[Token(Token = "0x4006B77")]
		[FieldOffset(Offset = "0x30")]
		private IAudioEvent _event;

		[Token(Token = "0x17000A8B")]
		public float Range
		{
			[Token(Token = "0x6005D2B")]
			[Address(RVA = "0x16C4664", Offset = "0x16C4664", VA = "0x16C4664")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A8C")]
		public RumbleEventAsset RumbleSettings
		{
			[Token(Token = "0x6005D2C")]
			[Address(RVA = "0x16C466C", Offset = "0x16C466C", VA = "0x16C466C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D2D")]
		[Address(RVA = "0x16C4674", Offset = "0x16C4674", VA = "0x16C4674")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005D2E")]
		[Address(RVA = "0x16C48A4", Offset = "0x16C48A4", VA = "0x16C48A4")]
		private void OnAudioEvent(Vector3 obj)
		{
		}

		[Token(Token = "0x6005D2F")]
		[Address(RVA = "0x16C48BC", Offset = "0x16C48BC", VA = "0x16C48BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6005D30")]
		[Address(RVA = "0x16C490C", Offset = "0x16C490C", VA = "0x16C490C")]
		public SpatialRumbleSettings()
		{
		}
	}
}
