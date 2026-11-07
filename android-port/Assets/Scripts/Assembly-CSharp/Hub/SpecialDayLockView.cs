using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x2001087")]
	public class SpecialDayLockView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001088")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x479E4", Offset = "0x479E4")]
		private struct _003CUnlock_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40056F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool immediate;

			[Token(Token = "0x40056F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SpecialDayLockView _003C_003E4__this;

			[Token(Token = "0x40056F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6004A23")]
			[Address(RVA = "0x18547F8", Offset = "0x18547F8", VA = "0x18547F8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6004A24")]
			[Address(RVA = "0x1854AEC", Offset = "0x1854AEC", VA = "0x1854AEC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40056ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x40056EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpecialDayOverworldButton2D door;

		[Token(Token = "0x40056EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Open;

		[Token(Token = "0x40056F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int Shake1;

		[Token(Token = "0x40056F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int Locked;

		[Token(Token = "0x6004A1B")]
		[Address(RVA = "0x16CA310", Offset = "0x16CA310", VA = "0x16CA310")]
		public void OnCollisionEnter2D(Collision2D other)
		{
		}

		[Token(Token = "0x6004A1C")]
		[Address(RVA = "0x16CA7D4", Offset = "0x16CA7D4", VA = "0x16CA7D4")]
		public void SetState(bool active, bool hasBeenOpenedBefore)
		{
		}

		[Token(Token = "0x6004A1D")]
		[Address(RVA = "0x16CA964", Offset = "0x16CA964", VA = "0x16CA964")]
		private void Shake()
		{
		}

		[Token(Token = "0x6004A1E")]
		[Address(RVA = "0x16CA9F0", Offset = "0x16CA9F0", VA = "0x16CA9F0")]
		public void Unlock(bool immediate)
		{
		}

		[Token(Token = "0x6004A1F")]
		[Address(RVA = "0x16CAB38", Offset = "0x16CAB38", VA = "0x16CAB38")]
		private float GetAnimationDuration()
		{
			return default;
		}

		[Token(Token = "0x6004A20")]
		[Address(RVA = "0x16CAA90", Offset = "0x16CAA90", VA = "0x16CAA90")]
		private void Lock()
		{
		}

		[Token(Token = "0x6004A21")]
		[Address(RVA = "0x16CAB40", Offset = "0x16CAB40", VA = "0x16CAB40")]
		public SpecialDayLockView()
		{
		}
	}
}
