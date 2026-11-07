using UnityEngine;

public class FishLocation : MonoBehaviour
{
	public static int fishCaught;

	public float maxTime;

	public float minTime;

	private float randomTime;

	private float timer;

	public GameObject flagFish;

	private GameObject flagFishClone;

	private Transform golfTransform;

	private bool caught;

	private ParticleSystem waves;

	private Vector3 waveScale;

	private bool shark;

	private Vector3 accelInput;

	private Transform fisherTransform;

	public GameObject somethingElse;

	private GameObject something;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Start()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void Update()
	{
	}
}
