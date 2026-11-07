using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

[Token(Token = "0x20001AD")]
public class MainMenuGameCenterAccessPointButton : MainMenu2Button
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20001AE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DFB0", Offset = "0x3DFB0")]
	private struct _003CShow_003Ed__0 : IAsyncStateMachine
	{
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MainMenuGameCenterAccessPointButton _003C_003E4__this;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object _003C_003Eu__1;

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x17F1EFC", Offset = "0x17F1EFC", VA = "0x17F1EFC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x17F2208", Offset = "0x17F2208", VA = "0x17F2208", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private bool _wasPresentingGameCenter;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private EventSystem _eventSystem;

	[Token(Token = "0x17000101")]
	private bool IsGameCenterPopupOpen
	{
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1559010", Offset = "0x1559010", VA = "0x1559010")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x1558F78", Offset = "0x1558F78", VA = "0x1558F78")]
	public void Show()
	{
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0x1559038", Offset = "0x1559038", VA = "0x1559038")]
	private void Update()
	{
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0x1559124", Offset = "0x1559124", VA = "0x1559124", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x1559140", Offset = "0x1559140", VA = "0x1559140", Slot = "42")]
	public override void OnSubmit(BaseEventData eventData)
	{
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x1559148", Offset = "0x1559148", VA = "0x1559148", Slot = "36")]
	public override void OnSelect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x155917C", Offset = "0x155917C", VA = "0x155917C", Slot = "37")]
	public override void OnDeselect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x1559184", Offset = "0x1559184", VA = "0x1559184")]
	public MainMenuGameCenterAccessPointButton()
	{
	}
}
