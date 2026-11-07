using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public interface IAmazonCognitoIdentityProvider : IAmazonService, IDisposable
	{
		Task<AddCustomAttributesResponse> AddCustomAttributesAsync(AddCustomAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminAddUserToGroupResponse> AdminAddUserToGroupAsync(AdminAddUserToGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminConfirmSignUpResponse> AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminCreateUserResponse> AdminCreateUserAsync(AdminCreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminDeleteUserResponse> AdminDeleteUserAsync(AdminDeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminDeleteUserAttributesResponse> AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminDisableProviderForUserResponse> AdminDisableProviderForUserAsync(AdminDisableProviderForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminDisableUserResponse> AdminDisableUserAsync(AdminDisableUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminEnableUserResponse> AdminEnableUserAsync(AdminEnableUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminForgetDeviceResponse> AdminForgetDeviceAsync(AdminForgetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminGetDeviceResponse> AdminGetDeviceAsync(AdminGetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminGetUserResponse> AdminGetUserAsync(AdminGetUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminInitiateAuthResponse> AdminInitiateAuthAsync(AdminInitiateAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminLinkProviderForUserResponse> AdminLinkProviderForUserAsync(AdminLinkProviderForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminListDevicesResponse> AdminListDevicesAsync(AdminListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminListGroupsForUserResponse> AdminListGroupsForUserAsync(AdminListGroupsForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminListUserAuthEventsResponse> AdminListUserAuthEventsAsync(AdminListUserAuthEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminRemoveUserFromGroupResponse> AdminRemoveUserFromGroupAsync(AdminRemoveUserFromGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminResetUserPasswordResponse> AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminRespondToAuthChallengeResponse> AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminSetUserMFAPreferenceResponse> AdminSetUserMFAPreferenceAsync(AdminSetUserMFAPreferenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminSetUserPasswordResponse> AdminSetUserPasswordAsync(AdminSetUserPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminSetUserSettingsResponse> AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminUpdateAuthEventFeedbackResponse> AdminUpdateAuthEventFeedbackAsync(AdminUpdateAuthEventFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminUpdateDeviceStatusResponse> AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminUpdateUserAttributesResponse> AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AdminUserGlobalSignOutResponse> AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<AssociateSoftwareTokenResponse> AssociateSoftwareTokenAsync(AssociateSoftwareTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ConfirmDeviceResponse> ConfirmDeviceAsync(ConfirmDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ConfirmForgotPasswordResponse> ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ConfirmSignUpResponse> ConfirmSignUpAsync(ConfirmSignUpRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(CreateIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<CreateResourceServerResponse> CreateResourceServerAsync(CreateResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<CreateUserImportJobResponse> CreateUserImportJobAsync(CreateUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<CreateUserPoolResponse> CreateUserPoolAsync(CreateUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<CreateUserPoolClientResponse> CreateUserPoolClientAsync(CreateUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<CreateUserPoolDomainResponse> CreateUserPoolDomainAsync(CreateUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteResourceServerResponse> DeleteResourceServerAsync(DeleteResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteUserAttributesResponse> DeleteUserAttributesAsync(DeleteUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteUserPoolResponse> DeleteUserPoolAsync(DeleteUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteUserPoolClientResponse> DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteUserPoolDomainResponse> DeleteUserPoolDomainAsync(DeleteUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeIdentityProviderResponse> DescribeIdentityProviderAsync(DescribeIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeResourceServerResponse> DescribeResourceServerAsync(DescribeResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeRiskConfigurationResponse> DescribeRiskConfigurationAsync(DescribeRiskConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeUserImportJobResponse> DescribeUserImportJobAsync(DescribeUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeUserPoolResponse> DescribeUserPoolAsync(DescribeUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeUserPoolClientResponse> DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeUserPoolDomainResponse> DescribeUserPoolDomainAsync(DescribeUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ForgetDeviceResponse> ForgetDeviceAsync(ForgetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetCSVHeaderResponse> GetCSVHeaderAsync(GetCSVHeaderRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetIdentityProviderByIdentifierResponse> GetIdentityProviderByIdentifierAsync(GetIdentityProviderByIdentifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetSigningCertificateResponse> GetSigningCertificateAsync(GetSigningCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetUICustomizationResponse> GetUICustomizationAsync(GetUICustomizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetUserAttributeVerificationCodeResponse> GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetUserPoolMfaConfigResponse> GetUserPoolMfaConfigAsync(GetUserPoolMfaConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GlobalSignOutResponse> GlobalSignOutAsync(GlobalSignOutRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<InitiateAuthResponse> InitiateAuthAsync(InitiateAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListResourceServersResponse> ListResourceServersAsync(ListResourceServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListUserImportJobsResponse> ListUserImportJobsAsync(ListUserImportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListUserPoolClientsResponse> ListUserPoolClientsAsync(ListUserPoolClientsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListUserPoolsResponse> ListUserPoolsAsync(ListUserPoolsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListUsersInGroupResponse> ListUsersInGroupAsync(ListUsersInGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ResendConfirmationCodeResponse> ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<RespondToAuthChallengeResponse> RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SetRiskConfigurationResponse> SetRiskConfigurationAsync(SetRiskConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SetUICustomizationResponse> SetUICustomizationAsync(SetUICustomizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SetUserMFAPreferenceResponse> SetUserMFAPreferenceAsync(SetUserMFAPreferenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SetUserPoolMfaConfigResponse> SetUserPoolMfaConfigAsync(SetUserPoolMfaConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SetUserSettingsResponse> SetUserSettingsAsync(SetUserSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SignUpResponse> SignUpAsync(SignUpRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<StartUserImportJobResponse> StartUserImportJobAsync(StartUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<StopUserImportJobResponse> StopUserImportJobAsync(StopUserImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateAuthEventFeedbackResponse> UpdateAuthEventFeedbackAsync(UpdateAuthEventFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateDeviceStatusResponse> UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateResourceServerResponse> UpdateResourceServerAsync(UpdateResourceServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateUserAttributesResponse> UpdateUserAttributesAsync(UpdateUserAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateUserPoolResponse> UpdateUserPoolAsync(UpdateUserPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateUserPoolClientResponse> UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateUserPoolDomainResponse> UpdateUserPoolDomainAsync(UpdateUserPoolDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<VerifySoftwareTokenResponse> VerifySoftwareTokenAsync(VerifySoftwareTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<VerifyUserAttributeResponse> VerifyUserAttributeAsync(VerifyUserAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
	}
}
