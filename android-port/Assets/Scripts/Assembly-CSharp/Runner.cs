using System;
using System.Collections.Generic;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002A2")]
public class Runner : MonoBehaviour, IMovingKinematicTarget
{
	[Token(Token = "0x20002A3")]
	public enum RunDirection
	{
		[Token(Token = "0x4000E1F")]
		Forward = 1,
		[Token(Token = "0x4000E20")]
		Backward = -1
	}

	[Token(Token = "0x20002A4")]
	public enum TrackLoopType
	{
		[Token(Token = "0x4000E22")]
		Loop = 0,
		[Token(Token = "0x4000E23")]
		PingPong = 1,
		[Token(Token = "0x4000E24")]
		Stop = 2
	}

	[Token(Token = "0x20002A5")]
	public enum RunnerState
	{
		[Token(Token = "0x4000E26")]
		Idle = 0,
		[Token(Token = "0x4000E27")]
		Running = 1,
		[Token(Token = "0x4000E28")]
		Turning = 2,
		[Token(Token = "0x4000E29")]
		Ragdoll = 3
	}

	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool addRunVelocityOnCollapse;

	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private LayerMask unbalanceCollisionLayerMask;

	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float unbalanceVelocitySqrMag;

	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float incomingForceMultiplier;

	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool teleportToOppositeOnLoop;

	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private TrackLoopType trackLoopType;

	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RunnerState state;

	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private RunDirection runDirection;

	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float turnDegreesPerSecond;

	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4B374", Offset = "0x4B374")]
	[SerializeField]
	private float startOffset;

	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private Vector3 laneOffset;

	[Token(Token = "0x4000E07")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Rigidbody root;

	[Token(Token = "0x4000E08")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Rigidbody collisionDetection;

	[Token(Token = "0x4000E09")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<Rigidbody> blackListRigidbodies;

	[Token(Token = "0x4000E0A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4000E0B")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private CinemachineSmoothPath path;

	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private bool placeAtOffset;

	[Token(Token = "0x4000E0D")]
	[FieldOffset(Offset = "0x79")]
	[SerializeField]
	private bool drawTangent;

	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x7C")]
	private float rawDistance;

	[Token(Token = "0x4000E0F")]
	[FieldOffset(Offset = "0x80")]
	private float standardDistance;

	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0x84")]
	private bool didTeleport;

	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0x88")]
	private Rigidbody runnerRigidbody;

	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0x90")]
	private List<Rigidbody> limbs;

	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x98")]
	private Collider mainCollider;

	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0xA0")]
	private RunDirection lastRunDirection;

	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0xA4")]
	private RunnerState prevState;

	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B434", Offset = "0x4B434")]
	private Vector3 Velocity__BackingField;

	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0xB8")]
	public Action<RunnerState> OnChangeState;

	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 forward;

	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0xCC")]
	private Vector3 right;

	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0xD8")]
	private Vector3 up;

	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0xE4")]
	private Vector3 splinePosition;

	[Token(Token = "0x4000E1C")]
	[FieldOffset(Offset = "0xF0")]
	private Vector3 splineTangent;

	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0xFC")]
	private Quaternion splineOrientation;

	[Token(Token = "0x17000177")]
	public Rigidbody Root
	{
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x1662724", Offset = "0x1662724", VA = "0x1662724")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000178")]
	public List<Rigidbody> Limbs
	{
		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x166272C", Offset = "0x166272C", VA = "0x166272C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000179")]
	public Vector3 Position
	{
		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x1662734", Offset = "0x1662734", VA = "0x1662734", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700017A")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x1662750", Offset = "0x1662750", VA = "0x1662750", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6046C", Offset = "0x6046C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x166275C", Offset = "0x166275C", VA = "0x166275C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6047C", Offset = "0x6047C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x1662768", Offset = "0x1662768", VA = "0x1662768")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x1662BA8", Offset = "0x1662BA8", VA = "0x1662BA8")]
	private float NormalizedToTrack(float t)
	{
		return default;
	}

	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x1662ECC", Offset = "0x1662ECC", VA = "0x1662ECC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x16630B8", Offset = "0x16630B8", VA = "0x16630B8")]
	public void SetRunState(RunnerState newState)
	{
	}

	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x1662C74", Offset = "0x1662C74", VA = "0x1662C74")]
	private void SetPositions(float distance)
	{
	}

	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x1662DBC", Offset = "0x1662DBC", VA = "0x1662DBC")]
	private Vector3 GetRunnerPosition()
	{
		return default;
	}

	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0x1662E28", Offset = "0x1662E28", VA = "0x1662E28")]
	private Quaternion GetRunnerRotation()
	{
		return default;
	}

	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x1663120", Offset = "0x1663120", VA = "0x1663120")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x1663720", Offset = "0x1663720", VA = "0x1663720")]
	private bool HandleLooping()
	{
		return default;
	}

	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x1663A74", Offset = "0x1663A74", VA = "0x1663A74")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x16629FC", Offset = "0x16629FC", VA = "0x16629FC")]
	public void RagdollSetActiveStatus(bool status)
	{
	}

	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x1663BC4", Offset = "0x1663BC4", VA = "0x1663BC4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x1663D40", Offset = "0x1663D40", VA = "0x1663D40")]
	public Runner()
	{
	}

	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x1663D64", Offset = "0x1663D64", VA = "0x1663D64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6048C", Offset = "0x6048C")]
	private bool _003CAwake_003Eb__41_0(Rigidbody item)
	{
		return default;
	}
}
