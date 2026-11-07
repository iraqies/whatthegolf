using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Triband.Events
{
	public class EventBus
	{
		private struct EventCallback
		{
			public object action;

			public object target;

			public bool isValid => false;
		}

		private static EventBus s_instance;

		private static EventBusCallbacks s_callbacks;

		private static bool s_appQuitting;

		private Dictionary<Type, List<EventCallback>> _listenersPerEventType;

		private static EventBus instance => null;

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
		}

		public static void RaiseEvent<T>(T eventInstance) where T : struct
		{
		}

		public static void AddListener<T>(UnityAction<T> callback) where T : struct
		{
		}

		public static void RemoveListener<T>(UnityAction<T> callback) where T : struct
		{
		}

		public static void RemoveAllListeners(UnityEngine.Object target)
		{
		}

		public static void CleanupInvalidListeners()
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

		private void RaiseEventInternal<T>(T eventInstance) where T : struct
		{
		}

		private void AddListenerInternal<T>(UnityAction<T> callback) where T : struct
		{
		}

		private void RemoveListenerInternal<T>(UnityAction<T> callback) where T : struct
		{
		}

		private void RemoveAllListenersInternal(UnityEngine.Object target)
		{
		}

		private void OnSceneUnloaded(Scene s)
		{
		}

		public void CleanupInvalidListenersInternal()
		{
		}
	}
}
