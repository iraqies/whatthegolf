using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D9E")]
public class LivingCarpet : MonoBehaviour
{
	[Token(Token = "0x4004A29")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private HingeJoint _joint;

	[Token(Token = "0x4004A2A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _targetVel;

	[Token(Token = "0x4004A2B")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _forceStrengh;

	[Token(Token = "0x4004A2C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _timeDown;

	[Token(Token = "0x4004A2D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _forceDir;

	[Token(Token = "0x4004A2E")]
	[FieldOffset(Offset = "0x38")]
	private bool move;

	[Token(Token = "0x4004A2F")]
	[FieldOffset(Offset = "0x40")]
	private double time;

	[Token(Token = "0x6004006")]
	[Address(RVA = "0x153566C", Offset = "0x153566C", VA = "0x153566C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6004007")]
	[Address(RVA = "0x1535730", Offset = "0x1535730", VA = "0x1535730")]
	private void Start()
	{
	}

	[Token(Token = "0x6004008")]
	[Address(RVA = "0x1535844", Offset = "0x1535844", VA = "0x1535844")]
	private void CollisionEnterTrigger(Rigidbody obj)
	{
	}

	[Token(Token = "0x6004009")]
	[Address(RVA = "0x1535928", Offset = "0x1535928", VA = "0x1535928")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600400A")]
	[Address(RVA = "0x1535A44", Offset = "0x1535A44", VA = "0x1535A44")]
	private void Update()
	{
	}

	[Token(Token = "0x600400B")]
	[Address(RVA = "0x1535ADC", Offset = "0x1535ADC", VA = "0x1535ADC")]
	public LivingCarpet()
	{
	}
}
