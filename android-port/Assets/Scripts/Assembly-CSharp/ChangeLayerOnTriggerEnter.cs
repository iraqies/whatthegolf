using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002EE")]
public class ChangeLayerOnTriggerEnter : MonoBehaviour
{
	[Token(Token = "0x4001032")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask ValidLayers;

	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0x20")]
	public string NewLayer;

	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x18975D0", Offset = "0x18975D0", VA = "0x18975D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x18976A8", Offset = "0x18976A8", VA = "0x18976A8")]
	public ChangeLayerOnTriggerEnter()
	{
	}
}
