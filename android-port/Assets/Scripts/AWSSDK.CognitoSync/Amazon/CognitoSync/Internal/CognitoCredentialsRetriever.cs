using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;

namespace Amazon.CognitoSync.Internal
{
	public class CognitoCredentialsRetriever : CredentialsRetriever
	{
		private static class CSRequestCache
		{
			private class CSRequest
			{
				private ITypeInfo requestType;

				private PropertyInfo identityPoolIdProperty;

				private PropertyInfo identityIdProperty;

				public static ITypeInfo SyncRequestType;

				public CSRequest(Type requestType)
				{
				}

				public void SetFields(AmazonCognitoSyncRequest request, string identityPoolId, string identityId)
				{
				}
			}

			private static Dictionary<Type, CSRequest> requestCache;

			static CSRequestCache()
			{
			}

			private static void PopulateCache()
			{
			}

			public static void SetFields(AmazonCognitoSyncRequest request, string identityPoolId, string identityId)
			{
			}
		}

		public CognitoCredentialsRetriever(AWSCredentials credentials)
			: base(null)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		private static void SetIdentity(IExecutionContext executionContext, string identityId, string identityPoolId)
		{
		}
	}
}
