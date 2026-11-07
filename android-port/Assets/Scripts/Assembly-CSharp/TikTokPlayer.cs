using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Video;

[Token(Token = "0x20001BF")]
public class TikTokPlayer : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20001C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E020", Offset = "0x3E020")]
	private struct _003CStart_003Ed__10 : IAsyncStateMachine
	{
		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TikTokPlayer _003C_003E4__this;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1866C6C", Offset = "0x1866C6C", VA = "0x1866C6C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1866E24", Offset = "0x1866E24", VA = "0x1866E24", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20001C1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E030", Offset = "0x3E030")]
	private struct _003CInitVideoPlayer_003Ed__11 : IAsyncStateMachine
	{
		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TikTokPlayer _003C_003E4__this;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Cindex_003E5__2;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<ODRDownloadResult> _003C_003Eu__1;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _003C_003Eu__2;

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x18662F4", Offset = "0x18662F4", VA = "0x18662F4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1866C60", Offset = "0x1866C60", VA = "0x1866C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40007D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SVGImage playImage;

	[Token(Token = "0x40007D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float distanceTolerance;

	[Token(Token = "0x40007D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x40007DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject loading;

	[Token(Token = "0x40007DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AssetReference[] videoClips;

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Camera camera;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioSource audioSource;

	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _isInitiated;

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool _isCentered;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	private bool _wasCentered;

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x171392C", Offset = "0x171392C", VA = "0x171392C")]
	private void Start()
	{
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x17139C4", Offset = "0x17139C4", VA = "0x17139C4")]
	private Task InitVideoPlayer()
	{
		return null;
	}

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x1713AA0", Offset = "0x1713AA0", VA = "0x1713AA0")]
	private int GetVideoIndex()
	{
		return default;
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x1713BE4", Offset = "0x1713BE4", VA = "0x1713BE4")]
	private void Update()
	{
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x1713CC4", Offset = "0x1713CC4", VA = "0x1713CC4")]
	private bool IsCentered()
	{
		return default;
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x1713DF0", Offset = "0x1713DF0", VA = "0x1713DF0")]
	public void OnPlayClicked()
	{
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x1713D80", Offset = "0x1713D80", VA = "0x1713D80")]
	private void PauseOrPlay(bool shouldPlay)
	{
	}

	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x1713E28", Offset = "0x1713E28", VA = "0x1713E28")]
	public void OnGoToTikTokClicked()
	{
	}

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x1713E70", Offset = "0x1713E70", VA = "0x1713E70")]
	public TikTokPlayer()
	{
	}
}
