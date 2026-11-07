using System;
using Core;
using GolfCourse;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F5")]
public class GiraffePainterController : GolfBallShooterBase
{
	[Token(Token = "0x20001F6")]
	public enum PaintStateEnum
	{
		[Token(Token = "0x4000993")]
		PlayerControlled = 0,
		[Token(Token = "0x4000994")]
		AutoPainting = 1,
		[Token(Token = "0x4000995")]
		NewPoseRoutine = 2
	}

	[Token(Token = "0x4000971")]
	[FieldOffset(Offset = "0x60")]
	public Transform PlayerTarget;

	[Token(Token = "0x4000972")]
	[FieldOffset(Offset = "0x68")]
	public Transform GiraffeLeg;

	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x70")]
	public float ShootForce;

	[Token(Token = "0x4000974")]
	[FieldOffset(Offset = "0x74")]
	public float MoveForce;

	[Token(Token = "0x4000975")]
	[FieldOffset(Offset = "0x78")]
	public Vector2 CanvasBounds;

	[Token(Token = "0x4000976")]
	[FieldOffset(Offset = "0x80")]
	public Animator GiraffeAnimator;

	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x88")]
	public Transform CanvasUp;

	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x90")]
	public Transform BrushPointOnCanvas;

	[Token(Token = "0x4000979")]
	[FieldOffset(Offset = "0x98")]
	public Transform Brush;

	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0xA0")]
	public Transform BlueprintContainer;

	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0xA8")]
	public Animator AutoPaintAnimator;

	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0xB0")]
	public float DistanceThreshold;

	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0xB8")]
	public Material PaintingMat;

	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0xC0")]
	public PoseMachine PoseMachine;

	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0xC8")]
	public Camera PoseCamera;

	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0xD0")]
	public GolfCoursePinGoal PinGoal;

	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0xD8")]
	public bool continiousMove;

	[Token(Token = "0x4000982")]
	[FieldOffset(Offset = "0xDC")]
	public float SizeMod;

	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0xE0")]
	public bool HavePainterFollowPlayerTarget;

	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0xE1")]
	public bool DoAutoPainting;

	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0xE8")]
	public Action<PaintStateEnum> OnChangeState;

	[Token(Token = "0x4000986")]
	[FieldOffset(Offset = "0xF0")]
	public Action OnNewPose;

	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0xF8")]
	public Action OnRedoPose;

	[Token(Token = "0x4000988")]
	[FieldOffset(Offset = "0x100")]
	public Action OnAnyComplete;

	[Token(Token = "0x4000989")]
	[FieldOffset(Offset = "0x108")]
	private Vector3 currentTarget;

	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0x114")]
	private Vector3 curVel;

	[Token(Token = "0x400098B")]
	[FieldOffset(Offset = "0x120")]
	private Vector3 startScale;

	[Token(Token = "0x400098C")]
	[FieldOffset(Offset = "0x12C")]
	private int currentBlueprint;

	[Token(Token = "0x400098D")]
	[FieldOffset(Offset = "0x130")]
	private PaintingBlueprint[] bluePrints;

	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x138")]
	private PaintStateEnum PaintState;

	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x13C")]
	private float autoPaintTimer;

	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0x140")]
	private MeshRenderer painter;

	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x148")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A534", Offset = "0x4A534")]
	private Action m_OnClear;

	[Token(Token = "0x14000004")]
	public event Action OnClear
	{
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x148AC90", Offset = "0x148AC90", VA = "0x148AC90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F5EC", Offset = "0x5F5EC")]
		add
		{
		}
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x148AD34", Offset = "0x148AD34", VA = "0x148AD34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F5FC", Offset = "0x5F5FC")]
		remove
		{
		}
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x148ADD8", Offset = "0x148ADD8", VA = "0x148ADD8", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x148B56C", Offset = "0x148B56C", VA = "0x148B56C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x148B5F0", Offset = "0x148B5F0", VA = "0x148B5F0", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x148B504", Offset = "0x148B504", VA = "0x148B504")]
	private void ChangeState(PaintStateEnum newState)
	{
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x148B690", Offset = "0x148B690", VA = "0x148B690")]
	private void Update()
	{
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x148C3C8", Offset = "0x148C3C8", VA = "0x148C3C8")]
	public void RedoPose()
	{
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x148C13C", Offset = "0x148C13C", VA = "0x148C13C")]
	private void NextPose()
	{
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x148C4E4", Offset = "0x148C4E4", VA = "0x148C4E4")]
	public GiraffePainterController()
	{
	}

	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x148C534", Offset = "0x148C534", VA = "0x148C534")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F60C", Offset = "0x5F60C")]
	private void _003CAwake_003Eb__36_0()
	{
	}

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x148C5A8", Offset = "0x148C5A8", VA = "0x148C5A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F61C", Offset = "0x5F61C")]
	private void _003CRedoPose_003Eb__41_0()
	{
	}

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x148C758", Offset = "0x148C758", VA = "0x148C758")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F62C", Offset = "0x5F62C")]
	private void _003CNextPose_003Eb__42_0()
	{
	}
}
