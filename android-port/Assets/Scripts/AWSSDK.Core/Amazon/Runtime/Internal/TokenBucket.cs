using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x20001A4")]
	public class TokenBucket
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25E60", Offset = "0x25E60")]
		private struct _003CTryAcquireTokenAsync_003Ed__55 : IAsyncStateMachine
		{
			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TokenBucket _003C_003E4__this;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double amount;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool failFast;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003Cattempt_003E5__2;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000D27")]
			[Address(RVA = "0x1296BA4", Offset = "0x1296BA4", VA = "0x1296BA4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000D28")]
			[Address(RVA = "0x1296E38", Offset = "0x1296E38", VA = "0x1296E38", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25E70", Offset = "0x25E70")]
		private struct _003CWaitForTokenAsync_003Ed__67 : IAsyncStateMachine
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int delayMs;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x1296E94", Offset = "0x1296E94", VA = "0x1296E94", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x1297060", Offset = "0x1297060", VA = "0x1297060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000649")]
		private const int MaxAttempts = 15;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object _bucketLock;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly double _minFillRate;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly double _minCapacity;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly double _beta;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly double _scaleConstant;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly double _smooth;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTime _epoch;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27508", Offset = "0x27508")]
		private double? FillRate__BackingField;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27518", Offset = "0x27518")]
		private double? MaxCapacity__BackingField;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27528", Offset = "0x27528")]
		private double CurrentCapacity__BackingField;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27538", Offset = "0x27538")]
		private double? LastTimestamp__BackingField;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27548", Offset = "0x27548")]
		private double MeasuredTxRate__BackingField;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27558", Offset = "0x27558")]
		private double LastTxRateBucket__BackingField;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27568", Offset = "0x27568")]
		private long RequestCount__BackingField;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27578", Offset = "0x27578")]
		private double LastMaxRate__BackingField;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27588", Offset = "0x27588")]
		private double LastThrottleTime__BackingField;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27598", Offset = "0x27598")]
		private double TimeWindow__BackingField;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x275A8", Offset = "0x275A8")]
		private bool Enabled__BackingField;

		[Token(Token = "0x1700034E")]
		protected double? FillRate
		{
			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0x127D0B0", Offset = "0x127D0B0", VA = "0x127D0B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AD24", Offset = "0x2AD24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x127D0BC", Offset = "0x127D0BC", VA = "0x127D0BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AD34", Offset = "0x2AD34")]
			set
			{
			}
		}

		[Token(Token = "0x1700034F")]
		protected double? MaxCapacity
		{
			[Token(Token = "0x6000D00")]
			[Address(RVA = "0x127D0C4", Offset = "0x127D0C4", VA = "0x127D0C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AD44", Offset = "0x2AD44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x127D0D0", Offset = "0x127D0D0", VA = "0x127D0D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AD54", Offset = "0x2AD54")]
			set
			{
			}
		}

		[Token(Token = "0x17000350")]
		protected double CurrentCapacity
		{
			[Token(Token = "0x6000D02")]
			[Address(RVA = "0x127D0D8", Offset = "0x127D0D8", VA = "0x127D0D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AD64", Offset = "0x2AD64")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x127D0E0", Offset = "0x127D0E0", VA = "0x127D0E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AD74", Offset = "0x2AD74")]
			set
			{
			}
		}

		[Token(Token = "0x17000351")]
		protected double? LastTimestamp
		{
			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x127D0E8", Offset = "0x127D0E8", VA = "0x127D0E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AD84", Offset = "0x2AD84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D05")]
			[Address(RVA = "0x127D0F4", Offset = "0x127D0F4", VA = "0x127D0F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AD94", Offset = "0x2AD94")]
			set
			{
			}
		}

		[Token(Token = "0x17000352")]
		protected double MeasuredTxRate
		{
			[Token(Token = "0x6000D06")]
			[Address(RVA = "0x127D0FC", Offset = "0x127D0FC", VA = "0x127D0FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2ADA4", Offset = "0x2ADA4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D07")]
			[Address(RVA = "0x127D104", Offset = "0x127D104", VA = "0x127D104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2ADB4", Offset = "0x2ADB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000353")]
		protected double LastTxRateBucket
		{
			[Token(Token = "0x6000D08")]
			[Address(RVA = "0x127D10C", Offset = "0x127D10C", VA = "0x127D10C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2ADC4", Offset = "0x2ADC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D09")]
			[Address(RVA = "0x127D114", Offset = "0x127D114", VA = "0x127D114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2ADD4", Offset = "0x2ADD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000354")]
		protected long RequestCount
		{
			[Token(Token = "0x6000D0A")]
			[Address(RVA = "0x127D11C", Offset = "0x127D11C", VA = "0x127D11C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2ADE4", Offset = "0x2ADE4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D0B")]
			[Address(RVA = "0x127D124", Offset = "0x127D124", VA = "0x127D124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2ADF4", Offset = "0x2ADF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000355")]
		protected double LastMaxRate
		{
			[Token(Token = "0x6000D0C")]
			[Address(RVA = "0x127D12C", Offset = "0x127D12C", VA = "0x127D12C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AE04", Offset = "0x2AE04")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0x127D134", Offset = "0x127D134", VA = "0x127D134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AE14", Offset = "0x2AE14")]
			set
			{
			}
		}

		[Token(Token = "0x17000356")]
		protected double LastThrottleTime
		{
			[Token(Token = "0x6000D0E")]
			[Address(RVA = "0x127D13C", Offset = "0x127D13C", VA = "0x127D13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AE24", Offset = "0x2AE24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D0F")]
			[Address(RVA = "0x127D144", Offset = "0x127D144", VA = "0x127D144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AE34", Offset = "0x2AE34")]
			set
			{
			}
		}

		[Token(Token = "0x17000357")]
		protected double TimeWindow
		{
			[Token(Token = "0x6000D10")]
			[Address(RVA = "0x127D14C", Offset = "0x127D14C", VA = "0x127D14C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AE44", Offset = "0x2AE44")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D11")]
			[Address(RVA = "0x127D154", Offset = "0x127D154", VA = "0x127D154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AE54", Offset = "0x2AE54")]
			set
			{
			}
		}

		[Token(Token = "0x17000358")]
		protected bool Enabled
		{
			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x127D15C", Offset = "0x127D15C", VA = "0x127D15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AE64", Offset = "0x2AE64")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x127D164", Offset = "0x127D164", VA = "0x127D164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AE74", Offset = "0x2AE74")]
			set
			{
			}
		}

		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x127D16C", Offset = "0x127D16C", VA = "0x127D16C")]
		public TokenBucket()
		{
		}

		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x127D194", Offset = "0x127D194", VA = "0x127D194")]
		public TokenBucket(double minFillRate, double minCapacity, double beta, double scaleConstant, double smooth)
		{
		}

		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x127D2A4", Offset = "0x127D2A4", VA = "0x127D2A4")]
		public bool TryAcquireToken(double amount, bool failFast)
		{
			return default;
		}

		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x127D6E8", Offset = "0x127D6E8", VA = "0x127D6E8")]
		public Task<bool> TryAcquireTokenAsync(double amount, bool failFast, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x127D3A4", Offset = "0x127D3A4", VA = "0x127D3A4")]
		private bool? SetupAcquireToken(double amount)
		{
			return null;
		}

		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x127D548", Offset = "0x127D548", VA = "0x127D548")]
		private int ObtainCapacity(double amount)
		{
			return default;
		}

		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x127D824", Offset = "0x127D824", VA = "0x127D824")]
		public void UpdateClientSendingRate(bool isThrottlingError)
		{
		}

		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x127DA8C", Offset = "0x127DA8C", VA = "0x127DA8C", Slot = "4")]
		protected virtual void TokenBucketRefill()
		{
		}

		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x127DBE0", Offset = "0x127DBE0", VA = "0x127DBE0", Slot = "5")]
		protected virtual void TokenBucketUpdateRate(double newRps)
		{
		}

		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x127DD14", Offset = "0x127DD14", VA = "0x127DD14", Slot = "6")]
		protected virtual void UpdateMeasuredRate()
		{
		}

		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x127DDF4", Offset = "0x127DDF4", VA = "0x127DDF4", Slot = "7")]
		protected virtual void CalculateTimeWindow()
		{
		}

		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x127DE98", Offset = "0x127DE98", VA = "0x127DE98", Slot = "8")]
		protected virtual double CUBICSuccess(double timestamp)
		{
			return default;
		}

		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x127DF38", Offset = "0x127DF38", VA = "0x127DF38", Slot = "9")]
		protected virtual double CUBICThrottle(double rateToUse)
		{
			return default;
		}

		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x127DF44", Offset = "0x127DF44", VA = "0x127DF44", Slot = "10")]
		protected virtual int CalculateWait(double amount, double currentCapacity, double fillRate)
		{
			return default;
		}

		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x127DF74", Offset = "0x127DF74", VA = "0x127DF74", Slot = "11")]
		protected virtual void WaitForToken(int delayMs)
		{
		}

		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x127DFE0", Offset = "0x127DFE0", VA = "0x127DFE0", Slot = "12")]
		protected virtual Task WaitForTokenAsync(int delayMs, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x127E0C4", Offset = "0x127E0C4", VA = "0x127E0C4", Slot = "13")]
		protected virtual double GetTimestamp()
		{
			return default;
		}

		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x127E11C", Offset = "0x127E11C", VA = "0x127E11C")]
		private static double GetTimeInSeconds()
		{
			return default;
		}
	}
}
