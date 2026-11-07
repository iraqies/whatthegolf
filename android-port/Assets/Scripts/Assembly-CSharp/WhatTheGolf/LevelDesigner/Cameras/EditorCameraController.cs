using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Cameras
{
	[Token(Token = "0x20012D6")]
	public sealed class EditorCameraController : BaseCameraController
	{
		[Token(Token = "0x400657A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CinemachineVirtualCamera m_VirtualCamera;

		[Token(Token = "0x400657B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MinZoom;

		[Token(Token = "0x400657C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_MaxZoom;

		[Token(Token = "0x400657D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_ZoomSpeed;

		[Token(Token = "0x400657E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve m_ZoomSpeedCurve;

		[Token(Token = "0x400657F")]
		private const string kZoomInput = "Mouse ScrollWheel";

		[Token(Token = "0x4006580")]
		private const float kPanSpeedMouse = 0.05f;

		[Token(Token = "0x4006581")]
		private const float kRotateSpeedMouse = 0.1f;

		[Token(Token = "0x4006582")]
		[FieldOffset(Offset = "0x38")]
		private bool m_HasInput;

		[Token(Token = "0x17000A01")]
		public override CinemachineVirtualCamera virtualCamera
		{
			[Token(Token = "0x600575C")]
			[Address(RVA = "0x143A69C", Offset = "0x143A69C", VA = "0x143A69C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600575D")]
		[Address(RVA = "0x143A6A4", Offset = "0x143A6A4", VA = "0x143A6A4", Slot = "5")]
		public override void SetActive(bool value)
		{
		}

		[Token(Token = "0x600575E")]
		[Address(RVA = "0x143A6E8", Offset = "0x143A6E8", VA = "0x143A6E8", Slot = "6")]
		public override void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600575F")]
		[Address(RVA = "0x143A754", Offset = "0x143A754", VA = "0x143A754")]
		private void Update()
		{
		}

		[Token(Token = "0x6005760")]
		[Address(RVA = "0x143AA5C", Offset = "0x143AA5C", VA = "0x143AA5C")]
		public EditorCameraController()
		{
		}
	}
}
