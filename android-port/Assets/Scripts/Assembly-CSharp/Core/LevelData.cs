using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Serializable]
	[Token(Token = "0x2001435")]
	public class LevelData : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2001436")]
		public class MapPositionData
		{
			[Token(Token = "0x2001437")]
			public enum AngleOptions
			{
				[Token(Token = "0x4006D9E")]
				RelativeForward = 0,
				[Token(Token = "0x4006D9F")]
				RelativeLeft = 1,
				[Token(Token = "0x4006DA0")]
				RelativeRight = 2,
				[Token(Token = "0x4006DA1")]
				UseScene = 3
			}

			[Token(Token = "0x4006D9B")]
			[FieldOffset(Offset = "0x10")]
			public AngleOptions currentAngle;

			[Token(Token = "0x4006D9C")]
			[FieldOffset(Offset = "0x14")]
			public float distance;

			[Token(Token = "0x6005E92")]
			[Address(RVA = "0x17D2574", Offset = "0x17D2574", VA = "0x17D2574")]
			public MapPositionData()
			{
			}
		}

		[Token(Token = "0x2001438")]
		public enum WindowType
		{
			[Token(Token = "0x4006DA3")]
			Normal = 0,
			[Token(Token = "0x4006DA4")]
			TwoD = 1
		}

		[Serializable]
		[Token(Token = "0x2001439")]
		public class LevelCollectable
		{
			[Token(Token = "0x4006DA5")]
			[FieldOffset(Offset = "0x10")]
			public Collectable Collectable;

			[Token(Token = "0x4006DA6")]
			[FieldOffset(Offset = "0x18")]
			public List<string> IDs;

			[Token(Token = "0x6005E93")]
			[Address(RVA = "0x17D256C", Offset = "0x17D256C", VA = "0x17D256C")]
			public LevelCollectable()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200143A")]
		public class ChallengeData
		{
			[Token(Token = "0x4006DA7")]
			[FieldOffset(Offset = "0x10")]
			public string ID;

			[Token(Token = "0x4006DA8")]
			[FieldOffset(Offset = "0x18")]
			public string LocalizationID;

			[Token(Token = "0x4006DA9")]
			[FieldOffset(Offset = "0x20")]
			public Sprite Icon;

			[Token(Token = "0x6005E94")]
			[Address(RVA = "0x17D2564", Offset = "0x17D2564", VA = "0x17D2564")]
			public ChallengeData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200143B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4909C", Offset = "0x4909C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4006DAA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006DAB")]
			[FieldOffset(Offset = "0x8")]
			public static Func<ChallengeData, string> _003C_003E9__24_0;

			[Token(Token = "0x4006DAC")]
			[FieldOffset(Offset = "0x10")]
			public static Func<ChallengeData, string> _003C_003E9__28_0;

			[Token(Token = "0x4006DAD")]
			[FieldOffset(Offset = "0x18")]
			public static Func<ChallengeData, string> _003C_003E9__52_0;

			[Token(Token = "0x6005E96")]
			[Address(RVA = "0x17D2514", Offset = "0x17D2514", VA = "0x17D2514")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005E97")]
			[Address(RVA = "0x17D251C", Offset = "0x17D251C", VA = "0x17D251C")]
			internal string _003Cget_CompletedChallenges_003Eb__24_0(ChallengeData challenge)
			{
				return null;
			}

			[Token(Token = "0x6005E98")]
			[Address(RVA = "0x17D2534", Offset = "0x17D2534", VA = "0x17D2534")]
			internal string _003CLevelChallengeIds_003Eb__28_0(ChallengeData l)
			{
				return null;
			}

			[Token(Token = "0x6005E99")]
			[Address(RVA = "0x17D254C", Offset = "0x17D254C", VA = "0x17D254C")]
			internal string _003CGetChallengeLocalizationIDs_003Eb__52_0(ChallengeData l)
			{
				return null;
			}
		}

		[Token(Token = "0x4006D82")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public bool skipPopup;

		[Token(Token = "0x4006D83")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public string ID;

		[Token(Token = "0x4006D84")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MapPositionData mapPosition;

		[Token(Token = "0x4006D85")]
		[FieldOffset(Offset = "0x30")]
		public MusicData showcaseMusic;

		[Token(Token = "0x4006D86")]
		[FieldOffset(Offset = "0x38")]
		public LevelMusicSettings music;

		[Token(Token = "0x4006D87")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public int StrokesToPar;

		[Token(Token = "0x4006D88")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public string Pun;

		[Token(Token = "0x4006D89")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public string completionID;

		[Token(Token = "0x4006D8A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public string CompletionText;

		[Token(Token = "0x4006D8B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public SceneField Scene;

		[Token(Token = "0x4006D8C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private WindowType window;

		[Token(Token = "0x4006D8D")]
		[FieldOffset(Offset = "0x0")]
		public static string bestScoreID;

		[Token(Token = "0x4006D8E")]
		[FieldOffset(Offset = "0x8")]
		public static string levelEventsID;

		[Token(Token = "0x4006D8F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<LevelCollectable> levelCollectables;

		[Token(Token = "0x4006D90")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public List<ChallengeData> levelChallenges;

		[Token(Token = "0x4006D91")]
		[FieldOffset(Offset = "0x80")]
		private List<string> _levelChallengeIds;

		[Token(Token = "0x4006D92")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		public bool isShowingFlipText;

		[Token(Token = "0x4006D93")]
		[FieldOffset(Offset = "0x89")]
		[SerializeField]
		public bool isBossBattle;

		[Token(Token = "0x4006D94")]
		[FieldOffset(Offset = "0x8A")]
		[SerializeField]
		public bool usedInDailyChallenges;

		[Token(Token = "0x4006D95")]
		[FieldOffset(Offset = "0x8B")]
		[SerializeField]
		public bool userCustomTransitionColor;

		[Token(Token = "0x4006D96")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		public Color customTransitionColor;

		[Token(Token = "0x4006D97")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		public bool useCustomTransitionEffect;

		[Token(Token = "0x4006D98")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public Transition.TransitionEffect customTransitionEffectIndex;

		[Token(Token = "0x4006D99")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int WeightInt;

		[Token(Token = "0x4006D9A")]
		[FieldOffset(Offset = "0xA8")]
		private string convertedLevelId;

		[Token(Token = "0x17000AB7")]
		public MapPositionData MapPosition
		{
			[Token(Token = "0x6005E75")]
			[Address(RVA = "0x1527D34", Offset = "0x1527D34", VA = "0x1527D34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E76")]
			[Address(RVA = "0x1527D9C", Offset = "0x1527D9C", VA = "0x1527D9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB8")]
		public WindowType LevelWindowType
		{
			[Token(Token = "0x6005E77")]
			[Address(RVA = "0x1527DA4", Offset = "0x1527DA4", VA = "0x1527DA4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AB9")]
		public int BestScore
		{
			[Token(Token = "0x6005E78")]
			[Address(RVA = "0x1527DAC", Offset = "0x1527DAC", VA = "0x1527DAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005E79")]
			[Address(RVA = "0x1527F74", Offset = "0x1527F74", VA = "0x1527F74")]
			set
			{
			}
		}

		[Token(Token = "0x17000ABA")]
		public List<string> CompletedChallenges
		{
			[Token(Token = "0x6005E7A")]
			[Address(RVA = "0x1525F1C", Offset = "0x1525F1C", VA = "0x1525F1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E7B")]
			[Address(RVA = "0x15260BC", Offset = "0x15260BC", VA = "0x15260BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000ABB")]
		public bool IsCompletedInSaveGame
		{
			[Token(Token = "0x6005E7D")]
			[Address(RVA = "0x1528274", Offset = "0x1528274", VA = "0x1528274")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005E7E")]
			[Address(RVA = "0x15282F0", Offset = "0x15282F0", VA = "0x15282F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000ABC")]
		public string SceneName
		{
			[Token(Token = "0x6005E7F")]
			[Address(RVA = "0x1527EEC", Offset = "0x1527EEC", VA = "0x1527EEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E7C")]
		[Address(RVA = "0x15280BC", Offset = "0x15280BC", VA = "0x15280BC")]
		public List<string> LevelChallengeIds()
		{
			return null;
		}

		[Token(Token = "0x6005E80")]
		[Address(RVA = "0x1528368", Offset = "0x1528368", VA = "0x1528368")]
		public void HandleSceneDataUpdate(Dictionary<string, float> data)
		{
		}

		[Token(Token = "0x6005E81")]
		[Address(RVA = "0x15284BC", Offset = "0x15284BC", VA = "0x15284BC")]
		public void DeleteData()
		{
		}

		[Token(Token = "0x6005E82")]
		[Address(RVA = "0x15285E8", Offset = "0x15285E8", VA = "0x15285E8")]
		public WindowType GetWindowType()
		{
			return default;
		}

		[Token(Token = "0x6005E83")]
		[Address(RVA = "0x152867C", Offset = "0x152867C", VA = "0x152867C")]
		public string GetID()
		{
			return null;
		}

		[Token(Token = "0x6005E84")]
		[Address(RVA = "0x1528724", Offset = "0x1528724", VA = "0x1528724")]
		public string GetCompletionTextID()
		{
			return null;
		}

		[Token(Token = "0x6005E85")]
		[Address(RVA = "0x1528784", Offset = "0x1528784", VA = "0x1528784")]
		public string GetWeightID()
		{
			return null;
		}

		[Token(Token = "0x6005E86")]
		[Address(RVA = "0x15287E4", Offset = "0x15287E4", VA = "0x15287E4")]
		public List<string> GetChallengeLocalizationIDs()
		{
			return null;
		}

		[Token(Token = "0x6005E87")]
		[Address(RVA = "0x1528934", Offset = "0x1528934", VA = "0x1528934")]
		public bool HasCompletedAllChallenges()
		{
			return default;
		}

		[Token(Token = "0x6005E88")]
		[Address(RVA = "0x1528A24", Offset = "0x1528A24", VA = "0x1528A24")]
		public int GetCurrentChallengeIndex()
		{
			return default;
		}

		[Token(Token = "0x6005E89")]
		[Address(RVA = "0x1528AE8", Offset = "0x1528AE8", VA = "0x1528AE8")]
		public void ZeroWeight()
		{
		}

		[Token(Token = "0x6005E8A")]
		[Address(RVA = "0x1528BE4", Offset = "0x1528BE4", VA = "0x1528BE4")]
		public void IncrementWeight()
		{
		}

		[Token(Token = "0x6005E8B")]
		[Address(RVA = "0x1528D78", Offset = "0x1528D78", VA = "0x1528D78")]
		public void DeleteWeight()
		{
		}

		[Token(Token = "0x6005E8C")]
		[Address(RVA = "0x1528E70", Offset = "0x1528E70", VA = "0x1528E70")]
		public void ResetWeight()
		{
		}

		[Token(Token = "0x6005E8D")]
		[Address(RVA = "0x1528F6C", Offset = "0x1528F6C", VA = "0x1528F6C")]
		public int GetActualWeight()
		{
			return default;
		}

		[Token(Token = "0x6005E8E")]
		[Address(RVA = "0x1529068", Offset = "0x1529068", VA = "0x1529068")]
		public LevelData()
		{
		}

		[Token(Token = "0x6005E90")]
		[Address(RVA = "0x1529140", Offset = "0x1529140", VA = "0x1529140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72D04", Offset = "0x72D04")]
		private bool _003CHasCompletedAllChallenges_003Eb__53_0(ChallengeData t)
		{
			return default;
		}

		[Token(Token = "0x6005E91")]
		[Address(RVA = "0x15291B0", Offset = "0x15291B0", VA = "0x15291B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72D14", Offset = "0x72D14")]
		private bool _003CGetCurrentChallengeIndex_003Eb__54_0(ChallengeData c)
		{
			return default;
		}
	}
}
