using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	[Token(Token = "0x200127C")]
	[Attribute(Name = "RequireComponent", RVA = "0x48764", Offset = "0x48764")]
	public class SelectableCollider : MonoBehaviour
	{
		[Token(Token = "0x4006362")]
		[FieldOffset(Offset = "0x18")]
		private Collider m_Collider;

		[Token(Token = "0x4006363")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Selectable m_Selectable;

		[Token(Token = "0x170009BD")]
		public Collider collider
		{
			[Token(Token = "0x600557C")]
			[Address(RVA = "0x1685BB4", Offset = "0x1685BB4", VA = "0x1685BB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009BE")]
		public Selectable selectable
		{
			[Token(Token = "0x600557D")]
			[Address(RVA = "0x1685C60", Offset = "0x1685C60", VA = "0x1685C60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600557E")]
		[Address(RVA = "0x1685C68", Offset = "0x1685C68", VA = "0x1685C68")]
		private void Start()
		{
		}

		[Token(Token = "0x600557F")]
		[Address(RVA = "0x1685DC8", Offset = "0x1685DC8", VA = "0x1685DC8")]
		private void OnExitPlayMode()
		{
		}

		[Token(Token = "0x6005580")]
		[Address(RVA = "0x1685DEC", Offset = "0x1685DEC", VA = "0x1685DEC")]
		private void OnEnterPlayMode()
		{
		}

		[Token(Token = "0x6005581")]
		[Address(RVA = "0x1685E10", Offset = "0x1685E10", VA = "0x1685E10")]
		public SelectableCollider()
		{
		}
	}
}
