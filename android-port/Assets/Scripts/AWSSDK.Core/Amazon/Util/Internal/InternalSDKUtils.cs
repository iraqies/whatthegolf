using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Util.Internal
{
	[Token(Token = "0x2000079")]
	public static class InternalSDKUtils
	{
		[Token(Token = "0x4000258")]
		internal const string UnknownVersion = "Unknown";

		[Token(Token = "0x4000259")]
		internal const string UnknownNetFrameworkVersion = ".NET_Runtime/Unknown .NET_Framework/Unknown";

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x0")]
		private static string _versionNumber;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x8")]
		private static string _customSdkUserAgent;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x10")]
		private static string _customData;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x18")]
		internal static string EXECUTION_ENVIRONMENT_ENVVAR;

		[Token(Token = "0x400025E")]
		internal const string CoreVersionNumber = "3.3.107.34";

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x20")]
		private static string _userAgentBaseName;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string _unknown;

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x121C654", Offset = "0x121C654", VA = "0x121C654")]
		public static void SetUserAgent(string productName, string versionNumber)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x121C708", Offset = "0x121C708", VA = "0x121C708")]
		public static void SetUserAgent(string productName, string versionNumber, string customData)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x121C790", Offset = "0x121C790", VA = "0x121C790")]
		private static void BuildCustomUserAgentString()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x121CF40", Offset = "0x121CF40", VA = "0x121CF40")]
		public static string BuildUserAgentString(string serviceSdkVersion)
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x121D360", Offset = "0x121D360", VA = "0x121D360")]
		public static void ApplyValues(object target, IDictionary<string, object> propertyValues)
		{
		}

		[Token(Token = "0x6000471")]
		public static void AddToDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
		}

		[Token(Token = "0x6000472")]
		public static void FillDictionary<T, TKey, TValue>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator, Dictionary<TKey, TValue> targetDictionary)
		{
		}

		[Token(Token = "0x6000473")]
		public static Dictionary<TKey, TValue> ToDictionary<T, TKey, TValue>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator)
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		public static Dictionary<TKey, TValue> ToDictionary<T, TKey, TValue>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		public static bool TryFindByValue<TKey, TValue>(IDictionary<TKey, TValue> dictionary, TValue value, IEqualityComparer<TValue> valueComparer, out TKey key)
		{
			return default;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x121DC40", Offset = "0x121DC40", VA = "0x121DC40")]
		internal static string GetExecutionEnvironment()
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x121CE04", Offset = "0x121CE04", VA = "0x121CE04")]
		private static string GetExecutionEnvironmentUserAgentString()
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		public static void SetIsSet<T>(bool isSet, ref T? field) where T : struct
		{
		}

		[Token(Token = "0x6000479")]
		public static void SetIsSet<T>(bool isSet, ref List<T> field)
		{
		}

		[Token(Token = "0x600047A")]
		public static void SetIsSet<TKey, TValue>(bool isSet, ref Dictionary<TKey, TValue> field)
		{
		}

		[Token(Token = "0x600047B")]
		public static bool GetIsSet<T>(T? field) where T : struct
		{
			return default;
		}

		[Token(Token = "0x600047C")]
		public static bool GetIsSet<T>(List<T> field)
		{
			return default;
		}

		[Token(Token = "0x600047D")]
		public static bool GetIsSet<TKey, TVvalue>(Dictionary<TKey, TVvalue> field)
		{
			return default;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x121DCA8", Offset = "0x121DCA8", VA = "0x121DCA8")]
		public static string GetValidSubstringOrUnknown(string str, int start, int end)
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x121DD94", Offset = "0x121DD94", VA = "0x121DD94")]
		public static string DetermineRuntime()
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x121DF0C", Offset = "0x121DF0C", VA = "0x121DF0C")]
		public static string DetermineFramework()
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x121E094", Offset = "0x121E094", VA = "0x121E094")]
		public static string DetermineOS()
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x121E20C", Offset = "0x121E20C", VA = "0x121E20C")]
		public static string DetermineOSVersion()
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x121E394", Offset = "0x121E394", VA = "0x121E394")]
		public static string PlatformUserAgent()
		{
			return null;
		}
	}
}
