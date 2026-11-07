using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000865")]
public class LaserSentry : MonoBehaviour
{
	[Token(Token = "0x2000866")]
	private enum States
	{
		[Token(Token = "0x4002DE0")]
		Seeking = 0,
		[Token(Token = "0x4002DE1")]
		WarmingUp = 1,
		[Token(Token = "0x4002DE2")]
		Shooting = 2
	}

	[Serializable]
	[Token(Token = "0x2000867")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41A28", Offset = "0x41A28")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002DE3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002DE4")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Rigidbody, bool> _003C_003E9__53_0;

		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x17CE2C8", Offset = "0x17CE2C8", VA = "0x17CE2C8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x17CE2D0", Offset = "0x17CE2D0", VA = "0x17CE2D0")]
		internal bool _003CUpdateObjectsInViewcone_003Eb__53_0(Rigidbody o)
		{
			return default;
		}
	}

	[Token(Token = "0x2000868")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41A38", Offset = "0x41A38")]
	private sealed class _003CShootLaser_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002DE5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002DE6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002DE7")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody rigid;

		[Token(Token = "0x4002DE8")]
		[FieldOffset(Offset = "0x28")]
		public LaserSentry _003C_003E4__this;

		[Token(Token = "0x4002DE9")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _003CtargetPosition_003E5__2;

		[Token(Token = "0x1700042A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60026C5")]
			[Address(RVA = "0x17CEBE0", Offset = "0x17CEBE0", VA = "0x17CEBE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700042B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60026C7")]
			[Address(RVA = "0x17CEC28", Offset = "0x17CEC28", VA = "0x17CEC28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x17CE2FC", Offset = "0x17CE2FC", VA = "0x17CE2FC")]
		[DebuggerHidden]
		public _003CShootLaser_003Ed__55(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x17CE328", Offset = "0x17CE328", VA = "0x17CE328", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x17CE32C", Offset = "0x17CE32C", VA = "0x17CE32C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60026C5")]
		[Address(RVA = "0x17CEBE0", Offset = "0x17CEBE0", VA = "0x17CEBE0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x17CEBE8", Offset = "0x17CEBE8", VA = "0x17CEBE8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x17CEC28", Offset = "0x17CEC28", VA = "0x17CEC28", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002DB0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UnityEvent _OnStartShoot;

	[Token(Token = "0x4002DB1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent _OnStopShoot;

	[Token(Token = "0x4002DB2")]
	[FieldOffset(Offset = "0x28")]
	public Transform connectedAim;

	[Token(Token = "0x4002DB3")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 spotlightOffset;

	[Token(Token = "0x4002DB4")]
	[FieldOffset(Offset = "0x40")]
	public Renderer connectedLaser;

	[Token(Token = "0x4002DB5")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem particles;

	[Token(Token = "0x4002DB6")]
	[FieldOffset(Offset = "0x50")]
	public IntroLoopOutro detectedLoop;

	[Token(Token = "0x4002DB7")]
	[FieldOffset(Offset = "0x58")]
	public RandomAudioClips detectedBeep;

	[Token(Token = "0x4002DB8")]
	[FieldOffset(Offset = "0x60")]
	public RandomAudioClips shootClips;

	[Token(Token = "0x4002DB9")]
	[FieldOffset(Offset = "0x68")]
	public Transform mesh;

	[Token(Token = "0x4002DBA")]
	[FieldOffset(Offset = "0x70")]
	public float MaxTrackDitsance;

	[Token(Token = "0x4002DBB")]
	[FieldOffset(Offset = "0x74")]
	public float laserDelay;

	[Token(Token = "0x4002DBC")]
	[FieldOffset(Offset = "0x78")]
	public float movementThreshold;

	[Token(Token = "0x4002DBD")]
	[FieldOffset(Offset = "0x7C")]
	public float targetingSpeed;

	[Token(Token = "0x4002DBE")]
	[FieldOffset(Offset = "0x80")]
	public float speed;

	[Token(Token = "0x4002DBF")]
	[FieldOffset(Offset = "0x84")]
	public float shootExplosionRadius;

	[Token(Token = "0x4002DC0")]
	[FieldOffset(Offset = "0x88")]
	public Color colorOne;

	[Token(Token = "0x4002DC1")]
	[FieldOffset(Offset = "0x98")]
	public Color colorTwo;

	[Token(Token = "0x4002DC2")]
	[FieldOffset(Offset = "0xA8")]
	public float colorOneTime;

	[Token(Token = "0x4002DC3")]
	[FieldOffset(Offset = "0xAC")]
	public float colorTwoTime;

	[Token(Token = "0x4002DC4")]
	[FieldOffset(Offset = "0xB0")]
	public List<string> BlacklistSearchTags;

	[Token(Token = "0x4002DC5")]
	[FieldOffset(Offset = "0xB8")]
	public MeshRenderer coneRenderer;

	[Token(Token = "0x4002DC6")]
	[FieldOffset(Offset = "0xC0")]
	public MeshRenderer groundCircleRenderer;

	[Token(Token = "0x4002DC7")]
	[FieldOffset(Offset = "0xC8")]
	private Material coneMaterial;

	[Token(Token = "0x4002DC8")]
	[FieldOffset(Offset = "0xD0")]
	private Material groundCircleMaterial;

	[Token(Token = "0x4002DC9")]
	[FieldOffset(Offset = "0xD8")]
	private float colorTime;

	[Token(Token = "0x4002DCA")]
	[FieldOffset(Offset = "0xDC")]
	private bool colorOneActive;

	[Token(Token = "0x4002DCB")]
	[FieldOffset(Offset = "0xE0")]
	private Rigidbody rigidB;

	[Token(Token = "0x4002DCC")]
	[FieldOffset(Offset = "0xE8")]
	private int curIndex;

	[Token(Token = "0x4002DCD")]
	[FieldOffset(Offset = "0xF0")]
	public List<Transform> CurvePoints;

	[Token(Token = "0x4002DCE")]
	[FieldOffset(Offset = "0xF8")]
	private Dictionary<Rigidbody, float> objectsInViewconeData;

	[Token(Token = "0x4002DCF")]
	[FieldOffset(Offset = "0x100")]
	private Collider col;

	[Token(Token = "0x4002DD0")]
	[FieldOffset(Offset = "0x108")]
	private List<Rigidbody> objectsInViewcone;

	[Token(Token = "0x4002DD1")]
	[FieldOffset(Offset = "0x110")]
	private int dir;

	[Token(Token = "0x4002DD2")]
	[FieldOffset(Offset = "0x114")]
	private Vector3 currentTarget;

	[Token(Token = "0x4002DD3")]
	[FieldOffset(Offset = "0x120")]
	private float currentSpeed;

	[Token(Token = "0x4002DD4")]
	[FieldOffset(Offset = "0x124")]
	private Vector3 baseScale;

	[Token(Token = "0x4002DD5")]
	[FieldOffset(Offset = "0x130")]
	private Vector3 baseColliderScale;

	[Token(Token = "0x4002DD6")]
	[FieldOffset(Offset = "0x13C")]
	private float smoothedMovement;

	[Token(Token = "0x4002DD7")]
	[FieldOffset(Offset = "0x140")]
	private float freezeTime;

	[Token(Token = "0x4002DD8")]
	[FieldOffset(Offset = "0x144")]
	private Vector3 startPosition;

	[Token(Token = "0x4002DD9")]
	[FieldOffset(Offset = "0x150")]
	private States state;

	[Token(Token = "0x4002DDA")]
	[FieldOffset(Offset = "0x154")]
	private States previousState;

	[Token(Token = "0x4002DDB")]
	[FieldOffset(Offset = "0x158")]
	public bool ignorePlayerIfNotAiming;

	[Token(Token = "0x4002DDC")]
	[FieldOffset(Offset = "0x159")]
	public bool pushAwayFromSpotlightCenter;

	[Token(Token = "0x4002DDD")]
	[FieldOffset(Offset = "0x15C")]
	public float shotExplosionForceScale;

	[Token(Token = "0x4002DDE")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private bool dontScaleCollider;

	[Token(Token = "0x60026B0")]
	[Address(RVA = "0x151C080", Offset = "0x151C080", VA = "0x151C080")]
	private void Start()
	{
	}

	[Token(Token = "0x60026B1")]
	[Address(RVA = "0x151C434", Offset = "0x151C434", VA = "0x151C434")]
	private Vector3 GetPos()
	{
		return default;
	}

	[Token(Token = "0x60026B2")]
	[Address(RVA = "0x151C564", Offset = "0x151C564", VA = "0x151C564")]
	private void Update()
	{
	}

	[Token(Token = "0x60026B3")]
	[Address(RVA = "0x151D3E0", Offset = "0x151D3E0", VA = "0x151D3E0")]
	private Vector3 UpdateFixedPosition()
	{
		return default;
	}

	[Token(Token = "0x60026B4")]
	[Address(RVA = "0x151D470", Offset = "0x151D470", VA = "0x151D470")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60026B5")]
	[Address(RVA = "0x151C8E4", Offset = "0x151C8E4", VA = "0x151C8E4")]
	private void UpdateObjectsInViewcone()
	{
	}

	[Token(Token = "0x60026B6")]
	[Address(RVA = "0x151D95C", Offset = "0x151D95C", VA = "0x151D95C")]
	private void Shoot(Rigidbody rigid)
	{
	}

	[Token(Token = "0x60026B7")]
	[Address(RVA = "0x151D9F0", Offset = "0x151D9F0", VA = "0x151D9F0")]
	private IEnumerator ShootLaser(Rigidbody rigid)
	{
		return null;
	}

	[Token(Token = "0x60026B8")]
	[Address(RVA = "0x151DA68", Offset = "0x151DA68", VA = "0x151DA68")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60026B9")]
	[Address(RVA = "0x151DC08", Offset = "0x151DC08", VA = "0x151DC08")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60026BA")]
	[Address(RVA = "0x151DD68", Offset = "0x151DD68", VA = "0x151DD68")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60026BB")]
	[Address(RVA = "0x151D7F4", Offset = "0x151D7F4", VA = "0x151D7F4")]
	public static Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		return default;
	}

	[Token(Token = "0x60026BC")]
	[Address(RVA = "0x151DEB8", Offset = "0x151DEB8", VA = "0x151DEB8")]
	public static Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point)
	{
		return default;
	}

	[Token(Token = "0x60026BD")]
	[Address(RVA = "0x151DEFC", Offset = "0x151DEFC", VA = "0x151DEFC")]
	public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		return default;
	}

	[Token(Token = "0x60026BE")]
	[Address(RVA = "0x151DFA4", Offset = "0x151DFA4", VA = "0x151DFA4")]
	public LaserSentry()
	{
	}
}
