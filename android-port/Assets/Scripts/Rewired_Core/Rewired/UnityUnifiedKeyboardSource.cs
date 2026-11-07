using System;
using Il2CppDummyDll;
using Rewired.Interfaces;

namespace Rewired
{
	[Token(Token = "0x20000C0")]
	internal class UnityUnifiedKeyboardSource : IDisposable, IGetSetEnabled, IUnifiedKeyboardSource
	{
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x0")]
		private static HardwareControllerMap_Game NadPxXYRifMljEYjJuhjIbsPVNdr;

		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x10")]
		private bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x11")]
		private bool AeWaeWamxRrERkciQkpFDWbRfZMkA;

		[Token(Token = "0x17000196")]
		public bool enabled
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x2437780", Offset = "0x2437780", VA = "0x2437780", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public InputSource inputSource
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x24377D4", Offset = "0x24377D4", VA = "0x24377D4", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000198")]
		public HardwareControllerMap_Game hardwareMap
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x24377DC", Offset = "0x24377DC", VA = "0x24377DC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000199")]
		public Controller.Extension controllerExtension
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x2437CA8", Offset = "0x2437CA8", VA = "0x2437CA8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x2437CB0", Offset = "0x2437CB0", VA = "0x2437CB0")]
		public UnityUnifiedKeyboardSource()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x2437D08", Offset = "0x2437D08", VA = "0x2437D08", Slot = "9")]
		public void UpdateInputData(ControllerDataUpdater dataUpdater)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x24377D0", Offset = "0x24377D0", VA = "0x24377D0", Slot = "10")]
		public void Clear()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x2437848", Offset = "0x2437848", VA = "0x2437848")]
		private static HardwareControllerMap_Game HStMDbOieMaNNxlRQxuGsFEKKaRE()
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x2437D58", Offset = "0x2437D58", VA = "0x2437D58", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x2437DD8", Offset = "0x2437DD8", VA = "0x2437DD8", Slot = "1")]
		~UnityUnifiedKeyboardSource()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2437E88", Offset = "0x2437E88", VA = "0x2437E88", Slot = "11")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
