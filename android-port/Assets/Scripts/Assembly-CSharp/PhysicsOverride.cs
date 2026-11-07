using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200085A")]
public class PhysicsOverride : MonoBehaviour
{
	[Token(Token = "0x4002D5F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 gravity;

	[Token(Token = "0x4002D60")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float bounceThreshold;

	[Token(Token = "0x4002D61")]
	[FieldOffset(Offset = "0x28")]
	private float oldBounceThreshold;

	[Token(Token = "0x4002D62")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 oldGravity;

	[Token(Token = "0x6002688")]
	[Address(RVA = "0x15E19E4", Offset = "0x15E19E4", VA = "0x15E19E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002689")]
	[Address(RVA = "0x15E1A34", Offset = "0x15E1A34", VA = "0x15E1A34")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600268A")]
	[Address(RVA = "0x15E1A68", Offset = "0x15E1A68", VA = "0x15E1A68")]
	public PhysicsOverride()
	{
	}
}
