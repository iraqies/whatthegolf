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
			SceneManager.sceneUnloaded += OnSceneUnloaded;
			EnsureScenePlayable();
		}

		private void OnDestroy()
		{
			SceneManager.sceneLoaded -= OnSceneLoaded;
			SceneManager.sceneUnloaded -= OnSceneUnloaded;
		}

		private void OnSceneUnloaded(Scene scene)
		{
			if (FindObjectOfType<Gravity>() == null && FindObjectOfType<PhysicsOverride>() == null)
			{
				Physics.gravity = new Vector3(0f, -9.81f, 0f);
				Physics2D.gravity = new Vector2(0f, -9.81f);
			}
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			Game.strokes = 0;
			EnsureScenePlayable();
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
			if (!OverworldManager2d.HasInstance)
			{
				var ctrls = FindObjectsOfType<GolfBallController>();
				foreach (var c in ctrls)
				{
					if (c != null && !c.enabled && c.gameObject.name != "RealClubBall")
						c.Activate();
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
