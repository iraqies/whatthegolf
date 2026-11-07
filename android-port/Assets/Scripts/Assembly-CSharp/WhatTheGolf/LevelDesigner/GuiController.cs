using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001247")]
	public sealed class GuiController : MonoBehaviour, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<GameStateEvent>
	{
		[Token(Token = "0x4006281")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GuiGroup[] m_GuiGroups;

		[Token(Token = "0x4006282")]
		[FieldOffset(Offset = "0x0")]
		private static List<int> m_ActiveGroupIndices;

		[Token(Token = "0x4006283")]
		[FieldOffset(Offset = "0x8")]
		private static bool s_HasFocus;

		[Token(Token = "0x4006284")]
		[FieldOffset(Offset = "0x9")]
		private static bool s_IsInModals;

		[Token(Token = "0x4006285")]
		[FieldOffset(Offset = "0x10")]
		private static Type s_CurrentModalType;

		[Token(Token = "0x4006286")]
		[FieldOffset(Offset = "0x18")]
		private static bool s_IsDraggingGui;

		[Token(Token = "0x4006287")]
		[FieldOffset(Offset = "0x20")]
		private bool m_Initialized;

		[Token(Token = "0x17000974")]
		public static bool HasFocus
		{
			[Token(Token = "0x6005426")]
			[Address(RVA = "0x14BE0D0", Offset = "0x14BE0D0", VA = "0x14BE0D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000975")]
		public static bool IsInModals
		{
			[Token(Token = "0x6005427")]
			[Address(RVA = "0x14BE11C", Offset = "0x14BE11C", VA = "0x14BE11C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005428")]
		[Address(RVA = "0x14BE168", Offset = "0x14BE168", VA = "0x14BE168")]
		public void Init(Camera camera)
		{
		}

		[Token(Token = "0x6005429")]
		[Address(RVA = "0x14BE580", Offset = "0x14BE580", VA = "0x14BE580")]
		private void Update()
		{
		}

		[Token(Token = "0x600542A")]
		[Address(RVA = "0x14BE820", Offset = "0x14BE820", VA = "0x14BE820", Slot = "5")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x600542B")]
		[Address(RVA = "0x14BEA3C", Offset = "0x14BEA3C", VA = "0x14BEA3C", Slot = "4")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x600542C")]
		[Address(RVA = "0x14BE898", Offset = "0x14BE898", VA = "0x14BE898")]
		private void UpdateGuiGroups()
		{
		}

		[Token(Token = "0x600542D")]
		[Address(RVA = "0x14BEBBC", Offset = "0x14BEBBC", VA = "0x14BEBBC")]
		public GuiController()
		{
		}
	}
}
