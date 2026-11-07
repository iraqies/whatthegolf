using Il2CppDummyDll;
using ThirdParty.Json.LitJson;

namespace Amazon.Auth.AccessControlPolicy.Internal
{
	[Token(Token = "0x200026C")]
	internal static class JsonPolicyReader
	{
		[Token(Token = "0x600120B")]
		[Address(RVA = "0x122F834", Offset = "0x122F834", VA = "0x122F834")]
		public static Policy ReadJsonStringToPolicy(string jsonString)
		{
			return null;
		}

		[Token(Token = "0x600120C")]
		[Address(RVA = "0x122FD1C", Offset = "0x122FD1C", VA = "0x122FD1C")]
		private static Statement convertStatement(JsonData jStatement)
		{
			return null;
		}

		[Token(Token = "0x600120D")]
		[Address(RVA = "0x1230CBC", Offset = "0x1230CBC", VA = "0x1230CBC")]
		private static void convertPrincipals(Statement statement, JsonData jStatement)
		{
		}

		[Token(Token = "0x600120E")]
		[Address(RVA = "0x12311BC", Offset = "0x12311BC", VA = "0x12311BC")]
		private static void convertPrincipalRecord(Statement statement, JsonData jPrincipal)
		{
		}

		[Token(Token = "0x600120F")]
		[Address(RVA = "0x122FE98", Offset = "0x122FE98", VA = "0x122FE98")]
		private static void convertActions(Statement statement, JsonData jStatement)
		{
		}

		[Token(Token = "0x6001210")]
		[Address(RVA = "0x12303E0", Offset = "0x12303E0", VA = "0x12303E0")]
		private static void convertResources(Statement statement, JsonData jStatement)
		{
		}

		[Token(Token = "0x6001211")]
		[Address(RVA = "0x1230928", Offset = "0x1230928", VA = "0x1230928")]
		private static void convertCondition(Statement statement, JsonData jStatement)
		{
		}

		[Token(Token = "0x6001212")]
		[Address(RVA = "0x12319E8", Offset = "0x12319E8", VA = "0x12319E8")]
		private static void convertConditionRecord(Statement statement, JsonData jCondition)
		{
		}
	}
}
