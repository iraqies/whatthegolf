using System;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.SecurityToken.Model;
using Il2CppDummyDll;

namespace Amazon.SecurityToken
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x30A30", Offset = "0x30A30")]
	public class STSAssumeRoleAWSCredentials : RefreshingAWSCredentials, IDisposable
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x38")]
		private IAmazonSecurityTokenService _stsClient;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x40")]
		private AssumeRoleRequest _assumeRequest;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x48")]
		private AssumeRoleWithSAMLRequest _assumeSamlRequest;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x50")]
		private bool _isDisposed;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		private static TimeSpan _defaultPreemptExpiryTime;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x12E5320", Offset = "0x12E5320", VA = "0x12E5320")]
		public STSAssumeRoleAWSCredentials(IAmazonSecurityTokenService sts, AssumeRoleRequest assumeRoleRequest)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x12E5420", Offset = "0x12E5420", VA = "0x12E5420")]
		public STSAssumeRoleAWSCredentials(AssumeRoleWithSAMLRequest assumeRoleWithSamlRequest)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x12E55A0", Offset = "0x12E55A0", VA = "0x12E55A0", Slot = "8")]
		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x12E57B0", Offset = "0x12E57B0", VA = "0x12E57B0", Slot = "12")]
		protected new virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x12E5888", Offset = "0x12E5888", VA = "0x12E5888", Slot = "7")]
		public new void Dispose()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x12E565C", Offset = "0x12E565C", VA = "0x12E565C")]
		private Credentials GetServiceCredentials()
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x12E598C", Offset = "0x12E598C", VA = "0x12E598C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30ACC", Offset = "0x30ACC")]
		private Task<AssumeRoleResponse> _003CGetServiceCredentials_003Eb__10_0()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x12E5A4C", Offset = "0x12E5A4C", VA = "0x12E5A4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30ADC", Offset = "0x30ADC")]
		private Task<AssumeRoleWithSAMLResponse> _003CGetServiceCredentials_003Eb__10_1()
		{
			return null;
		}
	}
}
