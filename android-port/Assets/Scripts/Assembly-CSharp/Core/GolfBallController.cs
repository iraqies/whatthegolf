using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{
	[Token(Token = "0x200142A")]
	public class GolfBallController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200142B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4905C", Offset = "0x4905C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4006D49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006D4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> _003C_003E9__143_0;

			[Token(Token = "0x4006D4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<GameObject, bool> _003C_003E9__143_1;

			[Token(Token = "0x4006D4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<GameObject, bool> _003C_003E9__145_0;

			[Token(Token = "0x4006D4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Action<float> _003C_003E9__169_0;

			[Token(Token = "0x4006D4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Action<float> _003C_003E9__194_0;

			[Token(Token = "0x6005E2E")]
			[Address(RVA = "0x17B4DD8", Offset = "0x17B4DD8", VA = "0x17B4DD8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005E2F")]
			[Address(RVA = "0x17B4DE0", Offset = "0x17B4DE0", VA = "0x17B4DE0")]
			internal bool _003CStart_003Eb__143_0(GameObject e)
			{
				return default;
			}

			[Token(Token = "0x6005E30")]
			[Address(RVA = "0x17B4E40", Offset = "0x17B4E40", VA = "0x17B4E40")]
			internal bool _003CStart_003Eb__143_1(GameObject e)
			{
				return default;
			}

			[Token(Token = "0x6005E31")]
			[Address(RVA = "0x17B4F60", Offset = "0x17B4F60", VA = "0x17B4F60")]
			internal bool _003CSetShootArrow_003Eb__145_0(GameObject e)
			{
				return default;
			}

			[Token(Token = "0x6005E32")]
			[Address(RVA = "0x17B4FC8", Offset = "0x17B4FC8", VA = "0x17B4FC8")]
			internal void _003CTryShoot_003Eb__169_0(float l)
			{
			}

			[Token(Token = "0x6005E33")]
			[Address(RVA = "0x17B4FCC", Offset = "0x17B4FCC", VA = "0x17B4FCC")]
			internal void _003CReset_003Eb__194_0(float t)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200142C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4906C", Offset = "0x4906C")]
		private struct _003CSetShootArrow_003Ed__145 : IAsyncStateMachine
		{
			[Token(Token = "0x4006D4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006D50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4006D51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GolfBallController _003C_003E4__this;

			[Token(Token = "0x4006D52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ShootArrow newArrow;

			[Token(Token = "0x6005E34")]
			[Address(RVA = "0x17B4FD0", Offset = "0x17B4FD0", VA = "0x17B4FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6005E35")]
			[Address(RVA = "0x17B54CC", Offset = "0x17B54CC", VA = "0x17B54CC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4006CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimPlanes AimPlane;

		[Token(Token = "0x4006CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 customAimPlane;

		[Token(Token = "0x4006CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool shootStraightTutorialMode;

		[Token(Token = "0x4006CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool StandaloneUseMobileAiming;

		[Token(Token = "0x4006CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool useAngleLimit;

		[Token(Token = "0x4006CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int angleLimit;

		[Token(Token = "0x4006CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useAimStartCamTransform;

		[Token(Token = "0x4006CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Camera aimStartCamTransformState;

		[Token(Token = "0x4006CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<AudioClip> swingSFX;

		[Token(Token = "0x4006CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public float Scale;

		[Token(Token = "0x4006CF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public bool useInstancedBall;

		[Token(Token = "0x4006CF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform arrowPosition;

		[Token(Token = "0x4006CF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public bool ReverseArrow;

		[Token(Token = "0x4006CF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public ShootArrow shootArrowPrefab;

		[Token(Token = "0x4006CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public bool ShadowOnArrow;

		[Token(Token = "0x4006CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		[SerializeField]
		public bool ShowArrowOnTop;

		[Token(Token = "0x4006CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float CancelThreshold;

		[Token(Token = "0x4006CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public float DragScaleRatio;

		[Token(Token = "0x4006CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		public bool affectTime;

		[Token(Token = "0x4006CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		[SerializeField]
		public bool useMinimumTime;

		[Token(Token = "0x4006CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float minimumTimeAffect;

		[Token(Token = "0x4006D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		public bool BlockShotIfPaused;

		[Token(Token = "0x4006D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float shootCoolDown;

		[Token(Token = "0x4006D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float EventDelay;

		[Token(Token = "0x4006D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent OnShootEvent;

		[Token(Token = "0x4006D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform testFollow;

		[Token(Token = "0x4006D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int PlayerIndex;

		[Token(Token = "0x4006D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int NumberOfStrokes;

		[Token(Token = "0x4006D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool ResetStrokesOnFail;

		[Token(Token = "0x4006D08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool ShowTransitionOnOutOfBounds;

		[Token(Token = "0x4006D09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool CountStrokes;

		[Token(Token = "0x4006D0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool CountStrokesWhileBlocked;

		[Token(Token = "0x4006D0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool DisablePullSounds;

		[Token(Token = "0x4006D0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float AimSpeedUp;

		[Token(Token = "0x4006D0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool OnlyFullPower;

		[Token(Token = "0x4006D0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool FullPowerOnAim;

		[Token(Token = "0x4006D0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAE")]
		public bool OnlyAimWhenButtonPressed;

		[Token(Token = "0x4006D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float aimSpeedDown;

		[Token(Token = "0x4006D11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float mobileDragMultiplier;

		[Token(Token = "0x4006D12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool isSubAimBlockedByIsBlocking;

		[Token(Token = "0x4006D13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B88C", Offset = "0x5B88C")]
		private Action m_OnAimStart;

		[Token(Token = "0x4006D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B89C", Offset = "0x5B89C")]
		private Action<Vector3, bool> m_OnAimUpdate;

		[Token(Token = "0x4006D15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8AC", Offset = "0x5B8AC")]
		private Action<Vector3> m_OnPreShoot;

		[Token(Token = "0x4006D16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8BC", Offset = "0x5B8BC")]
		private Action<Vector3> m_OnShoot;

		[Token(Token = "0x4006D17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8CC", Offset = "0x5B8CC")]
		private Action<Vector3> m_OnShootWhileBlocked;

		[Token(Token = "0x4006D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8DC", Offset = "0x5B8DC")]
		private Action<GolfBallController, int> m_OnPlayerHasShot;

		[Token(Token = "0x4006D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8EC", Offset = "0x5B8EC")]
		private Action m_OnCancel;

		[Token(Token = "0x4006D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B8FC", Offset = "0x5B8FC")]
		private Action m_OnReset;

		[Token(Token = "0x4006D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B90C", Offset = "0x5B90C")]
		private Action<ShootArrow> m_OnShootArrowInitialized;

		[Token(Token = "0x4006D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B91C", Offset = "0x5B91C")]
		private Action m_OnOutOfBoundsEvent;

		[Token(Token = "0x4006D1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private TimeControl timeControl;

		[Token(Token = "0x4006D1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ShootArrow shootArrow;

		[Token(Token = "0x4006D1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Player player;

		[Token(Token = "0x4006D20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ShooterBase m_Shooter;

		[Token(Token = "0x4006D21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B92C", Offset = "0x5B92C")]
		private bool IsAiming__BackingField;

		[Token(Token = "0x4006D22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B93C", Offset = "0x5B93C")]
		private bool IsAimingWithOutline__BackingField;

		[Token(Token = "0x4006D23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		public bool IsFPG;

		[Token(Token = "0x4006D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float ignoreBlocking;

		[Token(Token = "0x4006D25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private bool blockShooting;

		[Token(Token = "0x4006D26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public List<Func<bool>> BlockingFunctions;

		[Token(Token = "0x4006D27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool ignoreOwnLayerForGroundDetection;

		[Token(Token = "0x4006D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public float distToGroundExtraLength;

		[Token(Token = "0x4006D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public LayerMask groundLayer;

		[Token(Token = "0x4006D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private float distToGround;

		[Token(Token = "0x4006D2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _isCanceled;

		[Token(Token = "0x4006D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private Vector3 _startPos;

		[Token(Token = "0x4006D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Quaternion _startRot;

		[Token(Token = "0x4006D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B94C", Offset = "0x5B94C")]
		private Vector2 AimStartMousePosition__BackingField;

		[Token(Token = "0x4006D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 aimVector;

		[Token(Token = "0x4006D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private List<Vector3> previousAimVectors;

		[Token(Token = "0x4006D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float saveAimVectorTimer;

		[Token(Token = "0x4006D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private int aimVectorsToSave;

		[Token(Token = "0x4006D33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float saveAimVectorInterval;

		[Token(Token = "0x4006D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private float shootCoolTimer;

		[Token(Token = "0x4006D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private float startPower;

		[Token(Token = "0x4006D36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public Camera mainCamera;

		[Token(Token = "0x4006D37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected bool aimingWithMouse;

		[Token(Token = "0x4006D38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int localShotCount;

		[Token(Token = "0x4006D39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public float inputTarget;

		[Token(Token = "0x4006D3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float maxDragLength;

		[Token(Token = "0x4006D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private float controllerDeadZoneRange;

		[Token(Token = "0x4006D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float lastAimTime;

		[Token(Token = "0x4006D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 lastAim;

		[Token(Token = "0x4006D3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float stickActiveTime;

		[Token(Token = "0x4006D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool isDestroyed;

		[Token(Token = "0x4006D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool baseStandaloneUseMobileAimingSetting;

		[Token(Token = "0x4006D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		private bool pauseState;

		[Token(Token = "0x4006D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		private bool hasBeenStarted;

		[Token(Token = "0x4006D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool NormalizeShot;

		[Token(Token = "0x4006D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private TimeControl _timeControll;

		[Token(Token = "0x4006D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private TimeControl cachedTimeControl;

		[Token(Token = "0x4006D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private int lastFrame;

		[Token(Token = "0x4006D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		private Vector3 _lastBallPosition;

		[Token(Token = "0x4006D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Vector3 _ballVelocity;

		[Token(Token = "0x17000AA3")]
		public float ShootCoolDown
		{
			[Token(Token = "0x6005DC8")]
			[Address(RVA = "0x14912B4", Offset = "0x14912B4", VA = "0x14912B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005DC9")]
			[Address(RVA = "0x14912BC", Offset = "0x14912BC", VA = "0x14912BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA4")]
		public ShooterBase shooter
		{
			[Token(Token = "0x6005DDE")]
			[Address(RVA = "0x1491F94", Offset = "0x1491F94", VA = "0x1491F94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005DDF")]
			[Address(RVA = "0x1492040", Offset = "0x1492040", VA = "0x1492040")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA5")]
		public bool IsAiming
		{
			[Token(Token = "0x6005DE0")]
			[Address(RVA = "0x1492048", Offset = "0x1492048", VA = "0x1492048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72B04", Offset = "0x72B04")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005DE1")]
			[Address(RVA = "0x1492050", Offset = "0x1492050", VA = "0x1492050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72B14", Offset = "0x72B14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AA6")]
		public bool IsAimingWithOutline
		{
			[Token(Token = "0x6005DE2")]
			[Address(RVA = "0x1492058", Offset = "0x1492058", VA = "0x1492058")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72B24", Offset = "0x72B24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005DE3")]
			[Address(RVA = "0x1492060", Offset = "0x1492060", VA = "0x1492060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72B34", Offset = "0x72B34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AA7")]
		public bool BlockShooting
		{
			[Token(Token = "0x6005DE4")]
			[Address(RVA = "0x1492068", Offset = "0x1492068", VA = "0x1492068")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005DE5")]
			[Address(RVA = "0x1492268", Offset = "0x1492268", VA = "0x1492268")]
			set
			{
			}
		}

		[Token(Token = "0x17000AA8")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6005DE9")]
			[Address(RVA = "0x14923CC", Offset = "0x14923CC", VA = "0x14923CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AA9")]
		public Transform ArrowPosition
		{
			[Token(Token = "0x6005DEA")]
			[Address(RVA = "0x14923DC", Offset = "0x14923DC", VA = "0x14923DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005DEB")]
			[Address(RVA = "0x148CE24", Offset = "0x148CE24", VA = "0x148CE24")]
			set
			{
			}
		}

		[Token(Token = "0x17000AAA")]
		public bool IsGrounded
		{
			[Token(Token = "0x6005DEC")]
			[Address(RVA = "0x14852A0", Offset = "0x14852A0", VA = "0x14852A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AAB")]
		public bool IsCanceled
		{
			[Token(Token = "0x6005DED")]
			[Address(RVA = "0x14923E4", Offset = "0x14923E4", VA = "0x14923E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AAC")]
		public Vector2 AimStartMousePosition
		{
			[Token(Token = "0x6005DEE")]
			[Address(RVA = "0x14923EC", Offset = "0x14923EC", VA = "0x14923EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72B44", Offset = "0x72B44")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005DEF")]
			[Address(RVA = "0x14923F8", Offset = "0x14923F8", VA = "0x14923F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72B54", Offset = "0x72B54")]
			protected set
			{
			}
		}

		[Token(Token = "0x1400009D")]
		public event Action OnAimStart
		{
			[Token(Token = "0x6005DCA")]
			[Address(RVA = "0x14912C4", Offset = "0x14912C4", VA = "0x14912C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x729C4", Offset = "0x729C4")]
			add
			{
			}
			[Token(Token = "0x6005DCB")]
			[Address(RVA = "0x1491368", Offset = "0x1491368", VA = "0x1491368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x729D4", Offset = "0x729D4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400009E")]
		public event Action<Vector3, bool> OnAimUpdate
		{
			[Token(Token = "0x6005DCC")]
			[Address(RVA = "0x149140C", Offset = "0x149140C", VA = "0x149140C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x729E4", Offset = "0x729E4")]
			add
			{
			}
			[Token(Token = "0x6005DCD")]
			[Address(RVA = "0x14914B0", Offset = "0x14914B0", VA = "0x14914B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x729F4", Offset = "0x729F4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400009F")]
		public event Action<Vector3> OnPreShoot
		{
			[Token(Token = "0x6005DCE")]
			[Address(RVA = "0x1491554", Offset = "0x1491554", VA = "0x1491554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72A04", Offset = "0x72A04")]
			add
			{
			}
			[Token(Token = "0x6005DCF")]
			[Address(RVA = "0x14915F8", Offset = "0x14915F8", VA = "0x14915F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72A14", Offset = "0x72A14")]
			remove
			{
			}
		}

		[Token(Token = "0x140000A0")]
		public event Action<Vector3> OnShoot
		{
			[Token(Token = "0x6005DD0")]
			[Address(RVA = "0x149169C", Offset = "0x149169C", VA = "0x149169C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72A24", Offset = "0x72A24")]
			add
			{
			}
			[Token(Token = "0x6005DD1")]
			[Address(RVA = "0x1491740", Offset = "0x1491740", VA = "0x1491740")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72A34", Offset = "0x72A34")]
			remove
			{
			}
		}

		[Token(Token = "0x140000A1")]
		public event Action<Vector3> OnShootWhileBlocked
		{
			[Token(Token = "0x6005DD2")]
			[Address(RVA = "0x14917E4", Offset = "0x14917E4", VA = "0x14917E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72A44", Offset = "0x72A44")]
			add
			{
			}
			[Token(Token = "0x6005DD3")]
			[Address(RVA = "0x1491888", Offset = "0x1491888", VA = "0x1491888")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72A54", Offset = "0x72A54")]
			remove
			{
			}
		}

		[Token(Token = "0x140000A2")]
		public event Action<GolfBallController, int> OnPlayerHasShot
		{
			[Token(Token = "0x6005DD4")]
			[Address(RVA = "0x149192C", Offset = "0x149192C", VA = "0x149192C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72A64", Offset = "0x72A64")]
			add
			{
			}
			[Token(Token = "0x6005DD5")]
			[Address(RVA = "0x14919D0", Offset = "0x14919D0", VA = "0x14919D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72A74", Offset = "0x72A74")]
			remove
			{
			}
		}

		[Token(Token = "0x140000A3")]
		public event Action OnCancel
		{
			[Token(Token = "0x6005DD6")]
			[Address(RVA = "0x1491A74", Offset = "0x1491A74", VA = "0x1491A74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72A84", Offset = "0x72A84")]
			add
			{
			}
			[Token(Token = "0x6005DD7")]
			[Address(RVA = "0x1491B18", Offset = "0x1491B18", VA = "0x1491B18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72A94", Offset = "0x72A94")]
			remove
			{
			}
		}

		[Token(Token = "0x140000A4")]
		public event Action OnReset
		{
			[Token(Token = "0x6005DD8")]
			[Address(RVA = "0x1491BBC", Offset = "0x1491BBC", VA = "0x1491BBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72AA4", Offset = "0x72AA4")]
			add
			{
			}
			[Token(Token = "0x6005DD9")]
			[Address(RVA = "0x1491C60", Offset = "0x1491C60", VA = "0x1491C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72AB4", Offset = "0x72AB4")]
			remove
			{
			}
		}

		[Token(Token = "0x140000A5")]
		public event Action<ShootArrow> OnShootArrowInitialized
		{
			[Token(Token = "0x6005DDA")]
			[Address(RVA = "0x1491D04", Offset = "0x1491D04", VA = "0x1491D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72AC4", Offset = "0x72AC4")]
			add
			{
			}
			[Token(Token = "0x6005DDB")]
			[Address(RVA = "0x1491DA8", Offset = "0x1491DA8", VA = "0x1491DA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72AD4", Offset = "0x72AD4")]
			remove
			{
			}
		}

		[Token(Token = "0x140000A6")]
		public event Action OnOutOfBoundsEvent
		{
			[Token(Token = "0x6005DDC")]
			[Address(RVA = "0x1491E4C", Offset = "0x1491E4C", VA = "0x1491E4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72AE4", Offset = "0x72AE4")]
			add
			{
			}
			[Token(Token = "0x6005DDD")]
			[Address(RVA = "0x1491EF0", Offset = "0x1491EF0", VA = "0x1491EF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72AF4", Offset = "0x72AF4")]
			remove
			{
			}
		}

		[Token(Token = "0x6005DE6")]
		[Address(RVA = "0x1492270", Offset = "0x1492270", VA = "0x1492270")]
		public void AddBlockingFunction(Func<bool> blockFunction)
		{
		}

		[Token(Token = "0x6005DE7")]
		[Address(RVA = "0x149232C", Offset = "0x149232C", VA = "0x149232C")]
		public void RemoveBlockingFunction(Func<bool> blockFunction)
		{
		}

		[Token(Token = "0x6005DE8")]
		[Address(RVA = "0x14920BC", Offset = "0x14920BC", VA = "0x14920BC")]
		public bool IsBlockingFromFunctions()
		{
			return default;
		}

		[Token(Token = "0x6005DF0")]
		[Address(RVA = "0x1492404", Offset = "0x1492404", VA = "0x1492404")]
		protected Camera GetCam()
		{
			return null;
		}

		[Token(Token = "0x6005DF1")]
		[Address(RVA = "0x1492528", Offset = "0x1492528", VA = "0x1492528")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005DF2")]
		[Address(RVA = "0x1492A9C", Offset = "0x1492A9C", VA = "0x1492A9C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6005DF3")]
		[Address(RVA = "0x149318C", Offset = "0x149318C", VA = "0x149318C")]
		public void OnSpawnController(GolfBallController oldController)
		{
		}

		[Token(Token = "0x6005DF4")]
		[Address(RVA = "0x1493060", Offset = "0x1493060", VA = "0x1493060")]
		public void SetShootArrow(ShootArrow newArrow)
		{
		}

		[Token(Token = "0x6005DF5")]
		[Address(RVA = "0x1493100", Offset = "0x1493100", VA = "0x1493100")]
		public void SetPlayer(int index)
		{
		}

		[Token(Token = "0x6005DF6")]
		[Address(RVA = "0x1493280", Offset = "0x1493280", VA = "0x1493280")]
		public Player GetPlayer()
		{
			return null;
		}

		[Token(Token = "0x6005DF7")]
		[Address(RVA = "0x1493288", Offset = "0x1493288", VA = "0x1493288")]
		public void SetLocalShotCount(int shots)
		{
		}

		[Token(Token = "0x6005DF8")]
		[Address(RVA = "0x1493290", Offset = "0x1493290", VA = "0x1493290")]
		public int GetLocalShotCount()
		{
			return default;
		}

		[Token(Token = "0x6005DF9")]
		[Address(RVA = "0x1493298", Offset = "0x1493298", VA = "0x1493298")]
		public void Activate()
		{
		}

		[Token(Token = "0x6005DFA")]
		[Address(RVA = "0x1493324", Offset = "0x1493324", VA = "0x1493324")]
		public void Prepare()
		{
		}

		[Token(Token = "0x6005DFB")]
		[Address(RVA = "0x1493328", Offset = "0x1493328", VA = "0x1493328")]
		public void GoalReached()
		{
		}

		[Token(Token = "0x6005DFC")]
		[Address(RVA = "0x149334C", Offset = "0x149334C", VA = "0x149334C")]
		public void CheckpointHit(Vector3 newStartPos, Quaternion newStartRot)
		{
		}

		[Token(Token = "0x6005DFD")]
		[Address(RVA = "0x149336C", Offset = "0x149336C", VA = "0x149336C")]
		public void ForceShot()
		{
		}

		[Token(Token = "0x6005DFE")]
		[Address(RVA = "0x14933D4", Offset = "0x14933D4", VA = "0x14933D4")]
		public void ForceShot(Vector3 aimVector)
		{
		}

		[Token(Token = "0x6005DFF")]
		[Address(RVA = "0x1493A58", Offset = "0x1493A58", VA = "0x1493A58")]
		public float ScreenDistanceToArrow(Vector3 pos)
		{
			return default;
		}

		[Token(Token = "0x6005E00")]
		[Address(RVA = "0x1493B38", Offset = "0x1493B38", VA = "0x1493B38")]
		public float GetShotAccuracy(Vector3 boost)
		{
			return default;
		}

		[Token(Token = "0x6005E01")]
		[Address(RVA = "0x1493B44", Offset = "0x1493B44", VA = "0x1493B44")]
		public bool IsGroundedWithHeight(float height)
		{
			return default;
		}

		[Token(Token = "0x6005E02")]
		[Address(RVA = "0x1493CFC", Offset = "0x1493CFC", VA = "0x1493CFC")]
		public void TimedBlockShot(float duration)
		{
		}

		[Token(Token = "0x6005E03")]
		[Address(RVA = "0x1493D38", Offset = "0x1493D38", VA = "0x1493D38")]
		public void TimedStopBlocking(float duration)
		{
		}

		[Token(Token = "0x6005E04")]
		[Address(RVA = "0x1493D40", Offset = "0x1493D40", VA = "0x1493D40")]
		public void CancelShooting()
		{
		}

		[Token(Token = "0x6005E05")]
		[Address(RVA = "0x1493DF0", Offset = "0x1493DF0", VA = "0x1493DF0")]
		public void ForceOutOfBounds(string text)
		{
		}

		[Token(Token = "0x6005E06")]
		[Address(RVA = "0x1493E70", Offset = "0x1493E70", VA = "0x1493E70")]
		public void CountShot()
		{
		}

		[Token(Token = "0x6005E07")]
		[Address(RVA = "0x1493F8C", Offset = "0x1493F8C", VA = "0x1493F8C")]
		public void ChangeShooter(ShooterBase newShooter)
		{
		}

		[Token(Token = "0x6005E08")]
		[Address(RVA = "0x1493F94", Offset = "0x1493F94", VA = "0x1493F94")]
		private void OnApplicationPause(bool pauseState)
		{
		}

		[Token(Token = "0x6005E09")]
		[Address(RVA = "0x1493FA4", Offset = "0x1493FA4", VA = "0x1493FA4", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6005E0A")]
		[Address(RVA = "0x1495068", Offset = "0x1495068", VA = "0x1495068", Slot = "6")]
		internal virtual Vector3 GetFinalAimVector()
		{
			return default;
		}

		[Token(Token = "0x6005E0B")]
		[Address(RVA = "0x1493474", Offset = "0x1493474", VA = "0x1493474")]
		private void TryShoot()
		{
		}

		[Token(Token = "0x6005E0C")]
		[Address(RVA = "0x1494BC0", Offset = "0x1494BC0", VA = "0x1494BC0")]
		private bool CheckPreviousAimVectorsForDifference()
		{
			return default;
		}

		[Token(Token = "0x6005E0D")]
		[Address(RVA = "0x1495A40", Offset = "0x1495A40", VA = "0x1495A40", Slot = "7")]
		public virtual bool GetShootButtonDown(bool onlyController = false, string shootButtonName = "Shoot")
		{
			return default;
		}

		[Token(Token = "0x6005E0E")]
		[Address(RVA = "0x1495AD4", Offset = "0x1495AD4", VA = "0x1495AD4", Slot = "8")]
		public virtual bool GetShootButton(bool onlyController = false, string shootButtonName = "Shoot")
		{
			return default;
		}

		[Token(Token = "0x6005E0F")]
		[Address(RVA = "0x1495B78", Offset = "0x1495B78", VA = "0x1495B78", Slot = "9")]
		public virtual bool GetShootButtonUp(bool onlyController = false, string shootButtonName = "Shoot")
		{
			return default;
		}

		[Token(Token = "0x6005E10")]
		[Address(RVA = "0x14949F4", Offset = "0x14949F4", VA = "0x14949F4")]
		public bool GetCancelButtonDown()
		{
			return default;
		}

		[Token(Token = "0x6005E11")]
		[Address(RVA = "0x1495C0C", Offset = "0x1495C0C", VA = "0x1495C0C", Slot = "10")]
		protected virtual Vector2 GetInputPosition()
		{
			return default;
		}

		[Token(Token = "0x6005E12")]
		[Address(RVA = "0x1495D58", Offset = "0x1495D58", VA = "0x1495D58", Slot = "11")]
		protected virtual bool IsStartingToAim()
		{
			return default;
		}

		[Token(Token = "0x6005E13")]
		[Address(RVA = "0x1494D68", Offset = "0x1494D68", VA = "0x1494D68")]
		private bool IsShooting()
		{
			return default;
		}

		[Token(Token = "0x6005E14")]
		[Address(RVA = "0x1494A00", Offset = "0x1494A00", VA = "0x1494A00")]
		public Vector2 GetPlayerAxisDirection(bool raw = false, string horizontalName = "Aim Horizontal", string verticalName = "Aim Vertical")
		{
			return default;
		}

		[Token(Token = "0x6005E15")]
		[Address(RVA = "0x14948D0", Offset = "0x14948D0", VA = "0x14948D0")]
		private void DetermineVelocity()
		{
		}

		[Token(Token = "0x6005E16")]
		[Address(RVA = "0x1495FE0", Offset = "0x1495FE0", VA = "0x1495FE0")]
		private Vector3 GetMousePositionOnCamPlane(Vector2 mousePosition)
		{
			return default;
		}

		[Token(Token = "0x6005E17")]
		[Address(RVA = "0x1496118", Offset = "0x1496118", VA = "0x1496118")]
		public Vector3 GetPositionOnAimPlane(Vector2 position)
		{
			return default;
		}

		[Token(Token = "0x6005E18")]
		[Address(RVA = "0x1495800", Offset = "0x1495800", VA = "0x1495800")]
		public Vector3 GetMousePositionOnAimPlane(Vector2 mousePosition)
		{
			return default;
		}

		[Token(Token = "0x6005E19")]
		[Address(RVA = "0x1496250", Offset = "0x1496250", VA = "0x1496250")]
		public Plane GetPlane(AimPlanes planeType, Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6005E1A")]
		[Address(RVA = "0x14851E4", Offset = "0x14851E4", VA = "0x14851E4")]
		public Plane GetPlane(AimPlanes planeType)
		{
			return default;
		}

		[Token(Token = "0x6005E1B")]
		[Address(RVA = "0x1496534", Offset = "0x1496534", VA = "0x1496534")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6005E1C")]
		[Address(RVA = "0x1496574", Offset = "0x1496574", VA = "0x1496574")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6005E1D")]
		[Address(RVA = "0x14965B4", Offset = "0x14965B4", VA = "0x14965B4", Slot = "12")]
		protected virtual void CheckOutOfBounds(string tag)
		{
		}

		[Token(Token = "0x6005E1E")]
		[Address(RVA = "0x1496A84", Offset = "0x1496A84", VA = "0x1496A84")]
		public void RaiseOnOutOfBoundsEvent()
		{
		}

		[Token(Token = "0x6005E1F")]
		[Address(RVA = "0x14967FC", Offset = "0x14967FC", VA = "0x14967FC")]
		private void FailLevel(bool doReload = true)
		{
		}

		[Token(Token = "0x6005E20")]
		[Address(RVA = "0x1496758", Offset = "0x1496758", VA = "0x1496758")]
		private void HideShootArrow()
		{
		}

		[Token(Token = "0x6005E21")]
		[Address(RVA = "0x1493E30", Offset = "0x1493E30", VA = "0x1493E30")]
		public void OutOfBounds(string txt = "OUT OF BOUNDS", float delayedReset = 0f)
		{
		}

		[Token(Token = "0x6005E22")]
		[Address(RVA = "0x14968D8", Offset = "0x14968D8", VA = "0x14968D8")]
		public void Reset(float delayedReset = 0f)
		{
		}

		[Token(Token = "0x6005E23")]
		[Address(RVA = "0x1496AD4", Offset = "0x1496AD4", VA = "0x1496AD4")]
		private void Reload(string title)
		{
		}

		[Token(Token = "0x6005E24")]
		[Address(RVA = "0x148C310", Offset = "0x148C310", VA = "0x148C310")]
		public void StopAiming()
		{
		}

		[Token(Token = "0x6005E25")]
		[Address(RVA = "0x1496AD8", Offset = "0x1496AD8", VA = "0x1496AD8")]
		private void OnComplete(Level.CompletedState state)
		{
		}

		[Token(Token = "0x6005E26")]
		[Address(RVA = "0x1496B10", Offset = "0x1496B10", VA = "0x1496B10")]
		private void ResetValues()
		{
		}

		[Token(Token = "0x6005E27")]
		[Address(RVA = "0x1496D78", Offset = "0x1496D78", VA = "0x1496D78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005E28")]
		[Address(RVA = "0x1496E28", Offset = "0x1496E28", VA = "0x1496E28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005E29")]
		[Address(RVA = "0x1496F5C", Offset = "0x1496F5C", VA = "0x1496F5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6005E2A")]
		[Address(RVA = "0x149714C", Offset = "0x149714C", VA = "0x149714C")]
		public GolfBallController()
		{
		}

		[Token(Token = "0x6005E2B")]
		[Address(RVA = "0x14971FC", Offset = "0x14971FC", VA = "0x14971FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72B64", Offset = "0x72B64")]
		private void _003CAwake_003Eb__142_0()
		{
		}

		[Token(Token = "0x6005E2C")]
		[Address(RVA = "0x149723C", Offset = "0x149723C", VA = "0x149723C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72B74", Offset = "0x72B74")]
		private void _003CTryShoot_003Eb__169_1()
		{
		}
	}
}
