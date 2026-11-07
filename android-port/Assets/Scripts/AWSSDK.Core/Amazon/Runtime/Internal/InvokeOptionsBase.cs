using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000162")]
	public abstract class InvokeOptionsBase
	{
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x10")]
		private IMarshaller<IRequest, AmazonWebServiceRequest> _requestMarshaller;

		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0x18")]
		private ResponseUnmarshaller _responseUnmarshaller;

		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x20")]
		private IMarshaller<EndpointDiscoveryDataBase, AmazonWebServiceRequest> _endpointDiscoveryMarshaller;

		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x28")]
		private EndpointOperationDelegate _endpointOperation;

		[Token(Token = "0x170002E9")]
		public virtual IMarshaller<IRequest, AmazonWebServiceRequest> RequestMarshaller
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x121EB78", Offset = "0x121EB78", VA = "0x121EB78", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x121EB80", Offset = "0x121EB80", VA = "0x121EB80", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170002EA")]
		public virtual ResponseUnmarshaller ResponseUnmarshaller
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x121EB88", Offset = "0x121EB88", VA = "0x121EB88", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x121EB90", Offset = "0x121EB90", VA = "0x121EB90", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170002EB")]
		public virtual IMarshaller<EndpointDiscoveryDataBase, AmazonWebServiceRequest> EndpointDiscoveryMarshaller
		{
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x121EB98", Offset = "0x121EB98", VA = "0x121EB98", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x121EBA0", Offset = "0x121EBA0", VA = "0x121EBA0", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170002EC")]
		public virtual EndpointOperationDelegate EndpointOperation
		{
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x121EBA8", Offset = "0x121EBA8", VA = "0x121EBA8", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x121EBB0", Offset = "0x121EBB0", VA = "0x121EBB0", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x121EB70", Offset = "0x121EB70", VA = "0x121EB70")]
		protected InvokeOptionsBase()
		{
		}
	}
}
