using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200087C")]
public class TennisPlayerIK : MonoBehaviour
{
	[Token(Token = "0x4002E82")]
	[FieldOffset(Offset = "0x18")]
	public Transform Ball;

	[Token(Token = "0x4002E83")]
	[FieldOffset(Offset = "0x20")]
	public float Threshold;

	[Token(Token = "0x4002E84")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 LocalOffset;

	[Token(Token = "0x4002E85")]
	[FieldOffset(Offset = "0x30")]
	private Animator animator;

	[Token(Token = "0x6002725")]
	[Address(RVA = "0x170EBA0", Offset = "0x170EBA0", VA = "0x170EBA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002726")]
	[Address(RVA = "0x170EBFC", Offset = "0x170EBFC", VA = "0x170EBFC")]
	private void OnAnimatorIK(int layer)
	{
	}

	[Token(Token = "0x6002727")]
	[Address(RVA = "0x170EF40", Offset = "0x170EF40", VA = "0x170EF40")]
	public TennisPlayerIK()
	{
	}
}
