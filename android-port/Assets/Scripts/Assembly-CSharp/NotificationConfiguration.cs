using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000952")]
public class NotificationConfiguration : ScriptableObject
{
	[Token(Token = "0x400334E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<WTGNotification> notifications;

	[Token(Token = "0x1700047A")]
	public List<WTGNotification> Notifications
	{
		[Token(Token = "0x6002B7C")]
		[Address(RVA = "0x158E268", Offset = "0x158E268", VA = "0x158E268")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002B7D")]
	[Address(RVA = "0x158E2E4", Offset = "0x158E2E4", VA = "0x158E2E4")]
	public NotificationConfiguration()
	{
	}
}
