using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x2001400")]
	public class RumbleOnEvent : MonoBehaviour
	{
		[Token(Token = "0x4006B5E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Component audioEventComponent;

		[Token(Token = "0x4006B5F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RumbleEventAsset rumbleSettings;

		[Token(Token = "0x4006B60")]
		[FieldOffset(Offset = "0x28")]
		private IAudioEvent _event;

		[Token(Token = "0x6005D1F")]
		[Address(RVA = "0x16620A0", Offset = "0x16620A0", VA = "0x16620A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005D20")]
		[Address(RVA = "0x16622D0", Offset = "0x16622D0", VA = "0x16622D0")]
		private void OnAudioEvent(Vector3 obj)
		{
		}

		[Token(Token = "0x6005D21")]
		[Address(RVA = "0x16622D4", Offset = "0x16622D4", VA = "0x16622D4")]
		public RumbleOnEvent()
		{
		}
	}
}
