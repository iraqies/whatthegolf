using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
	[Token(Token = "0x2001054")]
	public class Menu : AddressableSingleton<Menu>
	{
		[Token(Token = "0x2001055")]
		public enum Location
		{
			[Token(Token = "0x4005632")]
			Hub = 0,
			[Token(Token = "0x4005633")]
			MainCampaign = 1,
			[Token(Token = "0x4005634")]
			Other = 2
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001056")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47744", Offset = "0x47744")]
		private struct _003CShowAndAwait_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x4005635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Menu _003C_003E4__this;

			[Token(Token = "0x4005638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x6004972")]
			[Address(RVA = "0x17F51B4", Offset = "0x17F51B4", VA = "0x17F51B4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6004973")]
			[Address(RVA = "0x17F53F4", Offset = "0x17F53F4", VA = "0x17F53F4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001057")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47754", Offset = "0x47754")]
		private struct _003CShow_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4005639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400563A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400563B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Menu _003C_003E4__this;

			[Token(Token = "0x400563C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6004974")]
			[Address(RVA = "0x17F484C", Offset = "0x17F484C", VA = "0x17F484C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6004975")]
			[Address(RVA = "0x17F51A8", Offset = "0x17F51A8", VA = "0x17F51A8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001058")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47764", Offset = "0x47764")]
		private struct _003CClose_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x400563D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400563E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400563F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Menu _003C_003E4__this;

			[Token(Token = "0x4005640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6004976")]
			[Address(RVA = "0x17F3B04", Offset = "0x17F3B04", VA = "0x17F3B04", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6004977")]
			[Address(RVA = "0x17F3C98", Offset = "0x17F3C98", VA = "0x17F3C98", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001059")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47774", Offset = "0x47774")]
		private struct _003CCloseAsync_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4005641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Menu _003C_003E4__this;

			[Token(Token = "0x4005644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6004978")]
			[Address(RVA = "0x17F3CA4", Offset = "0x17F3CA4", VA = "0x17F3CA4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6004979")]
			[Address(RVA = "0x17F4048", Offset = "0x17F4048", VA = "0x17F4048", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200105A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47784", Offset = "0x47784")]
		private struct _003COnHubButtonClicked_003Ed__35 : IAsyncStateMachine
		{
			[Token(Token = "0x4005645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Menu _003C_003E4__this;

			[Token(Token = "0x4005648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600497A")]
			[Address(RVA = "0x17F4280", Offset = "0x17F4280", VA = "0x17F4280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600497B")]
			[Address(RVA = "0x17F4560", Offset = "0x17F4560", VA = "0x17F4560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200105B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47794", Offset = "0x47794")]
		private struct _003CSettingsButtonClicked_003Ed__36 : IAsyncStateMachine
		{
			[Token(Token = "0x4005649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400564A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400564B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Menu _003C_003E4__this;

			[Token(Token = "0x400564C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600497C")]
			[Address(RVA = "0x17F456C", Offset = "0x17F456C", VA = "0x17F456C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600497D")]
			[Address(RVA = "0x17F4840", Offset = "0x17F4840", VA = "0x17F4840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200105C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x477A4", Offset = "0x477A4")]
		private struct _003CCloseButtonClicked_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x400564D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400564E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400564F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Menu _003C_003E4__this;

			[Token(Token = "0x4005650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600497E")]
			[Address(RVA = "0x17F4054", Offset = "0x17F4054", VA = "0x17F4054", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600497F")]
			[Address(RVA = "0x17F4274", Offset = "0x17F4274", VA = "0x17F4274", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400561E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimateRectTransform buttonAnimator;

		[Token(Token = "0x400561F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimateRectTransform teleportAnimatorPortrait;

		[Token(Token = "0x4005620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimateRectTransform teleportAnimatorLandscape;

		[Token(Token = "0x4005621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform buttonsAndLogoParent;

		[Token(Token = "0x4005622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button quitButton;

		[Token(Token = "0x4005623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button hubButton;

		[Token(Token = "0x4005624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button settingsButton;

		[Token(Token = "0x4005625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private OverworldTeleportMenu teleportMenuPortrait;

		[Token(Token = "0x4005626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private OverworldTeleportMenu teleportMenuLandscape;

		[Token(Token = "0x4005627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MainMenuGameCenterAccessPointButton accessPointButton;

		[Token(Token = "0x4005628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button defaultCloseButton;

		[Token(Token = "0x4005629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button landscapeMainCampaignCloseButton;

		[Token(Token = "0x400562A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasScaler canvasScaler;

		[Token(Token = "0x400562B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float buttonsPortraitOffset;

		[Token(Token = "0x400562C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float buttonsLandscapeOfset;

		[Token(Token = "0x400562D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public ClipSettingsCollection OpenSFX;

		[Token(Token = "0x400562E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TaskCompletionSource<bool> tcs;

		[Token(Token = "0x400562F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Location _location;

		[Token(Token = "0x4005630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _isInteractable;

		[Token(Token = "0x170007BD")]
		private bool IsPortrait
		{
			[Token(Token = "0x600495F")]
			[Address(RVA = "0x1560550", Offset = "0x1560550", VA = "0x1560550")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170007BE")]
		private OverworldTeleportMenu currentTeleportMenu
		{
			[Token(Token = "0x6004960")]
			[Address(RVA = "0x1560584", Offset = "0x1560584", VA = "0x1560584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007BF")]
		private OverworldTeleportMenu otherTeleportMenu
		{
			[Token(Token = "0x6004961")]
			[Address(RVA = "0x15605C8", Offset = "0x15605C8", VA = "0x15605C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004962")]
		[Address(RVA = "0x156060C", Offset = "0x156060C", VA = "0x156060C")]
		public bool IsOpen()
		{
			return default;
		}

		[Token(Token = "0x6004963")]
		[Address(RVA = "0x1560630", Offset = "0x1560630", VA = "0x1560630")]
		public Task ShowAndAwait()
		{
			return null;
		}

		[Token(Token = "0x6004964")]
		[Address(RVA = "0x156070C", Offset = "0x156070C", VA = "0x156070C")]
		public void Init()
		{
		}

		[Token(Token = "0x6004965")]
		[Address(RVA = "0x1560728", Offset = "0x1560728", VA = "0x1560728")]
		public void Show()
		{
		}

		[Token(Token = "0x6004966")]
		[Address(RVA = "0x15607C0", Offset = "0x15607C0", VA = "0x15607C0")]
		private Location GetLocation()
		{
			return default;
		}

		[Token(Token = "0x6004967")]
		[Address(RVA = "0x15607F8", Offset = "0x15607F8", VA = "0x15607F8")]
		private void SetButtonPositions(bool isInMainCampaign)
		{
		}

		[Token(Token = "0x6004968")]
		[Address(RVA = "0x1560938", Offset = "0x1560938", VA = "0x1560938")]
		private void Update()
		{
		}

		[Token(Token = "0x6004969")]
		[Address(RVA = "0x1560AB4", Offset = "0x1560AB4", VA = "0x1560AB4")]
		public void Close()
		{
		}

		[Token(Token = "0x600496A")]
		[Address(RVA = "0x1560B4C", Offset = "0x1560B4C", VA = "0x1560B4C")]
		public Task CloseAsync()
		{
			return null;
		}

		[Token(Token = "0x600496B")]
		[Address(RVA = "0x1560C28", Offset = "0x1560C28", VA = "0x1560C28")]
		public void OnQuitButtonClicked()
		{
		}

		[Token(Token = "0x600496C")]
		[Address(RVA = "0x1560C30", Offset = "0x1560C30", VA = "0x1560C30")]
		public void OnHubButtonClicked()
		{
		}

		[Token(Token = "0x600496D")]
		[Address(RVA = "0x1560CC8", Offset = "0x1560CC8", VA = "0x1560CC8")]
		public void SettingsButtonClicked()
		{
		}

		[Token(Token = "0x600496E")]
		[Address(RVA = "0x1560A1C", Offset = "0x1560A1C", VA = "0x1560A1C")]
		public void CloseButtonClicked()
		{
		}

		[Token(Token = "0x600496F")]
		[Address(RVA = "0x1560D60", Offset = "0x1560D60", VA = "0x1560D60")]
		private void DisableInteraction()
		{
		}

		[Token(Token = "0x6004970")]
		[Address(RVA = "0x1560D68", Offset = "0x1560D68", VA = "0x1560D68")]
		private void EnableInteraction()
		{
		}

		[Token(Token = "0x6004971")]
		[Address(RVA = "0x1560D74", Offset = "0x1560D74", VA = "0x1560D74")]
		public Menu()
		{
		}
	}
}
