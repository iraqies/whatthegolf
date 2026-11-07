using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C10")]
public class OrbitalTrailRenderer : MonoBehaviour
{
	[Token(Token = "0x40042AC")]
	[FieldOffset(Offset = "0x18")]
	public Collider OrbitObject;

	[Token(Token = "0x40042AD")]
	[FieldOffset(Offset = "0x20")]
	public float GroundDistance;

	[Token(Token = "0x40042AE")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigid;

	[Token(Token = "0x40042AF")]
	[FieldOffset(Offset = "0x30")]
	private TrailRenderer trail;

	[Token(Token = "0x60039D4")]
	[Address(RVA = "0x159DE3C", Offset = "0x159DE3C", VA = "0x159DE3C")]
	private void Start()
	{
	}

	[Token(Token = "0x60039D5")]
	[Address(RVA = "0x159DEBC", Offset = "0x159DEBC", VA = "0x159DEBC")]
	private void Update()
	{
	}

	[Token(Token = "0x60039D6")]
	[Address(RVA = "0x159E030", Offset = "0x159E030", VA = "0x159E030")]
	public OrbitalTrailRenderer()
	{
	}
}
