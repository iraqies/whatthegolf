using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Amazon.Runtime.CredentialManagement.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement
{
	[Token(Token = "0x2000130")]
	public static class AWSCredentialsFactory
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<CredentialProfileType> CallbackProfileTypes;

		[Token(Token = "0x400047E")]
		private const string RoleSessionNamePrefix = "aws-dotnet-sdk-session-";

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x11BE1CC", Offset = "0x11BE1CC", VA = "0x11BE1CC")]
		public static AWSCredentials GetAWSCredentials(CredentialProfile profile, ICredentialProfileSource profileSource)
		{
			return null;
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x11BE528", Offset = "0x11BE528", VA = "0x11BE528")]
		public static AWSCredentials GetAWSCredentials(CredentialProfileOptions options, ICredentialProfileSource profileSource)
		{
			return null;
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x11BE5AC", Offset = "0x11BE5AC", VA = "0x11BE5AC")]
		public static AWSCredentials GetAWSCredentials(CredentialProfile profile, ICredentialProfileSource profileSource, bool nonCallbackOnly)
		{
			return null;
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x11BE65C", Offset = "0x11BE65C", VA = "0x11BE65C")]
		public static AWSCredentials GetAWSCredentials(CredentialProfileOptions options, ICredentialProfileSource profileSource, bool nonCallbackOnly)
		{
			return null;
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x11BE6EC", Offset = "0x11BE6EC", VA = "0x11BE6EC")]
		public static bool TryGetAWSCredentials(CredentialProfile profile, ICredentialProfileSource profileSource, out AWSCredentials credentials)
		{
			return default;
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x11BF380", Offset = "0x11BF380", VA = "0x11BF380")]
		public static bool TryGetAWSCredentials(CredentialProfileOptions options, ICredentialProfileSource profileSource, out AWSCredentials credentials)
		{
			return default;
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x11BF45C", Offset = "0x11BF45C", VA = "0x11BF45C")]
		internal static bool IsCallbackRequired(CredentialProfileType? profileType)
		{
			return default;
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x11BE270", Offset = "0x11BE270", VA = "0x11BE270")]
		private static AWSCredentials GetAWSCredentials(string profileName, ICredentialProfileSource profileSource, CredentialProfileOptions options, RegionEndpoint stsRegion, bool nonCallbackOnly)
		{
			return null;
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x11BE7B4", Offset = "0x11BE7B4", VA = "0x11BE7B4")]
		private static AWSCredentials GetAWSCredentialsInternal(string profileName, CredentialProfileType? profileType, CredentialProfileOptions options, RegionEndpoint stsRegion, ICredentialProfileSource profileSource, bool throwIfInvalid, [Optional] HashSet<string> profileLoopAvoidance)
		{
			return null;
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x11BFCB0", Offset = "0x11BFCB0", VA = "0x11BFCB0")]
		private static AWSCredentials GetCredentialSourceAWSCredentials(string credentialSourceType, bool throwIfInvalid)
		{
			return null;
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x11BF630", Offset = "0x11BF630", VA = "0x11BF630")]
		private static AWSCredentials GetSourceAWSCredentials(string sourceProfileName, ICredentialProfileSource profileSource, bool throwIfInvalid, [Optional] HashSet<string> profileLoopAvoidance)
		{
			return null;
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x11C01E4", Offset = "0x11C01E4", VA = "0x11C01E4")]
		private static BasicAWSCredentials ThrowInvalidOrReturnNull(string profileName, bool doThrow)
		{
			return null;
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x11BF5CC", Offset = "0x11BF5CC", VA = "0x11BF5CC")]
		private static BasicAWSCredentials ThrowOrReturnNull(string message, Exception innerException, bool doThrow)
		{
			return null;
		}
	}
}
