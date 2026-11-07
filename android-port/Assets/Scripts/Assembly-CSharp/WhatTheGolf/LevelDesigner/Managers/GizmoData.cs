using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Token(Token = "0x20012C1")]
	internal struct GizmoData
	{
		[Token(Token = "0x4006500")]
		[FieldOffset(Offset = "0x0")]
		public readonly GizmoType gizmoType;

		[Token(Token = "0x4006501")]
		[FieldOffset(Offset = "0x4")]
		public readonly Vector3 position;

		[Token(Token = "0x4006502")]
		[FieldOffset(Offset = "0x10")]
		public readonly Quaternion rotation;

		[Token(Token = "0x4006503")]
		[FieldOffset(Offset = "0x20")]
		public readonly float scale;

		[Token(Token = "0x4006504")]
		[FieldOffset(Offset = "0x24")]
		public readonly float circleThickness;

		[Token(Token = "0x4006505")]
		[FieldOffset(Offset = "0x28")]
		public readonly float crossThickness;

		[Token(Token = "0x4006506")]
		[FieldOffset(Offset = "0x2C")]
		public readonly Color32 color;

		[Token(Token = "0x60056DA")]
		[Address(RVA = "0x148D784", Offset = "0x148D784", VA = "0x148D784")]
		public GizmoData(GizmoType gizmoType, Vector3 position, Quaternion rotation, float scale, float circleThickness, float crossThickness, Color32 color)
		{
		}
	}
}
