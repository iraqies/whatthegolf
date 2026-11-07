using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prime31
{
	public class LifecycleHelper : MonoBehaviour
	{
		[CompilerGenerated]
		private Action<bool> m_onApplicationPausedEvent;

		public event Action<bool> onApplicationPausedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnApplicationPause(bool paused)
		{
		}
	}
}
