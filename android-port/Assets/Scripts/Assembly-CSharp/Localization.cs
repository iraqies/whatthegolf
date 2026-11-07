using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using I2.Loc;
using Il2CppDummyDll;

[Token(Token = "0x20004DF")]
public class Localization
{
	[Token(Token = "0x20004E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FF34", Offset = "0x3FF34")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x400198F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x600168A")]
		[Address(RVA = "0x17ECD00", Offset = "0x17ECD00", VA = "0x17ECD00")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x600168B")]
		[Address(RVA = "0x17ECD08", Offset = "0x17ECD08", VA = "0x17ECD08")]
		internal bool _003CHasTerm_003Eb__0(LanguageSourceData s)
		{
			return default;
		}
	}

	[Token(Token = "0x20004E1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FF44", Offset = "0x3FF44")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4001990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4001991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string translated;

		[Token(Token = "0x600168C")]
		[Address(RVA = "0x17ECD2C", Offset = "0x17ECD2C", VA = "0x17ECD2C")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x600168D")]
		[Address(RVA = "0x17ECD34", Offset = "0x17ECD34", VA = "0x17ECD34")]
		internal string _003CGetString_003Eb__0()
		{
			return null;
		}

		[Token(Token = "0x600168E")]
		[Address(RVA = "0x17ECDA4", Offset = "0x17ECDA4", VA = "0x17ECDA4")]
		internal string _003CGetString_003Eb__1()
		{
			return null;
		}
	}

	[Token(Token = "0x20004E2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FF54", Offset = "0x3FF54")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4001992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LocalizationFontStyle style;

		[Token(Token = "0x4001993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Localization _003C_003E4__this;

		[Token(Token = "0x600168F")]
		[Address(RVA = "0x17ECF3C", Offset = "0x17ECF3C", VA = "0x17ECF3C")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6001690")]
		[Address(RVA = "0x17ECF44", Offset = "0x17ECF44", VA = "0x17ECF44")]
		internal string _003CGetFont_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x20004E3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FF64", Offset = "0x3FF64")]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x4001994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x6001691")]
		[Address(RVA = "0x17ECFB0", Offset = "0x17ECFB0", VA = "0x17ECFB0")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6001692")]
		[Address(RVA = "0x17ECFB8", Offset = "0x17ECFB8", VA = "0x17ECFB8")]
		internal string _003CLoadFontCollection_003Eb__0()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x20004E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FF74", Offset = "0x3FF74")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<string> _003C_003E9__22_0;

		[Token(Token = "0x6001694")]
		[Address(RVA = "0x17ECCB4", Offset = "0x17ECCB4", VA = "0x17ECCB4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001695")]
		[Address(RVA = "0x17ECCBC", Offset = "0x17ECCBC", VA = "0x17ECCBC")]
		internal string _003Cget_Instance_003Eb__22_0()
		{
			return null;
		}
	}

	[Token(Token = "0x4001989")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<string, LocalizationFont> fonts;

	[Token(Token = "0x400198A")]
	private const string TAG = "Localization";

	[Token(Token = "0x400198B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly pLogger dbg;

	[Token(Token = "0x400198C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly pLogger dbg_details;

	[Token(Token = "0x400198D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Action OnLanguageChangedEvent;

	[Token(Token = "0x400198E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Localization instance;

	[Token(Token = "0x1700027B")]
	public static Localization Instance
	{
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x153D020", Offset = "0x153D020", VA = "0x153D020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001679")]
	[Address(RVA = "0x153B024", Offset = "0x153B024", VA = "0x153B024")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6282C", Offset = "0x6282C")]
	private static void Init()
	{
	}

	[Token(Token = "0x600167A")]
	[Address(RVA = "0x153B088", Offset = "0x153B088", VA = "0x153B088")]
	static Localization()
	{
	}

	[Token(Token = "0x600167B")]
	[Address(RVA = "0x153B2F0", Offset = "0x153B2F0", VA = "0x153B2F0")]
	public void ChangeLanguage(string languageId)
	{
	}

	[Token(Token = "0x600167C")]
	[Address(RVA = "0x153B5B4", Offset = "0x153B5B4", VA = "0x153B5B4")]
	public string GetCurrentLanguage()
	{
		return null;
	}

	[Token(Token = "0x600167D")]
	[Address(RVA = "0x153B654", Offset = "0x153B654", VA = "0x153B654")]
	public bool IsEnglish()
	{
		return default;
	}

	[Token(Token = "0x600167E")]
	[Address(RVA = "0x153B6A0", Offset = "0x153B6A0", VA = "0x153B6A0")]
	public string ReverseCustomTextIfNecessary(string text)
	{
		return null;
	}

	[Token(Token = "0x600167F")]
	[Address(RVA = "0x153B750", Offset = "0x153B750", VA = "0x153B750")]
	public string GetNextLanguage()
	{
		return null;
	}

	[Token(Token = "0x6001680")]
	[Address(RVA = "0x153BB28", Offset = "0x153BB28", VA = "0x153BB28")]
	public bool HasTerm(string id)
	{
		return default;
	}

	[Token(Token = "0x6001681")]
	[Address(RVA = "0x153BC54", Offset = "0x153BC54", VA = "0x153BC54")]
	public string GetStringWithFormat(string id, params object[] values)
	{
		return null;
	}

	[Token(Token = "0x6001682")]
	[Address(RVA = "0x153BF04", Offset = "0x153BF04", VA = "0x153BF04")]
	public string GetEnglishString(string id)
	{
		return null;
	}

	[Token(Token = "0x6001683")]
	[Address(RVA = "0x153BF5C", Offset = "0x153BF5C", VA = "0x153BF5C")]
	public string GetString(string id, [Optional][DefaultParameterValue(false)] bool suppressWarnings, [Optional] string overrideLanguage)
	{
		return null;
	}

	[Token(Token = "0x6001684")]
	[Address(RVA = "0x153C774", Offset = "0x153C774", VA = "0x153C774")]
	public LocalizationFont GetFont(LocalizationFontStyle style)
	{
		return null;
	}

	[Token(Token = "0x6001685")]
	[Address(RVA = "0x153C8FC", Offset = "0x153C8FC", VA = "0x153C8FC")]
	private void RegisterForLanguageChanges()
	{
	}

	[Token(Token = "0x6001686")]
	[Address(RVA = "0x153CABC", Offset = "0x153CABC", VA = "0x153CABC")]
	private void OnLanguageChanged()
	{
	}

	[Token(Token = "0x6001687")]
	[Address(RVA = "0x153CCDC", Offset = "0x153CCDC", VA = "0x153CCDC")]
	private void LoadFontCollection(string fontCollectionName)
	{
	}

	[Token(Token = "0x6001689")]
	[Address(RVA = "0x153D2C0", Offset = "0x153D2C0", VA = "0x153D2C0")]
	public Localization()
	{
	}
}
