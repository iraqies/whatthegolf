using System;
using System.Collections.Generic;
using Core;
using Hub;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000ED6")]
public class DailyChallengeLevelDataContainer : LevelDataContainer, IPackWithData
{
	[Serializable]
	[Token(Token = "0x2000ED7")]
	public struct PunData
	{
		[Token(Token = "0x400502F")]
		[FieldOffset(Offset = "0x0")]
		public string LevelName;

		[Token(Token = "0x4005030")]
		[FieldOffset(Offset = "0x8")]
		public string LocalizedCompletionID;
	}

	[Serializable]
	[Token(Token = "0x2000ED8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45450", Offset = "0x45450")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4005031")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4005032")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PunData, string> _003C_003E9__39_0;

		[Token(Token = "0x600454B")]
		[Address(RVA = "0x1794D18", Offset = "0x1794D18", VA = "0x1794D18")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600454C")]
		[Address(RVA = "0x1794D20", Offset = "0x1794D20", VA = "0x1794D20")]
		internal string _003CSetPuns_003Eb__39_0(PunData p)
		{
			return null;
		}
	}

	[Token(Token = "0x2000ED9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45460", Offset = "0x45460")]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		[Token(Token = "0x4005033")]
		[FieldOffset(Offset = "0x10")]
		public string n;

		[Token(Token = "0x600454D")]
		[Address(RVA = "0x1794D28", Offset = "0x1794D28", VA = "0x1794D28")]
		public _003C_003Ec__DisplayClass42_0()
		{
		}

		[Token(Token = "0x600454E")]
		[Address(RVA = "0x1794D30", Offset = "0x1794D30", VA = "0x1794D30")]
		internal bool _003CPunCompletionID_003Eb__0(PunData p)
		{
			return default;
		}
	}

	[Token(Token = "0x400501F")]
	[FieldOffset(Offset = "0x30")]
	public Sprite menuIcon;

	[Token(Token = "0x4005020")]
	[FieldOffset(Offset = "0x38")]
	public DayOfWeek dayOfWeek;

	[Token(Token = "0x4005021")]
	[FieldOffset(Offset = "0x40")]
	public TransitionColorDefinition transitionColors;

	[Token(Token = "0x4005022")]
	[FieldOffset(Offset = "0x48")]
	public BaseTransitionEffect TransitionPrefab;

	[Token(Token = "0x4005023")]
	[FieldOffset(Offset = "0x50")]
	public Sprite TransitionSilhouette;

	[Token(Token = "0x4005024")]
	[FieldOffset(Offset = "0x58")]
	public bool UseSpecificDate;

	[Token(Token = "0x4005025")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string startDateString;

	[Token(Token = "0x4005026")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private string endDateString;

	[Token(Token = "0x4005027")]
	[FieldOffset(Offset = "0x70")]
	private DateTime? _startDate;

	[Token(Token = "0x4005028")]
	[FieldOffset(Offset = "0x80")]
	private DateTime? _endDate;

	[Token(Token = "0x4005029")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private bool isNewYears;

	[Token(Token = "0x400502A")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private List<UserCriteria> criteria;

	[Token(Token = "0x400502B")]
	[FieldOffset(Offset = "0xA0")]
	public DailyPrizeData.Prize mountain_prize_prefab;

	[Token(Token = "0x400502C")]
	[FieldOffset(Offset = "0xA8")]
	public LevelMusicSettings music;

	[Token(Token = "0x400502D")]
	[FieldOffset(Offset = "0xB0")]
	public List<PunData> puns;

	[Token(Token = "0x400502E")]
	[FieldOffset(Offset = "0xB8")]
	public SpecialDayRoomConfig RoomConfig;

	[Token(Token = "0x17000727")]
	public DateTime StartDate
	{
		[Token(Token = "0x6004534")]
		[Address(RVA = "0x18C9BD4", Offset = "0x18C9BD4", VA = "0x18C9BD4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000728")]
	public DateTime EndDate
	{
		[Token(Token = "0x6004535")]
		[Address(RVA = "0x18C9EEC", Offset = "0x18C9EEC", VA = "0x18C9EEC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000729")]
	public Sprite MenuIcon
	{
		[Token(Token = "0x6004536")]
		[Address(RVA = "0x18CA294", Offset = "0x18CA294", VA = "0x18CA294")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072A")]
	public string TitleID
	{
		[Token(Token = "0x6004537")]
		[Address(RVA = "0x18CA230", Offset = "0x18CA230", VA = "0x18CA230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072B")]
	public string ContentID
	{
		[Token(Token = "0x6004538")]
		[Address(RVA = "0x18CA300", Offset = "0x18CA300", VA = "0x18CA300", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072C")]
	public string PackID
	{
		[Token(Token = "0x6004539")]
		[Address(RVA = "0x18CA370", Offset = "0x18CA370", VA = "0x18CA370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072D")]
	public string PackName
	{
		[Token(Token = "0x600453A")]
		[Address(RVA = "0x18CA3E0", Offset = "0x18CA3E0", VA = "0x18CA3E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072E")]
	public string NotificationID
	{
		[Token(Token = "0x600453B")]
		[Address(RVA = "0x18CA4E4", Offset = "0x18CA4E4", VA = "0x18CA4E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700072F")]
	public bool IsSpecial
	{
		[Token(Token = "0x600453C")]
		[Address(RVA = "0x18CA504", Offset = "0x18CA504", VA = "0x18CA504")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000730")]
	public List<UserCriteria> Criteria
	{
		[Token(Token = "0x600453D")]
		[Address(RVA = "0x18CA50C", Offset = "0x18CA50C", VA = "0x18CA50C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000731")]
	public bool HasCustomTransition
	{
		[Token(Token = "0x600453E")]
		[Address(RVA = "0x18CA514", Offset = "0x18CA514", VA = "0x18CA514")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600453F")]
	[Address(RVA = "0x18CA5DC", Offset = "0x18CA5DC", VA = "0x18CA5DC")]
	public List<PunData> SetPuns()
	{
		return null;
	}

	[Token(Token = "0x6004540")]
	[Address(RVA = "0x18CAB6C", Offset = "0x18CAB6C", VA = "0x18CAB6C")]
	public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
	{
		return default;
	}

	[Token(Token = "0x6004541")]
	[Address(RVA = "0x18CA8F4", Offset = "0x18CA8F4", VA = "0x18CA8F4")]
	private string ToLevelName(LevelData l)
	{
		return null;
	}

	[Token(Token = "0x6004542")]
	[Address(RVA = "0x18CAC98", Offset = "0x18CAC98", VA = "0x18CAC98")]
	public string PunCompletionID(LevelData level)
	{
		return null;
	}

	[Token(Token = "0x6004543")]
	[Address(RVA = "0x18CA970", Offset = "0x18CA970", VA = "0x18CA970")]
	private string DefaultDailyIDLocalized(string id)
	{
		return null;
	}

	[Token(Token = "0x6004544")]
	[Address(RVA = "0x18CA468", Offset = "0x18CA468", VA = "0x18CA468")]
	private string Formatted(string s)
	{
		return null;
	}

	[Token(Token = "0x6004545")]
	[Address(RVA = "0x18CA29C", Offset = "0x18CA29C", VA = "0x18CA29C")]
	internal string GetMenuID()
	{
		return null;
	}

	[Token(Token = "0x6004546")]
	[Address(RVA = "0x18CAE50", Offset = "0x18CAE50", VA = "0x18CAE50")]
	public string GetStringID()
	{
		return null;
	}

	[Token(Token = "0x6004547")]
	[Address(RVA = "0x18CAE54", Offset = "0x18CAE54", VA = "0x18CAE54")]
	internal int GetID()
	{
		return default;
	}

	[Token(Token = "0x6004548")]
	[Address(RVA = "0x18CAE78", Offset = "0x18CAE78", VA = "0x18CAE78")]
	public bool IsActive(DateTime now)
	{
		return default;
	}

	[Token(Token = "0x6004549")]
	[Address(RVA = "0x18CAF40", Offset = "0x18CAF40", VA = "0x18CAF40")]
	public DailyChallengeLevelDataContainer()
	{
	}
}
