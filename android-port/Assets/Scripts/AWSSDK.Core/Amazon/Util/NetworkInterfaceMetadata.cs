using System.Collections.Generic;

namespace Amazon.Util
{
	public class NetworkInterfaceMetadata
	{
		private string _path;

		private string _mac;

		private IEnumerable<string> _availableKeys;

		private Dictionary<string, string> _data;

		public string MacAddress => null;

		public string OwnerId => null;

		public string Profile => null;

		public string LocalHostname => null;

		public IEnumerable<string> LocalIPv4s => null;

		public string PublicHostname => null;

		public IEnumerable<string> PublicIPv4s => null;

		public IEnumerable<string> SecurityGroups => null;

		public IEnumerable<string> SecurityGroupIds => null;

		public string SubnetId => null;

		public string SubnetIPv4CidrBlock => null;

		public string VpcId => null;

		private NetworkInterfaceMetadata()
		{
		}

		public NetworkInterfaceMetadata(string macAddress)
		{
		}

		public IEnumerable<string> GetIpV4Association(string publicIp)
		{
			return null;
		}

		private string GetData(string key)
		{
			return null;
		}

		private IEnumerable<string> GetItems(string key)
		{
			return null;
		}
	}
}
