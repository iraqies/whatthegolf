using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x200002E")]
	public class TimeNotificationBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x200002F")]
		private struct NotificationEntry
		{
			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0x0")]
			public double time;

			[Token(Token = "0x40000D5")]
			[FieldOffset(Offset = "0x8")]
			public INotification payload;

			[Token(Token = "0x40000D6")]
			[FieldOffset(Offset = "0x10")]
			public bool notificationFired;

			[Token(Token = "0x40000D7")]
			[FieldOffset(Offset = "0x12")]
			public NotificationFlags flags;

			[Token(Token = "0x17000092")]
			public bool triggerInEditor
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x2AEBD10", Offset = "0x2AEBD10", VA = "0x2AEBD10")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000093")]
			public bool prewarm
			{
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x2AEBD04", Offset = "0x2AEBD04", VA = "0x2AEBD04")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000094")]
			public bool triggerOnce
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x2AEB324", Offset = "0x2AEB324", VA = "0x2AEB324")]
				get
				{
					return default;
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BBA00", Offset = "0x1BBA00")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40000D8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40000D9")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<NotificationEntry> _003C_003E9__12_0;

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x2AFA068", Offset = "0x2AFA068", VA = "0x2AFA068")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x2AFA070", Offset = "0x2AFA070", VA = "0x2AFA070")]
			internal int _003CSortNotifications_003Eb__12_0(NotificationEntry x, NotificationEntry y)
			{
				return default;
			}
		}

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<NotificationEntry> m_Notifications;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x18")]
		private double m_PreviousTime;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x20")]
		private bool m_NeedSortNotifications;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x28")]
		private Playable m_TimeSource;

		[Token(Token = "0x17000091")]
		public Playable timeSource
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x2AEAFFC", Offset = "0x2AEAFFC", VA = "0x2AEAFFC")]
			set
			{
			}
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2AE9CCC", Offset = "0x2AE9CCC", VA = "0x2AE9CCC")]
		public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode)
		{
			return default;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2AE9E14", Offset = "0x2AE9E14", VA = "0x2AE9E14")]
		public void AddNotification(double time, INotification payload, NotificationFlags flags = NotificationFlags.Retroactive)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2AEB004", Offset = "0x2AEB004", VA = "0x2AEB004", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2AEB330", Offset = "0x2AEB330", VA = "0x2AEB330", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2AEB600", Offset = "0x2AEB600", VA = "0x2AEB600", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2AEB1D4", Offset = "0x2AEB1D4", VA = "0x2AEB1D4")]
		private void SortNotifications()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2AEBC8C", Offset = "0x2AEBC8C", VA = "0x2AEBC8C")]
		private static bool CanRestoreNotification(NotificationEntry e, FrameData info, double currentTime, double previousTime)
		{
			return default;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2AEBA7C", Offset = "0x2AEBA7C", VA = "0x2AEBA7C")]
		private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2AEB974", Offset = "0x2AEB974", VA = "0x2AEB974")]
		private void SyncDurationWithExternalSource(Playable playable)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2AEB56C", Offset = "0x2AEB56C", VA = "0x2AEB56C")]
		private static void Trigger_internal(Playable playable, PlayableOutput output, ref NotificationEntry e)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2AEBCFC", Offset = "0x2AEBCFC", VA = "0x2AEBCFC")]
		private static void Restore_internal(ref NotificationEntry e)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2AEBD1C", Offset = "0x2AEBD1C", VA = "0x2AEBD1C")]
		public TimeNotificationBehaviour()
		{
		}
	}
}
