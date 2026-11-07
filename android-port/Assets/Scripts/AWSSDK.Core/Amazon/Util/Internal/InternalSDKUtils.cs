using System;
using System.Collections.Generic;

namespace Amazon.Util.Internal
{
	public static class InternalSDKUtils
	{
		internal const string UnknownVersion = "Unknown";

		internal const string UnknownNetFrameworkVersion = ".NET_Runtime/Unknown .NET_Framework/Unknown";

		private static string _versionNumber;

		private static string _customSdkUserAgent;

		private static string _customData;

		internal static string EXECUTION_ENVIRONMENT_ENVVAR;

		internal const string CoreVersionNumber = "3.3.107.34";

		private static string _userAgentBaseName;

		private static readonly string _unknown;

		public static void SetUserAgent(string productName, string versionNumber)
		{
		}

		public static void SetUserAgent(string productName, string versionNumber, string customData)
		{
		}

		private static void BuildCustomUserAgentString()
		{
		}

		public static string BuildUserAgentString(string serviceSdkVersion)
		{
			return null;
		}

		public static void ApplyValues(object target, IDictionary<string, object> propertyValues)
		{
		}

		public static void AddToDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
		}

		public static void FillDictionary<T, TKey, TValue>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator, Dictionary<TKey, TValue> targetDictionary)
		{
		}

		public static Dictionary<TKey, TValue> ToDictionary<T, TKey, TValue>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator)
		{
			return null;
		}

		public static Dictionary<TKey, TValue> ToDictionary<T, TKey, TValue>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static bool TryFindByValue<TKey, TValue>(IDictionary<TKey, TValue> dictionary, TValue value, IEqualityComparer<TValue> valueComparer, out TKey key)
		{
			key = default;
			return false;
		}

		internal static string GetExecutionEnvironment()
		{
			return null;
		}

		private static string GetExecutionEnvironmentUserAgentString()
		{
			return null;
		}

		public static void SetIsSet<T>(bool isSet, ref T? field) where T : struct
		{
		}

		public static void SetIsSet<T>(bool isSet, ref List<T> field)
		{
		}

		public static void SetIsSet<TKey, TValue>(bool isSet, ref Dictionary<TKey, TValue> field)
		{
		}

		public static bool GetIsSet<T>(T? field) where T : struct
		{
			return false;
		}

		public static bool GetIsSet<T>(List<T> field)
		{
			return false;
		}

		public static bool GetIsSet<TKey, TVvalue>(Dictionary<TKey, TVvalue> field)
		{
			return false;
		}

		public static string GetValidSubstringOrUnknown(string str, int start, int end)
		{
			return null;
		}

		public static string DetermineRuntime()
		{
			return null;
		}

		public static string DetermineFramework()
		{
			return null;
		}

		public static string DetermineOS()
		{
			return null;
		}

		public static string DetermineOSVersion()
		{
			return null;
		}

		public static string PlatformUserAgent()
		{
			return null;
		}
	}
}
