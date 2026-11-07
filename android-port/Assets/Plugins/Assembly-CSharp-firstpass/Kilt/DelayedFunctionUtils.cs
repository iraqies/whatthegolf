using System;
using Il2CppDummyDll;
using Kilt.Collections;

namespace Kilt
{
	[Token(Token = "0x2000086")]
	public class DelayedFunctionUtils : Singleton<DelayedFunctionUtils>
	{
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x0")]
		private static ArrayDict<float, FunctionAndParams> m_functionsToCallOverTime;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x8")]
		private static DateTime _lastCheckedTime;

		[Token(Token = "0x17000045")]
		public static ArrayDict<float, FunctionAndParams> FunctionsToCallOverTime
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x13645DC", Offset = "0x13645DC", VA = "0x13645DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x13646C8", Offset = "0x13646C8", VA = "0x13646C8")]
		static DelayedFunctionUtils()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x13647A0", Offset = "0x13647A0", VA = "0x13647A0")]
		private static void Init()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1364844", Offset = "0x1364844", VA = "0x1364844")]
		private static void EditorUpdate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1364CA4", Offset = "0x1364CA4", VA = "0x1364CA4")]
		private static void RegisterInCallerOverTime(FunctionAndParams p_struct, float p_time)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x136489C", Offset = "0x136489C", VA = "0x136489C")]
		private static void ProcessStaticTime()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1364D6C", Offset = "0x1364D6C", VA = "0x1364D6C", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1364DDC", Offset = "0x1364DDC", VA = "0x1364DDC")]
		public static void CallFunction(Delegate p_functionPointer, float p_time, bool p_tryCreateInstance = true)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1364E78", Offset = "0x1364E78", VA = "0x1364E78")]
		public static void CallFunction(Delegate p_functionPointer, object[] p_params, float p_time, bool p_tryCreateInstance = true)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1365028", Offset = "0x1365028", VA = "0x1365028")]
		private static void TryCreateInstance()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x13650C8", Offset = "0x13650C8", VA = "0x13650C8")]
		public DelayedFunctionUtils()
		{
		}
	}
}
