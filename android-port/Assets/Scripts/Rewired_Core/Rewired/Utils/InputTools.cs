using Il2CppDummyDll;
using Rewired.Data.Mapping;
using UnityEngine;

namespace Rewired.Utils
{
	[Token(Token = "0x200033A")]
	internal static class InputTools
	{
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x23D8264", Offset = "0x23D8264", VA = "0x23D8264")]
		public static float TransformAxis2DComponentValue(float value, float zero, float min, float max)
		{
			return default;
		}

		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x23D8300", Offset = "0x23D8300", VA = "0x23D8300")]
		public static float GetCalibratedAxisValueClamped(float value, float zero, float min, float max, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
			return default;
		}

		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x23D861C", Offset = "0x23D861C", VA = "0x23D861C")]
		public static float GetCalibratedAxisValue(float value, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
			return default;
		}

		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x23D86D4", Offset = "0x23D86D4", VA = "0x23D86D4")]
		public static Vector2 ApplyRadialDeadZone(float xValue, float yValue, float deadzone)
		{
			return default;
		}

		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x23D8454", Offset = "0x23D8454", VA = "0x23D8454")]
		public static float ApplySensitivity(float value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
			return default;
		}

		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x23D8788", Offset = "0x23D8788", VA = "0x23D8788")]
		private static bool cMuTXazpBxoJtTVjgCoJikgtVnEY(AnimationCurve P_0)
		{
			return default;
		}

		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x23D8838", Offset = "0x23D8838", VA = "0x23D8838")]
		public static void ApplyRadialSensitivity(ref Vector2 value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
		}

		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x23D8954", Offset = "0x23D8954", VA = "0x23D8954")]
		public static string FormatHardwareIdentifierString(string str)
		{
			return null;
		}

		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x23D8A20", Offset = "0x23D8A20", VA = "0x23D8A20")]
		public static AxisRange InvertAxisRange(AxisRange axisRange)
		{
			return default;
		}

		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x23D8A78", Offset = "0x23D8A78", VA = "0x23D8A78")]
		public static void CompareLastActiveController(Controller controller, ref Controller lastController, ref double lastTime)
		{
		}

		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x23CDDAC", Offset = "0x23CDDAC", VA = "0x23CDDAC")]
		public static bool IsMappableType(ControllerElementType type)
		{
			return default;
		}

		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x23D03B0", Offset = "0x23D03B0", VA = "0x23D03B0")]
		public static bool IsMappableType(ControllerTemplateElementType type)
		{
			return default;
		}

		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x23D8AD8", Offset = "0x23D8AD8", VA = "0x23D8AD8")]
		public static bool HandleForced4WayHatsOnUnknownControllers(int direction, ref HatType hatType)
		{
			return default;
		}
	}
}
