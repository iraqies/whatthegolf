using Audio;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x200041C")]
public class SpawnHotdogsChallenge : Challenge
{
	[Token(Token = "0x4001677")]
	[FieldOffset(Offset = "0xA4")]
	public int SpawnsToWin;

	[Token(Token = "0x4001678")]
	[FieldOffset(Offset = "0xA8")]
	public HotdogVendor Vendor;

	[Token(Token = "0x4001679")]
	[FieldOffset(Offset = "0xB0")]
	public AudioClipSettings clip;

	[Token(Token = "0x400167A")]
	[FieldOffset(Offset = "0xB8")]
	public float maxPitch;

	[Token(Token = "0x400167B")]
	[FieldOffset(Offset = "0xBC")]
	public float maxVolume;

	[Token(Token = "0x400167C")]
	[FieldOffset(Offset = "0xC0")]
	private float nextClipTime;

	[Token(Token = "0x400167D")]
	[FieldOffset(Offset = "0xC4")]
	private float pitchIncrementPerSpawn;

	[Token(Token = "0x400167E")]
	[FieldOffset(Offset = "0xC8")]
	private float volumeIncrementPerSpawn;

	[Token(Token = "0x400167F")]
	[FieldOffset(Offset = "0xCC")]
	private int count;

	[Token(Token = "0x4001680")]
	[FieldOffset(Offset = "0xD0")]
	private GolfBallController controller;

	[Token(Token = "0x6001357")]
	[Address(RVA = "0x16C7564", Offset = "0x16C7564", VA = "0x16C7564")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001358")]
	[Address(RVA = "0x16C75A4", Offset = "0x16C75A4", VA = "0x16C75A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6001359")]
	[Address(RVA = "0x16C75A8", Offset = "0x16C75A8", VA = "0x16C75A8")]
	private void OnHotdogSpawned(GolfBallController controller)
	{
	}

	[Token(Token = "0x600135A")]
	[Address(RVA = "0x16C76E0", Offset = "0x16C76E0", VA = "0x16C76E0", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x600135B")]
	[Address(RVA = "0x16C7800", Offset = "0x16C7800", VA = "0x16C7800")]
	public SpawnHotdogsChallenge()
	{
	}
}
