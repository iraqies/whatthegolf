using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Amazon.Runtime;
using Amazon.Util;
using Amazon.Util.Internal;
using Il2CppDummyDll;

namespace Amazon
{
	[Token(Token = "0x2000036")]
	public static class AWSConfigs
	{
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x0")]
		private static char[] validSeparators;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x8")]
		internal static Func<DateTime> utcNowSource;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x10")]
		internal static string _awsRegion;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x18")]
		internal static LoggingOptions _logging;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x1C")]
		internal static ResponseLoggingOption _responseLogging;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x20")]
		internal static bool _logMetrics;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x28")]
		internal static string _endpointDefinition;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x30")]
		internal static string _awsProfileName;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x38")]
		internal static string _awsAccountsLocation;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x40")]
		internal static bool _useSdkCache;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x48")]
		private static object _lock;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x50")]
		private static List<string> standardConfigs;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x58")]
		private static bool configPresent;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x60")]
		private static RootConfig _rootConfig;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26148", Offset = "0x26148")]
		private static TimeSpan ClockOffset__BackingField;

		[Token(Token = "0x40000ED")]
		public const string AWSRegionKey = "AWSRegion";

		[Token(Token = "0x40000EE")]
		public const string AWSProfileNameKey = "AWSProfileName";

		[Token(Token = "0x40000EF")]
		public const string AWSProfilesLocationKey = "AWSProfilesLocation";

		[Token(Token = "0x40000F0")]
		public const string LoggingKey = "AWSLogging";

		[Token(Token = "0x40000F1")]
		public const string ResponseLoggingKey = "AWSResponseLogging";

		[Token(Token = "0x40000F2")]
		public const string LogMetricsKey = "AWSLogMetrics";

		[Token(Token = "0x40000F3")]
		public const string EndpointDefinitionKey = "AWSEndpointDefinition";

		[Token(Token = "0x40000F4")]
		public const string UseSdkCacheKey = "AWSCache";

		[Token(Token = "0x40000F5")]
		internal const string LoggingDestinationProperty = "LogTo";

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x70")]
		internal static PropertyChangedEventHandler mPropertyChanged;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x78")]
		internal static readonly object propertyChangedLock;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26158", Offset = "0x26158")]
		private static HttpClientFactory HttpClientFactory__BackingField;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x88")]
		private static Dictionary<string, List<TraceListener>> _traceListeners;

		[Token(Token = "0x17000066")]
		public static TimeSpan? ManualClockCorrection
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x11BBEE4", Offset = "0x11BBEE4", VA = "0x11BBEE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x11BBF40", Offset = "0x11BBF40", VA = "0x11BBF40")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public static bool CorrectForClockSkew
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x11BBFCC", Offset = "0x11BBFCC", VA = "0x11BBFCC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x11BC03C", Offset = "0x11BC03C", VA = "0x11BC03C")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C35C", Offset = "0x2C35C")]
		public static TimeSpan ClockOffset
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x11BC0B8", Offset = "0x11BC0B8", VA = "0x11BC0B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27E30", Offset = "0x27E30")]
			get
			{
				return default;
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x11BC11C", Offset = "0x11BC11C", VA = "0x11BC11C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27E40", Offset = "0x27E40")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public static string AWSRegion
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x11BC18C", Offset = "0x11BC18C", VA = "0x11BC18C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x11BC1FC", Offset = "0x11BC1FC", VA = "0x11BC1FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public static string AWSProfileName
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x11BC278", Offset = "0x11BC278", VA = "0x11BC278")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x11BC2E8", Offset = "0x11BC2E8", VA = "0x11BC2E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public static string AWSProfilesLocation
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x11BC364", Offset = "0x11BC364", VA = "0x11BC364")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x11BC3D4", Offset = "0x11BC3D4", VA = "0x11BC3D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C394", Offset = "0x2C394")]
		public static LoggingOptions Logging
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x11BC450", Offset = "0x11BC450", VA = "0x11BC450")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x11BC4C8", Offset = "0x11BC4C8", VA = "0x11BC4C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C3CC", Offset = "0x2C3CC")]
		public static ResponseLoggingOption ResponseLogging
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x11BC5F8", Offset = "0x11BC5F8", VA = "0x11BC5F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x11BC670", Offset = "0x11BC670", VA = "0x11BC670")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C404", Offset = "0x2C404")]
		public static bool LogMetrics
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x11BC6F4", Offset = "0x11BC6F4", VA = "0x11BC6F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x11BC76C", Offset = "0x11BC76C", VA = "0x11BC76C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public static string EndpointDefinition
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x11BC7F0", Offset = "0x11BC7F0", VA = "0x11BC7F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x11BC860", Offset = "0x11BC860", VA = "0x11BC860")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public static bool UseSdkCache
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x11BC8DC", Offset = "0x11BC8DC", VA = "0x11BC8DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x11BC94C", Offset = "0x11BC94C", VA = "0x11BC94C")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public static LoggingConfig LoggingConfig
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x11BC9C8", Offset = "0x11BC9C8", VA = "0x11BC9C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public static ProxyConfig ProxyConfig
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x11BCA38", Offset = "0x11BCA38", VA = "0x11BCA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public static bool UseAlternateUserAgentHeader
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x11BCAA8", Offset = "0x11BCAA8", VA = "0x11BCAA8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x11BCB18", Offset = "0x11BCB18", VA = "0x11BCB18")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public static RegionEndpoint RegionEndpoint
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x11BCB94", Offset = "0x11BCB94", VA = "0x11BCB94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x11BCC04", Offset = "0x11BCC04", VA = "0x11BCC04")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public static CSMConfig CSMConfig
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x11BCC84", Offset = "0x11BCC84", VA = "0x11BCC84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x11BCCF4", Offset = "0x11BCCF4", VA = "0x11BCCF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public static HttpClientFactory HttpClientFactory
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x11BD260", Offset = "0x11BD260", VA = "0x11BD260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27E50", Offset = "0x27E50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x11BD2C4", Offset = "0x11BD2C4", VA = "0x11BD2C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27E60", Offset = "0x27E60")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		internal static event PropertyChangedEventHandler PropertyChanged
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x11BCD70", Offset = "0x11BCD70", VA = "0x11BCD70")]
			add
			{
			}
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x11BCEF8", Offset = "0x11BCEF8", VA = "0x11BCEF8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x11BC550", Offset = "0x11BC550", VA = "0x11BC550")]
		private static LoggingOptions GetLoggingSetting()
		{
			return default;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x11BD080", Offset = "0x11BD080", VA = "0x11BD080")]
		internal static void OnPropertyChanged(string name)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x11BD140", Offset = "0x11BD140", VA = "0x11BD140")]
		private static bool GetConfigBool(string name, bool defaultValue = false)
		{
			return default;
		}

		[Token(Token = "0x600023B")]
		private static T GetConfigEnum<T>(string name)
		{
			return (T)null;
		}

		[Token(Token = "0x600023C")]
		private static T ParseEnum<T>(string value)
		{
			return (T)null;
		}

		[Token(Token = "0x600023D")]
		private static bool TryParseEnum<T>(string value, out T result)
		{
			return default;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x11BD1FC", Offset = "0x11BD1FC", VA = "0x11BD1FC")]
		private static DateTime GetUtcNow()
		{
			return default;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x11BC5F0", Offset = "0x11BC5F0", VA = "0x11BC5F0")]
		public static string GetConfig(string name)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x11BD258", Offset = "0x11BD258", VA = "0x11BD258")]
		internal static bool XmlSectionExists(string sectionName)
		{
			return default;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x11BD334", Offset = "0x11BD334", VA = "0x11BD334")]
		public static void AddTraceListener(string source, TraceListener listener)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x11BD6A4", Offset = "0x11BD6A4", VA = "0x11BD6A4")]
		public static void RemoveTraceListener(string source, string name)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x11BDB38", Offset = "0x11BDB38", VA = "0x11BDB38")]
		internal static TraceListener[] TraceListeners(string source)
		{
			return null;
		}
	}
}
