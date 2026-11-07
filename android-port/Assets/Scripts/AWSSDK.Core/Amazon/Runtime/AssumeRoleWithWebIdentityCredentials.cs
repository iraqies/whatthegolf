using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000C1")]
	public class AssumeRoleWithWebIdentityCredentials : RefreshingAWSCredentials
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20000C2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25A3C", Offset = "0x25A3C")]
		private struct _003CGenerateNewCredentialsAsync_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<CredentialsRefreshState> _003C_003Et__builder;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssumeRoleWithWebIdentityCredentials _003C_003E4__this;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string _003Ctoken_003E5__2;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cretry_003E5__3;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private FileStream _003CfileStream_003E5__4;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private StreamReader _003CstreamReader_003E5__5;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private ICoreAmazonSTS_WebIdentity _003CcoreStsClient_003E5__6;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private ConfiguredTaskAwaitable<AssumeRoleImmutableCredentials>.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1287038", Offset = "0x1287038", VA = "0x1287038", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1287C18", Offset = "0x1287C18", VA = "0x1287C18", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400033F")]
		private const int PREEMPT_EXPIRY_MINUTES = 5;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly RegionEndpoint _defaultSTSClientRegion;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string _roleSessionNameDefault;

		[Token(Token = "0x4000342")]
		public const string WebIdentityTokenFileEnvVariable = "AWS_WEB_IDENTITY_TOKEN_FILE";

		[Token(Token = "0x4000343")]
		public const string RoleArnEnvVariable = "AWS_ROLE_ARN";

		[Token(Token = "0x4000344")]
		public const string RoleSessionNameEnvVariable = "AWS_ROLE_SESSION_NAME";

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Regex _roleSessionNameRegex;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Logger _logger;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AssumeRoleWithWebIdentityCredentialsOptions _options;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26A28", Offset = "0x26A28")]
		private readonly string WebIdentityTokenFile__BackingField;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26A38", Offset = "0x26A38")]
		private readonly string RoleArn__BackingField;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26A48", Offset = "0x26A48")]
		private readonly string RoleSessionName__BackingField;

		[Token(Token = "0x170001C5")]
		public string WebIdentityTokenFile
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x11D203C", Offset = "0x11D203C", VA = "0x11D203C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2914C", Offset = "0x2914C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C6")]
		public string RoleArn
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x11D2044", Offset = "0x11D2044", VA = "0x11D2044")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2915C", Offset = "0x2915C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C7")]
		public string RoleSessionName
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x11D204C", Offset = "0x11D204C", VA = "0x11D204C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2916C", Offset = "0x2916C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x11C015C", Offset = "0x11C015C", VA = "0x11C015C")]
		public AssumeRoleWithWebIdentityCredentials(string webIdentityTokenFile, string roleArn, string roleSessionName)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x11D205C", Offset = "0x11D205C", VA = "0x11D205C")]
		public AssumeRoleWithWebIdentityCredentials(string webIdentityTokenFile, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x11D2440", Offset = "0x11D2440", VA = "0x11D2440")]
		public static AssumeRoleWithWebIdentityCredentials FromEnvironmentVariables()
		{
			return null;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x11D2560", Offset = "0x11D2560", VA = "0x11D2560", Slot = "8")]
		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x11D2CD8", Offset = "0x11D2CD8", VA = "0x11D2CD8", Slot = "9")]
		protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
		{
			return null;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x11D2DEC", Offset = "0x11D2DEC", VA = "0x11D2DEC", Slot = "12")]
		protected virtual ICoreAmazonSTS_WebIdentity CreateClient()
		{
			return null;
		}
	}
}
