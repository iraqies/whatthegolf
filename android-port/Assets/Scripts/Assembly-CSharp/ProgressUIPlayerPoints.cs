using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000171")]
public class ProgressUIPlayerPoints : MonoBehaviour
{
	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x18")]
	public Image Background;

	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x20")]
	public Image Border;

	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x28")]
	public Animator Animator;

	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x30")]
	public List<ProgressUICrown> Crowns;

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x16275D0", Offset = "0x16275D0", VA = "0x16275D0")]
	public ProgressUIPlayerPoints()
	{
	}
}
