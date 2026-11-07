using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x200009F")]
	public abstract class AmazonWebServiceRequest : IAmazonWebServiceRequest
	{
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x10")]
		internal RequestEventHandler mBeforeRequestEvent;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x267B8", Offset = "0x267B8")]
		private EventHandler<StreamTransferProgressArgs> Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002EStreamUploadProgressCallback__BackingField;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, object> requestState;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x267C8", Offset = "0x267C8")]
		private bool Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002EUseSigV4__BackingField;

		[Token(Token = "0x1700016F")]
		private EventHandler<StreamTransferProgressArgs> Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002EStreamUploadProgressCallback
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x11CDA04", Offset = "0x11CDA04", VA = "0x11CDA04", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C4C", Offset = "0x28C4C")]
			get
			{
				return Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002Eget_StreamUploadProgressCallback();
			}
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x11CDA0C", Offset = "0x11CDA0C", VA = "0x11CDA0C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C5C", Offset = "0x28C5C")]
			set
			{
				Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002Eset_StreamUploadProgressCallback(value);
			}
		}

		[Token(Token = "0x17000170")]
		private Dictionary<string, object> Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002ERequestState
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x11CDA14", Offset = "0x11CDA14", VA = "0x11CDA14", Slot = "8")]
			get
			{
				return Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002Eget_RequestState();
			}
		}

		[Token(Token = "0x17000171")]
		private bool Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002EUseSigV4
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x11CDAA0", Offset = "0x11CDAA0", VA = "0x11CDAA0", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C6C", Offset = "0x28C6C")]
			get
			{
				return Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002Eget_UseSigV4();
			}
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x11CDAA8", Offset = "0x11CDAA8", VA = "0x11CDAA8", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C7C", Offset = "0x28C7C")]
			set
			{
				Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002Eset_UseSigV4(value);
			}
		}

		[Token(Token = "0x17000172")]
		protected virtual bool Expect100Continue
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x11CDAB0", Offset = "0x11CDAB0", VA = "0x11CDAB0", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000173")]
		protected virtual bool IncludeSHA256Header
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x11CDAC4", Offset = "0x11CDAC4", VA = "0x11CDAC4", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000008")]
		internal event RequestEventHandler BeforeRequestEvent
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x11CD7B4", Offset = "0x11CD7B4", VA = "0x11CD7B4")]
			add
			{
			}
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x11CD8DC", Offset = "0x11CD8DC", VA = "0x11CD8DC")]
			remove
			{
			}
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x11CDA04", Offset = "0x11CDA04", VA = "0x11CDA04", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C4C", Offset = "0x28C4C")]
		private EventHandler<StreamTransferProgressArgs> Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002Eget_StreamUploadProgressCallback()
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x11CDA0C", Offset = "0x11CDA0C", VA = "0x11CDA0C", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C5C", Offset = "0x28C5C")]
		private void Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002Eset_StreamUploadProgressCallback(EventHandler<StreamTransferProgressArgs> value)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x11CDA14", Offset = "0x11CDA14", VA = "0x11CDA14", Slot = "8")]
		private Dictionary<string, object> Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002Eget_RequestState()
		{
			return null;
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x11CDA90", Offset = "0x11CDA90", VA = "0x11CDA90")]
		protected AmazonWebServiceRequest()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x11CDA98", Offset = "0x11CDA98", VA = "0x11CDA98", Slot = "6")]
		private void Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002EAddBeforeRequestHandler(RequestEventHandler handler)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x11CDA9C", Offset = "0x11CDA9C", VA = "0x11CDA9C", Slot = "7")]
		private void Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002ERemoveBeforeRequestHandler(RequestEventHandler handler)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x11CB43C", Offset = "0x11CB43C", VA = "0x11CB43C")]
		internal void FireBeforeRequestEvent(object sender, RequestEventArgs args)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x11CDAA0", Offset = "0x11CDAA0", VA = "0x11CDAA0", Slot = "9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C6C", Offset = "0x28C6C")]
		private bool Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002Eget_UseSigV4()
		{
			return default;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x11CDAA8", Offset = "0x11CDAA8", VA = "0x11CDAA8", Slot = "10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C7C", Offset = "0x28C7C")]
		private void Amazon_002ERuntime_002EInternal_002EIAmazonWebServiceRequest_002Eset_UseSigV4(bool value)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x11CDAB8", Offset = "0x11CDAB8", VA = "0x11CDAB8")]
		internal bool GetExpect100Continue()
		{
			return default;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x11CDACC", Offset = "0x11CDACC", VA = "0x11CDACC")]
		internal bool GetIncludeSHA256Header()
		{
			return default;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x11CDAD8", Offset = "0x11CDAD8", VA = "0x11CDAD8", Slot = "13")]
		protected virtual AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x11CDAE0", Offset = "0x11CDAE0", VA = "0x11CDAE0")]
		internal AbstractAWSSigner GetSigner()
		{
			return null;
		}
	}
}
