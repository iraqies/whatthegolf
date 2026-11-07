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

		public Vector3 customAimPlane;

		public bool shootStraightTutorialMode;

		public bool StandaloneUseMobileAiming;

		public bool useAngleLimit;

		public int angleLimit;

		public bool useAimStartCamTransform;

		public Camera aimStartCamTransformState;

		public List<AudioClip> swingSFX;

		[SerializeField]
		public float Scale;

		[SerializeField]
		public bool useInstancedBall;

		[SerializeField]
		private Transform arrowPosition;

		[SerializeField]
		public bool ReverseArrow;

		[SerializeField]
		public ShootArrow shootArrowPrefab;

		[SerializeField]
		public bool ShadowOnArrow;

		[SerializeField]
		public bool ShowArrowOnTop;

		public float CancelThreshold;

		[SerializeField]
		public float DragScaleRatio;

		[SerializeField]
		public bool affectTime;

		[SerializeField]
		public bool useMinimumTime;

		[SerializeField]
		public float minimumTimeAffect;

		[SerializeField]
		public bool BlockShotIfPaused;

		[SerializeField]
		private float shootCoolDown;

		public float EventDelay;

		public UnityEvent OnShootEvent;

		public Transform testFollow;

		public int PlayerIndex;

		public int NumberOfStrokes;

		public bool ResetStrokesOnFail;

		public bool ShowTransitionOnOutOfBounds;

		public bool CountStrokes;

		public bool CountStrokesWhileBlocked;

		public bool DisablePullSounds;

		public float AimSpeedUp;

		public bool OnlyFullPower;

		public bool FullPowerOnAim;

		public bool OnlyAimWhenButtonPressed;

		private float aimSpeedDown;

		public float mobileDragMultiplier;

		public bool isSubAimBlockedByIsBlocking;

		[CompilerGenerated]
		private Action m_OnAimStart;

		[CompilerGenerated]
		private Action<Vector3, bool> m_OnAimUpdate;

		[CompilerGenerated]
		private Action<Vector3> m_OnPreShoot;

		[CompilerGenerated]
		private Action<Vector3> m_OnShoot;

		[CompilerGenerated]
		private Action<Vector3> m_OnShootWhileBlocked;

		[CompilerGenerated]
		private Action<GolfBallController, int> m_OnPlayerHasShot;

		[CompilerGenerated]
		private Action m_OnCancel;

		[CompilerGenerated]
		private Action m_OnReset;

		[CompilerGenerated]
		private Action<ShootArrow> m_OnShootArrowInitialized;

		[CompilerGenerated]
		private Action m_OnOutOfBoundsEvent;

		private TimeControl timeControl;

		public ShootArrow shootArrow;

		private Player player;

		private ShooterBase m_Shooter;

		public bool IsFPG;

		private float ignoreBlocking;

		private bool blockShooting;

		public List<Func<bool>> BlockingFunctions;

		public bool ignoreOwnLayerForGroundDetection;

		public float distToGroundExtraLength;

		public LayerMask groundLayer;

		private float distToGround;

		private bool _isCanceled;

		private Vector3 _startPos;

		private Quaternion _startRot;

		private Vector3 aimVector;

		private List<Vector3> previousAimVectors;

		private float saveAimVectorTimer;

		private int aimVectorsToSave;

		private float saveAimVectorInterval;

		private float shootCoolTimer;

		private float startPower;

		public Camera mainCamera;

		protected bool aimingWithMouse;

		private int localShotCount;

		public float inputTarget;

		private float maxDragLength;

		private float controllerDeadZoneRange;

		private float lastAimTime;

		private Vector3 lastAim;

		private float stickActiveTime;

		private bool isDestroyed;

		private bool baseStandaloneUseMobileAimingSetting;

		private bool pauseState;

		private bool hasBeenStarted;

		public bool NormalizeShot;

		[SerializeField]
		private TimeControl _timeControll;

		private TimeControl cachedTimeControl;

		private int lastFrame;

		private Vector3 _lastBallPosition;

		private Vector3 _ballVelocity;

		public float ShootCoolDown
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ShooterBase shooter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsAiming { get; private set; }

		public bool IsAimingWithOutline { get; private set; }

		public bool BlockShooting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector3 Velocity => default;

		public Transform ArrowPosition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsGrounded => false;

		public bool IsCanceled => false;

		public Vector2 AimStartMousePosition { get; protected set; }

		public event Action OnAimStart
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

		public event Action<Vector3, bool> OnAimUpdate
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

		public event Action<Vector3> OnPreShoot
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

		public event Action<Vector3> OnShoot
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

		public event Action<Vector3> OnShootWhileBlocked
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

		public event Action<GolfBallController, int> OnPlayerHasShot
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

		public event Action OnCancel
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

		public event Action OnReset
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

		public event Action<ShootArrow> OnShootArrowInitialized
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

		public event Action OnOutOfBoundsEvent
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

		public void AddBlockingFunction(Func<bool> blockFunction)
		{
		}

		public void RemoveBlockingFunction(Func<bool> blockFunction)
		{
		}

		public bool IsBlockingFromFunctions()
		{
			return false;
		}

		protected Camera GetCam()
		{
			return null;
		}

		private void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public void OnSpawnController(GolfBallController oldController)
		{
		}

		public void SetShootArrow(ShootArrow newArrow)
		{
		}

		public void SetPlayer(int index)
		{
		}

		public Player GetPlayer()
		{
			return null;
		}

		public void SetLocalShotCount(int shots)
		{
		}

		public int GetLocalShotCount()
		{
			return 0;
		}

		public void Activate()
		{
		}

		public void Prepare()
		{
		}

		public void GoalReached()
		{
		}

		public void CheckpointHit(Vector3 newStartPos, Quaternion newStartRot)
		{
		}

		public void ForceShot()
		{
		}

		public void ForceShot(Vector3 aimVector)
		{
		}

		public float ScreenDistanceToArrow(Vector3 pos)
		{
			return 0f;
		}

		public float GetShotAccuracy(Vector3 boost)
		{
			return 0f;
		}

		public bool IsGroundedWithHeight(float height)
		{
			return false;
		}

		public void TimedBlockShot(float duration)
		{
		}

		public void TimedStopBlocking(float duration)
		{
		}

		public void CancelShooting()
		{
		}

		public void ForceOutOfBounds(string text)
		{
		}

		public void CountShot()
		{
		}

		public void ChangeShooter(ShooterBase newShooter)
		{
		}

		private void OnApplicationPause(bool pauseState)
		{
		}

		protected virtual void Update()
		{
		}

		internal virtual Vector3 GetFinalAimVector()
		{
			return default;
		}

		private void TryShoot()
		{
		}

		private bool CheckPreviousAimVectorsForDifference()
		{
			return false;
		}

		public virtual bool GetShootButtonDown(bool onlyController = false, string shootButtonName = "Shoot")
		{
			return false;
		}

		public virtual bool GetShootButton(bool onlyController = false, string shootButtonName = "Shoot")
		{
			return false;
		}

		public virtual bool GetShootButtonUp(bool onlyController = false, string shootButtonName = "Shoot")
		{
			return false;
		}

		public bool GetCancelButtonDown()
		{
			return false;
		}

		protected virtual Vector2 GetInputPosition()
		{
			return default;
		}

		protected virtual bool IsStartingToAim()
		{
			return false;
		}

		private bool IsShooting()
		{
			return false;
		}

		public Vector2 GetPlayerAxisDirection(bool raw = false, string horizontalName = "Aim Horizontal", string verticalName = "Aim Vertical")
		{
			return default;
		}

		private void DetermineVelocity()
		{
		}

		private Vector3 GetMousePositionOnCamPlane(Vector2 mousePosition)
		{
			return default;
		}

		public Vector3 GetPositionOnAimPlane(Vector2 position)
		{
			return default;
		}

		public Vector3 GetMousePositionOnAimPlane(Vector2 mousePosition)
		{
			return default;
		}

		public Plane GetPlane(AimPlanes planeType, Vector3 position)
		{
			return default;
		}

		public Plane GetPlane(AimPlanes planeType)
		{
			return default;
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		protected virtual void CheckOutOfBounds(string tag)
		{
		}

		public void RaiseOnOutOfBoundsEvent()
		{
		}

		private void FailLevel(bool doReload = true)
		{
		}

		private void HideShootArrow()
		{
		}

		public void OutOfBounds(string txt = "OUT OF BOUNDS", float delayedReset = 0f)
		{
		}

		public void Reset(float delayedReset = 0f)
		{
		}

		private void Reload(string title)
		{
		}

		public void StopAiming()
		{
		}

		private void OnComplete(Level.CompletedState state)
		{
		}

		private void ResetValues()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
