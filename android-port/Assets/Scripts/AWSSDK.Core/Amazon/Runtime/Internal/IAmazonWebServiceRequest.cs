using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000159")]
	public interface IAmazonWebServiceRequest
	{
		[Token(Token = "0x170002E0")]
		EventHandler<StreamTransferProgressArgs> StreamUploadProgressCallback
		{
			[Token(Token = "0x6000B00")]
			get;
			[Token(Token = "0x6000B01")]
			set;
		}

		[Token(Token = "0x170002E1")]
		Dictionary<string, object> RequestState
		{
			[Token(Token = "0x6000B04")]
			get;
		}

		[Token(Token = "0x170002E2")]
		bool UseSigV4
		{
			[Token(Token = "0x6000B05")]
			get;
			[Token(Token = "0x6000B06")]
			set;
		}

		[Token(Token = "0x6000B02")]
		void AddBeforeRequestHandler(RequestEventHandler handler);

		[Token(Token = "0x6000B03")]
		void RemoveBeforeRequestHandler(RequestEventHandler handler);
	}
}
