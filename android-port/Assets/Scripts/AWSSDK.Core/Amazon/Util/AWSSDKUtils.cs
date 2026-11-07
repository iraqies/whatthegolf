using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x200004D")]
	public static class AWSSDKUtils
	{
		[Token(Token = "0x200004E")]
		private class IsSetMethodsCacheKey
		{
			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly Type Type;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly string PropertyName;

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x12865E8", Offset = "0x12865E8", VA = "0x12865E8")]
			public IsSetMethodsCacheKey(Type type, string propertyName)
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1286620", Offset = "0x1286620", VA = "0x1286620", Slot = "0")]
			public override bool Equals(object other)
			{
				return default;
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1286724", Offset = "0x1286724", VA = "0x1286724", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1286774", Offset = "0x1286774", VA = "0x1286774", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25754", Offset = "0x25754")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> _003C_003E9__38_0;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, string> _003C_003E9__38_1;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<string, string> _003C_003E9__38_2;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<string, string> _003C_003E9__40_1;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<IsSetMethodsCacheKey, MethodInfo> _003C_003E9__105_0;

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1285560", Offset = "0x1285560", VA = "0x1285560")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1285568", Offset = "0x1285568", VA = "0x1285568")]
			internal string _003CCanonicalizeResourcePath_003Eb__38_0(string segment)
			{
				return null;
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1285618", Offset = "0x1285618", VA = "0x1285618")]
			internal string _003CCanonicalizeResourcePath_003Eb__38_1(string segment)
			{
				return null;
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x1285688", Offset = "0x1285688", VA = "0x1285688")]
			internal string _003CCanonicalizeResourcePath_003Eb__38_2(string segment)
			{
				return null;
			}

			[Token(Token = "0x6000333")]
			[Address(RVA = "0x12856F8", Offset = "0x12856F8", VA = "0x12856F8")]
			internal string _003CJoinResourcePathSegments_003Eb__40_1(string segment)
			{
				return null;
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1285768", Offset = "0x1285768", VA = "0x1285768")]
			internal MethodInfo _003CIsPropertySet_003Eb__105_0(IsSetMethodsCacheKey k)
			{
				return null;
			}
		}

		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25764", Offset = "0x25764")]
		private sealed class _003C_003Ec__DisplayClass40_0
		{
			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool path;

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x12858E0", Offset = "0x12858E0", VA = "0x12858E0")]
			public _003C_003Ec__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x12858E8", Offset = "0x12858E8", VA = "0x12858E8")]
			internal string _003CJoinResourcePathSegments_003Eb__0(string segment)
			{
				return null;
			}
		}

		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25774", Offset = "0x25774")]
		private sealed class _003C_003Ec__DisplayClass54_0<T> where T : EventArgs
		{
			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public object sender;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T args;

			[Token(Token = "0x6000337")]
			public _003C_003Ec__DisplayClass54_0()
			{
			}
		}

		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25784", Offset = "0x25784")]
		private sealed class _003C_003Ec__DisplayClass54_1<T> where T : EventArgs
		{
			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public EventHandler<T> eventHandler;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass54_0<T> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6000338")]
			public _003C_003Ec__DisplayClass54_1()
			{
			}

			[Token(Token = "0x6000339")]
			internal void _003CInvokeInBackground_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25794", Offset = "0x25794")]
		private sealed class _003C_003Ec__DisplayClass94_0
		{
			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Uri uri;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HttpClient client;

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x1285964", Offset = "0x1285964", VA = "0x1285964")]
			public _003C_003Ec__DisplayClass94_0()
			{
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x128596C", Offset = "0x128596C", VA = "0x128596C")]
			internal Task<string> _003CDownloadStringContent_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x257A4", Offset = "0x257A4")]
		private sealed class _003C_003Ec__DisplayClass95_0
		{
			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string requestType;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Uri uri;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string content;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HttpClient client;

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1285990", Offset = "0x1285990", VA = "0x1285990")]
			public _003C_003Ec__DisplayClass95_0()
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x1285998", Offset = "0x1285998", VA = "0x1285998")]
			internal Task<HttpResponseMessage> _003CExecuteHttpRequest_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x2000055")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x257B4", Offset = "0x257B4")]
		private sealed class _003C_003Ec__DisplayClass95_1
		{
			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HttpResponseMessage response;

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x1285A98", Offset = "0x1285A98", VA = "0x1285A98")]
			public _003C_003Ec__DisplayClass95_1()
			{
			}

			[Token(Token = "0x600033F")]
			[Address(RVA = "0x1285AA0", Offset = "0x1285AA0", VA = "0x1285AA0")]
			internal Task<string> _003CExecuteHttpRequest_003Eb__1()
			{
				return null;
			}
		}

		[Token(Token = "0x2000056")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x257C4", Offset = "0x257C4")]
		private sealed class _003C_003Ec__DisplayClass103_0
		{
			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Process process;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string standardOutput;

			[Token(Token = "0x6000340")]
			[Address(RVA = "0x1285834", Offset = "0x1285834", VA = "0x1285834")]
			public _003C_003Ec__DisplayClass103_0()
			{
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0x128583C", Offset = "0x128583C", VA = "0x128583C")]
			internal void _003CRunProcess_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x257D4", Offset = "0x257D4")]
		private sealed class _003C_003Ec__DisplayClass104_0
		{
			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TaskCompletionSource<object> tcs;

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x1285880", Offset = "0x1285880", VA = "0x1285880")]
			public _003C_003Ec__DisplayClass104_0()
			{
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x1285888", Offset = "0x1285888", VA = "0x1285888")]
			internal void _003CRunProcessAsync_003Eb__0(object s, EventArgs ea)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x257E4", Offset = "0x257E4")]
		private struct _003CRunProcessAsync_003Ed__104 : IAsyncStateMachine
		{
			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<ProcessExecutionResult> _003C_003Et__builder;

			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProcessStartInfo processStartInfo;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Process _003Cprocess_003E5__2;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Task<string> _003CstandardErrorTask_003E5__3;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Task<string> _003CstandardOutputTask_003E5__4;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x1285AC8", Offset = "0x1285AC8", VA = "0x1285AC8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0x128658C", Offset = "0x128658C", VA = "0x128658C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000175")]
		internal const string DefaultRegion = "us-east-1";

		[Token(Token = "0x4000176")]
		internal const string DefaultGovRegion = "us-gov-west-1";

		[Token(Token = "0x4000177")]
		private const char WindowsDirectorySeparatorChar = '\\';

		[Token(Token = "0x4000178")]
		private const char WindowsAltDirectorySeparatorChar = '/';

		[Token(Token = "0x4000179")]
		private const char WindowsVolumeSeparatorChar = ':';

		[Token(Token = "0x400017A")]
		private const char SlashChar = '/';

		[Token(Token = "0x400017B")]
		private const string Slash = "/";

		[Token(Token = "0x400017C")]
		private const string EncodedSlash = "%2F";

		[Token(Token = "0x400017D")]
		internal const int DefaultMaxRetry = 3;

		[Token(Token = "0x400017E")]
		private const int DefaultConnectionLimit = 50;

		[Token(Token = "0x400017F")]
		private const int DefaultMaxIdleTime = 50000;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DateTime EPOCH_START;

		[Token(Token = "0x4000181")]
		public const int DefaultBufferSize = 8192;

		[Token(Token = "0x4000182")]
		public const long DefaultProgressUpdateInterval = 102400L;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static Dictionary<int, string> RFCEncodingSchemes;

		[Token(Token = "0x4000184")]
		internal const string S3Accelerate = "s3-accelerate";

		[Token(Token = "0x4000185")]
		internal const string S3Control = "s3-control";

		[Token(Token = "0x4000186")]
		private const int DefaultMarshallerVersion = 1;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string _userAgent;

		[Token(Token = "0x4000188")]
		public const string UserAgentHeader = "User-Agent";

		[Token(Token = "0x4000189")]
		public const string ValidUrlCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";

		[Token(Token = "0x400018A")]
		public const string ValidUrlCharactersRFC1738 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.";

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string ValidPathCharacters;

		[Token(Token = "0x400018C")]
		public const string UrlEncodedContent = "application/x-www-form-urlencoded; charset=utf-8";

		[Token(Token = "0x400018D")]
		public const string GMTDateFormat = "ddd, dd MMM yyyy HH:mm:ss \\G\\M\\T";

		[Token(Token = "0x400018E")]
		public const string ISO8601DateFormat = "yyyy-MM-dd\\THH:mm:ss.fff\\Z";

		[Token(Token = "0x400018F")]
		public const string ISO8601DateFormatNoMS = "yyyy-MM-dd\\THH:mm:ss\\Z";

		[Token(Token = "0x4000190")]
		public const string ISO8601BasicDateTimeFormat = "yyyyMMddTHHmmssZ";

		[Token(Token = "0x4000191")]
		public const string ISO8601BasicDateFormat = "yyyyMMdd";

		[Token(Token = "0x4000192")]
		public const string RFC822DateFormat = "ddd, dd MMM yyyy HH:mm:ss \\G\\M\\T";

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static BackgroundInvoker _dispatcher;

		[Token(Token = "0x4000194")]
		private const int MaxIsSetMethodsCacheSize = 50;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static LruCache<IsSetMethodsCacheKey, MethodInfo> IsSetMethodsCache;

		[Token(Token = "0x170000A7")]
		private static BackgroundInvoker Dispatcher
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x11C4680", Offset = "0x11C4680", VA = "0x11C4680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public static string FormattedCurrentTimestampGMT
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x11C4EE4", Offset = "0x11C4EE4", VA = "0x11C4EE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public static string FormattedCurrentTimestampISO8601
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x11C4FAC", Offset = "0x11C4FAC", VA = "0x11C4FAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		public static string FormattedCurrentTimestampRFC822
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x11B0DE0", Offset = "0x11B0DE0", VA = "0x11B0DE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C43C", Offset = "0x2C43C")]
		public static DateTime CorrectedUtcNow
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x11BF910", Offset = "0x11BF910", VA = "0x11BF910")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x11C2E2C", Offset = "0x11C2E2C", VA = "0x11C2E2C")]
		private static string DetermineValidPathCharacters()
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x11C2F90", Offset = "0x11C2F90", VA = "0x11C2F90")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x11C30C0", Offset = "0x11C30C0", VA = "0x11C30C0")]
		private static bool IsPathSeparator(char ch)
		{
			return default;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x11C30E0", Offset = "0x11C30E0", VA = "0x11C30E0")]
		internal static string CalculateStringToSignV2(ParameterCollection parameterCollection, string serviceUrl)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x11BB6EC", Offset = "0x11BB6EC", VA = "0x11BB6EC")]
		internal static string GetParametersAsString(IRequest request)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x11C352C", Offset = "0x11C352C", VA = "0x11C352C")]
		internal static string GetParametersAsString(ParameterCollection parameterCollection)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x11C3804", Offset = "0x11C3804", VA = "0x11C3804")]
		public static string CanonicalizeResourcePath(Uri endpoint, string resourcePath)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x11C3898", Offset = "0x11C3898", VA = "0x11C3898")]
		public static string CanonicalizeResourcePath(Uri endpoint, string resourcePath, bool detectPreEncode)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x11B9F08", Offset = "0x11B9F08", VA = "0x11B9F08")]
		public static string CanonicalizeResourcePath(Uri endpoint, string resourcePath, bool detectPreEncode, IDictionary<string, string> pathResources, int marshallerVersion)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x11C3940", Offset = "0x11C3940", VA = "0x11C3940")]
		public static IEnumerable<string> SplitResourcePathIntoSegments(string resourcePath, IDictionary<string, string> pathResources)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x11C3D00", Offset = "0x11C3D00", VA = "0x11C3D00")]
		public static string JoinResourcePathSegments(IEnumerable<string> pathSegments, bool path)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x11B297C", Offset = "0x11B297C", VA = "0x11B297C")]
		public static string ResolveResourcePath(string resourcePath, IDictionary<string, string> pathResources)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x11C3F18", Offset = "0x11C3F18", VA = "0x11C3F18")]
		public static string Join(List<string> strings)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x11B959C", Offset = "0x11B959C", VA = "0x11B959C")]
		public static string DetermineRegion(string url)
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x11B9910", Offset = "0x11B9910", VA = "0x11B9910")]
		public static string DetermineService(string url)
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x11C40F8", Offset = "0x11C40F8", VA = "0x11C40F8")]
		public static DateTime ConvertFromUnixEpochSeconds(int seconds)
		{
			return default;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x11C41B8", Offset = "0x11C41B8", VA = "0x11C41B8")]
		public static int ConvertToUnixEpochSeconds(DateTime dateTime)
		{
			return default;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x11C433C", Offset = "0x11C433C", VA = "0x11C433C")]
		public static string ConvertToUnixEpochSecondsString(DateTime dateTime)
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x11C4460", Offset = "0x11C4460", VA = "0x11C4460")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x28270", Offset = "0x28270")]
		public static double ConvertToUnixEpochMilliSeconds(DateTime dateTime)
		{
			return default;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x11C44D8", Offset = "0x11C44D8", VA = "0x11C44D8")]
		public static double ConvertToUnixEpochSecondsDouble(DateTime dateTime)
		{
			return default;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x11C4294", Offset = "0x11C4294", VA = "0x11C4294")]
		public static TimeSpan GetTimeSpanInTicks(DateTime dateTime)
		{
			return default;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x11C45C8", Offset = "0x11C45C8", VA = "0x11C45C8")]
		public static long ConvertDateTimetoMilliseconds(DateTime dateTime)
		{
			return default;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x11C4660", Offset = "0x11C4660", VA = "0x11C4660")]
		public static long ConvertTimeSpanToMilliseconds(TimeSpan timeSpan)
		{
			return default;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x11B86B4", Offset = "0x11B86B4", VA = "0x11B86B4")]
		public static string ToHex(byte[] data, bool lowercase)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		public static void InvokeInBackground<T>(EventHandler<T> handler, T args, object sender) where T : EventArgs
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x11C4884", Offset = "0x11C4884", VA = "0x11C4884")]
		public static Dictionary<string, string> ParseQueryParameters(string url)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x11C4A84", Offset = "0x11C4A84", VA = "0x11C4A84")]
		internal static bool AreEqual(object[] itemsA, object[] itemsB)
		{
			return default;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x11C4BC0", Offset = "0x11C4BC0", VA = "0x11C4BC0")]
		internal static bool AreEqual(object a, object b)
		{
			return default;
		}

		[Token(Token = "0x60002FF")]
		internal static bool DictionariesAreEqual<K, V>(Dictionary<K, V> a, Dictionary<K, V> b)
		{
			return default;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x11C4BF8", Offset = "0x11C4BF8", VA = "0x11C4BF8")]
		public static MemoryStream GenerateMemoryStreamFromString(string s)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x11C4CD4", Offset = "0x11C4CD4", VA = "0x11C4CD4")]
		public static void CopyStream(Stream source, Stream destination)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x11C4D60", Offset = "0x11C4D60", VA = "0x11C4D60")]
		public static void CopyStream(Stream source, Stream destination, int bufferSize)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x11C5064", Offset = "0x11C5064", VA = "0x11C5064")]
		public static string GetFormattedTimestampISO8601(int minutesFromNow)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x11C523C", Offset = "0x11C523C", VA = "0x11C523C")]
		internal static string GetFormattedTimestampISO8601(IClientConfig config)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x11C50F0", Offset = "0x11C50F0", VA = "0x11C50F0")]
		private static string GetFormattedTimestampISO8601(DateTime dateTime)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x11C5328", Offset = "0x11C5328", VA = "0x11C5328")]
		public static string GetFormattedTimestampRFC822(int minutesFromNow)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x11C5410", Offset = "0x11C5410", VA = "0x11C5410")]
		public static bool IsAbsolutePath(string path)
		{
			return default;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x11C54EC", Offset = "0x11C54EC", VA = "0x11C54EC")]
		private static bool IsWindows()
		{
			return default;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x11C558C", Offset = "0x11C558C", VA = "0x11C558C")]
		private static bool IsPartiallyQualifiedForWindows(string path)
		{
			return default;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x11C5760", Offset = "0x11C5760", VA = "0x11C5760")]
		private static bool IsWindowsDirectorySeparator(char c)
		{
			return default;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x11C5774", Offset = "0x11C5774", VA = "0x11C5774")]
		private static bool IsValidWindowsDriveChar(char value)
		{
			return default;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x11B2A18", Offset = "0x11B2A18", VA = "0x11B2A18")]
		public static string UrlEncode(string data, bool path)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x11C5788", Offset = "0x11C5788", VA = "0x11C5788")]
		public static string UrlEncode(int rfcNumber, string data, bool path)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x11C5A8C", Offset = "0x11C5A8C", VA = "0x11C5A8C")]
		internal static string UrlEncodeSlash(string data)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x11C5B1C", Offset = "0x11C5B1C", VA = "0x11C5B1C")]
		public static string ProtectEncodedSlashUrlEncode(string data, bool path)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x11C5E2C", Offset = "0x11C5E2C", VA = "0x11C5E2C")]
		public static void Sleep(TimeSpan ts)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x11C5EC8", Offset = "0x11C5EC8", VA = "0x11C5EC8")]
		public static string BytesToHexString(byte[] value)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x11C5F8C", Offset = "0x11C5F8C", VA = "0x11C5F8C")]
		public static byte[] HexStringToBytes(string hex)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x11C6114", Offset = "0x11C6114", VA = "0x11C6114")]
		public static bool HasBidiControlCharacters(string input)
		{
			return default;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x11C620C", Offset = "0x11C620C", VA = "0x11C620C")]
		private static bool IsBidiControlChar(char c)
		{
			return default;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x11C6238", Offset = "0x11C6238", VA = "0x11C6238")]
		public static string DownloadStringContent(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x11C6528", Offset = "0x11C6528", VA = "0x11C6528")]
		public static string DownloadStringContent(Uri uri, TimeSpan timeout)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x11C245C", Offset = "0x11C245C", VA = "0x11C245C")]
		public static string DownloadStringContent(Uri uri, IWebProxy proxy)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x11C62E4", Offset = "0x11C62E4", VA = "0x11C62E4")]
		public static string DownloadStringContent(Uri uri, TimeSpan timeout, IWebProxy proxy)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x11C6A34", Offset = "0x11C6A34", VA = "0x11C6A34")]
		public static string ExecuteHttpRequest(Uri uri, string requestType, string content, TimeSpan timeout, IWebProxy proxy, IDictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x11C65B4", Offset = "0x11C65B4", VA = "0x11C65B4")]
		private static HttpClient CreateClient(Uri uri, TimeSpan timeout, IWebProxy proxy, IDictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x11C6F80", Offset = "0x11C6F80", VA = "0x11C6F80")]
		public static Stream OpenStream(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x11C6FFC", Offset = "0x11C6FFC", VA = "0x11C6FFC")]
		public static Stream OpenStream(Uri uri, IWebProxy proxy)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x11BABCC", Offset = "0x11BABCC", VA = "0x11BABCC")]
		public static string CompressSpaces(string data)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x11C71FC", Offset = "0x11C71FC", VA = "0x11C71FC")]
		public static ProcessExecutionResult RunProcess(ProcessStartInfo processStartInfo)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x11C7884", Offset = "0x11C7884", VA = "0x11C7884")]
		public static Task<ProcessExecutionResult> RunProcessAsync(ProcessStartInfo processStartInfo)
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x11C7994", Offset = "0x11C7994", VA = "0x11C7994")]
		public static bool IsPropertySet(object awsServiceObject, string propertyName)
		{
			return default;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x11C7E1C", Offset = "0x11C7E1C", VA = "0x11C7E1C")]
		public static void ForceCanonicalPathAndQuery(Uri uri)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x11C7E20", Offset = "0x11C7E20", VA = "0x11C7E20")]
		public static void PreserveStackTrace(Exception exception)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x11C7E24", Offset = "0x11C7E24", VA = "0x11C7E24")]
		internal static int GetConnectionLimit(int? clientConfigValue)
		{
			return default;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x11C2B30", Offset = "0x11C2B30", VA = "0x11C2B30")]
		public static void Sleep(int ms)
		{
		}
	}
}
