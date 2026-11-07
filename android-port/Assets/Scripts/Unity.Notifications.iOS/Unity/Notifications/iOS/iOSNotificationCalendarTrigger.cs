using System;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x200001A")]
	public struct iOSNotificationCalendarTrigger : iOSNotificationTrigger
	{
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5048", Offset = "0x1B5048")]
		private int? Year__BackingField;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5058", Offset = "0x1B5058")]
		private int? Month__BackingField;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5068", Offset = "0x1B5068")]
		private int? Day__BackingField;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5078", Offset = "0x1B5078")]
		private int? Hour__BackingField;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5088", Offset = "0x1B5088")]
		private int? Minute__BackingField;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5098", Offset = "0x1B5098")]
		private int? Second__BackingField;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B50A8", Offset = "0x1B50A8")]
		private bool UtcTime__BackingField;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B50B8", Offset = "0x1B50B8")]
		private bool Repeats__BackingField;

		[Token(Token = "0x17000026")]
		public iOSNotificationTriggerType Type
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2A42DA8", Offset = "0x2A42DA8", VA = "0x2A42DA8", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000027")]
		public int? Year
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2A42DB0", Offset = "0x2A42DB0", VA = "0x2A42DB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5228", Offset = "0x1B5228")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2A42DB8", Offset = "0x2A42DB8", VA = "0x2A42DB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5238", Offset = "0x1B5238")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public int? Month
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2A42DC0", Offset = "0x2A42DC0", VA = "0x2A42DC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5248", Offset = "0x1B5248")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2A42DC8", Offset = "0x2A42DC8", VA = "0x2A42DC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5258", Offset = "0x1B5258")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public int? Day
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2A42DD0", Offset = "0x2A42DD0", VA = "0x2A42DD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5268", Offset = "0x1B5268")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2A42DD8", Offset = "0x2A42DD8", VA = "0x2A42DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5278", Offset = "0x1B5278")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public int? Hour
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2A42DE0", Offset = "0x2A42DE0", VA = "0x2A42DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5288", Offset = "0x1B5288")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2A42DE8", Offset = "0x2A42DE8", VA = "0x2A42DE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5298", Offset = "0x1B5298")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int? Minute
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2A42DF0", Offset = "0x2A42DF0", VA = "0x2A42DF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B52A8", Offset = "0x1B52A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2A42DF8", Offset = "0x2A42DF8", VA = "0x2A42DF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B52B8", Offset = "0x1B52B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public int? Second
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2A42E00", Offset = "0x2A42E00", VA = "0x2A42E00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B52C8", Offset = "0x1B52C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2A42E08", Offset = "0x2A42E08", VA = "0x2A42E08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B52D8", Offset = "0x1B52D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool UtcTime
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2A42E10", Offset = "0x2A42E10", VA = "0x2A42E10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B52E8", Offset = "0x1B52E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x2A42E18", Offset = "0x2A42E18", VA = "0x2A42E18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B52F8", Offset = "0x1B52F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool Repeats
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2A42E20", Offset = "0x2A42E20", VA = "0x2A42E20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5308", Offset = "0x1B5308")]
			get
			{
				return default;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2A42E28", Offset = "0x2A42E28", VA = "0x2A42E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5318", Offset = "0x1B5318")]
			set
			{
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2A427B4", Offset = "0x2A427B4", VA = "0x2A427B4")]
		public iOSNotificationCalendarTrigger ToUtc()
		{
			return default;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2A42E30", Offset = "0x2A42E30", VA = "0x2A42E30")]
		internal DateTime AssignDateTimeComponents(DateTime dt)
		{
			return default;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2A43018", Offset = "0x2A43018", VA = "0x2A43018")]
		internal void AssignNonEmptyComponents(DateTime dt)
		{
		}
	}
}
