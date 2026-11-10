using UnityEngine;
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
			EnsureScenePlayable();
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F5))
			{
				int next = (SceneManager.GetActiveScene().buildIndex + 1) % Mathf.Max(1, SceneManager.sceneCountInBuildSettings);
				SceneManager.LoadScene(next);
			}
			else if (Input.GetKeyDown(KeyCode.F6))
			{
				int prev = (SceneManager.GetActiveScene().buildIndex - 1 + SceneManager.sceneCountInBuildSettings) % Mathf.Max(1, SceneManager.sceneCountInBuildSettings);
				SceneManager.LoadScene(prev);
			}
		}

		private void EnsureScenePlayable()
		{
			Screen.sleepTimeout = SleepTimeout.NeverSleep;
			if (LevelManager.HasInstance && LevelManager.Instance != null && LevelManager.Instance.CurrentLevelData != null)
				return;

			var levels = FindObjectsOfType<Level>();
			foreach (var lvl in levels)
			{
				if (lvl == null) continue;
				if (lvl.gameObject.scene.name == "main overworld new" || lvl.gameObject.scene.name == "Hub_Overworld") continue;
				if (!lvl.IsInitialized)
				{
					var ld = ScriptableObject.CreateInstance<LevelData>();
					ld.name = lvl.gameObject.scene.name;
					lvl.Initialize(ld);
					lvl.Begin();
					var cam = lvl.GetComponentInChildren<Camera>(true);
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
	}
}
