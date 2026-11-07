using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x200008F")]
public class Bootstrap : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000090")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D688", Offset = "0x3D688")]
	private struct _003CStart_003Ed__2 : IAsyncStateMachine
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Bootstrap _003C_003E4__this;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperationHandle<SceneInstance> _003Chandle_003E5__2;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private object _003C_003Eu__2;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1773EF0", Offset = "0x1773EF0", VA = "0x1773EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x17745C8", Offset = "0x17745C8", VA = "0x17745C8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000091")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D698", Offset = "0x3D698")]
	private struct _003CAwaitSplash_003Ed__3 : IAsyncStateMachine
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Bootstrap _003C_003E4__this;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object _003C_003Eu__1;

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1773C4C", Offset = "0x1773C4C", VA = "0x1773C4C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1773EE4", Offset = "0x1773EE4", VA = "0x1773EE4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AASplashScreen arcadeSplashScreen;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject SplashScreensContainer;

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x16F9D60", Offset = "0x16F9D60", VA = "0x16F9D60")]
	private void Start()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x16F9DFC", Offset = "0x16F9DFC", VA = "0x16F9DFC")]
	private Task AwaitSplash()
	{
		return null;
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x16F9ED8", Offset = "0x16F9ED8", VA = "0x16F9ED8")]
	private void SetWindowSize()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x16F9F80", Offset = "0x16F9F80", VA = "0x16F9F80")]
	private void SetOrientation()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x16FA16C", Offset = "0x16FA16C", VA = "0x16FA16C")]
	public Bootstrap()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x16FA174", Offset = "0x16FA174", VA = "0x16FA174")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5DAD0", Offset = "0x5DAD0")]
	private void _003CAwaitSplash_003Eb__3_0()
	{
	}
}
