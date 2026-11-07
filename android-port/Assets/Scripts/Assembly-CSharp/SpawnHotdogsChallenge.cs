using Audio;
using Core;

public class SpawnHotdogsChallenge : Challenge
{
	public int SpawnsToWin;

	public HotdogVendor Vendor;

	public AudioClipSettings clip;

	public float maxPitch;

	public float maxVolume;

	private float nextClipTime;

	private float pitchIncrementPerSpawn;

	private float volumeIncrementPerSpawn;

	private int count;

	private GolfBallController controller;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnHotdogSpawned(GolfBallController controller)
	{
	}

	protected override void Activate()
	{
	}
}
