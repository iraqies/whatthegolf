using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200017A")]
public class UnlockablesManager : ScriptableObject
{
	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UnlockList unlocks;

	[Token(Token = "0x170000D5")]
	public int CoinsAvailable
	{
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x173C580", Offset = "0x173C580", VA = "0x173C580")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x173C5CC", Offset = "0x173C5CC", VA = "0x173C5CC")]
		set
		{
		}
	}

	[Token(Token = "0x170000D6")]
	public int CoinsDonatedLocally
	{
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x173C624", Offset = "0x173C624", VA = "0x173C624")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x173C670", Offset = "0x173C670", VA = "0x173C670")]
		set
		{
		}
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x173C6C8", Offset = "0x173C6C8", VA = "0x173C6C8")]
	public UnlockableContentPackage GetPackage(int coinsDonated)
	{
		return null;
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x173C72C", Offset = "0x173C72C", VA = "0x173C72C")]
	public List<LevelData> GetAllUnlockedLevels()
	{
		return null;
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x173C9B0", Offset = "0x173C9B0", VA = "0x173C9B0")]
	public List<LevelData> GetUnlockableLevels()
	{
		return null;
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x173CC20", Offset = "0x173CC20", VA = "0x173CC20")]
	public List<PlayerColors.AvatarIDs> GetAllUnlockedAvatars()
	{
		return null;
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x173CDD8", Offset = "0x173CDD8", VA = "0x173CDD8")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5ECA8", Offset = "0x5ECA8")]
	public void ResetAll()
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x173CE5C", Offset = "0x173CE5C", VA = "0x173CE5C")]
	public UnlockablesManager()
	{
	}
}
