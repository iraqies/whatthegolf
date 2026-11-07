using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D3")]
public class DestroyJointsOnCollision : MonoBehaviour
{
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x18")]
	public List<Joint> JointsToDestroy;

	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask CollisionLayer;

	[Token(Token = "0x6000833")]
	[Address(RVA = "0x18DAB60", Offset = "0x18DAB60", VA = "0x18DAB60")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0x18DAD0C", Offset = "0x18DAD0C", VA = "0x18DAD0C")]
	public DestroyJointsOnCollision()
	{
	}
}
