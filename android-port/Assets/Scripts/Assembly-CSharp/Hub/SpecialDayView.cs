using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x200108D")]
	public class SpecialDayView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200108E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47A04", Offset = "0x47A04")]
		private struct _003COnPackStarted_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x400570F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ContentPack pack;

			[Token(Token = "0x4005712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SpecialDayView _003C_003E4__this;

			[Token(Token = "0x6004A3B")]
			[Address(RVA = "0x1856328", Offset = "0x1856328", VA = "0x1856328", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6004A3C")]
			[Address(RVA = "0x1856574", Offset = "0x1856574", VA = "0x1856574", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200108F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47A14", Offset = "0x47A14")]
		private struct _003CReloadScene_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4005713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6004A3D")]
			[Address(RVA = "0x1856580", Offset = "0x1856580", VA = "0x1856580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6004A3E")]
			[Address(RVA = "0x1856744", Offset = "0x1856744", VA = "0x1856744", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject defaultRoomDressing;

		[Token(Token = "0x4005705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpecialDayCalendar calendar;

		[Token(Token = "0x4005706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform roomDressingParent;

		[Token(Token = "0x4005707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SpecialDayOverworldButton2D door;

		[Token(Token = "0x4005708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SpecialDayCountdown countdown;

		[Token(Token = "0x4005709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BoxCollider2D boxCollider;

		[Token(Token = "0x400570A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TMP_Text debugText;

		[Token(Token = "0x400570B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_Text titleText;

		[Token(Token = "0x400570C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SpecialDayLockView lockView;

		[Token(Token = "0x400570D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SpecialDayStage _stage;

		[Token(Token = "0x400570E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _currentStageDressing;

		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x16CBAA0", Offset = "0x16CBAA0", VA = "0x16CBAA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x16CBF3C", Offset = "0x16CBF3C", VA = "0x16CBF3C")]
		private void OnPackStarted(ContentPack pack)
		{
		}

		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x16CBFDC", Offset = "0x16CBFDC", VA = "0x16CBFDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x16CBBC0", Offset = "0x16CBBC0", VA = "0x16CBBC0")]
		private void Apply(SpecialDayStage currentStage)
		{
		}

		[Token(Token = "0x6004A38")]
		[Address(RVA = "0x16CC060", Offset = "0x16CC060", VA = "0x16CC060")]
		private void ReloadScene()
		{
		}

		[Token(Token = "0x6004A39")]
		[Address(RVA = "0x16CB314", Offset = "0x16CB314", VA = "0x16CB314")]
		public void MarkDoorAsOpened()
		{
		}

		[Token(Token = "0x6004A3A")]
		[Address(RVA = "0x16CC0E8", Offset = "0x16CC0E8", VA = "0x16CC0E8")]
		public SpecialDayView()
		{
		}
	}
}
