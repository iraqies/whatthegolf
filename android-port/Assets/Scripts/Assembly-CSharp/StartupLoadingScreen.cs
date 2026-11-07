using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A4")]
public class StartupLoadingScreen : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000A5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D7B0", Offset = "0x3D7B0")]
	private struct _003CShow_003Ed__4 : IAsyncStateMachine
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StartupLoadingScreen _003C_003E4__this;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x185A314", Offset = "0x185A314", VA = "0x185A314", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x185A548", Offset = "0x185A548", VA = "0x185A548", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static StartupLoadingScreen Instance;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SVGImage image;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimateRectTransform animateRectTransform;

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x16DB824", Offset = "0x16DB824", VA = "0x16DB824")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x16DB8C8", Offset = "0x16DB8C8", VA = "0x16DB8C8")]
	public Task Show()
	{
		return null;
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x16DB9A4", Offset = "0x16DB9A4", VA = "0x16DB9A4")]
	public void Hide()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x16DB9C0", Offset = "0x16DB9C0", VA = "0x16DB9C0")]
	public StartupLoadingScreen()
	{
	}
}
