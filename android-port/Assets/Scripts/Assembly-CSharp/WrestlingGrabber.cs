using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x200027D")]
public class WrestlingGrabber : MonoBehaviour
{
	[Token(Token = "0x4000D20")]
	[FieldOffset(Offset = "0x18")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000D21")]
	[FieldOffset(Offset = "0x20")]
	public int grabLayer;

	[Token(Token = "0x4000D22")]
	[FieldOffset(Offset = "0x24")]
	public float massScale;

	[Token(Token = "0x4000D23")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF64", Offset = "0x4AF64")]
	private bool Grabbed__BackingField;

	[Token(Token = "0x4000D24")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AF74", Offset = "0x4AF74")]
	private BehaviourPuppet GrabbedPuppet__BackingField;

	[Token(Token = "0x4000D25")]
	[FieldOffset(Offset = "0x38")]
	private ConfigurableJoint joint;

	[Token(Token = "0x4000D26")]
	[FieldOffset(Offset = "0x40")]
	private Collider otherCollider;

	[Token(Token = "0x4000D27")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody thisRigidbody;

	[Token(Token = "0x4000D28")]
	[FieldOffset(Offset = "0x50")]
	private Collider thisCollider;

	[Token(Token = "0x4000D29")]
	private const float massMlp = 15f;

	[Token(Token = "0x4000D2A")]
	private const int solverIterationMlp = 20;

	[Token(Token = "0x1700015A")]
	public bool Grabbed
	{
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x175C298", Offset = "0x175C298", VA = "0x175C298")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FF7C", Offset = "0x5FF7C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x175C2A0", Offset = "0x175C2A0", VA = "0x175C2A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FF8C", Offset = "0x5FF8C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700015B")]
	public BehaviourPuppet GrabbedPuppet
	{
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x175C2A8", Offset = "0x175C2A8", VA = "0x175C2A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FF9C", Offset = "0x5FF9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x175C2B0", Offset = "0x175C2B0", VA = "0x175C2B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFAC", Offset = "0x5FFAC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x175C2B8", Offset = "0x175C2B8", VA = "0x175C2B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x175C338", Offset = "0x175C338", VA = "0x175C338")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x175C494", Offset = "0x175C494", VA = "0x175C494")]
	private void DoGrab(Collision collision, MuscleCollisionBroadcaster muscle)
	{
	}

	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x175C770", Offset = "0x175C770", VA = "0x175C770")]
	private void Update()
	{
	}

	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0x175C7AC", Offset = "0x175C7AC", VA = "0x175C7AC")]
	private void Release()
	{
	}

	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x175C8C4", Offset = "0x175C8C4", VA = "0x175C8C4")]
	public WrestlingGrabber()
	{
	}
}
