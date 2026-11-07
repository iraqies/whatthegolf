using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000F2")]
public class WinSequence : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000F3")]
	public class AvatarCard
	{
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x10")]
		public GameObject Card;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x18")]
		public PlayerColors.AvatarIDs Avatar;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1879120", Offset = "0x1879120", VA = "0x1879120")]
		public AvatarCard()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DA70", Offset = "0x3DA70")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MultiplayerConfiguration.PlayerInfo, int> _003C_003E9__25_0;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1878724", Offset = "0x1878724", VA = "0x1878724")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x187872C", Offset = "0x187872C", VA = "0x187872C")]
		internal int _003CMatchEnded_003Eb__25_0(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}
	}

	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DA80", Offset = "0x3DA80")]
	private sealed class _003CDelayStartCounting_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x20")]
		public List<MultiplayerConfiguration.PlayerInfo> players;

		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x28")]
		public WinSequence _003C_003E4__this;

		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x30")]
		private float _003CholdTimer_003E5__2;

		[Token(Token = "0x17000098")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x18790D0", Offset = "0x18790D0", VA = "0x18790D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000099")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1879118", Offset = "0x1879118", VA = "0x1879118", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x18788E0", Offset = "0x18788E0", VA = "0x18788E0")]
		[DebuggerHidden]
		public _003CDelayStartCounting_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x187890C", Offset = "0x187890C", VA = "0x187890C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1878910", Offset = "0x1878910", VA = "0x1878910", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x18790D0", Offset = "0x18790D0", VA = "0x18790D0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x18790D8", Offset = "0x18790D8", VA = "0x18790D8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1879118", Offset = "0x1879118", VA = "0x1879118", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DA90", Offset = "0x3DA90")]
	private sealed class _003CCountStats_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI textField;

		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x30")]
		public Action onDone;

		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x38")]
		private int _003Ccount_003E5__2;

		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x40")]
		private WaitForSeconds _003Cwait_003E5__3;

		[Token(Token = "0x1700009A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1878890", Offset = "0x1878890", VA = "0x1878890", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700009B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x18788D8", Offset = "0x18788D8", VA = "0x18788D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1878744", Offset = "0x1878744", VA = "0x1878744")]
		[DebuggerHidden]
		public _003CCountStats_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1878770", Offset = "0x1878770", VA = "0x1878770", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1878774", Offset = "0x1878774", VA = "0x1878774", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1878890", Offset = "0x1878890", VA = "0x1878890", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1878898", Offset = "0x1878898", VA = "0x1878898", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x18788D8", Offset = "0x18788D8", VA = "0x18788D8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x18")]
	public List<AvatarCard> AvatarCardsP1;

	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x20")]
	public List<AvatarCard> AvatarCardsP2;

	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x28")]
	public Animator Animator;

	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x30")]
	public MultiplayerLobby Lobby;

	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x38")]
	public Canvas Canvas;

	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x40")]
	private Camera camera;

	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x48")]
	public Animator HoldToExitAnimator;

	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x50")]
	public Image StatsPanelImage;

	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshProLocalized WinnerNameText;

	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI P1StrokesText;

	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI P2StrokesText;

	[Token(Token = "0x40003FF")]
	[FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI AllStrokesText;

	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI P1TimeText;

	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI P2TimeText;

	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI AllTimeText;

	[Token(Token = "0x4000403")]
	[FieldOffset(Offset = "0x90")]
	public TextMeshProLocalized P1TimeLabel;

	[Token(Token = "0x4000404")]
	[FieldOffset(Offset = "0x98")]
	public TextMeshProLocalized P2TimeLabel;

	[Token(Token = "0x4000405")]
	[FieldOffset(Offset = "0xA0")]
	public TextMeshProLocalized P1StrokeLabel;

	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0xA8")]
	public TextMeshProLocalized P2StrokeLabel;

	[Token(Token = "0x4000407")]
	[FieldOffset(Offset = "0xB0")]
	public Sprite defaultButtonSprite;

	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0xB8")]
	public Sprite playstationButtonSprite;

	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0xC0")]
	public SVGImage holdToExitButtonImage;

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x1755D94", Offset = "0x1755D94", VA = "0x1755D94")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x1755E64", Offset = "0x1755E64", VA = "0x1755E64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x1755F48", Offset = "0x1755F48", VA = "0x1755F48")]
	private void MatchEnded(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x175645C", Offset = "0x175645C", VA = "0x175645C")]
	private void SetMatchStats(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x1756B6C", Offset = "0x1756B6C", VA = "0x1756B6C")]
	private IEnumerator DelayStartCounting(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		return null;
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x1756DE0", Offset = "0x1756DE0", VA = "0x1756DE0")]
	private IEnumerator CountStats(MultiplayerConfiguration.PlayerInfo player, TextMeshProUGUI textField, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x1756E68", Offset = "0x1756E68", VA = "0x1756E68")]
	public void FinishCounting(string trigger)
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x1756E84", Offset = "0x1756E84", VA = "0x1756E84")]
	public WinSequence()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x1756BE4", Offset = "0x1756BE4", VA = "0x1756BE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E298", Offset = "0x5E298")]
	internal static string _003CSetMatchStats_003Eg__ToElapsedString_007C26_0(TimeSpan ts)
	{
		return null;
	}
}
