using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001D9")]
	public class RequestMetrics : IRequestMetrics
	{
		[Serializable]
		[Token(Token = "0x20001DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25F10", Offset = "0x25F10")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000732")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000733")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Metric, string> _003C_003E9__33_0;

			[Token(Token = "0x6000EA1")]
			[Address(RVA = "0x1294ADC", Offset = "0x1294ADC", VA = "0x1294ADC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000EA2")]
			[Address(RVA = "0x1294AE4", Offset = "0x1294AE4", VA = "0x1294AE4")]
			internal string _003CGetErrors_003Eb__33_0(Metric k)
			{
				return null;
			}
		}

		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x10")]
		private object metricsLock;

		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x18")]
		private Stopwatch stopWatch;

		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<Metric, Timing> inFlightTimings;

		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x28")]
		private List<MetricError> errors;

		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27988", Offset = "0x27988")]
		private Dictionary<Metric, List<object>> Properties__BackingField;

		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27998", Offset = "0x27998")]
		private Dictionary<Metric, List<IMetricsTiming>> Timings__BackingField;

		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x279A8", Offset = "0x279A8")]
		private Dictionary<Metric, long> Counters__BackingField;

		[Token(Token = "0x4000731")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x279B8", Offset = "0x279B8")]
		private bool IsEnabled__BackingField;

		[Token(Token = "0x170003B0")]
		private long CurrentTime
		{
			[Token(Token = "0x6000E89")]
			[Address(RVA = "0x125D0FC", Offset = "0x125D0FC", VA = "0x125D0FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003B1")]
		public Dictionary<Metric, List<object>> Properties
		{
			[Token(Token = "0x6000E8F")]
			[Address(RVA = "0x125D67C", Offset = "0x125D67C", VA = "0x125D67C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B754", Offset = "0x2B754")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E90")]
			[Address(RVA = "0x125D684", Offset = "0x125D684", VA = "0x125D684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B764", Offset = "0x2B764")]
			set
			{
			}
		}

		[Token(Token = "0x170003B2")]
		public Dictionary<Metric, List<IMetricsTiming>> Timings
		{
			[Token(Token = "0x6000E91")]
			[Address(RVA = "0x125D68C", Offset = "0x125D68C", VA = "0x125D68C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B774", Offset = "0x2B774")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E92")]
			[Address(RVA = "0x125D694", Offset = "0x125D694", VA = "0x125D694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B784", Offset = "0x2B784")]
			set
			{
			}
		}

		[Token(Token = "0x170003B3")]
		public Dictionary<Metric, long> Counters
		{
			[Token(Token = "0x6000E93")]
			[Address(RVA = "0x125D69C", Offset = "0x125D69C", VA = "0x125D69C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B794", Offset = "0x2B794")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E94")]
			[Address(RVA = "0x125D6A4", Offset = "0x125D6A4", VA = "0x125D6A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B7A4", Offset = "0x2B7A4")]
			set
			{
			}
		}

		[Token(Token = "0x170003B4")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000E95")]
			[Address(RVA = "0x125D6AC", Offset = "0x125D6AC", VA = "0x125D6AC", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B7B4", Offset = "0x2B7B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000E96")]
			[Address(RVA = "0x125D6B4", Offset = "0x125D6B4", VA = "0x125D6B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B7C4", Offset = "0x2B7C4")]
			internal set
			{
			}
		}

		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x125D174", Offset = "0x125D174", VA = "0x125D174")]
		private void LogError_Locked(Metric metric, string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x125D220", Offset = "0x125D220", VA = "0x125D220")]
		private static void Log(StringBuilder builder, Metric metric, object metricValue)
		{
		}

		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x125D4F4", Offset = "0x125D4F4", VA = "0x125D4F4")]
		private static void Log(StringBuilder builder, Metric metric, List<object> metricValues)
		{
		}

		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x125D2DC", Offset = "0x125D2DC", VA = "0x125D2DC")]
		private static void LogHelper(StringBuilder builder, Metric metric, params object[] metricValues)
		{
		}

		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x125D614", Offset = "0x125D614", VA = "0x125D614")]
		private static string ObjectToString(object data)
		{
			return null;
		}

		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x125C6F0", Offset = "0x125C6F0", VA = "0x125C6F0")]
		public RequestMetrics()
		{
		}

		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x123EBB0", Offset = "0x123EBB0", VA = "0x123EBB0")]
		public TimingEvent StartEvent(Metric metric)
		{
			return null;
		}

		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x123EE84", Offset = "0x123EE84", VA = "0x123EE84")]
		public Timing StopEvent(Metric metric)
		{
			return null;
		}

		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x123E9C4", Offset = "0x123E9C4", VA = "0x123E9C4")]
		public void AddProperty(Metric metric, object property)
		{
		}

		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x125D6BC", Offset = "0x125D6BC", VA = "0x125D6BC")]
		public void SetCounter(Metric metric, long value)
		{
		}

		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x125D7E4", Offset = "0x125D7E4", VA = "0x125D7E4")]
		public void IncrementCounter(Metric metric)
		{
		}

		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x124B850", Offset = "0x124B850", VA = "0x124B850")]
		public string GetErrors()
		{
			return null;
		}

		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x125D958", Offset = "0x125D958", VA = "0x125D958", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x125E56C", Offset = "0x125E56C", VA = "0x125E56C", Slot = "8")]
		public string ToJSON()
		{
			return null;
		}
	}
}
