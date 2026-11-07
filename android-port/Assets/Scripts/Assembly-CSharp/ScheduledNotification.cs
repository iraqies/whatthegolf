using System;

[Serializable]
public struct ScheduledNotification
{
	private static DateTimeOffset DefaultDateTime;

	private string dateTime;

	private string id;

	private DateTimeOffset? parsedDateTime;

	public static readonly string[] Iso8601Formats;

	public WTGNotification Notification => default;

	public bool IsValid { get; private set; }

	public DateTimeOffset DateTime => default;

	public string ID => null;

	public string DateTimeText => null;

	public string Identifier => null;

	public ScheduledNotification(string id, string dateTime)
	{
		this.dateTime = null;
		this.id = null;
		parsedDateTime = null;
		IsValid = false;
	}

	public ScheduledNotification(WTGNotification notification, DateTimeOffset dt)
	{
		dateTime = null;
		id = null;
		parsedDateTime = null;
		IsValid = false;
	}

	public override string ToString()
	{
		return null;
	}

	private void Initialize()
	{
	}

	public static bool TryParseNotification(string str, out ScheduledNotification notification)
	{
		notification = default;
		return false;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public bool Equals(ScheduledNotification p)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
