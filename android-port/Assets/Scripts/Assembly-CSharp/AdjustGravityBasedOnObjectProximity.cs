using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AF3")]
public class AdjustGravityBasedOnObjectProximity : MonoBehaviour
{
	[Token(Token = "0x4003CFC")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask Mask;

	[Token(Token = "0x4003CFD")]
	[FieldOffset(Offset = "0x1C")]
	public float RaycastDistance;

	[Token(Token = "0x4003CFE")]
	[FieldOffset(Offset = "0x20")]
	public float MaxWaitTime;

	[Token(Token = "0x4003CFF")]
	[FieldOffset(Offset = "0x24")]
	public float PullForce;

	[Token(Token = "0x4003D00")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4003D01")]
	[FieldOffset(Offset = "0x30")]
	private float waitTime;

	[Token(Token = "0x600343B")]
	[Address(RVA = "0x1408C20", Offset = "0x1408C20", VA = "0x1408C20")]
	private void Start()
	{
	}

	[Token(Token = "0x600343C")]
	[Address(RVA = "0x1408D08", Offset = "0x1408D08", VA = "0x1408D08")]
	private void Ball_OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600343D")]
	[Address(RVA = "0x1408D60", Offset = "0x1408D60", VA = "0x1408D60")]
	private void Update()
	{
	}

	[Token(Token = "0x600343E")]
	[Address(RVA = "0x1408EDC", Offset = "0x1408EDC", VA = "0x1408EDC")]
	public AdjustGravityBasedOnObjectProximity()
	{
	}
}
