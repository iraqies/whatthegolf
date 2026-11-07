using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BFF")]
public class InputHelper : MonoBehaviour
{
	[Token(Token = "0x400426D")]
	[FieldOffset(Offset = "0x0")]
	private static float controllerTime;

	[Token(Token = "0x400426E")]
	public const string INPUT_UI_HORIZONTAL = "UI Horizontal";

	[Token(Token = "0x400426F")]
	public const string INPUT_UI_VERTICAL = "UI Vertical";

	[Token(Token = "0x4004270")]
	public const string INPUT_UI_CONFIRM = "Confirm UI";

	[Token(Token = "0x4004271")]
	public const string INPUT_OPEN_MENU = "Open Menu";

	[Token(Token = "0x4004272")]
	public const string INPUT_CLOSE_MENU = "Close Menu";

	[Token(Token = "0x4004273")]
	public const string INPUT_BACK = "Go Back";

	[Token(Token = "0x4004274")]
	public const string INPUT_DEBUG1 = "Debug1";

	[Token(Token = "0x4004275")]
	public const string INPUT_DEBUG2 = "Debug2";

	[Token(Token = "0x4004276")]
	public const string INPUT_DEBUG3 = "Debug3";

	[Token(Token = "0x4004277")]
	public const string INPUT_DEBUG4 = "Debug4";

	[Token(Token = "0x4004278")]
	public const string INPUT_CHEAT = "Cheat";

	[Token(Token = "0x600398D")]
	[Address(RVA = "0x14EDCB8", Offset = "0x14EDCB8", VA = "0x14EDCB8")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6B3A0", Offset = "0x6B3A0")]
	private static void Init()
	{
	}

	[Token(Token = "0x600398E")]
	[Address(RVA = "0x14EDD20", Offset = "0x14EDD20", VA = "0x14EDD20")]
	public static bool IsNavigatingWithController()
	{
		return default;
	}

	[Token(Token = "0x600398F")]
	[Address(RVA = "0x14EDF48", Offset = "0x14EDF48", VA = "0x14EDF48")]
	public static bool IsNavigatingWithKeyboard()
	{
		return default;
	}

	[Token(Token = "0x6003990")]
	[Address(RVA = "0x14EDFC0", Offset = "0x14EDFC0", VA = "0x14EDFC0")]
	public static bool IsCurrentJoystickOrKeyboard()
	{
		return default;
	}

	[Token(Token = "0x6003991")]
	[Address(RVA = "0x14EE0A8", Offset = "0x14EE0A8", VA = "0x14EE0A8")]
	public static void UpdateLastInput()
	{
	}

	[Token(Token = "0x6003992")]
	[Address(RVA = "0x14EE2CC", Offset = "0x14EE2CC", VA = "0x14EE2CC")]
	private static int GetAllPlayerAxisRounded(string axisName)
	{
		return default;
	}

	[Token(Token = "0x6003993")]
	[Address(RVA = "0x14EE3F8", Offset = "0x14EE3F8", VA = "0x14EE3F8")]
	private static bool GetAllPlayerButtonUp(string buttonName)
	{
		return default;
	}

	[Token(Token = "0x6003994")]
	[Address(RVA = "0x14EE25C", Offset = "0x14EE25C", VA = "0x14EE25C")]
	public static int GetAllPlayerAxisRoundedHorizontal()
	{
		return default;
	}

	[Token(Token = "0x6003995")]
	[Address(RVA = "0x14EE4FC", Offset = "0x14EE4FC", VA = "0x14EE4FC")]
	public static int GetAllPlayerAxisRoundedVertical()
	{
		return default;
	}

	[Token(Token = "0x6003996")]
	[Address(RVA = "0x14EE56C", Offset = "0x14EE56C", VA = "0x14EE56C")]
	public static bool GetAllPlayerButtonConfirm()
	{
		return default;
	}

	[Token(Token = "0x6003997")]
	[Address(RVA = "0x14E98A0", Offset = "0x14E98A0", VA = "0x14E98A0")]
	public static bool GetAllPlayerButtonCancel()
	{
		return default;
	}

	[Token(Token = "0x6003998")]
	[Address(RVA = "0x14EE5DC", Offset = "0x14EE5DC", VA = "0x14EE5DC")]
	public static bool GetAllPlayerButtonOpenMenu()
	{
		return default;
	}

	[Token(Token = "0x6003999")]
	[Address(RVA = "0x14EE64C", Offset = "0x14EE64C", VA = "0x14EE64C")]
	public static bool GetAllPlayerButtonGoBack()
	{
		return default;
	}

	[Token(Token = "0x600399A")]
	[Address(RVA = "0x14EE6BC", Offset = "0x14EE6BC", VA = "0x14EE6BC")]
	public static bool GetAllPlayerButtonDebug1()
	{
		return default;
	}

	[Token(Token = "0x600399B")]
	[Address(RVA = "0x14EE72C", Offset = "0x14EE72C", VA = "0x14EE72C")]
	public static bool GetAllPlayerButtonDebug2()
	{
		return default;
	}

	[Token(Token = "0x600399C")]
	[Address(RVA = "0x14EE79C", Offset = "0x14EE79C", VA = "0x14EE79C")]
	public static bool GetAllPlayerButtonDebug3()
	{
		return default;
	}

	[Token(Token = "0x600399D")]
	[Address(RVA = "0x14EE80C", Offset = "0x14EE80C", VA = "0x14EE80C")]
	public static bool GetAllPlayerButtonDebug4()
	{
		return default;
	}

	[Token(Token = "0x600399E")]
	[Address(RVA = "0x14EE87C", Offset = "0x14EE87C", VA = "0x14EE87C")]
	public static bool GetAllPlayerButtonCheat()
	{
		return default;
	}

	[Token(Token = "0x600399F")]
	[Address(RVA = "0x14EE8EC", Offset = "0x14EE8EC", VA = "0x14EE8EC")]
	public static bool TouchedOrMouseClicked()
	{
		return default;
	}

	[Token(Token = "0x60039A0")]
	[Address(RVA = "0x14EEA04", Offset = "0x14EEA04", VA = "0x14EEA04")]
	public static bool GetAllPlayerButtonDown(string buttonName)
	{
		return default;
	}

	[Token(Token = "0x60039A1")]
	[Address(RVA = "0x14EEB08", Offset = "0x14EEB08", VA = "0x14EEB08")]
	public static Vector2 FixAxialDeadzoneForAppleArcade(Vector2 dir)
	{
		return default;
	}

	[Token(Token = "0x60039A2")]
	[Address(RVA = "0x14EEBD8", Offset = "0x14EEBD8", VA = "0x14EEBD8")]
	public InputHelper()
	{
	}
}
