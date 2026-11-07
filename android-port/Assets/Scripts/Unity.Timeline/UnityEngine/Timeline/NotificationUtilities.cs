using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	internal static class NotificationUtilities
	{
		public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, GameObject go)
		{
			return default;
		}

		public static bool TrackTypeSupportsNotifications(Type type)
		{
			return false;
		}
	}
}
