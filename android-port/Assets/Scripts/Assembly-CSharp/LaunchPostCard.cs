using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D03")]
public class LaunchPostCard : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000D04")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x44648", Offset = "0x44648")]
	private struct _003CClose_003Ed__11 : IAsyncStateMachine
	{
		[Token(Token = "0x40046B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40046B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40046B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LaunchPostCard _003C_003E4__this;

		[Token(Token = "0x40046BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003D83")]
		[Address(RVA = "0x17CEC30", Offset = "0x17CEC30", VA = "0x17CEC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003D84")]
		[Address(RVA = "0x17CEF04", Offset = "0x17CEF04", VA = "0x17CEF04", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000D05")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x44658", Offset = "0x44658")]
	private struct _003CExit_003Ed__13 : IAsyncStateMachine
	{
		[Token(Token = "0x40046BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40046BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40046BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LaunchPostCard _003C_003E4__this;

		[Token(Token = "0x40046BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003D85")]
		[Address(RVA = "0x17CEF10", Offset = "0x17CEF10", VA = "0x17CEF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003D86")]
		[Address(RVA = "0x17CF10C", Offset = "0x17CF10C", VA = "0x17CF10C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40046B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MainMenu2Button exit;

	[Token(Token = "0x40046B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MainMenu2Button toMenu;

	[Token(Token = "0x40046B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MainMenu2Button selected;

	[Token(Token = "0x40046B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject PostCard;

	[Token(Token = "0x40046B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Animator animator;

	[Token(Token = "0x40046B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isOpen;

	[Token(Token = "0x40046B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool busyClosing;

	[Token(Token = "0x6003D78")]
	[Address(RVA = "0x151E96C", Offset = "0x151E96C", VA = "0x151E96C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003D79")]
	[Address(RVA = "0x151EA24", Offset = "0x151EA24", VA = "0x151EA24")]
	private void OnLastFlagCompleted(LevelData lastFlagLevelData)
	{
	}

	[Token(Token = "0x6003D7A")]
	[Address(RVA = "0x151EA50", Offset = "0x151EA50", VA = "0x151EA50")]
	public void LaunchCardAnimation()
	{
	}

	[Token(Token = "0x6003D7B")]
	[Address(RVA = "0x151EC5C", Offset = "0x151EC5C", VA = "0x151EC5C")]
	private static void DisableUI()
	{
	}

	[Token(Token = "0x6003D7C")]
	[Address(RVA = "0x151EC84", Offset = "0x151EC84", VA = "0x151EC84")]
	private static void EnableUI()
	{
	}

	[Token(Token = "0x6003D7D")]
	[Address(RVA = "0x151ECA8", Offset = "0x151ECA8", VA = "0x151ECA8")]
	public void Close()
	{
	}

	[Token(Token = "0x6003D7E")]
	[Address(RVA = "0x151ED40", Offset = "0x151ED40", VA = "0x151ED40")]
	public void Exit()
	{
	}

	[Token(Token = "0x6003D7F")]
	[Address(RVA = "0x151EDD8", Offset = "0x151EDD8", VA = "0x151EDD8")]
	private void SetSelectedButtonExit()
	{
	}

	[Token(Token = "0x6003D80")]
	[Address(RVA = "0x151EDE4", Offset = "0x151EDE4", VA = "0x151EDE4")]
	private void SetSelectedButtonToMenu()
	{
	}

	[Token(Token = "0x6003D81")]
	[Address(RVA = "0x151EDF0", Offset = "0x151EDF0", VA = "0x151EDF0")]
	private void Update()
	{
	}

	[Token(Token = "0x6003D82")]
	[Address(RVA = "0x151F008", Offset = "0x151F008", VA = "0x151F008")]
	public LaunchPostCard()
	{
	}
}
