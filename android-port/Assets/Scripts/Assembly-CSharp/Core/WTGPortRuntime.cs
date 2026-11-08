using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Core
{
	public class WTGPortRuntime : MonoBehaviour
	{
		private static WTGPortRuntime _instance;

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

		private void EnsureScenePlayable()
		{
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
			var ctrls = FindObjectsOfType<GolfBallController>();
			foreach (var c in ctrls)
			{
				if (c != null && !c.enabled)
					c.Activate();
			}
		}
	}
}
