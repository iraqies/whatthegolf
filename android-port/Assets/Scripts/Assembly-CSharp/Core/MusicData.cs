using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Serializable]
	[Token(Token = "0x2001465")]
	public class MusicData : ScriptableObject
	{
		[Token(Token = "0x2001466")]
		public enum ClosingInState
		{
			[Token(Token = "0x4006FB1")]
			distance = 0,
			[Token(Token = "0x4006FB2")]
			velocity = 1,
			[Token(Token = "0x4006FB3")]
			custom = 2
		}

		[Token(Token = "0x4006FA0")]
		[FieldOffset(Offset = "0x18")]
		public uint state;

		[Token(Token = "0x4006FA1")]
		[FieldOffset(Offset = "0x1C")]
		public uint rtcp;

		[Token(Token = "0x4006FA2")]
		[FieldOffset(Offset = "0x20")]
		public bool isPlayingTransition;

		[Token(Token = "0x4006FA3")]
		[FieldOffset(Offset = "0x21")]
		public bool useFirstStrokeTrigger;

		[Token(Token = "0x4006FA4")]
		[FieldOffset(Offset = "0x24")]
		public float firstStrokeTriggerCooldown;

		[Token(Token = "0x4006FA5")]
		[FieldOffset(Offset = "0x28")]
		public uint triggerFirstShot;

		[Token(Token = "0x4006FA6")]
		[FieldOffset(Offset = "0x2C")]
		public float basicLayerVolumeMultiplier;

		[Token(Token = "0x4006FA7")]
		[FieldOffset(Offset = "0x30")]
		public uint rtcpClosingIn;

		[Token(Token = "0x4006FA8")]
		[FieldOffset(Offset = "0x34")]
		public uint triggerAdditionalShots;

		[Token(Token = "0x4006FA9")]
		[FieldOffset(Offset = "0x38")]
		public float cooldownBetweenShotTriggers;

		[Token(Token = "0x4006FAA")]
		[FieldOffset(Offset = "0x3C")]
		public uint rtcpAiming;

		[Token(Token = "0x4006FAB")]
		[FieldOffset(Offset = "0x40")]
		public bool useFirstStrokeOnGoal;

		[Token(Token = "0x4006FAC")]
		[FieldOffset(Offset = "0x44")]
		public ClosingInState closingIn;

		[Token(Token = "0x4006FAD")]
		[FieldOffset(Offset = "0x48")]
		public float closingInFullVolumeThreshold;

		[Token(Token = "0x4006FAE")]
		[FieldOffset(Offset = "0x4C")]
		public float closingInLayerVolumeMultiplier;

		[Token(Token = "0x4006FAF")]
		[FieldOffset(Offset = "0x50")]
		public float thirdLayerVolumeMultiplier;

		[Token(Token = "0x6005FF0")]
		[Address(RVA = "0x1585EBC", Offset = "0x1585EBC", VA = "0x1585EBC")]
		public MusicData()
		{
		}
	}
}
