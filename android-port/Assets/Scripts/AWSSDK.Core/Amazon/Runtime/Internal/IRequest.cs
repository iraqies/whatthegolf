using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000164")]
	public interface IRequest
	{
		[Token(Token = "0x170002ED")]
		string RequestName
		{
			[Token(Token = "0x6000B34")]
			get;
		}

		[Token(Token = "0x170002EE")]
		IDictionary<string, string> Headers
		{
			[Token(Token = "0x6000B35")]
			get;
		}

		[Token(Token = "0x170002EF")]
		bool UseQueryString
		{
			[Token(Token = "0x6000B36")]
			get;
			[Token(Token = "0x6000B37")]
			set;
		}

		[Token(Token = "0x170002F0")]
		IDictionary<string, string> Parameters
		{
			[Token(Token = "0x6000B38")]
			get;
		}

		[Token(Token = "0x170002F1")]
		ParameterCollection ParameterCollection
		{
			[Token(Token = "0x6000B39")]
			get;
		}

		[Token(Token = "0x170002F2")]
		IDictionary<string, string> SubResources
		{
			[Token(Token = "0x6000B3A")]
			get;
		}

		[Token(Token = "0x170002F3")]
		string HttpMethod
		{
			[Token(Token = "0x6000B3D")]
			get;
			[Token(Token = "0x6000B3E")]
			set;
		}

		[Token(Token = "0x170002F4")]
		Uri Endpoint
		{
			[Token(Token = "0x6000B3F")]
			get;
			[Token(Token = "0x6000B40")]
			set;
		}

		[Token(Token = "0x170002F5")]
		string ResourcePath
		{
			[Token(Token = "0x6000B41")]
			get;
			[Token(Token = "0x6000B42")]
			set;
		}

		[Token(Token = "0x170002F6")]
		IDictionary<string, string> PathResources
		{
			[Token(Token = "0x6000B43")]
			get;
		}

		[Token(Token = "0x170002F7")]
		int MarshallerVersion
		{
			[Token(Token = "0x6000B45")]
			get;
			[Token(Token = "0x6000B46")]
			set;
		}

		[Token(Token = "0x170002F8")]
		byte[] Content
		{
			[Token(Token = "0x6000B47")]
			get;
			[Token(Token = "0x6000B48")]
			set;
		}

		[Token(Token = "0x170002F9")]
		bool SetContentFromParameters
		{
			[Token(Token = "0x6000B4A")]
			get;
			[Token(Token = "0x6000B4B")]
			set;
		}

		[Token(Token = "0x170002FA")]
		Stream ContentStream
		{
			[Token(Token = "0x6000B4C")]
			get;
			[Token(Token = "0x6000B4D")]
			set;
		}

		[Token(Token = "0x170002FB")]
		long OriginalStreamPosition
		{
			[Token(Token = "0x6000B4E")]
			get;
			[Token(Token = "0x6000B4F")]
			set;
		}

		[Token(Token = "0x170002FC")]
		string ServiceName
		{
			[Token(Token = "0x6000B51")]
			get;
		}

		[Token(Token = "0x170002FD")]
		AmazonWebServiceRequest OriginalRequest
		{
			[Token(Token = "0x6000B52")]
			get;
		}

		[Token(Token = "0x170002FE")]
		RegionEndpoint AlternateEndpoint
		{
			[Token(Token = "0x6000B53")]
			get;
			[Token(Token = "0x6000B54")]
			set;
		}

		[Token(Token = "0x170002FF")]
		string HostPrefix
		{
			[Token(Token = "0x6000B55")]
			get;
			[Token(Token = "0x6000B56")]
			set;
		}

		[Token(Token = "0x17000300")]
		bool Suppress404Exceptions
		{
			[Token(Token = "0x6000B57")]
			get;
			[Token(Token = "0x6000B58")]
			set;
		}

		[Token(Token = "0x17000301")]
		AWS4SigningResult AWS4SignerResult
		{
			[Token(Token = "0x6000B59")]
			get;
			[Token(Token = "0x6000B5A")]
			set;
		}

		[Token(Token = "0x17000302")]
		bool UseChunkEncoding
		{
			[Token(Token = "0x6000B5B")]
			get;
			[Token(Token = "0x6000B5C")]
			set;
		}

		[Token(Token = "0x17000303")]
		string CanonicalResourcePrefix
		{
			[Token(Token = "0x6000B5D")]
			get;
			[Token(Token = "0x6000B5E")]
			set;
		}

		[Token(Token = "0x17000304")]
		bool UseSigV4
		{
			[Token(Token = "0x6000B5F")]
			get;
			[Token(Token = "0x6000B60")]
			set;
		}

		[Token(Token = "0x17000305")]
		string AuthenticationRegion
		{
			[Token(Token = "0x6000B61")]
			get;
			[Token(Token = "0x6000B62")]
			set;
		}

		[Token(Token = "0x17000306")]
		string DeterminedSigningRegion
		{
			[Token(Token = "0x6000B63")]
			get;
			[Token(Token = "0x6000B64")]
			set;
		}

		[Token(Token = "0x6000B3B")]
		void AddSubResource(string subResource);

		[Token(Token = "0x6000B3C")]
		void AddSubResource(string subResource, string value);

		[Token(Token = "0x6000B44")]
		void AddPathResource(string key, string value);

		[Token(Token = "0x6000B49")]
		string GetHeaderValue(string headerName);

		[Token(Token = "0x6000B50")]
		string ComputeContentStreamHash();

		[Token(Token = "0x6000B65")]
		bool IsRequestStreamRewindable();

		[Token(Token = "0x6000B66")]
		bool MayContainRequestBody();

		[Token(Token = "0x6000B67")]
		bool HasRequestBody();
	}
}
