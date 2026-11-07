using System;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

namespace BetaAnalytics
{
	public class AnalyticsUnityHelper : MonoBehaviour
	{
		[CompilerGenerated]
		private Action<bool> m_onApplicationFocus;

		[CompilerGenerated]
		private Action m_onApplicationQuit;

		[CompilerGenerated]
		private Action m_onUpdate;

		public event Action<bool> onApplicationFocus
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

		public event Action onApplicationQuit
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

		public event Action onUpdate
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

		private void Awake()
		{
		}

		private void OnApplicationFocus(bool focus)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void Update()
		{
		}

		private void ReInput_ControllerStatusChanged(ControllerStatusChangedEventArgs obj)
		{
		}
	}
}
