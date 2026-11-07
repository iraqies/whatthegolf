using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Internal
{
	public class DefaultRequest : IRequest
	{
		private readonly ParameterCollection parametersCollection;

		private readonly IDictionary<string, string> parametersFacade;

		private readonly IDictionary<string, string> headers;

		private readonly IDictionary<string, string> subResources;

		private readonly IDictionary<string, string> pathResources;

		private Uri endpoint;

		private string resourcePath;

		private string serviceName;

		private readonly AmazonWebServiceRequest originalRequest;

		private byte[] content;

		private Stream contentStream;

		private string contentStreamHash;

		private string httpMethod;

		private bool useQueryString;

		private string requestName;

		private string canonicalResource;

		private RegionEndpoint alternateRegion;

		private long originalStreamLength;

		private int marshallerVersion;

		public string RequestName => null;

		public string HttpMethod
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseQueryString
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AmazonWebServiceRequest OriginalRequest => null;

		public IDictionary<string, string> Headers => null;

		public IDictionary<string, string> Parameters => null;

		public ParameterCollection ParameterCollection => null;

		public IDictionary<string, string> SubResources => null;

		public Uri Endpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ResourcePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IDictionary<string, string> PathResources => null;

		public int MarshallerVersion
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string CanonicalResource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public byte[] Content
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool SetContentFromParameters { get; set; }

		public Stream ContentStream
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long OriginalStreamPosition
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string ServiceName => null;

		public RegionEndpoint AlternateEndpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string HostPrefix { get; set; }

		public bool Suppress404Exceptions { get; set; }

		public AWS4SigningResult AWS4SignerResult { get; set; }

		public bool UseChunkEncoding { get; set; }

		public string CanonicalResourcePrefix { get; set; }

		public bool UseSigV4 { get; set; }

		public string AuthenticationRegion { get; set; }

		public string DeterminedSigningRegion { get; set; }

		public DefaultRequest(AmazonWebServiceRequest request, string serviceName)
		{
		}

		public void AddSubResource(string subResource)
		{
		}

		public void AddSubResource(string subResource, string value)
		{
		}

		public void AddPathResource(string key, string value)
		{
		}

		public string ComputeContentStreamHash()
		{
			return null;
		}

		public bool IsRequestStreamRewindable()
		{
			return false;
		}

		public bool MayContainRequestBody()
		{
			return false;
		}

		public bool HasRequestBody()
		{
			return false;
		}

		public string GetHeaderValue(string headerName)
		{
			return null;
		}
	}
}
