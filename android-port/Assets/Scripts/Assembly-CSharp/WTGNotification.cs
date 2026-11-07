using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000959")]
public struct WTGNotification
{
	[Serializable]
	[Token(Token = "0x200095A")]
	public class LevelDataList
	{
		[Token(Token = "0x4003371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<LevelData> levels;

		[Token(Token = "0x6002BA7")]
		[Address(RVA = "0x1875088", Offset = "0x1875088", VA = "0x1875088")]
		public LevelDataList()
		{
		}
	}

	[Token(Token = "0x200095B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42240", Offset = "0x42240")]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		[Token(Token = "0x4003372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string notId;

		[Token(Token = "0x6002BA8")]
		[Address(RVA = "0x1874F84", Offset = "0x1874F84", VA = "0x1874F84")]
		public _003C_003Ec__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6002BA9")]
		[Address(RVA = "0x1874F8C", Offset = "0x1874F8C", VA = "0x1874F8C")]
		internal bool _003Cget_Text_003Eb__0(WTGNotification x)
		{
			return default;
		}
	}

	[Token(Token = "0x200095C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42250", Offset = "0x42250")]
	private sealed class _003C_003Ec__DisplayClass44_0
	{
		[Token(Token = "0x4003373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string notId;

		[Token(Token = "0x6002BAA")]
		[Address(RVA = "0x1874FA0", Offset = "0x1874FA0", VA = "0x1874FA0")]
		public _003C_003Ec__DisplayClass44_0()
		{
		}

		[Token(Token = "0x6002BAB")]
		[Address(RVA = "0x1874FA8", Offset = "0x1874FA8", VA = "0x1874FA8")]
		internal bool _003Cget_Title_003Eb__0(WTGNotification x)
		{
			return default;
		}
	}

	[Token(Token = "0x200095D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42260", Offset = "0x42260")]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		[Token(Token = "0x4003374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id1;

		[Token(Token = "0x6002BAC")]
		[Address(RVA = "0x1874FBC", Offset = "0x1874FBC", VA = "0x1874FBC")]
		public _003C_003Ec__DisplayClass48_0()
		{
		}

		[Token(Token = "0x6002BAD")]
		[Address(RVA = "0x1874FC4", Offset = "0x1874FC4", VA = "0x1874FC4")]
		internal bool _003Cget_ChallengePack_003Eb__0(DailyChallengeLevelDataContainer x)
		{
			return default;
		}
	}

	[Token(Token = "0x200095E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42270", Offset = "0x42270")]
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		[Token(Token = "0x4003375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int fails;

		[Token(Token = "0x4003376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string levelID;

		[Token(Token = "0x4003377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string packName;

		[Token(Token = "0x4003378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DateTime? day;

		[Token(Token = "0x6002BAE")]
		[Address(RVA = "0x1874FFC", Offset = "0x1874FFC", VA = "0x1874FFC")]
		public _003C_003Ec__DisplayClass55_0()
		{
		}

		[Token(Token = "0x6002BAF")]
		[Address(RVA = "0x1875004", Offset = "0x1875004", VA = "0x1875004")]
		internal bool _003CValidateCriteria_003Eb__0(UserCriteria x)
		{
			return default;
		}
	}

	[Token(Token = "0x4003361")]
	private const string TYPE_PACK = "pack";

	[Token(Token = "0x4003362")]
	private const string TYPE_CONTENTPACK = "contentPack";

	[Token(Token = "0x4003363")]
	private const string TYPE_OTHER = "other";

	[Token(Token = "0x4003364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	private string id;

	[Token(Token = "0x4003365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[SerializeField]
	private string localizationId;

	[Token(Token = "0x4003366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string localizationIdTitle;

	[Token(Token = "0x4003367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string gameboyDescription;

	[Token(Token = "0x4003368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string gameboyTitle;

	[Token(Token = "0x4003369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite image;

	[Token(Token = "0x400336A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ENotificationType type;

	[Token(Token = "0x400336B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string packId;

	[Token(Token = "0x400336C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private LevelDataList levels;

	[Token(Token = "0x400336D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<UserCriteria> criteria;

	[Token(Token = "0x400336E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x4FB64", Offset = "0x4FB64")]
	public bool skipGameboyPopup;

	[Token(Token = "0x400336F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FB9C", Offset = "0x4FB9C")]
	private Func<bool> ShouldSend__BackingField;

	[NonSerialized]
	[Token(Token = "0x4003370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool NotRecognized;

	[Token(Token = "0x1700047B")]
	public Func<bool> ShouldSend
	{
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x174BE78", Offset = "0x174BE78", VA = "0x174BE78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67B84", Offset = "0x67B84")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0x174BE80", Offset = "0x174BE80", VA = "0x174BE80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67B94", Offset = "0x67B94")]
		set
		{
		}
	}

	[Token(Token = "0x1700047C")]
	public string Id
	{
		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0x174BE88", Offset = "0x174BE88", VA = "0x174BE88")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002B90")]
		[Address(RVA = "0x174BE90", Offset = "0x174BE90", VA = "0x174BE90")]
		set
		{
		}
	}

	[Token(Token = "0x1700047D")]
	public ENotificationType Type
	{
		[Token(Token = "0x6002B91")]
		[Address(RVA = "0x174BE98", Offset = "0x174BE98", VA = "0x174BE98")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700047E")]
	public string LocalizationId
	{
		[Token(Token = "0x6002B92")]
		[Address(RVA = "0x174BEA0", Offset = "0x174BEA0", VA = "0x174BEA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047F")]
	public string LocalizationIdTitle
	{
		[Token(Token = "0x6002B93")]
		[Address(RVA = "0x174BEA8", Offset = "0x174BEA8", VA = "0x174BEA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000480")]
	public string GameboyDescription
	{
		[Token(Token = "0x6002B94")]
		[Address(RVA = "0x174BEB0", Offset = "0x174BEB0", VA = "0x174BEB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000481")]
	public string GameboyTitle
	{
		[Token(Token = "0x6002B95")]
		[Address(RVA = "0x174BEB8", Offset = "0x174BEB8", VA = "0x174BEB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000482")]
	public Sprite Image
	{
		[Token(Token = "0x6002B96")]
		[Address(RVA = "0x174BEC0", Offset = "0x174BEC0", VA = "0x174BEC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000483")]
	public List<UserCriteria> Criteria
	{
		[Token(Token = "0x6002B97")]
		[Address(RVA = "0x174BEC8", Offset = "0x174BEC8", VA = "0x174BEC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000484")]
	public List<LevelData> Levels
	{
		[Token(Token = "0x6002B98")]
		[Address(RVA = "0x174BED0", Offset = "0x174BED0", VA = "0x174BED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000485")]
	public bool IsValid
	{
		[Token(Token = "0x6002B99")]
		[Address(RVA = "0x174BF00", Offset = "0x174BF00", VA = "0x174BF00")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000486")]
	public string Text
	{
		[Token(Token = "0x6002B9A")]
		[Address(RVA = "0x174BF20", Offset = "0x174BF20", VA = "0x174BF20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000487")]
	public string Title
	{
		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x174C1A4", Offset = "0x174C1A4", VA = "0x174C1A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000488")]
	public ContentPackDef Pack
	{
		[Token(Token = "0x6002B9C")]
		[Address(RVA = "0x174C374", Offset = "0x174C374", VA = "0x174C374")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000489")]
	public IPackWithData ChallengePack
	{
		[Token(Token = "0x6002B9D")]
		[Address(RVA = "0x174C3C0", Offset = "0x174C3C0", VA = "0x174C3C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002B9E")]
	[Address(RVA = "0x174C590", Offset = "0x174C590", VA = "0x174C590")]
	public WTGNotification(string url)
	{
	}

	[Token(Token = "0x6002B9F")]
	[Address(RVA = "0x174C79C", Offset = "0x174C79C", VA = "0x174C79C")]
	private WTGNotification(WTGNotification other)
	{
	}

	[Token(Token = "0x6002BA0")]
	[Address(RVA = "0x174C800", Offset = "0x174C800", VA = "0x174C800")]
	public ScheduledNotification ToScheduled(DateTimeOffset time)
	{
		return default;
	}

	[Token(Token = "0x6002BA1")]
	[Address(RVA = "0x174C85C", Offset = "0x174C85C", VA = "0x174C85C")]
	public bool ValidateCriteria([Optional][DefaultParameterValue(-1)] int fails, [Optional][DefaultParameterValue("")] string levelID, [Optional][DefaultParameterValue("")] string packName, [Optional] DateTime? day)
	{
		return default;
	}

	[Token(Token = "0x6002BA2")]
	[Address(RVA = "0x174C990", Offset = "0x174C990", VA = "0x174C990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002BA3")]
	[Address(RVA = "0x174C998", Offset = "0x174C998", VA = "0x174C998", Slot = "0")]
	public override bool Equals(object other)
	{
		return default;
	}

	[Token(Token = "0x6002BA4")]
	[Address(RVA = "0x174CA6C", Offset = "0x174CA6C", VA = "0x174CA6C")]
	public bool Equals(WTGNotification other)
	{
		return default;
	}

	[Token(Token = "0x6002BA5")]
	[Address(RVA = "0x174CD18", Offset = "0x174CD18", VA = "0x174CD18")]
	public static bool operator ==(WTGNotification lhs, WTGNotification rhs)
	{
		return default;
	}

	[Token(Token = "0x6002BA6")]
	[Address(RVA = "0x174CAA0", Offset = "0x174CAA0", VA = "0x174CAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default;
	}
}
