using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AF9")]
public class CatIn2D : MonoBehaviour
{
	[Token(Token = "0x4003D16")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ToggleGenericRagdoll toggleRagdoll;

	[Token(Token = "0x4003D17")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float correctDirForcePush;

	[Token(Token = "0x4003D18")]
	[FieldOffset(Offset = "0x24")]
	private bool didHit;

	[Token(Token = "0x4003D19")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigid;

	[Token(Token = "0x600344F")]
	[Address(RVA = "0x18908E4", Offset = "0x18908E4", VA = "0x18908E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003450")]
	[Address(RVA = "0x1890940", Offset = "0x1890940", VA = "0x1890940")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6003451")]
	[Address(RVA = "0x1890B78", Offset = "0x1890B78", VA = "0x1890B78")]
	public CatIn2D()
	{
	}
}
