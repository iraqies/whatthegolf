using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Amazon.Runtime;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon
{
	public static class AWSConfigs
	{
		private static char[] validSeparators;

		internal static Func<DateTime> utcNowSource;

		internal static string _awsRegion;

		internal static LoggingOptions _logging;

		internal static ResponseLoggingOption _responseLogging;

		internal static bool _logMetrics;

		internal static string _endpointDefinition;

		internal static string _awsProfileName;

		internal static string _awsAccountsLocation;

		internal static bool _useSdkCache;

		private static object _lock;

		private static List<string> standardConfigs;

		private static bool configPresent;

		private static RootConfig _rootConfig;

		public const string AWSRegionKey = "AWSRegion";

		public const string AWSProfileNameKey = "AWSProfileName";

		public const string AWSProfilesLocationKey = "AWSProfilesLocation";

		public const string LoggingKey = "AWSLogging";

		public const string ResponseLoggingKey = "AWSResponseLogging";

		public const string LogMetricsKey = "AWSLogMetrics";

		public const string EndpointDefinitionKey = "AWSEndpointDefinition";

		public const string UseSdkCacheKey = "AWSCache";

		internal const string LoggingDestinationProperty = "LogTo";

		internal static PropertyChangedEventHandler mPropertyChanged;

		internal static readonly object propertyChangedLock;

		private static Dictionary<string, List<TraceListener>> _traceListeners;

		public static TimeSpan? ManualClockCorrection
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool CorrectForClockSkew
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete]
		public static TimeSpan ClockOffset { get; internal set; }

		public static string AWSRegion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string AWSProfileName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string AWSProfilesLocation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete]
		public static LoggingOptions Logging
		{
			get
			{
				return LoggingOptions.None;
			}
			set
			{
			}
		}

		[Obsolete]
		public static ResponseLoggingOption ResponseLogging
		{
			get
			{
				return ResponseLoggingOption.Never;
			}
			set
			{
			}
		}

		[Obsolete]
		public static bool LogMetrics
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string EndpointDefinition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool UseSdkCache
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static LoggingConfig LoggingConfig => null;

		public static ProxyConfig ProxyConfig => null;

		public static bool UseAlternateUserAgentHeader
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static RegionEndpoint RegionEndpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static CSMConfig CSMConfig
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static HttpClientFactory HttpClientFactory { get; set; }

		internal static event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		private static LoggingOptions GetLoggingSetting()
		{
			return LoggingOptions.None;
		}

		internal static void OnPropertyChanged(string name)
		{
		}

		private static bool GetConfigBool(string name, bool defaultValue = false)
		{
			return false;
		}

		private static T GetConfigEnum<T>(string name)
		{
			return default;
		}

		private static T ParseEnum<T>(string value)
		{
			return default;
		}

		private static bool TryParseEnum<T>(string value, out T result)
		{
			result = default;
			return false;
		}

		private static DateTime GetUtcNow()
		{
			return default;
		}

		public static string GetConfig(string name)
		{
			return null;
		}

		internal static bool XmlSectionExists(string sectionName)
		{
			return false;
		}

		public static void AddTraceListener(string source, TraceListener listener)
		{
		}

		public static void RemoveTraceListener(string source, string name)
		{
		}

		internal static TraceListener[] TraceListeners(string source)
		{
			return null;
		}
	}
}
