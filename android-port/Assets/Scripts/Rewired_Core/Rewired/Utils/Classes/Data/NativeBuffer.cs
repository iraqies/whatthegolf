using System;
using Il2CppDummyDll;

namespace Rewired.Utils.Classes.Data
{
	[Token(Token = "0x2000386")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x19224C", Offset = "0x19224C")]
	internal class NativeBuffer : IDisposable
	{
		[Token(Token = "0x4001201")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr RmRFxPdWrkdHQbuRfIypprJlmqQIA;

		[Token(Token = "0x4001202")]
		[FieldOffset(Offset = "0x18")]
		private int bmmUGyjLITCgyItghjjzIBmoICqaA;

		[Token(Token = "0x4001203")]
		[FieldOffset(Offset = "0x1C")]
		private bool AeWaeWamxRrERkciQkpFDWbRfZMkA;

		[Token(Token = "0x1700072C")]
		public IntPtr Pointer
		{
			[Token(Token = "0x6001B4D")]
			[Address(RVA = "0x23ED6B8", Offset = "0x23ED6B8", VA = "0x23ED6B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001B4E")]
		[Address(RVA = "0x23ED6C0", Offset = "0x23ED6C0", VA = "0x23ED6C0")]
		public NativeBuffer(int P_0)
		{
		}

		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0x23ED6F4", Offset = "0x23ED6F4", VA = "0x23ED6F4")]
		public bool Resize(int size, bool preserveData)
		{
			return default;
		}

		[Token(Token = "0x6001B50")]
		[Address(RVA = "0x23ED9C8", Offset = "0x23ED9C8", VA = "0x23ED9C8")]
		public void Release()
		{
		}

		[Token(Token = "0x6001B51")]
		[Address(RVA = "0x23EEA14", Offset = "0x23EEA14", VA = "0x23EEA14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6001B52")]
		[Address(RVA = "0x23EEBC4", Offset = "0x23EEBC4", VA = "0x23EEBC4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001B53")]
		[Address(RVA = "0x23EEC44", Offset = "0x23EEC44", VA = "0x23EEC44", Slot = "1")]
		~NativeBuffer()
		{
		}

		[Token(Token = "0x6001B54")]
		[Address(RVA = "0x23EECF4", Offset = "0x23EECF4", VA = "0x23EECF4", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6001B55")]
		[Address(RVA = "0x23EED24", Offset = "0x23EED24", VA = "0x23EED24")]
		public static implicit operator IntPtr(NativeBuffer buffer)
		{
			return default;
		}
	}
}
