using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListDevicesResponse : AmazonWebServiceResponse
	{
		private List<DeviceType> _devices;

		private string _paginationToken;

		public List<DeviceType> Devices
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
		public string PaginationToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDevices()
		{
			return false;
		}

		internal bool IsSetPaginationToken()
		{
			return false;
		}
	}
}
