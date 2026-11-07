using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Audio.Rumble;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Tilemaps;

[Token(Token = "0x200097D")]
public class OverworldMainButton : MonoBehaviour
{
	[Token(Token = "0x200097E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42498", Offset = "0x42498")]
	private sealed class _003CBlinkRoutine_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003445")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003446")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003447")]
		[FieldOffset(Offset = "0x20")]
		public OverworldMainButton _003C_003E4__this;

		[Token(Token = "0x1700049B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002C6C")]
			[Address(RVA = "0x1813B88", Offset = "0x1813B88", VA = "0x1813B88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700049C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002C6E")]
			[Address(RVA = "0x1813BD0", Offset = "0x1813BD0", VA = "0x1813BD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002C69")]
		[Address(RVA = "0x1813A38", Offset = "0x1813A38", VA = "0x1813A38")]
		[DebuggerHidden]
		public _003CBlinkRoutine_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002C6A")]
		[Address(RVA = "0x1813A64", Offset = "0x1813A64", VA = "0x1813A64", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002C6B")]
		[Address(RVA = "0x1813A68", Offset = "0x1813A68", VA = "0x1813A68", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002C6C")]
		[Address(RVA = "0x1813B88", Offset = "0x1813B88", VA = "0x1813B88", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002C6D")]
		[Address(RVA = "0x1813B90", Offset = "0x1813B90", VA = "0x1813B90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0x1813BD0", Offset = "0x1813BD0", VA = "0x1813BD0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200097F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x424A8", Offset = "0x424A8")]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[Token(Token = "0x4003448")]
		[FieldOffset(Offset = "0x10")]
		public OverworldMainButton _003C_003E4__this;

		[Token(Token = "0x4003449")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x400344A")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 end;

		[Token(Token = "0x6002C6F")]
		[Address(RVA = "0x1813944", Offset = "0x1813944", VA = "0x1813944")]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6002C70")]
		[Address(RVA = "0x181394C", Offset = "0x181394C", VA = "0x181394C")]
		internal void _003CEnableButtonAndCable_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6002C71")]
		[Address(RVA = "0x18139F4", Offset = "0x18139F4", VA = "0x18139F4")]
		internal void _003CEnableButtonAndCable_003Eb__1(float t)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000980")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x424B8", Offset = "0x424B8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400344B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400344C")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__37_2;

		[Token(Token = "0x6002C73")]
		[Address(RVA = "0x1813938", Offset = "0x1813938", VA = "0x1813938")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002C74")]
		[Address(RVA = "0x1813940", Offset = "0x1813940", VA = "0x1813940")]
		internal void _003CEnableButtonAndCable_003Eb__37_2(AudioSource s)
		{
		}
	}

	[Token(Token = "0x2000981")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x424C8", Offset = "0x424C8")]
	private sealed class _003CEnableButtonAndCable_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400344D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400344E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400344F")]
		[FieldOffset(Offset = "0x20")]
		public OverworldMainButton _003C_003E4__this;

		[Token(Token = "0x4003450")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		[Token(Token = "0x4003451")]
		[FieldOffset(Offset = "0x30")]
		public Action<Vector3> OnMove;

		[Token(Token = "0x4003452")]
		[FieldOffset(Offset = "0x38")]
		public Action OnCompleted;

		[Token(Token = "0x1700049D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002C78")]
			[Address(RVA = "0x1814354", Offset = "0x1814354", VA = "0x1814354", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700049E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002C7A")]
			[Address(RVA = "0x181439C", Offset = "0x181439C", VA = "0x181439C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002C75")]
		[Address(RVA = "0x1813BD8", Offset = "0x1813BD8", VA = "0x1813BD8")]
		[DebuggerHidden]
		public _003CEnableButtonAndCable_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002C76")]
		[Address(RVA = "0x1813C04", Offset = "0x1813C04", VA = "0x1813C04", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002C77")]
		[Address(RVA = "0x1813C08", Offset = "0x1813C08", VA = "0x1813C08", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002C78")]
		[Address(RVA = "0x1814354", Offset = "0x1814354", VA = "0x1814354", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002C79")]
		[Address(RVA = "0x181435C", Offset = "0x181435C", VA = "0x181435C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002C7A")]
		[Address(RVA = "0x181439C", Offset = "0x181439C", VA = "0x181439C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400342C")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FC9C", Offset = "0x4FC9C")]
	private Action<OverworldMainButton> m_OnPressed;

	[Token(Token = "0x400342D")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FCAC", Offset = "0x4FCAC")]
	private Action m_OnInit;

	[Token(Token = "0x400342E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject openIndicator;

	[Token(Token = "0x400342F")]
	[FieldOffset(Offset = "0x30")]
	public OverworldMainDoorPlate doorplate;

	[Token(Token = "0x4003430")]
	[FieldOffset(Offset = "0x38")]
	public bool isEnabled;

	[Token(Token = "0x4003431")]
	[FieldOffset(Offset = "0x39")]
	public bool didInit;

	[Token(Token = "0x4003432")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer button;

	[Token(Token = "0x4003433")]
	[FieldOffset(Offset = "0x48")]
	public OverworldCable cable;

	[Token(Token = "0x4003434")]
	[FieldOffset(Offset = "0x50")]
	public OverworldButton2D PreviousDoor;

	[Token(Token = "0x4003435")]
	[FieldOffset(Offset = "0x58")]
	public AudioClipSettings sfxOnButtonClick;

	[Token(Token = "0x4003436")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip sfxOnCableEndReached;

	[Token(Token = "0x4003437")]
	[FieldOffset(Offset = "0x68")]
	public AudioSource srcOnCableSparkle;

	[Token(Token = "0x4003438")]
	[FieldOffset(Offset = "0x70")]
	public float travelStartPitch;

	[Token(Token = "0x4003439")]
	[FieldOffset(Offset = "0x74")]
	public float travelEndPitch;

	[Token(Token = "0x400343A")]
	[FieldOffset(Offset = "0x78")]
	public RumbleEventAsset cableSparkRumble;

	[Token(Token = "0x400343B")]
	[FieldOffset(Offset = "0x80")]
	private Collider2D buttonCollider;

	[Token(Token = "0x400343C")]
	[FieldOffset(Offset = "0x88")]
	private Coroutine currentBlinkRoutine;

	[Token(Token = "0x400343D")]
	[FieldOffset(Offset = "0x90")]
	public float UnlockBlinkRate;

	[Token(Token = "0x400343E")]
	[FieldOffset(Offset = "0x94")]
	public Color OpenColor;

	[Token(Token = "0x400343F")]
	[FieldOffset(Offset = "0xA4")]
	public Color UnlockedColor;

	[Token(Token = "0x4003440")]
	[FieldOffset(Offset = "0xB4")]
	public Color LockedColor;

	[Token(Token = "0x4003441")]
	[FieldOffset(Offset = "0xC4")]
	public bool DoNotAlignToGrid;

	[Token(Token = "0x4003442")]
	[FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FCBC", Offset = "0x4FCBC")]
	private Action<OverworldMainButton> m_OnEnteredCable;

	[Token(Token = "0x4003443")]
	[FieldOffset(Offset = "0xD0")]
	public bool isReusable;

	[Token(Token = "0x4003444")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private AudioClip m_PS5RumbleHapticsClip;

	[Token(Token = "0x1400003F")]
	public event Action<OverworldMainButton> OnPressed
	{
		[Token(Token = "0x6002C5A")]
		[Address(RVA = "0x15BC824", Offset = "0x15BC824", VA = "0x15BC824")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67EC4", Offset = "0x67EC4")]
		add
		{
		}
		[Token(Token = "0x6002C5B")]
		[Address(RVA = "0x15BC8C8", Offset = "0x15BC8C8", VA = "0x15BC8C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67ED4", Offset = "0x67ED4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000040")]
	public event Action OnInit
	{
		[Token(Token = "0x6002C5C")]
		[Address(RVA = "0x15BC96C", Offset = "0x15BC96C", VA = "0x15BC96C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67EE4", Offset = "0x67EE4")]
		add
		{
		}
		[Token(Token = "0x6002C5D")]
		[Address(RVA = "0x15BCA10", Offset = "0x15BCA10", VA = "0x15BCA10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67EF4", Offset = "0x67EF4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000041")]
	public event Action<OverworldMainButton> OnEnteredCable
	{
		[Token(Token = "0x6002C5E")]
		[Address(RVA = "0x15AE178", Offset = "0x15AE178", VA = "0x15AE178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67F04", Offset = "0x67F04")]
		add
		{
		}
		[Token(Token = "0x6002C5F")]
		[Address(RVA = "0x15BCAB4", Offset = "0x15BCAB4", VA = "0x15BCAB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67F14", Offset = "0x67F14")]
		remove
		{
		}
	}

	[Token(Token = "0x6002C60")]
	[Address(RVA = "0x15BCB58", Offset = "0x15BCB58", VA = "0x15BCB58")]
	public void Init(Tilemap tilemap)
	{
	}

	[Token(Token = "0x6002C61")]
	[Address(RVA = "0x15BD050", Offset = "0x15BD050", VA = "0x15BD050")]
	private void PreviousDoor_OnOpen()
	{
	}

	[Token(Token = "0x6002C62")]
	[Address(RVA = "0x15BCEE8", Offset = "0x15BCEE8", VA = "0x15BCEE8")]
	private void UpdateStatus()
	{
	}

	[Token(Token = "0x6002C63")]
	[Address(RVA = "0x15AB68C", Offset = "0x15AB68C", VA = "0x15AB68C")]
	public void SetBlinking()
	{
	}

	[Token(Token = "0x6002C64")]
	[Address(RVA = "0x15BD054", Offset = "0x15BD054", VA = "0x15BD054")]
	private IEnumerator BlinkRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002C65")]
	[Address(RVA = "0x15BD0C8", Offset = "0x15BD0C8", VA = "0x15BD0C8")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002C66")]
	[Address(RVA = "0x15BD280", Offset = "0x15BD280", VA = "0x15BD280")]
	public IEnumerator EnableButtonAndCable(Action<Vector3> OnMove, Action OnCompleted)
	{
		return null;
	}

	[Token(Token = "0x6002C67")]
	[Address(RVA = "0x15BD308", Offset = "0x15BD308", VA = "0x15BD308")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002C68")]
	[Address(RVA = "0x15BD468", Offset = "0x15BD468", VA = "0x15BD468")]
	public OverworldMainButton()
	{
	}
}
