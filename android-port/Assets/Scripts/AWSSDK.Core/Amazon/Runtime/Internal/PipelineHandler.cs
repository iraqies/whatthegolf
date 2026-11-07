using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000197")]
	public abstract class PipelineHandler : IPipelineHandler
	{
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27488", Offset = "0x27488")]
		private ILogger Logger__BackingField;

		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27498", Offset = "0x27498")]
		private IPipelineHandler InnerHandler__BackingField;

		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x274A8", Offset = "0x274A8")]
		private IPipelineHandler OuterHandler__BackingField;

		[Token(Token = "0x17000341")]
		public virtual ILogger Logger
		{
			[Token(Token = "0x6000C81")]
			[Address(RVA = "0x124B820", Offset = "0x124B820", VA = "0x124B820", Slot = "12")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AA24", Offset = "0x2AA24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x124B828", Offset = "0x124B828", VA = "0x124B828", Slot = "13")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AA34", Offset = "0x2AA34")]
			set
			{
			}
		}

		[Token(Token = "0x17000342")]
		public IPipelineHandler InnerHandler
		{
			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x124B830", Offset = "0x124B830", VA = "0x124B830", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AA44", Offset = "0x2AA44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x124B838", Offset = "0x124B838", VA = "0x124B838", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AA54", Offset = "0x2AA54")]
			set
			{
			}
		}

		[Token(Token = "0x17000343")]
		public IPipelineHandler OuterHandler
		{
			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x124B840", Offset = "0x124B840", VA = "0x124B840", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AA64", Offset = "0x2AA64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x124B848", Offset = "0x124B848", VA = "0x124B848", Slot = "9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AA74", Offset = "0x2AA74")]
			set
			{
			}
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x123DF3C", Offset = "0x123DF3C", VA = "0x123DF3C", Slot = "14")]
		public virtual void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C88")]
		public virtual Task<T> InvokeAsync<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}

		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x123F278", Offset = "0x123F278", VA = "0x123F278")]
		protected void LogMetrics(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x123E050", Offset = "0x123E050", VA = "0x123E050")]
		protected PipelineHandler()
		{
		}
	}
}
