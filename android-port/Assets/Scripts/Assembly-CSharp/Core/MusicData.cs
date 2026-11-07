using System;
using UnityEngine;

namespace Core
{
	[Serializable]
	public class MusicData : ScriptableObject
	{
		public enum ClosingInState
		{
			distance = 0,
			velocity = 1,
			custom = 2
		}

		public uint state;

		public uint rtcp;

		public bool isPlayingTransition;

		public bool useFirstStrokeTrigger;

		public float firstStrokeTriggerCooldown;

		public uint triggerFirstShot;

		public float basicLayerVolumeMultiplier;

		public uint rtcpClosingIn;

		public uint triggerAdditionalShots;

		public float cooldownBetweenShotTriggers;

		public uint rtcpAiming;

		public bool useFirstStrokeOnGoal;

		public ClosingInState closingIn;

		public float closingInFullVolumeThreshold;

		public float closingInLayerVolumeMultiplier;

		public float thirdLayerVolumeMultiplier;
	}
}
