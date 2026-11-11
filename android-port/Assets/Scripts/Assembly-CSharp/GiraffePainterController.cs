using System;
using System.Collections.Generic;
using System.Linq;
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

	public float ShootForce = 1f;

	public float MoveForce = 1f;

	public Vector2 CanvasBounds = new Vector2(4f, 4f);

	public Animator GiraffeAnimator;

	public Transform CanvasUp;

	public Transform BrushPointOnCanvas;

	public Transform Brush;

	public Transform BlueprintContainer;

	public Animator AutoPaintAnimator;

	public float DistanceThreshold = 1f;

	public Material PaintingMat;

	public PoseMachine PoseMachine;

	public Camera PoseCamera;

	public GolfCoursePinGoal PinGoal;

	public bool continiousMove;

	public float SizeMod = 1f;

	public bool HavePainterFollowPlayerTarget = true;

	public bool DoAutoPainting = true;

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

	public event Action OnClear;

	protected override void Awake()
	{
		base.Awake();
		if (BrushPointOnCanvas != null)
		{
			painter = BrushPointOnCanvas.GetComponent<MeshRenderer>();
			startScale = BrushPointOnCanvas.localScale;
		}
		if (BlueprintContainer != null)
		{
			bluePrints = BlueprintContainer.GetComponentsInChildren<PaintingBlueprint>(true);
		}
		if (bluePrints != null && currentBlueprint < bluePrints.Length && bluePrints[currentBlueprint] != null && PlayerTarget != null)
		{
			List<Transform> paintPoints = bluePrints[currentBlueprint].PaintPoints;
			if (paintPoints != null && currentBlueprint < paintPoints.Count && paintPoints[currentBlueprint] != null)
			{
				PlayerTarget.position = paintPoints[currentBlueprint].position;
			}
			currentTarget = PlayerTarget.position;
			if (GiraffeAnimator != null)
			{
				GiraffeAnimator.SetFloat("PosX", PlayerTarget.localPosition.x);
				GiraffeAnimator.SetFloat("PosY", PlayerTarget.localPosition.y);
				GiraffeAnimator.Update(0f);
			}
			if (BrushPointOnCanvas != null)
			{
				BrushPointOnCanvas.position = PlayerTarget.position;
			}
		}
		if (bluePrints != null)
		{
			for (int i = 0; i < bluePrints.Length; i++)
			{
				if (bluePrints[i] != null)
				{
					bluePrints[i].Deactivate();
					bluePrints[i].ToggleBlueprint(false);
				}
			}
		}
		ChangeState(PaintStateEnum.NewPoseRoutine);
		if (controller != null)
		{
			controller.enabled = false;
		}
		if (bluePrints != null && bluePrints.Length > 0 && bluePrints[0] != null)
		{
			bluePrints[0].Activate();
			bluePrints[0].ToggleBlueprint(true);
		}
		if (PoseMachine != null)
		{
			PoseMachine.NextPose(delegate
			{
				ChangeState(PaintStateEnum.PlayerControlled);
				OnNewPose?.Invoke();
			});
		}
		else
		{
			ChangeState(PaintStateEnum.PlayerControlled);
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (PlayerTarget != null)
		{
			currentTarget = PlayerTarget.position + boost * ShootForce;
		}
		if (painter != null)
		{
			painter.enabled = true;
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (!onlyAimArrow && PaintState == PaintStateEnum.PlayerControlled && continiousMove)
		{
			if (painter != null)
			{
				painter.enabled = true;
			}
			if (PlayerTarget != null)
			{
				currentTarget = PlayerTarget.position + boost * MoveForce;
			}
		}
	}

	private void ChangeState(PaintStateEnum newState)
	{
		OnChangeState?.Invoke(newState);
		PaintState = newState;
	}

	private void Update()
	{
		if (PaintState == PaintStateEnum.PlayerControlled)
		{
			if (controller != null)
			{
				controller.enabled = true;
			}
			if (PlayerTarget != null)
			{
				PlayerTarget.position = Vector3.SmoothDamp(PlayerTarget.position, currentTarget, ref curVel, 0.3f, float.PositiveInfinity, Time.smoothDeltaTime);
				if (Mathf.Abs(PlayerTarget.localPosition.x) > CanvasBounds.x)
				{
					PlayerTarget.localPosition = new Vector3(CanvasBounds.x * Mathf.Sign(PlayerTarget.localPosition.x), PlayerTarget.localPosition.y, 0f);
				}
				if (Mathf.Abs(PlayerTarget.localPosition.y) > CanvasBounds.y)
				{
					PlayerTarget.localPosition = new Vector3(PlayerTarget.localPosition.x, CanvasBounds.y * Mathf.Sign(PlayerTarget.localPosition.y), 0f);
				}
			}
			if (bluePrints != null && currentBlueprint < bluePrints.Length && bluePrints[currentBlueprint] != null)
			{
				List<Transform> paintPoints = bluePrints[currentBlueprint].PaintPoints;
				if (paintPoints != null && PlayerTarget != null)
				{
					foreach (Transform item in paintPoints)
					{
						if (item != null && Vector3.Distance(item.position, PlayerTarget.position) >= DistanceThreshold)
						{
							break;
						}
					}
					Transform transform = paintPoints.Last();
					if (transform != null && Vector3.Distance(transform.position, PlayerTarget.position) < DistanceThreshold)
					{
						OnAnyComplete?.Invoke();
						if (DoAutoPainting)
						{
							ChangeState(PaintStateEnum.AutoPainting);
							if (AutoPaintAnimator != null)
							{
								AutoPaintAnimator.SetBool("AutoPaint", true);
							}
						}
						else
						{
							int num = currentBlueprint;
							currentBlueprint = num + 1;
							if (currentBlueprint < bluePrints.Length)
							{
								bluePrints[num].ToggleBlueprint(false);
								this.OnClear?.Invoke();
								NextPose();
							}
							else
							{
								if (AddressableSingleton<LevelManager>.Instance != null && AddressableSingleton<LevelManager>.Instance.IsInLevel() && PinGoal != null)
								{
									PinGoal.CheckObject(base.transform, false);
								}
								base.enabled = false;
							}
						}
					}
				}
			}
			if (BrushPointOnCanvas != null)
			{
				float t = Mathf.Clamp01(curVel.magnitude / 18f);
				BrushPointOnCanvas.localScale = Vector3.Lerp(startScale * 0.5f, startScale * SizeMod, t);
			}
			if (Brush != null && PlayerTarget != null)
			{
				Brush.up = (PlayerTarget.position - Brush.position).normalized;
			}
		}
		else if (PaintState == PaintStateEnum.AutoPainting)
		{
			if (controller != null)
			{
				controller.StopAiming();
				controller.enabled = false;
			}
			if (PaintingMat != null)
			{
				PaintingMat.SetFloat("_ImageLerp", Mathf.Clamp01(autoPaintTimer * 2f));
			}
			autoPaintTimer += Time.deltaTime;
			if (BrushPointOnCanvas != null)
			{
				BrushPointOnCanvas.localScale = Vector3.Lerp(BrushPointOnCanvas.localScale, startScale * 3f, Mathf.Clamp01(Time.deltaTime * 10f));
			}
			if (GiraffeLeg != null && CanvasUp != null && PlayerTarget != null)
			{
				Ray ray = new Ray(GiraffeLeg.position, GiraffeLeg.up);
				Plane plane = new Plane(CanvasUp.up, PlayerTarget.position);
				float enter;
				if (plane.Raycast(ray, out enter))
				{
					PlayerTarget.position = ray.GetPoint(enter);
				}
			}
			if (autoPaintTimer > 1.5f)
			{
				currentBlueprint++;
				if (bluePrints != null && currentBlueprint < bluePrints.Length)
				{
					NextPose();
				}
				else
				{
					if (AddressableSingleton<LevelManager>.Instance != null && AddressableSingleton<LevelManager>.Instance.IsInLevel() && PinGoal != null)
					{
						PinGoal.CheckObject(base.transform, false);
					}
					base.enabled = false;
				}
			}
		}
		if (PlayerTarget != null && GiraffeAnimator != null)
		{
			GiraffeAnimator.SetFloat("PosX", PlayerTarget.localPosition.x);
			GiraffeAnimator.SetFloat("PosY", PlayerTarget.localPosition.y);
		}
		if (HavePainterFollowPlayerTarget && GiraffeLeg != null && CanvasUp != null && PlayerTarget != null && BrushPointOnCanvas != null)
		{
			Ray ray2 = new Ray(GiraffeLeg.position, GiraffeLeg.up);
			Plane plane2 = new Plane(CanvasUp.up, PlayerTarget.position);
			float enter2;
			if (plane2.Raycast(ray2, out enter2))
			{
				BrushPointOnCanvas.position = ray2.GetPoint(enter2);
			}
		}
	}

	public void RedoPose()
	{
		OnRedoPose?.Invoke();
		if (controller != null)
		{
			controller.StopAiming();
			controller.enabled = false;
		}
		ChangeState(PaintStateEnum.NewPoseRoutine);
		if (painter != null)
		{
			painter.enabled = false;
		}
		if (PoseMachine != null)
		{
			PoseMachine.RedoPose(delegate
			{
				if (PoseCamera != null)
				{
					PoseCamera.enabled = true;
				}
				if (PaintingMat != null)
				{
					PaintingMat.SetFloat("_ImageLerp", 0f);
				}
				if (AutoPaintAnimator != null)
				{
					AutoPaintAnimator.SetBool("AutoPaint", false);
				}
				ChangeState(PaintStateEnum.PlayerControlled);
				if (controller != null)
				{
					controller.enabled = true;
				}
				this.OnClear?.Invoke();
				if (bluePrints != null && currentBlueprint < bluePrints.Length && bluePrints[currentBlueprint] != null && PlayerTarget != null)
				{
					List<Transform> paintPoints = bluePrints[currentBlueprint].PaintPoints;
					if (paintPoints != null && paintPoints.Count > 0 && paintPoints[0] != null)
					{
						PlayerTarget.localPosition = paintPoints[0].localPosition;
						currentTarget = PlayerTarget.position;
					}
				}
			});
		}
	}

	private void NextPose()
	{
		if (bluePrints != null && currentBlueprint < bluePrints.Length && bluePrints[currentBlueprint] != null)
		{
			bluePrints[currentBlueprint].Activate();
		}
		autoPaintTimer = 0f;
		ChangeState(PaintStateEnum.NewPoseRoutine);
		if (PoseCamera != null)
		{
			PoseCamera.enabled = false;
		}
		if (bluePrints != null && currentBlueprint < bluePrints.Length && bluePrints[currentBlueprint] != null && PlayerTarget != null)
		{
			List<Transform> paintPoints = bluePrints[currentBlueprint].PaintPoints;
			if (paintPoints != null && paintPoints.Count > 0 && paintPoints[0] != null)
			{
				PlayerTarget.localPosition = paintPoints[0].localPosition;
				currentTarget = PlayerTarget.position;
			}
		}
		if (painter != null)
		{
			painter.enabled = false;
		}
		if (PoseMachine != null)
		{
			PoseMachine.NextPose(delegate
			{
				OnNewPose?.Invoke();
				if (PoseCamera != null)
				{
					PoseCamera.enabled = true;
				}
				if (currentBlueprint - 1 >= 0 && bluePrints != null && currentBlueprint - 1 < bluePrints.Length && bluePrints[currentBlueprint - 1] != null)
				{
					bluePrints[currentBlueprint - 1].Deactivate();
					bluePrints[currentBlueprint - 1].ToggleBlueprint(false);
				}
				if (bluePrints != null && currentBlueprint < bluePrints.Length && bluePrints[currentBlueprint] != null)
				{
					bluePrints[currentBlueprint].ToggleBlueprint(true);
				}
				if (PaintingMat != null)
				{
					PaintingMat.SetFloat("_ImageLerp", 0f);
				}
				if (AutoPaintAnimator != null)
				{
					AutoPaintAnimator.SetBool("AutoPaint", false);
				}
				ChangeState(PaintStateEnum.PlayerControlled);
				this.OnClear?.Invoke();
			});
		}
	}
}
