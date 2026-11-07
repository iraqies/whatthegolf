using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Token(Token = "0x20012D3")]
	public sealed class SkyManager : BaseManager, IRequireRender
	{
		[Token(Token = "0x400656C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material m_Material;

		[Token(Token = "0x400656D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject cloudPrefab;

		[Token(Token = "0x400656E")]
		[FieldOffset(Offset = "0x30")]
		private bool m_Initialized;

		[Token(Token = "0x400656F")]
		[FieldOffset(Offset = "0x38")]
		private Mesh m_Mesh;

		[Token(Token = "0x4006570")]
		[FieldOffset(Offset = "0x40")]
		private Matrix4x4 m_Matrix;

		[Token(Token = "0x600574D")]
		[Address(RVA = "0x16B5EF4", Offset = "0x16B5EF4", VA = "0x16B5EF4", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x600574E")]
		[Address(RVA = "0x16B60A0", Offset = "0x16B60A0", VA = "0x16B60A0", Slot = "5")]
		public void QueueDraws(bool isScreenshot)
		{
		}

		[Token(Token = "0x600574F")]
		[Address(RVA = "0x16B61B8", Offset = "0x16B61B8", VA = "0x16B61B8")]
		public SkyManager()
		{
		}
	}
}
