using System;
using Kilt.Collections;

namespace Kilt
{
	public class DelayedFunctionUtils : Singleton<DelayedFunctionUtils>
	{
		private static ArrayDict<float, FunctionAndParams> m_functionsToCallOverTime;

		private static DateTime _lastCheckedTime;

		public static ArrayDict<float, FunctionAndParams> FunctionsToCallOverTime => null;

		static DelayedFunctionUtils()
		{
		}

		private static void Init()
		{
		}

		private static void EditorUpdate()
		{
		}

		private static void RegisterInCallerOverTime(FunctionAndParams p_struct, float p_time)
		{
		}

		private static void ProcessStaticTime()
		{
		}

		protected virtual void Update()
		{
		}

		public static void CallFunction(Delegate p_functionPointer, float p_time, bool p_tryCreateInstance = true)
		{
		}

		public static void CallFunction(Delegate p_functionPointer, object[] p_params, float p_time, bool p_tryCreateInstance = true)
		{
		}

		private static void TryCreateInstance()
		{
		}
	}
}
