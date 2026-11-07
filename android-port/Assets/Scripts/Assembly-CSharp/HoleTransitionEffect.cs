using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000328")]
public class HoleTransitionEffect : BaseTransitionEffect
{
	[Token(Token = "0x2000329")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EFF0", Offset = "0x3EFF0")]
	private sealed class _003CBegin_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001192")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001193")]
		[FieldOffset(Offset = "0x20")]
		public HoleTransitionEffect _003C_003E4__this;

		[Token(Token = "0x170001B7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000E9A")]
			[Address(RVA = "0x17BEBC8", Offset = "0x17BEBC8", VA = "0x17BEBC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001B8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000E9C")]
			[Address(RVA = "0x17BEC10", Offset = "0x17BEC10", VA = "0x17BEC10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x17BEAE4", Offset = "0x17BEAE4", VA = "0x17BEAE4")]
		[DebuggerHidden]
		public _003CBegin_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x17BEB10", Offset = "0x17BEB10", VA = "0x17BEB10", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x17BEB14", Offset = "0x17BEB14", VA = "0x17BEB14", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x17BEBC8", Offset = "0x17BEBC8", VA = "0x17BEBC8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x17BEBD0", Offset = "0x17BEBD0", VA = "0x17BEBD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x17BEC10", Offset = "0x17BEC10", VA = "0x17BEC10", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200032A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F000", Offset = "0x3F000")]
	private sealed class _003CEnd_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001194")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001195")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001196")]
		[FieldOffset(Offset = "0x20")]
		public HoleTransitionEffect _003C_003E4__this;

		[Token(Token = "0x4001197")]
		[FieldOffset(Offset = "0x28")]
		public float overrideTransitionDuration;

		[Token(Token = "0x170001B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000EA0")]
			[Address(RVA = "0x17BEDA4", Offset = "0x17BEDA4", VA = "0x17BEDA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000EA2")]
			[Address(RVA = "0x17BEDEC", Offset = "0x17BEDEC", VA = "0x17BEDEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x17BEC18", Offset = "0x17BEC18", VA = "0x17BEC18")]
		[DebuggerHidden]
		public _003CEnd_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x17BEC44", Offset = "0x17BEC44", VA = "0x17BEC44", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x17BEC48", Offset = "0x17BEC48", VA = "0x17BEC48", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x17BEDA4", Offset = "0x17BEDA4", VA = "0x17BEDA4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x17BEDAC", Offset = "0x17BEDAC", VA = "0x17BEDAC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x17BEDEC", Offset = "0x17BEDEC", VA = "0x17BEDEC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200032B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F010", Offset = "0x3F010")]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x4001198")]
		[FieldOffset(Offset = "0x10")]
		public Renderer b;

		[Token(Token = "0x4001199")]
		[FieldOffset(Offset = "0x18")]
		public HoleTransitionEffect _003C_003E4__this;

		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x17BEA34", Offset = "0x17BEA34", VA = "0x17BEA34")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x17BEA3C", Offset = "0x17BEA3C", VA = "0x17BEA3C")]
		internal void _003CFromTo_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200032C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F020", Offset = "0x3F020")]
	private sealed class _003CFromTo_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400119A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400119B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400119C")]
		[FieldOffset(Offset = "0x20")]
		public HoleTransitionEffect _003C_003E4__this;

		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170001BB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000EA8")]
			[Address(RVA = "0x17BF004", Offset = "0x17BF004", VA = "0x17BF004", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001BC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000EAA")]
			[Address(RVA = "0x17BF04C", Offset = "0x17BF04C", VA = "0x17BF04C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x17BEDF4", Offset = "0x17BEDF4", VA = "0x17BEDF4")]
		[DebuggerHidden]
		public _003CFromTo_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x17BEE20", Offset = "0x17BEE20", VA = "0x17BEE20", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x17BEE24", Offset = "0x17BEE24", VA = "0x17BEE24", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x17BF004", Offset = "0x17BF004", VA = "0x17BF004", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x17BF00C", Offset = "0x17BF00C", VA = "0x17BF00C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x17BF04C", Offset = "0x17BF04C", VA = "0x17BF04C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001184")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Renderer CirclePrefab;

	[Token(Token = "0x4001185")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Color> colors;

	[Token(Token = "0x4001186")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Renderer EndCircle;

	[Token(Token = "0x4001187")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform Mask;

	[Token(Token = "0x4001188")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve curve;

	[Token(Token = "0x4001189")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float durationIn;

	[Token(Token = "0x400118A")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float durationOut;

	[Token(Token = "0x400118B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int numRings;

	[Token(Token = "0x400118C")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float maxSizeMobile;

	[Token(Token = "0x400118D")]
	[FieldOffset(Offset = "0x50")]
	private float maxSizeDesktop;

	[Token(Token = "0x400118E")]
	[FieldOffset(Offset = "0x58")]
	private List<Renderer> Circles;

	[Token(Token = "0x400118F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ClipSettingsCollection transitionInClips;

	[Token(Token = "0x4001190")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ClipSettingsCollection transitionOutClips;

	[Token(Token = "0x170001B5")]
	[SerializeField]
	private float maxSize
	{
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x14D25DC", Offset = "0x14D25DC", VA = "0x14D25DC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170001B6")]
	private bool usePortrait
	{
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x14D2670", Offset = "0x14D2670", VA = "0x14D2670")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x14D26E4", Offset = "0x14D26E4", VA = "0x14D26E4")]
	private void SetAllRenders(bool b)
	{
	}

	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0x14D283C", Offset = "0x14D283C", VA = "0x14D283C", Slot = "6")]
	public override void Init()
	{
	}

	[Token(Token = "0x6000E8E")]
	[Address(RVA = "0x14D2A60", Offset = "0x14D2A60", VA = "0x14D2A60", Slot = "7")]
	public override void PreBegin(Color? color)
	{
	}

	[Token(Token = "0x6000E8F")]
	[Address(RVA = "0x14D2C08", Offset = "0x14D2C08", VA = "0x14D2C08", Slot = "4")]
	public override IEnumerator Begin()
	{
		return null;
	}

	[Token(Token = "0x6000E90")]
	[Address(RVA = "0x14D2C7C", Offset = "0x14D2C7C", VA = "0x14D2C7C", Slot = "8")]
	public override void CleanUp()
	{
	}

	[Token(Token = "0x6000E91")]
	[Address(RVA = "0x14D2CBC", Offset = "0x14D2CBC", VA = "0x14D2CBC", Slot = "5")]
	public override IEnumerator End(float overrideTransitionDuration = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000E92")]
	[Address(RVA = "0x14D2D40", Offset = "0x14D2D40", VA = "0x14D2D40")]
	private IEnumerator FromTo(float from, float to)
	{
		return null;
	}

	[Token(Token = "0x6000E93")]
	[Address(RVA = "0x14D2DB4", Offset = "0x14D2DB4", VA = "0x14D2DB4", Slot = "9")]
	public override void InstantTransitionCover(Color? color)
	{
	}

	[Token(Token = "0x6000E94")]
	[Address(RVA = "0x14D3024", Offset = "0x14D3024", VA = "0x14D3024")]
	private float tc(float input)
	{
		return default;
	}

	[Token(Token = "0x6000E95")]
	[Address(RVA = "0x14D3040", Offset = "0x14D3040", VA = "0x14D3040")]
	public HoleTransitionEffect()
	{
	}

	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x14D30E4", Offset = "0x14D30E4", VA = "0x14D30E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60DDC", Offset = "0x60DDC")]
	private void _003CEnd_003Eb__22_0(float t)
	{
	}
}
