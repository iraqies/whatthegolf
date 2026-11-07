using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001292")]
	public class MenuLevelInfoGUI : MonoBehaviour
	{
		[Token(Token = "0x40063F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LevelCoverButtonGUI levelCover;

		[Token(Token = "0x40063F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI levelTitle;

		[Token(Token = "0x40063F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI levelDescription;

		[Token(Token = "0x40063F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI sharingLink;

		[Token(Token = "0x40063F5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button cloneLevelButton;

		[Token(Token = "0x40063F6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button copyLevelLinkButton;

		[Token(Token = "0x40063F7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject sharingLinkContainer;

		[Token(Token = "0x40063F8")]
		[FieldOffset(Offset = "0x50")]
		private SerializableLevelData levelData;

		[Token(Token = "0x40063F9")]
		[FieldOffset(Offset = "0x58")]
		private Action<SerializableLevelData> action;

		[Token(Token = "0x40063FA")]
		[FieldOffset(Offset = "0x60")]
		private bool subscribed;

		[Token(Token = "0x60055F8")]
		[Address(RVA = "0x1565DB4", Offset = "0x1565DB4", VA = "0x1565DB4")]
		public void Init(SerializableLevelData levelData, Action<SerializableLevelData> action, Sprite actionIcon)
		{
		}

		[Token(Token = "0x60055F9")]
		[Address(RVA = "0x1566090", Offset = "0x1566090", VA = "0x1566090")]
		private void LevelCover_OnSelected(SerializableLevelData levelData)
		{
		}

		[Token(Token = "0x60055FA")]
		[Address(RVA = "0x1566100", Offset = "0x1566100", VA = "0x1566100")]
		private void CloneLevel()
		{
		}

		[Token(Token = "0x60055FB")]
		[Address(RVA = "0x1566174", Offset = "0x1566174", VA = "0x1566174")]
		private void CopyLevelLink()
		{
		}

		[Token(Token = "0x60055FC")]
		[Address(RVA = "0x15661FC", Offset = "0x15661FC", VA = "0x15661FC")]
		public MenuLevelInfoGUI()
		{
		}
	}
}
