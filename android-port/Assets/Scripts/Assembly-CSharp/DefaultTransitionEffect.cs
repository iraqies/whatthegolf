using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B93")]
public class DefaultTransitionEffect : BaseTransitionEffect
{
	[Serializable]
	[Token(Token = "0x2000B94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43AF0", Offset = "0x43AF0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004084")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004085")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__14_0;

		[Token(Token = "0x4004086")]
		[FieldOffset(Offset = "0x10")]
		public static Action<AudioSource> _003C_003E9__16_0;

		[Token(Token = "0x60037E7")]
		[Address(RVA = "0x179A06C", Offset = "0x179A06C", VA = "0x179A06C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x179A074", Offset = "0x179A074", VA = "0x179A074")]
		internal void _003CBegin_003Eb__14_0(AudioSource s)
		{
		}

		[Token(Token = "0x60037E9")]
		[Address(RVA = "0x179A0C4", Offset = "0x179A0C4", VA = "0x179A0C4")]
		internal void _003CEnd_003Eb__16_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x2000B95")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43B00", Offset = "0x43B00")]
	private sealed class _003CBegin_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004087")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004088")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004089")]
		[FieldOffset(Offset = "0x20")]
		public DefaultTransitionEffect _003C_003E4__this;

		[Token(Token = "0x170005D9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60037ED")]
			[Address(RVA = "0x179A364", Offset = "0x179A364", VA = "0x179A364", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005DA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60037EF")]
			[Address(RVA = "0x179A3AC", Offset = "0x179A3AC", VA = "0x179A3AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60037EA")]
		[Address(RVA = "0x179A114", Offset = "0x179A114", VA = "0x179A114")]
		[DebuggerHidden]
		public _003CBegin_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60037EB")]
		[Address(RVA = "0x179A140", Offset = "0x179A140", VA = "0x179A140", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60037EC")]
		[Address(RVA = "0x179A144", Offset = "0x179A144", VA = "0x179A144", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60037ED")]
		[Address(RVA = "0x179A364", Offset = "0x179A364", VA = "0x179A364", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60037EE")]
		[Address(RVA = "0x179A36C", Offset = "0x179A36C", VA = "0x179A36C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60037EF")]
		[Address(RVA = "0x179A3AC", Offset = "0x179A3AC", VA = "0x179A3AC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000B96")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43B10", Offset = "0x43B10")]
	private sealed class _003CEnd_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400408A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400408B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400408C")]
		[FieldOffset(Offset = "0x20")]
		public DefaultTransitionEffect _003C_003E4__this;

		[Token(Token = "0x400408D")]
		[FieldOffset(Offset = "0x28")]
		public float overrideTransitionDuration;

		[Token(Token = "0x170005DB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60037F3")]
			[Address(RVA = "0x179A6A4", Offset = "0x179A6A4", VA = "0x179A6A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005DC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60037F5")]
			[Address(RVA = "0x179A6EC", Offset = "0x179A6EC", VA = "0x179A6EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x179A3B4", Offset = "0x179A3B4", VA = "0x179A3B4")]
		[DebuggerHidden]
		public _003CEnd_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x179A3E0", Offset = "0x179A3E0", VA = "0x179A3E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60037F2")]
		[Address(RVA = "0x179A3E4", Offset = "0x179A3E4", VA = "0x179A3E4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60037F3")]
		[Address(RVA = "0x179A6A4", Offset = "0x179A6A4", VA = "0x179A6A4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60037F4")]
		[Address(RVA = "0x179A6AC", Offset = "0x179A6AC", VA = "0x179A6AC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60037F5")]
		[Address(RVA = "0x179A6EC", Offset = "0x179A6EC", VA = "0x179A6EC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004078")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform circleTransform;

	[Token(Token = "0x4004079")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MeshRenderer circleRenderer;

	[Token(Token = "0x400407A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform endCircleTransform;

	[Token(Token = "0x400407B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private MeshRenderer endCircleRenderer;

	[Token(Token = "0x400407C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<AudioClip> transitionClips;

	[Token(Token = "0x400407D")]
	[FieldOffset(Offset = "0x40")]
	private Material bgMaterial;

	[Token(Token = "0x400407E")]
	[FieldOffset(Offset = "0x48")]
	private Color defaultBgColor;

	[Token(Token = "0x400407F")]
	private const float transitionInDuration = 0.4f;

	[Token(Token = "0x4004080")]
	private const float transitionOutDuration = 0.4f;

	[Token(Token = "0x4004081")]
	private const float circleMaxScale = 0.006939388f;

	[Token(Token = "0x4004082")]
	private const float endCircleMinScale = 0.002055002f;

	[Token(Token = "0x4004083")]
	private const float endCircleMaxScale = 0.5123225f;

	[Token(Token = "0x60037DD")]
	[Address(RVA = "0x18D8270", Offset = "0x18D8270", VA = "0x18D8270", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x60037DE")]
	[Address(RVA = "0x18D8360", Offset = "0x18D8360", VA = "0x18D8360", Slot = "7")]
	public override void PreBegin(Color? color)
	{
	}

	[Token(Token = "0x60037DF")]
	[Address(RVA = "0x18D8438", Offset = "0x18D8438", VA = "0x18D8438", Slot = "4")]
	public override IEnumerator Begin()
	{
		return null;
	}

	[Token(Token = "0x60037E0")]
	[Address(RVA = "0x18D84AC", Offset = "0x18D84AC", VA = "0x18D84AC", Slot = "8")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x60037E1")]
	[Address(RVA = "0x18D84F0", Offset = "0x18D84F0", VA = "0x18D84F0", Slot = "5")]
	public override IEnumerator End(float overrideTransitionDuration = 0f)
	{
		return null;
	}

	[Token(Token = "0x60037E2")]
	[Address(RVA = "0x18D8574", Offset = "0x18D8574", VA = "0x18D8574", Slot = "9")]
	public override void InstantTransitionCover(Color? color)
	{
	}

	[Token(Token = "0x60037E3")]
	[Address(RVA = "0x18D8664", Offset = "0x18D8664", VA = "0x18D8664")]
	public DefaultTransitionEffect()
	{
	}

	[Token(Token = "0x60037E4")]
	[Address(RVA = "0x18D866C", Offset = "0x18D866C", VA = "0x18D866C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AD1C", Offset = "0x6AD1C")]
	private void _003CBegin_003Eb__14_1(float t)
	{
	}

	[Token(Token = "0x60037E5")]
	[Address(RVA = "0x18D86D4", Offset = "0x18D86D4", VA = "0x18D86D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AD2C", Offset = "0x6AD2C")]
	private void _003CEnd_003Eb__16_1(float t)
	{
	}
}
