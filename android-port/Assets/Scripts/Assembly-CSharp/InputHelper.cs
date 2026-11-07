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
	}

	public static bool IsNavigatingWithController()
	{
		return false;
	}

	public static bool IsNavigatingWithKeyboard()
	{
		return false;
	}

	public static bool IsCurrentJoystickOrKeyboard()
	{
		return false;
	}

	public static void UpdateLastInput()
	{
	}

	private static int GetAllPlayerAxisRounded(string axisName)
	{
		return 0;
	}

	private static bool GetAllPlayerButtonUp(string buttonName)
	{
		return false;
	}

	public static int GetAllPlayerAxisRoundedHorizontal()
	{
		return 0;
	}

	public static int GetAllPlayerAxisRoundedVertical()
	{
		return 0;
	}

	public static bool GetAllPlayerButtonConfirm()
	{
		return false;
	}

	public static bool GetAllPlayerButtonCancel()
	{
		return false;
	}

	public static bool GetAllPlayerButtonOpenMenu()
	{
		return false;
	}

	public static bool GetAllPlayerButtonGoBack()
	{
		return false;
	}

	public static bool GetAllPlayerButtonDebug1()
	{
		return false;
	}

	public static bool GetAllPlayerButtonDebug2()
	{
		return false;
	}

	public static bool GetAllPlayerButtonDebug3()
	{
		return false;
	}

	public static bool GetAllPlayerButtonDebug4()
	{
		return false;
	}

	public static bool GetAllPlayerButtonCheat()
	{
		return false;
	}

	public static bool TouchedOrMouseClicked()
	{
		return false;
	}

	public static bool GetAllPlayerButtonDown(string buttonName)
	{
		return false;
	}

	public static Vector2 FixAxialDeadzoneForAppleArcade(Vector2 dir)
	{
		return default;
	}
}
