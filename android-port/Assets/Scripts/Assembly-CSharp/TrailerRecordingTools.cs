using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class TrailerRecordingTools : MonoBehaviour
{
	private enum FollowType
	{
		staticFollow = 0,
		tightFollow = 1,
		normalFollow = 2
	}

	[Serializable]
	public struct CameraPreset
	{
		public string Label;

		public Vector3 Rotation;

		public Vector3 Offset;

		public Vector3 GlobalOffset;

		public float FOV;

		internal bool isActive;
	}

	private FollowType followType;

	public GameObject clickCatchUIPrefab;

	private GameObject clickCatchUI;

	private GameObject clickCatchUICameraTools;

	private bool forceMobileCamera;

	private bool showingRecordMenu;

	private GameObject cameraManagerGO;

	public GameObject CinemachineCameraPrefab;

	private GameObject m_CinemachineCameraPrefab;

	private bool lookAtGoal;

	private GUIStyle labelCenterStyle;

	private GUIStyle labelHeaderStyle;

	private GUIStyle toggledOnButtonStyle;

	private GUIStyle toggledOffButtonStyle;

	private GUIStyle trailerBoxStyle;

	private float timeScale;

	private bool UIButtonsToggle;

	private bool UIChallengeToggle;

	private bool staticToggle;

	private Transform cameraFollowTransform;

	private GameObject staticCameraFollowTransform;

	private bool cheatCompleteLevel;

	private bool cheatCompleteChallenge;

	private bool Use3DCamera;

	private bool UseCameraPresets;

	private float goalTimerOffset;

	private string goalTimerOffsetString;

	private GameObject golfGoalGO;

	private float rotationOffsetX;

	private float rotationOffsetY;

	private float rotationOffsetZ;

	private string rotationOffsetXString;

	private string rotationOffsetYString;

	private string rotationOffsetZString;

	private float zoomOffset;

	private string zoomOffsetString;

	private float cameraOffsetX;

	private float cameraOffsetY;

	private float cameraOffsetZ;

	private string cameraOffsetXString;

	private string cameraOffsetYString;

	private string cameraOffsetZString;

	private float globalOffsetX;

	private float globalOffsetY;

	private float globalOffsetZ;

	private string globalOffsetXString;

	private string globalOffsetYString;

	private string globalOffsetZString;

	public static TrailerRecordingTools Instance;

	private bool hasMusic;

	private const float defaultX = 1920f;

	private const float defaultY = 1080f;

	private const float jumpSmall = 0.1f;

	private const float jumpLarge = 0.5f;

	public int fontSize;

	public int fontSizeSmall;

	public int basePadding;

	public int buttonPadding;

	private Rect RecordingMenu;

	private Rect CameraMenu;

	private bool hasSetupStyles;

	private bool hasSetupCanvases;

	private bool cameraTooCustom;

	private List<CameraPreset> CameraPresets;

	private CameraPreset NormalCameraPreset;

	private GameObject StrokeCounterGO;

	public float distanceToController;

	public float defaultFOV;

	private string levelName;

	public bool usingCinemachine;

	private float damping;

	private string dampingString;

	private string smoothStartString;

	private string smoothUpdateString;

	private string smoothAimString;

	private float smoothStart;

	private float smoothUpdate;

	private float smoothAim;

	public bool BeenOpenedOnce { get; private set; }

	public bool HasShownTutorial { get; private set; }

	private void Start()
	{
	}

	private void ResetTrailerTools(LevelData data)
	{
	}

	private void CalculatePresets()
	{
	}

	private void CreatePreset(Transform targetTransform, string label, Vector3 pos)
	{
	}

	public void EnableMenu()
	{
	}

	public void DisableMenu()
	{
	}

	private void OnGUI()
	{
	}

	private void Label(string l, bool big = false)
	{
	}

	private void begin()
	{
	}

	private void end()
	{
	}

	private void ToggleButton(string on, string off, bool control, Action action)
	{
	}

	private void plusMinusControl(string label, ref float field, ref string fieldString, float resetVal = 0f)
	{
	}

	private void SetMusic(bool enable)
	{
	}

	private static void ToggleMusic()
	{
	}

	public static bool ShouldCheatCompleteLevel()
	{
		return false;
	}

	public static bool ShouldCheatCompleteChallenge()
	{
		return false;
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void IntroInformation()
	{
	}

	private void SetClickCanvasToRect(ref GameObject click, Rect rect)
	{
	}

	private void SetActiveOverworldUI(bool enable)
	{
	}

	private void SetActiveMenuAndFPS(bool enable)
	{
	}

	private void SetActiveLevelUI(bool enable)
	{
	}

	private void SetChallengeUIAlpha(bool enable)
	{
	}

	private void SetStrokeCounterActive(bool enable)
	{
	}

	public void LateTick()
	{
	}

	private void AddCam()
	{
	}

	private void UpdateCam()
	{
	}

	private void DeleteCam()
	{
	}

	private void ToggleFreezeCamera()
	{
	}

	private void AddCBFollowCam()
	{
	}

	private void UpdateCBFollowCam()
	{
	}

	private void SetCBStaticCamera()
	{
	}

	private void DeleteCBFollowCam()
	{
	}

	private void AddCinemachineCamera()
	{
	}

	private void UpdateCinemachineCamera()
	{
	}

	private void DeleteCinemachineCamera()
	{
	}

	private void ToggleCinemachineFreezeCamera()
	{
	}

	private void SetFollowTransform(Transform t)
	{
	}

	private Transform GetFollowTransform()
	{
		return null;
	}

	private Transform GetSceneFollowTarget()
	{
		return null;
	}

	private void ToggleCursor()
	{
	}

	private void ToggleMobileCamera()
	{
	}

	private void SetToCameraPreset(CameraPreset p)
	{
	}

	private void SetupStyles()
	{
	}

	private void SetupRects()
	{
	}

	private IEnumerator Reset()
	{
		return null;
	}

	private void SetTimeout(Action cb, int mili)
	{
	}
}
