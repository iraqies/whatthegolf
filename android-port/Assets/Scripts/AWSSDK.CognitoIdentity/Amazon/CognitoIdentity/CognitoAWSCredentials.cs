using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity
{
	[Token(Token = "0x2000002")]
	public class CognitoAWSCredentials : RefreshingAWSCredentials
	{
		[Token(Token = "0x2000003")]
		[Flags]
		private enum RefreshIdentityOptions
		{
			[Token(Token = "0x400000F")]
			None = 0,
			[Token(Token = "0x4000010")]
			Refresh = 1
		}

		[Token(Token = "0x2000004")]
		public class IdentityChangedArgs : EventArgs
		{
			[Token(Token = "0x4000011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22264", Offset = "0x22264")]
			private string OldIdentityId__BackingField;

			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22274", Offset = "0x22274")]
			private string NewIdentityId__BackingField;

			[Token(Token = "0x1700000A")]
			public string OldIdentityId
			{
				[Token(Token = "0x6000030")]
				[Address(RVA = "0x118C134", Offset = "0x118C134", VA = "0x118C134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22364", Offset = "0x22364")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000031")]
				[Address(RVA = "0x118C13C", Offset = "0x118C13C", VA = "0x118C13C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22374", Offset = "0x22374")]
				private set
				{
				}
			}

			[Token(Token = "0x1700000B")]
			public string NewIdentityId
			{
				[Token(Token = "0x6000032")]
				[Address(RVA = "0x118C144", Offset = "0x118C144", VA = "0x118C144")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22384", Offset = "0x22384")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000033")]
				[Address(RVA = "0x118C14C", Offset = "0x118C14C", VA = "0x118C14C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22394", Offset = "0x22394")]
				private set
				{
				}
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x118C154", Offset = "0x118C154", VA = "0x118C154")]
			internal IdentityChangedArgs(string oldIdentityId, string newIdentityId)
			{
			}
		}

		[Token(Token = "0x2000005")]
		public class IdentityState
		{
			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22284", Offset = "0x22284")]
			private string IdentityId__BackingField;

			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22294", Offset = "0x22294")]
			private string LoginProvider__BackingField;

			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222A4", Offset = "0x222A4")]
			private string LoginToken__BackingField;

			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222B4", Offset = "0x222B4")]
			private bool FromCache__BackingField;

			[Token(Token = "0x1700000C")]
			public string IdentityId
			{
				[Token(Token = "0x6000035")]
				[Address(RVA = "0x118C1D8", Offset = "0x118C1D8", VA = "0x118C1D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x223A4", Offset = "0x223A4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000036")]
				[Address(RVA = "0x118C1E0", Offset = "0x118C1E0", VA = "0x118C1E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x223B4", Offset = "0x223B4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700000D")]
			public string LoginProvider
			{
				[Token(Token = "0x6000037")]
				[Address(RVA = "0x118C1E8", Offset = "0x118C1E8", VA = "0x118C1E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x223C4", Offset = "0x223C4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000038")]
				[Address(RVA = "0x118C1F0", Offset = "0x118C1F0", VA = "0x118C1F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x223D4", Offset = "0x223D4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700000E")]
			public string LoginToken
			{
				[Token(Token = "0x6000039")]
				[Address(RVA = "0x118C1F8", Offset = "0x118C1F8", VA = "0x118C1F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x223E4", Offset = "0x223E4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600003A")]
				[Address(RVA = "0x118C200", Offset = "0x118C200", VA = "0x118C200")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x223F4", Offset = "0x223F4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700000F")]
			public bool FromCache
			{
				[Token(Token = "0x600003B")]
				[Address(RVA = "0x118C208", Offset = "0x118C208", VA = "0x118C208")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22404", Offset = "0x22404")]
				get
				{
					return default;
				}
				[Token(Token = "0x600003C")]
				[Address(RVA = "0x118C210", Offset = "0x118C210", VA = "0x118C210")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22414", Offset = "0x22414")]
				private set
				{
				}
			}

			[Token(Token = "0x17000010")]
			public bool LoginSpecified
			{
				[Token(Token = "0x600003F")]
				[Address(RVA = "0x118C268", Offset = "0x118C268", VA = "0x118C268")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600003D")]
			[Address(RVA = "0x118C218", Offset = "0x118C218", VA = "0x118C218")]
			public IdentityState(string identityId, string provider, string token, bool fromCache)
			{
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x118C09C", Offset = "0x118C09C", VA = "0x118C09C")]
			public IdentityState(string identityId, bool fromCache)
			{
			}
		}

		[Token(Token = "0x2000006")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22174", Offset = "0x22174")]
		private sealed class _003C_003Ec__DisplayClass45_0
		{
			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CognitoAWSCredentials _003C_003E4__this;

			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GetIdRequest getIdRequest;

			[Token(Token = "0x6000040")]
			[Address(RVA = "0x1189DB4", Offset = "0x1189DB4", VA = "0x1189DB4")]
			public _003C_003Ec__DisplayClass45_0()
			{
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1189DBC", Offset = "0x1189DBC", VA = "0x1189DBC")]
			internal Task<GetIdResponse> _003CRefreshIdentity_003Eb__0()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000007")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22184", Offset = "0x22184")]
		private struct _003CGetIdentityIdAsync_003Ed__46 : IAsyncStateMachine
		{
			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CognitoAWSCredentials _003C_003E4__this;

			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x118AEC4", Offset = "0x118AEC4", VA = "0x118AEC4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x118B0CC", Offset = "0x118B0CC", VA = "0x118B0CC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22194", Offset = "0x22194")]
		private struct _003CGetIdentityIdAsync_003Ed__47 : IAsyncStateMachine
		{
			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CognitoAWSCredentials _003C_003E4__this;

			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RefreshIdentityOptions options;

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable<IdentityState>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x118B128", Offset = "0x118B128", VA = "0x118B128", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x118B410", Offset = "0x118B410", VA = "0x118B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x221A4", Offset = "0x221A4")]
		private struct _003CRefreshIdentityAsync_003Ed__48 : IAsyncStateMachine
		{
			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<IdentityState> _003C_003Et__builder;

			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CognitoAWSCredentials _003C_003E4__this;

			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ConfiguredTaskAwaitable<GetIdResponse>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x118BCF8", Offset = "0x118BCF8", VA = "0x118BCF8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x118C0D8", Offset = "0x118C0D8", VA = "0x118C0D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200000A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x221B4", Offset = "0x221B4")]
		private struct _003CGenerateNewCredentialsAsync_003Ed__57 : IAsyncStateMachine
		{
			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<CredentialsRefreshState> _003C_003Et__builder;

			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CognitoAWSCredentials _003C_003E4__this;

			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ConfiguredTaskAwaitable<CredentialsRefreshState>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000048")]
			[Address(RVA = "0x118A104", Offset = "0x118A104", VA = "0x118A104", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000049")]
			[Address(RVA = "0x118A45C", Offset = "0x118A45C", VA = "0x118A45C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200000B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x221C4", Offset = "0x221C4")]
		private struct _003CGetCredentialsForRoleAsync_003Ed__58 : IAsyncStateMachine
		{
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<CredentialsRefreshState> _003C_003Et__builder;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CognitoAWSCredentials _003C_003E4__this;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string roleArn;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool _003Cretry_003E5__2;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GetOpenIdTokenResponse _003CgetTokenResult_003E5__3;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable<GetOpenIdTokenResponse>.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private ConfiguredTaskAwaitable<CredentialsRefreshState>.ConfiguredTaskAwaiter _003C_003Eu__3;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private ConfiguredTaskAwaitable<AssumeRoleWithWebIdentityResponse>.ConfiguredTaskAwaiter _003C_003Eu__4;

			[Token(Token = "0x600004A")]
			[Address(RVA = "0x118A4B8", Offset = "0x118A4B8", VA = "0x118A4B8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600004B")]
			[Address(RVA = "0x118AE68", Offset = "0x118AE68", VA = "0x118AE68", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200000C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x221D4", Offset = "0x221D4")]
		private struct _003CGetPoolCredentialsAsync_003Ed__59 : IAsyncStateMachine
		{
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<CredentialsRefreshState> _003C_003Et__builder;

			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CognitoAWSCredentials _003C_003E4__this;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool _003Cretry_003E5__2;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GetCredentialsForIdentityResponse _003Cresponse_003E5__3;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<GetCredentialsForIdentityResponse>.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private ConfiguredTaskAwaitable<CredentialsRefreshState>.ConfiguredTaskAwaiter _003C_003Eu__3;

			[Token(Token = "0x600004C")]
			[Address(RVA = "0x118B46C", Offset = "0x118B46C", VA = "0x118B46C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x118BC9C", Offset = "0x118BC9C", VA = "0x118BC9C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x221E4", Offset = "0x221E4")]
		private sealed class _003C_003Ec__DisplayClass64_0
		{
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CognitoAWSCredentials _003C_003E4__this;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AssumeRoleWithWebIdentityRequest assumeRequest;

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1189E88", Offset = "0x1189E88", VA = "0x1189E88")]
			public _003C_003Ec__DisplayClass64_0()
			{
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1189E90", Offset = "0x1189E90", VA = "0x1189E90")]
			internal Task<AssumeRoleWithWebIdentityResponse> _003CGetStsCredentials_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x200000E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x221F4", Offset = "0x221F4")]
		private sealed class _003C_003Ec__DisplayClass65_0
		{
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CognitoAWSCredentials _003C_003E4__this;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GetOpenIdTokenRequest getTokenRequest;

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1189F5C", Offset = "0x1189F5C", VA = "0x1189F5C")]
			public _003C_003Ec__DisplayClass65_0()
			{
			}

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x1189F64", Offset = "0x1189F64", VA = "0x1189F64")]
			internal Task<GetOpenIdTokenResponse> _003CGetOpenId_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22204", Offset = "0x22204")]
		private sealed class _003C_003Ec__DisplayClass66_0
		{
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CognitoAWSCredentials _003C_003E4__this;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GetCredentialsForIdentityRequest getCredentialsRequest;

			[Token(Token = "0x6000052")]
			[Address(RVA = "0x118A030", Offset = "0x118A030", VA = "0x118A030")]
			public _003C_003Ec__DisplayClass66_0()
			{
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x118A038", Offset = "0x118A038", VA = "0x118A038")]
			internal Task<GetCredentialsForIdentityResponse> _003CGetCredentialsForIdentity_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object refreshIdLock;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string identityId;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int DefaultDurationSeconds;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IAmazonCognitoIdentity cib;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IAmazonSecurityTokenService sts;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22214", Offset = "0x22214")]
		private string AccountId__BackingField;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22224", Offset = "0x22224")]
		private string IdentityPoolId__BackingField;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22234", Offset = "0x22234")]
		private string UnAuthRoleArn__BackingField;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22244", Offset = "0x22244")]
		private string AuthRoleArn__BackingField;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22254", Offset = "0x22254")]
		private Dictionary<string, string> Logins__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IdentityState _identityState;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private EventHandler<IdentityChangedArgs> mIdentityChangedEvent;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string IDENTITY_ID_CACHE_KEY;

		[Token(Token = "0x17000001")]
		private bool IsIdentitySet
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x10761C8", Offset = "0x10761C8", VA = "0x10761C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000002")]
		protected Dictionary<string, string> CloneLogins
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x1076318", Offset = "0x1076318", VA = "0x1076318")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public string AccountId
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x107658C", Offset = "0x107658C", VA = "0x107658C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222C4", Offset = "0x222C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x1076594", Offset = "0x1076594", VA = "0x1076594")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222D4", Offset = "0x222D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x107659C", Offset = "0x107659C", VA = "0x107659C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222E4", Offset = "0x222E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x10765A4", Offset = "0x10765A4", VA = "0x10765A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222F4", Offset = "0x222F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public string UnAuthRoleArn
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x10765AC", Offset = "0x10765AC", VA = "0x10765AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22304", Offset = "0x22304")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x10765B4", Offset = "0x10765B4", VA = "0x10765B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22314", Offset = "0x22314")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public string AuthRoleArn
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x10765BC", Offset = "0x10765BC", VA = "0x10765BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22324", Offset = "0x22324")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x10765C4", Offset = "0x10765C4", VA = "0x10765C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22334", Offset = "0x22334")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private Dictionary<string, string> Logins
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x10765CC", Offset = "0x10765CC", VA = "0x10765CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22344", Offset = "0x22344")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x10765D4", Offset = "0x10765D4", VA = "0x10765D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x22354", Offset = "0x22354")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public string[] CurrentLoginProviders
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x1076658", Offset = "0x1076658", VA = "0x1076658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public int LoginsCount
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x107681C", Offset = "0x107681C", VA = "0x107681C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000001")]
		public event EventHandler<IdentityChangedArgs> IdentityChangedEvent
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1077180", Offset = "0x1077180", VA = "0x1077180")]
			add
			{
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x10772A8", Offset = "0x10772A8", VA = "0x10772A8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x107621C", Offset = "0x107621C", VA = "0x107621C")]
		private void UpdateIdentity(string newIdentityId)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x107652C", Offset = "0x107652C", VA = "0x107652C")]
		protected string GetNamespacedKey(string key)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x10765DC", Offset = "0x10765DC", VA = "0x10765DC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x10766C8", Offset = "0x10766C8", VA = "0x10766C8")]
		public bool ContainsProvider(string providerName)
		{
			return default;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x107672C", Offset = "0x107672C", VA = "0x107672C")]
		public void RemoveLogin(string providerName)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x10767A0", Offset = "0x10767A0", VA = "0x10767A0")]
		public void AddLogin(string providerName, string token)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1076870", Offset = "0x1076870", VA = "0x1076870")]
		public string GetIdentityId()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1076878", Offset = "0x1076878", VA = "0x1076878")]
		private string GetIdentityId(RefreshIdentityOptions options)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1076A84", Offset = "0x1076A84", VA = "0x1076A84", Slot = "12")]
		protected virtual IdentityState RefreshIdentity()
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1076D14", Offset = "0x1076D14", VA = "0x1076D14")]
		public Task<string> GetIdentityIdAsync()
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1076E24", Offset = "0x1076E24", VA = "0x1076E24")]
		private Task<string> GetIdentityIdAsync(RefreshIdentityOptions options)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1076F38", Offset = "0x1076F38", VA = "0x1076F38", Slot = "13")]
		public virtual Task<IdentityState> RefreshIdentityAsync()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1077048", Offset = "0x1077048", VA = "0x1077048")]
		private bool ShouldRetry(AmazonCognitoIdentityException e)
		{
			return default;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x10773D0", Offset = "0x10773D0", VA = "0x10773D0")]
		public CognitoAWSCredentials(string identityPoolId, RegionEndpoint region)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x10773E8", Offset = "0x10773E8", VA = "0x10773E8")]
		public CognitoAWSCredentials(string accountId, string identityPoolId, string unAuthRoleArn, string authRoleArn, RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1077560", Offset = "0x1077560", VA = "0x1077560")]
		public CognitoAWSCredentials(string accountId, string identityPoolId, string unAuthRoleArn, string authRoleArn, IAmazonCognitoIdentity cibClient, IAmazonSecurityTokenService stsClient)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x107777C", Offset = "0x107777C", VA = "0x107777C", Slot = "9")]
		protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x107788C", Offset = "0x107788C", VA = "0x107788C")]
		private Task<CredentialsRefreshState> GetCredentialsForRoleAsync(string roleArn)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x10779A4", Offset = "0x10779A4", VA = "0x10779A4")]
		private Task<CredentialsRefreshState> GetPoolCredentialsAsync()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1077AB8", Offset = "0x1077AB8", VA = "0x1077AB8", Slot = "8")]
		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1077E60", Offset = "0x1077E60", VA = "0x1077E60")]
		private CredentialsRefreshState GetPoolCredentials()
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1077B68", Offset = "0x1077B68", VA = "0x1077B68")]
		private CredentialsRefreshState GetCredentialsForRole(string roleArn)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x107835C", Offset = "0x107835C", VA = "0x107835C")]
		private Amazon.SecurityToken.Model.Credentials GetStsCredentials(AssumeRoleWithWebIdentityRequest assumeRequest)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1078270", Offset = "0x1078270", VA = "0x1078270")]
		private GetOpenIdTokenResponse GetOpenId(GetOpenIdTokenRequest getTokenRequest)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1078144", Offset = "0x1078144", VA = "0x1078144")]
		private GetCredentialsForIdentityResponse GetCredentialsForIdentity(GetCredentialsForIdentityRequest getCredentialsRequest)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1078454", Offset = "0x1078454", VA = "0x1078454", Slot = "14")]
		public virtual string GetCachedIdentityId()
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x107845C", Offset = "0x107845C", VA = "0x107845C", Slot = "15")]
		public virtual void CacheIdentityId(string identityId)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1078460", Offset = "0x1078460", VA = "0x1078460", Slot = "16")]
		public virtual void ClearIdentityCache()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1078464", Offset = "0x1078464", VA = "0x1078464", Slot = "17")]
		public virtual void CacheCredentials(CredentialsRefreshState credentialsState)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1078468", Offset = "0x1078468", VA = "0x1078468", Slot = "18")]
		public virtual CredentialsRefreshState GetCachedCredentials()
		{
			return null;
		}
	}
}
