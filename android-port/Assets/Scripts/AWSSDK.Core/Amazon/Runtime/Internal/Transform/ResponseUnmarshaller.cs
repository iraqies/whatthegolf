using System;
using System.IO;
using System.Net;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200021F")]
	public abstract class ResponseUnmarshaller : IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext>, IUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext>
	{
		[Token(Token = "0x17000417")]
		public virtual bool HasStreamingProperty
		{
			[Token(Token = "0x6001041")]
			[Address(RVA = "0x12602C0", Offset = "0x12602C0", VA = "0x12602C0", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001040")]
		[Address(RVA = "0x126021C", Offset = "0x126021C", VA = "0x126021C", Slot = "6")]
		public virtual UnmarshallerContext CreateContext(IWebResponseData response, bool readEntireResponse, Stream stream, RequestMetrics metrics, bool isException)
		{
			return null;
		}

		[Token(Token = "0x6001042")]
		[Address(RVA = "0x12602C8", Offset = "0x12602C8", VA = "0x12602C8", Slot = "8")]
		public virtual AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001043")]
		[Address(RVA = "0x1260308", Offset = "0x1260308", VA = "0x1260308")]
		public AmazonWebServiceResponse UnmarshallResponse(UnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001044")]
		public abstract AmazonWebServiceResponse Unmarshall(UnmarshallerContext input);

		[Token(Token = "0x6001045")]
		public static string GetDefaultErrorMessage<T>() where T : Exception
		{
			return null;
		}

		[Token(Token = "0x6001046")]
		protected abstract UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response, bool isException);

		[Token(Token = "0x6001047")]
		[Address(RVA = "0x1260478", Offset = "0x1260478", VA = "0x1260478", Slot = "11")]
		protected virtual bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse)
		{
			return default;
		}

		[Token(Token = "0x6001048")]
		[Address(RVA = "0x1260480", Offset = "0x1260480", VA = "0x1260480")]
		protected ResponseUnmarshaller()
		{
		}
	}
}
