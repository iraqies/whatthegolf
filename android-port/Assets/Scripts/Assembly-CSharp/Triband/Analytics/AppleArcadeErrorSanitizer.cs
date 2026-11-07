namespace Triband.Analytics
{
	public static class AppleArcadeErrorSanitizer
	{
		public static bool IsAllowedToSend(ConditionType conditionType)
		{
			return false;
		}

		public static ConditionType ClassifyCondition(string condition)
		{
			return ConditionType.Unknown;
		}
	}
}
