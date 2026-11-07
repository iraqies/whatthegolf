using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider
{
	public class AmazonCognitoIdentityProviderClient : AmazonServiceClient, IAmazonCognitoIdentityProvider, IAmazonService, IDisposable
	{
		private static IServiceMetadata serviceMetadata;

		protected override IServiceMetadata ServiceMetadata => null;

		IClientConfig IAmazonService.Config => null;

		public AmazonCognitoIdentityProviderClient()
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(AmazonCognitoIdentityProviderConfig config)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(AWSCredentials credentials)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(AWSCredentials credentials, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(AWSCredentials credentials, AmazonCognitoIdentityProviderConfig clientConfig)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoIdentityProviderConfig clientConfig)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoIdentityProviderConfig clientConfig)
			: base(null, null)
		{
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal virtual AddCustomAttributesResponse AddCustomAttributes(AddCustomAttributesRequest request)
		{
			return null;
		}

		public virtual Task<AddCustomAttributesResponse> AddCustomAttributesAsync(AddCustomAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminAddUserToGroupResponse AdminAddUserToGroup(AdminAddUserToGroupRequest request)
		{
			return null;
		}

		public virtual Task<AdminAddUserToGroupResponse> AdminAddUserToGroupAsync(AdminAddUserToGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminConfirmSignUpResponse AdminConfirmSignUp(AdminConfirmSignUpRequest request)
		{
			return null;
		}

		public virtual Task<AdminConfirmSignUpResponse> AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminCreateUserResponse AdminCreateUser(AdminCreateUserRequest request)
		{
			return null;
		}

		public virtual Task<AdminCreateUserResponse> AdminCreateUserAsync(AdminCreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminDeleteUserResponse AdminDeleteUser(AdminDeleteUserRequest request)
		{
			return null;
		}

		public virtual Task<AdminDeleteUserResponse> AdminDeleteUserAsync(AdminDeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminDeleteUserAttributesResponse AdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request)
		{
			return null;
		}

		public virtual Task<AdminDeleteUserAttributesResponse> AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminDisableProviderForUserResponse AdminDisableProviderForUser(AdminDisableProviderForUserRequest request)
		{
			return null;
		}

		public virtual Task<AdminDisableProviderForUserResponse> AdminDisableProviderForUserAsync(AdminDisableProviderForUserRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminDisableUserResponse AdminDisableUser(AdminDisableUserRequest request)
		{
			return null;
		}

		public virtual Task<AdminDisableUserResponse> AdminDisableUserAsync(AdminDisableUserRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminEnableUserResponse AdminEnableUser(AdminEnableUserRequest request)
		{
			return null;
		}

		public virtual Task<AdminEnableUserResponse> AdminEnableUserAsync(AdminEnableUserRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminForgetDeviceResponse AdminForgetDevice(AdminForgetDeviceRequest request)
		{
			return null;
		}

		public virtual Task<AdminForgetDeviceResponse> AdminForgetDeviceAsync(AdminForgetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminGetDeviceResponse AdminGetDevice(AdminGetDeviceRequest request)
		{
			return null;
		}

		public virtual Task<AdminGetDeviceResponse> AdminGetDeviceAsync(AdminGetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminGetUserResponse AdminGetUser(AdminGetUserRequest request)
		{
			return null;
		}

		public virtual Task<AdminGetUserResponse> AdminGetUserAsync(AdminGetUserRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminInitiateAuthResponse AdminInitiateAuth(AdminInitiateAuthRequest request)
		{
			return null;
		}

		public virtual Task<AdminInitiateAuthResponse> AdminInitiateAuthAsync(AdminInitiateAuthRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminLinkProviderForUserResponse AdminLinkProviderForUser(AdminLinkProviderForUserRequest request)
		{
			return null;
		}

		public virtual Task<AdminLinkProviderForUserResponse> AdminLinkProviderForUserAsync(AdminLinkProviderForUserRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminListDevicesResponse AdminListDevices(AdminListDevicesRequest request)
		{
			return null;
		}

		public virtual Task<AdminListDevicesResponse> AdminListDevicesAsync(AdminListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminListGroupsForUserResponse AdminListGroupsForUser(AdminListGroupsForUserRequest request)
		{
			return null;
		}

		public virtual Task<AdminListGroupsForUserResponse> AdminListGroupsForUserAsync(AdminListGroupsForUserRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminListUserAuthEventsResponse AdminListUserAuthEvents(AdminListUserAuthEventsRequest request)
		{
			return null;
		}

		public virtual Task<AdminListUserAuthEventsResponse> AdminListUserAuthEventsAsync(AdminListUserAuthEventsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminRemoveUserFromGroupResponse AdminRemoveUserFromGroup(AdminRemoveUserFromGroupRequest request)
		{
			return null;
		}

		public virtual Task<AdminRemoveUserFromGroupResponse> AdminRemoveUserFromGroupAsync(AdminRemoveUserFromGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminResetUserPasswordResponse AdminResetUserPassword(AdminResetUserPasswordRequest request)
		{
			return null;
		}

		public virtual Task<AdminResetUserPasswordResponse> AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminRespondToAuthChallengeResponse AdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request)
		{
			return null;
		}

		public virtual Task<AdminRespondToAuthChallengeResponse> AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminSetUserMFAPreferenceResponse AdminSetUserMFAPreference(AdminSetUserMFAPreferenceRequest request)
		{
			return null;
		}

		public virtual Task<AdminSetUserMFAPreferenceResponse> AdminSetUserMFAPreferenceAsync(AdminSetUserMFAPreferenceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminSetUserPasswordResponse AdminSetUserPassword(AdminSetUserPasswordRequest request)
		{
			return null;
		}

		public virtual Task<AdminSetUserPasswordResponse> AdminSetUserPasswordAsync(AdminSetUserPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminSetUserSettingsResponse AdminSetUserSettings(AdminSetUserSettingsRequest request)
		{
			return null;
		}

		public virtual Task<AdminSetUserSettingsResponse> AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminUpdateAuthEventFeedbackResponse AdminUpdateAuthEventFeedback(AdminUpdateAuthEventFeedbackRequest request)
		{
			return null;
		}

		public virtual Task<AdminUpdateAuthEventFeedbackResponse> AdminUpdateAuthEventFeedbackAsync(AdminUpdateAuthEventFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminUpdateDeviceStatusResponse AdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request)
		{
			return null;
		}

		public virtual Task<AdminUpdateDeviceStatusResponse> AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminUpdateUserAttributesResponse AdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request)
		{
			return null;
		}

		public virtual Task<AdminUpdateUserAttributesResponse> AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AdminUserGlobalSignOutResponse AdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request)
		{
			return null;
		}

		public virtual Task<AdminUserGlobalSignOutResponse> AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual AssociateSoftwareTokenResponse AssociateSoftwareToken(AssociateSoftwareTokenRequest request)
		{
			return null;
		}

		public virtual Task<AssociateSoftwareTokenResponse> AssociateSoftwareTokenAsync(AssociateSoftwareTokenRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
		{
			return null;
		}

		public virtual Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ConfirmDeviceResponse ConfirmDevice(ConfirmDeviceRequest request)
		{
			return null;
		}

		public virtual Task<ConfirmDeviceResponse> ConfirmDeviceAsync(ConfirmDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ConfirmForgotPasswordResponse ConfirmForgotPassword(ConfirmForgotPasswordRequest request)
		{
			return null;
		}

		public virtual Task<ConfirmForgotPasswordResponse> ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ConfirmSignUpResponse ConfirmSignUp(ConfirmSignUpRequest request)
		{
			return null;
		}

		public virtual Task<ConfirmSignUpResponse> ConfirmSignUpAsync(ConfirmSignUpRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
		{
			return null;
		}

		public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request)
		{
			return null;
		}

		public virtual Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(CreateIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual CreateResourceServerResponse CreateResourceServer(CreateResourceServerRequest request)
		{
			return null;
		}

		public virtual Task<CreateResourceServerResponse> CreateResourceServerAsync(CreateResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual CreateUserImportJobResponse CreateUserImportJob(CreateUserImportJobRequest request)
		{
			return null;
		}

		public virtual Task<CreateUserImportJobResponse> CreateUserImportJobAsync(CreateUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request)
		{
			return null;
		}

		public virtual Task<CreateUserPoolResponse> CreateUserPoolAsync(CreateUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request)
		{
			return null;
		}

		public virtual Task<CreateUserPoolClientResponse> CreateUserPoolClientAsync(CreateUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual CreateUserPoolDomainResponse CreateUserPoolDomain(CreateUserPoolDomainRequest request)
		{
			return null;
		}

		public virtual Task<CreateUserPoolDomainResponse> CreateUserPoolDomainAsync(CreateUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
		{
			return null;
		}

		public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request)
		{
			return null;
		}

		public virtual Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteResourceServerResponse DeleteResourceServer(DeleteResourceServerRequest request)
		{
			return null;
		}

		public virtual Task<DeleteResourceServerResponse> DeleteResourceServerAsync(DeleteResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
		{
			return null;
		}

		public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteUserAttributesResponse DeleteUserAttributes(DeleteUserAttributesRequest request)
		{
			return null;
		}

		public virtual Task<DeleteUserAttributesResponse> DeleteUserAttributesAsync(DeleteUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request)
		{
			return null;
		}

		public virtual Task<DeleteUserPoolResponse> DeleteUserPoolAsync(DeleteUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request)
		{
			return null;
		}

		public virtual Task<DeleteUserPoolClientResponse> DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteUserPoolDomainResponse DeleteUserPoolDomain(DeleteUserPoolDomainRequest request)
		{
			return null;
		}

		public virtual Task<DeleteUserPoolDomainResponse> DeleteUserPoolDomainAsync(DeleteUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeIdentityProviderResponse DescribeIdentityProvider(DescribeIdentityProviderRequest request)
		{
			return null;
		}

		public virtual Task<DescribeIdentityProviderResponse> DescribeIdentityProviderAsync(DescribeIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeResourceServerResponse DescribeResourceServer(DescribeResourceServerRequest request)
		{
			return null;
		}

		public virtual Task<DescribeResourceServerResponse> DescribeResourceServerAsync(DescribeResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeRiskConfigurationResponse DescribeRiskConfiguration(DescribeRiskConfigurationRequest request)
		{
			return null;
		}

		public virtual Task<DescribeRiskConfigurationResponse> DescribeRiskConfigurationAsync(DescribeRiskConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeUserImportJobResponse DescribeUserImportJob(DescribeUserImportJobRequest request)
		{
			return null;
		}

		public virtual Task<DescribeUserImportJobResponse> DescribeUserImportJobAsync(DescribeUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeUserPoolResponse DescribeUserPool(DescribeUserPoolRequest request)
		{
			return null;
		}

		public virtual Task<DescribeUserPoolResponse> DescribeUserPoolAsync(DescribeUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeUserPoolClientResponse DescribeUserPoolClient(DescribeUserPoolClientRequest request)
		{
			return null;
		}

		public virtual Task<DescribeUserPoolClientResponse> DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeUserPoolDomainResponse DescribeUserPoolDomain(DescribeUserPoolDomainRequest request)
		{
			return null;
		}

		public virtual Task<DescribeUserPoolDomainResponse> DescribeUserPoolDomainAsync(DescribeUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ForgetDeviceResponse ForgetDevice(ForgetDeviceRequest request)
		{
			return null;
		}

		public virtual Task<ForgetDeviceResponse> ForgetDeviceAsync(ForgetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ForgotPasswordResponse ForgotPassword(ForgotPasswordRequest request)
		{
			return null;
		}

		public virtual Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetCSVHeaderResponse GetCSVHeader(GetCSVHeaderRequest request)
		{
			return null;
		}

		public virtual Task<GetCSVHeaderResponse> GetCSVHeaderAsync(GetCSVHeaderRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
		{
			return null;
		}

		public virtual Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
		{
			return null;
		}

		public virtual Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetIdentityProviderByIdentifierResponse GetIdentityProviderByIdentifier(GetIdentityProviderByIdentifierRequest request)
		{
			return null;
		}

		public virtual Task<GetIdentityProviderByIdentifierResponse> GetIdentityProviderByIdentifierAsync(GetIdentityProviderByIdentifierRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetSigningCertificateResponse GetSigningCertificate(GetSigningCertificateRequest request)
		{
			return null;
		}

		public virtual Task<GetSigningCertificateResponse> GetSigningCertificateAsync(GetSigningCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetUICustomizationResponse GetUICustomization(GetUICustomizationRequest request)
		{
			return null;
		}

		public virtual Task<GetUICustomizationResponse> GetUICustomizationAsync(GetUICustomizationRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetUserResponse GetUser(GetUserRequest request)
		{
			return null;
		}

		public virtual Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetUserAttributeVerificationCodeResponse GetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request)
		{
			return null;
		}

		public virtual Task<GetUserAttributeVerificationCodeResponse> GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetUserPoolMfaConfigResponse GetUserPoolMfaConfig(GetUserPoolMfaConfigRequest request)
		{
			return null;
		}

		public virtual Task<GetUserPoolMfaConfigResponse> GetUserPoolMfaConfigAsync(GetUserPoolMfaConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GlobalSignOutResponse GlobalSignOut(GlobalSignOutRequest request)
		{
			return null;
		}

		public virtual Task<GlobalSignOutResponse> GlobalSignOutAsync(GlobalSignOutRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual InitiateAuthResponse InitiateAuth(InitiateAuthRequest request)
		{
			return null;
		}

		public virtual Task<InitiateAuthResponse> InitiateAuthAsync(InitiateAuthRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
		{
			return null;
		}

		public virtual Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
		{
			return null;
		}

		public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request)
		{
			return null;
		}

		public virtual Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListResourceServersResponse ListResourceServers(ListResourceServersRequest request)
		{
			return null;
		}

		public virtual Task<ListResourceServersResponse> ListResourceServersAsync(ListResourceServersRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
		{
			return null;
		}

		public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListUserImportJobsResponse ListUserImportJobs(ListUserImportJobsRequest request)
		{
			return null;
		}

		public virtual Task<ListUserImportJobsResponse> ListUserImportJobsAsync(ListUserImportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request)
		{
			return null;
		}

		public virtual Task<ListUserPoolClientsResponse> ListUserPoolClientsAsync(ListUserPoolClientsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request)
		{
			return null;
		}

		public virtual Task<ListUserPoolsResponse> ListUserPoolsAsync(ListUserPoolsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
		{
			return null;
		}

		public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListUsersInGroupResponse ListUsersInGroup(ListUsersInGroupRequest request)
		{
			return null;
		}

		public virtual Task<ListUsersInGroupResponse> ListUsersInGroupAsync(ListUsersInGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ResendConfirmationCodeResponse ResendConfirmationCode(ResendConfirmationCodeRequest request)
		{
			return null;
		}

		public virtual Task<ResendConfirmationCodeResponse> ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual RespondToAuthChallengeResponse RespondToAuthChallenge(RespondToAuthChallengeRequest request)
		{
			return null;
		}

		public virtual Task<RespondToAuthChallengeResponse> RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SetRiskConfigurationResponse SetRiskConfiguration(SetRiskConfigurationRequest request)
		{
			return null;
		}

		public virtual Task<SetRiskConfigurationResponse> SetRiskConfigurationAsync(SetRiskConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SetUICustomizationResponse SetUICustomization(SetUICustomizationRequest request)
		{
			return null;
		}

		public virtual Task<SetUICustomizationResponse> SetUICustomizationAsync(SetUICustomizationRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SetUserMFAPreferenceResponse SetUserMFAPreference(SetUserMFAPreferenceRequest request)
		{
			return null;
		}

		public virtual Task<SetUserMFAPreferenceResponse> SetUserMFAPreferenceAsync(SetUserMFAPreferenceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SetUserPoolMfaConfigResponse SetUserPoolMfaConfig(SetUserPoolMfaConfigRequest request)
		{
			return null;
		}

		public virtual Task<SetUserPoolMfaConfigResponse> SetUserPoolMfaConfigAsync(SetUserPoolMfaConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request)
		{
			return null;
		}

		public virtual Task<SetUserSettingsResponse> SetUserSettingsAsync(SetUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SignUpResponse SignUp(SignUpRequest request)
		{
			return null;
		}

		public virtual Task<SignUpResponse> SignUpAsync(SignUpRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual StartUserImportJobResponse StartUserImportJob(StartUserImportJobRequest request)
		{
			return null;
		}

		public virtual Task<StartUserImportJobResponse> StartUserImportJobAsync(StartUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual StopUserImportJobResponse StopUserImportJob(StopUserImportJobRequest request)
		{
			return null;
		}

		public virtual Task<StopUserImportJobResponse> StopUserImportJobAsync(StopUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual TagResourceResponse TagResource(TagResourceRequest request)
		{
			return null;
		}

		public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
		{
			return null;
		}

		public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateAuthEventFeedbackResponse UpdateAuthEventFeedback(UpdateAuthEventFeedbackRequest request)
		{
			return null;
		}

		public virtual Task<UpdateAuthEventFeedbackResponse> UpdateAuthEventFeedbackAsync(UpdateAuthEventFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateDeviceStatusResponse UpdateDeviceStatus(UpdateDeviceStatusRequest request)
		{
			return null;
		}

		public virtual Task<UpdateDeviceStatusResponse> UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
		{
			return null;
		}

		public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request)
		{
			return null;
		}

		public virtual Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateResourceServerResponse UpdateResourceServer(UpdateResourceServerRequest request)
		{
			return null;
		}

		public virtual Task<UpdateResourceServerResponse> UpdateResourceServerAsync(UpdateResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateUserAttributesResponse UpdateUserAttributes(UpdateUserAttributesRequest request)
		{
			return null;
		}

		public virtual Task<UpdateUserAttributesResponse> UpdateUserAttributesAsync(UpdateUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request)
		{
			return null;
		}

		public virtual Task<UpdateUserPoolResponse> UpdateUserPoolAsync(UpdateUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request)
		{
			return null;
		}

		public virtual Task<UpdateUserPoolClientResponse> UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateUserPoolDomainResponse UpdateUserPoolDomain(UpdateUserPoolDomainRequest request)
		{
			return null;
		}

		public virtual Task<UpdateUserPoolDomainResponse> UpdateUserPoolDomainAsync(UpdateUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual VerifySoftwareTokenResponse VerifySoftwareToken(VerifySoftwareTokenRequest request)
		{
			return null;
		}

		public virtual Task<VerifySoftwareTokenResponse> VerifySoftwareTokenAsync(VerifySoftwareTokenRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual VerifyUserAttributeResponse VerifyUserAttribute(VerifyUserAttributeRequest request)
		{
			return null;
		}

		public virtual Task<VerifyUserAttributeResponse> VerifyUserAttributeAsync(VerifyUserAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
