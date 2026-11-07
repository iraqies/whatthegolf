using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B9C")]
public class Transition : MonoBehaviour
{
	[Token(Token = "0x2000B9D")]
	public enum TransitionEffect
	{
		[Token(Token = "0x40040C6")]
		Default = 0,
		[Token(Token = "0x40040C7")]
		SportySports = 1,
		[Token(Token = "0x40040C8")]
		Snowy = 2,
		[Token(Token = "0x40040C9")]
		Hole = 3,
		[Token(Token = "0x40040CA")]
		Daily = 4,
		[Token(Token = "0x40040CB")]
		AmongUs = 5,
		[Token(Token = "0x40040CC")]
		Car = 6,
		[Token(Token = "0x40040CD")]
		SpecialDay = 7,
		[Token(Token = "0x40040CE")]
		Slime = 8,
		[Token(Token = "0x40040CF")]
		CustomPrefab = 9
	}

	[Token(Token = "0x2000B9E")]
	private enum State
	{
		[Token(Token = "0x40040D1")]
		Idle = 0,
		[Token(Token = "0x40040D2")]
		Start = 1,
		[Token(Token = "0x40040D3")]
		Loop = 2,
		[Token(Token = "0x40040D4")]
		End = 3
	}

	[Token(Token = "0x2000B9F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43B60", Offset = "0x43B60")]
	private sealed class _003CStartTransition_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40040D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40040D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40040D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transition _003C_003E4__this;

		[Token(Token = "0x40040D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string textId;

		[Token(Token = "0x40040D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool onTheSide;

		[Token(Token = "0x40040DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float delay;

		[Token(Token = "0x40040DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onDone;

		[Token(Token = "0x40040DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color? color;

		[Token(Token = "0x40040DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TransitionTextEffect textEffect;

		[Token(Token = "0x40040DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool showWaitAnimation;

		[Token(Token = "0x40040DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool isAsync;

		[Token(Token = "0x40040E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool showWaitingText;

		[Token(Token = "0x40040E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BaseTransitionEffect transitionEffect;

		[Token(Token = "0x40040E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Func<bool> allowEndWhen;

		[Token(Token = "0x170005E3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003820")]
			[Address(RVA = "0x186B564", Offset = "0x186B564", VA = "0x186B564", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005E4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003822")]
			[Address(RVA = "0x186B5AC", Offset = "0x186B5AC", VA = "0x186B5AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600381D")]
		[Address(RVA = "0x186B3E0", Offset = "0x186B3E0", VA = "0x186B3E0")]
		[DebuggerHidden]
		public _003CStartTransition_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600381E")]
		[Address(RVA = "0x186B40C", Offset = "0x186B40C", VA = "0x186B40C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600381F")]
		[Address(RVA = "0x186B410", Offset = "0x186B410", VA = "0x186B410", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003820")]
		[Address(RVA = "0x186B564", Offset = "0x186B564", VA = "0x186B564", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003821")]
		[Address(RVA = "0x186B56C", Offset = "0x186B56C", VA = "0x186B56C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003822")]
		[Address(RVA = "0x186B5AC", Offset = "0x186B5AC", VA = "0x186B5AC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000BA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43B70", Offset = "0x43B70")]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		[Token(Token = "0x40040E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transition _003C_003E4__this;

		[Token(Token = "0x40040E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> allowEndWhen;

		[Token(Token = "0x6003823")]
		[Address(RVA = "0x186AD00", Offset = "0x186AD00", VA = "0x186AD00")]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6003824")]
		[Address(RVA = "0x186AD08", Offset = "0x186AD08", VA = "0x186AD08")]
		internal void _003CStartTransitionInternalCR_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6003825")]
		[Address(RVA = "0x186ADA4", Offset = "0x186ADA4", VA = "0x186ADA4")]
		internal bool _003CStartTransitionInternalCR_003Eb__1()
		{
			return default;
		}

		[Token(Token = "0x6003826")]
		[Address(RVA = "0x186ADD0", Offset = "0x186ADD0", VA = "0x186ADD0")]
		internal bool _003CStartTransitionInternalCR_003Eb__2()
		{
			return default;
		}
	}

	[Token(Token = "0x2000BA1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43B80", Offset = "0x43B80")]
	private sealed class _003CStartTransitionInternalCR_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40040E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40040E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40040E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transition _003C_003E4__this;

		[Token(Token = "0x40040E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Func<bool> allowEndWhen;

		[Token(Token = "0x40040E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BaseTransitionEffect transitionEffect;

		[Token(Token = "0x40040EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color? color;

		[Token(Token = "0x40040EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool showWaitAnimation;

		[Token(Token = "0x40040EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool showWaitingText;

		[Token(Token = "0x40040ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string textId;

		[Token(Token = "0x40040EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TransitionTextEffect textEffect;

		[Token(Token = "0x40040EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool onTheSide;

		[Token(Token = "0x40040F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float delay;

		[Token(Token = "0x40040F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

		[Token(Token = "0x40040F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Action onDone;

		[Token(Token = "0x170005E5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600382A")]
			[Address(RVA = "0x186BCCC", Offset = "0x186BCCC", VA = "0x186BCCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005E6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600382C")]
			[Address(RVA = "0x186BD14", Offset = "0x186BD14", VA = "0x186BD14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003827")]
		[Address(RVA = "0x186B5B4", Offset = "0x186B5B4", VA = "0x186B5B4")]
		[DebuggerHidden]
		public _003CStartTransitionInternalCR_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003828")]
		[Address(RVA = "0x186B5E0", Offset = "0x186B5E0", VA = "0x186B5E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003829")]
		[Address(RVA = "0x186B5E4", Offset = "0x186B5E4", VA = "0x186B5E4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600382A")]
		[Address(RVA = "0x186BCCC", Offset = "0x186BCCC", VA = "0x186BCCC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600382B")]
		[Address(RVA = "0x186BCD4", Offset = "0x186BCD4", VA = "0x186BCD4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600382C")]
		[Address(RVA = "0x186BD14", Offset = "0x186BD14", VA = "0x186BD14", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000BA2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43B90", Offset = "0x43B90")]
	private sealed class _003CEndTransition_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40040F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40040F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40040F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool force;

		[Token(Token = "0x40040F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transition _003C_003E4__this;

		[Token(Token = "0x40040F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float overrideTransitionDuration;

		[Token(Token = "0x170005E7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003830")]
			[Address(RVA = "0x186AF88", Offset = "0x186AF88", VA = "0x186AF88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005E8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003832")]
			[Address(RVA = "0x186AFD0", Offset = "0x186AFD0", VA = "0x186AFD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600382D")]
		[Address(RVA = "0x186AE24", Offset = "0x186AE24", VA = "0x186AE24")]
		[DebuggerHidden]
		public _003CEndTransition_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600382E")]
		[Address(RVA = "0x186AE50", Offset = "0x186AE50", VA = "0x186AE50", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600382F")]
		[Address(RVA = "0x186AE54", Offset = "0x186AE54", VA = "0x186AE54", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003830")]
		[Address(RVA = "0x186AF88", Offset = "0x186AF88", VA = "0x186AF88", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003831")]
		[Address(RVA = "0x186AF90", Offset = "0x186AF90", VA = "0x186AF90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003832")]
		[Address(RVA = "0x186AFD0", Offset = "0x186AFD0", VA = "0x186AFD0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000BA3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43BA0", Offset = "0x43BA0")]
	private sealed class _003CEndTransitionInternalCR_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40040F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40040F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40040FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transition _003C_003E4__this;

		[Token(Token = "0x40040FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float overrideTransitionDuration;

		[Token(Token = "0x170005E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003836")]
			[Address(RVA = "0x186B390", Offset = "0x186B390", VA = "0x186B390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003838")]
			[Address(RVA = "0x186B3D8", Offset = "0x186B3D8", VA = "0x186B3D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003833")]
		[Address(RVA = "0x186AFD8", Offset = "0x186AFD8", VA = "0x186AFD8")]
		[DebuggerHidden]
		public _003CEndTransitionInternalCR_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003834")]
		[Address(RVA = "0x186B004", Offset = "0x186B004", VA = "0x186B004", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003835")]
		[Address(RVA = "0x186B008", Offset = "0x186B008", VA = "0x186B008", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003836")]
		[Address(RVA = "0x186B390", Offset = "0x186B390", VA = "0x186B390", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003837")]
		[Address(RVA = "0x186B398", Offset = "0x186B398", VA = "0x186B398", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003838")]
		[Address(RVA = "0x186B3D8", Offset = "0x186B3D8", VA = "0x186B3D8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40040B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject fullScreenUIBlocker;

	[Token(Token = "0x40040B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TransitionTextEffect defaultTextEffect;

	[Token(Token = "0x40040B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<TransitionTextEffect> _textEffects;

	[Token(Token = "0x40040B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TransitionSubtitles subtitles;

	[Token(Token = "0x40040B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject waitAnimation;

	[Token(Token = "0x40040B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject waitText;

	[Token(Token = "0x40040B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public List<BaseTransitionEffect> transitionEffects;

	[Token(Token = "0x40040B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private BaseTransitionEffect lastUsedTransitionEffect;

	[Token(Token = "0x40040B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private SVGImage waitAnimationSpriteRenderer;

	[Token(Token = "0x40040B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color clearWhite;

	[Token(Token = "0x40040BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private TransitionTextEffects textEffects;

	[Token(Token = "0x40040BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float transitionInDuration;

	[Token(Token = "0x40040BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float transitionOutDuration;

	[Token(Token = "0x40040BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Coroutine loopCoroutine;

	[Token(Token = "0x40040BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private State state;

	[Token(Token = "0x40040BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private TransitionTextEffect activeTextEffect;

	[Token(Token = "0x40040C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private BaseTransitionEffect activeTransitionEffect;

	[Token(Token = "0x40040C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Camera transitionCam;

	[Token(Token = "0x40040C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private SecondDisplayCameraManager secondScreenCamera;

	[Token(Token = "0x40040C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Coroutine transitionWorkingCoroutine;

	[Token(Token = "0x40040C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Color? NextTransitionColor;

	[Token(Token = "0x170005E1")]
	public bool IsShowing
	{
		[Token(Token = "0x600380D")]
		[Address(RVA = "0x172AF18", Offset = "0x172AF18", VA = "0x172AF18")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170005E2")]
	public TransitionTextEffects TextEffects
	{
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x172BBC0", Offset = "0x172BBC0", VA = "0x172BBC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600380E")]
	[Address(RVA = "0x172AF28", Offset = "0x172AF28", VA = "0x172AF28")]
	private void Awake()
	{
	}

	[Token(Token = "0x600380F")]
	[Address(RVA = "0x172B234", Offset = "0x172B234", VA = "0x172B234")]
	private void InitializeTransitionEffects()
	{
	}

	[Token(Token = "0x6003810")]
	[Address(RVA = "0x172B094", Offset = "0x172B094", VA = "0x172B094")]
	private void InitializeTextEffects()
	{
	}

	[Token(Token = "0x6003811")]
	[Address(RVA = "0x172B5AC", Offset = "0x172B5AC", VA = "0x172B5AC")]
	public void InstantTransitionCover([Optional] Color? color, [Optional] BaseTransitionEffect transitionEffect)
	{
	}

	[Token(Token = "0x6003812")]
	[Address(RVA = "0x172B7D4", Offset = "0x172B7D4", VA = "0x172B7D4")]
	public IEnumerator StartTransition([Optional] string textId, [Optional][DefaultParameterValue(false)] bool onTheSide, [Optional][DefaultParameterValue(0f)] float delay, [Optional] Action onDone, [Optional] Color? color, [Optional] TransitionTextEffect textEffect, [Optional][DefaultParameterValue(false)] bool showWaitAnimation, [Optional][DefaultParameterValue(false)] bool isAsync, [Optional][DefaultParameterValue(false)] bool showWaitingText, [Optional] BaseTransitionEffect transitionEffect, [Optional] Func<bool> allowEndWhen)
	{
		return null;
	}

	[Token(Token = "0x6003813")]
	[Address(RVA = "0x172B8C0", Offset = "0x172B8C0", VA = "0x172B8C0")]
	private IEnumerator StartTransitionInternalCR([Optional] string textId, [Optional][DefaultParameterValue(false)] bool onTheSide, [Optional][DefaultParameterValue(0f)] float delay, [Optional] Action onDone, [Optional] Color? color, [Optional] TransitionTextEffect textEffect, [Optional][DefaultParameterValue(false)] bool showWaitAnimation, [Optional][DefaultParameterValue(false)] bool isAsync, [Optional][DefaultParameterValue(false)] bool showWaitingText, [Optional] BaseTransitionEffect transitionEffect, [Optional] Func<bool> allowEndWhen)
	{
		return null;
	}

	[Token(Token = "0x6003814")]
	[Address(RVA = "0x172B728", Offset = "0x172B728", VA = "0x172B728")]
	private void SetInputAllowed(bool allowed)
	{
	}

	[Token(Token = "0x6003815")]
	[Address(RVA = "0x172B9A8", Offset = "0x172B9A8", VA = "0x172B9A8")]
	public void EndTextTransitionImmidiate()
	{
	}

	[Token(Token = "0x6003816")]
	[Address(RVA = "0x172BAA0", Offset = "0x172BAA0", VA = "0x172BAA0")]
	public IEnumerator EndTransition(bool force = false, float overrideTransitionDuration = 0f)
	{
		return null;
	}

	[Token(Token = "0x6003817")]
	[Address(RVA = "0x172BB2C", Offset = "0x172BB2C", VA = "0x172BB2C")]
	private IEnumerator EndTransitionInternalCR(bool force = false, float overrideTransitionDuration = 0f)
	{
		return null;
	}

	[Token(Token = "0x6003818")]
	[Address(RVA = "0x172BBB0", Offset = "0x172BBB0", VA = "0x172BBB0")]
	public bool IsTransitionRunning()
	{
		return default;
	}

	[Token(Token = "0x600381A")]
	[Address(RVA = "0x172BBC8", Offset = "0x172BBC8", VA = "0x172BBC8")]
	public Transition()
	{
	}

	[Token(Token = "0x600381B")]
	[Address(RVA = "0x172BC30", Offset = "0x172BC30", VA = "0x172BC30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AE7C", Offset = "0x6AE7C")]
	private void _003CEndTransitionInternalCR_003Eb__34_0(float t)
	{
	}

	[Token(Token = "0x600381C")]
	[Address(RVA = "0x172BC98", Offset = "0x172BC98", VA = "0x172BC98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AE8C", Offset = "0x6AE8C")]
	private bool _003CEndTransitionInternalCR_003Eb__34_1()
	{
		return default;
	}
}
