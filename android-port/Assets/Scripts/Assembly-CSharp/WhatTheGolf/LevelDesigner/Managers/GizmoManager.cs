using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Token(Token = "0x20012C8")]
	public sealed class GizmoManager : BaseManager, IRequireEvents<GameStateEvent>, IRequireEvents, IRequireRender
	{
		[Token(Token = "0x4006535")]
		private const float kPlaneScale = 0.1f;

		[Token(Token = "0x4006536")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GizmoMaterial[] m_Materials;

		[Token(Token = "0x4006537")]
		[FieldOffset(Offset = "0x28")]
		private bool m_IsActive;

		[Token(Token = "0x4006538")]
		[FieldOffset(Offset = "0x29")]
		private bool m_Initialized;

		[Token(Token = "0x4006539")]
		[FieldOffset(Offset = "0x30")]
		private Mesh m_Mesh;

		[Token(Token = "0x400653A")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<GizmoType, Material> m_MaterialInstances;

		[Token(Token = "0x400653B")]
		[FieldOffset(Offset = "0x40")]
		private Stack<GizmoData> m_GizmoStack;

		[Token(Token = "0x60056FD")]
		[Address(RVA = "0x148D924", Offset = "0x148D924", VA = "0x148D924")]
		public GizmoManager()
		{
		}

		[Token(Token = "0x60056FE")]
		[Address(RVA = "0x148D9F8", Offset = "0x148D9F8", VA = "0x148D9F8", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x60056FF")]
		[Address(RVA = "0x148DA4C", Offset = "0x148DA4C", VA = "0x148DA4C")]
		private void InitMaterialInstances()
		{
		}

		[Token(Token = "0x6005700")]
		[Address(RVA = "0x148DBA8", Offset = "0x148DBA8", VA = "0x148DBA8", Slot = "5")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x6005701")]
		[Address(RVA = "0x148DC1C", Offset = "0x148DC1C", VA = "0x148DC1C", Slot = "6")]
		public void QueueDraws(bool isScreenshot)
		{
		}

		[Token(Token = "0x6005702")]
		private void TrySetProperty<T>(Material material, string name, T value)
		{
		}

		[Token(Token = "0x6005703")]
		[Address(RVA = "0x148DEE8", Offset = "0x148DEE8", VA = "0x148DEE8")]
		public void QueueCircleGizmo(Vector3 position, Quaternion rotation, float scale, Color32 color)
		{
		}

		[Token(Token = "0x6005704")]
		[Address(RVA = "0x148DFB8", Offset = "0x148DFB8", VA = "0x148DFB8")]
		public void QueueCrossGizmo(Vector3 position, Quaternion rotation, float scale, Color32 color)
		{
		}

		[Token(Token = "0x6005705")]
		[Address(RVA = "0x148E090", Offset = "0x148E090", VA = "0x148E090")]
		public void QueueRotationGizmo(Vector3 position, Quaternion rotation, float scale, Color32 color)
		{
		}

		[Token(Token = "0x6005706")]
		[Address(RVA = "0x148E164", Offset = "0x148E164", VA = "0x148E164")]
		public void QueueDirectionIndicatorGizmo(Vector3 position, Quaternion rotation, float scale, float offset, Color32 color)
		{
		}

		[Token(Token = "0x6005707")]
		[Address(RVA = "0x148E2E8", Offset = "0x148E2E8", VA = "0x148E2E8")]
		private float GetSignedAngle(Quaternion A, Quaternion B, Vector3 axis)
		{
			return default;
		}
	}
}
