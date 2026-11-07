using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B3F")]
public class PlaystationAgeLevels : ScriptableObject
{
	[Token(Token = "0x4003EAA")]
	[FieldOffset(Offset = "0x18")]
	public int defaultLevelSIEA;

	[Token(Token = "0x4003EAB")]
	[FieldOffset(Offset = "0x1C")]
	public int defaultLevelSIEE;

	[Token(Token = "0x4003EAC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<CountryRating> siea;

	[Token(Token = "0x4003EAD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<CountryRating> siee;

	[Token(Token = "0x17000576")]
	public List<CountryRating> SIEA
	{
		[Token(Token = "0x6003582")]
		[Address(RVA = "0x15FEE08", Offset = "0x15FEE08", VA = "0x15FEE08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000577")]
	public List<CountryRating> SIEE
	{
		[Token(Token = "0x6003583")]
		[Address(RVA = "0x15FEE84", Offset = "0x15FEE84", VA = "0x15FEE84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000578")]
	public int ParentalControlLevelSIEE
	{
		[Token(Token = "0x6003584")]
		[Address(RVA = "0x15FEF00", Offset = "0x15FEF00", VA = "0x15FEF00")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000579")]
	public int ParentalControlLevelSIEA
	{
		[Token(Token = "0x6003585")]
		[Address(RVA = "0x15FEF2C", Offset = "0x15FEF2C", VA = "0x15FEF2C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6003586")]
	[Address(RVA = "0x15FEF58", Offset = "0x15FEF58", VA = "0x15FEF58")]
	public PlaystationAgeLevels()
	{
	}
}
