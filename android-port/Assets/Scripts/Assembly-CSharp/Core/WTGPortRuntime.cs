using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
	public class WTGPortRuntime : MonoBehaviour
	{
		private static WTGPortRuntime _instance;
		private bool _showMenu;
		private int _selectedEpisodeIndex;
		private Vector2 _scrollPos;

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
			Application.targetFrameRate = 60;
			Screen.sleepTimeout = SleepTimeout.NeverSleep;
			SceneManager.sceneLoaded += OnSceneLoaded;
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
			var ctrls = FindObjectsOfType<GolfBallController>();
			foreach (var c in ctrls)
			{
				if (c != null && !c.enabled)
					c.Activate();
			}
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F1) || (Input.touchCount == 4 && Input.GetTouch(3).phase == TouchPhase.Began))
				_showMenu = !_showMenu;
		}

		private void OnGUI()
		{
			if (!_showMenu) return;

			float scale = Mathf.Clamp(Screen.height / 720f, 0.85f, 2.2f);
			int fontSize = Mathf.RoundToInt(18f * scale);
			var btnStyle = new GUIStyle(GUI.skin.button) { fontSize = fontSize, fontStyle = FontStyle.Bold };
			var labelStyle = new GUIStyle(GUI.skin.label) { fontSize = fontSize, fontStyle = FontStyle.Bold, normal = { textColor = Color.white } };

			DrawEpisodeMenu(scale, btnStyle, labelStyle);
		}

		private void DrawEpisodeMenu(float scale, GUIStyle btnStyle, GUIStyle labelStyle)
		{
			float w = Mathf.Min(Screen.width - 40f * scale, 920f * scale);
			float h = Mathf.Min(Screen.height - 90f * scale, 580f * scale);
			Rect boxRect = new Rect((Screen.width - w) * 0.5f, 48f * scale, w, h);
			GUI.Box(boxRect, "WHAT THE GOLF? — Level Selector");

			GUILayout.BeginArea(new Rect(boxRect.x + 16f * scale, boxRect.y + 36f * scale, boxRect.width - 32f * scale, boxRect.height - 48f * scale));

			GUILayout.BeginHorizontal();
			if (GUILayout.Button("Close", btnStyle, GUILayout.Height(36f * scale))) _showMenu = false;
			if (GUILayout.Button("Restart", btnStyle, GUILayout.Height(36f * scale))) { _showMenu = false; RestartActiveScene(); }
			if (GUILayout.Button("Hub", btnStyle, GUILayout.Height(36f * scale))) { _showMenu = false; LoadSceneByName("Hub_Overworld"); }
			GUILayout.EndHorizontal();

			var catalog = WTGPortCatalog.Instance;
			if (catalog != null && catalog.episodes != null && catalog.episodes.Count > 0)
			{
				GUILayout.BeginHorizontal();
				for (int i = 0; i < catalog.episodes.Count; i++)
				{
					var ep = catalog.episodes[i];
					if (GUILayout.Button(ep.title, btnStyle, GUILayout.Height(36f * scale)))
						_selectedEpisodeIndex = i;
				}
				GUILayout.EndHorizontal();

				var curEp = catalog.episodes[Mathf.Clamp(_selectedEpisodeIndex, 0, catalog.episodes.Count - 1)];
				if (!string.IsNullOrEmpty(curEp.overworldScene))
				{
					if (GUILayout.Button($"Enter Overworld: {curEp.overworldScene}", btnStyle, GUILayout.Height(40f * scale)))
					{
						_showMenu = false;
						LoadSceneByName(curEp.overworldScene);
					}
				}

				_scrollPos = GUILayout.BeginScrollView(_scrollPos);
				if (curEp.levels != null)
				{
					foreach (var lvl in curEp.levels)
					{
						if (lvl == null) continue;
						string sName = lvl.SceneName;
						if (GUILayout.Button($"{lvl.name}  ({sName})  [Par {lvl.StrokesToPar}]", btnStyle, GUILayout.Height(36f * scale)))
						{
							_showMenu = false;
							if (LevelManager.Instance != null)
								LevelManager.Instance.StartCoroutine(LevelManager.Instance.Play(lvl, discardLoadedScenes: true));
							else
								LoadSceneByName(sName);
						}
					}
				}
				GUILayout.EndScrollView();
			}

			GUILayout.EndArea();
		}

		private void RestartActiveScene()
		{
			if (Level.HasInstance) Level.Instance.ResetLevel();
			else SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

		private void LoadSceneByName(string sceneName)
		{
			if (string.IsNullOrEmpty(sceneName)) return;
			try
			{
				var handle = UnityEngine.AddressableAssets.Addressables.LoadSceneAsync(sceneName, LoadSceneMode.Single, true);
				if (handle.IsValid()) return;
			}
			catch { }
			if (Application.CanStreamedLevelBeLoaded(sceneName))
				SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
		}
	}
}
