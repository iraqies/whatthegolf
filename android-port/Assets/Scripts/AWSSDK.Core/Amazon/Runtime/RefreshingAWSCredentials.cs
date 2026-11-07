using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000B8")]
	public abstract class RefreshingAWSCredentials : AWSCredentials, IDisposable
	{
		[Token(Token = "0x20000B9")]
		public class CredentialsRefreshState
		{
			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26938", Offset = "0x26938")]
			private ImmutableCredentials Credentials__BackingField;

			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26948", Offset = "0x26948")]
			private DateTime Expiration__BackingField;

			[Token(Token = "0x170001B6")]
			public ImmutableCredentials Credentials
			{
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x1291E38", Offset = "0x1291E38", VA = "0x1291E38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28F5C", Offset = "0x28F5C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x1291E40", Offset = "0x1291E40", VA = "0x1291E40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28F6C", Offset = "0x28F6C")]
				set
				{
				}
			}

			[Token(Token = "0x170001B7")]
			public DateTime Expiration
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x1291E48", Offset = "0x1291E48", VA = "0x1291E48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28F7C", Offset = "0x28F7C")]
				get
				{
					return default;
				}
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x1291E50", Offset = "0x1291E50", VA = "0x1291E50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28F8C", Offset = "0x28F8C")]
				set
				{
				}
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x1291E58", Offset = "0x1291E58", VA = "0x1291E58")]
			public CredentialsRefreshState()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x1287BE0", Offset = "0x1287BE0", VA = "0x1287BE0")]
			public CredentialsRefreshState(ImmutableCredentials credentials, DateTime expiration)
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x1291E60", Offset = "0x1291E60", VA = "0x1291E60")]
			internal bool IsExpiredWithin(TimeSpan preemptExpiryTime)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25A2C", Offset = "0x25A2C")]
		private struct _003CGetCredentialsAsync_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<ImmutableCredentials> _003C_003Et__builder;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RefreshingAWSCredentials _003C_003E4__this;

			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable<CredentialsRefreshState>.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x1291960", Offset = "0x1291960", VA = "0x1291960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x1291DDC", Offset = "0x1291DDC", VA = "0x1291DDC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Logger _logger;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected CredentialsRefreshState currentState;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TimeSpan _preemptExpiryTime;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _disposed;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly SemaphoreSlim _updateGeneratedCredentialsSemaphore;

		[Token(Token = "0x170001B4")]
		public TimeSpan PreemptExpiryTime
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x12565E4", Offset = "0x12565E4", VA = "0x12565E4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x124EAC4", Offset = "0x124EAC4", VA = "0x124EAC4")]
			set
			{
			}
		}

		[Token(Token = "0x170001B5")]
		protected bool ShouldUpdate
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x1256F44", Offset = "0x1256F44", VA = "0x1256F44")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x12565EC", Offset = "0x12565EC", VA = "0x12565EC", Slot = "4")]
		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1256E34", Offset = "0x1256E34", VA = "0x1256E34", Slot = "6")]
		public override Task<ImmutableCredentials> GetCredentialsAsync()
		{
			return null;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1256A18", Offset = "0x1256A18", VA = "0x1256A18")]
		private static void UpdateToGeneratedCredentials(CredentialsRefreshState state, TimeSpan preemptExpiryTime)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1256728", Offset = "0x1256728", VA = "0x1256728")]
		private static bool ShouldUpdateState(CredentialsRefreshState state, TimeSpan preemptExpiryTime)
		{
			return default;
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1256F50", Offset = "0x1256F50", VA = "0x1256F50", Slot = "8")]
		protected virtual CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1256F90", Offset = "0x1256F90", VA = "0x1256F90", Slot = "9")]
		protected virtual Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1257070", Offset = "0x1257070", VA = "0x1257070", Slot = "10")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x12570B8", Offset = "0x12570B8", VA = "0x12570B8", Slot = "11")]
		public virtual void ClearCredentials()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x12570C0", Offset = "0x12570C0", VA = "0x12570C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x124E978", Offset = "0x124E978", VA = "0x124E978")]
		protected RefreshingAWSCredentials()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1257140", Offset = "0x1257140", VA = "0x1257140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28F4C", Offset = "0x28F4C")]
		private CredentialsRefreshState _003CGenerateNewCredentialsAsync_003Eb__16_0()
		{
			return null;
		}
	}
}
