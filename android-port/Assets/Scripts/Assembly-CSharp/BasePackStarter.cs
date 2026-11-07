using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000183")]
public abstract class BasePackStarter : MonoBehaviour
{
	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool> OnPackDone;

	[Token(Token = "0x60006A8")]
	public abstract bool StartPack(ContentPack pack, params object[] additionalContext);

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x1608240", Offset = "0x1608240", VA = "0x1608240")]
	protected BasePackStarter()
	{
	}
}
