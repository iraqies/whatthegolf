using System;
using System.Collections.Generic;
using System.Linq;
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

		[SerializeField] public bool skipPopup;
		[SerializeField] public string ID;
		[SerializeField] private MapPositionData mapPosition;
		public MusicData showcaseMusic;
		public LevelMusicSettings music;
		[SerializeField] public int StrokesToPar = 3;
		[SerializeField] public string Pun;
		[SerializeField] public string completionID;
		[SerializeField] public string CompletionText;
		[SerializeField] public SceneField Scene;
		[SerializeField] private WindowType window;
		public static string bestScoreID = "_BEST_SCORE";
		public static string levelEventsID = "_EVENTS";
		[SerializeField] public List<LevelCollectable> levelCollectables = new List<LevelCollectable>();
		[SerializeField] public List<ChallengeData> levelChallenges = new List<ChallengeData>();
		private List<string> _levelChallengeIds;
		[SerializeField] public bool isShowingFlipText;
		[SerializeField] public bool isBossBattle;
		[SerializeField] public bool usedInDailyChallenges;
		[SerializeField] public bool userCustomTransitionColor;
		[SerializeField] public Color customTransitionColor = Color.white;
		[SerializeField] public bool useCustomTransitionEffect;
		[SerializeField] public Transition.TransitionEffect customTransitionEffectIndex;
		[SerializeField] private int WeightInt = 1;
		private string convertedLevelId;

		public MapPositionData MapPosition
		{
			get => mapPosition;
			set => mapPosition = value;
		}

		public WindowType LevelWindowType => window;

		public int BestScore
		{
			get => SaveGame.GetValue(GetID() + bestScoreID, 0);
			set => SaveGame.SetValue(GetID() + bestScoreID, value, true);
		}

		public List<string> CompletedChallenges
		{
			get => SaveGame.GetCompletedChallenges(LevelChallengeIds());
			set
			{
				if (value != null)
					SaveGame.AddCompletedChallenges(value);
			}
		}

		public bool IsCompletedInSaveGame
		{
			get => SaveGame.GetIsLevelCompleted(!string.IsNullOrEmpty(ID) ? ID : GetID());
			set
			{
				if (value) SaveGame.SetLevelCompleted(!string.IsNullOrEmpty(ID) ? ID : GetID());
			}
		}

		public string SceneName => Scene != null && !string.IsNullOrEmpty(Scene.SceneName) ? Scene.SceneName : name;

		public List<string> LevelChallengeIds()
		{
			if (_levelChallengeIds == null)
			{
				_levelChallengeIds = levelChallenges != null
					? levelChallenges.Where(c => c != null && !string.IsNullOrEmpty(c.ID)).Select(c => c.ID).ToList()
					: new List<string>();
			}
			return _levelChallengeIds;
		}

		public void HandleSceneDataUpdate(Dictionary<string, float> data) { }
		public void DeleteData() { }
		public WindowType GetWindowType() => window;
		public string GetID()
		{
			if (string.IsNullOrEmpty(convertedLevelId))
				convertedLevelId = "LEVEL_" + (name ?? string.Empty).Trim().ToUpperInvariant().Replace(' ', '_');
			return convertedLevelId;
		}
		public string GetCompletionTextID() => !string.IsNullOrEmpty(completionID) ? completionID : CompletionText;
		public string GetWeightID() => GetID() + "_WEIGHT";
		public List<string> GetChallengeLocalizationIDs() => levelChallenges != null ? levelChallenges.Select(c => c.LocalizationID).ToList() : new List<string>();
		public bool HasCompletedAllChallenges()
		{
			if (levelChallenges == null || levelChallenges.Count == 0)
				return true;
			var completed = CompletedChallenges;
			return levelChallenges.All(t => t == null || string.IsNullOrEmpty(t.ID) || (completed != null && completed.Contains(t.ID)));
		}
		public int GetCurrentChallengeIndex()
		{
			if (!IsCompletedInSaveGame)
				return 0;
			if (levelChallenges == null || levelChallenges.Count == 0)
				return -1;
			var completed = CompletedChallenges;
			for (int i = 0; i < levelChallenges.Count; i++)
			{
				var ch = levelChallenges[i];
				if (ch != null && !string.IsNullOrEmpty(ch.ID) && (completed == null || !completed.Contains(ch.ID)))
					return i + 1;
			}
			return -1;
		}
		public void ZeroWeight() { }
		public void IncrementWeight() { }
		public void DeleteWeight() { }
		public void ResetWeight() { }
		public int GetActualWeight() => Mathf.Max(1, WeightInt);
	}
}
