using UnityEngine;

public class InputHelper : MonoBehaviour
{
	private static float controllerTime;
	public const string INPUT_UI_HORIZONTAL = "UI Horizontal";
	public const string INPUT_UI_VERTICAL = "UI Vertical";
	public const string INPUT_UI_CONFIRM = "Confirm UI";
	public const string INPUT_OPEN_MENU = "Open Menu";
	public const string INPUT_CLOSE_MENU = "Close Menu";
	public const string INPUT_BACK = "Go Back";
	public const string INPUT_DEBUG1 = "Debug1";
	public const string INPUT_DEBUG2 = "Debug2";
	public const string INPUT_DEBUG3 = "Debug3";
	public const string INPUT_DEBUG4 = "Debug4";
	public const string INPUT_CHEAT = "Cheat";

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		controllerTime = -100f;
	}

	public static bool IsNavigatingWithController() => Time.unscaledTime - controllerTime < 3f;
	public static bool IsNavigatingWithKeyboard() => false;
	public static bool IsCurrentJoystickOrKeyboard() => IsNavigatingWithController();

	public static void UpdateLastInput()
	{
		if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.25f || Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0.25f || Input.GetKeyDown(KeyCode.JoystickButton0))
			controllerTime = Time.unscaledTime;
	}

	private static int GetAllPlayerAxisRounded(string axisName)
	{
		try
		{
			float v = Input.GetAxisRaw(axisName);
			if (Mathf.Abs(v) > 0.4f) return v > 0f ? 1 : -1;
		}
		catch { }
		return 0;
	}

	private static bool GetAllPlayerButtonUp(string buttonName) => GetAllPlayerButtonDown(buttonName);

	public static int GetAllPlayerAxisRoundedHorizontal() => GetAllPlayerAxisRounded("Horizontal");
	public static int GetAllPlayerAxisRoundedVertical() => GetAllPlayerAxisRounded("Vertical");

	public static bool GetAllPlayerButtonConfirm() => Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.JoystickButton0);
	public static bool GetAllPlayerButtonCancel() => Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton1);
	public static bool GetAllPlayerButtonOpenMenu() => Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton7);
	public static bool GetAllPlayerButtonGoBack() => GetAllPlayerButtonCancel();
	public static bool GetAllPlayerButtonDebug1() => false;
	public static bool GetAllPlayerButtonDebug2() => false;
	public static bool GetAllPlayerButtonDebug3() => false;
	public static bool GetAllPlayerButtonDebug4() => false;
	public static bool GetAllPlayerButtonCheat() => false;

	public static bool TouchedOrMouseClicked()
	{
		if (Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
				if (Input.GetTouch(i).phase == TouchPhase.Began) return true;
		}
		return Input.GetMouseButtonDown(0);
	}

	public static bool GetAllPlayerButtonDown(string buttonName)
	{
		if (buttonName == INPUT_UI_CONFIRM || buttonName == "Shoot")
			return GetAllPlayerButtonConfirm();
		if (buttonName == INPUT_BACK || buttonName == INPUT_CLOSE_MENU)
			return GetAllPlayerButtonCancel();
		if (buttonName == INPUT_OPEN_MENU)
			return GetAllPlayerButtonOpenMenu();
		return false;
	}

	public static Vector2 FixAxialDeadzoneForAppleArcade(Vector2 dir)
	{
		return dir.magnitude < 0.15f ? Vector2.zero : dir;
	}
}
