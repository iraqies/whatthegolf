using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000DA4")]
public class LivingHouse : MonoBehaviour
{
	[Token(Token = "0x4004A56")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Transform> _targets;

	[Token(Token = "0x4004A57")]
	[FieldOffset(Offset = "0x20")]
	public bool canMove;

	[Token(Token = "0x4004A58")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody rb;

	[Token(Token = "0x4004A59")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x4004A5A")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool _contantMove;

	[Token(Token = "0x4004A5B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _waitBetweenMovesIfConstant;

	[Token(Token = "0x4004A5C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve _speedgain;

	[Token(Token = "0x4004A5D")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private double _moveTime;

	[Token(Token = "0x4004A5E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AnimationCurve _yCurve;

	[Token(Token = "0x4004A5F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float yHeight;

	[Token(Token = "0x4004A60")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4004A61")]
	[FieldOffset(Offset = "0x68")]
	public UnityEvent OnMove;

	[Token(Token = "0x4004A62")]
	[FieldOffset(Offset = "0x70")]
	public UnityEvent OnStop;

	[Token(Token = "0x4004A63")]
	[FieldOffset(Offset = "0x78")]
	private bool moving;

	[Token(Token = "0x4004A64")]
	[FieldOffset(Offset = "0x7C")]
	private int index;

	[Token(Token = "0x4004A65")]
	[FieldOffset(Offset = "0x80")]
	private double accDeltaTime;

	[Token(Token = "0x17000691")]
	private int from
	{
		[Token(Token = "0x6004025")]
		[Address(RVA = "0x1536D54", Offset = "0x1536D54", VA = "0x1536D54")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000692")]
	private int to
	{
		[Token(Token = "0x6004026")]
		[Address(RVA = "0x1536DAC", Offset = "0x1536DAC", VA = "0x1536DAC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6004027")]
	[Address(RVA = "0x1536DB4", Offset = "0x1536DB4", VA = "0x1536DB4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6004028")]
	[Address(RVA = "0x1536E8C", Offset = "0x1536E8C", VA = "0x1536E8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6004029")]
	[Address(RVA = "0x1537090", Offset = "0x1537090", VA = "0x1537090")]
	private void OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600402A")]
	[Address(RVA = "0x15371CC", Offset = "0x15371CC", VA = "0x15371CC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600402B")]
	[Address(RVA = "0x1537374", Offset = "0x1537374", VA = "0x1537374")]
	public void SetCanMove(bool b)
	{
	}

	[Token(Token = "0x600402C")]
	[Address(RVA = "0x153737C", Offset = "0x153737C", VA = "0x153737C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600402D")]
	[Address(RVA = "0x15377FC", Offset = "0x15377FC", VA = "0x15377FC")]
	public LivingHouse()
	{
	}
}
