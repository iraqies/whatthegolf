using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000045")]
public class ToggleGameobjectBasedOnMonth : MonoBehaviour
{
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int month;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> objectsToToggle;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x171A680", Offset = "0x171A680", VA = "0x171A680")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x171A83C", Offset = "0x171A83C", VA = "0x171A83C")]
	public ToggleGameobjectBasedOnMonth()
	{
	}
}
