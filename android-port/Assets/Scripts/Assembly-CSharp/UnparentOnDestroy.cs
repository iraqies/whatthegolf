using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C6C")]
public class UnparentOnDestroy : MonoBehaviour
{
	[Token(Token = "0x400440E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Transform> childrenToUnparent;

	[Token(Token = "0x6003AF4")]
	[Address(RVA = "0x173D0DC", Offset = "0x173D0DC", VA = "0x173D0DC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003AF5")]
	[Address(RVA = "0x173D230", Offset = "0x173D230", VA = "0x173D230")]
	public UnparentOnDestroy()
	{
	}
}
