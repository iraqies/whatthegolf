using System;
using System.Runtime.CompilerServices;
using Core;
using GolfCourse;
using UnityEngine;

public class GiraffePainterController : GolfBallShooterBase
{
	public enum PaintStateEnum
	{
		PlayerControlled = 0,
		AutoPainting = 1,
		NewPoseRoutine = 2
	}

	public Transform PlayerTarget;

	public Transform GiraffeLeg;

	public float ShootForce;

	public float MoveForce;

	public Vector2 CanvasBounds;

	public Animator GiraffeAnimator;

	public Transform CanvasUp;

	public Transform BrushPointOnCanvas;

	public Transform Brush;

	public Transform BlueprintContainer;

	public Animator AutoPaintAnimator;

	public float DistanceThreshold;

	public Material PaintingMat;

	public PoseMachine PoseMachine;

	public Camera PoseCamera;

	public GolfCoursePinGoal PinGoal;

	public bool continiousMove;

	public float SizeMod;

	public bool HavePainterFollowPlayerTarget;

	public bool DoAutoPainting;

	public Action<PaintStateEnum> OnChangeState;

	public Action OnNewPose;

	public Action OnRedoPose;

	public Action OnAnyComplete;

	private Vector3 currentTarget;

	private Vector3 curVel;

	private Vector3 startScale;

	private int currentBlueprint;

	private PaintingBlueprint[] bluePrints;

	private PaintStateEnum PaintState;

	private float autoPaintTimer;

	private MeshRenderer painter;

	[CompilerGenerated]
	private Action m_OnClear;

	public event Action OnClear
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void Awake()
	{
	base.Awake();
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, (ShootForce > 0f ? ShootForce : 22f), 5f);
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void ChangeState(PaintStateEnum newState)
	{
	}

	private void Update()
	{
	}

	public void RedoPose()
	{
	}

	private void NextPose()
	{
	}
}
