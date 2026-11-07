using System;
using UnityEngine;

namespace Triband.Events
{
	public class EventBusCallbacks : MonoBehaviour
	{
		private Action _onEnableAction;

		private Action _onDisableAction;

		private Action _onApplicationQuitAction;

		internal void RegisterCallbacks(Action onEnable, Action onDisable, Action onApplicationQuit)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
