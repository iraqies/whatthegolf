using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{
	public class GolfBallController : MonoBehaviour
	{
		public AimPlanes AimPlane;
		public Vector3 customAimPlane = Vector3.up;
		public bool shootStraightTutorialMode;
		public bool StandaloneUseMobileAiming = true;
		public bool useAngleLimit;
		public int angleLimit = 90;
		public bool useAimStartCamTransform;
		public Camera aimStartCamTransformState;
		public List<AudioClip> swingSFX = new List<AudioClip>();
		[SerializeField] public float Scale = 1f;
		[SerializeField] public bool useInstancedBall;
		[SerializeField] private Transform arrowPosition;
		[SerializeField] public bool ReverseArrow;
		[SerializeField] public ShootArrow shootArrowPrefab;
		[SerializeField] public bool ShadowOnArrow = true;
		[SerializeField] public bool ShowArrowOnTop;
		public float CancelThreshold = 0.03f;
		[SerializeField] public float DragScaleRatio = 1f;
		[SerializeField] public bool affectTime = true;
		[SerializeField] public bool useMinimumTime;
		[SerializeField] public float minimumTimeAffect = 0.15f;
		[SerializeField] public bool BlockShotIfPaused = true;
		[SerializeField] private float shootCoolDown = 0.15f;
		public float EventDelay;
		public UnityEvent OnShootEvent = new UnityEvent();
		public Transform testFollow;
		public int PlayerIndex;
		public int NumberOfStrokes;
		public bool ResetStrokesOnFail = true;
		public bool ShowTransitionOnOutOfBounds = true;
		public bool CountStrokes = true;
		public bool CountStrokesWhileBlocked;
		public bool DisablePullSounds;
		public float AimSpeedUp = 1f;
		public bool OnlyFullPower;
		public bool FullPowerOnAim;
		public bool OnlyAimWhenButtonPressed;
		private float aimSpeedDown;
		public float mobileDragMultiplier = 1f;
		public bool isSubAimBlockedByIsBlocking;

		private Action m_OnAimStart;
		private Action<Vector3, bool> m_OnAimUpdate;
		private Action<Vector3> m_OnPreShoot;
		private Action<Vector3> m_OnShoot;
		private Action<Vector3> m_OnShootWhileBlocked;
		private Action<GolfBallController, int> m_OnPlayerHasShot;
		private Action m_OnCancel;
		private Action m_OnReset;
		private Action<ShootArrow> m_OnShootArrowInitialized;
		private Action m_OnOutOfBoundsEvent;

		private TimeControl timeControl;
		public ShootArrow shootArrow;
		private Player player;
		private ShooterBase m_Shooter;
		public bool IsFPG;
		private float ignoreBlocking;
		private bool blockShooting;
		public List<Func<bool>> BlockingFunctions = new List<Func<bool>>();
		public bool ignoreOwnLayerForGroundDetection = true;
		public float distToGroundExtraLength = 0.25f;
		public LayerMask groundLayer = ~0;
		private float distToGround = 0.5f;
		private bool _isCanceled;
		private Vector3 _startPos;
		private Quaternion _startRot;
		private Vector3 aimVector;
		private List<Vector3> previousAimVectors = new List<Vector3>();
		private float saveAimVectorTimer;
		private int aimVectorsToSave = 4;
		private float saveAimVectorInterval = 0.02f;
		private float shootCoolTimer;
		private float startPower;
		public Camera mainCamera;
		protected bool aimingWithMouse;
		private int localShotCount;
		public float inputTarget;
		private float maxDragLength = 0.22f;
		private float controllerDeadZoneRange = 0.18f;
		private float lastAimTime;
		private Vector3 lastAim;
		private float stickActiveTime;
		private bool isDestroyed;
		private bool baseStandaloneUseMobileAimingSetting;
		private bool pauseState;
		private bool hasBeenStarted;
		public bool NormalizeShot;
		[SerializeField] private TimeControl _timeControll;
		private TimeControl cachedTimeControl;
		private int lastFrame;
		private Vector3 _lastBallPosition;
		private Vector3 _ballVelocity;

		public float ShootCoolDown
		{
			get => shootCoolDown;
			set => shootCoolDown = value;
		}

		public ShooterBase shooter
		{
			get => m_Shooter != null ? m_Shooter : (m_Shooter = GetComponent<ShooterBase>());
			set => m_Shooter = value;
		}

		public bool IsAiming { get; private set; }
		public bool IsAimingWithOutline { get; private set; }

		public bool BlockShooting
		{
			get => blockShooting || IsBlockingFromFunctions();
			set => blockShooting = value;
		}

		public Vector3 Velocity => _ballVelocity;

		public Transform ArrowPosition
		{
			get => arrowPosition != null ? arrowPosition : transform;
			set => arrowPosition = value;
		}

		public bool IsGrounded => IsGroundedWithHeight(distToGround + distToGroundExtraLength);
		public bool IsCanceled => _isCanceled;
		public Vector2 AimStartMousePosition { get; protected set; }

		public event Action OnAimStart
		{
			add => m_OnAimStart = (Action)Delegate.Combine(m_OnAimStart, value);
			remove => m_OnAimStart = (Action)Delegate.Remove(m_OnAimStart, value);
		}

		public event Action<Vector3, bool> OnAimUpdate
		{
			add => m_OnAimUpdate = (Action<Vector3, bool>)Delegate.Combine(m_OnAimUpdate, value);
			remove => m_OnAimUpdate = (Action<Vector3, bool>)Delegate.Remove(m_OnAimUpdate, value);
		}

		public event Action<Vector3> OnPreShoot
		{
			add => m_OnPreShoot = (Action<Vector3>)Delegate.Combine(m_OnPreShoot, value);
			remove => m_OnPreShoot = (Action<Vector3>)Delegate.Remove(m_OnPreShoot, value);
		}

		public event Action<Vector3> OnShoot
		{
			add => m_OnShoot = (Action<Vector3>)Delegate.Combine(m_OnShoot, value);
			remove => m_OnShoot = (Action<Vector3>)Delegate.Remove(m_OnShoot, value);
		}

		public event Action<Vector3> OnShootWhileBlocked
		{
			add => m_OnShootWhileBlocked = (Action<Vector3>)Delegate.Combine(m_OnShootWhileBlocked, value);
			remove => m_OnShootWhileBlocked = (Action<Vector3>)Delegate.Remove(m_OnShootWhileBlocked, value);
		}

		public event Action<GolfBallController, int> OnPlayerHasShot
		{
			add => m_OnPlayerHasShot = (Action<GolfBallController, int>)Delegate.Combine(m_OnPlayerHasShot, value);
			remove => m_OnPlayerHasShot = (Action<GolfBallController, int>)Delegate.Remove(m_OnPlayerHasShot, value);
		}

		public event Action OnCancel
		{
			add => m_OnCancel = (Action)Delegate.Combine(m_OnCancel, value);
			remove => m_OnCancel = (Action)Delegate.Remove(m_OnCancel, value);
		}

		public event Action OnReset
		{
			add => m_OnReset = (Action)Delegate.Combine(m_OnReset, value);
			remove => m_OnReset = (Action)Delegate.Remove(m_OnReset, value);
		}

		public event Action<ShootArrow> OnShootArrowInitialized
		{
			add => m_OnShootArrowInitialized = (Action<ShootArrow>)Delegate.Combine(m_OnShootArrowInitialized, value);
			remove => m_OnShootArrowInitialized = (Action<ShootArrow>)Delegate.Remove(m_OnShootArrowInitialized, value);
		}

		public event Action OnOutOfBoundsEvent
		{
			add => m_OnOutOfBoundsEvent = (Action)Delegate.Combine(m_OnOutOfBoundsEvent, value);
			remove => m_OnOutOfBoundsEvent = (Action)Delegate.Remove(m_OnOutOfBoundsEvent, value);
		}

		public void AddBlockingFunction(Func<bool> blockFunction)
		{
			if (blockFunction != null && !BlockingFunctions.Contains(blockFunction))
				BlockingFunctions.Add(blockFunction);
		}

		public void RemoveBlockingFunction(Func<bool> blockFunction)
		{
			BlockingFunctions.Remove(blockFunction);
		}

		public bool IsBlockingFromFunctions()
		{
			if (ignoreBlocking > 0f) return false;
			if (BlockingFunctions != null)
			{
				for (int i = 0; i < BlockingFunctions.Count; i++)
				{
					if (BlockingFunctions[i] != null && BlockingFunctions[i]())
						return true;
				}
			}
			return false;
		}

		protected Camera GetCam() => mainCamera != null ? mainCamera : (mainCamera = Camera.main);

		private void Awake()
		{
			_startPos = transform.position;
			_startRot = transform.rotation;
			_lastBallPosition = transform.position;
			if (Scale <= 0f) Scale = 1f;
			var col = GetComponent<Collider>();
			if (col != null) distToGround = col.bounds.extents.y;
			var col2d = GetComponent<Collider2D>();
			if (col2d != null) distToGround = col2d.bounds.extents.y;
			if (m_Shooter == null) m_Shooter = GetComponent<ShooterBase>();
			timeControl = _timeControll != null ? _timeControll : FindObjectOfType<TimeControl>();
		}

		protected virtual void Start()
		{
			hasBeenStarted = true;
			if (Level.HasInstance)
				Level.Instance.AddGolfballController(this);
			if (shootArrow == null)
			{
				var prefab = shootArrowPrefab != null ? shootArrowPrefab : Resources.Load<ShootArrow>("ShootArrow");
				if (prefab != null)
				{
					shootArrow = Instantiate(prefab);
					shootArrow.Initialize(this, ShowArrowOnTop);
					m_OnShootArrowInitialized?.Invoke(shootArrow);
				}
			}
			else
			{
				shootArrow.Initialize(this, ShowArrowOnTop);
			}
		}

		public void OnSpawnController(GolfBallController oldController) { }

		public void SetShootArrow(ShootArrow newArrow)
		{
			shootArrow = newArrow;
			if (shootArrow != null)
				shootArrow.Initialize(this, ShowArrowOnTop);
		}

		public void SetPlayer(int index) => PlayerIndex = index;
		public Player GetPlayer() => player;
		public void SetLocalShotCount(int shots) => localShotCount = shots;
		public int GetLocalShotCount() => localShotCount;

		public void Activate()
		{
			enabled = true;
			shooter?.OnActivate();
		}

		public void Prepare()
		{
			_startPos = transform.position;
			_startRot = transform.rotation;
		}

		public void GoalReached()
		{
			StopAiming();
			shooter?.OnGoalReached();
		}

		public void CheckpointHit(Vector3 newStartPos, Quaternion newStartRot)
		{
			_startPos = newStartPos;
			_startRot = newStartRot;
		}

		public void ForceShot() => ForceShot(aimVector.sqrMagnitude > 0.001f ? aimVector : transform.forward);

		public void ForceShot(Vector3 forcedAim)
		{
			aimVector = forcedAim;
			TryShoot();
		}

		public float ScreenDistanceToArrow(Vector3 pos) => 0f;
		public float GetShotAccuracy(Vector3 boost) => 1f;

		public bool IsGroundedWithHeight(float height)
		{
			if (GetComponent<Rigidbody2D>() != null)
			{
				var hit2d = Physics2D.Raycast(transform.position, Vector2.down, height + 0.15f, groundLayer);
				return hit2d.collider != null;
			}
			return Physics.Raycast(transform.position + Vector3.up * 0.05f, Vector3.down, height + 0.15f, groundLayer, QueryTriggerInteraction.Ignore);
		}

		public void TimedBlockShot(float duration) => shootCoolTimer = Mathf.Max(shootCoolTimer, duration);
		public void TimedStopBlocking(float duration) => ignoreBlocking = Mathf.Max(ignoreBlocking, duration);

		public void CancelShooting()
		{
			_isCanceled = true;
			StopAiming();
			m_OnCancel?.Invoke();
			shooter?.OnCancel();
		}

		public void ForceOutOfBounds(string text) => OutOfBounds(text, 0f);

		public void CountShot()
		{
			localShotCount++;
			if (CountStrokes)
			{
				NumberOfStrokes++;
				Game.strokes++;
			}
			m_OnPlayerHasShot?.Invoke(this, NumberOfStrokes);
		}

		public void ChangeShooter(ShooterBase newShooter)
		{
			m_Shooter = newShooter;
		}

		private void OnApplicationPause(bool paused)
		{
			pauseState = paused;
			if (paused && IsAiming) CancelShooting();
		}

		protected virtual void Update()
		{
			DetermineVelocity();
			if (shootCoolTimer > 0f) shootCoolTimer -= Time.unscaledDeltaTime;
			if (ignoreBlocking > 0f) ignoreBlocking -= Time.unscaledDeltaTime;

			Vector3 posToCheck = ArrowPosition != null ? ArrowPosition.position : transform.position;
			if (posToCheck.y < -40f)
			{
				CheckOutOfBounds("OutOfBoundsReload");
				return;
			}

			if (BlockShotIfPaused && timeControl != null && timeControl.IsPaused)
				return;

			bool pressedDown = GetShootButtonDown();
			bool held = GetShootButton();
			bool released = GetShootButtonUp();

			if (!IsAiming && pressedDown && shootCoolTimer <= 0f)
			{
				_isCanceled = false;
				IsAiming = true;
				IsAimingWithOutline = true;
				AimStartMousePosition = GetInputPosition();
				aimVector = Vector3.zero;
				if (affectTime && timeControl != null)
					timeControl.SetAimTimeScale(useMinimumTime, minimumTimeAffect);
				shootArrow?.StartAim();
				m_OnAimStart?.Invoke();
				shooter?.OnAimStart();
			}

			if (IsAiming && held && !_isCanceled)
			{
				Vector2 curPos = GetInputPosition();
				Vector2 deltaScreen = AimStartMousePosition - curPos;
				if (ReverseArrow) deltaScreen = -deltaScreen;
				float screenDiag = Mathf.Max(300f, Mathf.Min(Screen.width, Screen.height) * Mathf.Max(0.15f, maxDragLength));
				Vector2 norm2D = Vector2.ClampMagnitude(deltaScreen / screenDiag, 1f);

				if (AimPlane == AimPlanes.Camera || AimPlane == AimPlanes.TwoD || GetComponent<Rigidbody2D>() != null)
				{
					aimVector = new Vector3(norm2D.x, norm2D.y, 0f);
				}
				else
				{
					Camera cam = GetCam();
					if (cam != null)
					{
						Vector3 fwd = Vector3.ProjectOnPlane(cam.transform.forward, Vector3.up).normalized;
						if (fwd.sqrMagnitude < 1e-4f) fwd = Vector3.ProjectOnPlane(cam.transform.up, Vector3.up).normalized;
						Vector3 right = Vector3.ProjectOnPlane(cam.transform.right, Vector3.up).normalized;
						aimVector = Vector3.ClampMagnitude(right * norm2D.x + fwd * norm2D.y, 1f);
					}
					else
					{
						aimVector = new Vector3(norm2D.x, 0f, norm2D.y);
					}
				}

				if (OnlyFullPower || FullPowerOnAim)
				{
					if (aimVector.sqrMagnitude > 0.001f)
						aimVector = aimVector.normalized;
				}

				bool blocked = BlockShooting;
				shootArrow?.UpdateArrow(aimVector, blocked, false);
				m_OnAimUpdate?.Invoke(aimVector, blocked);
				shooter?.OnAimUpdate(aimVector, blocked);
			}

			if (IsAiming && released)
			{
				if (!_isCanceled && aimVector.magnitude >= CancelThreshold)
				{
					TryShoot();
				}
				else
				{
					CancelShooting();
				}
			}
		}

		internal virtual Vector3 GetFinalAimVector()
		{
			if (NormalizeShot && aimVector.sqrMagnitude > 0.001f)
				return aimVector.normalized;
			return Vector3.ClampMagnitude(aimVector, 1f);
		}

		private void TryShoot()
		{
			Vector3 finalAim = GetFinalAimVector();
			StopAiming();
			if (BlockShooting)
			{
				if (CountStrokesWhileBlocked) CountShot();
				m_OnShootWhileBlocked?.Invoke(finalAim);
				return;
			}
			shootCoolTimer = Mathf.Max(0.05f, shootCoolDown);
			CountShot();
			m_OnPreShoot?.Invoke(finalAim);
			m_OnShoot?.Invoke(finalAim);
			OnShootEvent?.Invoke();
		}

		private bool CheckPreviousAimVectorsForDifference() => true;

		public virtual bool GetShootButtonDown(bool onlyController = false, string shootButtonName = "Shoot")
		{
			if (!onlyController)
			{
				if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
					return true;
				if (Input.GetMouseButtonDown(0))
					return true;
			}
			return Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.JoystickButton0);
		}

		public virtual bool GetShootButton(bool onlyController = false, string shootButtonName = "Shoot")
		{
			if (!onlyController)
			{
				if (Input.touchCount > 0)
				{
					var ph = Input.GetTouch(0).phase;
					if (ph == TouchPhase.Began || ph == TouchPhase.Moved || ph == TouchPhase.Stationary)
						return true;
				}
				if (Input.GetMouseButton(0))
					return true;
			}
			return Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.JoystickButton0);
		}

		public virtual bool GetShootButtonUp(bool onlyController = false, string shootButtonName = "Shoot")
		{
			if (!onlyController)
			{
				if (Input.touchCount > 0)
				{
					var ph = Input.GetTouch(0).phase;
					if (ph == TouchPhase.Ended || ph == TouchPhase.Canceled)
						return true;
				}
				if (Input.GetMouseButtonUp(0))
					return true;
			}
			return Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.JoystickButton0);
		}

		public bool GetCancelButtonDown() => Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Escape);

		protected virtual Vector2 GetInputPosition()
		{
			if (Input.touchCount > 0)
				return Input.GetTouch(0).position;
			return Input.mousePosition;
		}

		protected virtual bool IsStartingToAim() => GetShootButtonDown();
		private bool IsShooting() => GetShootButtonUp();

		public Vector2 GetPlayerAxisDirection(bool raw = false, string horizontalName = "Aim Horizontal", string verticalName = "Aim Vertical")
		{
			return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		}

		private void DetermineVelocity()
		{
			if (Time.frameCount == lastFrame) return;
			lastFrame = Time.frameCount;
			float dt = Mathf.Max(1e-5f, Time.deltaTime);
			_ballVelocity = (transform.position - _lastBallPosition) / dt;
			_lastBallPosition = transform.position;
		}

		private Vector3 GetMousePositionOnCamPlane(Vector2 mousePosition) => GetPositionOnAimPlane(mousePosition);

		public Vector3 GetPositionOnAimPlane(Vector2 position)
		{
			Camera cam = GetCam();
			if (cam == null) return transform.position;
			Plane p = GetPlane(AimPlane, transform.position);
			Ray r = cam.ScreenPointToRay(position);
			if (p.Raycast(r, out float enter))
				return r.GetPoint(enter);
			return transform.position;
		}

		public Vector3 GetMousePositionOnAimPlane(Vector2 mousePosition) => GetPositionOnAimPlane(mousePosition);

		public Plane GetPlane(AimPlanes planeType, Vector3 position)
		{
			switch (planeType)
			{
				case AimPlanes.Camera:
					var cam = GetCam();
					return new Plane(cam != null ? -cam.transform.forward : Vector3.back, position);
				case AimPlanes.TwoD:
					return new Plane(transform.forward, position);
				case AimPlanes.CustomVector:
					return new Plane(customAimPlane.sqrMagnitude > 1e-4f ? customAimPlane.normalized : Vector3.up, position);
				default:
					return new Plane(Vector3.up, position);
			}
		}

		public Plane GetPlane(AimPlanes planeType) => GetPlane(planeType, transform.position);

		private void OnTriggerEnter(Collider other)
		{
			if (other != null) CheckOutOfBounds(other.tag);
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other != null) CheckOutOfBounds(other.tag);
		}

		public void NotifyChildTriggerEnter(Collider other)
		{
			if (other != null) CheckOutOfBounds(other.tag);
		}

		public void NotifyChildTriggerEnter2D(Collider2D other)
		{
			if (other != null) CheckOutOfBounds(other.tag);
		}

		protected virtual void CheckOutOfBounds(string tag)
		{
			if (tag == "OutOfBounds" || tag == "BoundsFail" || tag == "KillZone")
			{
				_ballVelocity = Vector3.zero;
				HideShootArrow();
				FailLevel(false);
			}
			else if (tag == "OutOfBoundsReset" || tag == "BoundsReset")
			{
				_ballVelocity = Vector3.zero;
				HideShootArrow();
				Reset(0f);
			}
			else if (tag == "OutOfBoundsReload" || tag == "BoundsReload")
			{
				_ballVelocity = Vector3.zero;
				HideShootArrow();
				FailLevel(true);
			}
			else if (tag == "BoundsTrigger" || tag == "OutOfBoundsTrigger")
			{
				_ballVelocity = Vector3.zero;
				HideShootArrow();
				m_OnOutOfBoundsEvent?.Invoke();
			}
		}

		public void RaiseOnOutOfBoundsEvent()
		{
			_ballVelocity = Vector3.zero;
			HideShootArrow();
			m_OnOutOfBoundsEvent?.Invoke();
		}

		private void FailLevel(bool doReload = true)
		{
			if (Level.HasInstance)
				Level.Instance.Fail(doReload, ShowTransitionOnOutOfBounds, this, 0f, true, "OUT OF BOUNDS");
		}

		private void HideShootArrow() => shootArrow?.Hide();

		public void OutOfBounds(string txt = "OUT OF BOUNDS", float delayedReset = 0f)
		{
			_ballVelocity = Vector3.zero;
			HideShootArrow();
			RaiseOnOutOfBoundsEvent();
			FailLevel(true);
		}

		public void Reset(float delayedReset = 0f)
		{
			if (delayedReset > 0f && gameObject.activeInHierarchy)
			{
				StartCoroutine(pTween.To(delayedReset, 0f, 1f, _ => { }).Then(ResetValues));
			}
			else
			{
				ResetValues();
			}
		}

		private void Reload(string title) { }

		public void StopAiming()
		{
			if (!IsAiming) return;
			IsAiming = false;
			IsAimingWithOutline = false;
			if (affectTime && timeControl != null)
				timeControl.ResetTimeScale();
			HideShootArrow();
		}

		private void OnComplete(Level.CompletedState state)
		{
			if (isDestroyed) return;
			StopAiming();
			enabled = false;
		}

		private void ResetValues()
		{
			IsAiming = false;
			IsAimingWithOutline = false;
			transform.position = _startPos;
			transform.rotation = _startRot;
			var rb = GetComponent<Rigidbody>();
			if (rb != null && !rb.isKinematic)
			{
				rb.velocity = Vector3.zero;
				rb.angularVelocity = Vector3.zero;
			}
			var rb2d = GetComponent<Rigidbody2D>();
			if (rb2d != null)
			{
				rb2d.velocity = Vector2.zero;
				rb2d.angularVelocity = 0f;
			}
			if (affectTime && timeControl != null)
				timeControl.ResetTimeScale();
			HideShootArrow();
			shooter?.OnReset();
			m_OnReset?.Invoke();
		}
		private void OnEnable() { }
		private void OnDisable() => StopAiming();

		private void OnDestroy()
		{
			isDestroyed = true;
			if (Level.HasInstance)
				Level.Instance.RemoveGolfballController(this);
			if (shootArrow != null)
				Destroy(shootArrow.gameObject);
		}
	}

	public class ChildOutOfBoundsForwarder : MonoBehaviour
	{
		public GolfBallController controller;

		private void OnTriggerEnter(Collider other)
		{
			if (controller != null && other != null)
				controller.NotifyChildTriggerEnter(other);
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (controller != null && other != null)
				controller.NotifyChildTriggerEnter2D(other);
		}
	}
}
