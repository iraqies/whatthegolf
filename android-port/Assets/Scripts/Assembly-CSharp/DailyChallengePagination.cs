using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EE6")]
public class DailyChallengePagination : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000EE7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45520", Offset = "0x45520")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400507A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400507B")]
		[FieldOffset(Offset = "0x8")]
		public static Action<SVGImage> _003C_003E9__5_0;

		[Token(Token = "0x400507C")]
		[FieldOffset(Offset = "0x10")]
		public static Action<SVGImage> _003C_003E9__5_1;

		[Token(Token = "0x400507D")]
		[FieldOffset(Offset = "0x18")]
		public static Action<SVGImage> _003C_003E9__5_2;

		[Token(Token = "0x60045A0")]
		[Address(RVA = "0x1797150", Offset = "0x1797150", VA = "0x1797150")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60045A1")]
		[Address(RVA = "0x1797158", Offset = "0x1797158", VA = "0x1797158")]
		internal void _003CEnable_003Eb__5_0(SVGImage i)
		{
		}

		[Token(Token = "0x60045A2")]
		[Address(RVA = "0x1797188", Offset = "0x1797188", VA = "0x1797188")]
		internal void _003CEnable_003Eb__5_1(SVGImage i)
		{
		}

		[Token(Token = "0x60045A3")]
		[Address(RVA = "0x17971B8", Offset = "0x17971B8", VA = "0x17971B8")]
		internal void _003CEnable_003Eb__5_2(SVGImage i)
		{
		}
	}

	[Token(Token = "0x2000EE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45530", Offset = "0x45530")]
	private sealed class _003CShowBar_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400507E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400507F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005080")]
		[FieldOffset(Offset = "0x20")]
		public DailyChallengePagination _003C_003E4__this;

		[Token(Token = "0x4005081")]
		[FieldOffset(Offset = "0x28")]
		private List<SVGImage>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x1700073E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60045A8")]
			[Address(RVA = "0x17979B8", Offset = "0x17979B8", VA = "0x17979B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700073F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60045AA")]
			[Address(RVA = "0x1797A00", Offset = "0x1797A00", VA = "0x1797A00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60045A4")]
		[Address(RVA = "0x17975D4", Offset = "0x17975D4", VA = "0x17975D4")]
		[DebuggerHidden]
		public _003CShowBar_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60045A5")]
		[Address(RVA = "0x1797600", Offset = "0x1797600", VA = "0x1797600", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x17976D4", Offset = "0x17976D4", VA = "0x17976D4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60045A7")]
		[Address(RVA = "0x1797678", Offset = "0x1797678", VA = "0x1797678")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60045A8")]
		[Address(RVA = "0x17979B8", Offset = "0x17979B8", VA = "0x17979B8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60045A9")]
		[Address(RVA = "0x17979C0", Offset = "0x17979C0", VA = "0x17979C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60045AA")]
		[Address(RVA = "0x1797A00", Offset = "0x1797A00", VA = "0x1797A00", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EE9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45540", Offset = "0x45540")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4005082")]
		[FieldOffset(Offset = "0x10")]
		public SVGImage svg;

		[Token(Token = "0x4005083")]
		[FieldOffset(Offset = "0x18")]
		public DailyChallengePagination _003C_003E4__this;

		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x17971F4", Offset = "0x17971F4", VA = "0x17971F4")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60045AC")]
		[Address(RVA = "0x17971FC", Offset = "0x17971FC", VA = "0x17971FC")]
		internal void _003CActivateIconCR_003Eb__0(float t)
		{
		}

		[Token(Token = "0x60045AD")]
		[Address(RVA = "0x1797260", Offset = "0x1797260", VA = "0x1797260")]
		internal void _003CActivateIconCR_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000EEA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45550", Offset = "0x45550")]
	private sealed class _003CActivateIconCR_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005084")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005085")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005086")]
		[FieldOffset(Offset = "0x20")]
		public SVGImage svg;

		[Token(Token = "0x4005087")]
		[FieldOffset(Offset = "0x28")]
		public DailyChallengePagination _003C_003E4__this;

		[Token(Token = "0x4005088")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		[Token(Token = "0x17000740")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60045B1")]
			[Address(RVA = "0x1797584", Offset = "0x1797584", VA = "0x1797584", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000741")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60045B3")]
			[Address(RVA = "0x17975CC", Offset = "0x17975CC", VA = "0x17975CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60045AE")]
		[Address(RVA = "0x1797328", Offset = "0x1797328", VA = "0x1797328")]
		[DebuggerHidden]
		public _003CActivateIconCR_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60045AF")]
		[Address(RVA = "0x1797354", Offset = "0x1797354", VA = "0x1797354", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60045B0")]
		[Address(RVA = "0x1797358", Offset = "0x1797358", VA = "0x1797358", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60045B1")]
		[Address(RVA = "0x1797584", Offset = "0x1797584", VA = "0x1797584", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60045B2")]
		[Address(RVA = "0x179758C", Offset = "0x179758C", VA = "0x179758C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x17975CC", Offset = "0x17975CC", VA = "0x17975CC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EEB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45560", Offset = "0x45560")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4005089")]
		[FieldOffset(Offset = "0x10")]
		public SVGImage img;

		[Token(Token = "0x400508A")]
		[FieldOffset(Offset = "0x18")]
		public Color p_c;

		[Token(Token = "0x400508B")]
		[FieldOffset(Offset = "0x28")]
		public Color c;

		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x17972C4", Offset = "0x17972C4", VA = "0x17972C4")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x17972CC", Offset = "0x17972CC", VA = "0x17972CC")]
		internal void _003CTweenColor_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4005075")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<SVGImage> icons;

	[Token(Token = "0x4005076")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimateRectTransform container;

	[Token(Token = "0x4005077")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Color on;

	[Token(Token = "0x4005078")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Color off;

	[Token(Token = "0x4005079")]
	[FieldOffset(Offset = "0x48")]
	private Coroutine ShowBarRoutine;

	[Token(Token = "0x6004594")]
	[Address(RVA = "0x18CB41C", Offset = "0x18CB41C", VA = "0x18CB41C")]
	public void Enable(int numberOfLevels)
	{
	}

	[Token(Token = "0x6004595")]
	[Address(RVA = "0x18CC8B0", Offset = "0x18CC8B0", VA = "0x18CC8B0")]
	private IEnumerator ShowBar()
	{
		return null;
	}

	[Token(Token = "0x6004596")]
	[Address(RVA = "0x18CB7FC", Offset = "0x18CB7FC", VA = "0x18CB7FC")]
	public void Disable()
	{
	}

	[Token(Token = "0x6004597")]
	[Address(RVA = "0x18CC924", Offset = "0x18CC924", VA = "0x18CC924")]
	public void DisableInstantly()
	{
	}

	[Token(Token = "0x6004598")]
	[Address(RVA = "0x18CC970", Offset = "0x18CC970", VA = "0x18CC970")]
	private void Start()
	{
	}

	[Token(Token = "0x6004599")]
	[Address(RVA = "0x18CC994", Offset = "0x18CC994", VA = "0x18CC994")]
	private void SetIcons()
	{
	}

	[Token(Token = "0x600459A")]
	[Address(RVA = "0x18CB898", Offset = "0x18CB898", VA = "0x18CB898")]
	public void CompleteIcon(int i)
	{
	}

	[Token(Token = "0x600459B")]
	[Address(RVA = "0x18CB9D0", Offset = "0x18CB9D0", VA = "0x18CB9D0")]
	public void ActivateIcon(int i)
	{
	}

	[Token(Token = "0x600459C")]
	[Address(RVA = "0x18CCAEC", Offset = "0x18CCAEC", VA = "0x18CCAEC")]
	private IEnumerator ActivateIconCR(SVGImage svg)
	{
		return null;
	}

	[Token(Token = "0x600459D")]
	[Address(RVA = "0x18CC99C", Offset = "0x18CC99C", VA = "0x18CC99C")]
	private void TweenColor(SVGImage img, Color c, float duration = 1f)
	{
	}

	[Token(Token = "0x600459E")]
	[Address(RVA = "0x18CCB64", Offset = "0x18CCB64", VA = "0x18CCB64")]
	public DailyChallengePagination()
	{
	}
}
