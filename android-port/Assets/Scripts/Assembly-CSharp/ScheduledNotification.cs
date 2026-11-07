using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000CB8")]
public struct ScheduledNotification
{
	[Token(Token = "0x4004540")]
	[FieldOffset(Offset = "0x0")]
	private static DateTimeOffset DefaultDateTime;

	[Token(Token = "0x4004541")]
	[FieldOffset(Offset = "0x0")]
	private string dateTime;

	[Token(Token = "0x4004542")]
	[FieldOffset(Offset = "0x8")]
	private string id;

	[Token(Token = "0x4004543")]
	[FieldOffset(Offset = "0x10")]
	private DateTimeOffset? parsedDateTime;

	[Token(Token = "0x4004544")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x512D4", Offset = "0x512D4")]
	private bool IsValid__BackingField;

	[Token(Token = "0x4004545")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string[] Iso8601Formats;

	[Token(Token = "0x1700061A")]
	public WTGNotification Notification
	{
		[Token(Token = "0x6003C0C")]
		[Address(RVA = "0x167BCC0", Offset = "0x167BCC0", VA = "0x167BCC0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700061B")]
	public bool IsValid
	{
		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0x167BFE0", Offset = "0x167BFE0", VA = "0x167BFE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B988", Offset = "0x6B988")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003C10")]
		[Address(RVA = "0x167BFE8", Offset = "0x167BFE8", VA = "0x167BFE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B998", Offset = "0x6B998")]
		private set
		{
		}
	}

	[Token(Token = "0x1700061C")]
	public DateTimeOffset DateTime
	{
		[Token(Token = "0x6003C11")]
		[Address(RVA = "0x167BFF0", Offset = "0x167BFF0", VA = "0x167BFF0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700061D")]
	public string ID
	{
		[Token(Token = "0x6003C12")]
		[Address(RVA = "0x167C0A8", Offset = "0x167C0A8", VA = "0x167C0A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700061E")]
	public string DateTimeText
	{
		[Token(Token = "0x6003C13")]
		[Address(RVA = "0x167C0B0", Offset = "0x167C0B0", VA = "0x167C0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700061F")]
	public string Identifier
	{
		[Token(Token = "0x6003C14")]
		[Address(RVA = "0x167C0B8", Offset = "0x167C0B8", VA = "0x167C0B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003C0D")]
	[Address(RVA = "0x167BCE4", Offset = "0x167BCE4", VA = "0x167BCE4")]
	public ScheduledNotification(string id, string dateTime)
	{
	}

	[Token(Token = "0x6003C0E")]
	[Address(RVA = "0x167BEC4", Offset = "0x167BEC4", VA = "0x167BEC4")]
	public ScheduledNotification(WTGNotification notification, DateTimeOffset dt)
	{
	}

	[Token(Token = "0x6003C15")]
	[Address(RVA = "0x167C208", Offset = "0x167C208", VA = "0x167C208", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003C16")]
	[Address(RVA = "0x167BCF8", Offset = "0x167BCF8", VA = "0x167BCF8")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6003C17")]
	[Address(RVA = "0x167C260", Offset = "0x167C260", VA = "0x167C260")]
	public static bool TryParseNotification(string str, out ScheduledNotification notification)
	{
		return default;
	}

	[Token(Token = "0x6003C18")]
	[Address(RVA = "0x167C360", Offset = "0x167C360", VA = "0x167C360", Slot = "0")]
	public override bool Equals(object other)
	{
		return default;
	}

	[Token(Token = "0x6003C19")]
	[Address(RVA = "0x167C414", Offset = "0x167C414", VA = "0x167C414")]
	public bool Equals(ScheduledNotification p)
	{
		return default;
	}

	[Token(Token = "0x6003C1A")]
	[Address(RVA = "0x167C460", Offset = "0x167C460", VA = "0x167C460", Slot = "2")]
	public override int GetHashCode()
	{
		return default;
	}
}
