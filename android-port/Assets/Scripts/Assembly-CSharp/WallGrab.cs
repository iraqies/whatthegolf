using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B39")]
public class WallGrab : MonoBehaviour
{
	[Token(Token = "0x4003EA0")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask WallLayers;

	[Token(Token = "0x4003EA1")]
	[FieldOffset(Offset = "0x1C")]
	public float GrabDelay;

	[Token(Token = "0x4003EA2")]
	[FieldOffset(Offset = "0x20")]
	public float BreakForce;

	[Token(Token = "0x4003EA3")]
	[FieldOffset(Offset = "0x24")]
	public float BreakTorque;

	[Token(Token = "0x4003EA4")]
	[FieldOffset(Offset = "0x28")]
	private FixedJoint joint;

	[Token(Token = "0x600356B")]
	[Address(RVA = "0x174FF48", Offset = "0x174FF48", VA = "0x174FF48")]
	private void Start()
	{
	}

	[Token(Token = "0x600356C")]
	[Address(RVA = "0x17500C8", Offset = "0x17500C8", VA = "0x17500C8")]
	private void Instance_OnOutOfBounds()
	{
	}

	[Token(Token = "0x600356D")]
	[Address(RVA = "0x1750188", Offset = "0x1750188", VA = "0x1750188")]
	private void Update()
	{
	}

	[Token(Token = "0x600356E")]
	[Address(RVA = "0x17501C8", Offset = "0x17501C8", VA = "0x17501C8")]
	private void Ball_OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600356F")]
	[Address(RVA = "0x1750284", Offset = "0x1750284", VA = "0x1750284")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003570")]
	[Address(RVA = "0x17504A8", Offset = "0x17504A8", VA = "0x17504A8")]
	public WallGrab()
	{
	}
}
