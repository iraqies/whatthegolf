using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.SharedInterfaces.Internal
{
	[Token(Token = "0x2000110")]
	public class CoreAmazonKMS : ICoreAmazonKMS, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25BC4", Offset = "0x25BC4")]
		private struct _003CDecryptAsync_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoreAmazonKMS _003C_003E4__this;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] ciphertextBlob;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Dictionary<string, string> encryptionContext;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x1289360", Offset = "0x1289360", VA = "0x1289360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000900")]
			[Address(RVA = "0x1289618", Offset = "0x1289618", VA = "0x1289618", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25BD4", Offset = "0x25BD4")]
		private struct _003CGenerateDataKeyAsync_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GenerateDataKeyResult> _003C_003Et__builder;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoreAmazonKMS _003C_003E4__this;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string keyID;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Dictionary<string, string> encryptionContext;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string keySpec;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<GenerateDataKeyResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x1289674", Offset = "0x1289674", VA = "0x1289674", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1289934", Offset = "0x1289934", VA = "0x1289934", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object wrappedClientLock;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ICoreAmazonKMS wrappedClient;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AmazonServiceClient existingClient;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string feature;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool disposed;

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x11E5560", Offset = "0x11E5560", VA = "0x11E5560")]
		public CoreAmazonKMS(AmazonServiceClient existingClient, string feature)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x11E55E4", Offset = "0x11E55E4", VA = "0x11E55E4", Slot = "5")]
		public byte[] Decrypt(byte[] ciphertextBlob, Dictionary<string, string> encryptionContext)
		{
			return null;
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x11E57A4", Offset = "0x11E57A4", VA = "0x11E57A4", Slot = "4")]
		public GenerateDataKeyResult GenerateDataKey(string keyID, Dictionary<string, string> encryptionContext, string keySpec)
		{
			return null;
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x11E5888", Offset = "0x11E5888", VA = "0x11E5888", Slot = "7")]
		public Task<byte[]> DecryptAsync(byte[] ciphertextBlob, Dictionary<string, string> encryptionContext)
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x11E59AC", Offset = "0x11E59AC", VA = "0x11E59AC", Slot = "6")]
		public Task<GenerateDataKeyResult> GenerateDataKeyAsync(string keyID, Dictionary<string, string> encryptionContext, string keySpec)
		{
			return null;
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x11E56BC", Offset = "0x11E56BC", VA = "0x11E56BC")]
		private void EnsureWrappedClientIsInstantiated()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x11E5AD4", Offset = "0x11E5AD4", VA = "0x11E5AD4")]
		private static ICoreAmazonKMS CreateFromExistingClient(AmazonServiceClient existingClient, string feature)
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x11E5CA8", Offset = "0x11E5CA8", VA = "0x11E5CA8", Slot = "8")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x11E5D28", Offset = "0x11E5D28", VA = "0x11E5D28", Slot = "9")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
