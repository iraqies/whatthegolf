using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BD3")]
public class DeactivateObjectOnAwake : MonoBehaviour
{
	[Token(Token = "0x40041C8")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> ObjectsToDeactivate;

	[Token(Token = "0x60038DC")]
	[Address(RVA = "0x18D4B20", Offset = "0x18D4B20", VA = "0x18D4B20")]
	private void Awake()
	{
	}

	[Token(Token = "0x60038DD")]
	[Address(RVA = "0x18D4C74", Offset = "0x18D4C74", VA = "0x18D4C74")]
	public DeactivateObjectOnAwake()
	{
	}
}
