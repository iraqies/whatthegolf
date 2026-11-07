using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	[Serializable]
	public class LevelData : ScriptableObject
	{
		[Serializable]
		public class MapPositionData
		{
			public enum AngleOptions
			{
				RelativeForward = 0,
				RelativeLeft = 1,
				RelativeRight = 2,
				UseScene = 3
			}

			public AngleOptions currentAngle;

			public float distance;
		}

		public enum WindowType
		{
			Normal = 0,
			TwoD = 1
		}

		[Serializable]
		public class LevelCollectable
		{
			public Collectable Collectable;

			public List<string> IDs;
		}

		[Serializable]
		public class ChallengeData
		{
			public string ID;

			public string LocalizationID;

			public Sprite Icon;
		}

		[SerializeField]
		public bool skipPopup;

		[SerializeField]
		public string ID;

		[SerializeField]
		private MapPositionData mapPosition;

		public MusicData showcaseMusic;

		public LevelMusicSettings music;

		[SerializeField]
		public int StrokesToPar;

		[SerializeField]
		public string Pun;

		[SerializeField]
		public string completionID;

		[SerializeField]
		public string CompletionText;

		[SerializeField]
		public SceneField Scene;

		[SerializeField]
		private WindowType window;

		public static string bestScoreID;

		public static string levelEventsID;

		[SerializeField]
		public List<LevelCollectable> levelCollectables;

		[SerializeField]
		public List<ChallengeData> levelChallenges;

		private List<string> _levelChallengeIds;

		[SerializeField]
		public bool isShowingFlipText;

		[SerializeField]
		public bool isBossBattle;

		[SerializeField]
		public bool usedInDailyChallenges;

		[SerializeField]
		public bool userCustomTransitionColor;

		[SerializeField]
		public Color customTransitionColor;

		[SerializeField]
		public bool useCustomTransitionEffect;

		[SerializeField]
		public Transition.TransitionEffect customTransitionEffectIndex;

		[SerializeField]
		private int WeightInt;

		private string convertedLevelId;

		public MapPositionData MapPosition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public WindowType LevelWindowType => WindowType.Normal;

		public int BestScore
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<string> CompletedChallenges
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsCompletedInSaveGame
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string SceneName => null;

		public List<string> LevelChallengeIds()
		{
			return null;
		}

		public void HandleSceneDataUpdate(Dictionary<string, float> data)
		{
		}

		public void DeleteData()
		{
		}

		public WindowType GetWindowType()
		{
			return WindowType.Normal;
		}

		public string GetID()
		{
			return null;
		}

		public string GetCompletionTextID()
		{
			return null;
		}

		public string GetWeightID()
		{
			return null;
		}

		public List<string> GetChallengeLocalizationIDs()
		{
			return null;
		}

		public bool HasCompletedAllChallenges()
		{
			return false;
		}

		public int GetCurrentChallengeIndex()
		{
			return 0;
		}

		public void ZeroWeight()
		{
		}

		public void IncrementWeight()
		{
		}

		public void DeleteWeight()
		{
		}

		public void ResetWeight()
		{
		}

		public int GetActualWeight()
		{
			return 0;
		}
	}
}
