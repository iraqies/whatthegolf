using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AE4")]
public class MoveObjectAlongPoints : MonoBehaviour
{
	[Token(Token = "0x2000AE5")]
	public enum MovementTypeEnum
	{
		[Token(Token = "0x4003CC8")]
		PingPong = 0,
		[Token(Token = "0x4003CC9")]
		Loop = 1
	}

	[Token(Token = "0x4003CB7")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve MovementCurve;

	[Token(Token = "0x4003CB8")]
	[FieldOffset(Offset = "0x20")]
	public Transform WaypointContainer;

	[Token(Token = "0x4003CB9")]
	[FieldOffset(Offset = "0x28")]
	public float TimePerRound;

	[Token(Token = "0x4003CBA")]
	[FieldOffset(Offset = "0x2C")]
	public bool MoveWithBezier;

	[Token(Token = "0x4003CBB")]
	[FieldOffset(Offset = "0x2D")]
	public bool FollowWaypointRotations;

	[Token(Token = "0x4003CBC")]
	[FieldOffset(Offset = "0x30")]
	public MovementTypeEnum MovementType;

	[Token(Token = "0x4003CBD")]
	[FieldOffset(Offset = "0x34")]
	public float SpeedMod;

	[Token(Token = "0x4003CBE")]
	[FieldOffset(Offset = "0x38")]
	private float movementTimer;

	[Token(Token = "0x4003CBF")]
	[FieldOffset(Offset = "0x3C")]
	private int currentDirection;

	[Token(Token = "0x4003CC0")]
	[FieldOffset(Offset = "0x40")]
	private int currentMovementTargetIndex;

	[Token(Token = "0x4003CC1")]
	[FieldOffset(Offset = "0x44")]
	private float movementDist;

	[Token(Token = "0x4003CC2")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody rigid;

	[Token(Token = "0x4003CC3")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody2D rigid2D;

	[Token(Token = "0x4003CC4")]
	[FieldOffset(Offset = "0x58")]
	private float movementTimerTarget;

	[Token(Token = "0x4003CC5")]
	[FieldOffset(Offset = "0x5C")]
	private float movedSoFar;

	[Token(Token = "0x4003CC6")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 lastPos;

	[Token(Token = "0x60033FD")]
	[Address(RVA = "0x1572038", Offset = "0x1572038", VA = "0x1572038")]
	private void Awake()
	{
	}

	[Token(Token = "0x60033FE")]
	[Address(RVA = "0x15720B8", Offset = "0x15720B8", VA = "0x15720B8")]
	private void Start()
	{
	}

	[Token(Token = "0x60033FF")]
	[Address(RVA = "0x1572410", Offset = "0x1572410", VA = "0x1572410")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003400")]
	[Address(RVA = "0x1572860", Offset = "0x1572860", VA = "0x1572860")]
	private void Update()
	{
	}

	[Token(Token = "0x6003401")]
	[Address(RVA = "0x1572A70", Offset = "0x1572A70", VA = "0x1572A70")]
	public void ChangeDirection()
	{
	}

	[Token(Token = "0x6003402")]
	[Address(RVA = "0x15725B0", Offset = "0x15725B0", VA = "0x15725B0")]
	private Vector3 GetTargetPosition()
	{
		return default;
	}

	[Token(Token = "0x6003403")]
	[Address(RVA = "0x1572A98", Offset = "0x1572A98", VA = "0x1572A98")]
	public int GetDirection()
	{
		return default;
	}

	[Token(Token = "0x6003404")]
	[Address(RVA = "0x1572AA0", Offset = "0x1572AA0", VA = "0x1572AA0")]
	public void SetDirection(float direction)
	{
	}

	[Token(Token = "0x6003405")]
	[Address(RVA = "0x1572748", Offset = "0x1572748", VA = "0x1572748")]
	private Quaternion GetTargetRotation()
	{
		return default;
	}

	[Token(Token = "0x6003406")]
	[Address(RVA = "0x15723B4", Offset = "0x15723B4", VA = "0x15723B4")]
	private void SetMovementTarget()
	{
	}

	[Token(Token = "0x6003407")]
	[Address(RVA = "0x1572198", Offset = "0x1572198", VA = "0x1572198")]
	private float GetDistance(int index)
	{
		return default;
	}

	[Token(Token = "0x6003408")]
	[Address(RVA = "0x1572ADC", Offset = "0x1572ADC", VA = "0x1572ADC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003409")]
	[Address(RVA = "0x1572D1C", Offset = "0x1572D1C", VA = "0x1572D1C")]
	public MoveObjectAlongPoints()
	{
	}
}
