using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColors : ScriptableObject
{
	public enum AvatarIDs
	{
		All = 0,
		Toaster = 1,
		HockeyDog = 2,
		BurgerBird = 3,
		BabyVike = 4
	}

	[Serializable]
	public class AvatarData
	{
		public AvatarIDs AvatarID;

		public string NameID;

		public bool UnlockedAtStart;

		public Color BaseColor;

		public Color ArrowColor;

		public Color ArrowColorMin;

		public Color StrokeCounterColor;

		public Color IntroBackgroundColor;
	}

	public List<AvatarData> Avatars;
}
