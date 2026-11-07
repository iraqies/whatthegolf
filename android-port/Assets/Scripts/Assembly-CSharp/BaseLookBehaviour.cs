using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D60")]
public class BaseLookBehaviour : MonoBehaviour
{
	[Token(Token = "0x40048B5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Transform[] transformsLookingAt;

	[Token(Token = "0x40048B6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Transform lookAtTargetBehind;

	[Token(Token = "0x40048B7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected Transform FOVtransform;

	[Token(Token = "0x40048B8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected float lookAtSpeed;

	[Token(Token = "0x40048B9")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	protected float lookAwaySpeed;

	[Token(Token = "0x40048BA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected bool resetBackToDefault;

	[Token(Token = "0x40048BB")]
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	protected bool detectCollisionOnlyInsideTrigger;

	[Token(Token = "0x40048BC")]
	[FieldOffset(Offset = "0x3A")]
	[SerializeField]
	protected bool ignoreY;

	[Token(Token = "0x40048BD")]
	[FieldOffset(Offset = "0x3B")]
	[SerializeField]
	protected bool needLineOfSightToDetect;

	[Token(Token = "0x40048BE")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent<Transform> OnDetection;

	[Token(Token = "0x40048BF")]
	[FieldOffset(Offset = "0x48")]
	public UnityEvent<Transform> OnCollision;

	[Token(Token = "0x40048C0")]
	[FieldOffset(Offset = "0x50")]
	public UnityEvent<Transform> OnFollowPlayer;

	[Token(Token = "0x40048C1")]
	[FieldOffset(Offset = "0x58")]
	public UnityEvent<Vector3> OnLostLineOfSight;

	[Token(Token = "0x40048C2")]
	[FieldOffset(Offset = "0x60")]
	public UnityEvent<Transform> OnRestoredLineOfSight;

	[Token(Token = "0x40048C3")]
	[FieldOffset(Offset = "0x68")]
	private Transform player;

	[Token(Token = "0x40048C4")]
	[FieldOffset(Offset = "0x70")]
	private Quaternion[] defaultRotations;

	[Token(Token = "0x40048C5")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 lastKnownPlayerPos;

	[Token(Token = "0x40048C6")]
	[FieldOffset(Offset = "0x84")]
	private bool hadLostLineOfSight;

	[Token(Token = "0x6003EE4")]
	[Address(RVA = "0x1607214", Offset = "0x1607214", VA = "0x1607214", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6003EE5")]
	[Address(RVA = "0x1607314", Offset = "0x1607314", VA = "0x1607314", Slot = "5")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6003EE6")]
	[Address(RVA = "0x1607434", Offset = "0x1607434", VA = "0x1607434", Slot = "6")]
	protected virtual void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003EE7")]
	[Address(RVA = "0x1607590", Offset = "0x1607590", VA = "0x1607590", Slot = "7")]
	protected virtual void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6003EE8")]
	[Address(RVA = "0x1607600", Offset = "0x1607600", VA = "0x1607600", Slot = "8")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6003EE9")]
	[Address(RVA = "0x16076A8", Offset = "0x16076A8", VA = "0x16076A8", Slot = "9")]
	protected virtual void TryLookingAtPlayer()
	{
	}

	[Token(Token = "0x6003EEA")]
	[Address(RVA = "0x1607C3C", Offset = "0x1607C3C", VA = "0x1607C3C", Slot = "10")]
	protected virtual void LookAround()
	{
	}

	[Token(Token = "0x6003EEB")]
	[Address(RVA = "0x160796C", Offset = "0x160796C", VA = "0x160796C")]
	private void MoveFovAround(bool reset = false)
	{
	}

	[Token(Token = "0x6003EEC")]
	[Address(RVA = "0x1607F34", Offset = "0x1607F34", VA = "0x1607F34", Slot = "11")]
	protected virtual void LookAtPlayer()
	{
	}

	[Token(Token = "0x6003EED")]
	[Address(RVA = "0x16081EC", Offset = "0x16081EC", VA = "0x16081EC")]
	public BaseLookBehaviour()
	{
	}
}
