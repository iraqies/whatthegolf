using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime
{
	public abstract class AmazonWebServiceRequest : IAmazonWebServiceRequest
	{
		internal RequestEventHandler mBeforeRequestEvent;

		private Dictionary<string, object> requestState;

		EventHandler<StreamTransferProgressArgs> IAmazonWebServiceRequest.StreamUploadProgressCallback
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		Dictionary<string, object> IAmazonWebServiceRequest.RequestState => null;

		bool IAmazonWebServiceRequest.UseSigV4
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected virtual bool Expect100Continue => false;

		protected virtual bool IncludeSHA256Header => false;

		internal event RequestEventHandler BeforeRequestEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		void IAmazonWebServiceRequest.AddBeforeRequestHandler(RequestEventHandler handler)
		{
		}

		void IAmazonWebServiceRequest.RemoveBeforeRequestHandler(RequestEventHandler handler)
		{
		}

		internal void FireBeforeRequestEvent(object sender, RequestEventArgs args)
		{
		}

		internal bool GetExpect100Continue()
		{
			return false;
		}

		internal bool GetIncludeSHA256Header()
		{
			return false;
		}

		protected virtual AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		internal AbstractAWSSigner GetSigner()
		{
			return null;
		}
	}
}
