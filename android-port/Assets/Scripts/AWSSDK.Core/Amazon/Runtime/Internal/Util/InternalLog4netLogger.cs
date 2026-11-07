using System;
using System.Reflection;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal.Util
{
	internal class InternalLog4netLogger : InternalLogger
	{
		private enum LoadState
		{
			Uninitialized = 0,
			Failed = 1,
			Loading = 2,
			Success = 3
		}

		private static LoadState loadState;

		private static readonly object LOCK;

		private static Type logMangerType;

		private static ITypeInfo logMangerTypeInfo;

		private static MethodInfo getLoggerWithTypeMethod;

		private static Type logType;

		private static ITypeInfo logTypeInfo;

		private static MethodInfo logMethod;

		private static Type levelType;

		private static ITypeInfo levelTypeInfo;

		private static object debugLevelPropertyValue;

		private static object infoLevelPropertyValue;

		private static object errorLevelPropertyValue;

		private static MethodInfo isEnabledForMethod;

		private static Type systemStringFormatType;

		private static Type loggerType;

		private object internalLogger;

		private bool? isErrorEnabled;

		private bool? isDebugEnabled;

		private bool? isInfoEnabled;

		public override bool IsErrorEnabled => false;

		public override bool IsDebugEnabled => false;

		public override bool IsInfoEnabled => false;

		private static void loadStatics()
		{
		}

		public InternalLog4netLogger(Type declaringType)
			: base(null)
		{
		}

		public override void Flush()
		{
		}

		public override void Error(Exception exception, string messageFormat, params object[] args)
		{
		}

		public override void Debug(Exception exception, string messageFormat, params object[] args)
		{
		}

		public override void DebugFormat(string message, params object[] arguments)
		{
		}

		public override void InfoFormat(string message, params object[] arguments)
		{
		}
	}
}
