using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000026")]
	public class AmazonCognitoIdentityProviderClient : AmazonServiceClient, IAmazonCognitoIdentityProvider, IAmazonService, IDisposable
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IServiceMetadata serviceMetadata;

		[Token(Token = "0x17000004")]
		protected override IServiceMetadata ServiceMetadata
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x10C7DD8", Offset = "0x10C7DD8", VA = "0x10C7DD8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x10C7768", Offset = "0x10C7768", VA = "0x10C7768")]
		public AmazonCognitoIdentityProviderClient()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x10C78D4", Offset = "0x10C78D4", VA = "0x10C78D4")]
		public AmazonCognitoIdentityProviderClient(RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x10C7994", Offset = "0x10C7994", VA = "0x10C7994")]
		public AmazonCognitoIdentityProviderClient(AmazonCognitoIdentityProviderConfig config)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x10C7A14", Offset = "0x10C7A14", VA = "0x10C7A14")]
		public AmazonCognitoIdentityProviderClient(AWSCredentials credentials)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x10C7A8C", Offset = "0x10C7A8C", VA = "0x10C7A8C")]
		public AmazonCognitoIdentityProviderClient(AWSCredentials credentials, RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x10C7A84", Offset = "0x10C7A84", VA = "0x10C7A84")]
		public AmazonCognitoIdentityProviderClient(AWSCredentials credentials, AmazonCognitoIdentityProviderConfig clientConfig)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x10C7B20", Offset = "0x10C7B20", VA = "0x10C7B20")]
		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x10C7BA8", Offset = "0x10C7BA8", VA = "0x10C7BA8")]
		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x10C7BA0", Offset = "0x10C7BA0", VA = "0x10C7BA0")]
		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoIdentityProviderConfig clientConfig)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x10C7C44", Offset = "0x10C7C44", VA = "0x10C7C44")]
		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x10C7CD4", Offset = "0x10C7CD4", VA = "0x10C7CD4")]
		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x10C7CCC", Offset = "0x10C7CCC", VA = "0x10C7CCC")]
		public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoIdentityProviderConfig clientConfig)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x10C7D80", Offset = "0x10C7D80", VA = "0x10C7D80", Slot = "11")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x10C7E3C", Offset = "0x10C7E3C", VA = "0x10C7E3C", Slot = "10")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x10C7E44", Offset = "0x10C7E44", VA = "0x10C7E44", Slot = "114")]
		internal virtual AddCustomAttributesResponse AddCustomAttributes(AddCustomAttributesRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x10C7FDC", Offset = "0x10C7FDC", VA = "0x10C7FDC", Slot = "115")]
		public virtual Task<AddCustomAttributesResponse> AddCustomAttributesAsync(AddCustomAttributesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x10C817C", Offset = "0x10C817C", VA = "0x10C817C", Slot = "116")]
		internal virtual AdminAddUserToGroupResponse AdminAddUserToGroup(AdminAddUserToGroupRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x10C8314", Offset = "0x10C8314", VA = "0x10C8314", Slot = "117")]
		public virtual Task<AdminAddUserToGroupResponse> AdminAddUserToGroupAsync(AdminAddUserToGroupRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x10C84B4", Offset = "0x10C84B4", VA = "0x10C84B4", Slot = "118")]
		internal virtual AdminConfirmSignUpResponse AdminConfirmSignUp(AdminConfirmSignUpRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x10C864C", Offset = "0x10C864C", VA = "0x10C864C", Slot = "119")]
		public virtual Task<AdminConfirmSignUpResponse> AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x10C87EC", Offset = "0x10C87EC", VA = "0x10C87EC", Slot = "120")]
		internal virtual AdminCreateUserResponse AdminCreateUser(AdminCreateUserRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x10C8984", Offset = "0x10C8984", VA = "0x10C8984", Slot = "121")]
		public virtual Task<AdminCreateUserResponse> AdminCreateUserAsync(AdminCreateUserRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x10C8B24", Offset = "0x10C8B24", VA = "0x10C8B24", Slot = "122")]
		internal virtual AdminDeleteUserResponse AdminDeleteUser(AdminDeleteUserRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x10C8CBC", Offset = "0x10C8CBC", VA = "0x10C8CBC", Slot = "123")]
		public virtual Task<AdminDeleteUserResponse> AdminDeleteUserAsync(AdminDeleteUserRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x10C8E5C", Offset = "0x10C8E5C", VA = "0x10C8E5C", Slot = "124")]
		internal virtual AdminDeleteUserAttributesResponse AdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x10C8FF4", Offset = "0x10C8FF4", VA = "0x10C8FF4", Slot = "125")]
		public virtual Task<AdminDeleteUserAttributesResponse> AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x10C9194", Offset = "0x10C9194", VA = "0x10C9194", Slot = "126")]
		internal virtual AdminDisableProviderForUserResponse AdminDisableProviderForUser(AdminDisableProviderForUserRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x10C932C", Offset = "0x10C932C", VA = "0x10C932C", Slot = "127")]
		public virtual Task<AdminDisableProviderForUserResponse> AdminDisableProviderForUserAsync(AdminDisableProviderForUserRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x10C94CC", Offset = "0x10C94CC", VA = "0x10C94CC", Slot = "128")]
		internal virtual AdminDisableUserResponse AdminDisableUser(AdminDisableUserRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x10C9664", Offset = "0x10C9664", VA = "0x10C9664", Slot = "129")]
		public virtual Task<AdminDisableUserResponse> AdminDisableUserAsync(AdminDisableUserRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x10C9804", Offset = "0x10C9804", VA = "0x10C9804", Slot = "130")]
		internal virtual AdminEnableUserResponse AdminEnableUser(AdminEnableUserRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x10C999C", Offset = "0x10C999C", VA = "0x10C999C", Slot = "131")]
		public virtual Task<AdminEnableUserResponse> AdminEnableUserAsync(AdminEnableUserRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x10C9B3C", Offset = "0x10C9B3C", VA = "0x10C9B3C", Slot = "132")]
		internal virtual AdminForgetDeviceResponse AdminForgetDevice(AdminForgetDeviceRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x10C9CD4", Offset = "0x10C9CD4", VA = "0x10C9CD4", Slot = "133")]
		public virtual Task<AdminForgetDeviceResponse> AdminForgetDeviceAsync(AdminForgetDeviceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x10C9E74", Offset = "0x10C9E74", VA = "0x10C9E74", Slot = "134")]
		internal virtual AdminGetDeviceResponse AdminGetDevice(AdminGetDeviceRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x10CA00C", Offset = "0x10CA00C", VA = "0x10CA00C", Slot = "135")]
		public virtual Task<AdminGetDeviceResponse> AdminGetDeviceAsync(AdminGetDeviceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x10CA1AC", Offset = "0x10CA1AC", VA = "0x10CA1AC", Slot = "136")]
		internal virtual AdminGetUserResponse AdminGetUser(AdminGetUserRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x10CA344", Offset = "0x10CA344", VA = "0x10CA344", Slot = "137")]
		public virtual Task<AdminGetUserResponse> AdminGetUserAsync(AdminGetUserRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x10CA4E4", Offset = "0x10CA4E4", VA = "0x10CA4E4", Slot = "138")]
		internal virtual AdminInitiateAuthResponse AdminInitiateAuth(AdminInitiateAuthRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x10CA67C", Offset = "0x10CA67C", VA = "0x10CA67C", Slot = "139")]
		public virtual Task<AdminInitiateAuthResponse> AdminInitiateAuthAsync(AdminInitiateAuthRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x10CA81C", Offset = "0x10CA81C", VA = "0x10CA81C", Slot = "140")]
		internal virtual AdminLinkProviderForUserResponse AdminLinkProviderForUser(AdminLinkProviderForUserRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x10CA9B4", Offset = "0x10CA9B4", VA = "0x10CA9B4", Slot = "141")]
		public virtual Task<AdminLinkProviderForUserResponse> AdminLinkProviderForUserAsync(AdminLinkProviderForUserRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x10CAB54", Offset = "0x10CAB54", VA = "0x10CAB54", Slot = "142")]
		internal virtual AdminListDevicesResponse AdminListDevices(AdminListDevicesRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x10CACEC", Offset = "0x10CACEC", VA = "0x10CACEC", Slot = "143")]
		public virtual Task<AdminListDevicesResponse> AdminListDevicesAsync(AdminListDevicesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x10CAE8C", Offset = "0x10CAE8C", VA = "0x10CAE8C", Slot = "144")]
		internal virtual AdminListGroupsForUserResponse AdminListGroupsForUser(AdminListGroupsForUserRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x10CB024", Offset = "0x10CB024", VA = "0x10CB024", Slot = "145")]
		public virtual Task<AdminListGroupsForUserResponse> AdminListGroupsForUserAsync(AdminListGroupsForUserRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x10CB1C4", Offset = "0x10CB1C4", VA = "0x10CB1C4", Slot = "146")]
		internal virtual AdminListUserAuthEventsResponse AdminListUserAuthEvents(AdminListUserAuthEventsRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x10CB35C", Offset = "0x10CB35C", VA = "0x10CB35C", Slot = "147")]
		public virtual Task<AdminListUserAuthEventsResponse> AdminListUserAuthEventsAsync(AdminListUserAuthEventsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x10CB4FC", Offset = "0x10CB4FC", VA = "0x10CB4FC", Slot = "148")]
		internal virtual AdminRemoveUserFromGroupResponse AdminRemoveUserFromGroup(AdminRemoveUserFromGroupRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x10CB694", Offset = "0x10CB694", VA = "0x10CB694", Slot = "149")]
		public virtual Task<AdminRemoveUserFromGroupResponse> AdminRemoveUserFromGroupAsync(AdminRemoveUserFromGroupRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x10CB834", Offset = "0x10CB834", VA = "0x10CB834", Slot = "150")]
		internal virtual AdminResetUserPasswordResponse AdminResetUserPassword(AdminResetUserPasswordRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x10CB9CC", Offset = "0x10CB9CC", VA = "0x10CB9CC", Slot = "151")]
		public virtual Task<AdminResetUserPasswordResponse> AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x10CBB6C", Offset = "0x10CBB6C", VA = "0x10CBB6C", Slot = "152")]
		internal virtual AdminRespondToAuthChallengeResponse AdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x10CBD04", Offset = "0x10CBD04", VA = "0x10CBD04", Slot = "153")]
		public virtual Task<AdminRespondToAuthChallengeResponse> AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x10CBEA4", Offset = "0x10CBEA4", VA = "0x10CBEA4", Slot = "154")]
		internal virtual AdminSetUserMFAPreferenceResponse AdminSetUserMFAPreference(AdminSetUserMFAPreferenceRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x10CC03C", Offset = "0x10CC03C", VA = "0x10CC03C", Slot = "155")]
		public virtual Task<AdminSetUserMFAPreferenceResponse> AdminSetUserMFAPreferenceAsync(AdminSetUserMFAPreferenceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x10CC1DC", Offset = "0x10CC1DC", VA = "0x10CC1DC", Slot = "156")]
		internal virtual AdminSetUserPasswordResponse AdminSetUserPassword(AdminSetUserPasswordRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x10CC374", Offset = "0x10CC374", VA = "0x10CC374", Slot = "157")]
		public virtual Task<AdminSetUserPasswordResponse> AdminSetUserPasswordAsync(AdminSetUserPasswordRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x10CC514", Offset = "0x10CC514", VA = "0x10CC514", Slot = "158")]
		internal virtual AdminSetUserSettingsResponse AdminSetUserSettings(AdminSetUserSettingsRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x10CC6AC", Offset = "0x10CC6AC", VA = "0x10CC6AC", Slot = "159")]
		public virtual Task<AdminSetUserSettingsResponse> AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x10CC84C", Offset = "0x10CC84C", VA = "0x10CC84C", Slot = "160")]
		internal virtual AdminUpdateAuthEventFeedbackResponse AdminUpdateAuthEventFeedback(AdminUpdateAuthEventFeedbackRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x10CC9E4", Offset = "0x10CC9E4", VA = "0x10CC9E4", Slot = "161")]
		public virtual Task<AdminUpdateAuthEventFeedbackResponse> AdminUpdateAuthEventFeedbackAsync(AdminUpdateAuthEventFeedbackRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x10CCB84", Offset = "0x10CCB84", VA = "0x10CCB84", Slot = "162")]
		internal virtual AdminUpdateDeviceStatusResponse AdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x10CCD1C", Offset = "0x10CCD1C", VA = "0x10CCD1C", Slot = "163")]
		public virtual Task<AdminUpdateDeviceStatusResponse> AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x10CCEBC", Offset = "0x10CCEBC", VA = "0x10CCEBC", Slot = "164")]
		internal virtual AdminUpdateUserAttributesResponse AdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x10CD054", Offset = "0x10CD054", VA = "0x10CD054", Slot = "165")]
		public virtual Task<AdminUpdateUserAttributesResponse> AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x10CD1F4", Offset = "0x10CD1F4", VA = "0x10CD1F4", Slot = "166")]
		internal virtual AdminUserGlobalSignOutResponse AdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x10CD38C", Offset = "0x10CD38C", VA = "0x10CD38C", Slot = "167")]
		public virtual Task<AdminUserGlobalSignOutResponse> AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x10CD52C", Offset = "0x10CD52C", VA = "0x10CD52C", Slot = "168")]
		internal virtual AssociateSoftwareTokenResponse AssociateSoftwareToken(AssociateSoftwareTokenRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x10CD6C4", Offset = "0x10CD6C4", VA = "0x10CD6C4", Slot = "169")]
		public virtual Task<AssociateSoftwareTokenResponse> AssociateSoftwareTokenAsync(AssociateSoftwareTokenRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x10CD864", Offset = "0x10CD864", VA = "0x10CD864", Slot = "170")]
		internal virtual ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x10CD9FC", Offset = "0x10CD9FC", VA = "0x10CD9FC", Slot = "171")]
		public virtual Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x10CDB9C", Offset = "0x10CDB9C", VA = "0x10CDB9C", Slot = "172")]
		internal virtual ConfirmDeviceResponse ConfirmDevice(ConfirmDeviceRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x10CDD34", Offset = "0x10CDD34", VA = "0x10CDD34", Slot = "173")]
		public virtual Task<ConfirmDeviceResponse> ConfirmDeviceAsync(ConfirmDeviceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x10CDED4", Offset = "0x10CDED4", VA = "0x10CDED4", Slot = "174")]
		internal virtual ConfirmForgotPasswordResponse ConfirmForgotPassword(ConfirmForgotPasswordRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x10CE06C", Offset = "0x10CE06C", VA = "0x10CE06C", Slot = "175")]
		public virtual Task<ConfirmForgotPasswordResponse> ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x10CE20C", Offset = "0x10CE20C", VA = "0x10CE20C", Slot = "176")]
		internal virtual ConfirmSignUpResponse ConfirmSignUp(ConfirmSignUpRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x10CE3A4", Offset = "0x10CE3A4", VA = "0x10CE3A4", Slot = "177")]
		public virtual Task<ConfirmSignUpResponse> ConfirmSignUpAsync(ConfirmSignUpRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x10CE544", Offset = "0x10CE544", VA = "0x10CE544", Slot = "178")]
		internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x10CE6DC", Offset = "0x10CE6DC", VA = "0x10CE6DC", Slot = "179")]
		public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x10CE87C", Offset = "0x10CE87C", VA = "0x10CE87C", Slot = "180")]
		internal virtual CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x10CEA14", Offset = "0x10CEA14", VA = "0x10CEA14", Slot = "181")]
		public virtual Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(CreateIdentityProviderRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x10CEBB4", Offset = "0x10CEBB4", VA = "0x10CEBB4", Slot = "182")]
		internal virtual CreateResourceServerResponse CreateResourceServer(CreateResourceServerRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x10CED4C", Offset = "0x10CED4C", VA = "0x10CED4C", Slot = "183")]
		public virtual Task<CreateResourceServerResponse> CreateResourceServerAsync(CreateResourceServerRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x10CEEEC", Offset = "0x10CEEEC", VA = "0x10CEEEC", Slot = "184")]
		internal virtual CreateUserImportJobResponse CreateUserImportJob(CreateUserImportJobRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x10CF084", Offset = "0x10CF084", VA = "0x10CF084", Slot = "185")]
		public virtual Task<CreateUserImportJobResponse> CreateUserImportJobAsync(CreateUserImportJobRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x10CF224", Offset = "0x10CF224", VA = "0x10CF224", Slot = "186")]
		internal virtual CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x10CF3BC", Offset = "0x10CF3BC", VA = "0x10CF3BC", Slot = "187")]
		public virtual Task<CreateUserPoolResponse> CreateUserPoolAsync(CreateUserPoolRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x10CF55C", Offset = "0x10CF55C", VA = "0x10CF55C", Slot = "188")]
		internal virtual CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x10CF6F4", Offset = "0x10CF6F4", VA = "0x10CF6F4", Slot = "189")]
		public virtual Task<CreateUserPoolClientResponse> CreateUserPoolClientAsync(CreateUserPoolClientRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x10CF894", Offset = "0x10CF894", VA = "0x10CF894", Slot = "190")]
		internal virtual CreateUserPoolDomainResponse CreateUserPoolDomain(CreateUserPoolDomainRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x10CFA2C", Offset = "0x10CFA2C", VA = "0x10CFA2C", Slot = "191")]
		public virtual Task<CreateUserPoolDomainResponse> CreateUserPoolDomainAsync(CreateUserPoolDomainRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x10CFBCC", Offset = "0x10CFBCC", VA = "0x10CFBCC", Slot = "192")]
		internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x10CFD64", Offset = "0x10CFD64", VA = "0x10CFD64", Slot = "193")]
		public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x10CFF04", Offset = "0x10CFF04", VA = "0x10CFF04", Slot = "194")]
		internal virtual DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x10D009C", Offset = "0x10D009C", VA = "0x10D009C", Slot = "195")]
		public virtual Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x10D023C", Offset = "0x10D023C", VA = "0x10D023C", Slot = "196")]
		internal virtual DeleteResourceServerResponse DeleteResourceServer(DeleteResourceServerRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x10D03D4", Offset = "0x10D03D4", VA = "0x10D03D4", Slot = "197")]
		public virtual Task<DeleteResourceServerResponse> DeleteResourceServerAsync(DeleteResourceServerRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x10D0574", Offset = "0x10D0574", VA = "0x10D0574", Slot = "198")]
		internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x10D070C", Offset = "0x10D070C", VA = "0x10D070C", Slot = "199")]
		public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x10D08AC", Offset = "0x10D08AC", VA = "0x10D08AC", Slot = "200")]
		internal virtual DeleteUserAttributesResponse DeleteUserAttributes(DeleteUserAttributesRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x10D0A44", Offset = "0x10D0A44", VA = "0x10D0A44", Slot = "201")]
		public virtual Task<DeleteUserAttributesResponse> DeleteUserAttributesAsync(DeleteUserAttributesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x10D0BE4", Offset = "0x10D0BE4", VA = "0x10D0BE4", Slot = "202")]
		internal virtual DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x10D0D7C", Offset = "0x10D0D7C", VA = "0x10D0D7C", Slot = "203")]
		public virtual Task<DeleteUserPoolResponse> DeleteUserPoolAsync(DeleteUserPoolRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x10D0F1C", Offset = "0x10D0F1C", VA = "0x10D0F1C", Slot = "204")]
		internal virtual DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x10D10B4", Offset = "0x10D10B4", VA = "0x10D10B4", Slot = "205")]
		public virtual Task<DeleteUserPoolClientResponse> DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x10D1254", Offset = "0x10D1254", VA = "0x10D1254", Slot = "206")]
		internal virtual DeleteUserPoolDomainResponse DeleteUserPoolDomain(DeleteUserPoolDomainRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x10D13EC", Offset = "0x10D13EC", VA = "0x10D13EC", Slot = "207")]
		public virtual Task<DeleteUserPoolDomainResponse> DeleteUserPoolDomainAsync(DeleteUserPoolDomainRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x10D158C", Offset = "0x10D158C", VA = "0x10D158C", Slot = "208")]
		internal virtual DescribeIdentityProviderResponse DescribeIdentityProvider(DescribeIdentityProviderRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x10D1724", Offset = "0x10D1724", VA = "0x10D1724", Slot = "209")]
		public virtual Task<DescribeIdentityProviderResponse> DescribeIdentityProviderAsync(DescribeIdentityProviderRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x10D18C4", Offset = "0x10D18C4", VA = "0x10D18C4", Slot = "210")]
		internal virtual DescribeResourceServerResponse DescribeResourceServer(DescribeResourceServerRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x10D1A5C", Offset = "0x10D1A5C", VA = "0x10D1A5C", Slot = "211")]
		public virtual Task<DescribeResourceServerResponse> DescribeResourceServerAsync(DescribeResourceServerRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x10D1BFC", Offset = "0x10D1BFC", VA = "0x10D1BFC", Slot = "212")]
		internal virtual DescribeRiskConfigurationResponse DescribeRiskConfiguration(DescribeRiskConfigurationRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x10D1D94", Offset = "0x10D1D94", VA = "0x10D1D94", Slot = "213")]
		public virtual Task<DescribeRiskConfigurationResponse> DescribeRiskConfigurationAsync(DescribeRiskConfigurationRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x10D1F34", Offset = "0x10D1F34", VA = "0x10D1F34", Slot = "214")]
		internal virtual DescribeUserImportJobResponse DescribeUserImportJob(DescribeUserImportJobRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x10D20CC", Offset = "0x10D20CC", VA = "0x10D20CC", Slot = "215")]
		public virtual Task<DescribeUserImportJobResponse> DescribeUserImportJobAsync(DescribeUserImportJobRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x10D226C", Offset = "0x10D226C", VA = "0x10D226C", Slot = "216")]
		internal virtual DescribeUserPoolResponse DescribeUserPool(DescribeUserPoolRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x10D2404", Offset = "0x10D2404", VA = "0x10D2404", Slot = "217")]
		public virtual Task<DescribeUserPoolResponse> DescribeUserPoolAsync(DescribeUserPoolRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x10D25A4", Offset = "0x10D25A4", VA = "0x10D25A4", Slot = "218")]
		internal virtual DescribeUserPoolClientResponse DescribeUserPoolClient(DescribeUserPoolClientRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x10D273C", Offset = "0x10D273C", VA = "0x10D273C", Slot = "219")]
		public virtual Task<DescribeUserPoolClientResponse> DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x10D28DC", Offset = "0x10D28DC", VA = "0x10D28DC", Slot = "220")]
		internal virtual DescribeUserPoolDomainResponse DescribeUserPoolDomain(DescribeUserPoolDomainRequest request)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x10D2A74", Offset = "0x10D2A74", VA = "0x10D2A74", Slot = "221")]
		public virtual Task<DescribeUserPoolDomainResponse> DescribeUserPoolDomainAsync(DescribeUserPoolDomainRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x10D2C14", Offset = "0x10D2C14", VA = "0x10D2C14", Slot = "222")]
		internal virtual ForgetDeviceResponse ForgetDevice(ForgetDeviceRequest request)
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x10D2DAC", Offset = "0x10D2DAC", VA = "0x10D2DAC", Slot = "223")]
		public virtual Task<ForgetDeviceResponse> ForgetDeviceAsync(ForgetDeviceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x10D2F4C", Offset = "0x10D2F4C", VA = "0x10D2F4C", Slot = "224")]
		internal virtual ForgotPasswordResponse ForgotPassword(ForgotPasswordRequest request)
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x10D30E4", Offset = "0x10D30E4", VA = "0x10D30E4", Slot = "225")]
		public virtual Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x10D3284", Offset = "0x10D3284", VA = "0x10D3284", Slot = "226")]
		internal virtual GetCSVHeaderResponse GetCSVHeader(GetCSVHeaderRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x10D341C", Offset = "0x10D341C", VA = "0x10D341C", Slot = "227")]
		public virtual Task<GetCSVHeaderResponse> GetCSVHeaderAsync(GetCSVHeaderRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x10D35BC", Offset = "0x10D35BC", VA = "0x10D35BC", Slot = "228")]
		internal virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x10D3754", Offset = "0x10D3754", VA = "0x10D3754", Slot = "229")]
		public virtual Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x10D38F4", Offset = "0x10D38F4", VA = "0x10D38F4", Slot = "230")]
		internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x10D3A8C", Offset = "0x10D3A8C", VA = "0x10D3A8C", Slot = "231")]
		public virtual Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x10D3C2C", Offset = "0x10D3C2C", VA = "0x10D3C2C", Slot = "232")]
		internal virtual GetIdentityProviderByIdentifierResponse GetIdentityProviderByIdentifier(GetIdentityProviderByIdentifierRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x10D3DC4", Offset = "0x10D3DC4", VA = "0x10D3DC4", Slot = "233")]
		public virtual Task<GetIdentityProviderByIdentifierResponse> GetIdentityProviderByIdentifierAsync(GetIdentityProviderByIdentifierRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x10D3F64", Offset = "0x10D3F64", VA = "0x10D3F64", Slot = "234")]
		internal virtual GetSigningCertificateResponse GetSigningCertificate(GetSigningCertificateRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x10D40FC", Offset = "0x10D40FC", VA = "0x10D40FC", Slot = "235")]
		public virtual Task<GetSigningCertificateResponse> GetSigningCertificateAsync(GetSigningCertificateRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x10D429C", Offset = "0x10D429C", VA = "0x10D429C", Slot = "236")]
		internal virtual GetUICustomizationResponse GetUICustomization(GetUICustomizationRequest request)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x10D4434", Offset = "0x10D4434", VA = "0x10D4434", Slot = "237")]
		public virtual Task<GetUICustomizationResponse> GetUICustomizationAsync(GetUICustomizationRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x10D45D4", Offset = "0x10D45D4", VA = "0x10D45D4", Slot = "238")]
		internal virtual GetUserResponse GetUser(GetUserRequest request)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x10D476C", Offset = "0x10D476C", VA = "0x10D476C", Slot = "239")]
		public virtual Task<GetUserResponse> GetUserAsync(GetUserRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x10D490C", Offset = "0x10D490C", VA = "0x10D490C", Slot = "240")]
		internal virtual GetUserAttributeVerificationCodeResponse GetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x10D4AA4", Offset = "0x10D4AA4", VA = "0x10D4AA4", Slot = "241")]
		public virtual Task<GetUserAttributeVerificationCodeResponse> GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x10D4C44", Offset = "0x10D4C44", VA = "0x10D4C44", Slot = "242")]
		internal virtual GetUserPoolMfaConfigResponse GetUserPoolMfaConfig(GetUserPoolMfaConfigRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x10D4DDC", Offset = "0x10D4DDC", VA = "0x10D4DDC", Slot = "243")]
		public virtual Task<GetUserPoolMfaConfigResponse> GetUserPoolMfaConfigAsync(GetUserPoolMfaConfigRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x10D4F7C", Offset = "0x10D4F7C", VA = "0x10D4F7C", Slot = "244")]
		internal virtual GlobalSignOutResponse GlobalSignOut(GlobalSignOutRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x10D5114", Offset = "0x10D5114", VA = "0x10D5114", Slot = "245")]
		public virtual Task<GlobalSignOutResponse> GlobalSignOutAsync(GlobalSignOutRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x10D52B4", Offset = "0x10D52B4", VA = "0x10D52B4", Slot = "246")]
		internal virtual InitiateAuthResponse InitiateAuth(InitiateAuthRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x10D544C", Offset = "0x10D544C", VA = "0x10D544C", Slot = "247")]
		public virtual Task<InitiateAuthResponse> InitiateAuthAsync(InitiateAuthRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x10D55EC", Offset = "0x10D55EC", VA = "0x10D55EC", Slot = "248")]
		internal virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x10D5784", Offset = "0x10D5784", VA = "0x10D5784", Slot = "249")]
		public virtual Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x10D5924", Offset = "0x10D5924", VA = "0x10D5924", Slot = "250")]
		internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x10D5ABC", Offset = "0x10D5ABC", VA = "0x10D5ABC", Slot = "251")]
		public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x10D5C5C", Offset = "0x10D5C5C", VA = "0x10D5C5C", Slot = "252")]
		internal virtual ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x10D5DF4", Offset = "0x10D5DF4", VA = "0x10D5DF4", Slot = "253")]
		public virtual Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(ListIdentityProvidersRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x10D5F94", Offset = "0x10D5F94", VA = "0x10D5F94", Slot = "254")]
		internal virtual ListResourceServersResponse ListResourceServers(ListResourceServersRequest request)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x10D612C", Offset = "0x10D612C", VA = "0x10D612C", Slot = "255")]
		public virtual Task<ListResourceServersResponse> ListResourceServersAsync(ListResourceServersRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x10D62CC", Offset = "0x10D62CC", VA = "0x10D62CC", Slot = "256")]
		internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x10D6464", Offset = "0x10D6464", VA = "0x10D6464", Slot = "257")]
		public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x10D6604", Offset = "0x10D6604", VA = "0x10D6604", Slot = "258")]
		internal virtual ListUserImportJobsResponse ListUserImportJobs(ListUserImportJobsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x10D679C", Offset = "0x10D679C", VA = "0x10D679C", Slot = "259")]
		public virtual Task<ListUserImportJobsResponse> ListUserImportJobsAsync(ListUserImportJobsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x10D693C", Offset = "0x10D693C", VA = "0x10D693C", Slot = "260")]
		internal virtual ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x10D6AD4", Offset = "0x10D6AD4", VA = "0x10D6AD4", Slot = "261")]
		public virtual Task<ListUserPoolClientsResponse> ListUserPoolClientsAsync(ListUserPoolClientsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x10D6C74", Offset = "0x10D6C74", VA = "0x10D6C74", Slot = "262")]
		internal virtual ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x10D6E0C", Offset = "0x10D6E0C", VA = "0x10D6E0C", Slot = "263")]
		public virtual Task<ListUserPoolsResponse> ListUserPoolsAsync(ListUserPoolsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x10D6FAC", Offset = "0x10D6FAC", VA = "0x10D6FAC", Slot = "264")]
		internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x10D7144", Offset = "0x10D7144", VA = "0x10D7144", Slot = "265")]
		public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x10D72E4", Offset = "0x10D72E4", VA = "0x10D72E4", Slot = "266")]
		internal virtual ListUsersInGroupResponse ListUsersInGroup(ListUsersInGroupRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x10D747C", Offset = "0x10D747C", VA = "0x10D747C", Slot = "267")]
		public virtual Task<ListUsersInGroupResponse> ListUsersInGroupAsync(ListUsersInGroupRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x10D761C", Offset = "0x10D761C", VA = "0x10D761C", Slot = "268")]
		internal virtual ResendConfirmationCodeResponse ResendConfirmationCode(ResendConfirmationCodeRequest request)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x10D77B4", Offset = "0x10D77B4", VA = "0x10D77B4", Slot = "269")]
		public virtual Task<ResendConfirmationCodeResponse> ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x10D7954", Offset = "0x10D7954", VA = "0x10D7954", Slot = "270")]
		internal virtual RespondToAuthChallengeResponse RespondToAuthChallenge(RespondToAuthChallengeRequest request)
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x10D7AEC", Offset = "0x10D7AEC", VA = "0x10D7AEC", Slot = "271")]
		public virtual Task<RespondToAuthChallengeResponse> RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x10D7C8C", Offset = "0x10D7C8C", VA = "0x10D7C8C", Slot = "272")]
		internal virtual SetRiskConfigurationResponse SetRiskConfiguration(SetRiskConfigurationRequest request)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x10D7E24", Offset = "0x10D7E24", VA = "0x10D7E24", Slot = "273")]
		public virtual Task<SetRiskConfigurationResponse> SetRiskConfigurationAsync(SetRiskConfigurationRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x10D7FC4", Offset = "0x10D7FC4", VA = "0x10D7FC4", Slot = "274")]
		internal virtual SetUICustomizationResponse SetUICustomization(SetUICustomizationRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x10D815C", Offset = "0x10D815C", VA = "0x10D815C", Slot = "275")]
		public virtual Task<SetUICustomizationResponse> SetUICustomizationAsync(SetUICustomizationRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x10D82FC", Offset = "0x10D82FC", VA = "0x10D82FC", Slot = "276")]
		internal virtual SetUserMFAPreferenceResponse SetUserMFAPreference(SetUserMFAPreferenceRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x10D8494", Offset = "0x10D8494", VA = "0x10D8494", Slot = "277")]
		public virtual Task<SetUserMFAPreferenceResponse> SetUserMFAPreferenceAsync(SetUserMFAPreferenceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x10D8634", Offset = "0x10D8634", VA = "0x10D8634", Slot = "278")]
		internal virtual SetUserPoolMfaConfigResponse SetUserPoolMfaConfig(SetUserPoolMfaConfigRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x10D87CC", Offset = "0x10D87CC", VA = "0x10D87CC", Slot = "279")]
		public virtual Task<SetUserPoolMfaConfigResponse> SetUserPoolMfaConfigAsync(SetUserPoolMfaConfigRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x10D896C", Offset = "0x10D896C", VA = "0x10D896C", Slot = "280")]
		internal virtual SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x10D8B04", Offset = "0x10D8B04", VA = "0x10D8B04", Slot = "281")]
		public virtual Task<SetUserSettingsResponse> SetUserSettingsAsync(SetUserSettingsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x10D8CA4", Offset = "0x10D8CA4", VA = "0x10D8CA4", Slot = "282")]
		internal virtual SignUpResponse SignUp(SignUpRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x10D8E3C", Offset = "0x10D8E3C", VA = "0x10D8E3C", Slot = "283")]
		public virtual Task<SignUpResponse> SignUpAsync(SignUpRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x10D8FDC", Offset = "0x10D8FDC", VA = "0x10D8FDC", Slot = "284")]
		internal virtual StartUserImportJobResponse StartUserImportJob(StartUserImportJobRequest request)
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x10D9174", Offset = "0x10D9174", VA = "0x10D9174", Slot = "285")]
		public virtual Task<StartUserImportJobResponse> StartUserImportJobAsync(StartUserImportJobRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x10D9314", Offset = "0x10D9314", VA = "0x10D9314", Slot = "286")]
		internal virtual StopUserImportJobResponse StopUserImportJob(StopUserImportJobRequest request)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x10D94AC", Offset = "0x10D94AC", VA = "0x10D94AC", Slot = "287")]
		public virtual Task<StopUserImportJobResponse> StopUserImportJobAsync(StopUserImportJobRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x10D964C", Offset = "0x10D964C", VA = "0x10D964C", Slot = "288")]
		internal virtual TagResourceResponse TagResource(TagResourceRequest request)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x10D97E4", Offset = "0x10D97E4", VA = "0x10D97E4", Slot = "289")]
		public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x10D9984", Offset = "0x10D9984", VA = "0x10D9984", Slot = "290")]
		internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x10D9B1C", Offset = "0x10D9B1C", VA = "0x10D9B1C", Slot = "291")]
		public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x10D9CBC", Offset = "0x10D9CBC", VA = "0x10D9CBC", Slot = "292")]
		internal virtual UpdateAuthEventFeedbackResponse UpdateAuthEventFeedback(UpdateAuthEventFeedbackRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x10D9E54", Offset = "0x10D9E54", VA = "0x10D9E54", Slot = "293")]
		public virtual Task<UpdateAuthEventFeedbackResponse> UpdateAuthEventFeedbackAsync(UpdateAuthEventFeedbackRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x10D9FF4", Offset = "0x10D9FF4", VA = "0x10D9FF4", Slot = "294")]
		internal virtual UpdateDeviceStatusResponse UpdateDeviceStatus(UpdateDeviceStatusRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x10DA18C", Offset = "0x10DA18C", VA = "0x10DA18C", Slot = "295")]
		public virtual Task<UpdateDeviceStatusResponse> UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x10DA32C", Offset = "0x10DA32C", VA = "0x10DA32C", Slot = "296")]
		internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x10DA4C4", Offset = "0x10DA4C4", VA = "0x10DA4C4", Slot = "297")]
		public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x10DA664", Offset = "0x10DA664", VA = "0x10DA664", Slot = "298")]
		internal virtual UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x10DA7FC", Offset = "0x10DA7FC", VA = "0x10DA7FC", Slot = "299")]
		public virtual Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x10DA99C", Offset = "0x10DA99C", VA = "0x10DA99C", Slot = "300")]
		internal virtual UpdateResourceServerResponse UpdateResourceServer(UpdateResourceServerRequest request)
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x10DAB34", Offset = "0x10DAB34", VA = "0x10DAB34", Slot = "301")]
		public virtual Task<UpdateResourceServerResponse> UpdateResourceServerAsync(UpdateResourceServerRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x10DACD4", Offset = "0x10DACD4", VA = "0x10DACD4", Slot = "302")]
		internal virtual UpdateUserAttributesResponse UpdateUserAttributes(UpdateUserAttributesRequest request)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x10DAE6C", Offset = "0x10DAE6C", VA = "0x10DAE6C", Slot = "303")]
		public virtual Task<UpdateUserAttributesResponse> UpdateUserAttributesAsync(UpdateUserAttributesRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x10DB00C", Offset = "0x10DB00C", VA = "0x10DB00C", Slot = "304")]
		internal virtual UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x10DB1A4", Offset = "0x10DB1A4", VA = "0x10DB1A4", Slot = "305")]
		public virtual Task<UpdateUserPoolResponse> UpdateUserPoolAsync(UpdateUserPoolRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x10DB344", Offset = "0x10DB344", VA = "0x10DB344", Slot = "306")]
		internal virtual UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x10DB4DC", Offset = "0x10DB4DC", VA = "0x10DB4DC", Slot = "307")]
		public virtual Task<UpdateUserPoolClientResponse> UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x10DB67C", Offset = "0x10DB67C", VA = "0x10DB67C", Slot = "308")]
		internal virtual UpdateUserPoolDomainResponse UpdateUserPoolDomain(UpdateUserPoolDomainRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x10DB814", Offset = "0x10DB814", VA = "0x10DB814", Slot = "309")]
		public virtual Task<UpdateUserPoolDomainResponse> UpdateUserPoolDomainAsync(UpdateUserPoolDomainRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x10DB9B4", Offset = "0x10DB9B4", VA = "0x10DB9B4", Slot = "310")]
		internal virtual VerifySoftwareTokenResponse VerifySoftwareToken(VerifySoftwareTokenRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x10DBB4C", Offset = "0x10DBB4C", VA = "0x10DBB4C", Slot = "311")]
		public virtual Task<VerifySoftwareTokenResponse> VerifySoftwareTokenAsync(VerifySoftwareTokenRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x10DBCEC", Offset = "0x10DBCEC", VA = "0x10DBCEC", Slot = "312")]
		internal virtual VerifyUserAttributeResponse VerifyUserAttribute(VerifyUserAttributeRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x10DBE84", Offset = "0x10DBE84", VA = "0x10DBE84", Slot = "313")]
		public virtual Task<VerifyUserAttributeResponse> VerifyUserAttributeAsync(VerifyUserAttributeRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x10DC0A8", Offset = "0x10DC0A8", VA = "0x10DC0A8", Slot = "113")]
		private IClientConfig Amazon_002ERuntime_002EIAmazonService_002Eget_Config()
		{
			return null;
		}
	}
}
