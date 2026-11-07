using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200038D")]
public class AudioSpectrum : MonoBehaviour
{
	[Token(Token = "0x200038E")]
	public enum BandType
	{
		[Token(Token = "0x400138F")]
		FourBand = 0,
		[Token(Token = "0x4001390")]
		FourBandVisual = 1,
		[Token(Token = "0x4001391")]
		EightBand = 2,
		[Token(Token = "0x4001392")]
		TenBand = 3,
		[Token(Token = "0x4001393")]
		TwentySixBand = 4,
		[Token(Token = "0x4001394")]
		ThirtyOneBand = 5
	}

	[Token(Token = "0x4001383")]
	[FieldOffset(Offset = "0x0")]
	private static float[][] middleFrequenciesForBands;

	[Token(Token = "0x4001384")]
	[FieldOffset(Offset = "0x8")]
	private static float[] bandwidthForBands;

	[Token(Token = "0x4001385")]
	[FieldOffset(Offset = "0x18")]
	public AudioSource source;

	[Token(Token = "0x4001386")]
	[FieldOffset(Offset = "0x20")]
	public int numberOfSamples;

	[Token(Token = "0x4001387")]
	[FieldOffset(Offset = "0x24")]
	public BandType bandType;

	[Token(Token = "0x4001388")]
	[FieldOffset(Offset = "0x28")]
	public float fallSpeed;

	[Token(Token = "0x4001389")]
	[FieldOffset(Offset = "0x2C")]
	public float sensibility;

	[Token(Token = "0x400138A")]
	[FieldOffset(Offset = "0x30")]
	private float[] rawSpectrum;

	[Token(Token = "0x400138B")]
	[FieldOffset(Offset = "0x38")]
	private float[] levels;

	[Token(Token = "0x400138C")]
	[FieldOffset(Offset = "0x40")]
	private float[] peakLevels;

	[Token(Token = "0x400138D")]
	[FieldOffset(Offset = "0x48")]
	private float[] meanLevels;

	[Token(Token = "0x170001FD")]
	public float[] Levels
	{
		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x150D88C", Offset = "0x150D88C", VA = "0x150D88C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001FE")]
	public float[] PeakLevels
	{
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x150D894", Offset = "0x150D894", VA = "0x150D894")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001FF")]
	public float[] MeanLevels
	{
		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x150D89C", Offset = "0x150D89C", VA = "0x150D89C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000200")]
	public int BandCount
	{
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x150D8A4", Offset = "0x150D8A4", VA = "0x150D8A4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x150D948", Offset = "0x150D948", VA = "0x150D948")]
	private void CheckBuffers()
	{
	}

	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x150DA6C", Offset = "0x150DA6C", VA = "0x150DA6C")]
	private int FrequencyToSpectrumIndex(float f)
	{
		return default;
	}

	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x150DAE0", Offset = "0x150DAE0", VA = "0x150DAE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x150DAE4", Offset = "0x150DAE4", VA = "0x150DAE4")]
	private void Update()
	{
	}

	[Token(Token = "0x60010D9")]
	[Address(RVA = "0x150DDBC", Offset = "0x150DDBC", VA = "0x150DDBC")]
	public AudioSpectrum()
	{
	}
}
