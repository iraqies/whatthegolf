using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009B7")]
public class GizmoLabel : MonoBehaviour
{
	[Token(Token = "0x4003551")]
	[FieldOffset(Offset = "0x18")]
	public string label;

	[Token(Token = "0x4003552")]
	[FieldOffset(Offset = "0x20")]
	public Transform nameFromTransform;

	[Token(Token = "0x4003553")]
	[FieldOffset(Offset = "0x28")]
	public Color color;

	[Token(Token = "0x6002DA0")]
	[Address(RVA = "0x148D7A8", Offset = "0x148D7A8", VA = "0x148D7A8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002DA1")]
	[Address(RVA = "0x148D91C", Offset = "0x148D91C", VA = "0x148D91C")]
	public GizmoLabel()
	{
	}
}
