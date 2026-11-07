using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000C5")]
	internal class DefaultInstanceProfileAWSCredentials : AWSCredentials, IDisposable
	{
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x0")]
		private static object instanceLock;

		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x10")]
		private Timer credentialsRetrieverTimer;

		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x18")]
		private ImmutableCredentials lastRetrievedCredentials;

		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x20")]
		private Logger logger;

		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TimeSpan neverTimespan;

		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x10")]
		private static readonly TimeSpan refreshRate;

		[Token(Token = "0x4000364")]
		private const string FailedToGetCredentialsMessage = "Failed to retrieve credentials from EC2 Instance Metadata Service.";

		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x18")]
		private static DefaultInstanceProfileAWSCredentials _instance;

		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x28")]
		private bool isDisposed;

		[Token(Token = "0x170001D1")]
		public static DefaultInstanceProfileAWSCredentials Instance
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x11ED6D4", Offset = "0x11ED6D4", VA = "0x11ED6D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x11ED938", Offset = "0x11ED938", VA = "0x11ED938")]
		private DefaultInstanceProfileAWSCredentials()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x11EDC94", Offset = "0x11EDC94", VA = "0x11EDC94", Slot = "4")]
		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x11EE2BC", Offset = "0x11EE2BC", VA = "0x11EE2BC", Slot = "6")]
		public override Task<ImmutableCredentials> GetCredentialsAsync()
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x11EE358", Offset = "0x11EE358", VA = "0x11EE358")]
		private void RenewCredentials(object unused)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x11EDD80", Offset = "0x11EDD80", VA = "0x11EDD80")]
		private static ImmutableCredentials FetchCredentials()
		{
			return null;
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x11ED890", Offset = "0x11ED890", VA = "0x11ED890")]
		private static void CheckIsIMDSEnabled()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x11EEC64", Offset = "0x11EEC64", VA = "0x11EEC64", Slot = "8")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x11EEDD8", Offset = "0x11EEDD8", VA = "0x11EEDD8", Slot = "7")]
		public void Dispose()
		{
		}
	}
}
