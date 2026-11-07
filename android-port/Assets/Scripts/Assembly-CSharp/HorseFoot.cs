using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008A4")]
public class HorseFoot : MonoBehaviour
{
	[Token(Token = "0x4002F73")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody target;

	[Token(Token = "0x4002F74")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float force;

	[Token(Token = "0x4002F75")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float maxAngularVelocity;

	[Token(Token = "0x4002F76")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 targetPositionScale;

	[Token(Token = "0x4002F77")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector3 spherePoint;

	[Token(Token = "0x4002F78")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 RunVelocity;

	[Token(Token = "0x4002F79")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody body;

	[Token(Token = "0x60027EE")]
	[Address(RVA = "0x14D4E64", Offset = "0x14D4E64", VA = "0x14D4E64")]
	private void Awake()
	{
	}

	[Token(Token = "0x60027EF")]
	[Address(RVA = "0x14D5018", Offset = "0x14D5018", VA = "0x14D5018")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60027F0")]
	[Address(RVA = "0x14D4E88", Offset = "0x14D4E88", VA = "0x14D4E88")]
	private Rigidbody MakeDummy()
	{
		return null;
	}

	[Token(Token = "0x60027F1")]
	[Address(RVA = "0x14D5164", Offset = "0x14D5164", VA = "0x14D5164")]
	public HorseFoot()
	{
	}
}
