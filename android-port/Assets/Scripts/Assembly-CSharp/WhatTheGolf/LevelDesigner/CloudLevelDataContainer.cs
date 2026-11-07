using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x200122D")]
	public class CloudLevelDataContainer
	{
		[Token(Token = "0x4006247")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public CloudLevelData[] levelDatas;

		[Token(Token = "0x60053C6")]
		[Address(RVA = "0x18A0E4C", Offset = "0x18A0E4C", VA = "0x18A0E4C")]
		public CloudLevelDataContainer()
		{
		}
	}
}
