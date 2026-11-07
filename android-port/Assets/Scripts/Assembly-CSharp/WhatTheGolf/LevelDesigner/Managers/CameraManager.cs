using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Cameras;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Token(Token = "0x20012C6")]
	[Attribute(Name = "RequireComponent", RVA = "0x488FC", Offset = "0x488FC")]
	[Attribute(Name = "RequireComponent", RVA = "0x488FC", Offset = "0x488FC")]
	public sealed class CameraManager : BaseManager, IRequireEvents<GameStateEvent>, IRequireEvents
	{
		[Token(Token = "0x4006526")]
		[FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x4006527")]
		[FieldOffset(Offset = "0x28")]
		private CinemachineBrain m_CameraBrain;

		[Token(Token = "0x4006528")]
		[FieldOffset(Offset = "0x30")]
		private SelectableManager m_SelectableManager;

		[Token(Token = "0x4006529")]
		private const string kEditorCameraName = "EditorCamera";

		[Token(Token = "0x400652A")]
		private const string kPlayCameraName = "PlayCamera";

		[Token(Token = "0x400652B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private EditorCameraController m_EditorCameraPrefab;

		[Token(Token = "0x400652C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BasicCameraController m_PlayCameraPrefab;

		[Token(Token = "0x400652D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Camera m_UICamera;

		[Token(Token = "0x400652E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CameraData m_DefaultEditorCameraData;

		[Token(Token = "0x400652F")]
		[FieldOffset(Offset = "0x58")]
		private BaseCameraController m_EditorCamera;

		[Token(Token = "0x4006530")]
		[FieldOffset(Offset = "0x60")]
		private BaseCameraController m_PlayCamera;

		[Token(Token = "0x4006531")]
		[FieldOffset(Offset = "0x68")]
		private BaseCameraController m_OverridePlayCamera;

		[Token(Token = "0x4006532")]
		[FieldOffset(Offset = "0x70")]
		private bool m_IsRenderingScreenshot;

		[Token(Token = "0x170009EC")]
		public Camera camera
		{
			[Token(Token = "0x60056ED")]
			[Address(RVA = "0x1883500", Offset = "0x1883500", VA = "0x1883500")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009ED")]
		public CinemachineBrain cameraBrain
		{
			[Token(Token = "0x60056EE")]
			[Address(RVA = "0x18835AC", Offset = "0x18835AC", VA = "0x18835AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009EE")]
		public SelectableManager selectableManager
		{
			[Token(Token = "0x60056EF")]
			[Address(RVA = "0x1883658", Offset = "0x1883658", VA = "0x1883658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009EF")]
		public BaseCameraController playCamera
		{
			[Token(Token = "0x60056F0")]
			[Address(RVA = "0x188370C", Offset = "0x188370C", VA = "0x188370C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F0")]
		public BaseCameraController editorCamera
		{
			[Token(Token = "0x60056F1")]
			[Address(RVA = "0x18837A0", Offset = "0x18837A0", VA = "0x18837A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F1")]
		public Camera uiCamera
		{
			[Token(Token = "0x60056F2")]
			[Address(RVA = "0x18837A8", Offset = "0x18837A8", VA = "0x18837A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60056F3")]
		[Address(RVA = "0x18837B0", Offset = "0x18837B0", VA = "0x18837B0", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x60056F4")]
		[Address(RVA = "0x1883AB0", Offset = "0x1883AB0", VA = "0x1883AB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60056F5")]
		[Address(RVA = "0x1883BAC", Offset = "0x1883BAC", VA = "0x1883BAC", Slot = "5")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x60056F6")]
		[Address(RVA = "0x1883CB8", Offset = "0x1883CB8", VA = "0x1883CB8")]
		private void Transition(bool toPlayCamera, Transform target, float transitionTime)
		{
		}

		[Token(Token = "0x60056F7")]
		[Address(RVA = "0x1883E24", Offset = "0x1883E24", VA = "0x1883E24")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x60056F8")]
		[Address(RVA = "0x1883E34", Offset = "0x1883E34", VA = "0x1883E34")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60056F9")]
		[Address(RVA = "0x1883924", Offset = "0x1883924", VA = "0x1883924")]
		private void CreateDefaultCameras()
		{
		}

		[Token(Token = "0x60056FA")]
		[Address(RVA = "0x1883E44", Offset = "0x1883E44", VA = "0x1883E44")]
		public void SetPlayModeCamera(BallDefinition ballDefinition)
		{
		}

		[Token(Token = "0x60056FB")]
		[Address(RVA = "0x1883FFC", Offset = "0x1883FFC", VA = "0x1883FFC")]
		private void TakeScreenshot(RenderTexture rt)
		{
		}

		[Token(Token = "0x60056FC")]
		[Address(RVA = "0x188428C", Offset = "0x188428C", VA = "0x188428C")]
		public CameraManager()
		{
		}
	}
}
