using ThirdParty.Json.LitJson;

namespace Amazon.Auth.AccessControlPolicy.Internal
{
	internal static class JsonPolicyReader
	{
		public static Policy ReadJsonStringToPolicy(string jsonString)
		{
			return null;
		}

		private static Statement convertStatement(JsonData jStatement)
		{
			return null;
		}

		private static void convertPrincipals(Statement statement, JsonData jStatement)
		{
		}

		private static void convertPrincipalRecord(Statement statement, JsonData jPrincipal)
		{
		}

		private static void convertActions(Statement statement, JsonData jStatement)
		{
		}

		private static void convertResources(Statement statement, JsonData jStatement)
		{
		}

		private static void convertCondition(Statement statement, JsonData jStatement)
		{
		}

		private static void convertConditionRecord(Statement statement, JsonData jCondition)
		{
		}
	}
}
