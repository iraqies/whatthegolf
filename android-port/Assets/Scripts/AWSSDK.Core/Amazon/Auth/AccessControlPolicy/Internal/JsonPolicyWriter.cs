using System.Collections.Generic;
using ThirdParty.Json.LitJson;

namespace Amazon.Auth.AccessControlPolicy.Internal
{
	internal static class JsonPolicyWriter
	{
		public static string WritePolicyToString(bool prettyPrint, Policy policy)
		{
			return null;
		}

		private static void writePolicy(Policy policy, JsonWriter generator)
		{
		}

		private static void writePrincipals(Statement statement, JsonWriter generator)
		{
		}

		private static void writeActions(Statement statement, JsonWriter generator)
		{
		}

		private static void writeResources(Statement statement, JsonWriter generator)
		{
		}

		private static void writeConditions(Statement statement, JsonWriter generator)
		{
		}

		private static Dictionary<string, Dictionary<string, List<string>>> sortConditionsByTypeAndKey(IList<Condition> conditions)
		{
			return null;
		}

		private static void writePropertyValue(JsonWriter generator, string propertyName, string value)
		{
		}
	}
}
