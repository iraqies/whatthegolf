using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000018")]
	[ExecuteAlways]
	public class CinemachineConfiner : CinemachineExtension
	{
		[Token(Token = "0x2000019")]
		public enum Mode
		{
			[Token(Token = "0x4000083")]
			Confine2D = 0,
			[Token(Token = "0x4000084")]
			Confine3D = 1
		}

		[Token(Token = "0x200001A")]
		private class VcamExtraState
		{
			[Token(Token = "0x4000085")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 m_previousDisplacement;

			[Token(Token = "0x4000086")]
			[FieldOffset(Offset = "0x1C")]
			public float confinerDisplacement;

			[Token(Token = "0x6000092")]
			[Address(RVA = "0x190F260", Offset = "0x190F260", VA = "0x190F260")]
			public VcamExtraState()
			{
			}
		}

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x28")]
		public Mode m_ConfineMode;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x30")]
		public Collider m_BoundingVolume;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x38")]
		public Collider2D m_BoundingShape2D;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x40")]
		public bool m_ConfineScreenEdges;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "RangeAttribute", RVA = "0x783B0", Offset = "0x783B0")]
		public float m_Damping;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x48")]
		private List<List<Vector2>> m_pathCache;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x50")]
		private int m_pathTotalPointCount;

		[Token(Token = "0x1700001E")]
		public bool IsValid
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x18EEAD4", Offset = "0x18EEAD4", VA = "0x18EEAD4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x18EEA2C", Offset = "0x18EEA2C", VA = "0x18EEA2C")]
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam)
		{
			return default;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x18EEAA4", Offset = "0x18EEAA4", VA = "0x18EEAA4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x18EEBB8", Offset = "0x18EEBB8", VA = "0x18EEBB8", Slot = "7")]
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x18EF340", Offset = "0x18EF340", VA = "0x18EF340")]
		public void InvalidatePathCache()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x18EF348", Offset = "0x18EF348", VA = "0x18EF348")]
		private bool ValidatePathCache()
		{
			return default;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x18EF028", Offset = "0x18EF028", VA = "0x18EF028")]
		private Vector3 ConfinePoint(Vector3 camPos)
		{
			return default;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x18EED74", Offset = "0x18EED74", VA = "0x18EED74")]
		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state)
		{
			return default;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x18EF8AC", Offset = "0x18EF8AC", VA = "0x18EF8AC")]
		public CinemachineConfiner()
		{
		}
	}
}
