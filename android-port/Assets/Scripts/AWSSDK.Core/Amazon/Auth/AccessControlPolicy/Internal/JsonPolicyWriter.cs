using System.Collections.Generic;
using Il2CppDummyDll;
using ThirdParty.Json.LitJson;

namespace Amazon.Auth.AccessControlPolicy.Internal
{
	[Token(Token = "0x200026D")]
	internal static class JsonPolicyWriter
	{
		[Token(Token = "0x6001213")]
		[Address(RVA = "0x12324D4", Offset = "0x12324D4", VA = "0x12324D4")]
		public static string WritePolicyToString(bool prettyPrint, Policy policy)
		{
			return null;
		}

		[Token(Token = "0x6001214")]
		[Address(RVA = "0x1232760", Offset = "0x1232760", VA = "0x1232760")]
		private static void writePolicy(Policy policy, JsonWriter generator)
		{
		}

		[Token(Token = "0x6001215")]
		[Address(RVA = "0x1232C74", Offset = "0x1232C74", VA = "0x1232C74")]
		private static void writePrincipals(Statement statement, JsonWriter generator)
		{
		}

		[Token(Token = "0x6001216")]
		[Address(RVA = "0x1233630", Offset = "0x1233630", VA = "0x1233630")]
		private static void writeActions(Statement statement, JsonWriter generator)
		{
		}

		[Token(Token = "0x6001217")]
		[Address(RVA = "0x1233AEC", Offset = "0x1233AEC", VA = "0x1233AEC")]
		private static void writeResources(Statement statement, JsonWriter generator)
		{
		}

		[Token(Token = "0x6001218")]
		[Address(RVA = "0x1233FA8", Offset = "0x1233FA8", VA = "0x1233FA8")]
		private static void writeConditions(Statement statement, JsonWriter generator)
		{
		}

		[Token(Token = "0x6001219")]
		[Address(RVA = "0x1234810", Offset = "0x1234810", VA = "0x1234810")]
		private static Dictionary<string, Dictionary<string, List<string>>> sortConditionsByTypeAndKey(IList<Condition> conditions)
		{
			return null;
		}

		[Token(Token = "0x600121A")]
		[Address(RVA = "0x1232C40", Offset = "0x1232C40", VA = "0x1232C40")]
		private static void writePropertyValue(JsonWriter generator, string propertyName, string value)
		{
		}
	}
}
