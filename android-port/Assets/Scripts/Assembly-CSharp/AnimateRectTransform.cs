using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000EC2")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x452F0", Offset = "0x452F0")]
public class AnimateRectTransform : MonoBehaviour
{
	[Token(Token = "0x2000EC3")]
	public enum Property
	{
		[Token(Token = "0x4004FD8")]
		sizeDelta = 0,
		[Token(Token = "0x4004FD9")]
		position = 1,
		[Token(Token = "0x4004FDA")]
		scale = 2,
		[Token(Token = "0x4004FDB")]
		color = 3
	}

	[Serializable]
	[Token(Token = "0x2000EC4")]
	public struct TransitionType
	{
		[Token(Token = "0x4004FDC")]
		[FieldOffset(Offset = "0x0")]
		public float duration;

		[Token(Token = "0x4004FDD")]
		[FieldOffset(Offset = "0x4")]
		public EasingFunction.Ease ease;

		[Token(Token = "0x4004FDE")]
		[FieldOffset(Offset = "0x8")]
		public Property prop;

		[Token(Token = "0x4004FDF")]
		[FieldOffset(Offset = "0x10")]
		public Graphic overrideColorGraphic;
	}

	[Serializable]
	[Token(Token = "0x2000EC5")]
	[SerializeField]
	public struct RectState
	{
		[Token(Token = "0x4004FE0")]
		[FieldOffset(Offset = "0x0")]
		public bool useSize;

		[Token(Token = "0x4004FE1")]
		[FieldOffset(Offset = "0x4")]
		public Vector2 sizeDelta;

		[Token(Token = "0x4004FE2")]
		[FieldOffset(Offset = "0xC")]
		public bool useScale;

		[Token(Token = "0x4004FE3")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 scale;

		[Token(Token = "0x4004FE4")]
		[FieldOffset(Offset = "0x18")]
		public bool usePos;

		[Token(Token = "0x4004FE5")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 anchoredPos;

		[Token(Token = "0x4004FE6")]
		[FieldOffset(Offset = "0x24")]
		public bool useColor;

		[Token(Token = "0x4004FE7")]
		[FieldOffset(Offset = "0x28")]
		public Color color;
	}

	[Token(Token = "0x2000EC6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45368", Offset = "0x45368")]
	private sealed class _003CAlternateAfter_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004FE8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004FE9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004FEA")]
		[FieldOffset(Offset = "0x20")]
		public float a;

		[Token(Token = "0x4004FEB")]
		[FieldOffset(Offset = "0x28")]
		public AnimateRectTransform _003C_003E4__this;

		[Token(Token = "0x1700071E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004501")]
			[Address(RVA = "0x176BE14", Offset = "0x176BE14", VA = "0x176BE14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700071F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004503")]
			[Address(RVA = "0x176BE5C", Offset = "0x176BE5C", VA = "0x176BE5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60044FE")]
		[Address(RVA = "0x176BD28", Offset = "0x176BD28", VA = "0x176BD28")]
		[DebuggerHidden]
		public _003CAlternateAfter_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60044FF")]
		[Address(RVA = "0x176BD54", Offset = "0x176BD54", VA = "0x176BD54", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004500")]
		[Address(RVA = "0x176BD58", Offset = "0x176BD58", VA = "0x176BD58", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004501")]
		[Address(RVA = "0x176BE14", Offset = "0x176BE14", VA = "0x176BE14", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004502")]
		[Address(RVA = "0x176BE1C", Offset = "0x176BE1C", VA = "0x176BE1C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004503")]
		[Address(RVA = "0x176BE5C", Offset = "0x176BE5C", VA = "0x176BE5C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EC7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45378", Offset = "0x45378")]
	private sealed class _003CDeactiveAfter_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004FEC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004FED")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004FEE")]
		[FieldOffset(Offset = "0x20")]
		public float t;

		[Token(Token = "0x4004FEF")]
		[FieldOffset(Offset = "0x28")]
		public AnimateRectTransform _003C_003E4__this;

		[Token(Token = "0x17000720")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004507")]
			[Address(RVA = "0x176C348", Offset = "0x176C348", VA = "0x176C348", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000721")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004509")]
			[Address(RVA = "0x176C390", Offset = "0x176C390", VA = "0x176C390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004504")]
		[Address(RVA = "0x176C25C", Offset = "0x176C25C", VA = "0x176C25C")]
		[DebuggerHidden]
		public _003CDeactiveAfter_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004505")]
		[Address(RVA = "0x176C288", Offset = "0x176C288", VA = "0x176C288", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004506")]
		[Address(RVA = "0x176C28C", Offset = "0x176C28C", VA = "0x176C28C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004507")]
		[Address(RVA = "0x176C348", Offset = "0x176C348", VA = "0x176C348", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004508")]
		[Address(RVA = "0x176C350", Offset = "0x176C350", VA = "0x176C350", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004509")]
		[Address(RVA = "0x176C390", Offset = "0x176C390", VA = "0x176C390", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45388", Offset = "0x45388")]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x4004FF0")]
		[FieldOffset(Offset = "0x10")]
		public Property p;

		[Token(Token = "0x600450A")]
		[Address(RVA = "0x176BA54", Offset = "0x176BA54", VA = "0x176BA54")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x600450B")]
		[Address(RVA = "0x176BA5C", Offset = "0x176BA5C", VA = "0x176BA5C")]
		internal bool _003CGetTransitionLength_003Eb__0(TransitionType t)
		{
			return default;
		}
	}

	[Token(Token = "0x2000EC9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45398", Offset = "0x45398")]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x4004FF1")]
		[FieldOffset(Offset = "0x10")]
		public AnimateRectTransform _003C_003E4__this;

		[Token(Token = "0x4004FF2")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 end;

		[Token(Token = "0x4004FF3")]
		[FieldOffset(Offset = "0x20")]
		public TransitionType transition;

		[Token(Token = "0x4004FF4")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 start;

		[Token(Token = "0x600450C")]
		[Address(RVA = "0x176BA70", Offset = "0x176BA70", VA = "0x176BA70")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x600450D")]
		[Address(RVA = "0x176BA78", Offset = "0x176BA78", VA = "0x176BA78")]
		internal void _003CSetProp_003Eb__0(float t)
		{
		}

		[Token(Token = "0x600450E")]
		[Address(RVA = "0x176BB18", Offset = "0x176BB18", VA = "0x176BB18")]
		internal void _003CSetProp_003Eb__1(float t)
		{
		}

		[Token(Token = "0x600450F")]
		[Address(RVA = "0x176BBB8", Offset = "0x176BBB8", VA = "0x176BBB8")]
		internal void _003CSetProp_003Eb__2(float t)
		{
		}
	}

	[Token(Token = "0x2000ECA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x453A8", Offset = "0x453A8")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4004FF5")]
		[FieldOffset(Offset = "0x10")]
		public Graphic i;

		[Token(Token = "0x4004FF6")]
		[FieldOffset(Offset = "0x18")]
		public Color startA;

		[Token(Token = "0x4004FF7")]
		[FieldOffset(Offset = "0x28")]
		public Color endA;

		[Token(Token = "0x4004FF8")]
		[FieldOffset(Offset = "0x38")]
		public TransitionType transition;

		[Token(Token = "0x6004510")]
		[Address(RVA = "0x176BC5C", Offset = "0x176BC5C", VA = "0x176BC5C")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6004511")]
		[Address(RVA = "0x176BC64", Offset = "0x176BC64", VA = "0x176BC64")]
		internal void _003CSetProp_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000ECB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x453B8", Offset = "0x453B8")]
	private sealed class _003CAlternateCR_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004FF9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004FFA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004FFB")]
		[FieldOffset(Offset = "0x20")]
		public AnimateRectTransform _003C_003E4__this;

		[Token(Token = "0x4004FFC")]
		[FieldOffset(Offset = "0x28")]
		private List<RectState>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17000722")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004516")]
			[Address(RVA = "0x176C20C", Offset = "0x176C20C", VA = "0x176C20C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000723")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004518")]
			[Address(RVA = "0x176C254", Offset = "0x176C254", VA = "0x176C254", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004512")]
		[Address(RVA = "0x176BE64", Offset = "0x176BE64", VA = "0x176BE64")]
		[DebuggerHidden]
		public _003CAlternateCR_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004513")]
		[Address(RVA = "0x176BE90", Offset = "0x176BE90", VA = "0x176BE90", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004514")]
		[Address(RVA = "0x176BF64", Offset = "0x176BF64", VA = "0x176BF64", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004515")]
		[Address(RVA = "0x176BF08", Offset = "0x176BF08", VA = "0x176BF08")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6004516")]
		[Address(RVA = "0x176C20C", Offset = "0x176C20C", VA = "0x176C20C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004517")]
		[Address(RVA = "0x176C214", Offset = "0x176C214", VA = "0x176C214", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004518")]
		[Address(RVA = "0x176C254", Offset = "0x176C254", VA = "0x176C254", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004FCF")]
	[FieldOffset(Offset = "0x18")]
	public bool disableOnHide;

	[Token(Token = "0x4004FD0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<TransitionType> overrideTransition;

	[Token(Token = "0x4004FD1")]
	[FieldOffset(Offset = "0x28")]
	private TransitionType defaultT;

	[Token(Token = "0x4004FD2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public RectState HideState;

	[Token(Token = "0x4004FD3")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private RectState ShowState;

	[Token(Token = "0x4004FD4")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private bool alternate;

	[Token(Token = "0x4004FD5")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private List<RectState> AlternateStates;

	[Token(Token = "0x4004FD6")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private RectTransform overrideRectTransform;

	[Token(Token = "0x1700071D")]
	private RectTransform RectTransform
	{
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0x1416A44", Offset = "0x1416A44", VA = "0x1416A44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60044ED")]
	[Address(RVA = "0x141698C", Offset = "0x141698C", VA = "0x141698C")]
	private Graphic Graphic(TransitionType transitionType)
	{
		return null;
	}

	[Token(Token = "0x60044EF")]
	[Address(RVA = "0x1416B14", Offset = "0x1416B14", VA = "0x1416B14")]
	public float SetShow(bool s, bool instant = false)
	{
		return default;
	}

	[Token(Token = "0x60044F0")]
	[Address(RVA = "0x1416D1C", Offset = "0x1416D1C", VA = "0x1416D1C")]
	private void Deactivate()
	{
	}

	[Token(Token = "0x60044F1")]
	[Address(RVA = "0x1416D58", Offset = "0x1416D58", VA = "0x1416D58")]
	public float Show()
	{
		return default;
	}

	[Token(Token = "0x60044F2")]
	[Address(RVA = "0x14171EC", Offset = "0x14171EC", VA = "0x14171EC")]
	private IEnumerator AlternateAfter(float a)
	{
		return null;
	}

	[Token(Token = "0x60044F3")]
	[Address(RVA = "0x1416F08", Offset = "0x1416F08", VA = "0x1416F08")]
	public float Hide()
	{
		return default;
	}

	[Token(Token = "0x60044F4")]
	[Address(RVA = "0x141703C", Offset = "0x141703C", VA = "0x141703C")]
	private void SetProps(RectState s)
	{
	}

	[Token(Token = "0x60044F5")]
	[Address(RVA = "0x1416BE0", Offset = "0x1416BE0", VA = "0x1416BE0")]
	private void SetInstant(RectState s)
	{
	}

	[Token(Token = "0x60044F6")]
	[Address(RVA = "0x1417270", Offset = "0x1417270", VA = "0x1417270")]
	private IEnumerator DeactiveAfter(float t)
	{
		return null;
	}

	[Token(Token = "0x60044F7")]
	[Address(RVA = "0x14170E0", Offset = "0x14170E0", VA = "0x14170E0")]
	public float GetLongestTransition(RectState s)
	{
		return default;
	}

	[Token(Token = "0x60044F8")]
	[Address(RVA = "0x14177C0", Offset = "0x14177C0", VA = "0x14177C0")]
	private TransitionType GetTransitionLength(Property p)
	{
		return default;
	}

	[Token(Token = "0x60044F9")]
	[Address(RVA = "0x1417580", Offset = "0x1417580", VA = "0x1417580")]
	private void SetProp(Property p, Vector2 end)
	{
	}

	[Token(Token = "0x60044FA")]
	[Address(RVA = "0x14172F4", Offset = "0x14172F4", VA = "0x14172F4")]
	private void SetProp(Property p, Color c)
	{
	}

	[Token(Token = "0x60044FB")]
	[Address(RVA = "0x1417920", Offset = "0x1417920", VA = "0x1417920")]
	private void Alternate()
	{
	}

	[Token(Token = "0x60044FC")]
	[Address(RVA = "0x141799C", Offset = "0x141799C", VA = "0x141799C")]
	private IEnumerator AlternateCR()
	{
		return null;
	}

	[Token(Token = "0x60044FD")]
	[Address(RVA = "0x1417A10", Offset = "0x1417A10", VA = "0x1417A10")]
	public AnimateRectTransform()
	{
	}
}
