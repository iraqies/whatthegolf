using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Moga
{
	[Token(Token = "0x20010CF")]
	public class MogaGameController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20010D0")]
		public class MogaTeamInfo
		{
			[Token(Token = "0x4005896")]
			[FieldOffset(Offset = "0x10")]
			public int TeamIndex;

			[Token(Token = "0x4005897")]
			[FieldOffset(Offset = "0x18")]
			public MogaEntity HomeBase;

			[Token(Token = "0x4005898")]
			[FieldOffset(Offset = "0x20")]
			public Color TeamColor;

			[Token(Token = "0x6004B52")]
			[Address(RVA = "0x17F8FDC", Offset = "0x17F8FDC", VA = "0x17F8FDC")]
			public MogaTeamInfo()
			{
			}
		}

		[Token(Token = "0x4005893")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<MogaTeamInfo> teamInfo;

		[Token(Token = "0x4005894")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MogaHealthbar healtbarTemplate;

		[Token(Token = "0x4005895")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<MogaEntity, MogaHealthbar> healthbars;

		[Token(Token = "0x6004B4D")]
		[Address(RVA = "0x156C0F4", Offset = "0x156C0F4", VA = "0x156C0F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004B4E")]
		[Address(RVA = "0x156C16C", Offset = "0x156C16C", VA = "0x156C16C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x156ABB0", Offset = "0x156ABB0", VA = "0x156ABB0")]
		public MogaTeamInfo GetBaseInfoForTeam(int index)
		{
			return null;
		}

		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x156AC40", Offset = "0x156AC40", VA = "0x156AC40")]
		public void RegisterEntity(MogaEntity entity)
		{
		}

		[Token(Token = "0x6004B51")]
		[Address(RVA = "0x156C74C", Offset = "0x156C74C", VA = "0x156C74C")]
		public MogaGameController()
		{
		}
	}
}
