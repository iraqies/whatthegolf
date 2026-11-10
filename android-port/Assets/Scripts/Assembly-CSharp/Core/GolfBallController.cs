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
		private float _autoOobMinY = float.NegativeInfinity;
		private string _autoOobTag = "OutOfBounds";
		private bool _hasAutoOobY;
		private bool _isOutOfBounds;

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
		public bool isAiming => IsAiming;
		public bool isRolling
		{
			get => Velocity.sqrMagnitude > 0.01f;
			set { }
		}
		public int PlayerID => PlayerIndex;
		public float MaxAimDistance
		{
			get => Scale;
			set => Scale = value;
		}
		public bool UseRigidbodyTimeline { get; set; }
		public bool AffectTime
		{
			get => affectTime;
			set => affectTime = value;
		}
		public bool AffectsTimeScale
		{
			get => affectTime;
			set => affectTime = value;
		}
		public bool IsChangingTime => IsAiming && affectTime;
		public bool doReloadSceneWhenOutOfBounds = true;
		public bool GetIsCharging(int playerIdx = 0) => GetShootButton(false);
		public bool IsAimingWithOutline { get; private set; }

		public bool BlockShooting
		{
			get => blockShooting || IsBlockingFromFunctions();
			set => blockShooting = value;
		}

		public bool isBlocking
		{
			get => BlockShooting;
			set => BlockShooting = value;
		}

		public bool canShoot
		{
			get => !BlockShooting;
			set => BlockShooting = !value;
		}

		public bool didShoot { get; set; }

		public AimPlanes planeType
		{
			get => AimPlane;
			set => AimPlane = value;
		}

		public bool countStrokes
		{
			get => CountStrokes;
			set => CountStrokes = value;
		}

		public int playerIndex
		{
			get => PlayerIndex;
			set => PlayerIndex = value;
		}

		public int playerID => PlayerID;

		public bool IsCharging => GetShootButton(false);

		public bool noCharging
		{
			get => FullPowerOnAim;
			set => FullPowerOnAim = value;
		}

		public float resetCountdown
		{
			get => shootCoolDown;
			set => shootCoolDown = value;
		}

		public Player playerInput => player;

		public Vector3 GetAimInputDirection => aimVector;

		public bool FlipAim
		{
			get => ReverseArrow;
			set => ReverseArrow = value;
		}

		public bool GetPlayerButton(bool onlyController = false, string shootButtonName = "Shoot") => GetShootButton(onlyController, shootButtonName);

		public bool GetPlayerButton(int playerIdx, string shootButtonName = "Shoot") => GetShootButton(false, shootButtonName);

		public bool GetPlayerButtonDown(bool onlyController = false, string shootButtonName = "Shoot") => GetShootButtonDown(onlyController, shootButtonName);

		public bool GetPlayerButtonDown(int playerIdx, string shootButtonName = "Shoot") => GetShootButtonDown(false, shootButtonName);

		public bool GetPlayerButtonUp(bool onlyController = false, string shootButtonName = "Shoot") => GetShootButtonUp(onlyController, shootButtonName);

		public bool GetPlayerButtonUp(int playerIdx, string shootButtonName = "Shoot") => GetShootButtonUp(false, shootButtonName);

		public Vector2 GetPlayerAxisDirection(int playerIdx, string horizontalName = "Aim Horizontal", string verticalName = "Aim Vertical") => GetPlayerAxisDirection(false, horizontalName, verticalName);

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

		protected Camera GetCam()
		{
			if (mainCamera != null)
				return mainCamera;
			if (CameraStack.CameraManager.Instance != null && CameraStack.CameraManager.Instance.MainCamera != null)
				return mainCamera = CameraStack.CameraManager.Instance.MainCamera;
			if (CameraStack.OverworldCamera.Instance != null && CameraStack.OverworldCamera.Instance.MainCamera != null)
				return mainCamera = CameraStack.OverworldCamera.Instance.MainCamera;
			return mainCamera = Camera.main;
		}

		private void Awake()
		{
			_startPos = transform.position;
			_startRot = transform.rotation;
			_lastBallPosition = transform.position;
			if (Scale <= 0f) Scale = 1f;
			var col = GetComponent<Collider>() ?? GetComponentInChildren<Collider>();
			if (col != null) distToGround = col.bounds.extents.y;
			if (distToGround <= 0f)
			{
				var rend = GetComponent<Renderer>() ?? GetComponentInChildren<Renderer>();
				if (rend != null) distToGround = rend.bounds.extents.y;
			}
			var col2d = GetComponent<Collider2D>() ?? GetComponentInChildren<Collider2D>();
			if (col2d != null && col2d.bounds.extents.y > 0f) distToGround = col2d.bounds.extents.y;
			if (distToGround <= 0f) distToGround = 1f;
			if (m_Shooter == null) m_Shooter = GetComponent<ShooterBase>();
			timeControl = _timeControll != null ? _timeControll : FindObjectOfType<TimeControl>();
		}

		protected virtual void Start()
		{
			hasBeenStarted = true;
			if (Level.HasInstance)
				Level.Instance.AddGolfballController(this);
			if (GetComponent<Rigidbody2D>() == null && GetComponent<Rigidbody>() != null && FindObjectOfType<TunnelToOverworld>() == null)
			{
				float lowestTriggerTop = float.PositiveInfinity;
				string foundTag = "OutOfBounds";
				bool foundAny = false;
				foreach (var col in FindObjectsOfType<Collider>())
				{
					if (col == null || !col.enabled) continue;
					string t = col.tag;
					if (t == "OutOfBounds" || t == "BoundsFail" || t == "KillZone" || t == "OutOfBoundsReset" || t == "BoundsReset" || t == "OutOfBoundsReload" || t == "BoundsReload")
					{
						if (col.bounds.size.x >= 200f && col.bounds.size.z >= 200f && col.bounds.max.y < _startPos.y - 1f)
						{
							if (col.bounds.max.y < lowestTriggerTop)
							{
								lowestTriggerTop = col.bounds.max.y;
								foundTag = t;
								foundAny = true;
							}
						}
					}
				}
				if (foundAny)
				{
					_autoOobMinY = lowestTriggerTop;
					_autoOobTag = foundTag;
					_hasAutoOobY = true;
				}
			}
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
			_isOutOfBounds = false;
			enabled = true;
			shooter?.OnActivate();
		}

		public void Prepare()
		{
			_isOutOfBounds = false;
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
			int mask = (ignoreOwnLayerForGroundDetection && groundLayer.value != 0) ? groundLayer.value : ~0;
			if (GetComponent<Rigidbody2D>() != null)
			{
				var hit2d = Physics2D.Raycast(transform.position, Vector2.down, height + 0.5f, mask);
				return hit2d.collider != null;
			}
			Vector3 downDir = -GetPlane(AimPlane).normal;
			if (downDir.sqrMagnitude < 1e-4f) downDir = Vector3.down;
			return Physics.Raycast(transform.position + (-downDir * 0.05f), downDir, height + 0.5f, mask, QueryTriggerInteraction.Ignore);
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

		public void DisableAutoOutOfBounds()
		{
			_hasAutoOobY = false;
			_isOutOfBounds = true;
		}

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
			if (_hasAutoOobY && transform.position.y < _autoOobMinY && Level.HasInstance)
			{
				CheckOutOfBounds(_autoOobTag);
				return;
			}
			if (shootCoolTimer > 0f) shootCoolTimer -= Time.unscaledDeltaTime;
			if (ignoreBlocking > 0f) ignoreBlocking -= Time.unscaledDeltaTime;

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
				float screenDiag = Mathf.Max(140f, Mathf.Min(Screen.width, Screen.height) * Mathf.Max(0.18f, maxDragLength));
				float dragMag = Mathf.Clamp01(deltaScreen.magnitude / screenDiag) * Mathf.Max(0.1f, DragScaleRatio);
				Vector2 norm2D = deltaScreen.sqrMagnitude > 1e-4f ? (deltaScreen.normalized * dragMag) : Vector2.zero;

				if (AimPlane == AimPlanes.Camera || AimPlane == AimPlanes.TwoD || GetComponent<Rigidbody2D>() != null)
				{
					Camera cam = GetCam();
					if (cam != null)
					{
						Vector3 right = cam.transform.right;
						right.z = 0f;
						if (right.sqrMagnitude > 1e-4f) right.Normalize();
						else right = Vector3.right;
						Vector3 up = cam.transform.up;
						up.z = 0f;
						if (up.sqrMagnitude > 1e-4f) up.Normalize();
						else up = Vector3.up;
						aimVector = Vector3.ClampMagnitude(right * norm2D.x + up * norm2D.y, 1f);
					}
					else
					{
						aimVector = new Vector3(norm2D.x, norm2D.y, 0f);
					}
				}
				else
				{
					Vector3 planeDiff = GetMousePositionOnAimPlane(AimStartMousePosition) - GetMousePositionOnAimPlane(curPos);
					if (ReverseArrow) planeDiff = -planeDiff;
					if (planeDiff.sqrMagnitude > 1e-5f)
					{
						aimVector = Vector3.ClampMagnitude(planeDiff.normalized * dragMag, 1f);
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
				}

				if (shootStraightTutorialMode)
				{
					aimVector = Vector3.Project(aimVector, Vector3.forward);
					if (Vector3.Dot(aimVector, Vector3.forward) < 0f)
						aimVector = Vector3.zero;
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
			if (OnlyFullPower && aimVector.sqrMagnitude > 0.001f)
				return aimVector.normalized;
			if (NormalizeShot && aimVector.magnitude > 1f)
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
			if (!OnlyFullPower && finalAim.sqrMagnitude > 1e-6f)
			{
				float mag = finalAim.magnitude;
				float thresh = Mathf.Clamp(CancelThreshold, 0f, 0.5f);
				float remapped = Mathf.Clamp01((mag - thresh) / Mathf.Max(0.01f, 1f - thresh));
				finalAim = finalAim.normalized * remapped;
			}
			m_OnPreShoot?.Invoke(finalAim);
			shootCoolTimer = Mathf.Max(0.05f, shootCoolDown);
			shooter?.OnShoot(finalAim);
			m_OnShoot?.Invoke(finalAim);
			OnShootEvent?.Invoke();
			CountShot();
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

		public Vector3 GetMousePositionOnAimPlane(Vector2 mousePosition)
		{
			Vector3 ballPos = ArrowPosition != null ? ArrowPosition.position : transform.position;
			Camera cam = (useAimStartCamTransform && aimStartCamTransformState != null) ? aimStartCamTransformState : GetCam();
			if (cam == null) return ballPos;
			Vector3 ballScreen = cam.WorldToScreenPoint(ballPos);
			Vector3 offsetScreen = new Vector3((mousePosition.x - AimStartMousePosition.x) + ballScreen.x, (mousePosition.y - AimStartMousePosition.y) + ballScreen.y, 0f);
			Plane p = GetPlane(AimPlane, ballPos);
			Ray r = cam.ScreenPointToRay(offsetScreen);
			if (p.Raycast(r, out float enter))
				return r.GetPoint(enter);
			return ballPos;
		}

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

		private void OnTriggerStay(Collider other)
		{
			if (other != null) CheckOutOfBounds(other.tag);
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision != null && collision.collider != null) CheckOutOfBounds(collision.collider.tag);
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other != null) CheckOutOfBounds(other.tag);
		}

		private void OnTriggerStay2D(Collider2D other)
		{
			if (other != null) CheckOutOfBounds(other.tag);
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision != null && collision.collider != null) CheckOutOfBounds(collision.collider.tag);
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
			if (_isOutOfBounds)
				return;
			if (Level.HasInstance && Level.Instance != null && !Level.Instance.IsPlaying)
				return;
			if (tag == "OutOfBounds" || tag == "BoundsFail" || tag == "KillZone")
			{
				_isOutOfBounds = true;
				RaiseOnOutOfBoundsEvent();
				FailLevel(false);
			}
			else if (tag == "OutOfBoundsReset" || tag == "BoundsReset")
			{
				_isOutOfBounds = true;
				RaiseOnOutOfBoundsEvent();
				Reset(0f);
			}
			else if (tag == "OutOfBoundsReload" || tag == "BoundsReload")
			{
				_isOutOfBounds = true;
				RaiseOnOutOfBoundsEvent();
				FailLevel(true);
			}
			else if (tag == "BoundsTrigger" || tag == "OutOfBoundsTrigger")
			{
				_isOutOfBounds = true;
				RaiseOnOutOfBoundsEvent();
			}
		}

		public void RaiseOnOutOfBoundsEvent()
		{
			_ballVelocity = Vector3.zero;
			HideShootArrow();
			AkSoundEngine.PostTrigger(AK.TRIGGERS.OFF_THE_MAP_SHORT, gameObject);
			m_OnOutOfBoundsEvent?.Invoke();
		}

		private void FailLevel(bool doReload = true)
		{
			if (Level.HasInstance)
				Level.Instance.Fail(doReload, ShowTransitionOnOutOfBounds, this, 0f, false, "OUT OF BOUNDS");
		}

		private void HideShootArrow() => shootArrow?.Hide();

		public void OutOfBounds(string txt = "OUT OF BOUNDS", float delayedReset = 0f)
		{
			if (_isOutOfBounds)
				return;
			if (Level.HasInstance && Level.Instance != null && !Level.Instance.IsPlaying)
				return;
			_isOutOfBounds = true;
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
			_isOutOfBounds = false;
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

		public event Action<Vector3> OnBallShot
		{
			add => OnShoot += value;
			remove => OnShoot -= value;
		}

		public event Action<Vector3, bool> OnBallAiming
		{
			add => OnAimUpdate += value;
			remove => OnAimUpdate -= value;
		}

		public void DisableShooting()
		{
			blockShooting = true;
			StopAiming();
		}

		public void EnableShooting()
		{
			blockShooting = false;
		}

		public void BlockShootingForSeconds(float seconds)
		{
			shootCoolTimer = Mathf.Max(shootCoolTimer, seconds);
		}

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
