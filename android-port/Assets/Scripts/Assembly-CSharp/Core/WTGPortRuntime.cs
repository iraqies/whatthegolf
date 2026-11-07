using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
		private string _bannerText = string.Empty;
		private float _bannerTimer;
		private Vector2 _touchStart;
		private Vector2 _touchCurrent;
		private bool _isTouchAiming;

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
			Screen.sleepTimeout = -1;
			SceneManager.sceneLoaded += OnSceneLoaded;
		}

		private void OnDestroy()
		{
			SceneManager.sceneLoaded -= OnSceneLoaded;
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			Game.strokes = 0;
			_bannerText = scene.name;
			_bannerTimer = 2.5f;
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
			if (Level.HasInstance)
			{
				var lvl = Level.Instance;
				lvl.OnComplete -= OnLevelCompleted;
				lvl.OnComplete += OnLevelCompleted;
			}
		}

		private void OnLevelCompleted(Level.CompletedState state)
		{
			_bannerText = !string.IsNullOrEmpty(state?.Message) ? state.Message : "GOLF!";
			_bannerTimer = 2.5f;
		}

		private void Update()
		{
			if (_bannerTimer > 0f)
				_bannerTimer -= Time.unscaledDeltaTime;

			if (Input.GetKeyDown(KeyCode.Escape))
				_showMenu = !_showMenu;

			if (!_showMenu)
			{
				if (Input.touchCount > 0)
				{
					var t = Input.GetTouch(0);
					if (t.phase == TouchPhase.Began)
					{
						_touchStart = t.position;
						_touchCurrent = t.position;
						_isTouchAiming = true;
					}
					else if (t.phase == TouchPhase.Moved || t.phase == TouchPhase.Stationary)
					{
						_touchCurrent = t.position;
					}
					else
					{
						_isTouchAiming = false;
					}
				}
				else if (Input.GetMouseButton(0))
				{
					if (Input.GetMouseButtonDown(0))
						_touchStart = Input.mousePosition;
					_touchCurrent = Input.mousePosition;
					_isTouchAiming = true;
				}
				else
				{
					_isTouchAiming = false;
				}
			}
		}

		private void OnGUI()
		{
			float scale = Mathf.Clamp(Screen.height / 720f, 0.85f, 2.2f);
			int btnH = Mathf.RoundToInt(44f * scale);
			int fontSize = Mathf.RoundToInt(18f * scale);

			var btnStyle = new GUIStyle(GUI.skin.button) { fontSize = fontSize, fontStyle = FontStyle.Bold };
			var labelStyle = new GUIStyle(GUI.skin.label) { fontSize = fontSize, fontStyle = FontStyle.Bold, normal = { textColor = Color.white } };
			var bannerStyle = new GUIStyle(GUI.skin.box) { fontSize = Mathf.RoundToInt(28f * scale), fontStyle = FontStyle.Bold, alignment = TextAnchor.MiddleCenter, normal = { textColor = Color.yellow } };

			// Top bar: Pause/Levels, Restart, Next Level, Strokes
			GUILayout.BeginArea(new Rect(16f * scale, 12f * scale, Screen.width - 32f * scale, btnH + 8f));
			GUILayout.BeginHorizontal();
			if (GUILayout.Button(_showMenu ? "Close Menu" : "Episodes / Levels", btnStyle, GUILayout.Width(180f * scale), GUILayout.Height(btnH)))
			{
				_showMenu = !_showMenu;
			}
			if (GUILayout.Button("Restart", btnStyle, GUILayout.Width(110f * scale), GUILayout.Height(btnH)))
			{
				RestartActiveScene();
			}
			if (GUILayout.Button("Hub", btnStyle, GUILayout.Width(90f * scale), GUILayout.Height(btnH)))
			{
				LoadSceneByName("Hub_Overworld");
			}
			GUILayout.FlexibleSpace();
			GUILayout.Label($"Scene: {SceneManager.GetActiveScene().name}   Strokes: {Game.strokes}", labelStyle, GUILayout.Height(btnH));
			GUILayout.EndHorizontal();
			GUILayout.EndArea();

			if (_bannerTimer > 0f && !string.IsNullOrEmpty(_bannerText))
			{
				float bw = 420f * scale;
				float bh = 64f * scale;
				GUI.Box(new Rect((Screen.width - bw) * 0.5f, 70f * scale, bw, bh), _bannerText, bannerStyle);
			}

			if (_showMenu)
			{
				DrawEpisodeMenu(scale, btnStyle, labelStyle);
			}
		}

		private void DrawEpisodeMenu(float scale, GUIStyle btnStyle, GUIStyle labelStyle)
		{
			float w = Mathf.Min(Screen.width - 40f * scale, 920f * scale);
			float h = Mathf.Min(Screen.height - 90f * scale, 580f * scale);
			Rect boxRect = new Rect((Screen.width - w) * 0.5f, 72f * scale, w, h);
			GUI.Box(boxRect, "WHAT THE GOLF? — Episodes & Level Browser (v20.5.34 Android Port)", GUI.skin.box);

			GUILayout.BeginArea(new Rect(boxRect.x + 16f * scale, boxRect.y + 36f * scale, boxRect.width - 32f * scale, boxRect.height - 48f * scale));

			var catalog = WTGPortCatalog.Instance;
			if (catalog != null && catalog.episodes != null && catalog.episodes.Count > 0)
			{
				GUILayout.BeginHorizontal();
				for (int i = 0; i < catalog.episodes.Count; i++)
				{
					var ep = catalog.episodes[i];
					if (GUILayout.Button(ep.title, btnStyle, GUILayout.Height(36f * scale)))
					{
						_selectedEpisodeIndex = i;
					}
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
			else
			{
				_scrollPos = GUILayout.BeginScrollView(_scrollPos);
				if (catalog != null && catalog.allSceneNames != null)
				{
					foreach (var sName in catalog.allSceneNames)
					{
						if (GUILayout.Button(sName, btnStyle, GUILayout.Height(36f * scale)))
						{
							_showMenu = false;
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
			if (Level.HasInstance)
			{
				Level.Instance.ResetLevel();
			}
			else
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			}
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
			try { SceneManager.LoadScene(sceneName, LoadSceneMode.Single); } catch { }
		}
	}
}
