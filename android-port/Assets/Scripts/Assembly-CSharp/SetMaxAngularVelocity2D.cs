using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B2B")]
public class SetMaxAngularVelocity2D : MonoBehaviour
{
	[Token(Token = "0x4003E5E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float maxAngularVelocity;

	[Token(Token = "0x4003E5F")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool includeChildren;

	[Token(Token = "0x4003E60")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody2D[] bodies;

	[Token(Token = "0x6003533")]
	[Address(RVA = "0x168E6EC", Offset = "0x168E6EC", VA = "0x168E6EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003534")]
	[Address(RVA = "0x168E7E8", Offset = "0x168E7E8", VA = "0x168E7E8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003535")]
	[Address(RVA = "0x168E87C", Offset = "0x168E87C", VA = "0x168E87C")]
	public SetMaxAngularVelocity2D()
	{
	}
}
