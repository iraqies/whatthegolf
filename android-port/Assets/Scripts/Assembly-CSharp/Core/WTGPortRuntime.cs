using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Core
{
	public class WTGPortRuntime : MonoBehaviour
	{
		private static WTGPortRuntime _instance;
		private static Material _cachedVectorMaterial;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AutoBoot()
		{
			if (_instance != null) return;
			var go = new GameObject("WTGPortRuntime");
			DontDestroyOnLoad(go);
			_instance = go.AddComponent<WTGPortRuntime>();
		}

		private void Awake()
		{
			if (_instance != null && _instance != this)
			{
				Destroy(gameObject);
				return;
			}
			_instance = this;
			DontDestroyOnLoad(gameObject);
			QualitySettings.vSyncCount = 0;
			QualitySettings.antiAliasing = 0;
			Application.targetFrameRate = 120;
			Screen.sleepTimeout = SleepTimeout.NeverSleep;
			SceneManager.sceneLoaded += OnSceneLoaded;
			EnsureScenePlayable();
		}

		private void OnDestroy()
		{
			SceneManager.sceneLoaded -= OnSceneLoaded;
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			Game.strokes = 0;
			EnsureScenePlayable();
		}

		private static Material GetVectorMaterial()
		{
			if (_cachedVectorMaterial != null)
				return _cachedVectorMaterial;
			Shader sh = Shader.Find("Unlit/Vector");
			if (sh == null)
				sh = Shader.Find("Sprites/Default");
			if (sh != null)
			{
				_cachedVectorMaterial = new Material(sh);
				_cachedVectorMaterial.mainTexture = Texture2D.whiteTexture;
			}
			return _cachedVectorMaterial;
		}

		private void EnsureScenePlayable()
		{
			Screen.sleepTimeout = SleepTimeout.NeverSleep;
			QualitySettings.vSyncCount = 0;
			if (Application.targetFrameRate < 60)
				Application.targetFrameRate = 120;
			var cfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			if (cfg != null && cfg.useRotatedOverworldAndCameraInLevels)
			{
				if (Screen.orientation != ScreenOrientation.Portrait)
					Screen.orientation = ScreenOrientation.Portrait;
			}
			else
			{
				Screen.autorotateToPortrait = false;
				Screen.autorotateToPortraitUpsideDown = false;
				if (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
					Screen.orientation = ScreenOrientation.LandscapeLeft;
			}
			foreach (var es in FindObjectsOfType<EventSystem>())
			{
				if (es != null && es.GetComponent<StandaloneInputModule>() == null)
				{
					var sim = es.gameObject.AddComponent<StandaloneInputModule>();
					sim.forceModuleActive = true;
				}
			}
			foreach (var tr in FindObjectsOfType<Transition>())
			{
				if (tr != null && !tr.IsShowing)
				{
					var cam = tr.GetComponent<Camera>();
					if (cam != null) cam.enabled = false;
				}
			}
			Material vecMat = GetVectorMaterial();
			if (vecMat != null)
			{
				foreach (var sr in FindObjectsOfType<SpriteRenderer>(true))
				{
					if (sr != null && sr.sprite != null && sr.sprite.texture == null)
					{
						var shName = sr.sharedMaterial != null && sr.sharedMaterial.shader != null ? sr.sharedMaterial.shader.name : string.Empty;
						if (shName == "Sprites/Default" || string.IsNullOrEmpty(shName))
							sr.sharedMaterial = vecMat;
					}
				}
			}
		}

		private void OnApplicationPause(bool pauseStatus)
		{
			if (pauseStatus)
			{
				SaveGame.Save(false);
			}
		}

		private void OnApplicationQuit()
		{
			SaveGame.Save(false);
		}
	}
}
