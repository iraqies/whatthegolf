using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000438")]
public class InGameChallengeInfo : MonoBehaviour
{
	[Token(Token = "0x2000439")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FA5C", Offset = "0x3FA5C")]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x4001718")]
		[FieldOffset(Offset = "0x10")]
		public bool didShoot;

		[Token(Token = "0x4001719")]
		[FieldOffset(Offset = "0x18")]
		public InGameChallengeInfo _003C_003E4__this;

		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x17C46A8", Offset = "0x17C46A8", VA = "0x17C46A8")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x17C46B0", Offset = "0x17C46B0", VA = "0x17C46B0")]
		internal void _003CRoutine_003Eb__0()
		{
		}

		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x17C46BC", Offset = "0x17C46BC", VA = "0x17C46BC")]
		internal void _003CRoutine_003Eb__1(float t)
		{
		}

		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x17C4720", Offset = "0x17C4720", VA = "0x17C4720")]
		internal void _003CRoutine_003Eb__2(float t)
		{
		}
	}

	[Token(Token = "0x200043A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FA6C", Offset = "0x3FA6C")]
	private sealed class _003CRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400171A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400171B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400171C")]
		[FieldOffset(Offset = "0x20")]
		public InGameChallengeInfo _003C_003E4__this;

		[Token(Token = "0x400171D")]
		[FieldOffset(Offset = "0x28")]
		public string text;

		[Token(Token = "0x400171E")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		[Token(Token = "0x17000234")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60013DE")]
			[Address(RVA = "0x17C4DB0", Offset = "0x17C4DB0", VA = "0x17C4DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000235")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60013E0")]
			[Address(RVA = "0x17C4DF8", Offset = "0x17C4DF8", VA = "0x17C4DF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x17C49C4", Offset = "0x17C49C4", VA = "0x17C49C4")]
		[DebuggerHidden]
		public _003CRoutine_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x17C49F0", Offset = "0x17C49F0", VA = "0x17C49F0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x17C49F4", Offset = "0x17C49F4", VA = "0x17C49F4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x17C4DB0", Offset = "0x17C4DB0", VA = "0x17C4DB0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x17C4DB8", Offset = "0x17C4DB8", VA = "0x17C4DB8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x17C4DF8", Offset = "0x17C4DF8", VA = "0x17C4DF8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200043B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FA7C", Offset = "0x3FA7C")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x400171F")]
		[FieldOffset(Offset = "0x10")]
		public bool playerHasShot;

		[Token(Token = "0x4001720")]
		[FieldOffset(Offset = "0x14")]
		public float aimTime;

		[Token(Token = "0x4001721")]
		[FieldOffset(Offset = "0x18")]
		public Action<Vector3> _003C_003E9__2;

		[Token(Token = "0x4001722")]
		[FieldOffset(Offset = "0x20")]
		public Action<Vector3, bool> _003C_003E9__3;

		[Token(Token = "0x4001723")]
		[FieldOffset(Offset = "0x28")]
		public Action<Vector3> _003C_003E9__4;

		[Token(Token = "0x4001724")]
		[FieldOffset(Offset = "0x30")]
		public Action<Vector3, bool> _003C_003E9__5;

		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x17C4784", Offset = "0x17C4784", VA = "0x17C4784")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x17C478C", Offset = "0x17C478C", VA = "0x17C478C")]
		internal void _003CWaitForPlayerShot_003Eg__RegisterShot_007C0()
		{
		}

		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x17C4798", Offset = "0x17C4798", VA = "0x17C4798")]
		internal void _003CWaitForPlayerShot_003Eg__UpdateAim_007C1(Vector3 v)
		{
		}

		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x17C4800", Offset = "0x17C4800", VA = "0x17C4800")]
		internal void _003CWaitForPlayerShot_003Eb__2(Vector3 v)
		{
		}

		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x17C480C", Offset = "0x17C480C", VA = "0x17C480C")]
		internal void _003CWaitForPlayerShot_003Eb__3(Vector3 v, bool b)
		{
		}

		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x17C4874", Offset = "0x17C4874", VA = "0x17C4874")]
		internal void _003CWaitForPlayerShot_003Eb__4(Vector3 v)
		{
		}

		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x17C4880", Offset = "0x17C4880", VA = "0x17C4880")]
		internal void _003CWaitForPlayerShot_003Eb__5(Vector3 v, bool b)
		{
		}
	}

	[Token(Token = "0x200043C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FA8C", Offset = "0x3FA8C")]
	private sealed class _003CWaitForPlayerShot_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001725")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001726")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001727")]
		[FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		[Token(Token = "0x4001728")]
		[FieldOffset(Offset = "0x28")]
		public Action OnReady;

		[Token(Token = "0x4001729")]
		[FieldOffset(Offset = "0x30")]
		private float _003Ctimer_003E5__2;

		[Token(Token = "0x400172A")]
		[FieldOffset(Offset = "0x38")]
		private GolfBallController[] _003Ccontrollers_003E5__3;

		[Token(Token = "0x17000236")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60013EB")]
			[Address(RVA = "0x17C571C", Offset = "0x17C571C", VA = "0x17C571C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000237")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60013ED")]
			[Address(RVA = "0x17C5764", Offset = "0x17C5764", VA = "0x17C5764", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x17C52A4", Offset = "0x17C52A4", VA = "0x17C52A4")]
		[DebuggerHidden]
		public _003CWaitForPlayerShot_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x17C52D0", Offset = "0x17C52D0", VA = "0x17C52D0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x17C52D4", Offset = "0x17C52D4", VA = "0x17C52D4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x17C571C", Offset = "0x17C571C", VA = "0x17C571C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x17C5724", Offset = "0x17C5724", VA = "0x17C5724", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x17C5764", Offset = "0x17C5764", VA = "0x17C5764", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200043D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FA9C", Offset = "0x3FA9C")]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x10")]
		public bool didShoot;

		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0x18")]
		public InGameChallengeInfo _003C_003E4__this;

		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x17C48E8", Offset = "0x17C48E8", VA = "0x17C48E8")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x17C48F0", Offset = "0x17C48F0", VA = "0x17C48F0")]
		internal void _003CRoutine_003Eb__0()
		{
		}

		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x17C48FC", Offset = "0x17C48FC", VA = "0x17C48FC")]
		internal void _003CRoutine_003Eb__1(float t)
		{
		}

		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x17C4960", Offset = "0x17C4960", VA = "0x17C4960")]
		internal void _003CRoutine_003Eb__2(float t)
		{
		}
	}

	[Token(Token = "0x200043E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FAAC", Offset = "0x3FAAC")]
	private sealed class _003CRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x20")]
		public InGameChallengeInfo _003C_003E4__this;

		[Token(Token = "0x4001730")]
		[FieldOffset(Offset = "0x28")]
		public string text;

		[Token(Token = "0x4001731")]
		[FieldOffset(Offset = "0x30")]
		public Sprite[] icons;

		[Token(Token = "0x4001732")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		[Token(Token = "0x17000238")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60013F5")]
			[Address(RVA = "0x17C5254", Offset = "0x17C5254", VA = "0x17C5254", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000239")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60013F7")]
			[Address(RVA = "0x17C529C", Offset = "0x17C529C", VA = "0x17C529C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x17C4E00", Offset = "0x17C4E00", VA = "0x17C4E00")]
		[DebuggerHidden]
		public _003CRoutine_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x17C4E2C", Offset = "0x17C4E2C", VA = "0x17C4E2C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x17C4E30", Offset = "0x17C4E30", VA = "0x17C4E30", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x17C5254", Offset = "0x17C5254", VA = "0x17C5254", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x17C525C", Offset = "0x17C525C", VA = "0x17C525C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x17C529C", Offset = "0x17C529C", VA = "0x17C529C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001705")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI ChallengeText;

	[Token(Token = "0x4001706")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform Container;

	[Token(Token = "0x4001707")]
	[FieldOffset(Offset = "0x28")]
	public float Height;

	[Token(Token = "0x4001708")]
	[FieldOffset(Offset = "0x2C")]
	public float IconExtraHeight;

	[Token(Token = "0x4001709")]
	[FieldOffset(Offset = "0x30")]
	public float HoldDuration;

	[Token(Token = "0x400170A")]
	[FieldOffset(Offset = "0x34")]
	public float MobileWidth;

	[Token(Token = "0x400170B")]
	[FieldOffset(Offset = "0x38")]
	public float StandaloneWidth;

	[Token(Token = "0x400170C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject IconImagePrefab;

	[Token(Token = "0x400170D")]
	[FieldOffset(Offset = "0x48")]
	public int MaxIcons;

	[Token(Token = "0x400170E")]
	[FieldOffset(Offset = "0x4C")]
	public float SpacingBetweenIcons;

	[Token(Token = "0x400170F")]
	[FieldOffset(Offset = "0x50")]
	public float IconHeight;

	[Token(Token = "0x4001710")]
	[FieldOffset(Offset = "0x54")]
	public float SoloTextY;

	[Token(Token = "0x4001711")]
	[FieldOffset(Offset = "0x58")]
	public float IconTextY;

	[Token(Token = "0x4001712")]
	[FieldOffset(Offset = "0x5C")]
	public float IconY;

	[Token(Token = "0x4001713")]
	[FieldOffset(Offset = "0x60")]
	public ClipSettingsCollection sfxOnAppear;

	[Token(Token = "0x4001714")]
	[FieldOffset(Offset = "0x68")]
	public ClipSettingsCollection sfxOnDissapear;

	[Token(Token = "0x4001715")]
	[FieldOffset(Offset = "0x70")]
	private List<SVGImage> iconImagePool;

	[Token(Token = "0x4001716")]
	[FieldOffset(Offset = "0x78")]
	private float WaitTime;

	[Token(Token = "0x4001717")]
	[FieldOffset(Offset = "0x7C")]
	public bool ShowForMinSeconds;

	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x14E9B2C", Offset = "0x14E9B2C", VA = "0x14E9B2C")]
	public void SetWaitSeconds(float seconds)
	{
	}

	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x14E9B34", Offset = "0x14E9B34", VA = "0x14E9B34")]
	private void Awake()
	{
	}

	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x14E9DD4", Offset = "0x14E9DD4", VA = "0x14E9DD4")]
	private void Start()
	{
	}

	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x14E9E8C", Offset = "0x14E9E8C", VA = "0x14E9E8C")]
	private void OnLevelWillUnload()
	{
	}

	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x14E9ED0", Offset = "0x14E9ED0", VA = "0x14E9ED0")]
	public void Show(string text)
	{
	}

	[Token(Token = "0x60013D0")]
	[Address(RVA = "0x14EA0D8", Offset = "0x14EA0D8", VA = "0x14EA0D8")]
	private IEnumerator Routine(string text)
	{
		return null;
	}

	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x14EA150", Offset = "0x14EA150", VA = "0x14EA150")]
	private IEnumerator WaitForPlayerShot(Action OnReady)
	{
		return null;
	}

	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x14EA1C4", Offset = "0x14EA1C4", VA = "0x14EA1C4")]
	public void Show(string text, Sprite[] icons)
	{
	}

	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x14EA2DC", Offset = "0x14EA2DC", VA = "0x14EA2DC")]
	private IEnumerator Routine(string text, Sprite[] icons)
	{
		return null;
	}

	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x14EA364", Offset = "0x14EA364", VA = "0x14EA364")]
	private void LayoutIcons(Sprite[] icons)
	{
	}

	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x14E9FD8", Offset = "0x14E9FD8", VA = "0x14E9FD8")]
	private void ResetIconsAndText()
	{
	}

	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x14EA718", Offset = "0x14EA718", VA = "0x14EA718")]
	public InGameChallengeInfo()
	{
	}
}
