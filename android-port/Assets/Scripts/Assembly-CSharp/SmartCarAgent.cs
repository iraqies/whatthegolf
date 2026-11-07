using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B8E")]
public class SmartCarAgent : MonoBehaviour
{
	[Token(Token = "0x400405B")]
	[FieldOffset(Offset = "0x18")]
	public float Speed;

	[Token(Token = "0x400405C")]
	[FieldOffset(Offset = "0x1C")]
	public float Gravity;

	[Token(Token = "0x400405D")]
	[FieldOffset(Offset = "0x20")]
	public float RotateSpeed;

	[Token(Token = "0x400405E")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask IgnoreLayers;

	[Token(Token = "0x400405F")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigid;

	[Token(Token = "0x4004060")]
	[FieldOffset(Offset = "0x30")]
	private TrafficController.TrafficPoint _currentPath;

	[Token(Token = "0x4004061")]
	[FieldOffset(Offset = "0x38")]
	private bool isLocked;

	[Token(Token = "0x4004062")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 smoothedNormal;

	[Token(Token = "0x4004063")]
	[FieldOffset(Offset = "0x48")]
	private float nonGroundTime;

	[Token(Token = "0x4004064")]
	[FieldOffset(Offset = "0x4C")]
	private bool hasBeenFlat;

	[Token(Token = "0x4004065")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 smoothedFlatForward;

	[Token(Token = "0x60037C0")]
	[Address(RVA = "0x16B7408", Offset = "0x16B7408", VA = "0x16B7408")]
	private void Awake()
	{
	}

	[Token(Token = "0x60037C1")]
	[Address(RVA = "0x16B74AC", Offset = "0x16B74AC", VA = "0x16B74AC")]
	public void Iniitialize(Vector3 position, Vector3 forward)
	{
	}

	[Token(Token = "0x60037C2")]
	[Address(RVA = "0x16B7590", Offset = "0x16B7590", VA = "0x16B7590")]
	private Vector3 GetNormal()
	{
		return default;
	}

	[Token(Token = "0x60037C3")]
	[Address(RVA = "0x16B768C", Offset = "0x16B768C", VA = "0x16B768C")]
	private void Unlock()
	{
	}

	[Token(Token = "0x60037C4")]
	[Address(RVA = "0x16B76D0", Offset = "0x16B76D0", VA = "0x16B76D0")]
	private bool IsGrounded()
	{
		return default;
	}

	[Token(Token = "0x60037C5")]
	[Address(RVA = "0x16B778C", Offset = "0x16B778C", VA = "0x16B778C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60037C6")]
	[Address(RVA = "0x16B7908", Offset = "0x16B7908", VA = "0x16B7908")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60037C7")]
	[Address(RVA = "0x16B7C2C", Offset = "0x16B7C2C", VA = "0x16B7C2C")]
	public SmartCarAgent()
	{
	}
}
