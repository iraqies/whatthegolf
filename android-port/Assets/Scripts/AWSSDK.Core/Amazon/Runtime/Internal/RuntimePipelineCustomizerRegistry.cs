using System;
using System.Collections.Generic;
using System.Threading;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000169")]
	public class RuntimePipelineCustomizerRegistry : IDisposable
	{
		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25D00", Offset = "0x25D00")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4000582")]
			[FieldOffset(Offset = "0x10")]
			public IRuntimePipelineCustomizer customizer;

			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x1295338", Offset = "0x1295338", VA = "0x1295338")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x1295340", Offset = "0x1295340", VA = "0x1295340")]
			internal bool _003CRegister_003Eb__0(IRuntimePipelineCustomizer x)
			{
				return default;
			}
		}

		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27248", Offset = "0x27248")]
		private static readonly RuntimePipelineCustomizerRegistry Instance__BackingField;

		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x10")]
		private Logger _logger;

		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x18")]
		private ReaderWriterLockSlim _rwlock;

		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x20")]
		private IList<IRuntimePipelineCustomizer> _customizers;

		[Token(Token = "0x17000315")]
		public static RuntimePipelineCustomizerRegistry Instance
		{
			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0x126579C", Offset = "0x126579C", VA = "0x126579C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A2E4", Offset = "0x2A2E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x1265800", Offset = "0x1265800", VA = "0x1265800")]
		private RuntimePipelineCustomizerRegistry()
		{
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x1265950", Offset = "0x1265950", VA = "0x1265950")]
		public void Register(IRuntimePipelineCustomizer customizer)
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x1265DD0", Offset = "0x1265DD0", VA = "0x1265DD0")]
		public void Deregister(IRuntimePipelineCustomizer customizer)
		{
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x1265E98", Offset = "0x1265E98", VA = "0x1265E98")]
		public void Deregister(string uniqueName)
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x1266334", Offset = "0x1266334", VA = "0x1266334")]
		internal void ApplyCustomizations(Type type, RuntimePipeline pipeline)
		{
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x126688C", Offset = "0x126688C", VA = "0x126688C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x126690C", Offset = "0x126690C", VA = "0x126690C", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
