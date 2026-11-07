using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000059")]
	[Attribute(Name = "NullableAttribute", RVA = "0x1830E4", Offset = "0x1830E4")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x1830E4", Offset = "0x1830E4")]
	internal class FSharpFunction
	{
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _instance;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18592C", Offset = "0x18592C")]
		private readonly MethodCall<object, object> _invoker;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x22C7C38", Offset = "0x22C7C38", VA = "0x22C7C38")]
		public FSharpFunction(object instance, [Attribute(Name = "NullableAttribute", RVA = "0x18B9B8", Offset = "0x18B9B8")] MethodCall<object, object> invoker)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x22C3B0C", Offset = "0x22C3B0C", VA = "0x22C3B0C")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x188DF4", Offset = "0x188DF4")]
		public object Invoke(params object[] args)
		{
			return null;
		}
	}
}
