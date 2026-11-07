using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000027")]
	public interface IAmazonCognitoIdentityProvider : IAmazonService, IDisposable
	{
		[Token(Token = "0x6000169")]
		Task<AddCustomAttributesResponse> AddCustomAttributesAsync(AddCustomAttributesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600016A")]
		Task<AdminAddUserToGroupResponse> AdminAddUserToGroupAsync(AdminAddUserToGroupRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600016B")]
		Task<AdminConfirmSignUpResponse> AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600016C")]
		Task<AdminCreateUserResponse> AdminCreateUserAsync(AdminCreateUserRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600016D")]
		Task<AdminDeleteUserResponse> AdminDeleteUserAsync(AdminDeleteUserRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600016E")]
		Task<AdminDeleteUserAttributesResponse> AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600016F")]
		Task<AdminDisableProviderForUserResponse> AdminDisableProviderForUserAsync(AdminDisableProviderForUserRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000170")]
		Task<AdminDisableUserResponse> AdminDisableUserAsync(AdminDisableUserRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000171")]
		Task<AdminEnableUserResponse> AdminEnableUserAsync(AdminEnableUserRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000172")]
		Task<AdminForgetDeviceResponse> AdminForgetDeviceAsync(AdminForgetDeviceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000173")]
		Task<AdminGetDeviceResponse> AdminGetDeviceAsync(AdminGetDeviceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000174")]
		Task<AdminGetUserResponse> AdminGetUserAsync(AdminGetUserRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000175")]
		Task<AdminInitiateAuthResponse> AdminInitiateAuthAsync(AdminInitiateAuthRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000176")]
		Task<AdminLinkProviderForUserResponse> AdminLinkProviderForUserAsync(AdminLinkProviderForUserRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000177")]
		Task<AdminListDevicesResponse> AdminListDevicesAsync(AdminListDevicesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000178")]
		Task<AdminListGroupsForUserResponse> AdminListGroupsForUserAsync(AdminListGroupsForUserRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000179")]
		Task<AdminListUserAuthEventsResponse> AdminListUserAuthEventsAsync(AdminListUserAuthEventsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600017A")]
		Task<AdminRemoveUserFromGroupResponse> AdminRemoveUserFromGroupAsync(AdminRemoveUserFromGroupRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600017B")]
		Task<AdminResetUserPasswordResponse> AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600017C")]
		Task<AdminRespondToAuthChallengeResponse> AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600017D")]
		Task<AdminSetUserMFAPreferenceResponse> AdminSetUserMFAPreferenceAsync(AdminSetUserMFAPreferenceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600017E")]
		Task<AdminSetUserPasswordResponse> AdminSetUserPasswordAsync(AdminSetUserPasswordRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600017F")]
		Task<AdminSetUserSettingsResponse> AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000180")]
		Task<AdminUpdateAuthEventFeedbackResponse> AdminUpdateAuthEventFeedbackAsync(AdminUpdateAuthEventFeedbackRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000181")]
		Task<AdminUpdateDeviceStatusResponse> AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000182")]
		Task<AdminUpdateUserAttributesResponse> AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000183")]
		Task<AdminUserGlobalSignOutResponse> AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000184")]
		Task<AssociateSoftwareTokenResponse> AssociateSoftwareTokenAsync(AssociateSoftwareTokenRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000185")]
		Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000186")]
		Task<ConfirmDeviceResponse> ConfirmDeviceAsync(ConfirmDeviceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000187")]
		Task<ConfirmForgotPasswordResponse> ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000188")]
		Task<ConfirmSignUpResponse> ConfirmSignUpAsync(ConfirmSignUpRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000189")]
		Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600018A")]
		Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(CreateIdentityProviderRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600018B")]
		Task<CreateResourceServerResponse> CreateResourceServerAsync(CreateResourceServerRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600018C")]
		Task<CreateUserImportJobResponse> CreateUserImportJobAsync(CreateUserImportJobRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600018D")]
		Task<CreateUserPoolResponse> CreateUserPoolAsync(CreateUserPoolRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600018E")]
		Task<CreateUserPoolClientResponse> CreateUserPoolClientAsync(CreateUserPoolClientRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600018F")]
		Task<CreateUserPoolDomainResponse> CreateUserPoolDomainAsync(CreateUserPoolDomainRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000190")]
		Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000191")]
		Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000192")]
		Task<DeleteResourceServerResponse> DeleteResourceServerAsync(DeleteResourceServerRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000193")]
		Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000194")]
		Task<DeleteUserAttributesResponse> DeleteUserAttributesAsync(DeleteUserAttributesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000195")]
		Task<DeleteUserPoolResponse> DeleteUserPoolAsync(DeleteUserPoolRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000196")]
		Task<DeleteUserPoolClientResponse> DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000197")]
		Task<DeleteUserPoolDomainResponse> DeleteUserPoolDomainAsync(DeleteUserPoolDomainRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000198")]
		Task<DescribeIdentityProviderResponse> DescribeIdentityProviderAsync(DescribeIdentityProviderRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000199")]
		Task<DescribeResourceServerResponse> DescribeResourceServerAsync(DescribeResourceServerRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600019A")]
		Task<DescribeRiskConfigurationResponse> DescribeRiskConfigurationAsync(DescribeRiskConfigurationRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600019B")]
		Task<DescribeUserImportJobResponse> DescribeUserImportJobAsync(DescribeUserImportJobRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600019C")]
		Task<DescribeUserPoolResponse> DescribeUserPoolAsync(DescribeUserPoolRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600019D")]
		Task<DescribeUserPoolClientResponse> DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600019E")]
		Task<DescribeUserPoolDomainResponse> DescribeUserPoolDomainAsync(DescribeUserPoolDomainRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600019F")]
		Task<ForgetDeviceResponse> ForgetDeviceAsync(ForgetDeviceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001A0")]
		Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001A1")]
		Task<GetCSVHeaderResponse> GetCSVHeaderAsync(GetCSVHeaderRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001A2")]
		Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001A3")]
		Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001A4")]
		Task<GetIdentityProviderByIdentifierResponse> GetIdentityProviderByIdentifierAsync(GetIdentityProviderByIdentifierRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001A5")]
		Task<GetSigningCertificateResponse> GetSigningCertificateAsync(GetSigningCertificateRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001A6")]
		Task<GetUICustomizationResponse> GetUICustomizationAsync(GetUICustomizationRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001A7")]
		Task<GetUserResponse> GetUserAsync(GetUserRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001A8")]
		Task<GetUserAttributeVerificationCodeResponse> GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001A9")]
		Task<GetUserPoolMfaConfigResponse> GetUserPoolMfaConfigAsync(GetUserPoolMfaConfigRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001AA")]
		Task<GlobalSignOutResponse> GlobalSignOutAsync(GlobalSignOutRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001AB")]
		Task<InitiateAuthResponse> InitiateAuthAsync(InitiateAuthRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001AC")]
		Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001AD")]
		Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001AE")]
		Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001AF")]
		Task<ListResourceServersResponse> ListResourceServersAsync(ListResourceServersRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001B0")]
		Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001B1")]
		Task<ListUserImportJobsResponse> ListUserImportJobsAsync(ListUserImportJobsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001B2")]
		Task<ListUserPoolClientsResponse> ListUserPoolClientsAsync(ListUserPoolClientsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001B3")]
		Task<ListUserPoolsResponse> ListUserPoolsAsync(ListUserPoolsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001B4")]
		Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001B5")]
		Task<ListUsersInGroupResponse> ListUsersInGroupAsync(ListUsersInGroupRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001B6")]
		Task<ResendConfirmationCodeResponse> ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001B7")]
		Task<RespondToAuthChallengeResponse> RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001B8")]
		Task<SetRiskConfigurationResponse> SetRiskConfigurationAsync(SetRiskConfigurationRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001B9")]
		Task<SetUICustomizationResponse> SetUICustomizationAsync(SetUICustomizationRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001BA")]
		Task<SetUserMFAPreferenceResponse> SetUserMFAPreferenceAsync(SetUserMFAPreferenceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001BB")]
		Task<SetUserPoolMfaConfigResponse> SetUserPoolMfaConfigAsync(SetUserPoolMfaConfigRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001BC")]
		Task<SetUserSettingsResponse> SetUserSettingsAsync(SetUserSettingsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001BD")]
		Task<SignUpResponse> SignUpAsync(SignUpRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001BE")]
		Task<StartUserImportJobResponse> StartUserImportJobAsync(StartUserImportJobRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001BF")]
		Task<StopUserImportJobResponse> StopUserImportJobAsync(StopUserImportJobRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001C0")]
		Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001C1")]
		Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001C2")]
		Task<UpdateAuthEventFeedbackResponse> UpdateAuthEventFeedbackAsync(UpdateAuthEventFeedbackRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001C3")]
		Task<UpdateDeviceStatusResponse> UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001C4")]
		Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001C5")]
		Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001C6")]
		Task<UpdateResourceServerResponse> UpdateResourceServerAsync(UpdateResourceServerRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001C7")]
		Task<UpdateUserAttributesResponse> UpdateUserAttributesAsync(UpdateUserAttributesRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001C8")]
		Task<UpdateUserPoolResponse> UpdateUserPoolAsync(UpdateUserPoolRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001C9")]
		Task<UpdateUserPoolClientResponse> UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001CA")]
		Task<UpdateUserPoolDomainResponse> UpdateUserPoolDomainAsync(UpdateUserPoolDomainRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001CB")]
		Task<VerifySoftwareTokenResponse> VerifySoftwareTokenAsync(VerifySoftwareTokenRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60001CC")]
		Task<VerifyUserAttributeResponse> VerifyUserAttributeAsync(VerifyUserAttributeRequest request, [Optional] CancellationToken cancellationToken);
	}
}
