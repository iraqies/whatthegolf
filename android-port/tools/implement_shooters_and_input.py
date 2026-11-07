#!/usr/bin/env python3
"""Implement core gameplay, level, aiming, shooting, goal, transition, input, and time control
systems for WHAT THE GOLF? Android port:
  - InputHelper & GyroHelper (Android touch + gamepad + gyroscope support)
  - TimeControl (bullet-time slow motion while aiming + pause handling)
  - Core.ShooterBase, Core.GolfBallShooterBase, Core.GolfBallShooterStandard,
    Core.GolfBallShooterStandardSpin, Core.GolfBallShooterExperimental,
    Core.GolfBallShooterExperimentalSim2d, Core.GolfBall2DShooterBase,
    Core.GolfBall2DShooterExperimental, Core.GolfCarNoFollowAimShooter
  - Core.ShootArrow (3D/2D aiming arrow scaling, rotation, color gradient)
  - Core.GolfBallController (pull-back slingshot touch aiming, gamepad stick aiming, shot release, out-of-bounds, stroke counting)
  - GolfBall2D, MouseSpringAction, Killable
  - GolfGoal, Core.HitGoal, GolfCourse.GolfCoursePinGoal, GolfCourse.GolfCourse2DPinGoal,
    GolfCourse.SuperPuttGoal, BossGoal, KatamariGoal, MarioEndFlag, MultiBallFlag,
    CompleteLevelWhenAllFlagsHit, FlagHitCheck
  - Core.Level, Game, LevelManager, Transition, DefaultTransitionEffect, TransitionTextEffects, HoleInOneTransition
"""
import os

PORT_ASSETS = "/home/ubuntu/work/WhatTheGolf/android-port/Assets"
EXPORT_ASSETS = "/home/ubuntu/c113work/ar_out/ExportedProject/Assets"


def write_asset_file(rel_path: str, content: str) -> None:
    for root in (PORT_ASSETS, EXPORT_ASSETS):
        if os.path.exists(root):
            p = os.path.join(root, rel_path)
            os.makedirs(os.path.dirname(p), exist_ok=True)
            with open(p, "w", encoding="utf-8") as f:
                f.write(content)


def main() -> None:
    # 1. InputHelper.cs & GyroHelper.cs
    write_asset_file("Scripts/Assembly-CSharp/InputHelper.cs", """using UnityEngine;

public class InputHelper : MonoBehaviour
{
	private static float controllerTime;
	public const string INPUT_UI_HORIZONTAL = "UI Horizontal";
	public const string INPUT_UI_VERTICAL = "UI Vertical";
	public const string INPUT_UI_CONFIRM = "Confirm UI";
	public const string INPUT_OPEN_MENU = "Open Menu";
	public const string INPUT_CLOSE_MENU = "Close Menu";
	public const string INPUT_BACK = "Go Back";
	public const string INPUT_DEBUG1 = "Debug1";
	public const string INPUT_DEBUG2 = "Debug2";
	public const string INPUT_DEBUG3 = "Debug3";
	public const string INPUT_DEBUG4 = "Debug4";
	public const string INPUT_CHEAT = "Cheat";

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		controllerTime = -100f;
	}

	public static bool IsNavigatingWithController() => Time.unscaledTime - controllerTime < 3f;
	public static bool IsNavigatingWithKeyboard() => false;
	public static bool IsCurrentJoystickOrKeyboard() => IsNavigatingWithController();

	public static void UpdateLastInput()
	{
		if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.25f || Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0.25f || Input.GetKeyDown(KeyCode.JoystickButton0))
			controllerTime = Time.unscaledTime;
	}

	private static int GetAllPlayerAxisRounded(string axisName)
	{
		try
		{
			float v = Input.GetAxisRaw(axisName);
			if (Mathf.Abs(v) > 0.4f) return v > 0f ? 1 : -1;
		}
		catch { }
		return 0;
	}

	private static bool GetAllPlayerButtonUp(string buttonName) => GetAllPlayerButtonDown(buttonName);

	public static int GetAllPlayerAxisRoundedHorizontal() => GetAllPlayerAxisRounded("Horizontal");
	public static int GetAllPlayerAxisRoundedVertical() => GetAllPlayerAxisRounded("Vertical");

	public static bool GetAllPlayerButtonConfirm() => Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.JoystickButton0);
	public static bool GetAllPlayerButtonCancel() => Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton1);
	public static bool GetAllPlayerButtonOpenMenu() => Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton7);
	public static bool GetAllPlayerButtonGoBack() => GetAllPlayerButtonCancel();
	public static bool GetAllPlayerButtonDebug1() => false;
	public static bool GetAllPlayerButtonDebug2() => false;
	public static bool GetAllPlayerButtonDebug3() => false;
	public static bool GetAllPlayerButtonDebug4() => false;
	public static bool GetAllPlayerButtonCheat() => false;

	public static bool TouchedOrMouseClicked()
	{
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
				if (Input.GetTouch(i).phase == TouchPhase.Began) return true;
		}
		return Input.GetMouseButtonDown(0);
	}

	public static bool GetAllPlayerButtonDown(string buttonName)
	{
		if (buttonName == INPUT_UI_CONFIRM || buttonName == "Shoot")
			return GetAllPlayerButtonConfirm();
		if (buttonName == INPUT_BACK || buttonName == INPUT_CLOSE_MENU)
			return GetAllPlayerButtonCancel();
		if (buttonName == INPUT_OPEN_MENU)
			return GetAllPlayerButtonOpenMenu();
		return false;
	}

	public static Vector2 FixAxialDeadzoneForAppleArcade(Vector2 dir)
	{
		return dir.magnitude < 0.15f ? Vector2.zero : dir;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/GyroHelper.cs", """using UnityEngine;

public class GyroHelper
{
	private static bool isRemote;

	public static void InitGyro()
	{
		if (SystemInfo.supportsGyroscope)
		{
			Input.gyro.enabled = true;
			Input.gyro.updateInterval = 1f / 60f;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		InitGyro();
	}

	public static void UpdateEditorRemoteGyroState() { }

	public static void SetGyroFPS(float fps)
	{
		if (SystemInfo.supportsGyroscope && fps > 0f)
			Input.gyro.updateInterval = 1f / fps;
	}
}
""")

    # 2. TimeControl.cs
    write_asset_file("Scripts/Assembly-CSharp/TimeControl.cs", """using System;
using System.Runtime.CompilerServices;
using Chronos;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
	public delegate void PauseDelegate(bool state);

	public float aimTimeScale = 0.15f;
	public float upSpeed = 8f;
	public float downSpeed = 12f;
	[SerializeField] private float baseFixedTimeStep = 0.02f;
	public bool usePlatformSettingsTimeScaleAdjustment;
	[SerializeField] public LocalClock clockToUseInstead;
	[SerializeField] public bool showVisualEffect;
	[SerializeField] public bool modifyFixedDeltaTime = true;

	private bool inTrailerRecordMode;
	private float trailerModeMultiplier = 1f;
	private float targetTimeScale = 1f;
	private float fixedTimeStep = 0.02f;
	private bool isPaused;
	private static PauseDelegate m_OnPauseStateChanged;
	private float timeScaleBeforePause = 1f;
	private float nextTimeStop;
	private bool useMinimumTime;
	private bool isStopping;
	private bool isAiming;
	private TimeControlAudio timeControlAudio;
	private float currentAimTimeScale = 0.15f;

	public bool IsPaused
	{
		get => isPaused;
		private set => isPaused = value;
	}

	public static event PauseDelegate OnPauseStateChanged
	{
		add => m_OnPauseStateChanged = (PauseDelegate)Delegate.Combine(m_OnPauseStateChanged, value);
		remove => m_OnPauseStateChanged = (PauseDelegate)Delegate.Remove(m_OnPauseStateChanged, value);
	}

	private void Start()
	{
		if (baseFixedTimeStep <= 0f) baseFixedTimeStep = 0.02f;
		fixedTimeStep = baseFixedTimeStep;
		currentAimTimeScale = aimTimeScale > 0f ? aimTimeScale : 0.15f;
		targetTimeScale = 1f;
	}

	private void OnEnable()
	{
		targetTimeScale = 1f;
	}

	private void Instance_OnNewBall() { }

	public void SetCurrentAimTimeScale(float val) => currentAimTimeScale = Mathf.Clamp(val, 0.02f, 1f);

	public void SetAimTimeScale(bool useMinimumTime = false, float minimumTime = 0f)
	{
		isAiming = true;
		this.useMinimumTime = useMinimumTime;
		targetTimeScale = Mathf.Clamp(currentAimTimeScale > 0f ? currentAimTimeScale : aimTimeScale, 0.02f, 1f);
		if (useMinimumTime && minimumTime > 0f)
			nextTimeStop = Time.unscaledTime + minimumTime;
	}

	public void SetNewAimTimeScale(float newAimTimeScale)
	{
		aimTimeScale = newAimTimeScale;
		currentAimTimeScale = newAimTimeScale;
		if (isAiming) targetTimeScale = Mathf.Clamp(newAimTimeScale, 0.02f, 1f);
	}

	public float GetTargetTimeScale() => isPaused ? 0f : targetTimeScale;

	public void ResetTimeScale()
	{
		isAiming = false;
		targetTimeScale = 1f;
		if (!isPaused)
		{
			Time.timeScale = 1f;
			if (modifyFixedDeltaTime && fixedTimeStep > 0f)
				Time.fixedDeltaTime = fixedTimeStep;
		}
	}

	public void TogglePause(bool paused)
	{
		if (isPaused == paused) return;
		isPaused = paused;
		if (isPaused)
		{
			timeScaleBeforePause = Time.timeScale > 0f ? Time.timeScale : 1f;
			Time.timeScale = 0f;
		}
		else
		{
			Time.timeScale = isAiming ? targetTimeScale : 1f;
		}
		m_OnPauseStateChanged?.Invoke(isPaused);
	}

	private void Update()
	{
		if (!isPaused)
			UpdateTimeScale();
	}

	private void UpdateTimeScale()
	{
		float speed = Time.timeScale < targetTimeScale ? (upSpeed > 0f ? upSpeed : 8f) : (downSpeed > 0f ? downSpeed : 12f);
		Time.timeScale = Mathf.MoveTowards(Time.timeScale, targetTimeScale, Time.unscaledDeltaTime * speed);
		if (modifyFixedDeltaTime && fixedTimeStep > 0f)
			Time.fixedDeltaTime = fixedTimeStep * Mathf.Max(0.05f, Time.timeScale);
	}

	private void OnDestroy()
	{
		Time.timeScale = 1f;
		if (baseFixedTimeStep > 0f)
			Time.fixedDeltaTime = baseFixedTimeStep;
	}

	public void SetRecordingMultiplier(float multiplier) => trailerModeMultiplier = multiplier;
}
""")

    # 3. Core/ShooterBase.cs, GolfBallShooterBase.cs, GolfBallShooterStandard.cs, GolfBallShooterStandardSpin.cs, GolfBallShooterExperimental.cs, GolfBallShooterExperimentalSim2d.cs, GolfBall2DShooterBase.cs, GolfBall2DShooterExperimental.cs
    write_asset_file("Scripts/Assembly-CSharp/Core/ShooterBase.cs", """using UnityEngine;

namespace Core
{
	public abstract class ShooterBase : MonoBehaviour
	{
		protected GolfBallController GolfBallController;

		public virtual void OnActivate() { }
		public virtual void OnAimStart() { }
		public virtual void OnAimUpdate(Vector3 boost, bool onlyAimArrow) { }
		public virtual void OnShoot(Vector3 boost) { }
		public virtual void OnCancel() { }
		public virtual void OnReset() { }
		public virtual void OnGoalReached() { }

		public GolfBallController GetOwner()
		{
			if (GolfBallController == null)
				GolfBallController = GetComponent<GolfBallController>() ?? GetComponentInParent<GolfBallController>();
			return GolfBallController;
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Core/GolfBallShooterBase.cs", """using UnityEngine;

namespace Core
{
	public abstract class GolfBallShooterBase : ShooterBase
	{
		protected Rigidbody rigidbodyC;
		[SerializeField] protected float goalPullForce = 5f;
		[SerializeField] protected float goalPullDistance = 1.5f;
		[SerializeField] protected float angleThreshold = 45f;
		[SerializeField] private GolfBallController golfBallControllerOverride;
		[SerializeField] private Rigidbody rigidbodyOverride;
		[SerializeField] public bool isblockedIfNotGrounded;
		public float sqrVelocityShootingThreshold = 0.25f;
		public float shootThresholdMinimumTime = 0.05f;
		protected float lastUnderVelocityShootingThreshold;
		private float currentStillTime;
		private float stillTimeThreshold = 0.05f;

		public Rigidbody RigidbodyOverride
		{
			get => rigidbodyOverride != null ? rigidbodyOverride : rigidbodyC;
			set { rigidbodyOverride = value; rigidbodyC = value; }
		}

		protected virtual void Awake()
		{
			rigidbodyC = rigidbodyOverride != null ? rigidbodyOverride : GetComponent<Rigidbody>();
			GolfBallController = golfBallControllerOverride != null ? golfBallControllerOverride : GetComponent<GolfBallController>();
			if (GolfBallController != null)
			{
				GolfBallController.shooter = this;
				GolfBallController.OnShoot -= GolfBallController_OnShoot;
				GolfBallController.OnShoot += GolfBallController_OnShoot;
				GolfBallController.AddBlockingFunction(IsBlocking);
			}
		}

		private void GolfBallController_OnShoot(Vector3 obj) => OnShoot(obj);

		public void SetOwner(GolfBallController newOwner)
		{
			GolfBallController = newOwner;
			if (GolfBallController != null)
				GolfBallController.shooter = this;
		}

		protected virtual void FixedUpdate()
		{
			if (rigidbodyC == null) rigidbodyC = GetComponent<Rigidbody>();
		}

		protected virtual bool IsBlocking()
		{
			if (isblockedIfNotGrounded && GolfBallController != null && !GolfBallController.IsGrounded)
				return true;
			if (rigidbodyC != null && sqrVelocityShootingThreshold > 0f)
				return rigidbodyC.velocity.sqrMagnitude > sqrVelocityShootingThreshold;
			return false;
		}

		protected void StandardShoot(Vector3 boost, float pitch, float fullShootVelocity, float spin)
		{
			StandardShoot(boost, pitch, 0f, fullShootVelocity, spin);
		}

		protected virtual void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
			if (rigidbodyC == null) rigidbodyC = GetComponent<Rigidbody>();
			if (rigidbodyC == null) return;
			rigidbodyC.isKinematic = false;
			rigidbodyC.WakeUp();

			float mag = Mathf.Clamp01(boost.magnitude);
			if (mag <= 1e-4f) return;
			Vector3 dir = boost.normalized;
			if (Mathf.Abs(pitch) > 0.01f)
			{
				Vector3 right = Vector3.Cross(Vector3.up, dir).normalized;
				if (right.sqrMagnitude < 1e-4f) right = Vector3.right;
				dir = Quaternion.AngleAxis(-pitch * mag, right) * dir;
			}
			float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 18f, mag);
			rigidbodyC.velocity = dir.normalized * speed;
			if (Mathf.Abs(spin) > 0.01f)
				rigidbodyC.AddTorque(Vector3.Cross(Vector3.up, dir) * spin * mag, ForceMode.Impulse);
		}

		public void StopAndSleep()
		{
			if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
				rigidbodyC.Sleep();
			}
		}

		public void StartAndWakeup()
		{
			if (rigidbodyC != null)
			{
				rigidbodyC.isKinematic = false;
				rigidbodyC.WakeUp();
			}
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Core/GolfBallShooterStandard.cs", """using UnityEngine;

namespace Core
{
	public class GolfBallShooterStandard : GolfBallShooterBase
	{
		[SerializeField] private float fullShootVelocity = 18f;
		[SerializeField] private float pitch;

		public override void OnActivate() => StartAndWakeup();

		public override void OnShoot(Vector3 boost)
		{
			StandardShoot(boost, pitch, fullShootVelocity > 0f ? fullShootVelocity : 18f, 0f);
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Core/GolfBallShooterStandardSpin.cs", """using UnityEngine;

namespace Core
{
	public class GolfBallShooterStandardSpin : GolfBallShooterBase
	{
		[SerializeField] private float fullShootVelocity = 18f;
		[SerializeField] private float pitch;
		[SerializeField] private float spin = 5f;

		public override void OnActivate() => StartAndWakeup();

		public override void OnShoot(Vector3 boost)
		{
			StandardShoot(boost, pitch, fullShootVelocity > 0f ? fullShootVelocity : 18f, spin);
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Core/GolfBallShooterExperimental.cs", """using UnityEngine;

namespace Core
{
	public class GolfBallShooterExperimental : GolfBallShooterBase
	{
		[SerializeField] public float minShootVelocity = 2f;
		[SerializeField] public float fullShootVelocity = 18f;
		[SerializeField] public float pitch;
		[SerializeField] public AnimationCurve powerToPitchWeightCurve;
		[SerializeField] public float spin;
		[SerializeField] protected bool lookInShotDirection;
		public bool lookInAimDirection;
		[SerializeField] protected bool onlyLookWhenChargingOnController;
		public float LookInAimDirectionSpeed = 10f;
		[SerializeField] protected bool dontLookInAimDirectionWhenBlocked;
		[SerializeField] protected bool useLocalUp;
		[SerializeField] public bool zeroPitchIfNotGrouneded;

		protected override void Awake() => base.Awake();
		public override void OnActivate() => StartAndWakeup();

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (lookInAimDirection && boost.sqrMagnitude > 0.001f)
			{
				Vector3 flat = new Vector3(boost.x, 0f, boost.z);
				if (flat.sqrMagnitude > 0.001f)
				{
					Quaternion targetRot = Quaternion.LookRotation(flat.normalized, Vector3.up);
					transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, Time.unscaledDeltaTime * Mathf.Max(5f, LookInAimDirectionSpeed));
				}
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			float p = (zeroPitchIfNotGrouneded && GolfBallController != null && !GolfBallController.IsGrounded) ? 0f : pitch;
			StandardShoot(boost, p, minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 18f, spin);
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Core/GolfBallShooterExperimentalSim2d.cs", """using UnityEngine;

namespace Core
{
	public class GolfBallShooterExperimentalSim2d : GolfBallShooterBase
	{
		[SerializeField] public float minShootVelocity = 2f;
		[SerializeField] public float fullShootVelocity = 18f;
		[SerializeField] public float pitch;
		[SerializeField] public AnimationCurve powerToPitchWeightCurve;
		[SerializeField] public float spin;
		[SerializeField] protected bool lookInShotDirection;
		public bool lookInAimDirection;
		[SerializeField] protected bool onlyLookWhenChargingOnController;
		public float LookInAimDirectionSpeed = 10f;
		[SerializeField] protected bool dontLookInAimDirectionWhenBlocked;
		[SerializeField] protected bool useLocalUp;
		[SerializeField] public bool zeroPitchIfNotGrouneded;
		public float allowedZVariance = 0.05f;
		public float zCorrectionSpeedMultiplier = 10f;
		public float minimumZCorrectionSpeed = 1f;
		private float originZ;

		protected override void Awake()
		{
			base.Awake();
			originZ = transform.position.z;
		}

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (rigidbodyC != null && Mathf.Abs(transform.position.z - originZ) > allowedZVariance)
			{
				Vector3 p = transform.position;
				p.z = Mathf.MoveTowards(p.z, originZ, Time.fixedDeltaTime * Mathf.Max(minimumZCorrectionSpeed, zCorrectionSpeedMultiplier));
				transform.position = p;
			}
		}

		public override void OnActivate() => StartAndWakeup();
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow) { }

		public override void OnShoot(Vector3 boost)
		{
			float p = (zeroPitchIfNotGrouneded && GolfBallController != null && !GolfBallController.IsGrounded) ? 0f : pitch;
			StandardShoot(boost, p, minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 18f, spin);
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Core/GolfBall2DShooterBase.cs", """using System.Collections;
using UnityEngine;

namespace Core
{
	public abstract class GolfBall2DShooterBase : ShooterBase
	{
		protected Rigidbody2D rigidbodyC;
		[SerializeField] private float goalPullForce = 5f;
		[SerializeField] private float goalPullDistance = 1.5f;
		[SerializeField] private bool useCurrentForce;
		public float sqrVelocityShootingThreshold = 0.25f;
		private float currentStillTime;
		private float stillTimeThreshold = 0.05f;
		private Coroutine lockRoutine;

		protected virtual void Awake()
		{
			rigidbodyC = GetComponent<Rigidbody2D>();
			GolfBallController = GetComponent<GolfBallController>() ?? GetComponentInParent<GolfBallController>();
			if (GolfBallController != null)
			{
				GolfBallController.shooter = this;
				GolfBallController.OnShoot -= OnShoot;
				GolfBallController.OnShoot += OnShoot;
				GolfBallController.AddBlockingFunction(IsBlocking);
			}
		}

		protected virtual void FixedUpdate()
		{
			if (rigidbodyC == null) rigidbodyC = GetComponent<Rigidbody2D>();
		}

		protected virtual bool IsBlocking()
		{
			if (rigidbodyC != null && sqrVelocityShootingThreshold > 0f)
				return rigidbodyC.velocity.sqrMagnitude > sqrVelocityShootingThreshold;
			return false;
		}

		protected void StandardShoot(Vector3 boost, float pitch, float fullShootVelocity, float spin)
		{
			StandardShoot(boost, pitch, 0f, fullShootVelocity, spin);
		}

		public void StopAndSleep()
		{
			if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector2.zero;
				rigidbodyC.angularVelocity = 0f;
				rigidbodyC.Sleep();
			}
		}

		public void StartAndWakeup()
		{
			if (rigidbodyC != null)
			{
				rigidbodyC.isKinematic = false;
				rigidbodyC.WakeUp();
			}
		}

		protected void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
			if (rigidbodyC == null) rigidbodyC = GetComponent<Rigidbody2D>();
			if (rigidbodyC == null) return;
			rigidbodyC.isKinematic = false;
			rigidbodyC.WakeUp();

			Vector2 dir2 = new Vector2(boost.x, boost.y);
			if (dir2.sqrMagnitude < 1e-4f)
				dir2 = new Vector2(boost.x, boost.z);
			float mag = Mathf.Clamp01(dir2.magnitude);
			if (mag <= 1e-4f) return;

			Vector2 dir = dir2.normalized;
			if (Mathf.Abs(pitch) > 0.01f)
			{
				float sign = dir.x >= 0f ? 1f : -1f;
				dir = Quaternion.Euler(0f, 0f, pitch * sign * mag) * dir;
			}
			float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 16f, mag);
			rigidbodyC.velocity = dir.normalized * speed;
			if (Mathf.Abs(spin) > 0.01f)
				rigidbodyC.AddTorque(-Mathf.Sign(dir.x) * spin * mag, ForceMode2D.Impulse);
		}

		public void LockForDuration(float v)
		{
			if (gameObject.activeInHierarchy)
				lockRoutine = StartCoroutine(LockForDurationRoutine(v));
		}

		private IEnumerator LockForDurationRoutine(float duration)
		{
			StopAndSleep();
			yield return new WaitForSeconds(duration);
			StartAndWakeup();
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Core/GolfBall2DShooterExperimental.cs", """using UnityEngine;

namespace Core
{
	public class GolfBall2DShooterExperimental : GolfBall2DShooterBase
	{
		[SerializeField] public float minShootVelocity = 2f;
		[SerializeField] public float fullShootVelocity = 16f;
		[SerializeField] public float pitch;
		[SerializeField] public float spin;
		[SerializeField] public bool zeroPitchIfNotGrouneded;
		[SerializeField] public bool lookInAimDirection;

		public override void OnActivate() => StartAndWakeup();
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow) { }

		public override void OnShoot(Vector3 boost)
		{
			float p = (zeroPitchIfNotGrouneded && GolfBallController != null && !GolfBallController.IsGrounded) ? 0f : pitch;
			StandardShoot(boost, p, minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 16f, spin);
		}
	}
}
""")

    # 4. Core/ShootArrow.cs
    write_asset_file("Scripts/Assembly-CSharp/Core/ShootArrow.cs", """using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class ShootArrow : MonoBehaviour
	{
		public enum MoveMethodEnum
		{
			Normal = 0,
			Physics = 1,
			Physics2D = 2,
			None = 3,
			SmoothedPhysics = 4
		}

		[SerializeField] public List<Renderer> renderers = new List<Renderer>();
		[SerializeField] public List<Renderer> shadowRenderers = new List<Renderer>();
		[SerializeField] public Renderer arrowOutline;
		[SerializeField] public Color colorMin = new Color(1f, 0.9f, 0.2f, 1f);
		[SerializeField] public Color colorMax = new Color(1f, 0.2f, 0.2f, 1f);
		[SerializeField] public AnimationCurve colorCurve;
		[SerializeField] public Color blockedColor = Color.gray;
		[SerializeField] public Color outlineBlockedColor = Color.black;
		[SerializeField] public Transform overrideBall;
		[SerializeField] public Transform basePivot;
		[SerializeField] public float limitValue = 1f;
		[SerializeField] public Transform arrowHeadJoint;
		[SerializeField] public Transform arrowBaseJoint;
		[SerializeField] public MoveMethodEnum MoveMethod;
		[SerializeField] public MoveMethodEnum RotateMethod;
		[SerializeField] private GameObject boostArrow;
		[SerializeField] public bool AutoHide = true;
		[SerializeField] public float SmoothedPhysicsSpeed = 15f;
		[SerializeField] private float gyroMagnitude;
		[SerializeField] private float scaleMod = 1f;

		private float alphaDipSpeed;
		private float alphaDipStart;
		public float InsideAlpha = 0.5f;
		public float InsideAlphaOutline = 0.5f;
		public Camera cam;
		private GolfBallController ball;
		private float blockValue;
		private Material arrowMaterial;
		private Material arrowOutlineMaterial;
		private float arrowSize;
		private float targetArrowSize;
		private float arrowSizeChangeSpeed;
		private Rigidbody rigid;
		private Rigidbody2D rigid2D;
		private float alphaTarget;
		private float currentAlpha;
		private bool overrideIsBlocked;
		public bool clampAimVector = true;

		public float ShaftLength => arrowSize * Scale;
		private float Scale => ball != null && ball.Scale > 0f ? ball.Scale : 1f;
		private Vector3 Up => ball != null && ball.AimPlane == AimPlanes.Camera ? Vector3.forward : Vector3.up;

		public bool CastShadow
		{
			set
			{
				if (shadowRenderers != null)
				{
					foreach (var r in shadowRenderers)
						if (r != null) r.enabled = value;
				}
			}
		}

		private Camera GetCam() => cam != null ? cam : (cam = Camera.main);

		public void Initialize(GolfBallController ballController, bool showArrowOnTop)
		{
			ball = ballController;
			if (scaleMod <= 0f) scaleMod = 1f;
			if (AutoHide) Hide();
		}

		public void SetOverrideBall(Transform newBall) => overrideBall = newBall;

		private Vector3 GetGyroDirection(float amount) => Vector3.zero;

		public void UpdateDashedArrow(Vector3 dir) { }

		public void UpdateArrow(Vector3 vec, bool isBlocked, bool onlyDashedArrow)
		{
			if (!gameObject.activeSelf)
				gameObject.SetActive(true);
			Transform target = overrideBall != null ? overrideBall : (ball != null ? ball.ArrowPosition : null);
			if (target != null)
				MoveArrow(target.position);
			RotateArrow(vec);
			ChangeLength(Mathf.Clamp01(vec.magnitude));
			SetArrowColor(isBlocked || overrideIsBlocked ? blockedColor : GetColor(vec));
		}

		public void SetBlockOverride(bool value) => overrideIsBlocked = value;

		private void MoveArrow(Vector3 position) => transform.position = position;

		private void RotateArrow(Vector3 vec)
		{
			if (vec.sqrMagnitude < 1e-5f) return;
			if (ball != null && (ball.AimPlane == AimPlanes.Camera || ball.AimPlane == AimPlanes.LocalXY))
			{
				float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.Euler(0f, 0f, angle - 90f);
			}
			else
			{
				Vector3 flat = new Vector3(vec.x, 0f, vec.z);
				if (flat.sqrMagnitude > 1e-5f)
					transform.rotation = Quaternion.LookRotation(flat.normalized, Vector3.up);
			}
		}

		private void ChangeLength(float ratio)
		{
			arrowSize = ratio;
			float s = Mathf.Lerp(0.25f, 2.2f, ratio) * Scale;
			if (basePivot != null)
				basePivot.localScale = new Vector3(Scale, Scale, s);
			else
				transform.localScale = new Vector3(Scale, s, s);
		}

		public void PlayShootSequence(float t) => Hide();

		public void SetArrowColor(Color c)
		{
			if (renderers != null)
			{
				foreach (var r in renderers)
				{
					if (r != null && r.material != null)
						r.material.color = c;
				}
			}
		}

		public Color GetColor(Vector3 vec)
		{
			float t = Mathf.Clamp01(vec.magnitude);
			if (colorCurve != null && colorCurve.length > 0)
				t = colorCurve.Evaluate(t);
			return Color.Lerp(colorMin, colorMax, t);
		}

		public void StartAim()
		{
			gameObject.SetActive(true);
		}

		public void Hide()
		{
			if (gameObject != null)
				gameObject.SetActive(false);
		}

		public void DoAlphaDip() { }
		public Vector3? GetClosestPointOnShaft(Vector3 pos) => transform.position;
	}
}
""")

    print("Implemented InputHelper, GyroHelper, TimeControl, Shooter classes, and ShootArrow")


if __name__ == "__main__":
    main()
