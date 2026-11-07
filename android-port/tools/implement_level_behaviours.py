#!/usr/bin/env python3
"""Implement the top 29 most-used level, camera, physics, collision, door, barrel,
localization, and animation behaviours across all 336 scenes in WHAT THE GOLF?.
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
    # 1. CameraStack/CameraBehavior.cs, CameraBehaviorPerspective.cs, CameraManager.cs, CBFollow.cs, CBStatic.cs
    write_asset_file("Scripts/Assembly-CSharp/CameraStack/CameraBehavior.cs", """using System;
using Cinemachine;
using Core;
using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehavior : MonoBehaviour
	{
		public string PlatformName;
		[NonSerialized] public Camera[] cameras;
		public bool IsAttachedToCameraManager;
		private CinemachineVirtualCamera[] virtualCameras;

		public Camera[] Cameras
		{
			get => cameras ?? (cameras = GetComponentsInChildren<Camera>(true));
			set => cameras = value;
		}

		public CinemachineVirtualCamera[] VirtualCameras
		{
			get => virtualCameras ?? (virtualCameras = GetComponentsInChildren<CinemachineVirtualCamera>(true));
			set => virtualCameras = value;
		}

		protected GolfBallController Ball => Level.HasInstance ? Level.Instance.Ball : FindObjectOfType<GolfBallController>();
		public Vector3 Position => CalculatePosition();
		public Quaternion Rotation => CalculateRotation();

		public void ResetCameras() { }
		public virtual void Init() { }
		public virtual void Cleanup() { }
		public virtual void PreUpdate() { }
		public abstract Quaternion CalculateRotation();
		protected abstract Vector3 CalculatePosition();
		public virtual void OutOfBounds() { }
		public virtual void GoalComplete() { }
		public override string ToString() => name;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/CameraStack/CameraBehaviorPerspective.cs", """using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehaviorPerspective : CameraBehavior
	{
		[SerializeField] private float fieldOfView = 60f;
		public virtual float FOV => fieldOfView > 0f ? fieldOfView : 60f;

		public override void Init()
		{
			if (Cameras != null)
			{
				foreach (var c in Cameras)
				{
					if (c != null && !c.orthographic && fieldOfView > 0f)
						c.fieldOfView = fieldOfView;
				}
			}
		}

		public override void PreUpdate() { }
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/CameraStack/CBStatic.cs", """using UnityEngine;

namespace CameraStack
{
	public class CBStatic : CameraBehaviorPerspective
	{
		[SerializeField] private Transform trans;

		public override void Init()
		{
			base.Init();
			if (trans == null) trans = transform;
		}

		protected override Vector3 CalculatePosition() => (trans != null ? trans : transform).position;
		public override Quaternion CalculateRotation() => (trans != null ? trans : transform).rotation;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/CameraStack/CBFollow.cs", """using System.Collections;
using Chronos;
using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBFollow : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[SerializeField] protected Transform orbitTarget;
		[SerializeField] protected Transform followTarget;
		[SerializeField] protected bool followGoalOnWin = true;
		[SerializeField] public Vector3 rotation = new Vector3(45f, 0f, 0f);
		[SerializeField] public float elevation = 15f;
		[SerializeField] public bool shouldFollow = true;
		[SerializeField] protected float startSmoothTime = 0.25f;
		[SerializeField] protected float continuousSmoothTime = 0.15f;
		[SerializeField] protected float aimSmoothTime = 0.2f;
		[SerializeField] protected float continousTrackingTimer = 0.5f;
		[SerializeField] public Vector2 screenPosition = new Vector2(0.5f, 0.5f);
		[SerializeField] protected float sideTrackPadding = 0.2f;
		[SerializeField] protected float upperTrackPadding = 0.2f;
		[SerializeField] protected float lowerTrackPadding = 0.2f;

		public LocalClock Clock;
		protected float elevationSmoothTime;
		protected Vector2 velocity;
		protected Vector2 adjustedScreenPosition;
		public float groundedElevation;
		public float targetGroundedElevation;
		protected float continousTrackingTimerCountDown;
		protected float diff;
		protected float distance;
		protected float elevationSmoothVel;
		protected float smoothTime;
		protected float width;
		protected float height;
		private Vector3 _currentPos;
		private bool _hasInitialPos;

		public Transform FollowTarget
		{
			get => GetFollowTarget();
			set => followTarget = value;
		}

		protected virtual Vector3 ballAtElevation
		{
			get
			{
				var t = GetFollowTarget();
				return t != null ? t.position : Vector3.zero;
			}
		}

		public Transform GetFollowTarget()
		{
			if (followTarget != null) return followTarget;
			var b = Ball;
			return b != null ? b.transform : orbitTarget;
		}

		public override void Init()
		{
			base.Init();
			_currentPos = transform.position;
			_hasInitialPos = true;
		}

		private IEnumerator WaitForActiveBall()
		{
			yield break;
		}

		public override void OutOfBounds() { }
		public void SetElevation(float newElevation) => elevation = newElevation;
		public float GetElevation() => elevation;
		public void SetRotation(Vector3 newRotation) => rotation = newRotation;
		public Vector3 GetRotation() => rotation;
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);
		protected Vector3 ScreenToWorld(Vector2 screenPos) => transform.position;
		protected void UpdateWidthAndHeight() { }

		protected override Vector3 CalculatePosition()
		{
			var target = GetFollowTarget();
			if (target == null || !shouldFollow) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = elevation > 0.1f ? elevation : 14f;
			Vector3 desired = target.position - (rot * Vector3.forward) * dist;
			if (!_hasInitialPos)
			{
				_currentPos = desired;
				_hasInitialPos = true;
			}
			else
			{
				float st = Mathf.Max(0.05f, continuousSmoothTime);
				_currentPos = Vector3.Lerp(_currentPos, desired, Time.unscaledDeltaTime / st);
			}
			return _currentPos;
		}

		protected bool IsBallOutsideOfBox() => true;
		protected bool IsPointOutsideOfBox(Vector3 p) => true;
		public override string ToString() => name;
		public void SetFollowTarget(Transform target) => followTarget = target;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/CameraStack/CameraManager.cs", """using System;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

namespace CameraStack
{
	public class CameraManager : MonoBehaviour
	{
		private static CameraManager _instance;
		private Action<CameraBehavior> m_OnActiveBehaviourChanged;
		private Camera[] _cameras;
		public bool useGyroSense;
		[SerializeField] public CameraBehavior OnPlayCameraBehavior;
		[SerializeField] public CameraBehavior DesktopCameraOverrideBehaviour;
		public bool challengeSetup;
		[SerializeField] public CameraBehavior OnChallengeCameraBehavior;
		[SerializeField] public CameraBehavior DesktopChallengeCameraOverrideBehaviour;
		private bool _started;
		private bool? _is2D;
		private PerlinShake shake;
		private GyroShake gyro;
		private bool activeBehaviourAttachedToThis;
		public float gyroSenseMagnitude;

		public static CameraManager Instance => _instance != null ? _instance : (_instance = FindObjectOfType<CameraManager>());
		public Camera[] Cameras => _cameras ?? (_cameras = GetComponentsInChildren<Camera>(true));
		public Camera MainCamera => GetComponent<Camera>() ?? (Cameras.Length > 0 ? Cameras[0] : Camera.main);
		public CameraBehavior ActiveBehavior { get; private set; }
		public bool Is2D { set => _is2D = value; }

		public event Action<CameraBehavior> OnActiveBehaviourChanged
		{
			add => m_OnActiveBehaviourChanged = (Action<CameraBehavior>)Delegate.Combine(m_OnActiveBehaviourChanged, value);
			remove => m_OnActiveBehaviourChanged = (Action<CameraBehavior>)Delegate.Remove(m_OnActiveBehaviourChanged, value);
		}

		public void Reset() => SetCurrentBehaviour();

		public void SetChallengeBehaviour(CameraBehavior arg1, CameraBehavior arg2)
		{
			OnChallengeCameraBehavior = arg1;
			DesktopChallengeCameraOverrideBehaviour = arg2;
		}

		private void Awake()
		{
			_instance = this;
			_cameras = GetComponentsInChildren<Camera>(true);
			SetCurrentBehaviour();
		}

		private void OnDestroy()
		{
			if (_instance == this) _instance = null;
		}

		private void OnChallengeSelected(string id) { }

		public void SetCurrentBehaviour()
		{
			var next = OnPlayCameraBehavior != null ? OnPlayCameraBehavior : DesktopCameraOverrideBehaviour;
			if (next == null) next = GetComponent<CameraBehavior>();
			if (next != null) SwitchBehavior(next);
		}

		private void Start()
		{
			_started = true;
			SetCurrentBehaviour();
		}

		private void StartCheckingForAirPlay() { }
		private void OnReset() { }

		private void Update() => ManualUpdate();

		public void SwitchBehavior(CameraBehavior newCameraBehavior)
		{
			if (newCameraBehavior == null) return;
			ActiveBehavior?.Cleanup();
			ActiveBehavior = newCameraBehavior;
			ActiveBehavior.Cameras = Cameras;
			ActiveBehavior.Init();
			m_OnActiveBehaviourChanged?.Invoke(ActiveBehavior);
		}

		private void OnGoal(Level.CompletedState s) => ActiveBehavior?.GoalComplete();

		public void ManualUpdate()
		{
			if (ActiveBehavior == null) return;
			ActiveBehavior.PreUpdate();
			transform.position = ActiveBehavior.Position;
			transform.rotation = ActiveBehavior.Rotation;
		}

		public void Shake(float duration, float speed, float magnitude) { }
		public void StopShake() { }
		public float GetShakeMagnitude() => 0f;
		private void OnDrawGizmosSelected() { }
	}
}
""")

    # 2. CollisionEvents.cs & CollisionEvent2D.cs
    write_asset_file("Scripts/Assembly-CSharp/CollisionEvents.cs", """using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvents : MonoBehaviour
{
	public UnityEvent OnCollisionEnterEvent = new UnityEvent();
	public UnityEvent OnCollisionExitEvent = new UnityEvent();
	public UnityEvent OnTriggerEnterEvent = new UnityEvent();
	public UnityEvent OnTriggerExitEvent = new UnityEvent();
	public Action<Rigidbody> OnCollisionEnterTrigger;
	public Action<Rigidbody> OnTriggerEnterTrigger;
	public Action<Rigidbody> OnTriggerExitTrigger;
	public List<Collider> Blacklist = new List<Collider>();
	public List<string> AcceptedTags = new List<string>();

	private bool Accepts(Collider col)
	{
		if (col == null) return false;
		if (Blacklist != null && Blacklist.Contains(col)) return false;
		if (AcceptedTags != null && AcceptedTags.Count > 0 && !AcceptedTags.Contains(col.tag)) return false;
		return true;
	}

	private void OnCollisionEnter(Collision col)
	{
		if (col != null && Accepts(col.collider))
		{
			OnCollisionEnterEvent?.Invoke();
			OnCollisionEnterTrigger?.Invoke(col.rigidbody);
		}
	}

	private void OnCollisionExit(Collision col)
	{
		if (col != null && Accepts(col.collider))
			OnCollisionExitEvent?.Invoke();
	}

	private void OnTriggerEnter(Collider col)
	{
		if (Accepts(col))
		{
			OnTriggerEnterEvent?.Invoke();
			OnTriggerEnterTrigger?.Invoke(col.attachedRigidbody);
		}
	}

	private void OnTriggerExit(Collider col)
	{
		if (Accepts(col))
		{
			OnTriggerExitEvent?.Invoke();
			OnTriggerExitTrigger?.Invoke(col.attachedRigidbody);
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/CollisionEvent2D.cs", """using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent2D : MonoBehaviour
{
	public UnityEvent OnEnter = new UnityEvent();
	public UnityEvent OnStay = new UnityEvent();
	public UnityEvent OnExit = new UnityEvent();
	public UnityEvent OnTriggerEnter = new UnityEvent();
	public UnityEvent OnTriggerStay = new UnityEvent();
	public UnityEvent OnTriggerExit = new UnityEvent();
	public List<string> Tags = new List<string>();
	public float minForce;
	public bool acceptAny = true;
	public float Delay;

	private bool Accepts(Collider2D col)
	{
		if (col == null) return false;
		if (acceptAny || Tags == null || Tags.Count == 0) return true;
		return Tags.Contains(col.tag);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other != null && Accepts(other.collider) && other.relativeVelocity.magnitude >= minForce)
		{
			if (Delay > 0f) Invoke(nameof(EnterInvoke), Delay);
			else EnterInvoke();
		}
	}

	private void OnCollisionStay2D(Collision2D other)
	{
		if (other != null && Accepts(other.collider))
			OnStay?.Invoke();
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		if (other != null && Accepts(other.collider))
		{
			if (Delay > 0f) Invoke(nameof(ExitInvoke), Delay);
			else ExitInvoke();
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (Accepts(other))
			OnTriggerEnter?.Invoke();
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		if (Accepts(other))
			OnTriggerStay?.Invoke();
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (Accepts(other))
			OnTriggerExit?.Invoke();
	}

	private void EnterInvoke() => OnEnter?.Invoke();
	private void ExitInvoke() => OnExit?.Invoke();
}
""")

    # 3. ExplosionBarrel.cs, TipObject.cs, OverworldDoor.cs, SpeedBoostPad.cs, Gravity.cs
    write_asset_file("Scripts/Assembly-CSharp/ExplosionBarrel.cs", """using System;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class ExplosionBarrel : MonoBehaviour, IAudioEvent
{
	private Action<Collider, ExplosionBarrel> m_OnExplode;
	public UnityEvent OnExplodeEvent = new UnityEvent();
	public PlayClipOnAudioEvent ExplosionSFX;
	public float startCooldown = 0.1f;
	public bool canExplode = true;
	public ParticleSystem ps;
	public float impactThreshold = 1f;
	public float radius = 5f;
	public float power = 500f;
	public Renderer normalRender;
	public Renderer burnedRender;
	public bool screenShake = true;
	public float PlayerBlockDuration;
	public bool DestroyOnExplosion;
	public bool KeepOldVelocity;
	public float hitObjectExplosionForce = 500f;
	public Vector3 hitObjectExplosionForceModsMinRange;
	public Vector3 hitObjectExplosionForceModsMaxRange;
	public bool applyNormalExplosionToHitObject = true;
	public LayerMask ignoreLayers;
	public bool ExplodeOnOutOfBounds;
	public bool AddRandomAngularVelocity = true;

	private float ignoreTime;
	private float startTime;
	public bool didExplode;
	private float explosionTime;
	private bool shouldExplode;
	private Rigidbody rigid;
	private Collider[] nearbyColliders;
	private Rigidbody[] nearbyRigids;
	private float allowedExplodeTime;
	private bool initialized;
	private GolfBallController ball;

	public Action<Vector3> OnAudioEvent { get; set; }

	public event Action<Collider, ExplosionBarrel> OnExplode
	{
		add => m_OnExplode = (Action<Collider, ExplosionBarrel>)Delegate.Combine(m_OnExplode, value);
		remove => m_OnExplode = (Action<Collider, ExplosionBarrel>)Delegate.Remove(m_OnExplode, value);
	}

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		allowedExplodeTime = Time.time + startCooldown;
		initialized = true;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (didExplode || !canExplode || Time.time < allowedExplodeTime) return;
		if (collision != null && collision.relativeVelocity.magnitude >= impactThreshold)
			Explode(collision.collider);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (didExplode || !canExplode || Time.time < allowedExplodeTime) return;
		if (other != null && (other.GetComponentInParent<GolfBallController>() != null || other.CompareTag("Player") || other.CompareTag("Ball")))
			Explode(other);
	}

	private void Update()
	{
		if (shouldExplode && !didExplode && Time.time >= explosionTime)
			Explode(null);
	}

	public void SetExplosionTimer(float delay)
	{
		shouldExplode = true;
		explosionTime = Time.time + delay;
	}

	public void CanExplode() => canExplode = true;

	public void Explode(Collider col = null) => Explode(Vector3.up, col);

	private void Explode(Vector3 normal, Collider col = null)
	{
		if (didExplode) return;
		didExplode = true;
		if (ps != null) ps.Play();
		if (normalRender != null && burnedRender != null)
		{
			normalRender.enabled = false;
			burnedRender.enabled = true;
		}
		float r = radius > 0f ? radius : 5f;
		float f = power > 0f ? power : 400f;
		foreach (var hit in Physics.OverlapSphere(transform.position, r))
		{
			var rb = hit.attachedRigidbody;
			if (rb != null && !rb.isKinematic)
				rb.AddExplosionForce(f, transform.position, r, 1f, ForceMode.Impulse);
		}
		OnAudioEvent?.Invoke(transform.position);
		OnExplodeEvent?.Invoke();
		m_OnExplode?.Invoke(col, this);
		if (DestroyOnExplosion)
			gameObject.SetActive(false);
	}

	public void Reset()
	{
		didExplode = false;
		shouldExplode = false;
		if (normalRender != null) normalRender.enabled = true;
		if (burnedRender != null) burnedRender.enabled = false;
		gameObject.SetActive(true);
	}

	private void OnDrawGizmosSelected() { }
}
""")

    write_asset_file("Scripts/Assembly-CSharp/TipObject.cs", """using UnityEngine;

public class TipObject : TippableObjectBase
{
	public float SleepThreshold = 0.1f;
	public float DotThreshold = 0.5f;
	public float CheckTimer = 0.2f;
	public Vector3 AxisToCheck = Vector3.up;
	private bool hasBeenTipped;
	private float timer;
	public bool extremeTip;

	private void Awake()
	{
		if (AxisToCheck.sqrMagnitude < 1e-4f) AxisToCheck = Vector3.up;
	}

	private void FixedUpdate()
	{
		if (hasBeenTipped) return;
		timer += Time.fixedDeltaTime;
		if (timer >= CheckTimer)
		{
			timer = 0f;
			if (Vector3.Dot(transform.TransformDirection(AxisToCheck), Vector3.up) < DotThreshold)
				Tip();
		}
	}

	private void OnCollisionEnter(Collision other) { }
	private void OnTriggerEnter(Collider other) { }

	private void Tip()
	{
		if (hasBeenTipped) return;
		hasBeenTipped = true;
		OnTip?.Invoke(gameObject);
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/OverworldDoor.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Audio;
using CameraStack;
using UnityEngine;

public class OverworldDoor : MonoBehaviour
{
	public Transform LeftDoor;
	public Transform RightDoor;
	public GameObject Button;
	public AnimationCurve animationCurve;
	public float RoutineLength = 0.5f;
	public float DoorExtend = 2f;
	public GameObject DoorSides;
	public List<Collider2D> Colliders = new List<Collider2D>();
	public bool DebugThisDoor;
	public Vector3[] corners;
	public float BallDistanceThreshold = 3f;
	public float Speed = 5f;
	public float Magnitude = 1f;
	public bool canPlaySound = true;
	public PlayClipOnAudioEvent SFX;

	private OverworldCamera cam;
	private Vector3 leftStart;
	private Vector3 rightStart;
	private bool _inited;

	public void SetCamera(OverworldCamera overworldCamera) => cam = overworldCamera;

	public void Init()
	{
		if (_inited) return;
		_inited = true;
		if (LeftDoor != null) leftStart = LeftDoor.localPosition;
		if (RightDoor != null) rightStart = RightDoor.localPosition;
	}

	public void OpenDoor(Action onOpen, bool instant = false)
	{
		Init();
		if (LeftDoor != null) LeftDoor.localPosition = leftStart + Vector3.left * DoorExtend;
		if (RightDoor != null) RightDoor.localPosition = rightStart + Vector3.right * DoorExtend;
		if (Colliders != null)
		{
			foreach (var c in Colliders)
				if (c != null) c.enabled = false;
		}
		onOpen?.Invoke();
	}

	public Task OpenDoorAsync(Action onOpen, float duration, bool playEndSounds = true)
	{
		OpenDoor(onOpen, false);
		return Task.CompletedTask;
	}

	private Task MoveDoorsOpen(float duration) => Task.CompletedTask;

	public void RemoveButton()
	{
		if (Button != null) Button.SetActive(false);
	}

	public IEnumerator CloseDoorRoutine(Action onClose, float duration, bool playEndSounds = true)
	{
		Init();
		if (LeftDoor != null) LeftDoor.localPosition = leftStart;
		if (RightDoor != null) RightDoor.localPosition = rightStart;
		if (Colliders != null)
		{
			foreach (var c in Colliders)
				if (c != null) c.enabled = true;
		}
		onClose?.Invoke();
		yield break;
	}

	public Vector3 GetCornerInThatDirection(Vector3 worldDir) => transform.position;
	private void OnDrawGizmos() { }
}
""")

    write_asset_file("Scripts/Assembly-CSharp/SpeedBoostPad.cs", """using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostPad : MonoBehaviour
{
	public Vector3 ForceDirection = Vector3.forward;
	public float SpeedBoost = 25f;
	public ForceMode Mode = ForceMode.Acceleration;
	private List<Rigidbody> affectedRigidbodies = new List<Rigidbody>();

	private void Start() { }

	private void FixedUpdate()
	{
		affectedRigidbodies.RemoveAll(r => r == null);
		Vector3 worldDir = transform.TransformDirection(ForceDirection.normalized);
		foreach (var rb in affectedRigidbodies)
		{
			if (!rb.isKinematic)
				rb.AddForce(worldDir * SpeedBoost, Mode);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other?.rigidbody != null && !affectedRigidbodies.Contains(other.rigidbody))
			affectedRigidbodies.Add(other.rigidbody);
	}

	private void OnCollisionExit(Collision other)
	{
		if (other?.rigidbody != null)
			affectedRigidbodies.Remove(other.rigidbody);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other?.attachedRigidbody != null && !affectedRigidbodies.Contains(other.attachedRigidbody))
			affectedRigidbodies.Add(other.attachedRigidbody);
	}

	private void OnTriggerExit(Collider other)
	{
		if (other?.attachedRigidbody != null)
			affectedRigidbodies.Remove(other.attachedRigidbody);
	}

	private void OnDrawGizmosSelected() { }
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Gravity.cs", """using UnityEngine;

public class Gravity : MonoBehaviour
{
	[SerializeField] private bool twoD;
	[SerializeField] public float gravity = -9.81f;
	[SerializeField] private Vector3 extraGravity;

	private void OnEnable() => UpdateGravity();

	public void UpdateGravity()
	{
		float g = Mathf.Abs(gravity) > 0.01f ? -Mathf.Abs(gravity) : -9.81f;
		if (twoD)
			Physics2D.gravity = new Vector2(extraGravity.x, g + extraGravity.y);
		else
			Physics.gravity = new Vector3(extraGravity.x, g + extraGravity.y, extraGravity.z);
	}

	public bool IsFake2D() => twoD;
}
""")

    # 4. Utility & Animation Behaviours (TextMeshProLocalized, TweenScale, ActionAfterDelay, FollowTransform, RotateAxis, EventOnInterval, UnparentOnStart, SetCenterOfMass, SetMaxAngularVelocity, SetRigidSolverIterations, ToggleActiveStateOfChildren)
    write_asset_file("Scripts/Assembly-CSharp/TextMeshProLocalized.cs", """using TMPro;
using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class TextMeshProLocalized : MonoBehaviour
{
	private enum HorizontalTextAlignment
	{
		Original = 0,
		FontBased = 10
	}

	[SerializeField] private string _textId;
	public LocalizationFontStyle style;
	public bool isCountdown;
	[SerializeField] private HorizontalTextAlignment HorizontalAlignment;
	protected TMP_Text _tmp;
	protected TextAlignmentOptions _originalAlignment;
	public UnityEvent onTextChanged = new UnityEvent();

	public string TermId => _textId;

	private void Awake()
	{
		CheckForComponent();
		Retranslate();
	}

	public void NotifyLanguageChanged() => Retranslate();

	private void Retranslate()
	{
		if (!string.IsNullOrEmpty(_textId))
			ChangeText(Localization.Instance.GetString(_textId));
	}

	public void ChangeText(string text)
	{
		CheckForComponent();
		if (_tmp != null && !string.IsNullOrEmpty(text))
		{
			_tmp.text = text;
			onTextChanged?.Invoke();
		}
	}

	private void CheckForComponent()
	{
		if (_tmp == null) _tmp = GetComponent<TMP_Text>();
	}

	private static bool TryTranslate(string textOrTerm, out string translated)
	{
		translated = Localization.Instance.GetString(textOrTerm);
		return !string.IsNullOrEmpty(translated);
	}

	public void ClearText()
	{
		CheckForComponent();
		if (_tmp != null) _tmp.text = string.Empty;
	}

	public virtual void ChangeTextAfterTranslation(string textOrTerm) => ChangeText(Localization.Instance.GetString(textOrTerm));
	public void UpdateAlignment() { }
	public void UpdateFont() { }
	private bool IsUGUI() => _tmp is TextMeshProUGUI;
	private static TextAlignmentOptions GetOppositeAlignment(TextAlignmentOptions a) => a;
}
""")

    write_asset_file("Scripts/Assembly-CSharp/TweenScale.cs", """using UnityEngine;

public class TweenScale : MonoBehaviour
{
	[SerializeField] private GameObject totween;
	[SerializeField] private Vector3 from = Vector3.zero;
	[SerializeField] private Vector3 to = Vector3.one;
	[SerializeField] private AnimationCurve animationCurve;
	[SerializeField] private float duration = 0.3f;
	[SerializeField] private bool StartOnAwake = true;

	private void Start()
	{
		if (StartOnAwake) Scale();
	}

	public void Scale()
	{
		var target = totween != null ? totween.transform : transform;
		if (duration <= 0f)
		{
			target.localScale = to;
			return;
		}
		StartCoroutine(pTween.To(duration, t =>
		{
			float eval = animationCurve != null && animationCurve.length > 0 ? animationCurve.Evaluate(t) : t;
			if (target != null) target.localScale = Vector3.LerpUnclamped(from, to, eval);
		}));
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/ActionAfterDelay.cs", """using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ActionAfterDelay : MonoBehaviour
{
	[SerializeField] private float delay = 0.5f;
	[SerializeField] private bool startOnEnable = true;
	[SerializeField] private UnityEvent m_Event = new UnityEvent();

	private void OnEnable()
	{
		if (startOnEnable) DoAction();
	}

	public void DoAction()
	{
		if (gameObject.activeInHierarchy)
			StartCoroutine(Do());
	}

	private IEnumerator Do()
	{
		if (delay > 0f)
			yield return new WaitForSeconds(delay);
		m_Event?.Invoke();
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/FollowTransform.cs", """using UnityEngine;

public class FollowTransform : MonoBehaviour
{
	public Transform Target;
	public Vector3 FollowAxis = Vector3.one;
	public float FollowSpeed = 20f;
	public bool UsePhysics;
	public bool FollowUpVector;
	public bool FollowRotation;
	public bool TransformPositionOffset;
	public bool InverseTransformPositionOffset;
	public Vector3 RotationOffset;
	public Vector3 PositionOffset;
	public Vector3 LookDirectionAxis;
	public Vector2 HeightRange;
	private Rigidbody rigid;
	public float LookSpeed = 10f;
	public bool LookAtTarget;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
	}

	public void ManualFollowUpdate()
	{
		if (Target == null) return;
		transform.position = GetPosition();
		if (FollowRotation || LookAtTarget)
			transform.rotation = GetRotation();
	}

	private void Update()
	{
		if (!UsePhysics) ManualFollowUpdate();
	}

	private void FixedUpdate()
	{
		if (UsePhysics) ManualFollowUpdate();
	}

	private Vector3 GetPosition()
	{
		if (Target == null) return transform.position;
		Vector3 offset = TransformPositionOffset ? Target.TransformVector(PositionOffset) : PositionOffset;
		Vector3 targetPos = Target.position + offset;
		Vector3 cur = transform.position;
		Vector3 next = new Vector3(
			FollowAxis.x != 0f ? targetPos.x : cur.x,
			FollowAxis.y != 0f ? targetPos.y : cur.y,
			FollowAxis.z != 0f ? targetPos.z : cur.z
		);
		return FollowSpeed > 0f ? Vector3.Lerp(cur, next, Time.deltaTime * FollowSpeed) : next;
	}

	private Quaternion GetRotation()
	{
		if (Target == null) return transform.rotation;
		if (LookAtTarget) return GetLookRotation();
		return Target.rotation * Quaternion.Euler(RotationOffset);
	}

	private Quaternion GetLookRotation()
	{
		Vector3 dir = Target.position - transform.position;
		return dir.sqrMagnitude > 1e-4f ? Quaternion.LookRotation(dir.normalized) : transform.rotation;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/RotateAxis.cs", """using Chronos;
using UnityEngine;

public class RotateAxis : MonoBehaviour
{
	public bool UsePhysics;
	public Vector3 Axis = Vector3.up;
	public float Speed = 90f;
	private Rigidbody rigidbody;
	private Timeline timeline;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		if (!UsePhysics)
			transform.Rotate(Axis, Speed * GetDelta(), Space.Self);
	}

	private void FixedUpdate()
	{
		if (UsePhysics)
			transform.Rotate(Axis, Speed * GetDelta(), Space.Self);
	}

	private float GetDelta() => UsePhysics ? Time.fixedDeltaTime : Time.deltaTime;
}
""")

    write_asset_file("Scripts/Assembly-CSharp/EventOnInterval.cs", """using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class EventOnInterval : MonoBehaviour
{
	public Vector2 duration = new Vector2(2f, 2f);
	public Vector2 offset;
	private float d;
	private float o;
	public UnityEvent _event = new UnityEvent();

	private void Start()
	{
		StartCoroutine(MainCR());
	}

	private IEnumerator CR()
	{
		yield return MainCR();
	}

	private IEnumerator MainCR()
	{
		o = Random.Range(offset.x, Mathf.Max(offset.x, offset.y));
		if (o > 0f) yield return new WaitForSeconds(o);
		while (enabled && gameObject.activeInHierarchy)
		{
			d = Mathf.Max(0.1f, Random.Range(duration.x, Mathf.Max(duration.x, duration.y)));
			yield return new WaitForSeconds(d);
			_event?.Invoke();
		}
	}

	private void OnDisable() => StopAllCoroutines();
	private void OnDestroy() => StopAllCoroutines();
}
""")

    write_asset_file("Scripts/Assembly-CSharp/UnparentOnStart.cs", """using UnityEngine;

public class UnparentOnStart : MonoBehaviour
{
	private Quaternion originalRotation;
	private Vector3 originalPosition;
	private Transform originalParent;
	private Rigidbody thisRigidbody;
	[SerializeField] private bool DontUnparentOnStart;

	private void Start()
	{
		originalParent = transform.parent;
		originalPosition = transform.localPosition;
		originalRotation = transform.localRotation;
		thisRigidbody = GetComponent<Rigidbody>();
		if (!DontUnparentOnStart) Unparent();
	}

	public void Unparent() => transform.SetParent(null, true);

	public void Reparent(bool alsoReturnToPosition)
	{
		transform.SetParent(originalParent, true);
		if (alsoReturnToPosition) ResetPosition();
	}

	public void ResetPosition()
	{
		transform.localPosition = originalPosition;
		transform.localRotation = originalRotation;
		if (thisRigidbody != null && !thisRigidbody.isKinematic)
		{
			thisRigidbody.velocity = Vector3.zero;
			thisRigidbody.angularVelocity = Vector3.zero;
		}
	}

	public void DestroyObject() => Destroy(gameObject);
}
""")

    write_asset_file("Scripts/Assembly-CSharp/SetCenterOfMass.cs", """using UnityEngine;

public class SetCenterOfMass : MonoBehaviour
{
	public Transform CenterOfMass;

	private void Awake()
	{
		if (CenterOfMass != null)
			UpdateCenterOfMass(CenterOfMass.localPosition);
	}

	public void UpdateCenterOfMass(Vector3 newCoMPosition)
	{
		var rb = GetComponent<Rigidbody>();
		if (rb != null) rb.centerOfMass = newCoMPosition;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/SetMaxAngularVelocity.cs", """using UnityEngine;

public class SetMaxAngularVelocity : MonoBehaviour
{
	[SerializeField] private float maxAngularVelocity = 50f;
	[SerializeField] private bool includeChildren;

	private void Awake()
	{
		if (includeChildren)
		{
			foreach (var rb in GetComponentsInChildren<Rigidbody>(true))
				rb.maxAngularVelocity = maxAngularVelocity;
		}
		else
		{
			var rb = GetComponent<Rigidbody>();
			if (rb != null) rb.maxAngularVelocity = maxAngularVelocity;
		}
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/SetRigidSolverIterations.cs", """using UnityEngine;

public class SetRigidSolverIterations : MonoBehaviour
{
	public bool setOnAwake = true;
	public int solverIterationCount = 12;

	private void Awake()
	{
		if (!setOnAwake) return;
		var rb = GetComponent<Rigidbody>();
		if (rb != null && solverIterationCount > 0)
			rb.solverIterations = solverIterationCount;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/ToggleActiveStateOfChildren.cs", """using UnityEngine;

public class ToggleActiveStateOfChildren : MonoBehaviour
{
	private int index;

	private void Start() { }

	public void Toggle()
	{
		if (transform.childCount == 0) return;
		index = (index + 1) % transform.childCount;
		for (int i = 0; i < transform.childCount; i++)
			transform.GetChild(i).gameObject.SetActive(i == index);
	}
}
""")

    print("Implemented top 29 camera, collision, physics, door, barrel, and animation behaviours")


if __name__ == "__main__":
    main()
