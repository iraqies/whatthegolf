using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C9")]
public class MultiplayerLevelCountdown : MonoBehaviour
{
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D890", Offset = "0x3D890")]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x10")]
		public SphericalGrayscaleEffect effect;

		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x18")]
		public MultiplayerLevelCountdown _003C_003E4__this;

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x17FC1E0", Offset = "0x17FC1E0", VA = "0x17FC1E0")]
		public _003C_003Ec__DisplayClass18_0()
		{
		}
	}

	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D8A0", Offset = "0x3D8A0")]
	private sealed class _003C_003Ec__DisplayClass18_1
	{
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x10")]
		public int i1;

		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x17FC1E8", Offset = "0x17FC1E8", VA = "0x17FC1E8")]
		public _003C_003Ec__DisplayClass18_1()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x17FC1F0", Offset = "0x17FC1F0", VA = "0x17FC1F0")]
		internal void _003CCountdown_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D8B0", Offset = "0x3D8B0")]
	private sealed class _003CCountdown_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerLevelCountdown _003C_003E4__this;

		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x28")]
		public List<MultiplayerConfiguration.PlayerInfo> players;

		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x30")]
		private CountdownAnimator _003Ccurrent_003E5__2;

		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x38")]
		private int _003Ccounts_003E5__3;

		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x3C")]
		private int _003Ci_003E5__4;

		[Token(Token = "0x17000089")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x17FCD64", Offset = "0x17FCD64", VA = "0x17FCD64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700008A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x17FCDAC", Offset = "0x17FCDAC", VA = "0x17FCDAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x17FC2B8", Offset = "0x17FC2B8", VA = "0x17FC2B8")]
		[DebuggerHidden]
		public _003CCountdown_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x17FC2E4", Offset = "0x17FC2E4", VA = "0x17FC2E4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x17FC2E8", Offset = "0x17FC2E8", VA = "0x17FC2E8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x17FCD64", Offset = "0x17FCD64", VA = "0x17FCD64", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x17FCD6C", Offset = "0x17FCD6C", VA = "0x17FCD6C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x17FCDAC", Offset = "0x17FCDAC", VA = "0x17FCDAC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MultiplayerLobby Lobby;

	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform AnimatorsParent;

	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x28")]
	public ClipSettingsCollection BlobPopInClip;

	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x30")]
	public float OutroTime;

	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x34")]
	public float CircleStartRadius;

	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x38")]
	public float AnimationSpeed;

	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x40")]
	private CountdownAnimator[] animators;

	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x48")]
	private bool beepPlayed;

	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x50")]
	private List<SphericalGrayscaleEffect> greyScale;

	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x58")]
	private List<Camera> newCams;

	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x60")]
	private TimeControl timeControl;

	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x68")]
	private QuickMenu quickMenu;

	[Token(Token = "0x400033B")]
	[FieldOffset(Offset = "0x70")]
	private List<MultiplayerConfiguration.PlayerInfo> players;

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x157ADA0", Offset = "0x157ADA0", VA = "0x157ADA0")]
	private void Start()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x157AFE8", Offset = "0x157AFE8", VA = "0x157AFE8")]
	private void OnBeep()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x157AFF4", Offset = "0x157AFF4", VA = "0x157AFF4")]
	private void OnLastBeep()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x157B394", Offset = "0x157B394", VA = "0x157B394")]
	private void OnLevelStarted(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x157B508", Offset = "0x157B508", VA = "0x157B508")]
	private void SetupGreyScaleCameraForPlayer(MultiplayerConfiguration.PlayerInfo player, bool addOffset)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x157B490", Offset = "0x157B490", VA = "0x157B490")]
	private IEnumerator Countdown(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		return null;
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x157B6CC", Offset = "0x157B6CC", VA = "0x157B6CC")]
	public MultiplayerLevelCountdown()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x157B7B0", Offset = "0x157B7B0", VA = "0x157B7B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E018", Offset = "0x5E018")]
	private void _003COnLastBeep_003Eb__15_0(float t)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x157BA44", Offset = "0x157BA44", VA = "0x157BA44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E028", Offset = "0x5E028")]
	private void _003COnLastBeep_003Eb__15_1()
	{
	}
}
