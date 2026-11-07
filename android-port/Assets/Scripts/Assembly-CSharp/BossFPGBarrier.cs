using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000624")]
public class BossFPGBarrier : MonoBehaviour
{
	[Token(Token = "0x4001FAE")]
	[FieldOffset(Offset = "0x18")]
	public List<AudioClip> HitClips;

	[Token(Token = "0x4001FAF")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask AcceptedLayers;

	[Token(Token = "0x4001FB0")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody BarTrans;

	[Token(Token = "0x4001FB1")]
	[FieldOffset(Offset = "0x30")]
	public float MoveSpeed;

	[Token(Token = "0x4001FB2")]
	[FieldOffset(Offset = "0x34")]
	private bool isUp;

	[Token(Token = "0x4001FB3")]
	[FieldOffset(Offset = "0x35")]
	private bool nextState;

	[Token(Token = "0x4001FB4")]
	[FieldOffset(Offset = "0x38")]
	private float changeStateTimer;

	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0x16FC3F0", Offset = "0x16FC3F0", VA = "0x16FC3F0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6001BFA")]
	[Address(RVA = "0x16FC480", Offset = "0x16FC480", VA = "0x16FC480")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001BFB")]
	[Address(RVA = "0x16FC530", Offset = "0x16FC530", VA = "0x16FC530")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001BFC")]
	[Address(RVA = "0x16FC694", Offset = "0x16FC694", VA = "0x16FC694")]
	public void SetTarget(bool goUp)
	{
	}

	[Token(Token = "0x6001BFD")]
	[Address(RVA = "0x16FC6B8", Offset = "0x16FC6B8", VA = "0x16FC6B8")]
	public BossFPGBarrier()
	{
	}
}
