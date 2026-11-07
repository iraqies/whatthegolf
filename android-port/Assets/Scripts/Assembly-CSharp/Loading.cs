using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000096")]
public class Loading : MonoBehaviour
{
	[Token(Token = "0x2000097")]
	private enum StartingPoint
	{
		[Token(Token = "0x4000252")]
		ONBOARDING = 0,
		[Token(Token = "0x4000253")]
		SECONDONBOARDING = 1,
		[Token(Token = "0x4000254")]
		HUB = 2
	}

	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D6B8", Offset = "0x3D6B8")]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IPlatform platform;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isMusicBankInitialized;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool hasGottenNewestIcloudSave;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Loading _003C_003E4__this;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool saveFileDetermined;

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x17EA854", Offset = "0x17EA854", VA = "0x17EA854")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x17EA85C", Offset = "0x17EA85C", VA = "0x17EA85C")]
		internal bool _003CInitCR_003Eb__0()
		{
			return default;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x17EA914", Offset = "0x17EA914", VA = "0x17EA914")]
		internal void _003CInitCR_003Eb__1()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x17EA948", Offset = "0x17EA948", VA = "0x17EA948")]
		internal void _003CInitCR_003Eb__2()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x17EAAA0", Offset = "0x17EAAA0", VA = "0x17EAAA0")]
		internal void _003CInitCR_003Eb__3()
		{
		}
	}

	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D6C8", Offset = "0x3D6C8")]
	private sealed class _003CInitCR_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Loading _003C_003E4__this;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _003CstartLoadTime_003E5__2;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _003CstartWaitForMusicTime_003E5__3;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _003CmaxWaitForICloudDownloadAndGameCenter_003E5__4;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private StartingPoint _003Cstart_003E5__5;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _003CtimeBeforeShowingWarning_003E5__6;

		[Token(Token = "0x1700006E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x17EBBE8", Offset = "0x17EBBE8", VA = "0x17EBBE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700006F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x17EBC30", Offset = "0x17EBC30", VA = "0x17EBC30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x17EACE0", Offset = "0x17EACE0", VA = "0x17EACE0")]
		[DebuggerHidden]
		public _003CInitCR_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x17EAD0C", Offset = "0x17EAD0C", VA = "0x17EAD0C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x17EAD10", Offset = "0x17EAD10", VA = "0x17EAD10", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x17EBBE8", Offset = "0x17EBBE8", VA = "0x17EBBE8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x17EBBF0", Offset = "0x17EBBF0", VA = "0x17EBBF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x17EBC30", Offset = "0x17EBC30", VA = "0x17EBC30", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D6D8", Offset = "0x3D6D8")]
	private struct _003CDownloadMusic_003Ed__24 : IAsyncStateMachine
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<ODRDownloadResult> _003C_003Eu__1;

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x17EAAAC", Offset = "0x17EAAAC", VA = "0x17EAAAC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x17EACD4", Offset = "0x17EACD4", VA = "0x17EACD4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D6E8", Offset = "0x3D6E8")]
	private struct _003CLoadHub_003Ed__26 : IAsyncStateMachine
	{
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Loading _003C_003E4__this;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HubSceneLoader _003ChubSceneLoader_003E5__2;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _003C_003Eu__1;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _003Cc_003E5__4;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x17EBC38", Offset = "0x17EBC38", VA = "0x17EBC38", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x17EC3B4", Offset = "0x17EC3B4", VA = "0x17EC3B4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D6F8", Offset = "0x3D6F8")]
	private sealed class _003CStartOnBoardingRoutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Loading _003C_003E4__this;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isMainOnboarding;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ContentPack pack;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool allowMenuButtons;

		[Token(Token = "0x17000070")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x17EC84C", Offset = "0x17EC84C", VA = "0x17EC84C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000071")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x17EC894", Offset = "0x17EC894", VA = "0x17EC894", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x17EC600", Offset = "0x17EC600", VA = "0x17EC600")]
		[DebuggerHidden]
		public _003CStartOnBoardingRoutine_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x17EC62C", Offset = "0x17EC62C", VA = "0x17EC62C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x17EC630", Offset = "0x17EC630", VA = "0x17EC630", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x17EC84C", Offset = "0x17EC84C", VA = "0x17EC84C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x17EC854", Offset = "0x17EC854", VA = "0x17EC854", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x17EC894", Offset = "0x17EC894", VA = "0x17EC894", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D708", Offset = "0x3D708")]
	private sealed class _003COnboardingAbandoned_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Loading _003C_003E4__this;

		[Token(Token = "0x17000072")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x17EC5B0", Offset = "0x17EC5B0", VA = "0x17EC5B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000073")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x17EC5F8", Offset = "0x17EC5F8", VA = "0x17EC5F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x17EC3C0", Offset = "0x17EC3C0", VA = "0x17EC3C0")]
		[DebuggerHidden]
		public _003COnboardingAbandoned_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x17EC3EC", Offset = "0x17EC3EC", VA = "0x17EC3EC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x17EC3F0", Offset = "0x17EC3F0", VA = "0x17EC3F0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x17EC5B0", Offset = "0x17EC5B0", VA = "0x17EC5B0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x17EC5B8", Offset = "0x17EC5B8", VA = "0x17EC5B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x17EC5F8", Offset = "0x17EC5F8", VA = "0x17EC5F8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Onboarding Onboarding;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XboxSplashScreen xboxSplashScreen;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PlaystationSplashScreen playstationSplashScreen;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject quickmenu;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color SwitchTransitionColor;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool forceSecondOnboarding;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Camera camera;

	[NonSerialized]
	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool IsLoaded;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Color transitionColor;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x49678", Offset = "0x49678")]
	private bool isOnboardingRunning__BackingField;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Loading instance;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private SceneInstance _loadingSceneInstance;

	[Token(Token = "0x1700006B")]
	public bool isOnboardingRunning
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1538990", Offset = "0x1538990", VA = "0x1538990")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5DB10", Offset = "0x5DB10")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1538998", Offset = "0x1538998", VA = "0x1538998")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5DB20", Offset = "0x5DB20")]
		private set
		{
		}
	}

	[Token(Token = "0x1700006C")]
	public static bool IsCreated
	{
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x15389A0", Offset = "0x15389A0", VA = "0x15389A0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700006D")]
	public static bool IsReady
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1538A34", Offset = "0x1538A34", VA = "0x1538A34")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1538B14", Offset = "0x1538B14", VA = "0x1538B14")]
	public void Init(SceneInstance sceneInstance)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x1538D9C", Offset = "0x1538D9C", VA = "0x1538D9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x1538D28", Offset = "0x1538D28", VA = "0x1538D28")]
	private IEnumerator InitCR()
	{
		return null;
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x1538DE8", Offset = "0x1538DE8", VA = "0x1538DE8")]
	private void CreateConsentPopupRequests()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x1538E4C", Offset = "0x1538E4C", VA = "0x1538E4C")]
	private void DownloadMusic()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x1538ED4", Offset = "0x1538ED4", VA = "0x1538ED4")]
	private void StartODR(LevelData obj)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1538F5C", Offset = "0x1538F5C", VA = "0x1538F5C")]
	private void LoadHub()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1538FF8", Offset = "0x1538FF8", VA = "0x1538FF8")]
	private StartingPoint WhereToStart()
	{
		return default;
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x153929C", Offset = "0x153929C", VA = "0x153929C")]
	private bool IsUserBeginner()
	{
		return default;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1539408", Offset = "0x1539408", VA = "0x1539408")]
	private bool HasOnlyPlayedMainCampaign()
	{
		return default;
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1539474", Offset = "0x1539474", VA = "0x1539474")]
	private IEnumerator StartOnBoardingRoutine(ContentPack pack, bool allowMenuButtons, bool isMainOnboarding)
	{
		return null;
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1539508", Offset = "0x1539508", VA = "0x1539508")]
	public void AbandonButtonClicked()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1539584", Offset = "0x1539584", VA = "0x1539584")]
	private IEnumerator OnboardingAbandoned()
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x15395F8", Offset = "0x15395F8", VA = "0x15395F8")]
	public Loading()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x1539600", Offset = "0x1539600", VA = "0x1539600")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5DB30", Offset = "0x5DB30")]
	private void _003CStartOnBoardingRoutine_003Eb__30_0()
	{
	}
}
