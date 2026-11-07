using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000935")]
public class MusicManager : MonoBehaviour
{
	[Token(Token = "0x2000936")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x420B8", Offset = "0x420B8")]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x4003255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action callback;

		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0x1805098", Offset = "0x1805098", VA = "0x1805098")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0x18050A0", Offset = "0x18050A0", VA = "0x18050A0")]
		internal void _003CInitializeBank_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000937")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x420C8", Offset = "0x420C8")]
	private sealed class _003CSlowFixedUpdate_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MusicManager _003C_003E4__this;

		[Token(Token = "0x4003259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSecondsRealtime _003Cwait_003E5__2;

		[Token(Token = "0x400325A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _003CdelayInMs_003E5__3;

		[Token(Token = "0x17000465")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002AC9")]
			[Address(RVA = "0x1805364", Offset = "0x1805364", VA = "0x1805364", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000466")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002ACB")]
			[Address(RVA = "0x18053AC", Offset = "0x18053AC", VA = "0x18053AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002AC6")]
		[Address(RVA = "0x18050B4", Offset = "0x18050B4", VA = "0x18050B4")]
		[DebuggerHidden]
		public _003CSlowFixedUpdate_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002AC7")]
		[Address(RVA = "0x18050E0", Offset = "0x18050E0", VA = "0x18050E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0x18050E4", Offset = "0x18050E4", VA = "0x18050E4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002AC9")]
		[Address(RVA = "0x1805364", Offset = "0x1805364", VA = "0x1805364", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0x180536C", Offset = "0x180536C", VA = "0x180536C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002ACB")]
		[Address(RVA = "0x18053AC", Offset = "0x18053AC", VA = "0x18053AC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000938")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x420D8", Offset = "0x420D8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400325B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400325C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<FieldInfo, bool> _003C_003E9__49_0;

		[Token(Token = "0x6002ACD")]
		[Address(RVA = "0x1804FD4", Offset = "0x1804FD4", VA = "0x1804FD4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002ACE")]
		[Address(RVA = "0x1804FDC", Offset = "0x1804FDC", VA = "0x1804FDC")]
		internal bool _003CGetStateName_003Eb__49_0(FieldInfo t)
		{
			return default;
		}
	}

	[Token(Token = "0x4003244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string bankName;

	[Token(Token = "0x4003245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isLoaded;

	[Token(Token = "0x4003246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private uint playingId;

	[Token(Token = "0x4003247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float nextMusicSet;

	[Token(Token = "0x4003248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float musicSetInterval;

	[Token(Token = "0x4003249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private LevelMusicSettings currentMusicSettings;

	[Token(Token = "0x400324A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LevelMusic currentLevelMusic;

	[Token(Token = "0x400324B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float lastFirstShotTime;

	[Token(Token = "0x400324C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float lastMusicStartTime;

	[Token(Token = "0x400324D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float musicFadeVolume;

	[Token(Token = "0x400324E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float musicUserVolume;

	[Token(Token = "0x400324F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float musicVolume;

	[Token(Token = "0x4003250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool masterMute;

	[Token(Token = "0x4003251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int strokecount;

	[Token(Token = "0x4003252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string currentStateName;

	[Token(Token = "0x4003253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	internal bool useTransition;

	[Token(Token = "0x4003254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FA94", Offset = "0x4FA94")]
	private uint lastState__BackingField;

	[Token(Token = "0x17000464")]
	public uint lastState
	{
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x1585F6C", Offset = "0x1585F6C", VA = "0x1585F6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67860", Offset = "0x67860")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x1585F74", Offset = "0x1585F74", VA = "0x1585F74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67870", Offset = "0x67870")]
		private set
		{
		}
	}

	[Token(Token = "0x6002AA1")]
	[Address(RVA = "0x157ED90", Offset = "0x157ED90", VA = "0x157ED90")]
	public void InitializeBank([Optional] Action callback, bool startsWithOnboarding = false)
	{
	}

	[Token(Token = "0x6002AA2")]
	[Address(RVA = "0x1585FF0", Offset = "0x1585FF0", VA = "0x1585FF0")]
	public void FailChallenge()
	{
	}

	[Token(Token = "0x6002AA3")]
	[Address(RVA = "0x1586088", Offset = "0x1586088", VA = "0x1586088")]
	public void CompleteChallenge()
	{
	}

	[Token(Token = "0x6002AA4")]
	[Address(RVA = "0x1586120", Offset = "0x1586120", VA = "0x1586120")]
	public void PostTrigger(uint trigger)
	{
	}

	[Token(Token = "0x6002AA5")]
	[Address(RVA = "0x1586160", Offset = "0x1586160", VA = "0x1586160")]
	public void PostTrigger(StingerData trigger)
	{
	}

	[Token(Token = "0x6002AA6")]
	[Address(RVA = "0x158621C", Offset = "0x158621C", VA = "0x158621C")]
	public void SetUserVolume(float userVolume)
	{
	}

	[Token(Token = "0x6002AA7")]
	[Address(RVA = "0x15862E4", Offset = "0x15862E4", VA = "0x15862E4")]
	public void SetGain(float fadeVolume)
	{
	}

	[Token(Token = "0x6002AA8")]
	[Address(RVA = "0x1586224", Offset = "0x1586224", VA = "0x1586224")]
	private void UpdateMixerVolume()
	{
	}

	[Token(Token = "0x6002AA9")]
	[Address(RVA = "0x1585F7C", Offset = "0x1585F7C", VA = "0x1585F7C")]
	private IEnumerator SlowFixedUpdate()
	{
		return null;
	}

	[Token(Token = "0x6002AAA")]
	[Address(RVA = "0x15862EC", Offset = "0x15862EC", VA = "0x15862EC")]
	public void OnLevelWillUnload()
	{
	}

	[Token(Token = "0x6002AAB")]
	[Address(RVA = "0x1586644", Offset = "0x1586644", VA = "0x1586644")]
	public void OnLevelLoaded()
	{
	}

	[Token(Token = "0x6002AAC")]
	[Address(RVA = "0x1586930", Offset = "0x1586930", VA = "0x1586930")]
	private void CurrentLevelMusic_OnAimtStart(int preStrokeCount)
	{
	}

	[Token(Token = "0x6002AAD")]
	[Address(RVA = "0x15869FC", Offset = "0x15869FC", VA = "0x15869FC")]
	private void CurrentLevelMusic_OnStart()
	{
	}

	[Token(Token = "0x6002AAE")]
	[Address(RVA = "0x1586B9C", Offset = "0x1586B9C", VA = "0x1586B9C")]
	private void CurrentLevelMusic_OnShot(int preStrokeCount)
	{
	}

	[Token(Token = "0x6002AAF")]
	[Address(RVA = "0x1586D78", Offset = "0x1586D78", VA = "0x1586D78")]
	private void CurrentLevelMusic_OnFail()
	{
	}

	[Token(Token = "0x6002AB0")]
	[Address(RVA = "0x1587000", Offset = "0x1587000", VA = "0x1587000")]
	private void CurrentLevelMusic_OnAimUpdate(bool isAiming)
	{
	}

	[Token(Token = "0x6002AB1")]
	[Address(RVA = "0x15870D0", Offset = "0x15870D0", VA = "0x15870D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002AB2")]
	[Address(RVA = "0x15870F4", Offset = "0x15870F4", VA = "0x15870F4")]
	public bool ToggleMuteMusic()
	{
		return default;
	}

	[Token(Token = "0x6002AB3")]
	[Address(RVA = "0x158658C", Offset = "0x158658C", VA = "0x158658C")]
	private void SetAiming(float value)
	{
	}

	[Token(Token = "0x6002AB4")]
	[Address(RVA = "0x158710C", Offset = "0x158710C", VA = "0x158710C")]
	public void SetOverwroldRTCP(uint rtcp, float rtcpValue)
	{
	}

	[Token(Token = "0x6002AB5")]
	[Address(RVA = "0x1587164", Offset = "0x1587164", VA = "0x1587164")]
	public void setRTCPRaw(uint rtcp, float rtcpValue, int time)
	{
	}

	[Token(Token = "0x6002AB6")]
	[Address(RVA = "0x15871C4", Offset = "0x15871C4", VA = "0x15871C4")]
	public void SetLevelMusicRTPC(float rtpcValue, int time)
	{
	}

	[Token(Token = "0x6002AB7")]
	[Address(RVA = "0x1587264", Offset = "0x1587264", VA = "0x1587264")]
	public float GetLevelMusicRTPC()
	{
		return default;
	}

	[Token(Token = "0x6002AB8")]
	[Address(RVA = "0x15872EC", Offset = "0x15872EC", VA = "0x15872EC")]
	public float GetRTPCValueRaw(uint rtpcID)
	{
		return default;
	}

	[Token(Token = "0x6002AB9")]
	[Address(RVA = "0x1586ABC", Offset = "0x1586ABC", VA = "0x1586ABC")]
	private void SetBasic(float value, int tweenTime)
	{
	}

	[Token(Token = "0x6002ABA")]
	[Address(RVA = "0x1586F40", Offset = "0x1586F40", VA = "0x1586F40")]
	public void SetClosingIn(float value, int tweenTimeMs)
	{
	}

	[Token(Token = "0x6002ABB")]
	[Address(RVA = "0x1587358", Offset = "0x1587358", VA = "0x1587358")]
	public void InitializeMusic()
	{
	}

	[Token(Token = "0x6002ABC")]
	[Address(RVA = "0x1587408", Offset = "0x1587408", VA = "0x1587408")]
	public void InitializeMusic(uint initialState)
	{
	}

	[Token(Token = "0x6002ABD")]
	[Address(RVA = "0x1587670", Offset = "0x1587670", VA = "0x1587670")]
	public static string GetStateName(uint wwiseState)
	{
		return null;
	}

	[Token(Token = "0x6002ABE")]
	[Address(RVA = "0x15874E8", Offset = "0x15874E8", VA = "0x15874E8")]
	public void SetState(uint wwiseState, bool fromLoading, [Optional] Action onLoaded, bool ignoreTransition = false)
	{
	}

	[Token(Token = "0x6002ABF")]
	[Address(RVA = "0x15869D8", Offset = "0x15869D8", VA = "0x15869D8")]
	public void SetStateChange(MusicData musicOverworldWithTransition)
	{
	}

	[Token(Token = "0x6002AC0")]
	[Address(RVA = "0x1587920", Offset = "0x1587920", VA = "0x1587920")]
	public void SetLevelMusic(LevelMusicSettings music, float rtcpStart, [Optional][DefaultParameterValue(false)] bool ignoreTransition, [Optional] Action onLoaded)
	{
	}

	[Token(Token = "0x6002AC1")]
	[Address(RVA = "0x1587AE4", Offset = "0x1587AE4", VA = "0x1587AE4")]
	public void SetLevelMusic(LevelMusicSettings music, [Optional][DefaultParameterValue(false)] bool ignoreTransition, [Optional] Action onLoaded)
	{
	}

	[Token(Token = "0x6002AC2")]
	[Address(RVA = "0x1587AFC", Offset = "0x1587AFC", VA = "0x1587AFC")]
	public bool IsReadyToPlay()
	{
		return default;
	}

	[Token(Token = "0x6002AC3")]
	[Address(RVA = "0x1587B04", Offset = "0x1587B04", VA = "0x1587B04")]
	public MusicManager()
	{
	}
}
