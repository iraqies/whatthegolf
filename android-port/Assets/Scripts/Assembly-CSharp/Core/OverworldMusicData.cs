using System;
using UnityEngine;

namespace Core
{
	[Serializable]
	public class OverworldMusicData : ScriptableObject
	{
		public LevelMusicSettings withoutTransition;

		public LevelMusicSettings withTransition;

		public float RTCPMax;

		public float RTCPMin;

		public float wwiseThreshold;
	}
}
