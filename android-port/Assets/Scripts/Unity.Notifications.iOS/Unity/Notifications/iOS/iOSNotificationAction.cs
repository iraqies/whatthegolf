using System;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x200000D")]
	public class iOSNotificationAction
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F28", Offset = "0x1B4F28")]
		private string Id__BackingField;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F38", Offset = "0x1B4F38")]
		private string Title__BackingField;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F48", Offset = "0x1B4F48")]
		private iOSNotificationActionOptions Options__BackingField;

		[Token(Token = "0x1700000E")]
		public string Id
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x2A42CA4", Offset = "0x2A42CA4", VA = "0x2A42CA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B50F8", Offset = "0x1B50F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public string Title
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2A42CAC", Offset = "0x2A42CAC", VA = "0x2A42CAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5108", Offset = "0x1B5108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public iOSNotificationActionOptions Options
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x2A42CB4", Offset = "0x2A42CB4", VA = "0x2A42CB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5118", Offset = "0x1B5118")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2A42CBC", Offset = "0x2A42CBC", VA = "0x2A42CBC", Slot = "4")]
		internal virtual IntPtr CreateUNNotificationAction()
		{
			return default;
		}
	}
}
