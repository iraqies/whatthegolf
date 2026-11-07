using System.Collections.Generic;
using UnityEngine;

public class PlaystationAgeLevels : ScriptableObject
{
	public int defaultLevelSIEA;

	public int defaultLevelSIEE;

	[SerializeField]
	private List<CountryRating> siea;

	[SerializeField]
	private List<CountryRating> siee;

	public List<CountryRating> SIEA => null;

	public List<CountryRating> SIEE => null;

	public int ParentalControlLevelSIEE => 0;

	public int ParentalControlLevelSIEA => 0;
}
