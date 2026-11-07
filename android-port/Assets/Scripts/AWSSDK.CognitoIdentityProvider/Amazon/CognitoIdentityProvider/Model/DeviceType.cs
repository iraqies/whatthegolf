using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DeviceType
	{
		private List<AttributeType> _deviceAttributes;

		private DateTime? _deviceCreateDate;

		private string _deviceKey;

		private DateTime? _deviceLastAuthenticatedDate;

		private DateTime? _deviceLastModifiedDate;

		public List<AttributeType> DeviceAttributes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime DeviceCreateDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string DeviceKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime DeviceLastAuthenticatedDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public DateTime DeviceLastModifiedDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		internal bool IsSetDeviceAttributes()
		{
			return false;
		}

		internal bool IsSetDeviceCreateDate()
		{
			return false;
		}

		internal bool IsSetDeviceKey()
		{
			return false;
		}

		internal bool IsSetDeviceLastAuthenticatedDate()
		{
			return false;
		}

		internal bool IsSetDeviceLastModifiedDate()
		{
			return false;
		}
	}
}
