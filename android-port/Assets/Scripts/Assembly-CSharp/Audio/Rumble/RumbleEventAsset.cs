using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x20013F9")]
	public class RumbleEventAsset : ScriptableObject
	{
		[Token(Token = "0x4006B44")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x5ABC4", Offset = "0x5ABC4")]
		private float cooldown;

		[Token(Token = "0x4006B45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RumbleCollection rumbleCollection;

		[Token(Token = "0x4006B46")]
		[FieldOffset(Offset = "0x28")]
		private float _nextPlayTime;

		[Token(Token = "0x6005CFE")]
		[Address(RVA = "0x1661B1C", Offset = "0x1661B1C", VA = "0x1661B1C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005CFF")]
		[Address(RVA = "0x1661B24", Offset = "0x1661B24", VA = "0x1661B24")]
		public void Play(int playerIndex, float volume = 1f)
		{
		}

		[Token(Token = "0x6005D00")]
		[Address(RVA = "0x1661B28", Offset = "0x1661B28", VA = "0x1661B28")]
		public void PlaySpatial(SpatialRumbleSettings spatialSettings)
		{
		}

		[Token(Token = "0x6005D01")]
		[Address(RVA = "0x1661B2C", Offset = "0x1661B2C", VA = "0x1661B2C")]
		public void PlaySpatial(Vector3 position, float range)
		{
		}

		[Token(Token = "0x6005D02")]
		[Address(RVA = "0x1661B30", Offset = "0x1661B30", VA = "0x1661B30")]
		public void PlayOnAllDevices(float volume = 1f)
		{
		}

		[Token(Token = "0x6005D03")]
		[Address(RVA = "0x1661B38", Offset = "0x1661B38", VA = "0x1661B38")]
		public RumbleEventAsset()
		{
		}
	}
}
