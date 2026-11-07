using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000CD")]
	public class ProcessAWSCredentials : RefreshingAWSCredentials
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20000CE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25A5C", Offset = "0x25A5C")]
		private struct _003CDetermineProcessCredentialAsync_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<CredentialsRefreshState> _003C_003Et__builder;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProcessAWSCredentials _003C_003E4__this;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ConfiguredTaskAwaitable<ProcessExecutionResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x1291088", Offset = "0x1291088", VA = "0x1291088", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1291544", Offset = "0x1291544", VA = "0x1291544", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400038B")]
		private const string _versionString = "Version";

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Logger _logger;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly ProcessStartInfo _processStartInfo;

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x124E674", Offset = "0x124E674", VA = "0x124E674")]
		public ProcessAWSCredentials(string processCredentialInfo)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x124EBA8", Offset = "0x124EBA8", VA = "0x124EBA8", Slot = "8")]
		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x124EDFC", Offset = "0x124EDFC", VA = "0x124EDFC", Slot = "9")]
		protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
		{
			return null;
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x124EBAC", Offset = "0x124EBAC", VA = "0x124EBAC")]
		public CredentialsRefreshState DetermineProcessCredential()
		{
			return null;
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x124EE00", Offset = "0x124EE00", VA = "0x124EE00")]
		public Task<CredentialsRefreshState> DetermineProcessCredentialAsync()
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x124EF10", Offset = "0x124EF10", VA = "0x124EF10")]
		private CredentialsRefreshState SetCredentialsRefreshState(ProcessExecutionResult processInfo)
		{
			return null;
		}
	}
}
