using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000AD")]
	public class AssumeRoleAWSCredentials : RefreshingAWSCredentials
	{
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x38")]
		private RegionEndpoint DefaultSTSClientRegion;

		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x40")]
		private Logger _logger;

		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26848", Offset = "0x26848")]
		private AWSCredentials SourceCredentials__BackingField;

		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26858", Offset = "0x26858")]
		private string RoleArn__BackingField;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26868", Offset = "0x26868")]
		private string RoleSessionName__BackingField;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26878", Offset = "0x26878")]
		private AssumeRoleAWSCredentialsOptions Options__BackingField;

		[Token(Token = "0x170001A3")]
		public AWSCredentials SourceCredentials
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x11D134C", Offset = "0x11D134C", VA = "0x11D134C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28D6C", Offset = "0x28D6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x11D1354", Offset = "0x11D1354", VA = "0x11D1354")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28D7C", Offset = "0x28D7C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public string RoleArn
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x11D135C", Offset = "0x11D135C", VA = "0x11D135C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28D8C", Offset = "0x28D8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x11D1364", Offset = "0x11D1364", VA = "0x11D1364")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28D9C", Offset = "0x28D9C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		public string RoleSessionName
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x11D136C", Offset = "0x11D136C", VA = "0x11D136C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28DAC", Offset = "0x28DAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x11D1374", Offset = "0x11D1374", VA = "0x11D1374")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28DBC", Offset = "0x28DBC")]
			private set
			{
			}
		}

		[Token(Token = "0x170001A6")]
		public AssumeRoleAWSCredentialsOptions Options
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x11D137C", Offset = "0x11D137C", VA = "0x11D137C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28DCC", Offset = "0x28DCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x11D1384", Offset = "0x11D1384", VA = "0x11D1384")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28DDC", Offset = "0x28DDC")]
			private set
			{
			}
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x11D138C", Offset = "0x11D138C", VA = "0x11D138C")]
		public AssumeRoleAWSCredentials(AWSCredentials sourceCredentials, string roleArn, string roleSessionName)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x11BFAD4", Offset = "0x11BFAD4", VA = "0x11BFAD4")]
		public AssumeRoleAWSCredentials(AWSCredentials sourceCredentials, string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x11D1414", Offset = "0x11D1414", VA = "0x11D1414", Slot = "8")]
		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}
	}
}
