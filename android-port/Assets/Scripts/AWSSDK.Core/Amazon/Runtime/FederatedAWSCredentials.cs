using System;
using System.Net;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.CredentialManagement.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000C9")]
	public class FederatedAWSCredentials : RefreshingAWSCredentials
	{
		[Token(Token = "0x400036C")]
		private const int MaxAuthenticationRetries = 3;

		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly RegionEndpoint DefaultSTSClientRegion;

		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TimeSpan MaximumCredentialTimespan;

		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly TimeSpan DefaultPreemptExpiryTime;

		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x38")]
		private readonly SAMLRoleSessionManager sessionManager;

		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26AE8", Offset = "0x26AE8")]
		private SAMLEndpoint SAMLEndpoint__BackingField;

		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26AF8", Offset = "0x26AF8")]
		private string RoleArn__BackingField;

		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26B08", Offset = "0x26B08")]
		private FederatedAWSCredentialsOptions Options__BackingField;

		[Token(Token = "0x170001D2")]
		public SAMLEndpoint SAMLEndpoint
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x120AC44", Offset = "0x120AC44", VA = "0x120AC44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2925C", Offset = "0x2925C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x120AC4C", Offset = "0x120AC4C", VA = "0x120AC4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2926C", Offset = "0x2926C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public string RoleArn
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x120AC54", Offset = "0x120AC54", VA = "0x120AC54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2927C", Offset = "0x2927C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x120AC5C", Offset = "0x120AC5C", VA = "0x120AC5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2928C", Offset = "0x2928C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public FederatedAWSCredentialsOptions Options
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x120AC64", Offset = "0x120AC64", VA = "0x120AC64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2929C", Offset = "0x2929C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x120AC6C", Offset = "0x120AC6C", VA = "0x120AC6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x292AC", Offset = "0x292AC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x120A98C", Offset = "0x120A98C", VA = "0x120A98C")]
		public FederatedAWSCredentials(SAMLEndpoint samlEndpoint, string roleArn)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x120AABC", Offset = "0x120AABC", VA = "0x120AABC")]
		public FederatedAWSCredentials(SAMLEndpoint samlEndpoint, string roleArn, FederatedAWSCredentialsOptions options)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x120AC74", Offset = "0x120AC74", VA = "0x120AC74", Slot = "8")]
		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x120B5D4", Offset = "0x120B5D4", VA = "0x120B5D4")]
		private CredentialsRefreshState Authenticate(ICredentials userCredential)
		{
			return null;
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x120BF90", Offset = "0x120BF90", VA = "0x120BF90")]
		private string GetRoleSessionName()
		{
			return null;
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x120B17C", Offset = "0x120B17C", VA = "0x120B17C")]
		private bool TryGetRoleSession(out SAMLImmutableCredentials sessionCredentials)
		{
			return default;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x120BF28", Offset = "0x120BF28", VA = "0x120BF28")]
		private void RegisterRoleSession(SAMLImmutableCredentials sessionCredentials)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x120C144", Offset = "0x120C144", VA = "0x120C144", Slot = "11")]
		public override void ClearCredentials()
		{
		}
	}
}
