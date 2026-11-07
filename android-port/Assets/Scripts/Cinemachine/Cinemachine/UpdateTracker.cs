using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000079")]
	internal class UpdateTracker
	{
		[Token(Token = "0x200007A")]
		public enum UpdateClock
		{
			[Token(Token = "0x40002AF")]
			Fixed = 0,
			[Token(Token = "0x40002B0")]
			Late = 1
		}

		[Token(Token = "0x200007B")]
		private class UpdateStatus
		{
			[Token(Token = "0x40002B1")]
			[FieldOffset(Offset = "0x10")]
			private int windowStart;

			[Token(Token = "0x40002B2")]
			[FieldOffset(Offset = "0x14")]
			private int numWindowLateUpdateMoves;

			[Token(Token = "0x40002B3")]
			[FieldOffset(Offset = "0x18")]
			private int numWindowFixedUpdateMoves;

			[Token(Token = "0x40002B4")]
			[FieldOffset(Offset = "0x1C")]
			private int numWindows;

			[Token(Token = "0x40002B5")]
			[FieldOffset(Offset = "0x20")]
			private int lastFrameUpdated;

			[Token(Token = "0x40002B6")]
			[FieldOffset(Offset = "0x24")]
			private Matrix4x4 lastPos;

			[Token(Token = "0x40002B7")]
			[FieldOffset(Offset = "0x64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x793C8", Offset = "0x793C8")]
			private UpdateClock PreferredUpdate__BackingField;

			[Token(Token = "0x170000CD")]
			public UpdateClock PreferredUpdate
			{
				[Token(Token = "0x60002F8")]
				[Address(RVA = "0x1911D34", Offset = "0x1911D34", VA = "0x1911D34")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B38", Offset = "0x79B38")]
				get
				{
					return default;
				}
				[Token(Token = "0x60002F9")]
				[Address(RVA = "0x1911D3C", Offset = "0x1911D3C", VA = "0x1911D3C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B48", Offset = "0x79B48")]
				private set
				{
				}
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x190E350", Offset = "0x190E350", VA = "0x190E350")]
			public UpdateStatus(int currentFrame, Matrix4x4 pos)
			{
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x190E03C", Offset = "0x190E03C", VA = "0x190E03C")]
			public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos)
			{
			}
		}

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Transform, UpdateStatus> mUpdateStatus;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x8")]
		private static List<Transform> sToDelete;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x10")]
		private static float mLastUpdateTime;

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x190DBD0", Offset = "0x190DBD0", VA = "0x190DBD0")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x79B28", Offset = "0x79B28")]
		private static void InitializeModule()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x190DC54", Offset = "0x190DC54", VA = "0x190DC54")]
		private static void UpdateTargets(UpdateClock currentClock)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x190E174", Offset = "0x190E174", VA = "0x190E174")]
		public static UpdateClock GetPreferredUpdate(Transform target)
		{
			return default;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x190E3B4", Offset = "0x190E3B4", VA = "0x190E3B4")]
		public static void OnUpdate(UpdateClock currentClock)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x190E484", Offset = "0x190E484", VA = "0x190E484")]
		public UpdateTracker()
		{
		}
	}
}
