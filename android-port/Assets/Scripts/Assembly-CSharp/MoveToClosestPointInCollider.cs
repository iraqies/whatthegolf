using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003A1")]
public class MoveToClosestPointInCollider : MonoBehaviour
{
	[Token(Token = "0x4001411")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform m_proximityTarget;

	[Token(Token = "0x4001412")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform targetToMove;

	[Token(Token = "0x4001413")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float checkCooldown;

	[Token(Token = "0x4001414")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Collider[] m_collider;

	[Token(Token = "0x4001415")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Collider2D[] m_collider2D;

	[Token(Token = "0x4001416")]
	[FieldOffset(Offset = "0x40")]
	private float m_lastCheckTime;

	[Token(Token = "0x6001140")]
	[Address(RVA = "0x15742E4", Offset = "0x15742E4", VA = "0x15742E4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001141")]
	[Address(RVA = "0x15744E8", Offset = "0x15744E8", VA = "0x15744E8")]
	public MoveToClosestPointInCollider()
	{
	}
}
