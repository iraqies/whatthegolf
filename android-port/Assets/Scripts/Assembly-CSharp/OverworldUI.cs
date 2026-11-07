using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Audio;
using Core;
using Core.UI;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;
using UnityEngine.UI;
using Utility;

[Token(Token = "0x2000A79")]
public class OverworldUI : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000A7A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42DA0", Offset = "0x42DA0")]
	private struct _003CShowMenu_003Ed__66 : IAsyncStateMachine
	{
		[Token(Token = "0x4003A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldUI _003C_003E4__this;

		[Token(Token = "0x4003A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _003CwasButtonActive_003E5__2;

		[Token(Token = "0x4003A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003209")]
		[Address(RVA = "0x181F630", Offset = "0x181F630", VA = "0x181F630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600320A")]
		[Address(RVA = "0x181F928", Offset = "0x181F928", VA = "0x181F928", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000A7B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42DB0", Offset = "0x42DB0")]
	private sealed class _003CExitToHub_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldUI _003C_003E4__this;

		[Token(Token = "0x17000526")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600320E")]
			[Address(RVA = "0x181EBFC", Offset = "0x181EBFC", VA = "0x181EBFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000527")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003210")]
			[Address(RVA = "0x181EC44", Offset = "0x181EC44", VA = "0x181EC44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600320B")]
		[Address(RVA = "0x181E9B4", Offset = "0x181E9B4", VA = "0x181E9B4")]
		[DebuggerHidden]
		public _003CExitToHub_003Ed__67(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600320C")]
		[Address(RVA = "0x181E9E0", Offset = "0x181E9E0", VA = "0x181E9E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600320D")]
		[Address(RVA = "0x181E9E4", Offset = "0x181E9E4", VA = "0x181E9E4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600320E")]
		[Address(RVA = "0x181EBFC", Offset = "0x181EBFC", VA = "0x181EBFC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600320F")]
		[Address(RVA = "0x181EC04", Offset = "0x181EC04", VA = "0x181EC04", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003210")]
		[Address(RVA = "0x181EC44", Offset = "0x181EC44", VA = "0x181EC44", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42DC0", Offset = "0x42DC0")]
	private sealed class _003C_003Ec__DisplayClass71_0
	{
		[Token(Token = "0x4003A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OverworldUI _003C_003E4__this;

		[Token(Token = "0x4003A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SubObjectiveUIElement firstElement;

		[Token(Token = "0x6003211")]
		[Address(RVA = "0x181E684", Offset = "0x181E684", VA = "0x181E684")]
		public _003C_003Ec__DisplayClass71_0()
		{
		}

		[Token(Token = "0x6003212")]
		[Address(RVA = "0x181E68C", Offset = "0x181E68C", VA = "0x181E68C")]
		internal void _003CRefreshElements_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000A7D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42DD0", Offset = "0x42DD0")]
	private sealed class _003C_003Ec__DisplayClass71_1
	{
		[Token(Token = "0x4003A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> completedChallengeIDs;

		[Token(Token = "0x4003A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass71_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6003213")]
		[Address(RVA = "0x181E790", Offset = "0x181E790", VA = "0x181E790")]
		public _003C_003Ec__DisplayClass71_1()
		{
		}

		[Token(Token = "0x6003214")]
		[Address(RVA = "0x181E798", Offset = "0x181E798", VA = "0x181E798")]
		internal bool _003CRefreshElements_003Eb__1(LevelData.ChallengeData c)
		{
			return default;
		}
	}

	[Token(Token = "0x2000A7E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42DE0", Offset = "0x42DE0")]
	private sealed class _003C_003Ec__DisplayClass71_2
	{
		[Token(Token = "0x4003A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i1;

		[Token(Token = "0x4003A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int used;

		[Token(Token = "0x4003A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass71_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x6003215")]
		[Address(RVA = "0x181E808", Offset = "0x181E808", VA = "0x181E808")]
		public _003C_003Ec__DisplayClass71_2()
		{
		}

		[Token(Token = "0x6003216")]
		[Address(RVA = "0x181E810", Offset = "0x181E810", VA = "0x181E810")]
		internal void _003CRefreshElements_003Eb__3()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A7F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42DF0", Offset = "0x42DF0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<LevelData, bool> _003C_003E9__71_2;

		[Token(Token = "0x4003A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<float> _003C_003E9__74_1;

		[Token(Token = "0x4003A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<SubObjectiveUIElement, bool> _003C_003E9__81_1;

		[Token(Token = "0x6003218")]
		[Address(RVA = "0x181E5F8", Offset = "0x181E5F8", VA = "0x181E5F8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003219")]
		[Address(RVA = "0x181E600", Offset = "0x181E600", VA = "0x181E600")]
		internal bool _003CRefreshElements_003Eb__71_2(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x600321A")]
		[Address(RVA = "0x181E658", Offset = "0x181E658", VA = "0x181E658")]
		internal void _003CChallengeCompleted_003Eb__74_1(float t)
		{
		}

		[Token(Token = "0x600321B")]
		[Address(RVA = "0x181E65C", Offset = "0x181E65C", VA = "0x181E65C")]
		internal bool _003CUpdatePlayAgainDialog_003Eb__81_1(SubObjectiveUIElement c)
		{
			return default;
		}
	}

	[Token(Token = "0x2000A80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42E00", Offset = "0x42E00")]
	private sealed class _003C_003Ec__DisplayClass74_0
	{
		[Token(Token = "0x4003A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string challengeID;

		[Token(Token = "0x4003A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OverworldUI _003C_003E4__this;

		[Token(Token = "0x600321C")]
		[Address(RVA = "0x181E96C", Offset = "0x181E96C", VA = "0x181E96C")]
		public _003C_003Ec__DisplayClass74_0()
		{
		}

		[Token(Token = "0x600321D")]
		[Address(RVA = "0x181E974", Offset = "0x181E974", VA = "0x181E974")]
		internal bool _003CChallengeCompleted_003Eb__0(SubObjectiveUIElement c)
		{
			return default;
		}

		[Token(Token = "0x600321E")]
		[Address(RVA = "0x181E998", Offset = "0x181E998", VA = "0x181E998")]
		internal void _003CChallengeCompleted_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000A81")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42E10", Offset = "0x42E10")]
	private sealed class _003CShowRoutine_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldUI _003C_003E4__this;

		[Token(Token = "0x17000528")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003222")]
			[Address(RVA = "0x181FB00", Offset = "0x181FB00", VA = "0x181FB00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000529")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003224")]
			[Address(RVA = "0x181FB48", Offset = "0x181FB48", VA = "0x181FB48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600321F")]
		[Address(RVA = "0x181F934", Offset = "0x181F934", VA = "0x181F934")]
		[DebuggerHidden]
		public _003CShowRoutine_003Ed__88(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003220")]
		[Address(RVA = "0x181F960", Offset = "0x181F960", VA = "0x181F960", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003221")]
		[Address(RVA = "0x181F964", Offset = "0x181F964", VA = "0x181F964", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003222")]
		[Address(RVA = "0x181FB00", Offset = "0x181FB00", VA = "0x181FB00", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003223")]
		[Address(RVA = "0x181FB08", Offset = "0x181FB08", VA = "0x181FB08", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003224")]
		[Address(RVA = "0x181FB48", Offset = "0x181FB48", VA = "0x181FB48", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A82")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42E20", Offset = "0x42E20")]
	private sealed class _003CHideRoutine_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OverworldUI _003C_003E4__this;

		[Token(Token = "0x4003A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003Ct_003E5__2;

		[Token(Token = "0x4003A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector2 _003CstartPos_003E5__3;

		[Token(Token = "0x4003A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector2 _003CmiddlePos_003E5__4;

		[Token(Token = "0x1700052A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003228")]
			[Address(RVA = "0x181F5E0", Offset = "0x181F5E0", VA = "0x181F5E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700052B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600322A")]
			[Address(RVA = "0x181F628", Offset = "0x181F628", VA = "0x181F628", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003225")]
		[Address(RVA = "0x181EC4C", Offset = "0x181EC4C", VA = "0x181EC4C")]
		[DebuggerHidden]
		public _003CHideRoutine_003Ed__91(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003226")]
		[Address(RVA = "0x181EC78", Offset = "0x181EC78", VA = "0x181EC78", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003227")]
		[Address(RVA = "0x181EC7C", Offset = "0x181EC7C", VA = "0x181EC7C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003228")]
		[Address(RVA = "0x181F5E0", Offset = "0x181F5E0", VA = "0x181F5E0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003229")]
		[Address(RVA = "0x181F5E8", Offset = "0x181F5E8", VA = "0x181F5E8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600322A")]
		[Address(RVA = "0x181F628", Offset = "0x181F628", VA = "0x181F628", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40039EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50528", Offset = "0x50528")]
	private Action m_OnExitingOverworld;

	[Token(Token = "0x40039ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RawImage Screenshot;

	[Token(Token = "0x40039EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<AudioClip> PopupClips;

	[Token(Token = "0x40039EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection CrownWonSequenceSFX;

	[Token(Token = "0x40039F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float volume;

	[Token(Token = "0x40039F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Button> buttonCancel;

	[Token(Token = "0x40039F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RectTransform MenuContainer;

	[Token(Token = "0x40039F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<SubObjectiveUIElement> ChallengeElement;

	[Token(Token = "0x40039F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RectTransform ChallengesContainer;

	[Token(Token = "0x40039F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RectTransform ScreenshotContainer;

	[Token(Token = "0x40039F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject PlayAgainDialogContainer;

	[Token(Token = "0x40039F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Button ExitOverworldButton;

	[Token(Token = "0x40039F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Sprite CloseSprite;

	[Token(Token = "0x40039F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Sprite MenuSprite;

	[Token(Token = "0x40039FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private TextureLibrary screenshotTextureLibrary;

	[Token(Token = "0x40039FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Animator PlayAgainAnimator;

	[Token(Token = "0x40039FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Animator CrownWonAnimator;

	[Token(Token = "0x40039FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Canvas PlayAgainCanvas;

	[Token(Token = "0x40039FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Sprite NoIconReplacement;

	[Token(Token = "0x40039FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public RectTransform CloseButtonRect;

	[Token(Token = "0x4003A00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public RectTransform CloseButtonRectRotated;

	[Token(Token = "0x4003A01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RectTransform ChallengeContainer;

	[Token(Token = "0x4003A02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public AimMarker AimMarker;

	[Token(Token = "0x4003A03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject CrownLocked;

	[Token(Token = "0x4003A04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject CrownWon;

	[Token(Token = "0x4003A05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject CrownWonTop;

	[Token(Token = "0x4003A06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public RectTransform CrownToFlag;

	[Token(Token = "0x4003A07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public RectTransform SelectionBox;

	[Token(Token = "0x4003A08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public AnimationCurve AppearCurve;

	[Token(Token = "0x4003A09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public AnimationCurve DisappearCurve;

	[Token(Token = "0x4003A0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public CanvasGroup BackgroundImage;

	[Token(Token = "0x4003A0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public CanvasGroup ScanlinesAlpha;

	[Token(Token = "0x4003A0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Animator KeyboardAnimator;

	[Token(Token = "0x4003A0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Animator ScanlinesAnimator;

	[Token(Token = "0x4003A0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public RectTransform NextUpRectTransform;

	[Token(Token = "0x4003A0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Transition.TransitionEffect TransitionEffectType;

	[Token(Token = "0x4003A10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private Vector3 activePosition;

	[Token(Token = "0x4003A11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Vector3 activePosition2D;

	[Token(Token = "0x4003A12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Player player;

	[Token(Token = "0x4003A13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private int selectedChallengeIndex;

	[Token(Token = "0x4003A14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private Vector3 currentChallengeVel;

	[Token(Token = "0x4003A15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private float changeTimer;

	[Token(Token = "0x4003A16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private bool crownWon;

	[Token(Token = "0x4003A17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private CanvasScaler canvasScaler;

	[Token(Token = "0x4003A18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private bool isClosing;

	[Token(Token = "0x4003A19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Action<string> onPlayLevelCallback;

	[Token(Token = "0x4003A1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private Action onCloseCallback;

	[Token(Token = "0x4003A1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private List<LevelData> allLevels;

	[Token(Token = "0x4003A1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private OverworldGoal goal;

	[Token(Token = "0x4003A1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private OverworldGoal previousGoal;

	[Token(Token = "0x4003A1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private float screenshotSwitchTimer;

	[Token(Token = "0x4003A1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private int currentSpriteIndex;

	[Token(Token = "0x4003A20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private List<Texture> currentScreenshotSprites;

	[Token(Token = "0x4003A21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private SVGImage selectionBoxImage;

	[Token(Token = "0x4003A22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private float scanlinesTimer;

	[Token(Token = "0x4003A23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Dictionary<OverworldGoal, bool> goalUsesLandscapeCrown;

	[Token(Token = "0x4003A24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private float closeTimer;

	[Token(Token = "0x4003A25")]
	private const float closeTimerMax = 10f;

	[Token(Token = "0x4003A26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	private bool _exiting;

	[Token(Token = "0x4003A27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
	private bool shouldUpdate;

	[Token(Token = "0x14000068")]
	public event Action OnExitingOverworld
	{
		[Token(Token = "0x60031E4")]
		[Address(RVA = "0x15CF67C", Offset = "0x15CF67C", VA = "0x15CF67C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69B64", Offset = "0x69B64")]
		add
		{
		}
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x15CF720", Offset = "0x15CF720", VA = "0x15CF720")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69B74", Offset = "0x69B74")]
		remove
		{
		}
	}

	[Token(Token = "0x60031E6")]
	[Address(RVA = "0x15CF7C4", Offset = "0x15CF7C4", VA = "0x15CF7C4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60031E7")]
	[Address(RVA = "0x15CFCCC", Offset = "0x15CFCCC", VA = "0x15CFCCC")]
	public void EnableReturnButton()
	{
	}

	[Token(Token = "0x60031E8")]
	[Address(RVA = "0x15CFCAC", Offset = "0x15CFCAC", VA = "0x15CFCAC")]
	public void DisableReturnButton(LevelData level)
	{
	}

	[Token(Token = "0x60031E9")]
	[Address(RVA = "0x15CFD60", Offset = "0x15CFD60", VA = "0x15CFD60")]
	public void ExitToMenu()
	{
	}

	[Token(Token = "0x60031EA")]
	[Address(RVA = "0x15CFDF8", Offset = "0x15CFDF8", VA = "0x15CFDF8")]
	public void ShowMenu()
	{
	}

	[Token(Token = "0x60031EB")]
	[Address(RVA = "0x15CFE90", Offset = "0x15CFE90", VA = "0x15CFE90")]
	public IEnumerator ExitToHub()
	{
		return null;
	}

	[Token(Token = "0x60031EC")]
	[Address(RVA = "0x15CFF04", Offset = "0x15CFF04", VA = "0x15CFF04")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60031ED")]
	[Address(RVA = "0x15C3028", Offset = "0x15C3028", VA = "0x15C3028")]
	public bool IsPlayAgainDialogActive()
	{
		return default;
	}

	[Token(Token = "0x60031EE")]
	[Address(RVA = "0x15C3A20", Offset = "0x15C3A20", VA = "0x15C3A20")]
	public void ShowPlayagainDialog(OverworldGoal goal, Action<string> onPlayLevelCallback, Action onCloseCallback)
	{
	}

	[Token(Token = "0x60031EF")]
	[Address(RVA = "0x15D0248", Offset = "0x15D0248", VA = "0x15D0248")]
	public void RefreshElements()
	{
	}

	[Token(Token = "0x60031F0")]
	[Address(RVA = "0x15D1680", Offset = "0x15D1680", VA = "0x15D1680")]
	public bool IsMenuActive()
	{
		return default;
	}

	[Token(Token = "0x60031F1")]
	[Address(RVA = "0x15D125C", Offset = "0x15D125C", VA = "0x15D125C")]
	private bool GetGoalUsedLandscape(OverworldGoal goal)
	{
		return default;
	}

	[Token(Token = "0x60031F2")]
	[Address(RVA = "0x15D169C", Offset = "0x15D169C", VA = "0x15D169C")]
	public void ChallengeCompleted(string challengeID)
	{
	}

	[Token(Token = "0x60031F3")]
	[Address(RVA = "0x15D1D7C", Offset = "0x15D1D7C", VA = "0x15D1D7C")]
	public void CloseUI()
	{
	}

	[Token(Token = "0x60031F4")]
	[Address(RVA = "0x15D1D94", Offset = "0x15D1D94", VA = "0x15D1D94")]
	private void Close()
	{
	}

	[Token(Token = "0x60031F5")]
	[Address(RVA = "0x15C4028", Offset = "0x15C4028", VA = "0x15C4028")]
	public void DisableUI()
	{
	}

	[Token(Token = "0x60031F6")]
	[Address(RVA = "0x15C4FF4", Offset = "0x15C4FF4", VA = "0x15C4FF4")]
	public void EnableUI()
	{
	}

	[Token(Token = "0x60031F7")]
	[Address(RVA = "0x15D1E50", Offset = "0x15D1E50", VA = "0x15D1E50")]
	private void Update()
	{
	}

	[Token(Token = "0x60031F8")]
	[Address(RVA = "0x15D261C", Offset = "0x15D261C", VA = "0x15D261C")]
	private void ListenToCloseButton()
	{
	}

	[Token(Token = "0x60031F9")]
	[Address(RVA = "0x15D1F2C", Offset = "0x15D1F2C", VA = "0x15D1F2C")]
	private void UpdatePlayAgainDialog()
	{
	}

	[Token(Token = "0x60031FA")]
	[Address(RVA = "0x15D1250", Offset = "0x15D1250", VA = "0x15D1250")]
	private void StartCloseTimer()
	{
	}

	[Token(Token = "0x60031FB")]
	[Address(RVA = "0x15D27B8", Offset = "0x15D27B8", VA = "0x15D27B8")]
	private void StopCloseTimer()
	{
	}

	[Token(Token = "0x60031FC")]
	[Address(RVA = "0x15D2754", Offset = "0x15D2754", VA = "0x15D2754")]
	private void UpdateAndHandleCloseTimer()
	{
	}

	[Token(Token = "0x60031FD")]
	[Address(RVA = "0x15D1DAC", Offset = "0x15D1DAC", VA = "0x15D1DAC")]
	public void ClearPlayagainDialog()
	{
	}

	[Token(Token = "0x60031FE")]
	[Address(RVA = "0x15D0068", Offset = "0x15D0068", VA = "0x15D0068")]
	private void AddCancelListeners()
	{
	}

	[Token(Token = "0x60031FF")]
	[Address(RVA = "0x15D13A0", Offset = "0x15D13A0", VA = "0x15D13A0")]
	private void RemoveAllListeners()
	{
	}

	[Token(Token = "0x6003200")]
	[Address(RVA = "0x15D11DC", Offset = "0x15D11DC", VA = "0x15D11DC")]
	private IEnumerator ShowRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003201")]
	[Address(RVA = "0x15D2838", Offset = "0x15D2838", VA = "0x15D2838")]
	private bool NoneIsNull()
	{
		return default;
	}

	[Token(Token = "0x6003202")]
	[Address(RVA = "0x15D2A20", Offset = "0x15D2A20", VA = "0x15D2A20")]
	public void CloseInstant()
	{
	}

	[Token(Token = "0x6003203")]
	[Address(RVA = "0x15D27C4", Offset = "0x15D27C4", VA = "0x15D27C4")]
	private IEnumerator HideRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003204")]
	[Address(RVA = "0x15D2AD8", Offset = "0x15D2AD8", VA = "0x15D2AD8")]
	public OverworldUI()
	{
	}

	[Token(Token = "0x6003205")]
	[Address(RVA = "0x15D2AFC", Offset = "0x15D2AFC", VA = "0x15D2AFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69B84", Offset = "0x69B84")]
	private void _003CShowPlayagainDialog_003Eb__70_0(AudioSource s)
	{
	}

	[Token(Token = "0x6003206")]
	[Address(RVA = "0x15D2B3C", Offset = "0x15D2B3C", VA = "0x15D2B3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69B94", Offset = "0x69B94")]
	private void _003CUpdatePlayAgainDialog_003Eb__81_0(float t)
	{
	}

	[Token(Token = "0x6003207")]
	[Address(RVA = "0x15D2C20", Offset = "0x15D2C20", VA = "0x15D2C20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69BA4", Offset = "0x69BA4")]
	private void _003CShowRoutine_003Eb__88_0(float t)
	{
	}

	[Token(Token = "0x6003208")]
	[Address(RVA = "0x15D2D7C", Offset = "0x15D2D7C", VA = "0x15D2D7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69BB4", Offset = "0x69BB4")]
	private void _003CHideRoutine_003Eb__91_0(float t)
	{
	}
}
