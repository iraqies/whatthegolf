using Cinemachine;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Cameras;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.Managers
{
	public sealed class CameraManager : BaseManager, IRequireEvents<GameStateEvent>, IRequireEvents
	{
		private Camera m_Camera;

		private CinemachineBrain m_CameraBrain;

		private SelectableManager m_SelectableManager;

		private const string kEditorCameraName = "EditorCamera";

		private const string kPlayCameraName = "PlayCamera";

		[SerializeField]
		private EditorCameraController m_EditorCameraPrefab;

		[SerializeField]
		private BasicCameraController m_PlayCameraPrefab;

		[SerializeField]
		private Camera m_UICamera;

		[SerializeField]
		private CameraData m_DefaultEditorCameraData;

		private BaseCameraController m_EditorCamera;

		private BaseCameraController m_PlayCamera;

		private BaseCameraController m_OverridePlayCamera;

		private bool m_IsRenderingScreenshot;

		public Camera camera => null;

		public CinemachineBrain cameraBrain => null;

		public SelectableManager selectableManager => null;

		public BaseCameraController playCamera => null;

		public BaseCameraController editorCamera => null;

		public Camera uiCamera => null;

		public override void Init()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		private void Transition(bool toPlayCamera, Transform target, float transitionTime)
		{
		}

		private void OnPreCull()
		{
		}

		private void OnPostRender()
		{
		}

		private void CreateDefaultCameras()
		{
		}

		public void SetPlayModeCamera(BallDefinition ballDefinition)
		{
		}

		private void TakeScreenshot(RenderTexture rt)
		{
		}
	}
}
