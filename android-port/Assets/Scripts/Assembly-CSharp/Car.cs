using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AF6")]
[Attribute(Name = "RequireComponent", RVA = "0x433D8", Offset = "0x433D8")]
public class Car : MonoBehaviour
{
	[Token(Token = "0x4003D0A")]
	[FieldOffset(Offset = "0x18")]
	public bool isApplyingBaseForward;

	[Token(Token = "0x4003D0B")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float bounceYAngleThreshold;

	[Token(Token = "0x4003D0C")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody rigid;

	[Token(Token = "0x4003D0D")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 lastVelocity;

	[Token(Token = "0x4003D0E")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 lastAngularVelocity;

	[Token(Token = "0x6003445")]
	[Address(RVA = "0x1887820", Offset = "0x1887820", VA = "0x1887820")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003446")]
	[Address(RVA = "0x188787C", Offset = "0x188787C", VA = "0x188787C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003447")]
	[Address(RVA = "0x18878CC", Offset = "0x18878CC", VA = "0x18878CC")]
	public void Push(Vector3 newForce)
	{
	}

	[Token(Token = "0x6003448")]
	[Address(RVA = "0x1887914", Offset = "0x1887914", VA = "0x1887914")]
	private void OnCollisionEnter(Collision col)
	{
	}

	[Token(Token = "0x6003449")]
	[Address(RVA = "0x1887CEC", Offset = "0x1887CEC", VA = "0x1887CEC")]
	public void IgnoreLastCollision(float amount)
	{
	}

	[Token(Token = "0x600344A")]
	[Address(RVA = "0x1887D20", Offset = "0x1887D20", VA = "0x1887D20")]
	public Car()
	{
	}
}
