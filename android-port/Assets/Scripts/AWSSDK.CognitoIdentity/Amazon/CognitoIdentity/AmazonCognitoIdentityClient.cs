using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity
{
	[Token(Token = "0x2000017")]
	public class AmazonCognitoIdentityClient : AmazonServiceClient, IAmazonCognitoIdentity, IAmazonService, IDisposable
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IServiceMetadata serviceMetadata;

		[Token(Token = "0x17000014")]
		protected override IServiceMetadata ServiceMetadata
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x10710D4", Offset = "0x10710D4", VA = "0x10710D4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1070A64", Offset = "0x1070A64", VA = "0x1070A64")]
		public AmazonCognitoIdentityClient()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1070BD0", Offset = "0x1070BD0", VA = "0x1070BD0")]
		public AmazonCognitoIdentityClient(RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1070C90", Offset = "0x1070C90", VA = "0x1070C90")]
		public AmazonCognitoIdentityClient(AmazonCognitoIdentityConfig config)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1070D10", Offset = "0x1070D10", VA = "0x1070D10")]
		public AmazonCognitoIdentityClient(AWSCredentials credentials)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1070D88", Offset = "0x1070D88", VA = "0x1070D88")]
		public AmazonCognitoIdentityClient(AWSCredentials credentials, RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1070D80", Offset = "0x1070D80", VA = "0x1070D80")]
		public AmazonCognitoIdentityClient(AWSCredentials credentials, AmazonCognitoIdentityConfig clientConfig)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1070E1C", Offset = "0x1070E1C", VA = "0x1070E1C")]
		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1070EA4", Offset = "0x1070EA4", VA = "0x1070EA4")]
		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1070E9C", Offset = "0x1070E9C", VA = "0x1070E9C")]
		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoIdentityConfig clientConfig)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1070F40", Offset = "0x1070F40", VA = "0x1070F40")]
		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1070FD0", Offset = "0x1070FD0", VA = "0x1070FD0")]
		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1070FC8", Offset = "0x1070FC8", VA = "0x1070FC8")]
		public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoIdentityConfig clientConfig)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x107107C", Offset = "0x107107C", VA = "0x107107C", Slot = "11")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1071138", Offset = "0x1071138", VA = "0x1071138", Slot = "10")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1071140", Offset = "0x1071140", VA = "0x1071140", Slot = "43")]
		internal virtual CreateIdentityPoolResponse CreateIdentityPool(CreateIdentityPoolRequest request)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x10712D8", Offset = "0x10712D8", VA = "0x10712D8", Slot = "44")]
		public virtual Task<CreateIdentityPoolResponse> CreateIdentityPoolAsync(CreateIdentityPoolRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1071478", Offset = "0x1071478", VA = "0x1071478", Slot = "45")]
		internal virtual DeleteIdentitiesResponse DeleteIdentities(DeleteIdentitiesRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1071610", Offset = "0x1071610", VA = "0x1071610", Slot = "46")]
		public virtual Task<DeleteIdentitiesResponse> DeleteIdentitiesAsync(DeleteIdentitiesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x10717B0", Offset = "0x10717B0", VA = "0x10717B0", Slot = "47")]
		internal virtual DeleteIdentityPoolResponse DeleteIdentityPool(DeleteIdentityPoolRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1071948", Offset = "0x1071948", VA = "0x1071948", Slot = "48")]
		public virtual Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(string identityPoolId, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x10719E4", Offset = "0x10719E4", VA = "0x10719E4", Slot = "49")]
		public virtual Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(DeleteIdentityPoolRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1071B84", Offset = "0x1071B84", VA = "0x1071B84", Slot = "50")]
		internal virtual DescribeIdentityResponse DescribeIdentity(DescribeIdentityRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1071D1C", Offset = "0x1071D1C", VA = "0x1071D1C", Slot = "51")]
		public virtual Task<DescribeIdentityResponse> DescribeIdentityAsync(string identityId, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1071DB8", Offset = "0x1071DB8", VA = "0x1071DB8", Slot = "52")]
		public virtual Task<DescribeIdentityResponse> DescribeIdentityAsync(DescribeIdentityRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1071F58", Offset = "0x1071F58", VA = "0x1071F58", Slot = "53")]
		internal virtual DescribeIdentityPoolResponse DescribeIdentityPool(DescribeIdentityPoolRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x10720F0", Offset = "0x10720F0", VA = "0x10720F0", Slot = "54")]
		public virtual Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(string identityPoolId, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x107218C", Offset = "0x107218C", VA = "0x107218C", Slot = "55")]
		public virtual Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(DescribeIdentityPoolRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x107232C", Offset = "0x107232C", VA = "0x107232C", Slot = "56")]
		internal virtual GetCredentialsForIdentityResponse GetCredentialsForIdentity(GetCredentialsForIdentityRequest request)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x10724C4", Offset = "0x10724C4", VA = "0x10724C4", Slot = "57")]
		public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1072638", Offset = "0x1072638", VA = "0x1072638", Slot = "58")]
		public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, Dictionary<string, string> logins, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1072730", Offset = "0x1072730", VA = "0x1072730", Slot = "59")]
		public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(GetCredentialsForIdentityRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x10728D0", Offset = "0x10728D0", VA = "0x10728D0", Slot = "60")]
		internal virtual GetIdResponse GetId(GetIdRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1072A68", Offset = "0x1072A68", VA = "0x1072A68", Slot = "61")]
		public virtual Task<GetIdResponse> GetIdAsync(GetIdRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1072C08", Offset = "0x1072C08", VA = "0x1072C08", Slot = "62")]
		internal virtual GetIdentityPoolRolesResponse GetIdentityPoolRoles(GetIdentityPoolRolesRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1072DA0", Offset = "0x1072DA0", VA = "0x1072DA0", Slot = "63")]
		public virtual Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(string identityPoolId, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1072E3C", Offset = "0x1072E3C", VA = "0x1072E3C", Slot = "64")]
		public virtual Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(GetIdentityPoolRolesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1072FDC", Offset = "0x1072FDC", VA = "0x1072FDC", Slot = "65")]
		internal virtual GetOpenIdTokenResponse GetOpenIdToken(GetOpenIdTokenRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1073174", Offset = "0x1073174", VA = "0x1073174", Slot = "66")]
		public virtual Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(string identityId, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x10732E8", Offset = "0x10732E8", VA = "0x10732E8", Slot = "67")]
		public virtual Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(GetOpenIdTokenRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1073488", Offset = "0x1073488", VA = "0x1073488", Slot = "68")]
		internal virtual GetOpenIdTokenForDeveloperIdentityResponse GetOpenIdTokenForDeveloperIdentity(GetOpenIdTokenForDeveloperIdentityRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1073620", Offset = "0x1073620", VA = "0x1073620", Slot = "69")]
		public virtual Task<GetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentityAsync(GetOpenIdTokenForDeveloperIdentityRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x10737C0", Offset = "0x10737C0", VA = "0x10737C0", Slot = "70")]
		internal virtual ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1073958", Offset = "0x1073958", VA = "0x1073958", Slot = "71")]
		public virtual Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1073AF8", Offset = "0x1073AF8", VA = "0x1073AF8", Slot = "72")]
		internal virtual ListIdentityPoolsResponse ListIdentityPools(ListIdentityPoolsRequest request)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1073C90", Offset = "0x1073C90", VA = "0x1073C90", Slot = "73")]
		public virtual Task<ListIdentityPoolsResponse> ListIdentityPoolsAsync(ListIdentityPoolsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1073E30", Offset = "0x1073E30", VA = "0x1073E30", Slot = "74")]
		internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1073FC8", Offset = "0x1073FC8", VA = "0x1073FC8", Slot = "75")]
		public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1074168", Offset = "0x1074168", VA = "0x1074168", Slot = "76")]
		internal virtual LookupDeveloperIdentityResponse LookupDeveloperIdentity(LookupDeveloperIdentityRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1074300", Offset = "0x1074300", VA = "0x1074300", Slot = "77")]
		public virtual Task<LookupDeveloperIdentityResponse> LookupDeveloperIdentityAsync(LookupDeveloperIdentityRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x10744A0", Offset = "0x10744A0", VA = "0x10744A0", Slot = "78")]
		internal virtual MergeDeveloperIdentitiesResponse MergeDeveloperIdentities(MergeDeveloperIdentitiesRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1074638", Offset = "0x1074638", VA = "0x1074638", Slot = "79")]
		public virtual Task<MergeDeveloperIdentitiesResponse> MergeDeveloperIdentitiesAsync(MergeDeveloperIdentitiesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x10747D8", Offset = "0x10747D8", VA = "0x10747D8", Slot = "80")]
		internal virtual SetIdentityPoolRolesResponse SetIdentityPoolRoles(SetIdentityPoolRolesRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1074970", Offset = "0x1074970", VA = "0x1074970", Slot = "81")]
		public virtual Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(string identityPoolId, Dictionary<string, string> roles, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1074A0C", Offset = "0x1074A0C", VA = "0x1074A0C", Slot = "82")]
		public virtual Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(SetIdentityPoolRolesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1074BAC", Offset = "0x1074BAC", VA = "0x1074BAC", Slot = "83")]
		internal virtual TagResourceResponse TagResource(TagResourceRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1074D44", Offset = "0x1074D44", VA = "0x1074D44", Slot = "84")]
		public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1074EE4", Offset = "0x1074EE4", VA = "0x1074EE4", Slot = "85")]
		internal virtual UnlinkDeveloperIdentityResponse UnlinkDeveloperIdentity(UnlinkDeveloperIdentityRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x107507C", Offset = "0x107507C", VA = "0x107507C", Slot = "86")]
		public virtual Task<UnlinkDeveloperIdentityResponse> UnlinkDeveloperIdentityAsync(UnlinkDeveloperIdentityRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x107521C", Offset = "0x107521C", VA = "0x107521C", Slot = "87")]
		internal virtual UnlinkIdentityResponse UnlinkIdentity(UnlinkIdentityRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x10753B4", Offset = "0x10753B4", VA = "0x10753B4", Slot = "88")]
		public virtual Task<UnlinkIdentityResponse> UnlinkIdentityAsync(UnlinkIdentityRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1075554", Offset = "0x1075554", VA = "0x1075554", Slot = "89")]
		internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x10756EC", Offset = "0x10756EC", VA = "0x10756EC", Slot = "90")]
		public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x107588C", Offset = "0x107588C", VA = "0x107588C", Slot = "91")]
		internal virtual UpdateIdentityPoolResponse UpdateIdentityPool(UpdateIdentityPoolRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1075A24", Offset = "0x1075A24", VA = "0x1075A24", Slot = "92")]
		public virtual Task<UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(UpdateIdentityPoolRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1075C48", Offset = "0x1075C48", VA = "0x1075C48", Slot = "42")]
		private IClientConfig Amazon_002ERuntime_002EIAmazonService_002Eget_Config()
		{
			return null;
		}
	}
}
