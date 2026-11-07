using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001243")]
	public class SelectableDefinition : ElementDefinition
	{
		[Token(Token = "0x4006273")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_Prefab;

		[Token(Token = "0x4006274")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_HighlightRadius;

		[Token(Token = "0x4006275")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ScatterRadius;

		[Token(Token = "0x4006276")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_CanDelete;

		[Token(Token = "0x17000966")]
		public GameObject prefab
		{
			[Token(Token = "0x6005414")]
			[Address(RVA = "0x1685F84", Offset = "0x1685F84", VA = "0x1685F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000967")]
		public float highlightRadius
		{
			[Token(Token = "0x6005415")]
			[Address(RVA = "0x1685F8C", Offset = "0x1685F8C", VA = "0x1685F8C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000968")]
		public float scatterRadius
		{
			[Token(Token = "0x6005416")]
			[Address(RVA = "0x1685F94", Offset = "0x1685F94", VA = "0x1685F94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000969")]
		public bool canDelete
		{
			[Token(Token = "0x6005417")]
			[Address(RVA = "0x1685F9C", Offset = "0x1685F9C", VA = "0x1685F9C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005418")]
		[Address(RVA = "0x1685FA4", Offset = "0x1685FA4", VA = "0x1685FA4")]
		public SelectableDefinition()
		{
		}
	}
}
