using System;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000F7")]
	public class PreRequestEventArgs : EventArgs
	{
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26C78", Offset = "0x26C78")]
		private AmazonWebServiceRequest Request__BackingField;

		[Token(Token = "0x17000247")]
		public AmazonWebServiceRequest Request
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x124DCF0", Offset = "0x124DCF0", VA = "0x124DCF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2961C", Offset = "0x2961C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x124DCF8", Offset = "0x124DCF8", VA = "0x124DCF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2962C", Offset = "0x2962C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x124DC74", Offset = "0x124DC74", VA = "0x124DC74")]
		protected PreRequestEventArgs()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x124DD00", Offset = "0x124DD00", VA = "0x124DD00")]
		internal static PreRequestEventArgs Create(AmazonWebServiceRequest request)
		{
			return null;
		}
	}
}
