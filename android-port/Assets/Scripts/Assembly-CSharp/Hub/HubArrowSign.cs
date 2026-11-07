using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x200107C")]
	public class HubArrowSign : MonoBehaviour
	{
		[Token(Token = "0x200107D")]
		public enum ContentType
		{
			[Token(Token = "0x40056CC")]
			SpecialNew = 0,
			[Token(Token = "0x40056CD")]
			EpisodesNew = 1,
			[Token(Token = "0x40056CE")]
			EpisodesContinue = 2,
			[Token(Token = "0x40056CF")]
			MainCampaignContinue = 3
		}

		[Token(Token = "0x200107E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4792C", Offset = "0x4792C")]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			[Token(Token = "0x40056D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string packConstant;

			[Token(Token = "0x60049FE")]
			[Address(RVA = "0x17C05E4", Offset = "0x17C05E4", VA = "0x17C05E4")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60049FF")]
			[Address(RVA = "0x17C05EC", Offset = "0x17C05EC", VA = "0x17C05EC")]
			internal bool _003CGoToSaveSpot_003Eb__0(SaveSpot s)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200107F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4793C", Offset = "0x4793C")]
		private struct _003CGoToSaveSpot_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40056D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string packConstant;

			[Token(Token = "0x40056D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HubArrowSign _003C_003E4__this;

			[Token(Token = "0x40056D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private SaveSpot _003CsaveSpot_003E5__2;

			[Token(Token = "0x40056D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private OverworldBall2D _003Cball_003E5__3;

			[Token(Token = "0x40056D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6004A00")]
			[Address(RVA = "0x17C06B4", Offset = "0x17C06B4", VA = "0x17C06B4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6004A01")]
			[Address(RVA = "0x17C0C38", Offset = "0x17C0C38", VA = "0x17C0C38", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40056C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ContentType contentType;

		[Token(Token = "0x40056C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ShortcutTunnel shortcutTunnel;

		[Token(Token = "0x40056C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SaveSpot> saveSpots;

		[Token(Token = "0x40056C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float ballSpeed;

		[Token(Token = "0x40056CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool _isInitialized;

		[Token(Token = "0x60049F4")]
		[Address(RVA = "0x14DDDFC", Offset = "0x14DDDFC", VA = "0x14DDDFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60049F5")]
		[Address(RVA = "0x14DDE38", Offset = "0x14DDE38", VA = "0x14DDE38")]
		private void Init()
		{
		}

		[Token(Token = "0x60049F6")]
		[Address(RVA = "0x14DDF6C", Offset = "0x14DDF6C", VA = "0x14DDF6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60049F7")]
		[Address(RVA = "0x14DDE50", Offset = "0x14DDE50", VA = "0x14DDE50")]
		private void SetState()
		{
		}

		[Token(Token = "0x60049F8")]
		[Address(RVA = "0x14DDF7C", Offset = "0x14DDF7C", VA = "0x14DDF7C")]
		private bool ShouldShow()
		{
			return default;
		}

		[Token(Token = "0x60049F9")]
		[Address(RVA = "0x14DE184", Offset = "0x14DE184", VA = "0x14DE184")]
		private bool ShouldShowEpisodesContinue(ECampaignType lastPlayedCampaignType)
		{
			return default;
		}

		[Token(Token = "0x60049FA")]
		[Address(RVA = "0x14DDEBC", Offset = "0x14DDEBC", VA = "0x14DDEBC")]
		private void SubscribeToTunnel()
		{
		}

		[Token(Token = "0x60049FB")]
		[Address(RVA = "0x14DE21C", Offset = "0x14DE21C", VA = "0x14DE21C")]
		private void BallExitedTunnel(ShortcutTunnel tunnel)
		{
		}

		[Token(Token = "0x60049FC")]
		[Address(RVA = "0x14DE3D8", Offset = "0x14DE3D8", VA = "0x14DE3D8")]
		private void GoToSaveSpot(string packConstant)
		{
		}

		[Token(Token = "0x60049FD")]
		[Address(RVA = "0x14DE478", Offset = "0x14DE478", VA = "0x14DE478")]
		public HubArrowSign()
		{
		}
	}
}
