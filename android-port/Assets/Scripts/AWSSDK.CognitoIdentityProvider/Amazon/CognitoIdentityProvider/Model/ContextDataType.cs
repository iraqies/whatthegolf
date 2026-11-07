using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ContextDataType
	{
		private string _encodedData;

		private List<HttpHeader> _httpHeaders;

		private string _ipAddress;

		private string _serverName;

		private string _serverPath;

		public string EncodedData
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
		public List<HttpHeader> HttpHeaders
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
		public string IpAddress
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
		public string ServerName
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
		public string ServerPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetEncodedData()
		{
			return false;
		}

		internal bool IsSetHttpHeaders()
		{
			return false;
		}

		internal bool IsSetIpAddress()
		{
			return false;
		}

		internal bool IsSetServerName()
		{
			return false;
		}

		internal bool IsSetServerPath()
		{
			return false;
		}
	}
}
