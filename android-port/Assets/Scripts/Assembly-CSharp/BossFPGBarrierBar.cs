using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000625")]
public class BossFPGBarrierBar : MonoBehaviour
{
	[Token(Token = "0x4001FB5")]
	[FieldOffset(Offset = "0x18")]
	public BossFPGBarrier barrier;

	[Token(Token = "0x6001BFE")]
	[Address(RVA = "0x16FC6C8", Offset = "0x16FC6C8", VA = "0x16FC6C8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001BFF")]
	[Address(RVA = "0x16FC7EC", Offset = "0x16FC7EC", VA = "0x16FC7EC")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6001C00")]
	[Address(RVA = "0x16FC90C", Offset = "0x16FC90C", VA = "0x16FC90C")]
	public BossFPGBarrierBar()
	{
	}
}
