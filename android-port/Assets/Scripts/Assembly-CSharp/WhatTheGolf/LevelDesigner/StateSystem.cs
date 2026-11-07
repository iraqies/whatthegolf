using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x200125A")]
	internal sealed class StateSystem : BaseSystem, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<PlayEvent>
	{
		[Serializable]
		[Token(Token = "0x200125B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48644", Offset = "0x48644")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40062D6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40062D7")]
			[FieldOffset(Offset = "0x8")]
			public static Action _003C_003E9__43_0;

			[Token(Token = "0x60054B9")]
			[Address(RVA = "0x185AAD0", Offset = "0x185AAD0", VA = "0x185AAD0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60054BA")]
			[Address(RVA = "0x185AAD8", Offset = "0x185AAD8", VA = "0x185AAD8")]
			internal void _003COnEvent_003Eb__43_0()
			{
			}
		}

		[Token(Token = "0x40062C9")]
		[FieldOffset(Offset = "0x0")]
		private static StateSystem s_Instance;

		[Token(Token = "0x40062CA")]
		private const string kInvalidStateError = "Invalid State change requested.";

		[Token(Token = "0x40062CB")]
		[FieldOffset(Offset = "0x8")]
		private static StateType s_CurrentState;

		[Token(Token = "0x40062CC")]
		[FieldOffset(Offset = "0x10")]
		private static ElementDatabase s_ElementDatabase;

		[Token(Token = "0x40062CD")]
		[FieldOffset(Offset = "0x18")]
		private static SerializableLevelData s_CurrentLevelData;

		[Token(Token = "0x40062CE")]
		[FieldOffset(Offset = "0x20")]
		private static List<IRequireSerialization> s_RequirementConsumers;

		[Token(Token = "0x40062CF")]
		[FieldOffset(Offset = "0x28")]
		private static LevelData s_DefaultLevel;

		[Token(Token = "0x40062D0")]
		[FieldOffset(Offset = "0x30")]
		private static LevelData s_CachedLevel;

		[Token(Token = "0x40062D1")]
		[FieldOffset(Offset = "0x38")]
		private static SelectableDefinition s_Selection;

		[Token(Token = "0x40062D2")]
		[FieldOffset(Offset = "0x40")]
		private static BallDefinition s_Ball;

		[Token(Token = "0x40062D3")]
		[FieldOffset(Offset = "0x48")]
		private static bool s_EditorOpen;

		[Token(Token = "0x40062D4")]
		[FieldOffset(Offset = "0x49")]
		private static bool s_SessionTested;

		[Token(Token = "0x40062D5")]
		[FieldOffset(Offset = "0x50")]
		private static Stopwatch s_EditorStopwatch;

		[Token(Token = "0x17000988")]
		internal static LevelData CurrentLevel
		{
			[Token(Token = "0x600549C")]
			[Address(RVA = "0x16DBD34", Offset = "0x16DBD34", VA = "0x16DBD34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000989")]
		public static StateType CurrentState
		{
			[Token(Token = "0x600549D")]
			[Address(RVA = "0x16DBD80", Offset = "0x16DBD80", VA = "0x16DBD80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700098A")]
		public static ElementDatabase ElementDatabase
		{
			[Token(Token = "0x600549E")]
			[Address(RVA = "0x16DBDCC", Offset = "0x16DBDCC", VA = "0x16DBDCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098B")]
		public static SerializableLevelData CurrentLevelData
		{
			[Token(Token = "0x600549F")]
			[Address(RVA = "0x16DBE18", Offset = "0x16DBE18", VA = "0x16DBE18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098C")]
		public static bool HasSelection
		{
			[Token(Token = "0x60054A0")]
			[Address(RVA = "0x16DBE64", Offset = "0x16DBE64", VA = "0x16DBE64")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700098D")]
		public static SelectableDefinition CurrentSelection
		{
			[Token(Token = "0x60054A1")]
			[Address(RVA = "0x16DBF0C", Offset = "0x16DBF0C", VA = "0x16DBF0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700098E")]
		public static BallDefinition CurrentBall
		{
			[Token(Token = "0x60054A2")]
			[Address(RVA = "0x16DBF58", Offset = "0x16DBF58", VA = "0x16DBF58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60054A3")]
		[Address(RVA = "0x16DBFA4", Offset = "0x16DBFA4", VA = "0x16DBFA4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x713E8", Offset = "0x713E8")]
		private static void InitOnLoad()
		{
		}

		[Token(Token = "0x60054A4")]
		[Address(RVA = "0x16DC090", Offset = "0x16DC090", VA = "0x16DC090")]
		public static void SetResources(ElementDatabase elementDatabase, LevelData defaultLevel)
		{
		}

		[Token(Token = "0x60054A5")]
		[Address(RVA = "0x16DC104", Offset = "0x16DC104", VA = "0x16DC104")]
		public static void SetState(StateType stateType)
		{
		}

		[Token(Token = "0x60054A6")]
		[Address(RVA = "0x16DC35C", Offset = "0x16DC35C", VA = "0x16DC35C")]
		private static void HandleStateDiagnostics()
		{
		}

		[Token(Token = "0x60054A7")]
		[Address(RVA = "0x16DC5D8", Offset = "0x16DC5D8", VA = "0x16DC5D8", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x60054A8")]
		[Address(RVA = "0x16DC63C", Offset = "0x16DC63C", VA = "0x16DC63C", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60054A9")]
		[Address(RVA = "0x16DC640", Offset = "0x16DC640", VA = "0x16DC640", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60054AA")]
		[Address(RVA = "0x16DC644", Offset = "0x16DC644", VA = "0x16DC644")]
		public static void LoadEditorState(LevelData levelData)
		{
		}

		[Token(Token = "0x60054AB")]
		[Address(RVA = "0x16DC818", Offset = "0x16DC818", VA = "0x16DC818")]
		public static void SaveEditorState()
		{
		}

		[Token(Token = "0x60054AC")]
		[Address(RVA = "0x16DC9EC", Offset = "0x16DC9EC", VA = "0x16DC9EC")]
		public static void LoadEditorContentState(LevelContentData levelContentData)
		{
		}

		[Token(Token = "0x60054AD")]
		[Address(RVA = "0x16DC298", Offset = "0x16DC298", VA = "0x16DC298")]
		public static void ResetEditorState()
		{
		}

		[Token(Token = "0x60054AE")]
		[Address(RVA = "0x16DCAB8", Offset = "0x16DCAB8", VA = "0x16DCAB8")]
		public static LevelData GetEditorStateCopy()
		{
			return null;
		}

		[Token(Token = "0x60054AF")]
		[Address(RVA = "0x16DCB28", Offset = "0x16DCB28", VA = "0x16DCB28")]
		public static void SetEditorStateDirty()
		{
		}

		[Token(Token = "0x60054B0")]
		[Address(RVA = "0x16DCBF0", Offset = "0x16DCBF0", VA = "0x16DCBF0")]
		public static void ReplaceEditorStateMetadataFromFileCache()
		{
		}

		[Token(Token = "0x60054B1")]
		[Address(RVA = "0x16DCDBC", Offset = "0x16DCDBC", VA = "0x16DCDBC")]
		public static void SetSelection(SelectableDefinition selectableDefinition)
		{
		}

		[Token(Token = "0x60054B2")]
		[Address(RVA = "0x16DCE14", Offset = "0x16DCE14", VA = "0x16DCE14")]
		public static void SetBall(BallDefinition ballDefinition)
		{
		}

		[Token(Token = "0x60054B3")]
		[Address(RVA = "0x16DCE6C", Offset = "0x16DCE6C", VA = "0x16DCE6C", Slot = "7")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x60054B4")]
		[Address(RVA = "0x16DD198", Offset = "0x16DD198", VA = "0x16DD198", Slot = "8")]
		public void OnEvent(PlayEvent evt)
		{
		}

		[Token(Token = "0x60054B5")]
		[Address(RVA = "0x16DD3C4", Offset = "0x16DD3C4", VA = "0x16DD3C4")]
		public static void Register(IRequireSerialization consumer)
		{
		}

		[Token(Token = "0x60054B6")]
		[Address(RVA = "0x16DD484", Offset = "0x16DD484", VA = "0x16DD484")]
		public static void Unregister(IRequireSerialization consumer)
		{
		}

		[Token(Token = "0x60054B7")]
		[Address(RVA = "0x16DD544", Offset = "0x16DD544", VA = "0x16DD544")]
		public StateSystem()
		{
		}
	}
}
