using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x200000B")]
	public class iOSNotification
	{
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F08", Offset = "0x1B4F08")]
		private float? SoundVolume__BackingField;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F18", Offset = "0x1B4F18")]
		private List<iOSNotificationAttachment> Attachments__BackingField;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		private iOSNotificationData data;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<string, string> userInfo;

		[Token(Token = "0x17000005")]
		public string Identifier
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2A41F88", Offset = "0x2A41F88", VA = "0x2A41F88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public string Title
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2A41F90", Offset = "0x2A41F90", VA = "0x2A41F90")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public string Body
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2A41F98", Offset = "0x2A41F98", VA = "0x2A41F98")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool ShowInForeground
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2A41FA0", Offset = "0x2A41FA0", VA = "0x2A41FA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public PresentationOption ForegroundPresentationOption
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2A4204C", Offset = "0x2A4204C", VA = "0x2A4204C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float? SoundVolume
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2A420E8", Offset = "0x2A420E8", VA = "0x2A420E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B50C8", Offset = "0x1B50C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public string Data
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2A420F0", Offset = "0x2A420F0", VA = "0x2A420F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2A42174", Offset = "0x2A42174", VA = "0x2A42174")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public List<iOSNotificationAttachment> Attachments
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2A421F0", Offset = "0x2A421F0", VA = "0x2A421F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B50D8", Offset = "0x1B50D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2A421F8", Offset = "0x2A421F8", VA = "0x2A421F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B50E8", Offset = "0x1B50E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public iOSNotificationTrigger Trigger
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2A42200", Offset = "0x2A42200", VA = "0x2A42200")]
			set
			{
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A428AC", Offset = "0x2A428AC", VA = "0x2A428AC")]
		private static string GenerateUniqueID()
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A429A8", Offset = "0x2A429A8", VA = "0x2A429A8")]
		public iOSNotification(string identifier)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A42B7C", Offset = "0x2A42B7C", VA = "0x2A42B7C")]
		internal iOSNotification(iOSNotificationWithUserInfo data)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A42BD0", Offset = "0x2A42BD0", VA = "0x2A42BD0")]
		internal iOSNotificationWithUserInfo GetDataForSending()
		{
			return default;
		}
	}
}
