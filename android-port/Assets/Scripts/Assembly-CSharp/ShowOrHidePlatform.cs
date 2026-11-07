using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E5C")]
public class ShowOrHidePlatform : MonoBehaviour
{
	[Token(Token = "0x4004DCE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<GameObject> toHide;

	[Token(Token = "0x4004DCF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> replaceBy;

	[Token(Token = "0x4004DD0")]
	[FieldOffset(Offset = "0x28")]
	public bool isForAchievements;

	[Token(Token = "0x4004DD1")]
	[FieldOffset(Offset = "0x29")]
	public bool isForLeaderboards;

	[Token(Token = "0x6004336")]
	[Address(RVA = "0x16A5FD4", Offset = "0x16A5FD4", VA = "0x16A5FD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6004337")]
	[Address(RVA = "0x16A5FD8", Offset = "0x16A5FD8", VA = "0x16A5FD8")]
	private void ToggleVisibility()
	{
	}

	[Token(Token = "0x6004338")]
	[Address(RVA = "0x16A624C", Offset = "0x16A624C", VA = "0x16A624C")]
	public ShowOrHidePlatform()
	{
	}
}
