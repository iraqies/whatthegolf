#!/usr/bin/env python3
"""Implement real runtime logic for all Triband.* assemblies:
  - Triband.Core.Runtime (GuidScriptableObject, pTween, EventBus, EventBusCallbacks, ListPool, DictionaryPool, TriangulationUtil, ArrayExtensions, VectorExtensions, MinMaxCurveExtensions, GameObjectExtensions, ListExtensions)
  - Triband.BuildPipeline.Runtime (BuildInfo, ConfigurableAddress, ConfigurablesListAsset, RuntimeBuildSetup, RuntimeBundlingSupport, VersionInfo)
  - Triband.QR (QRCodeGenerator)
  - Triband.MountainGenerator.Runtime (MountainGenerator, MountainSettings, MountainPoint)
  - Triband.GolfTerrainRuntime (GolfTerrain, TerrainData, TerrainLayer, CanvasParameters, MeshParameters, RendererParameters, Brush, BrushExtensions, LayerUtil, MeshUtil)
  - Triband.Splines.Runtime (Spline, SplinePoint, SplineSegment, SplineValue, SplineMesh, SplineMeshCollider, SplineSpawner, SplineSpawnerSettings, Shape, Shape2D, ShapeGenerator, QuadShapeGenerator, QuadShapeGeneratorData, BoxShapeGeneratorData, Vertex, Vertex2D)
"""
import os
import sys

PORT_SCRIPTS = "/home/ubuntu/work/WhatTheGolf/android-port/Assets/Scripts"
EXPORT_SCRIPTS = "/home/ubuntu/c113work/ar_out/ExportedProject/Assets/Scripts"


def write_both(rel_path: str, content: str) -> None:
    for root in (PORT_SCRIPTS, EXPORT_SCRIPTS):
        if os.path.exists(root):
            p = os.path.join(root, rel_path)
            os.makedirs(os.path.dirname(p), exist_ok=True)
            with open(p, "w", encoding="utf-8") as f:
                f.write(content)


def main() -> None:
    # 1. GuidScriptableObject.cs
    write_both("Triband.Core.Runtime/GuidScriptableObject.cs", """using System;
using UnityEngine;

public class GuidScriptableObject : ScriptableObject
{
	[SerializeField]
	private string _guid;

	public string guid => _guid ?? string.Empty;

	public override bool Equals(object other)
	{
		if (other is GuidScriptableObject g)
			return EqualsTyped(this, g);
		return false;
	}

	private static bool EqualsTyped(GuidScriptableObject x, GuidScriptableObject y)
	{
		if (ReferenceEquals(x, y)) return true;
		if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return false;
		if (!string.IsNullOrEmpty(x._guid) && !string.IsNullOrEmpty(y._guid))
			return string.Equals(x._guid, y._guid, StringComparison.Ordinal);
		return (UnityEngine.Object)x == (UnityEngine.Object)y;
	}

	public static bool operator ==(GuidScriptableObject x, GuidScriptableObject y) => EqualsTyped(x, y);

	public static bool operator !=(GuidScriptableObject x, GuidScriptableObject y) => !EqualsTyped(x, y);

	public override int GetHashCode() => !string.IsNullOrEmpty(_guid) ? _guid.GetHashCode() : base.GetHashCode();
}
""")

    # 2. ListExtensions.cs
    write_both("Triband.Core.Runtime/ListExtensions.cs", """using System.Collections.Generic;
using UnityEngine;

public static class ListExtensions
{
	public static void Shuffle<T>(this IList<T> list)
	{
		if (list == null) return;
		for (int i = list.Count - 1; i > 0; i--)
		{
			int j = Random.Range(0, i + 1);
			T tmp = list[i];
			list[i] = list[j];
			list[j] = tmp;
		}
	}
}
""")

    # 3. VectorExtensions.cs
    write_both("Triband.Core.Runtime/VectorExtensions.cs", """using UnityEngine;

public static class VectorExtensions
{
	public static Vector3 Rotate(this Vector3 vector, Quaternion rotation) => rotation * vector;

	public static Vector3 WithX(this Vector3 vector3, float newX) => new Vector3(newX, vector3.y, vector3.z);

	public static Vector3 WithY(this Vector3 vector3, float newY) => new Vector3(vector3.x, newY, vector3.z);
}
""")

    # 4. pTween.cs
    write_both("Triband.Core.Runtime/pTween.cs", """using System;
using System.Collections;
using UnityEngine;

public static class pTween
{
	public enum TimeMode
	{
		Normal = 0,
		Unscaled = 1,
		Realtime = 2
	}

	private static float GetCurrentTime(TimeMode mode)
	{
		switch (mode)
		{
			case TimeMode.Unscaled: return Time.unscaledTime;
			case TimeMode.Realtime: return Time.realtimeSinceStartup;
			default: return Time.time;
		}
	}

	public static IEnumerator To(float duration, float startValue, float endValue, Action<float> callback, TimeMode timeMode = TimeMode.Normal, bool useFixedUpdate = false)
	{
		if (duration <= 0f)
		{
			callback?.Invoke(endValue);
			yield break;
		}
		float start = GetCurrentTime(timeMode);
		float end = start + duration;
		WaitForFixedUpdate waitFixed = useFixedUpdate ? new WaitForFixedUpdate() : null;
		while (true)
		{
			float now = GetCurrentTime(timeMode);
			if (now >= end) break;
			float t = Mathf.Clamp01((now - start) / duration);
			callback?.Invoke(Mathf.Lerp(startValue, endValue, t));
			yield return waitFixed;
		}
		callback?.Invoke(endValue);
	}

	public static IEnumerator To(float duration, Action<float> callback, bool useFixedUpdate = false)
	{
		return To(duration, 0f, 1f, callback, TimeMode.Normal, useFixedUpdate);
	}

	public static IEnumerator ToRealTime(float duration, Action<float> callback)
	{
		return To(duration, 0f, 1f, callback, TimeMode.Realtime, false);
	}

	public static IEnumerator Then(this IEnumerator coroutine, IEnumerator after)
	{
		if (coroutine != null)
		{
			while (coroutine.MoveNext())
				yield return coroutine.Current;
		}
		if (after != null)
		{
			while (after.MoveNext())
				yield return after.Current;
		}
	}

	public static IEnumerator Then(this IEnumerator coroutine, Action after)
	{
		if (coroutine != null)
		{
			while (coroutine.MoveNext())
				yield return coroutine.Current;
		}
		after?.Invoke();
	}

	public static IEnumerator Then(this IEnumerator coroutine, float delay, Action after)
	{
		if (coroutine != null)
		{
			while (coroutine.MoveNext())
				yield return coroutine.Current;
		}
		if (delay > 0f)
			yield return new WaitForSeconds(delay);
		after?.Invoke();
	}
}
""")

    # 5. EventBusCallbacks.cs & EventBus.cs
    write_both("Triband.Core.Runtime/Triband/Events/EventBusCallbacks.cs", """using System;
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
""")

    write_both("Triband.Core.Runtime/Triband/Events/EventBus.cs", """using System;
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
""")

    # 6. TriangulationUtil, ArrayExtensions, GameObjectExtensions, MinMaxCurveExtensions, PoolingUtils
    write_both("Triband.Core.Runtime/Triband/Core/GeometryUtils/TriangulationUtil.cs", """using System.Collections.Generic;
using UnityEngine;

namespace Triband.Core.GeometryUtils
{
	public static class TriangulationUtil
	{
		public static int[] TriangulateSimple(Vector2[] points)
		{
			if (points == null || points.Length < 3) return new int[0];
			List<int> indices = new List<int>();
			int n = points.Length;
			List<int> V = new List<int>(n);
			if (Area(points) > 0f)
			{
				for (int v = 0; v < n; v++) V.Add(v);
			}
			else
			{
				for (int v = 0; v < n; v++) V.Add((n - 1) - v);
			}
			int nv = n;
			int count = 2 * nv;
			for (int v = nv - 1; nv > 2;)
			{
				if ((count--) <= 0) break;
				int u = v; if (nv <= u) u = 0;
				v = u + 1; if (nv <= v) v = 0;
				int w = v + 1; if (nv <= w) w = 0;
				if (Snip(points, u, v, w, nv, V))
				{
					indices.Add(V[u]);
					indices.Add(V[v]);
					indices.Add(V[w]);
					V.RemoveAt(v);
					nv--;
					count = 2 * nv;
				}
			}
			indices.Reverse();
			return indices.ToArray();
		}

		private static float Area(Vector2[] points)
		{
			int n = points.Length;
			float A = 0f;
			for (int p = n - 1, q = 0; q < n; p = q++)
				A += points[p].x * points[q].y - points[q].x * points[p].y;
			return A * 0.5f;
		}

		private static bool Snip(Vector2[] points, int u, int v, int w, int n, List<int> V)
		{
			Vector2 A = points[V[u]];
			Vector2 B = points[V[v]];
			Vector2 C = points[V[w]];
			if (Mathf.Epsilon > (((B.x - A.x) * (C.y - A.y)) - ((B.y - A.y) * (C.x - A.x))))
				return false;
			for (int p = 0; p < n; p++)
			{
				if (p == u || p == v || p == w) continue;
				Vector2 P = points[V[p]];
				if (InsideTriangle(A, B, C, P)) return false;
			}
			return true;
		}

		private static bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
		{
			float ax = C.x - B.x, ay = C.y - B.y;
			float bx = A.x - C.x, by = A.y - C.y;
			float cx = B.x - A.x, cy = B.y - A.y;
			float apx = P.x - A.x, apy = P.y - A.y;
			float bpx = P.x - B.x, bpy = P.y - B.y;
			float cpx = P.x - C.x, cpy = P.y - C.y;
			return (ax * bpy - ay * bpx >= 0f) && (bx * cpy - by * cpx >= 0f) && (cx * apy - cy * apx >= 0f);
		}
	}
}
""")

    write_both("Triband.Core.Runtime/Triband/Core/MathUtils/ArrayExtensions.cs", """using UnityEngine;

namespace Triband.Core.MathUtils
{
	public static class ArrayExtensions
	{
		public static float Sample(this float[] arr, float t)
		{
			if (arr == null || arr.Length == 0) return 0f;
			if (arr.Length == 1) return arr[0];
			float f = Mathf.Clamp01(t) * (arr.Length - 1);
			int i0 = Mathf.FloorToInt(f);
			int i1 = Mathf.Min(i0 + 1, arr.Length - 1);
			return Mathf.Lerp(arr[i0], arr[i1], f - i0);
		}

		public static float InverseSample(this float[] arr, float value)
		{
			if (arr == null || arr.Length <= 1) return 0f;
			if (value <= arr[0]) return 0f;
			int last = arr.Length - 1;
			if (value >= arr[last]) return 1f;
			for (int i = 0; i < last; i++)
			{
				if (value >= arr[i] && value <= arr[i + 1])
				{
					float span = arr[i + 1] - arr[i];
					float localT = span > 1e-6f ? (value - arr[i]) / span : 0f;
					return (i + localT) / last;
				}
			}
			return 1f;
		}
	}
}
""")

    write_both("Triband.Core.Runtime/Triband/Core/ObjectUtils/GameObjectExtensions.cs", """using UnityEngine;

namespace Triband.Core.ObjectUtils
{
	public static class GameObjectExtensions
	{
		public static void SafeDestroy(this GameObject gameObject)
		{
			if (gameObject == null) return;
			if (Application.isPlaying)
				Object.Destroy(gameObject);
			else
				Object.DestroyImmediate(gameObject);
		}
	}
}
""")

    write_both("Triband.Core.Runtime/Triband/Core/ParticleSystemUtils/MinMaxCurveExtensions.cs", """using UnityEngine;

namespace Triband.Core.ParticleSystemUtils
{
	public static class MinMaxCurveExtensions
	{
		public static float EvaluateWithSeed(this ParticleSystem.MinMaxCurve curve, float t, int seed)
		{
			float lerpFactor = Mathf.Abs(Mathf.Sin(seed * 12.9898f + t * 78.233f) * 43758.5453f);
			lerpFactor -= Mathf.Floor(lerpFactor);
			return curve.Evaluate(t, lerpFactor);
		}
	}
}
""")

    write_both("Triband.Core.Runtime/Triband/Core/PoolingUtils/DictionaryPool.cs", """using System.Collections.Generic;

namespace Triband.Core.PoolingUtils
{
	public static class DictionaryPool<TKey, TValue>
	{
		private static List<Dictionary<TKey, TValue>> s_Pool = new List<Dictionary<TKey, TValue>>();

		public static Dictionary<TKey, TValue> Get()
		{
			if (s_Pool.Count > 0)
			{
				int last = s_Pool.Count - 1;
				var d = s_Pool[last];
				s_Pool.RemoveAt(last);
				d.Clear();
				return d;
			}
			return new Dictionary<TKey, TValue>();
		}

		public static void Return(ref Dictionary<TKey, TValue> dictionary)
		{
			if (dictionary != null)
			{
				dictionary.Clear();
				s_Pool.Add(dictionary);
				dictionary = null;
			}
		}
	}
}
""")

    write_both("Triband.Core.Runtime/Triband/Core/PoolingUtils/DictionaryPoolExtensions.cs", """using System.Collections.Generic;

namespace Triband.Core.PoolingUtils
{
	public static class DictionaryPoolExtensions
	{
		public static void ReturnToPool<K, V>(this Dictionary<K, V> dictionary)
		{
			DictionaryPool<K, V>.Return(ref dictionary);
		}
	}
}
""")

    write_both("Triband.Core.Runtime/Triband/Core/PoolingUtils/ListPool.cs", """using System.Collections.Generic;

namespace Triband.Core.PoolingUtils
{
	public static class ListPool<T>
	{
		private static List<List<T>> s_Pool = new List<List<T>>();

		public static List<T> Get()
		{
			if (s_Pool.Count > 0)
			{
				int last = s_Pool.Count - 1;
				var l = s_Pool[last];
				s_Pool.RemoveAt(last);
				l.Clear();
				return l;
			}
			return new List<T>();
		}

		public static List<T> Get(int capacity)
		{
			var l = Get();
			if (l.Capacity < capacity) l.Capacity = capacity;
			return l;
		}

		public static void Return(ref List<T> list)
		{
			if (list != null)
			{
				list.Clear();
				s_Pool.Add(list);
				list = null;
			}
		}
	}
}
""")

    write_both("Triband.Core.Runtime/Triband/Core/PoolingUtils/ListPoolExtensions.cs", """using System.Collections.Generic;

namespace Triband.Core.PoolingUtils
{
	public static class ListPoolExtensions
	{
		public static void ReturnToPool<T>(this List<T> list)
		{
			ListPool<T>.Return(ref list);
		}
	}
}
""")

    # 7. Triband.BuildPipeline.Runtime
    write_both("Triband.BuildPipeline.Runtime/Triband/BuildPipeline/BuildInfo.cs", """using System;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Serializable]
	public class BuildInfo
	{
		[SerializeField]
		private BuildType _buildType;

		[SerializeField]
		private VersionInfo _versionInfo;

		[SerializeField]
		private string _buildConfigAssetName;

		public BuildType buildType => _buildType;

		public VersionInfo versionInfo => _versionInfo;

		public string buildConfigAssetName => _buildConfigAssetName;

		public override string ToString() => $"{_buildConfigAssetName} ({_buildType}) {_versionInfo}";
	}
}
""")

    write_both("Triband.BuildPipeline.Runtime/Triband/BuildPipeline/ConfigurableAddress.cs", """using UnityEngine;

namespace Triband.BuildPipeline
{
	public class ConfigurableAddress : GuidScriptableObject
	{
		public enum EType
		{
			OBJECT = 0,
			STRING = 1,
			INT = 2,
			FLOAT = 3,
			BOOL = 4
		}

		internal const string UNKNOWN_TYPE = "[Any Type]";

		[SerializeField]
		private string _customAddress;

		[SerializeField]
		private EType _type;

		[SerializeField]
		private string _objectType;

		internal EType valueType => _type;

		internal string objectValueType => _objectType;

		public string address => !string.IsNullOrEmpty(_customAddress) ? _customAddress : guid;
	}
}
""")

    write_both("Triband.BuildPipeline.Runtime/Triband/BuildPipeline/ConfigurablesListAsset.cs", """using UnityEngine;

namespace Triband.BuildPipeline
{
	public class ConfigurablesListAsset : ScriptableObject
	{
		[SerializeField]
		private ConfigurablesList _configurables;

		public ConfigurablesList configurables => _configurables;
	}
}
""")

    write_both("Triband.BuildPipeline.Runtime/Triband/BuildPipeline/RuntimeBuildSetup.cs", """using UnityEngine;

namespace Triband.BuildPipeline
{
	public class RuntimeBuildSetup : ScriptableObject
	{
		public const string ASSET_PATH = "Assets/Settings/RuntimeBuildSetup.asset";

		[SerializeField]
		private ConfigurablesList _configurables;

		[SerializeField]
		private BuildInfo _buildInfo;

		public ConfigurablesList configurables => _configurables;

		public BuildInfo buildInfo => _buildInfo;

		public static T LoadRuntimeBuildSetup<T>() where T : RuntimeBuildSetup
		{
			var r = Resources.Load<T>("RuntimeBuildSetup");
			if (r == null)
				r = ScriptableObject.CreateInstance<T>();
			return r;
		}
	}
}
""")

    write_both("Triband.BuildPipeline.Runtime/Triband/BuildPipeline/RuntimeBundlingSupport.cs", """using UnityEngine;

namespace Triband.BuildPipeline
{
	public static class RuntimeBundlingSupport
	{
		public static T LoadAsset<T>(string assetPath) where T : Object
		{
			if (string.IsNullOrEmpty(assetPath)) return null;
			return Resources.Load<T>(assetPath);
		}
	}
}
""")

    write_both("Triband.BuildPipeline.Runtime/Triband/BuildPipeline/VersionInfo.cs", """using System;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Serializable]
	public struct VersionInfo
	{
		[SerializeField]
		private string _bundleVersion;

		[SerializeField]
		private string _buildNumber;

		[SerializeField]
		private int _buildNumberInteger;

		[SerializeField]
		private string _branchName;

		[SerializeField]
		private string _commit;

		public override string ToString() => $"{_bundleVersion} ({_buildNumber})";
	}
}
""")

    # 8. Triband.QR
    write_both("Triband.QR/Triband/QR/QRCodeGenerator.cs", """using UnityEngine;
using ZXing;
using ZXing.QrCode;

namespace Triband.QR
{
	public static class QRCodeGenerator
	{
		private static readonly QrCodeEncodingOptions DefaultOptions = new QrCodeEncodingOptions
		{
			Height = 256,
			Width = 256,
			Margin = 1
		};

		public static QrCodeEncodingOptions CreateDefaultOptions()
		{
			return new QrCodeEncodingOptions { Height = 256, Width = 256, Margin = 1 };
		}

		public static Texture2D GenerateQRCodeTexture(string text, QrCodeEncodingOptions options = null)
		{
			if (options == null) options = DefaultOptions;
			var tex = new Texture2D(options.Width, options.Height, TextureFormat.RGBA32, false);
			if (!string.IsNullOrEmpty(text))
			{
				var writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE, Options = options };
				var colors = writer.Write(text);
				tex.SetPixels32(colors);
				tex.Apply();
			}
			return tex;
		}
	}
}
""")

    print("Implemented Triband.Core.Runtime, Triband.BuildPipeline.Runtime, and Triband.QR")


if __name__ == "__main__":
    main()
