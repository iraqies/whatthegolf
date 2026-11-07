using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B2A")]
public class SetMaxAngularVelocity : MonoBehaviour
{
	[Token(Token = "0x4003E5C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float maxAngularVelocity;

	[Token(Token = "0x4003E5D")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool includeChildren;

	[Token(Token = "0x6003531")]
	[Address(RVA = "0x168E5E4", Offset = "0x168E5E4", VA = "0x168E5E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003532")]
	[Address(RVA = "0x168E6DC", Offset = "0x168E6DC", VA = "0x168E6DC")]
	public SetMaxAngularVelocity()
	{
	}
}
