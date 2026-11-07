using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007C4")]
public class MagicCup : MonoBehaviour
{
	[Token(Token = "0x4002921")]
	[FieldOffset(Offset = "0x18")]
	public MagicCupSorter Sorter;

	[Token(Token = "0x4002922")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 ContentCheckSize;

	[Token(Token = "0x4002923")]
	[FieldOffset(Offset = "0x2C")]
	public LayerMask ContentBlacklist;

	[Token(Token = "0x4002924")]
	[FieldOffset(Offset = "0x30")]
	public Transform TeleportContentPosition;

	[Token(Token = "0x4002925")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigid;

	[Token(Token = "0x4002926")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> currentContent;

	[Token(Token = "0x4002927")]
	[FieldOffset(Offset = "0x48")]
	private List<Vector3> contentOffsets;

	[Token(Token = "0x6002391")]
	[Address(RVA = "0x1552230", Offset = "0x1552230", VA = "0x1552230")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002392")]
	[Address(RVA = "0x155231C", Offset = "0x155231C", VA = "0x155231C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002393")]
	[Address(RVA = "0x1552500", Offset = "0x1552500", VA = "0x1552500")]
	public void Move(Vector3 pos)
	{
	}

	[Token(Token = "0x6002394")]
	[Address(RVA = "0x155251C", Offset = "0x155251C", VA = "0x155251C")]
	public void Rotate(Quaternion rot)
	{
	}

	[Token(Token = "0x6002395")]
	[Address(RVA = "0x1552538", Offset = "0x1552538", VA = "0x1552538")]
	public void HideContents()
	{
	}

	[Token(Token = "0x6002396")]
	[Address(RVA = "0x15527F0", Offset = "0x15527F0", VA = "0x15527F0")]
	public void ShowContents()
	{
	}

	[Token(Token = "0x6002397")]
	[Address(RVA = "0x15529A8", Offset = "0x15529A8", VA = "0x15529A8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002398")]
	[Address(RVA = "0x15529E8", Offset = "0x15529E8", VA = "0x15529E8")]
	public MagicCup()
	{
	}
}
