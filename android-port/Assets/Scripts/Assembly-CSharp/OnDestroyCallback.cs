using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000413")]
public class OnDestroyCallback : MonoBehaviour
{
	[Token(Token = "0x4001642")]
	[FieldOffset(Offset = "0x18")]
	public Action<GameObject> OnWillDestroy;

	[Token(Token = "0x600132E")]
	[Address(RVA = "0x1599CEC", Offset = "0x1599CEC", VA = "0x1599CEC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600132F")]
	[Address(RVA = "0x1599D60", Offset = "0x1599D60", VA = "0x1599D60")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001330")]
	[Address(RVA = "0x1599DD4", Offset = "0x1599DD4", VA = "0x1599DD4")]
	public OnDestroyCallback()
	{
	}
}
