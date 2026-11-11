using UnityEngine;

public class FishLocation : MonoBehaviour
{
	public static int fishCaught;

	public float maxTime = 3f;

	public float minTime = 1f;

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
		fishCaught = 0;
	}

	private void Start()
	{
		waves = GetComponentInChildren<ParticleSystem>();
		if (waves != null)
		{
			waveScale = waves.transform.localScale;
		}
		shark = GameObject.Find("Shark") != null;
		GameObject fisher = GameObject.Find("Fisher");
		if (fisher != null)
		{
			fisherTransform = fisher.transform;
		}
		randomTime = Random.Range(minTime, maxTime);
	}

	private void OnTriggerStay(Collider other)
	{
		if (other == null || other.gameObject == null)
		{
			return;
		}
		if (other.gameObject.layer != LayerMask.NameToLayer("GolfBall"))
		{
			return;
		}
		golfTransform = other.transform;
		if (!caught)
		{
			other.transform.position = Vector3.Lerp(other.transform.position, transform.position, Mathf.Clamp01(Time.deltaTime * 2f));
			if (waves != null)
			{
				waves.transform.localScale = Vector3.Lerp(waves.transform.localScale, Vector3.one * 2f, Mathf.Clamp01(Time.deltaTime * 2f));
				var main = waves.main;
				main.simulationSpeed = 2f;
			}
			timer += Time.deltaTime;
			if (timer >= randomTime)
			{
				caught = true;
				fishCaught++;
				Renderer rend = other.GetComponent<Renderer>();
				if (rend != null)
				{
					rend.enabled = false;
				}
				if (flagFish != null)
				{
					flagFishClone = Object.Instantiate(flagFish, transform.position + Vector3.up, flagFish.transform.rotation);
					Collider fishCol = flagFishClone.GetComponent<Collider>();
					if (fishCol != null)
					{
						Physics.IgnoreCollision(other, fishCol, true);
					}
				}
				else if (somethingElse != null)
				{
					something = Object.Instantiate(somethingElse, transform.position, somethingElse.transform.rotation);
					Collider sCol = something.GetComponent<Collider>();
					if (sCol != null)
					{
						Physics.IgnoreCollision(other, sCol, true);
					}
				}
			}
		}
		else if (fisherTransform != null && golfTransform != null)
		{
			fisherTransform.LookAt(golfTransform);
			Vector3 euler = fisherTransform.rotation.eulerAngles;
			fisherTransform.rotation = Quaternion.Euler(0f, euler.y, 0f);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		timer = 0f;
		if (waves != null)
		{
			waves.transform.localScale = waveScale;
			var main = waves.main;
			main.simulationSpeed = 1f;
			if (caught)
			{
				waves.Stop();
			}
		}
	}

	private void Update()
	{
		if (flagFishClone != null && golfTransform != null)
		{
			flagFishClone.transform.position = golfTransform.position + Vector3.up * 0.5f;
		}
		if (something != null && golfTransform != null)
		{
			something.transform.position = golfTransform.position;
		}
		accelInput = shark ? Input.acceleration : Vector3.zero;
	}
}
