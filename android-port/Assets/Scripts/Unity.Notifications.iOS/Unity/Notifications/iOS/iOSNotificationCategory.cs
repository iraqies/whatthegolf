using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000010")]
	public class iOSNotificationCategory
	{
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x10")]
		private List<iOSNotificationAction> m_Actions;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x18")]
		private List<string> m_IntentIdentifiers;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F78", Offset = "0x1B4F78")]
		private string Id__BackingField;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F88", Offset = "0x1B4F88")]
		private string HiddenPreviewsBodyPlaceholder__BackingField;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F98", Offset = "0x1B4F98")]
		private string SummaryFormat__BackingField;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4FA8", Offset = "0x1B4FA8")]
		private iOSNotificationCategoryOptions Options__BackingField;

		[Token(Token = "0x17000013")]
		public string Id
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2A431C0", Offset = "0x2A431C0", VA = "0x2A431C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5168", Offset = "0x1B5168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public iOSNotificationAction[] Actions
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2A431C8", Offset = "0x2A431C8", VA = "0x2A431C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public string[] IntentIdentifiers
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2A4321C", Offset = "0x2A4321C", VA = "0x2A4321C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public string HiddenPreviewsBodyPlaceholder
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2A43270", Offset = "0x2A43270", VA = "0x2A43270")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5178", Offset = "0x1B5178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public string SummaryFormat
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2A43278", Offset = "0x2A43278", VA = "0x2A43278")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5188", Offset = "0x1B5188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public iOSNotificationCategoryOptions Options
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2A43280", Offset = "0x2A43280", VA = "0x2A43280")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5198", Offset = "0x1B5198")]
			get
			{
				return default;
			}
		}
	}
}
