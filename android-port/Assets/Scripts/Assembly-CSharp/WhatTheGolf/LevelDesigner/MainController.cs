using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Managers;
using WhatTheGolf.LevelDesigner.Tools;

namespace WhatTheGolf.LevelDesigner
{
	public sealed class MainController : MonoBehaviour, IRequireEvents<GUIEvent>, IRequireEvents
	{
		private static MainController s_Instance;

		[SerializeField]
		private BaseManager[] m_ManagerPrefabs;

		[SerializeField]
		private GuiController m_GuiController;

		[SerializeField]
		private ElementDatabase m_ElementDatabase;

		[SerializeField]
		private LevelData m_DefaultLevelData;

		private const string kSceneName = "LevelDesigner";

		private const string kEditorKeyword = "_EDITOR";

		private bool m_Initialized;

		private List<BaseSystem> m_Systems;

		private List<BaseManager> m_Managers;

		private List<BaseTool> m_Tools;

		private int m_ActiveToolIndex;

		private GUIEvent.GUIEventType m_LatestToolEvent;

		private static MainController Instance => null;

		private BaseTool activeTool => null;

		private void Awake()
		{
		}

		public static void Startup(StateType stateType)
		{
		}

		private static IEnumerator StartupProcess(StateType stateType)
		{
			return null;
		}

		private static IEnumerator WaitForActiveScene()
		{
			return null;
		}

		public static void Close()
		{
		}

		private static IEnumerator CloseProcess()
		{
			return null;
		}

		private void Init(StateType stateType)
		{
		}

		private T CreateSystem<T>() where T : BaseSystem
		{
			return null;
		}

		private void CreateManager(BaseManager managerPrefab)
		{
		}

		private T CreateTool<T>() where T : BaseTool
		{
			return null;
		}

		private void Update()
		{
		}

		public void OnEvent(GUIEvent evt)
		{
		}

		private void OnDestroy()
		{
		}

		public T GetManager<T>() where T : BaseManager
		{
			return null;
		}

		private void UpdateActiveTool(GUIEvent evt)
		{
		}

		private int GetToolIndex<T>() where T : BaseTool
		{
			return 0;
		}
	}
}
