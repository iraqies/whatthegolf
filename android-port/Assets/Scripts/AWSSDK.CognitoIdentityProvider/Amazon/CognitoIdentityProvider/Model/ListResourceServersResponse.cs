using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListResourceServersResponse : AmazonWebServiceResponse
	{
		private string _nextToken;

		private List<ResourceServerType> _resourceServers;

		[AWSProperty]
		public string NextToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public List<ResourceServerType> ResourceServers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetNextToken()
		{
			return false;
		}

		internal bool IsSetResourceServers()
		{
			return false;
		}
	}
}
