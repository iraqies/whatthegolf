using UnityEngine;

public class AudioSpectrum : MonoBehaviour
{
	public enum BandType
	{
		FourBand = 0,
		FourBandVisual = 1,
		EightBand = 2,
		TenBand = 3,
		TwentySixBand = 4,
		ThirtyOneBand = 5
	}

	private static float[][] middleFrequenciesForBands;

	private static float[] bandwidthForBands;

	public AudioSource source;

	public int numberOfSamples;

	public BandType bandType;

	public float fallSpeed;

	public float sensibility;

	private float[] rawSpectrum;

	private float[] levels;

	private float[] peakLevels;

	private float[] meanLevels;

	public float[] Levels => null;

	public float[] PeakLevels => null;

	public float[] MeanLevels => null;

	public int BandCount => 0;

	private void CheckBuffers()
	{
	}

	private int FrequencyToSpectrumIndex(float f)
	{
		return 0;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
