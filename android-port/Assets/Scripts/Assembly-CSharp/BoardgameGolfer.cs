using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000259")]
public class BoardgameGolfer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200025A")]
	public struct DiceSideToActionPair
	{
		[Token(Token = "0x4000C2A")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 axis;

		[Token(Token = "0x4000C2B")]
		[FieldOffset(Offset = "0xC")]
		public bool onlyIfShot;

		[Token(Token = "0x4000C2C")]
		[FieldOffset(Offset = "0x10")]
		public UnityEvent callback;
	}

	[Token(Token = "0x4000C01")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> targets;

	[Token(Token = "0x4000C02")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> targetTiles;

	[Token(Token = "0x4000C03")]
	[FieldOffset(Offset = "0x28")]
	public Transform endTarget;

	[Token(Token = "0x4000C04")]
	[FieldOffset(Offset = "0x30")]
	public Transform bounceTarget;

	[Token(Token = "0x4000C05")]
	[FieldOffset(Offset = "0x38")]
	public int endTargetIndex;

	[Token(Token = "0x4000C06")]
	[FieldOffset(Offset = "0x3C")]
	private int currentIndex;

	[Token(Token = "0x4000C07")]
	[FieldOffset(Offset = "0x40")]
	private int nextIndex;

	[Token(Token = "0x4000C08")]
	[FieldOffset(Offset = "0x44")]
	private int targetIndex;

	[Token(Token = "0x4000C09")]
	[FieldOffset(Offset = "0x48")]
	public GolfBallController dice;

	[Token(Token = "0x4000C0A")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody diceRigid;

	[Token(Token = "0x4000C0B")]
	[FieldOffset(Offset = "0x58")]
	private bool hasBeenShot;

	[Token(Token = "0x4000C0C")]
	[FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x4000C0D")]
	[FieldOffset(Offset = "0x60")]
	public float CheckTimer;

	[Token(Token = "0x4000C0E")]
	[FieldOffset(Offset = "0x64")]
	public float SleepThreshold;

	[Token(Token = "0x4000C0F")]
	[FieldOffset(Offset = "0x68")]
	public float DotThreshold;

	[Token(Token = "0x4000C10")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 startPosition;

	[Token(Token = "0x4000C11")]
	[FieldOffset(Offset = "0x78")]
	public List<DiceSideToActionPair> sideToActionMap;

	[Token(Token = "0x4000C12")]
	[FieldOffset(Offset = "0x80")]
	private Rigidbody rb;

	[Token(Token = "0x4000C13")]
	[FieldOffset(Offset = "0x88")]
	private Transform t;

	[Token(Token = "0x4000C14")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float moveSpeed;

	[Token(Token = "0x4000C15")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	private float moveHeight;

	[Token(Token = "0x4000C16")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private AnimationCurve moveHeightCurve;

	[Token(Token = "0x4000C17")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float rotationSpeed;

	[Token(Token = "0x4000C18")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float collisionExtraPush;

	[Token(Token = "0x4000C19")]
	[FieldOffset(Offset = "0xA8")]
	public LayerMask groundLayer;

	[Token(Token = "0x4000C1A")]
	[FieldOffset(Offset = "0xAC")]
	private Vector3 startPos;

	[Token(Token = "0x4000C1B")]
	[FieldOffset(Offset = "0xB8")]
	private Quaternion startRot;

	[Token(Token = "0x4000C1C")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private ParticleSystem particleSystem;

	[Token(Token = "0x4000C1D")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private PropRain hotdogRain;

	[Token(Token = "0x4000C1E")]
	[FieldOffset(Offset = "0xD8")]
	private bool disabledByCollision;

	[Token(Token = "0x4000C1F")]
	[FieldOffset(Offset = "0xDC")]
	private float startTime;

	[Token(Token = "0x4000C20")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private int particleCount;

	[Token(Token = "0x4000C21")]
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	private float maxHotdogDestroyAngle;

	[Token(Token = "0x4000C22")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private float maxCollisionDisableAngle;

	[Token(Token = "0x4000C23")]
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	private float rotationCheckerRadius;

	[Token(Token = "0x4000C24")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Transform rotationCheckerCenter;

	[Token(Token = "0x4000C25")]
	[FieldOffset(Offset = "0xF8")]
	private Collider[] rotationCheckResults;

	[Token(Token = "0x4000C26")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private float respawnYOffset;

	[Token(Token = "0x4000C27")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private BoardgameGolfer other;

	[Token(Token = "0x4000C28")]
	[FieldOffset(Offset = "0x110")]
	public List<Transform> alternativeTargets;

	[Token(Token = "0x4000C29")]
	[FieldOffset(Offset = "0x118")]
	private bool reachedNext;

	[Token(Token = "0x1700014A")]
	public int CurrentIndex
	{
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x1614EF0", Offset = "0x1614EF0", VA = "0x1614EF0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700014B")]
	public int NextIndex
	{
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x1614EF8", Offset = "0x1614EF8", VA = "0x1614EF8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700014C")]
	public int TargetIndex
	{
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x1614F00", Offset = "0x1614F00", VA = "0x1614F00")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700014D")]
	private bool isMoving
	{
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x1614F7C", Offset = "0x1614F7C", VA = "0x1614F7C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x1614FA4", Offset = "0x1614FA4", VA = "0x1614FA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x1615134", Offset = "0x1615134", VA = "0x1615134")]
	private void Dice_OnShoot(Vector3 dir)
	{
	}

	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0x1615140", Offset = "0x1615140", VA = "0x1615140")]
	private void Dice_OnReset()
	{
	}

	[Token(Token = "0x6000A90")]
	[Address(RVA = "0x1615148", Offset = "0x1615148", VA = "0x1615148")]
	public void MovePiece(int value)
	{
	}

	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x1615190", Offset = "0x1615190", VA = "0x1615190")]
	public void RainHotdogs(int index)
	{
	}

	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x16151B0", Offset = "0x16151B0", VA = "0x16151B0")]
	public void StopHotdogs()
	{
	}

	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x16151CC", Offset = "0x16151CC", VA = "0x16151CC")]
	private void CheckDiceState()
	{
	}

	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x1615378", Offset = "0x1615378", VA = "0x1615378")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x161585C", Offset = "0x161585C", VA = "0x161585C")]
	private Transform GetNextNode()
	{
		return null;
	}

	[Token(Token = "0x6000A96")]
	[Address(RVA = "0x1615AD0", Offset = "0x1615AD0", VA = "0x1615AD0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x1615B18", Offset = "0x1615B18", VA = "0x1615B18")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000A98")]
	[Address(RVA = "0x1616094", Offset = "0x1616094", VA = "0x1616094")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000A99")]
	[Address(RVA = "0x16161FC", Offset = "0x16161FC", VA = "0x16161FC")]
	public void ResetOnRespawn()
	{
	}

	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0x161611C", Offset = "0x161611C", VA = "0x161611C")]
	public void OutOfBounds()
	{
	}

	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x1616220", Offset = "0x1616220", VA = "0x1616220")]
	public BoardgameGolfer()
	{
	}
}
