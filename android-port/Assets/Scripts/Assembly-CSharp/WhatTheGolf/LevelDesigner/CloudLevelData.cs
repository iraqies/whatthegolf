using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x200122E")]
	public class CloudLevelData
	{
		[Token(Token = "0x4006248")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public SerializableLevelData levelData;

		[Token(Token = "0x60053C7")]
		[Address(RVA = "0x18A0E44", Offset = "0x18A0E44", VA = "0x18A0E44")]
		public CloudLevelData()
		{
		}
	}
}
