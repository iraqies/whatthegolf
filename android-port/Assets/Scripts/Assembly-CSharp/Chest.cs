using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Audio.Rumble;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000961")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x42280", Offset = "0x42280")]
public class Chest : MonoBehaviour
{
	[Token(Token = "0x2000962")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x422E8", Offset = "0x422E8")]
	private sealed class _003COpenChestInstantly_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400338E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400338F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003390")]
		[FieldOffset(Offset = "0x20")]
		public Chest _003C_003E4__this;

		[Token(Token = "0x1700048A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002BC4")]
			[Address(RVA = "0x17855EC", Offset = "0x17855EC", VA = "0x17855EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700048B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BC6")]
			[Address(RVA = "0x1785634", Offset = "0x1785634", VA = "0x1785634", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002BC1")]
		[Address(RVA = "0x17854C4", Offset = "0x17854C4", VA = "0x17854C4")]
		[DebuggerHidden]
		public _003COpenChestInstantly_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002BC2")]
		[Address(RVA = "0x17854F0", Offset = "0x17854F0", VA = "0x17854F0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002BC3")]
		[Address(RVA = "0x17854F4", Offset = "0x17854F4", VA = "0x17854F4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0x17855EC", Offset = "0x17855EC", VA = "0x17855EC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BC5")]
		[Address(RVA = "0x17855F4", Offset = "0x17855F4", VA = "0x17855F4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002BC6")]
		[Address(RVA = "0x1785634", Offset = "0x1785634", VA = "0x1785634", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000963")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x422F8", Offset = "0x422F8")]
	private sealed class _003COpenChestRoutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003391")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003392")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003393")]
		[FieldOffset(Offset = "0x20")]
		public Chest _003C_003E4__this;

		[Token(Token = "0x1700048C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002BCA")]
			[Address(RVA = "0x1785924", Offset = "0x1785924", VA = "0x1785924", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700048D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BCC")]
			[Address(RVA = "0x178596C", Offset = "0x178596C", VA = "0x178596C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002BC7")]
		[Address(RVA = "0x178563C", Offset = "0x178563C", VA = "0x178563C")]
		[DebuggerHidden]
		public _003COpenChestRoutine_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002BC8")]
		[Address(RVA = "0x1785668", Offset = "0x1785668", VA = "0x1785668", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002BC9")]
		[Address(RVA = "0x178566C", Offset = "0x178566C", VA = "0x178566C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0x1785924", Offset = "0x1785924", VA = "0x1785924", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0x178592C", Offset = "0x178592C", VA = "0x178592C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0x178596C", Offset = "0x178596C", VA = "0x178596C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400337F")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FBAC", Offset = "0x4FBAC")]
	private Action<Chest> m_OnPreChestOpen;

	[Token(Token = "0x4003380")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FBBC", Offset = "0x4FBBC")]
	private Action<Chest> m_OnPostChestOpen;

	[Token(Token = "0x4003381")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FBCC", Offset = "0x4FBCC")]
	private Action<Chest> m_OnInstantChestOpen;

	[Token(Token = "0x4003382")]
	[FieldOffset(Offset = "0x30")]
	public Sprite popupSprite;

	[Token(Token = "0x4003383")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer ItemSpriteRenderer;

	[Token(Token = "0x4003384")]
	[FieldOffset(Offset = "0x40")]
	public float ItemScaleOverride;

	[Token(Token = "0x4003385")]
	[FieldOffset(Offset = "0x48")]
	public ClipSettingsCollection sfxOnOpen;

	[Token(Token = "0x4003386")]
	[FieldOffset(Offset = "0x50")]
	private OverworldID id;

	[Token(Token = "0x4003387")]
	[FieldOffset(Offset = "0x58")]
	private bool didInit;

	[Token(Token = "0x4003388")]
	[FieldOffset(Offset = "0x59")]
	private bool isUnlocked;

	[Token(Token = "0x4003389")]
	[FieldOffset(Offset = "0x60")]
	private Animator anim;

	[Token(Token = "0x400338A")]
	[FieldOffset(Offset = "0x68")]
	public Transform PortalTransform;

	[Token(Token = "0x400338B")]
	[FieldOffset(Offset = "0x70")]
	public ParticleSystem PortalParticles;

	[Token(Token = "0x400338C")]
	[FieldOffset(Offset = "0x78")]
	private Transform playerBall;

	[Token(Token = "0x400338D")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private RumbleEventAsset rumbleEventAssetChestOpen;

	[Token(Token = "0x1400003A")]
	public event Action<Chest> OnPreChestOpen
	{
		[Token(Token = "0x6002BB4")]
		[Address(RVA = "0x189ACE8", Offset = "0x189ACE8", VA = "0x189ACE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67BA4", Offset = "0x67BA4")]
		add
		{
		}
		[Token(Token = "0x6002BB5")]
		[Address(RVA = "0x189AD8C", Offset = "0x189AD8C", VA = "0x189AD8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67BB4", Offset = "0x67BB4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400003B")]
	public event Action<Chest> OnPostChestOpen
	{
		[Token(Token = "0x6002BB6")]
		[Address(RVA = "0x189AE30", Offset = "0x189AE30", VA = "0x189AE30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67BC4", Offset = "0x67BC4")]
		add
		{
		}
		[Token(Token = "0x6002BB7")]
		[Address(RVA = "0x189AED4", Offset = "0x189AED4", VA = "0x189AED4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67BD4", Offset = "0x67BD4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400003C")]
	public event Action<Chest> OnInstantChestOpen
	{
		[Token(Token = "0x6002BB8")]
		[Address(RVA = "0x189AF78", Offset = "0x189AF78", VA = "0x189AF78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67BE4", Offset = "0x67BE4")]
		add
		{
		}
		[Token(Token = "0x6002BB9")]
		[Address(RVA = "0x189B01C", Offset = "0x189B01C", VA = "0x189B01C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67BF4", Offset = "0x67BF4")]
		remove
		{
		}
	}

	[Token(Token = "0x6002BBA")]
	[Address(RVA = "0x189B0C0", Offset = "0x189B0C0", VA = "0x189B0C0")]
	public void Init()
	{
	}

	[Token(Token = "0x6002BBB")]
	[Address(RVA = "0x189B2D4", Offset = "0x189B2D4", VA = "0x189B2D4")]
	public bool IsUnlocked()
	{
		return default;
	}

	[Token(Token = "0x6002BBC")]
	[Address(RVA = "0x189B208", Offset = "0x189B208", VA = "0x189B208")]
	private void InstantOpen()
	{
	}

	[Token(Token = "0x6002BBD")]
	[Address(RVA = "0x189B2DC", Offset = "0x189B2DC", VA = "0x189B2DC")]
	private IEnumerator OpenChestInstantly()
	{
		return null;
	}

	[Token(Token = "0x6002BBE")]
	[Address(RVA = "0x189B350", Offset = "0x189B350", VA = "0x189B350")]
	private IEnumerator OpenChestRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002BBF")]
	[Address(RVA = "0x189B3C4", Offset = "0x189B3C4", VA = "0x189B3C4")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002BC0")]
	[Address(RVA = "0x189B5F4", Offset = "0x189B5F4", VA = "0x189B5F4")]
	public Chest()
	{
	}
}
