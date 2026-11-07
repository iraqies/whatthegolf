using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000714")]
public class ClusterPuttShooter : GolfBallShooterBase
{
	[Token(Token = "0x4002543")]
	[FieldOffset(Offset = "0x60")]
	public float Force;

	[Token(Token = "0x4002544")]
	[FieldOffset(Offset = "0x64")]
	public float Pitch;

	[Token(Token = "0x4002545")]
	[FieldOffset(Offset = "0x68")]
	public Vector2 RandomRange;

	[Token(Token = "0x4002546")]
	[FieldOffset(Offset = "0x70")]
	public float InheritVelocity;

	[Token(Token = "0x4002547")]
	[FieldOffset(Offset = "0x78")]
	public Rigidbody[] rigidbodies;

	[Token(Token = "0x4002548")]
	[FieldOffset(Offset = "0x80")]
	public Rigidbody[] blacklist;

	[Token(Token = "0x4002549")]
	[FieldOffset(Offset = "0x88")]
	public GameObject Tracker;

	[Token(Token = "0x400254A")]
	[FieldOffset(Offset = "0x90")]
	public float MaxAutoAimDistance;

	[Token(Token = "0x400254B")]
	[FieldOffset(Offset = "0x94")]
	public float SphereCastRadius;

	[Token(Token = "0x400254C")]
	[FieldOffset(Offset = "0x98")]
	private Collider onCar;

	[Token(Token = "0x400254D")]
	[FieldOffset(Offset = "0xA0")]
	private BlockIfNotNearStuff blocker;

	[Token(Token = "0x400254E")]
	[FieldOffset(Offset = "0xA8")]
	private float delay;

	[Token(Token = "0x400254F")]
	[FieldOffset(Offset = "0xAC")]
	private float trackerTimer;

	[Token(Token = "0x4002550")]
	[FieldOffset(Offset = "0xB0")]
	private Collider lastTrackerHit;

	[Token(Token = "0x4002551")]
	[FieldOffset(Offset = "0xB8")]
	private string carLayer;

	[Token(Token = "0x60020AD")]
	[Address(RVA = "0x18A5B00", Offset = "0x18A5B00", VA = "0x18A5B00", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60020AE")]
	[Address(RVA = "0x18A5BF4", Offset = "0x18A5BF4", VA = "0x18A5BF4")]
	private void Update()
	{
	}

	[Token(Token = "0x60020AF")]
	[Address(RVA = "0x18A5C6C", Offset = "0x18A5C6C", VA = "0x18A5C6C", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60020B0")]
	[Address(RVA = "0x18A616C", Offset = "0x18A616C", VA = "0x18A616C", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x60020B1")]
	[Address(RVA = "0x18A61A4", Offset = "0x18A61A4", VA = "0x18A61A4", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60020B2")]
	[Address(RVA = "0x18A6994", Offset = "0x18A6994", VA = "0x18A6994")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60020B3")]
	[Address(RVA = "0x18A6A70", Offset = "0x18A6A70", VA = "0x18A6A70")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60020B4")]
	[Address(RVA = "0x18A6B20", Offset = "0x18A6B20", VA = "0x18A6B20")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60020B5")]
	[Address(RVA = "0x18A681C", Offset = "0x18A681C", VA = "0x18A681C")]
	public static Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		return default;
	}

	[Token(Token = "0x60020B6")]
	[Address(RVA = "0x18A6B78", Offset = "0x18A6B78", VA = "0x18A6B78")]
	public ClusterPuttShooter()
	{
	}

	[Token(Token = "0x60020B7")]
	[Address(RVA = "0x18A6BF8", Offset = "0x18A6BF8", VA = "0x18A6BF8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A20", Offset = "0x65A20")]
	private bool _003COnAimUpdate_003Eb__17_0(RaycastHit h)
	{
		return default;
	}

	[Token(Token = "0x60020B8")]
	[Address(RVA = "0x18A6C88", Offset = "0x18A6C88", VA = "0x18A6C88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A30", Offset = "0x65A30")]
	private float _003COnAimUpdate_003Eb__17_1(RaycastHit c)
	{
		return default;
	}

	[Token(Token = "0x60020B9")]
	[Address(RVA = "0x18A6D0C", Offset = "0x18A6D0C", VA = "0x18A6D0C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A40", Offset = "0x65A40")]
	private bool _003COnShoot_003Eb__19_0(RaycastHit h)
	{
		return default;
	}

	[Token(Token = "0x60020BA")]
	[Address(RVA = "0x18A6D9C", Offset = "0x18A6D9C", VA = "0x18A6D9C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A50", Offset = "0x65A50")]
	private float _003COnShoot_003Eb__19_1(RaycastHit c)
	{
		return default;
	}
}
