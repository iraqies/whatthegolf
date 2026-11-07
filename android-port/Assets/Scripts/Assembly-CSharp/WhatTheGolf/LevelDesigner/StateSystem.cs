using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner
{
	internal sealed class StateSystem : BaseSystem, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<PlayEvent>
	{
		private static StateSystem s_Instance;

		private const string kInvalidStateError = "Invalid State change requested.";

		private static StateType s_CurrentState;

		private static ElementDatabase s_ElementDatabase;

		private static SerializableLevelData s_CurrentLevelData;

		private static List<IRequireSerialization> s_RequirementConsumers;

		private static LevelData s_DefaultLevel;

		private static LevelData s_CachedLevel;

		private static SelectableDefinition s_Selection;

		private static BallDefinition s_Ball;

		private static bool s_EditorOpen;

		private static bool s_SessionTested;

		private static Stopwatch s_EditorStopwatch;

		internal static LevelData CurrentLevel => null;

		public static StateType CurrentState => StateType.Menu;

		public static ElementDatabase ElementDatabase => null;

		public static SerializableLevelData CurrentLevelData => null;

		public static bool HasSelection => false;

		public static SelectableDefinition CurrentSelection => null;

		public static BallDefinition CurrentBall => null;

		[RuntimeInitializeOnLoadMethod]
		private static void InitOnLoad()
		{
		}

		public static void SetResources(ElementDatabase elementDatabase, LevelData defaultLevel)
		{
		}

		public static void SetState(StateType stateType)
		{
		}

		private static void HandleStateDiagnostics()
		{
		}

		public override void Init()
		{
		}

		public override void Update()
		{
		}

		public override void Dispose()
		{
		}

		public static void LoadEditorState(LevelData levelData)
		{
		}

		public static void SaveEditorState()
		{
		}

		public static void LoadEditorContentState(LevelContentData levelContentData)
		{
		}

		public static void ResetEditorState()
		{
		}

		public static LevelData GetEditorStateCopy()
		{
			return null;
		}

		public static void SetEditorStateDirty()
		{
		}

		public static void ReplaceEditorStateMetadataFromFileCache()
		{
		}

		public static void SetSelection(SelectableDefinition selectableDefinition)
		{
		}

		public static void SetBall(BallDefinition ballDefinition)
		{
		}

		public void OnEvent(GUIEvent evt)
		{
		}

		public void OnEvent(PlayEvent evt)
		{
		}

		public static void Register(IRequireSerialization consumer)
		{
		}

		public static void Unregister(IRequireSerialization consumer)
		{
		}
	}
}
