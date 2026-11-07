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
			_onEnableAction = onEnable;
			_onDisableAction = onDisable;
			_onApplicationQuitAction = onApplicationQuit;
		}

		private void OnApplicationQuit() => _onApplicationQuitAction?.Invoke();

		private void OnEnable() => _onEnableAction?.Invoke();

		private void OnDisable() => _onDisableAction?.Invoke();
	}
}
