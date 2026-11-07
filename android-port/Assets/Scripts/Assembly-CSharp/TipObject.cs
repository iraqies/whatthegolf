using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B33")]
public class TipObject : TippableObjectBase
{
	[Token(Token = "0x4003E81")]
	[FieldOffset(Offset = "0x20")]
	public float SleepThreshold;

	[Token(Token = "0x4003E82")]
	[FieldOffset(Offset = "0x24")]
	public float DotThreshold;

	[Token(Token = "0x4003E83")]
	[FieldOffset(Offset = "0x28")]
	public float CheckTimer;

	[Token(Token = "0x4003E84")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 AxisToCheck;

	[Token(Token = "0x4003E85")]
	[FieldOffset(Offset = "0x38")]
	private bool hasBeenTipped;

	[Token(Token = "0x4003E86")]
	[FieldOffset(Offset = "0x3C")]
	private float timer;

	[Token(Token = "0x4003E87")]
	[FieldOffset(Offset = "0x40")]
	public bool extremeTip;

	[Token(Token = "0x6003550")]
	[Address(RVA = "0x1718084", Offset = "0x1718084", VA = "0x1718084")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003551")]
	[Address(RVA = "0x171809C", Offset = "0x171809C", VA = "0x171809C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003552")]
	[Address(RVA = "0x1718264", Offset = "0x1718264", VA = "0x1718264")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003553")]
	[Address(RVA = "0x1718424", Offset = "0x1718424", VA = "0x1718424")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003554")]
	[Address(RVA = "0x17181EC", Offset = "0x17181EC", VA = "0x17181EC")]
	private void Tip()
	{
	}

	[Token(Token = "0x6003555")]
	[Address(RVA = "0x171853C", Offset = "0x171853C", VA = "0x171853C")]
	public TipObject()
	{
	}
}
