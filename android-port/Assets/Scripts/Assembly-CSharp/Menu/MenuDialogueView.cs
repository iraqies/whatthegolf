using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Menu
{
	[Token(Token = "0x2001067")]
	public class MenuDialogueView : ShowSpeechBubble
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001068")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x477D4", Offset = "0x477D4")]
		private struct _003COnEnable_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x400567C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400567D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400567E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MenuDialogueView _003C_003E4__this;

			[Token(Token = "0x400567F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private MenuDialogueConfig.Entry _003Centry_003E5__2;

			[Token(Token = "0x4005680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private MenuDialogueConfig.Entry _003Ccopy_003E5__3;

			[Token(Token = "0x4005681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60049A2")]
			[Address(RVA = "0x17F5E28", Offset = "0x17F5E28", VA = "0x17F5E28", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60049A3")]
			[Address(RVA = "0x17F658C", Offset = "0x17F658C", VA = "0x17F658C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x477E4", Offset = "0x477E4")]
		private struct _003COnTriggerEnter2D_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4005682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MenuDialogueView _003C_003E4__this;

			[Token(Token = "0x4005685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Collider2D other;

			[Token(Token = "0x4005686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60049A4")]
			[Address(RVA = "0x17F6598", Offset = "0x17F6598", VA = "0x17F6598", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60049A5")]
			[Address(RVA = "0x17F67BC", Offset = "0x17F67BC", VA = "0x17F67BC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200106A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x477F4", Offset = "0x477F4")]
		private struct _003CAutoShowSpeechBubble_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4005687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MenuDialogueView _003C_003E4__this;

			[Token(Token = "0x60049A6")]
			[Address(RVA = "0x17F5BC0", Offset = "0x17F5BC0", VA = "0x17F5BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60049A7")]
			[Address(RVA = "0x17F5E1C", Offset = "0x17F5E1C", VA = "0x17F5E1C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200106B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47804", Offset = "0x47804")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x400568A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MenuDialogueView _003C_003E4__this;

			[Token(Token = "0x400568B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int hitCount;

			[Token(Token = "0x400568C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MenuDialogueConfig.Entry entry;

			[Token(Token = "0x400568D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action _003C_003E9__1;

			[Token(Token = "0x60049A8")]
			[Address(RVA = "0x17F59CC", Offset = "0x17F59CC", VA = "0x17F59CC")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60049A9")]
			[Address(RVA = "0x17F59D4", Offset = "0x17F59D4", VA = "0x17F59D4")]
			internal void _003CWaitForHit_003Eb__0()
			{
			}

			[Token(Token = "0x60049AA")]
			[Address(RVA = "0x17F5AF0", Offset = "0x17F5AF0", VA = "0x17F5AF0")]
			internal void _003CWaitForHit_003Eb__1()
			{
			}

			[Token(Token = "0x60049AB")]
			[Address(RVA = "0x17F5B1C", Offset = "0x17F5B1C", VA = "0x17F5B1C")]
			internal void _003CWaitForHit_003Eb__2()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200106C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47814", Offset = "0x47814")]
		private struct _003CWaitForHit_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400568E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400568F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MenuDialogueView _003C_003E4__this;

			[Token(Token = "0x4005691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MenuDialogueConfig.Entry entry;

			[Token(Token = "0x4005692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

			[Token(Token = "0x4005693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x4005694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60049AC")]
			[Address(RVA = "0x17F67C8", Offset = "0x17F67C8", VA = "0x17F67C8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60049AD")]
			[Address(RVA = "0x17F6E0C", Offset = "0x17F6E0C", VA = "0x17F6E0C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MenuDialogueConfig config;

		[Token(Token = "0x4005674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform bubblePosition;

		[Token(Token = "0x4005675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ShowSpeechbubbleOnHit showSpeechbubbleOnHit;

		[Token(Token = "0x4005676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject exclamation;

		[Token(Token = "0x4005677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject bonusArrowHighlight;

		[Token(Token = "0x4005678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject episodesArrowHighlight;

		[Token(Token = "0x4005679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform turtleTransform;

		[Token(Token = "0x400567A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool shouldAutoShowSpeechBubble;

		[Token(Token = "0x400567B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private MenuDialogueConfig.Entry welcomeEntry;

		[Token(Token = "0x6004999")]
		[Address(RVA = "0x1562024", Offset = "0x1562024", VA = "0x1562024")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600499A")]
		[Address(RVA = "0x15620C0", Offset = "0x15620C0", VA = "0x15620C0")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600499B")]
		[Address(RVA = "0x156215C", Offset = "0x156215C", VA = "0x156215C")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600499C")]
		[Address(RVA = "0x1562228", Offset = "0x1562228", VA = "0x1562228")]
		private void RemoveAutoSpeechBubble()
		{
		}

		[Token(Token = "0x600499D")]
		[Address(RVA = "0x15622D8", Offset = "0x15622D8", VA = "0x15622D8")]
		private Task AutoShowSpeechBubble()
		{
			return null;
		}

		[Token(Token = "0x600499E")]
		[Address(RVA = "0x15623B4", Offset = "0x15623B4", VA = "0x15623B4")]
		private void WaitForHit(MenuDialogueConfig.Entry entry)
		{
		}

		[Token(Token = "0x600499F")]
		[Address(RVA = "0x1562454", Offset = "0x1562454", VA = "0x1562454")]
		private void ShowEffects(MenuDialogueConfig.EffectType effectType)
		{
		}

		[Token(Token = "0x60049A0")]
		[Address(RVA = "0x1562638", Offset = "0x1562638", VA = "0x1562638")]
		public MenuDialogueView()
		{
		}

		[Token(Token = "0x60049A1")]
		[Address(RVA = "0x1562640", Offset = "0x1562640", VA = "0x1562640")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F2E4", Offset = "0x6F2E4")]
		private void _003CShowEffects_003Eb__15_0(float f)
		{
		}
	}
}
