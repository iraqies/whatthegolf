using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x2000103")]
	public class WebServiceResponseEventArgs : ResponseEventArgs
	{
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26CF8", Offset = "0x26CF8")]
		private IDictionary<string, string> RequestHeaders__BackingField;

		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26D08", Offset = "0x26D08")]
		private IDictionary<string, string> ResponseHeaders__BackingField;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26D18", Offset = "0x26D18")]
		private IDictionary<string, string> Parameters__BackingField;

		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26D28", Offset = "0x26D28")]
		private string ServiceName__BackingField;

		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26D38", Offset = "0x26D38")]
		private Uri Endpoint__BackingField;

		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26D48", Offset = "0x26D48")]
		private AmazonWebServiceRequest Request__BackingField;

		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26D58", Offset = "0x26D58")]
		private AmazonWebServiceResponse Response__BackingField;

		[Token(Token = "0x17000257")]
		public IDictionary<string, string> RequestHeaders
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x1282208", Offset = "0x1282208", VA = "0x1282208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2971C", Offset = "0x2971C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x1282210", Offset = "0x1282210", VA = "0x1282210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2972C", Offset = "0x2972C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000258")]
		public IDictionary<string, string> ResponseHeaders
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x1282218", Offset = "0x1282218", VA = "0x1282218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2973C", Offset = "0x2973C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x1282220", Offset = "0x1282220", VA = "0x1282220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2974C", Offset = "0x2974C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000259")]
		public IDictionary<string, string> Parameters
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x1282228", Offset = "0x1282228", VA = "0x1282228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2975C", Offset = "0x2975C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x1282230", Offset = "0x1282230", VA = "0x1282230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2976C", Offset = "0x2976C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700025A")]
		public string ServiceName
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x1282238", Offset = "0x1282238", VA = "0x1282238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2977C", Offset = "0x2977C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x1282240", Offset = "0x1282240", VA = "0x1282240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2978C", Offset = "0x2978C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700025B")]
		public Uri Endpoint
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x1282248", Offset = "0x1282248", VA = "0x1282248")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2979C", Offset = "0x2979C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x1282250", Offset = "0x1282250", VA = "0x1282250")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x297AC", Offset = "0x297AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700025C")]
		public AmazonWebServiceRequest Request
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x1282258", Offset = "0x1282258", VA = "0x1282258")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x297BC", Offset = "0x297BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x1282260", Offset = "0x1282260", VA = "0x1282260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x297CC", Offset = "0x297CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700025D")]
		public AmazonWebServiceResponse Response
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x1282268", Offset = "0x1282268", VA = "0x1282268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x297DC", Offset = "0x297DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x1282270", Offset = "0x1282270", VA = "0x1282270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x297EC", Offset = "0x297EC")]
			private set
			{
			}
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x1282200", Offset = "0x1282200", VA = "0x1282200")]
		protected WebServiceResponseEventArgs()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1282278", Offset = "0x1282278", VA = "0x1282278")]
		internal static WebServiceResponseEventArgs Create(AmazonWebServiceResponse response, IRequest request, IWebResponseData webResponseData)
		{
			return null;
		}
	}
}
