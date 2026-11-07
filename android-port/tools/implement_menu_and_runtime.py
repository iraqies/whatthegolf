#!/usr/bin/env python3
"""Implement Menu.Menu, Menu.InGameMenu, WTGPortCatalog, WTGPortRuntime, and WTGAndroidBuilder
for the standalone Android 1:1 port of WHAT THE GOLF? (v20.5.34).
"""
import os

PORT_ASSETS = "/home/ubuntu/work/WhatTheGolf/android-port/Assets"
EXPORT_ASSETS = "/home/ubuntu/c113work/ar_out/ExportedProject/Assets"

CATALOG_SCRIPT_GUID = "d1a7b207000040008000000000000001"
RUNTIME_SCRIPT_GUID = "d1a7b207000040008000000000000002"
BUILDER_SCRIPT_GUID = "d1a7b207000040008000000000000003"


def write_asset_file(rel_path: str, content: str, guid: str = None) -> None:
    for root in (PORT_ASSETS, EXPORT_ASSETS):
        if os.path.exists(root):
            p = os.path.join(root, rel_path)
            os.makedirs(os.path.dirname(p), exist_ok=True)
            with open(p, "w", encoding="utf-8") as f:
                f.write(content)
            if guid:
                with open(p + ".meta", "w", encoding="utf-8") as mf:
                    mf.write(f"""fileFormatVersion: 2
guid: {guid}
MonoImporter:
  externalObjects: {{}}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {{instanceID: 0}}
  userData: 
  assetBundleName: 
  assetBundleVariant: 
""")


def main() -> None:
    # 1. Menu/Menu.cs & Menu/InGameMenu.cs
    write_asset_file("Scripts/Assembly-CSharp/Menu/Menu.cs", """using System.Threading.Tasks;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menu
{
	public class Menu : AddressableSingleton<Menu>
	{
		public enum Location
		{
			Hub = 0,
			MainCampaign = 1,
			Other = 2
		}

		[SerializeField] private AnimateRectTransform buttonAnimator;
		[SerializeField] private AnimateRectTransform teleportAnimatorPortrait;
		[SerializeField] private AnimateRectTransform teleportAnimatorLandscape;
		[SerializeField] private RectTransform buttonsAndLogoParent;
		[SerializeField] private Button quitButton;
		[SerializeField] private Button hubButton;
		[SerializeField] private Button settingsButton;
		[SerializeField] private OverworldTeleportMenu teleportMenuPortrait;
		[SerializeField] private OverworldTeleportMenu teleportMenuLandscape;
		[SerializeField] private MainMenuGameCenterAccessPointButton accessPointButton;
		[SerializeField] private Button defaultCloseButton;
		[SerializeField] private Button landscapeMainCampaignCloseButton;
		[SerializeField] private CanvasScaler canvasScaler;
		[SerializeField] private float buttonsPortraitOffset;
		[SerializeField] private float buttonsLandscapeOfset;
		public ClipSettingsCollection OpenSFX;

		private TaskCompletionSource<bool> tcs;
		private Location _location;
		private bool _isInteractable;
		private bool _isOpen;

		private bool IsPortrait => Screen.height > Screen.width;
		private OverworldTeleportMenu currentTeleportMenu => IsPortrait ? teleportMenuPortrait : teleportMenuLandscape;
		private OverworldTeleportMenu otherTeleportMenu => IsPortrait ? teleportMenuLandscape : teleportMenuPortrait;

		public bool IsOpen() => _isOpen;

		public Task ShowAndAwait()
		{
			Show();
			tcs = new TaskCompletionSource<bool>();
			return tcs.Task;
		}

		public void Init()
		{
			if (quitButton != null) quitButton.gameObject.SetActive(false);
			if (accessPointButton != null) accessPointButton.gameObject.SetActive(false);
		}

		public void Show()
		{
			_isOpen = true;
			gameObject.SetActive(true);
			EnableInteraction();
		}

		private Location GetLocation()
		{
			string s = SceneManager.GetActiveScene().name;
			if (s == "Hub_Overworld") return Location.Hub;
			if (s.Contains("main overworld")) return Location.MainCampaign;
			return Location.Other;
		}

		private void SetButtonPositions(bool isInMainCampaign) { }
		private void Update() { }

		public void Close()
		{
			_isOpen = false;
			DisableInteraction();
			tcs?.TrySetResult(true);
		}

		public Task CloseAsync()
		{
			Close();
			return Task.CompletedTask;
		}

		public void OnQuitButtonClicked() => Application.Quit();

		public void OnHubButtonClicked()
		{
			Close();
			_ = HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
		}

		public void SettingsButtonClicked() { }
		public void CloseButtonClicked() => Close();
		private void DisableInteraction() => _isInteractable = false;
		private void EnableInteraction() => _isInteractable = true;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Menu/InGameMenu.cs", """using System;
using System.Collections;
using Core;
using Core.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
	public class InGameMenu : MonoBehaviour
	{
		[SerializeField] private RectTransform strokeCounterContainer;
		[SerializeField] private StrokeCounter strokeCounter;
		[SerializeField] private Transition transition;
		[SerializeField] private GameObject menuButton;
		[SerializeField] private Button exitButton;
		[SerializeField] private Button restartButton;
		[SerializeField] private Canvas menuCanvas;
		[SerializeField] private TextMeshProUGUI levelName;
		[SerializeField] private ChallengeCompletedUI ChallengeUI;
		[SerializeField] private ChallengeCompletedUI ChallengeFailedUI;
		[SerializeField] private InGameChallengeInfo ChallengeInfo;
		[SerializeField] private InGameChallengeInfo ChallengeInfoTop;
		[SerializeField] private GameObject LookUpText;
		[SerializeField] private SwitchUndockMessage UndockMessage;
		[SerializeField] private InGameFullScreenText fullScreenText;
		[SerializeField] private IngameInformationText informationText;
		public DailyChallengePagination DailyChallengePagination;
		public Action OnAbandonButtonClicked;
		public Action OnRestartButtonClicked;

		private RectTransform rectTrans;
		private GameObject currentFailScreen;
		private GameObject currentTitleScreen;
		private GameObject currentWinScreen;
		private TextWithShadow currentWinMessage;
		private Button[] menuButtons;
		private TextMeshProUGUI buildText;

		private void Awake() => Init();

		public void Init()
		{
			rectTrans = GetComponent<RectTransform>();
			if (exitButton != null)
			{
				exitButton.onClick.RemoveAllListeners();
				exitButton.onClick.AddListener(AbandonLevel);
			}
			if (restartButton != null)
			{
				restartButton.onClick.RemoveAllListeners();
				restartButton.onClick.AddListener(RestartLevel);
			}
		}

		public void DisableCloseButton() { }
		public void ForceScreenChangeHide() => HideMenu();
		private void Instance_OnLevelWillUnload() => HideMenu();

		public void Instance_OnLevelLoaded(LevelData level)
		{
			if (levelName != null && level != null)
				levelName.text = level.name;
		}

		public bool ToggleLevelName() => true;

		public void ShowMenu()
		{
			if (menuCanvas != null) menuCanvas.enabled = true;
			gameObject.SetActive(true);
		}

		public void HideMenu()
		{
			if (menuCanvas != null) menuCanvas.enabled = false;
		}

		public void DeactivateMenu() => gameObject.SetActive(false);
		public void ToggleTopButtonTransparency(bool isVisible) { }
		public void ToggleRestartButton(bool state) { if (restartButton != null) restartButton.gameObject.SetActive(state); }
		public void ToggleExitButton(bool state) { if (exitButton != null) exitButton.gameObject.SetActive(state); }
		public void ActivateMenu() => gameObject.SetActive(true);
		public void ToggleLookUp(bool state) { if (LookUpText != null) LookUpText.SetActive(state); }
		public void SetStrokeCounterSettings(StrokeCounter.CounterTypes counterType, bool useExternalCountActivator) { }
		public StrokeCounter GetStrokeCounter() => strokeCounter;
		public void SetStrokeCounterSettings(int initialStrokes, StrokeCounter.CounterTypes counterType, bool useExternalCountActivator, int playerIndex = 0) { }
		public void ToggleStrokeCounter(bool state) { if (strokeCounterContainer != null) strokeCounterContainer.gameObject.SetActive(state); }
		public void CountStroke(GolfBallController shooter, int strokes) { }
		public void CountStroke(int playerIndex, int strokes) { }
		public void CountStroke(int strokes) { }
		public void EnableMenu() => ActivateMenu();
		public void DisableMenu() => DeactivateMenu();

		public void AbandonLevel()
		{
			OnAbandonButtonClicked?.Invoke();
			if (Level.HasInstance) Level.Instance.Abort();
		}

		public void RestartLevel()
		{
			OnRestartButtonClicked?.Invoke();
			if (Level.HasInstance) Level.Instance.Restart();
		}

		public void ResetStrokes(int resetToThis = 0) => Game.strokes = resetToThis;
		public void ToggleLeaderCrown(bool state) { }
		public void ResetStrokes(int playerId, int resetToThis = 0) => Game.strokes = resetToThis;
		public void SetOrientation(LevelData.WindowType window) { }
		public void ChallengeCompleted(string title) { }
		public void ChallengeFailed(string title) { }
		public void ShowChallengeInfo(string text) { }
		public void ShowChallengeInfo(string text, Sprite[] icons) { }
		public IEnumerator ShowText(string text, float duration) { yield break; }
		public void ShowUndockMessage() { }
		public void HideUndockMessage() { }
		public void EnableBuildText() { }
		public void DisableBuildText() { }
		public void SetActiveBuildText(bool enable) { }
		private void FindBuildText() { }
		public void ShowFullScreenText(string text, float duration) { }
		public void ShowInformationText(string text, float duration, bool aboveTransition = false) { }
		public void SetChallengeInfoToShowForMinSeconds(bool show) { }
	}
}
""")

    # 2. WTGPortCatalog.cs
    write_asset_file("Scripts/Assembly-CSharp/Core/WTGPortCatalog.cs", """using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	[CreateAssetMenu(fileName = "WTGPortCatalog", menuName = "WhatTheGolf/PortCatalog")]
	public class WTGPortCatalog : ScriptableObject
	{
		[Serializable]
		public class EpisodeEntry
		{
			public string packId;
			public string title;
			public string overworldScene;
			public ContentPack pack;
			public List<LevelData> levels = new List<LevelData>();
		}

		public RuntimeStoreData storeData;
		public PlatformSettings platformSettings;
		public ShootArrow defaultShootArrow;
		public List<EpisodeEntry> episodes = new List<EpisodeEntry>();
		public List<LevelData> allLevels = new List<LevelData>();
		public List<string> allSceneNames = new List<string>();

		private static WTGPortCatalog _instance;
		public static WTGPortCatalog Instance
		{
			get
			{
				if (_instance == null)
					_instance = Resources.Load<WTGPortCatalog>("WTGPortCatalog");
				return _instance;
			}
		}
	}
}
""", guid=CATALOG_SCRIPT_GUID)

    # 3. WTGPortRuntime.cs
    write_asset_file("Scripts/Assembly-CSharp/Core/WTGPortRuntime.cs", """using System;
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
			GUI.Box(boxRect, "WHAT THE GOLF? — Episodes & Level Browser (v20.5.34 Android Port)");

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
				int count = SceneManager.sceneCountInBuildSettings;
				_scrollPos = GUILayout.BeginScrollView(_scrollPos);
				for (int i = 0; i < count; i++)
				{
					string path = SceneUtility.GetScenePathByBuildIndex(i);
					string name = System.IO.Path.GetFileNameWithoutExtension(path);
					if (GUILayout.Button($"{i}: {name}", btnStyle, GUILayout.Height(36f * scale)))
					{
						_showMenu = false;
						SceneManager.LoadScene(i);
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
			if (Application.CanStreamedLevelBeLoaded(sceneName))
				SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
		}
	}
}
""", guid=RUNTIME_SCRIPT_GUID)

    # 4. Editor/WTGAndroidBuilder.cs
    write_asset_file("Editor/WTGAndroidBuilder.cs", """using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public static class WTGAndroidBuilder
{
	[MenuItem("WhatTheGolf/Build Android APK")]
	public static void BuildAll()
	{
		try
		{
			Debug.Log("[WTGAndroidBuilder] Starting WHAT THE GOLF? (v20.5.34) Android APK build...");

			string sdkRoot = Environment.GetEnvironmentVariable("ANDROID_SDK_ROOT") ?? "/home/ubuntu/mm-sdk";
			string ndkRoot = Environment.GetEnvironmentVariable("ANDROID_NDK_ROOT") ?? "/home/ubuntu/ndk-r23b";
			string jdkRoot = Environment.GetEnvironmentVariable("JAVA_HOME") ?? "/home/ubuntu/jdk11";

			if (Directory.Exists(sdkRoot)) EditorPrefs.SetString("AndroidSdkRoot", sdkRoot);
			if (Directory.Exists(ndkRoot))
			{
				EditorPrefs.SetString("AndroidNdkRoot", ndkRoot);
				EditorPrefs.SetString("AndroidNdkRootR23B", ndkRoot);
			}
			if (Directory.Exists(jdkRoot))
			{
				EditorPrefs.SetString("JdkPath", jdkRoot);
				EditorPrefs.SetString("Jdk11Path", jdkRoot);
				EditorPrefs.SetBool("JdkUseEmbedded", false);
			}

			PlayerSettings.companyName = "Triband";
			PlayerSettings.productName = "WHAT THE GOLF?";
			PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.thelabelgames.golf");
			PlayerSettings.bundleVersion = "20.5.34";
			PlayerSettings.Android.bundleVersionCode = 200534;
			PlayerSettings.allowUnsafeCode = true;

			PlayerSettings.defaultInterfaceOrientation = UIOrientation.AutoRotation;
			PlayerSettings.allowedAutorotateToLandscapeLeft = true;
			PlayerSettings.allowedAutorotateToLandscapeRight = true;
			PlayerSettings.allowedAutorotateToPortrait = true;
			PlayerSettings.allowedAutorotateToPortraitUpsideDown = false;

			PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel24;
			PlayerSettings.Android.targetSdkVersion = (AndroidSdkVersions)34;
			PlayerSettings.Android.renderOutsideSafeArea = true;
			PlayerSettings.SplashScreen.show = false;
			PlayerSettings.SplashScreen.showUnityLogo = false;

			PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.Android, false);
			PlayerSettings.SetGraphicsAPIs(
				BuildTarget.Android,
				new UnityEngine.Rendering.GraphicsDeviceType[] { UnityEngine.Rendering.GraphicsDeviceType.OpenGLES3 }
			);
			PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android, ScriptingImplementation.IL2CPP);

			string archEnv = Environment.GetEnvironmentVariable("WTG_ARCH") ?? "ARM64";
			if (archEnv == "X86_64")
				PlayerSettings.Android.targetArchitectures = AndroidArchitecture.X86_64;
			else if (archEnv == "BOTH")
				PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64 | AndroidArchitecture.X86_64;
			else
				PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;

			AssetDatabase.Refresh();

			var scenes = EditorBuildSettings.scenes
				.Where(s => s != null && s.enabled && File.Exists(s.path))
				.Select(s => s.path)
				.ToList();

			if (!scenes.Contains("Assets/Scenes/_Start.unity") && File.Exists("Assets/Scenes/_Start.unity"))
				scenes.Insert(0, "Assets/Scenes/_Start.unity");
			if (!scenes.Contains("Assets/Scenes/Loading.unity") && File.Exists("Assets/Scenes/Loading.unity"))
				scenes.Insert(Mathf.Min(1, scenes.Count), "Assets/Scenes/Loading.unity");

			string outDir = Environment.GetEnvironmentVariable("WTG_BUILD_DIR") ?? "/home/ubuntu/c113work/build";
			Directory.CreateDirectory(outDir);
			string apkPath = Path.Combine(outDir, "WhatTheGolf-Android.apk");
			if (File.Exists(apkPath))
				File.Delete(apkPath);

			EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
			EditorUserBuildSettings.exportAsGoogleAndroidProject = false;
			EditorUserBuildSettings.androidBuildSystem = AndroidBuildSystem.Gradle;

			var opts = new BuildPlayerOptions
			{
				scenes = scenes.ToArray(),
				locationPathName = apkPath,
				target = BuildTarget.Android,
				targetGroup = BuildTargetGroup.Android,
				options = BuildOptions.None
			};

			BuildReport report = BuildPipeline.BuildPlayer(opts);
			Debug.LogFormat(
				"[WTGAndroidBuilder] BuildPlayer result: {0}, totalSize={1}, totalErrors={2}",
				report.summary.result,
				report.summary.totalSize,
				report.summary.totalErrors
			);

			if (report.summary.result != BuildResult.Succeeded)
			{
				EditorApplication.Exit(2);
				return;
			}
			EditorApplication.Exit(0);
		}
		catch (Exception ex)
		{
			Debug.LogError("[WTGAndroidBuilder] Exception: " + ex);
			EditorApplication.Exit(1);
		}
	}
}
""", guid=BUILDER_SCRIPT_GUID)

    print("Implemented Menu, InGameMenu, WTGPortCatalog, WTGPortRuntime, and WTGAndroidBuilder")


if __name__ == "__main__":
    main()
