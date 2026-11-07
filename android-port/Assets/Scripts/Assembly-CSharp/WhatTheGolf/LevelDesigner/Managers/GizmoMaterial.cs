using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Serializable]
	[Token(Token = "0x20012C7")]
	public struct GizmoMaterial
	{
		[Token(Token = "0x4006533")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public GizmoType gizmoType;

		[Token(Token = "0x4006534")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public Material material;
	}
}
