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

			public bool isValid
			{
				get
				{
					if (action == null) return false;
					if (target is UnityEngine.Object uo) return uo != null;
					return true;
				}
			}
		}

		private static EventBus s_instance;
		private static EventBusCallbacks s_callbacks;
		private static bool s_appQuitting;
		private Dictionary<Type, List<EventCallback>> _listenersPerEventType = new Dictionary<Type, List<EventCallback>>();

		private static EventBus instance
		{
			get
			{
				if (s_instance == null)
					s_instance = new EventBus();
				return s_instance;
			}
		}

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
			s_appQuitting = false;
			if (s_instance == null)
				s_instance = new EventBus();
			SceneManager.sceneUnloaded -= s_instance.OnSceneUnloaded;
			SceneManager.sceneUnloaded += s_instance.OnSceneUnloaded;
		}

		public static void RaiseEvent<T>(T eventInstance) where T : struct
		{
			if (!s_appQuitting)
				instance.RaiseEventInternal(eventInstance);
		}

		public static void AddListener<T>(UnityAction<T> callback) where T : struct
		{
			if (!s_appQuitting && callback != null)
				instance.AddListenerInternal(callback);
		}

		public static void RemoveListener<T>(UnityAction<T> callback) where T : struct
		{
			if (!s_appQuitting && callback != null)
				instance.RemoveListenerInternal(callback);
		}

		public static void RemoveAllListeners(UnityEngine.Object target)
		{
			if (!s_appQuitting)
				instance.RemoveAllListenersInternal(target);
		}

		public static void CleanupInvalidListeners()
		{
			if (!s_appQuitting)
				instance.CleanupInvalidListenersInternal();
		}

		private void OnApplicationQuit() => s_appQuitting = true;

		private void OnEnable()
		{
			SceneManager.sceneUnloaded -= OnSceneUnloaded;
			SceneManager.sceneUnloaded += OnSceneUnloaded;
		}

		private void OnDisable()
		{
			SceneManager.sceneUnloaded -= OnSceneUnloaded;
		}

		private void RaiseEventInternal<T>(T eventInstance) where T : struct
		{
			if (_listenersPerEventType == null) return;
			if (!_listenersPerEventType.TryGetValue(typeof(T), out var list) || list == null) return;
			var copy = new List<EventCallback>(list);
			for (int i = 0; i < copy.Count; i++)
			{
				var cb = copy[i];
				if (cb.isValid && cb.action is UnityAction<T> ua)
				{
					try { ua.Invoke(eventInstance); }
					catch (Exception ex) { Debug.LogException(ex); }
				}
			}
		}

		private void AddListenerInternal<T>(UnityAction<T> callback) where T : struct
		{
			if (_listenersPerEventType == null)
				_listenersPerEventType = new Dictionary<Type, List<EventCallback>>();
			if (!_listenersPerEventType.TryGetValue(typeof(T), out var list))
			{
				list = new List<EventCallback>();
				_listenersPerEventType[typeof(T)] = list;
			}
			list.Add(new EventCallback { action = callback, target = callback.Target });
		}

		private void RemoveListenerInternal<T>(UnityAction<T> callback) where T : struct
		{
			if (_listenersPerEventType != null && _listenersPerEventType.TryGetValue(typeof(T), out var list))
			{
				list.RemoveAll(c => Equals(c.action, callback));
			}
		}

		private void RemoveAllListenersInternal(UnityEngine.Object target)
		{
			if (_listenersPerEventType == null) return;
			foreach (var kv in _listenersPerEventType)
				kv.Value.RemoveAll(c => ReferenceEquals(c.target, target));
		}

		private void OnSceneUnloaded(Scene s) => CleanupInvalidListenersInternal();

		public void CleanupInvalidListenersInternal()
		{
			if (_listenersPerEventType == null) return;
			foreach (var kv in _listenersPerEventType)
				kv.Value.RemoveAll(c => !c.isValid);
		}
	}
}
