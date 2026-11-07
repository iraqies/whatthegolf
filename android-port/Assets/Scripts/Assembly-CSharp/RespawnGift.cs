using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F24")]
public class RespawnGift : MonoBehaviour
{
	[Token(Token = "0x40051AD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject prizePrefab;

	[Token(Token = "0x40051AE")]
	[FieldOffset(Offset = "0x20")]
	private Transform prizeParent;

	[Token(Token = "0x40051AF")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 prizePosition;

	[Token(Token = "0x40051B0")]
	[FieldOffset(Offset = "0x34")]
	private Quaternion prizeRotation;

	[Token(Token = "0x60046C7")]
	[Address(RVA = "0x164CC5C", Offset = "0x164CC5C", VA = "0x164CC5C")]
	public void Start()
	{
	}

	[Token(Token = "0x60046C8")]
	[Address(RVA = "0x164CCD4", Offset = "0x164CCD4", VA = "0x164CCD4")]
	public void RespawnPrize()
	{
	}

	[Token(Token = "0x60046C9")]
	[Address(RVA = "0x164CDB0", Offset = "0x164CDB0", VA = "0x164CDB0")]
	public RespawnGift()
	{
	}
}
