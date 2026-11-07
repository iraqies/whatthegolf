using System;
using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement.Internal;

namespace Amazon.Runtime.CredentialManagement
{
	public class CredentialProfile
	{
		private Dictionary<string, string> _properties;

		public string Name { get; private set; }

		public CredentialProfileOptions Options { get; private set; }

		public RegionEndpoint Region { get; set; }

		internal Guid? UniqueKey { get; set; }

		public bool? EndpointDiscoveryEnabled { get; set; }

		public bool? S3UseArnRegion { get; set; }

		public StsRegionalEndpointsValue? StsRegionalEndpoints { get; set; }

		public S3UsEast1RegionalEndpointValue? S3RegionalEndpoint { get; set; }

		public RequestRetryMode? RetryMode { get; set; }

		public int? MaxAttempts { get; set; }

		internal Dictionary<string, string> Properties
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool CanCreateAWSCredentials => false;

		public ICredentialProfileStore CredentialProfileStore { get; internal set; }

		public string CredentialDescription => null;

		internal CredentialProfileType? ProfileType => null;

		internal bool IsCallbackRequired => false;

		public CredentialProfile(string name, CredentialProfileOptions profileOptions)
		{
		}

		public AWSCredentials GetAWSCredentials(ICredentialProfileSource profileSource)
		{
			return null;
		}

		internal AWSCredentials GetAWSCredentials(ICredentialProfileSource profileSource, bool nonCallbackOnly)
		{
			return null;
		}

		private string GetPropertiesString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
