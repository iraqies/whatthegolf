using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000044")]
	public class LoggingConfig
	{
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int DefaultLogResponsesSizeLimit;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x10")]
		private LoggingOptions _logTo;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26268", Offset = "0x26268")]
		private ResponseLoggingOption LogResponses__BackingField;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26278", Offset = "0x26278")]
		private int LogResponsesSizeLimit__BackingField;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26288", Offset = "0x26288")]
		private bool LogMetrics__BackingField;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26298", Offset = "0x26298")]
		private LogMetricsFormatOption LogMetricsFormat__BackingField;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x262A8", Offset = "0x262A8")]
		private IMetricsFormatter LogMetricsCustomFormatter__BackingField;

		[Token(Token = "0x17000095")]
		public LoggingOptions LogTo
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x123B47C", Offset = "0x123B47C", VA = "0x123B47C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x123B484", Offset = "0x123B484", VA = "0x123B484")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public ResponseLoggingOption LogResponses
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x123B50C", Offset = "0x123B50C", VA = "0x123B50C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28070", Offset = "0x28070")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x123B514", Offset = "0x123B514", VA = "0x123B514")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28080", Offset = "0x28080")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public int LogResponsesSizeLimit
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x123B51C", Offset = "0x123B51C", VA = "0x123B51C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28090", Offset = "0x28090")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x123B524", Offset = "0x123B524", VA = "0x123B524")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x280A0", Offset = "0x280A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public bool LogMetrics
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x123B52C", Offset = "0x123B52C", VA = "0x123B52C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x280B0", Offset = "0x280B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x123B534", Offset = "0x123B534", VA = "0x123B534")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x280C0", Offset = "0x280C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public LogMetricsFormatOption LogMetricsFormat
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x123B53C", Offset = "0x123B53C", VA = "0x123B53C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x280D0", Offset = "0x280D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x123B544", Offset = "0x123B544", VA = "0x123B544")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x280E0", Offset = "0x280E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public IMetricsFormatter LogMetricsCustomFormatter
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x123B54C", Offset = "0x123B54C", VA = "0x123B54C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x280F0", Offset = "0x280F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x123B554", Offset = "0x123B554", VA = "0x123B554")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28100", Offset = "0x28100")]
			set
			{
			}
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x123B55C", Offset = "0x123B55C", VA = "0x123B55C")]
		internal LoggingConfig()
		{
		}
	}
}
