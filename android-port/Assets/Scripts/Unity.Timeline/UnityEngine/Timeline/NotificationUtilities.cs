using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x200003E")]
	internal static class NotificationUtilities
	{
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2AE93B4", Offset = "0x2AE93B4", VA = "0x2AE93B4")]
		public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, GameObject go)
		{
			return default;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2AE9EB0", Offset = "0x2AE9EB0", VA = "0x2AE9EB0")]
		public static bool TrackTypeSupportsNotifications(Type type)
		{
			return default;
		}
	}
}
