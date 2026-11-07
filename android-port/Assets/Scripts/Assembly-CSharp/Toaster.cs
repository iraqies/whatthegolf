using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C54")]
public class Toaster : MonoBehaviour
{
	[Token(Token = "0x2000C55")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440D8", Offset = "0x440D8")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x40043CB")]
		[FieldOffset(Offset = "0x10")]
		public Toaster _003C_003E4__this;

		[Token(Token = "0x40043CC")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 handleStartPos;

		[Token(Token = "0x6003AA8")]
		[Address(RVA = "0x1867B7C", Offset = "0x1867B7C", VA = "0x1867B7C")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6003AA9")]
		[Address(RVA = "0x1867B84", Offset = "0x1867B84", VA = "0x1867B84")]
		internal void _003CToastRoutine_003Eb__0(AudioSource s)
		{
		}

		[Token(Token = "0x6003AAA")]
		[Address(RVA = "0x1867C04", Offset = "0x1867C04", VA = "0x1867C04")]
		internal void _003CToastRoutine_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000C56")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440E8", Offset = "0x440E8")]
	private sealed class _003CToastRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40043CD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40043CE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40043CF")]
		[FieldOffset(Offset = "0x20")]
		public Toaster _003C_003E4__this;

		[Token(Token = "0x17000607")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003AAE")]
			[Address(RVA = "0x1868408", Offset = "0x1868408", VA = "0x1868408", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000608")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003AB0")]
			[Address(RVA = "0x1868450", Offset = "0x1868450", VA = "0x1868450", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003AAB")]
		[Address(RVA = "0x1867D20", Offset = "0x1867D20", VA = "0x1867D20")]
		[DebuggerHidden]
		public _003CToastRoutine_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003AAC")]
		[Address(RVA = "0x1867D4C", Offset = "0x1867D4C", VA = "0x1867D4C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003AAD")]
		[Address(RVA = "0x1867D50", Offset = "0x1867D50", VA = "0x1867D50", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003AAE")]
		[Address(RVA = "0x1868408", Offset = "0x1868408", VA = "0x1868408", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003AAF")]
		[Address(RVA = "0x1868410", Offset = "0x1868410", VA = "0x1868410", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003AB0")]
		[Address(RVA = "0x1868450", Offset = "0x1868450", VA = "0x1868450", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40043B4")]
	[FieldOffset(Offset = "0x18")]
	public List<Rigidbody> Toasts;

	[Token(Token = "0x40043B5")]
	[FieldOffset(Offset = "0x20")]
	private Vector3[] originalToastPositions;

	[Token(Token = "0x40043B6")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 originalToasterPosition;

	[Token(Token = "0x40043B7")]
	[FieldOffset(Offset = "0x34")]
	private Quaternion originalToasterRotation;

	[Token(Token = "0x40043B8")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 originalHandlePosition;

	[Token(Token = "0x40043B9")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody rigid;

	[Token(Token = "0x40043BA")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool isEditorToaster;

	[Token(Token = "0x40043BB")]
	[FieldOffset(Offset = "0x60")]
	public Transform Handle;

	[Token(Token = "0x40043BC")]
	[FieldOffset(Offset = "0x68")]
	public float HandleEndHeight;

	[Token(Token = "0x40043BD")]
	[FieldOffset(Offset = "0x6C")]
	public float ToastForce;

	[Token(Token = "0x40043BE")]
	[FieldOffset(Offset = "0x70")]
	public List<AudioClip> ToastClip;

	[Token(Token = "0x40043BF")]
	[FieldOffset(Offset = "0x78")]
	public LevelEvent toasterExists;

	[Token(Token = "0x40043C0")]
	[FieldOffset(Offset = "0x80")]
	public LevelEvent toasterPopped;

	[Token(Token = "0x40043C1")]
	[FieldOffset(Offset = "0x88")]
	public float AutoResetTime;

	[Token(Token = "0x40043C2")]
	[FieldOffset(Offset = "0x8C")]
	public bool UnparentToasts;

	[Token(Token = "0x40043C3")]
	[FieldOffset(Offset = "0x90")]
	public Collectable Collectable;

	[Token(Token = "0x40043C4")]
	[FieldOffset(Offset = "0x98")]
	public string ToasterId;

	[Token(Token = "0x40043C5")]
	[FieldOffset(Offset = "0xA0")]
	public TransitionTextEffect ToasterEffect;

	[Token(Token = "0x40043C6")]
	[FieldOffset(Offset = "0xA8")]
	public List<string> CollisionTags;

	[Token(Token = "0x40043C7")]
	[FieldOffset(Offset = "0xB0")]
	private bool hasSprung;

	[Token(Token = "0x40043C8")]
	[FieldOffset(Offset = "0xB4")]
	private float resetTimer;

	[Token(Token = "0x40043C9")]
	[FieldOffset(Offset = "0xB8")]
	private List<Transform> toastTransforms;

	[Token(Token = "0x40043CA")]
	[FieldOffset(Offset = "0xC0")]
	public Action<Toaster> onToast;

	[Token(Token = "0x6003AA0")]
	[Address(RVA = "0x1718D38", Offset = "0x1718D38", VA = "0x1718D38")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003AA1")]
	[Address(RVA = "0x17190EC", Offset = "0x17190EC", VA = "0x17190EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6003AA2")]
	[Address(RVA = "0x1719294", Offset = "0x1719294", VA = "0x1719294")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6B524", Offset = "0x6B524")]
	public void ToastBread(bool hitByPlayer)
	{
	}

	[Token(Token = "0x6003AA3")]
	[Address(RVA = "0x17193E0", Offset = "0x17193E0", VA = "0x17193E0")]
	public void ResetToaster()
	{
	}

	[Token(Token = "0x6003AA4")]
	[Address(RVA = "0x1719738", Offset = "0x1719738", VA = "0x1719738")]
	public void DestroyBread()
	{
	}

	[Token(Token = "0x6003AA5")]
	[Address(RVA = "0x171936C", Offset = "0x171936C", VA = "0x171936C")]
	private IEnumerator ToastRoutine(bool hitByPlayer)
	{
		return null;
	}

	[Token(Token = "0x6003AA6")]
	[Address(RVA = "0x171982C", Offset = "0x171982C", VA = "0x171982C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6003AA7")]
	[Address(RVA = "0x17198CC", Offset = "0x17198CC", VA = "0x17198CC")]
	public Toaster()
	{
	}
}
