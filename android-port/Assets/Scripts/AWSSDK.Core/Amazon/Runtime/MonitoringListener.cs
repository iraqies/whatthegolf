using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x2000107")]
	internal sealed class MonitoringListener : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25BB4", Offset = "0x25BB4")]
		private struct _003CPostMessagesOverUDPAsync_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MonitoringListener _003C_003E4__this;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string response;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x128F8A4", Offset = "0x128F8A4", VA = "0x128F8A4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x128FC68", Offset = "0x128FC68", VA = "0x128FC68", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MonitoringListener csmMonitoringListenerInstance;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _host;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly UdpClient _udpClient;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Logger logger;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly int _port;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool _disposed;

		[Token(Token = "0x17000264")]
		public static MonitoringListener Instance
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x1240204", Offset = "0x1240204", VA = "0x1240204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x123FFB8", Offset = "0x123FFB8", VA = "0x123FFB8")]
		private MonitoringListener()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x12401A8", Offset = "0x12401A8", VA = "0x12401A8")]
		static MonitoringListener()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x1240268", Offset = "0x1240268", VA = "0x1240268")]
		public void PostMessagesOverUDP(string response)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x124026C", Offset = "0x124026C", VA = "0x124026C")]
		public Task PostMessagesOverUDPAsync(string response)
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x124034C", Offset = "0x124034C", VA = "0x124034C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x12403D4", Offset = "0x12403D4", VA = "0x12403D4")]
		private void Dispose(bool disposing)
		{
		}
	}
}
