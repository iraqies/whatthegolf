using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000803")]
public class SimplePortal : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000804")]
	public class UnityGameobjectEvent : UnityEvent<GameObject>
	{
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x184EDD4", Offset = "0x184EDD4", VA = "0x184EDD4")]
		public UnityGameobjectEvent()
		{
		}
	}

	[Token(Token = "0x2000805")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41740", Offset = "0x41740")]
	private sealed class _003COpenHiddenPortal_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002B21")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002B22")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002B23")]
		[FieldOffset(Offset = "0x20")]
		public SimplePortal _003C_003E4__this;

		[Token(Token = "0x4002B24")]
		[FieldOffset(Offset = "0x28")]
		public GameObject other;

		[Token(Token = "0x17000400")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60024E0")]
			[Address(RVA = "0x184ED84", Offset = "0x184ED84", VA = "0x184ED84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000401")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60024E2")]
			[Address(RVA = "0x184EDCC", Offset = "0x184EDCC", VA = "0x184EDCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x184EAF4", Offset = "0x184EAF4", VA = "0x184EAF4")]
		[DebuggerHidden]
		public _003COpenHiddenPortal_003Ed__50(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x184EB20", Offset = "0x184EB20", VA = "0x184EB20", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60024DF")]
		[Address(RVA = "0x184EB24", Offset = "0x184EB24", VA = "0x184EB24", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60024E0")]
		[Address(RVA = "0x184ED84", Offset = "0x184ED84", VA = "0x184ED84", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60024E1")]
		[Address(RVA = "0x184ED8C", Offset = "0x184ED8C", VA = "0x184ED8C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60024E2")]
		[Address(RVA = "0x184EDCC", Offset = "0x184EDCC", VA = "0x184EDCC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002AFE")]
	[FieldOffset(Offset = "0x0")]
	public static Action FinishedTeleporting;

	[Token(Token = "0x4002AFF")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F0E4", Offset = "0x4F0E4")]
	private Action<SimplePortal, GameObject, SimplePortal> m_OnPortaling;

	[Token(Token = "0x4002B00")]
	[FieldOffset(Offset = "0x20")]
	public SimplePortal LinkedPortal;

	[Token(Token = "0x4002B01")]
	[FieldOffset(Offset = "0x28")]
	public Transmogrif sendThroughTransmogrif;

	[Token(Token = "0x4002B02")]
	[FieldOffset(Offset = "0x30")]
	public List<string> AllowedTags;

	[Token(Token = "0x4002B03")]
	[FieldOffset(Offset = "0x38")]
	public Color InactiveColor;

	[Token(Token = "0x4002B04")]
	[FieldOffset(Offset = "0x48")]
	public bool SetRotationOnTransfer;

	[Token(Token = "0x4002B05")]
	[FieldOffset(Offset = "0x49")]
	public bool hideUntilUsedFromOtherSide;

	[Token(Token = "0x4002B06")]
	[FieldOffset(Offset = "0x4A")]
	public bool saveUnhideState;

	[Token(Token = "0x4002B07")]
	[FieldOffset(Offset = "0x50")]
	public AudioEventAsset portalSFX;

	[Token(Token = "0x4002B08")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AudioClip sfxPortal;

	[Token(Token = "0x4002B09")]
	[FieldOffset(Offset = "0x60")]
	public float BlockTimer;

	[Token(Token = "0x4002B0A")]
	[FieldOffset(Offset = "0x64")]
	public float SpawnOffset;

	[Token(Token = "0x4002B0B")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 WorldPositionSpawnOffset;

	[Token(Token = "0x4002B0C")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 ForceDirectionOverride;

	[Token(Token = "0x4002B0D")]
	[FieldOffset(Offset = "0x80")]
	public bool CheckForRigidParent;

	[Token(Token = "0x4002B0E")]
	[FieldOffset(Offset = "0x88")]
	public UnityEvent OtherEvents;

	[Token(Token = "0x4002B0F")]
	[FieldOffset(Offset = "0x90")]
	public UnityGameobjectEvent OtherEventsWithInfo;

	[Token(Token = "0x4002B10")]
	[FieldOffset(Offset = "0x98")]
	public bool IgnoreKinematicObjects;

	[Token(Token = "0x4002B11")]
	[FieldOffset(Offset = "0x9C")]
	public float MinVelocityOnExit;

	[Token(Token = "0x4002B12")]
	[FieldOffset(Offset = "0xA0")]
	public bool useTransitionCamera;

	[Token(Token = "0x4002B13")]
	[FieldOffset(Offset = "0xA1")]
	public bool portAll;

	[Token(Token = "0x4002B14")]
	[FieldOffset(Offset = "0xA2")]
	public bool portOnce;

	[Token(Token = "0x4002B15")]
	[FieldOffset(Offset = "0xA4")]
	public Color baseColor;

	[Token(Token = "0x4002B16")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F104", Offset = "0x4F104")]
	private Action m_OnPortalEnabledIfDidntStartEnabled;

	[Token(Token = "0x4002B17")]
	[FieldOffset(Offset = "0xC0")]
	private SpriteRenderer render;

	[Token(Token = "0x4002B18")]
	[FieldOffset(Offset = "0xC8")]
	private float colorValue;

	[Token(Token = "0x4002B19")]
	[FieldOffset(Offset = "0xCC")]
	private float blockTimer;

	[Token(Token = "0x4002B1A")]
	[FieldOffset(Offset = "0xD0")]
	private Color targetColor;

	[Token(Token = "0x4002B1B")]
	[FieldOffset(Offset = "0xE0")]
	private ParticleSystem particles;

	[Token(Token = "0x4002B1C")]
	[FieldOffset(Offset = "0xE8")]
	private GridFiller filler;

	[Token(Token = "0x4002B1D")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string saveFormat;

	[Token(Token = "0x4002B1E")]
	[FieldOffset(Offset = "0xF8")]
	public float transitionCamTime;

	[Token(Token = "0x4002B1F")]
	[FieldOffset(Offset = "0x100")]
	private OverworldID overworldID;

	[Token(Token = "0x4002B20")]
	[FieldOffset(Offset = "0x108")]
	public bool NotSaved;

	[Token(Token = "0x14000033")]
	public event Action<SimplePortal, GameObject, SimplePortal> OnPortaling
	{
		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x16AD110", Offset = "0x16AD110", VA = "0x16AD110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66660", Offset = "0x66660")]
		add
		{
		}
		[Token(Token = "0x60024C9")]
		[Address(RVA = "0x16AD1B4", Offset = "0x16AD1B4", VA = "0x16AD1B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66670", Offset = "0x66670")]
		remove
		{
		}
	}

	[Token(Token = "0x14000034")]
	public event Action OnPortalEnabledIfDidntStartEnabled
	{
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x16AD258", Offset = "0x16AD258", VA = "0x16AD258")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66680", Offset = "0x66680")]
		add
		{
		}
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x16AD2FC", Offset = "0x16AD2FC", VA = "0x16AD2FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66690", Offset = "0x66690")]
		remove
		{
		}
	}

	[Token(Token = "0x60024CC")]
	[Address(RVA = "0x16AD3A0", Offset = "0x16AD3A0", VA = "0x16AD3A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60024CD")]
	[Address(RVA = "0x16AD48C", Offset = "0x16AD48C", VA = "0x16AD48C")]
	public void OpenPortalFromOtherSide()
	{
	}

	[Token(Token = "0x60024CE")]
	[Address(RVA = "0x16AD4AC", Offset = "0x16AD4AC", VA = "0x16AD4AC")]
	public void Init(GridFiller gridFiller)
	{
	}

	[Token(Token = "0x60024CF")]
	[Address(RVA = "0x16AD5D8", Offset = "0x16AD5D8", VA = "0x16AD5D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60024D0")]
	[Address(RVA = "0x16AD7F0", Offset = "0x16AD7F0", VA = "0x16AD7F0")]
	private bool IsActive()
	{
		return default;
	}

	[Token(Token = "0x60024D1")]
	[Address(RVA = "0x16AD8C4", Offset = "0x16AD8C4", VA = "0x16AD8C4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60024D2")]
	[Address(RVA = "0x16AD9E8", Offset = "0x16AD9E8", VA = "0x16AD9E8")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60024D3")]
	[Address(RVA = "0x16AD9EC", Offset = "0x16AD9EC", VA = "0x16AD9EC")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x60024D4")]
	[Address(RVA = "0x16ADB10", Offset = "0x16ADB10", VA = "0x16ADB10")]
	private void OnTriggerStay2D(Collider2D other)
	{
	}

	[Token(Token = "0x60024D5")]
	[Address(RVA = "0x16ADB14", Offset = "0x16ADB14", VA = "0x16ADB14", Slot = "4")]
	protected virtual void ObjectEnteredTrigger(GameObject other)
	{
	}

	[Token(Token = "0x60024D6")]
	[Address(RVA = "0x16ADF18", Offset = "0x16ADF18", VA = "0x16ADF18")]
	private IEnumerator OpenHiddenPortal(GameObject other)
	{
		return null;
	}

	[Token(Token = "0x60024D7")]
	[Address(RVA = "0x16ADF90", Offset = "0x16ADF90", VA = "0x16ADF90")]
	public void SaveOpenState()
	{
	}

	[Token(Token = "0x60024D8")]
	[Address(RVA = "0x16AE05C", Offset = "0x16AE05C", VA = "0x16AE05C", Slot = "5")]
	protected virtual void RecieveObject(GameObject go)
	{
	}

	[Token(Token = "0x60024D9")]
	[Address(RVA = "0x16AE060", Offset = "0x16AE060", VA = "0x16AE060")]
	private void ThrowOutOfPortal(GameObject go)
	{
	}

	[Token(Token = "0x60024DA")]
	[Address(RVA = "0x16AE644", Offset = "0x16AE644", VA = "0x16AE644")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60024DB")]
	[Address(RVA = "0x16AE760", Offset = "0x16AE760", VA = "0x16AE760")]
	public SimplePortal()
	{
	}
}
