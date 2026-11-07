using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Token(Token = "0x2000E4D")]
public class EpisodeEntranceManager : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E4E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F88", Offset = "0x44F88")]
	private struct _003CStartPack_003Ed__28 : IAsyncStateMachine
	{
		[Token(Token = "0x4004D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EpisodeEntranceManager _003C_003E4__this;

		[Token(Token = "0x4004DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x4004DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x60042F9")]
		[Address(RVA = "0x179FA08", Offset = "0x179FA08", VA = "0x179FA08", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60042FA")]
		[Address(RVA = "0x179FDF4", Offset = "0x179FDF4", VA = "0x179FDF4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E4F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F98", Offset = "0x44F98")]
	private struct _003CExit_003Ed__29 : IAsyncStateMachine
	{
		[Token(Token = "0x4004DA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EpisodeEntranceManager _003C_003E4__this;

		[Token(Token = "0x4004DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60042FB")]
		[Address(RVA = "0x179F4D4", Offset = "0x179F4D4", VA = "0x179F4D4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60042FC")]
		[Address(RVA = "0x179F6A0", Offset = "0x179F6A0", VA = "0x179F6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44FA8", Offset = "0x44FA8")]
	private struct _003CPushAway_003Ed__30 : IAsyncStateMachine
	{
		[Token(Token = "0x4004DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EpisodeEntranceManager _003C_003E4__this;

		[Token(Token = "0x4004DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody2D _003Crigid_003E5__2;

		[Token(Token = "0x4004DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _003Ctime_003E5__3;

		[Token(Token = "0x4004DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _003C_003Eu__1;

		[Token(Token = "0x60042FD")]
		[Address(RVA = "0x179F6AC", Offset = "0x179F6AC", VA = "0x179F6AC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60042FE")]
		[Address(RVA = "0x179F9FC", Offset = "0x179F9FC", VA = "0x179F9FC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4004D8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _newBanner;

	[Token(Token = "0x4004D8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _completeBanner;

	[Token(Token = "0x4004D8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _nameBanner;

	[Token(Token = "0x4004D90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _progressBanner;

	[Token(Token = "0x4004D91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TMP_Text _progressText;

	[Token(Token = "0x4004D92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image _progressImg;

	[Token(Token = "0x4004D93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Animator _curtainsAnimator;

	[Token(Token = "0x4004D94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _animatedIllustrationPrefab;

	[Token(Token = "0x4004D95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform _animatedIllustrationContainer;

	[Token(Token = "0x4004D96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private TextMeshProLocalized _campaignNameText;

	[Token(Token = "0x4004D97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private TextMeshProLocalized _episodeText;

	[Token(Token = "0x4004D98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Color _bannerColor;

	[Token(Token = "0x4004D99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool isNew;

	[Token(Token = "0x4004D9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool packHasBeenEntered;

	[Token(Token = "0x4004D9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private string pack;

	[NonSerialized]
	[Token(Token = "0x4004D9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private ContentPackDef packDef;

	[Token(Token = "0x4004D9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private UnityAction<ContentPackDef> _startAction;

	[Token(Token = "0x170006DF")]
	public ContentPackDef PackDef
	{
		[Token(Token = "0x60042EC")]
		[Address(RVA = "0x1445568", Offset = "0x1445568", VA = "0x1445568")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E0")]
	public string adventureTitleID
	{
		[Token(Token = "0x60042F3")]
		[Address(RVA = "0x144590C", Offset = "0x144590C", VA = "0x144590C")]
		set
		{
		}
	}

	[Token(Token = "0x60042ED")]
	[Address(RVA = "0x14455A8", Offset = "0x14455A8", VA = "0x14455A8")]
	public void Start()
	{
	}

	[Token(Token = "0x60042EE")]
	[Address(RVA = "0x1445B10", Offset = "0x1445B10", VA = "0x1445B10")]
	private void UpdateProgress()
	{
	}

	[Token(Token = "0x60042EF")]
	[Address(RVA = "0x1445EC8", Offset = "0x1445EC8", VA = "0x1445EC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60042F0")]
	[Address(RVA = "0x1445ED0", Offset = "0x1445ED0", VA = "0x1445ED0")]
	public void OpenTheCurtains()
	{
	}

	[Token(Token = "0x60042F1")]
	[Address(RVA = "0x1445A1C", Offset = "0x1445A1C", VA = "0x1445A1C")]
	private void SetArtwork()
	{
	}

	[Token(Token = "0x60042F2")]
	[Address(RVA = "0x144584C", Offset = "0x144584C", VA = "0x144584C")]
	private void SetUpBannerColor()
	{
	}

	[Token(Token = "0x60042F4")]
	[Address(RVA = "0x1445C80", Offset = "0x1445C80", VA = "0x1445C80")]
	private void SetProgressText(float value)
	{
	}

	[Token(Token = "0x60042F5")]
	[Address(RVA = "0x1445FCC", Offset = "0x1445FCC", VA = "0x1445FCC")]
	public void StartPack()
	{
	}

	[Token(Token = "0x60042F6")]
	[Address(RVA = "0x1446064", Offset = "0x1446064", VA = "0x1446064")]
	private void Exit()
	{
	}

	[Token(Token = "0x60042F7")]
	[Address(RVA = "0x14460FC", Offset = "0x14460FC", VA = "0x14460FC")]
	private Task PushAway()
	{
		return null;
	}

	[Token(Token = "0x60042F8")]
	[Address(RVA = "0x14461D8", Offset = "0x14461D8", VA = "0x14461D8")]
	public EpisodeEntranceManager()
	{
	}
}
