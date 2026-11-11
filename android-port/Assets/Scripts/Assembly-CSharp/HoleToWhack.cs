using UnityEngine;

public class HoleToWhack : MonoBehaviour
{
	public Transform ItemsContainer;

	public Animator HoleAnimator;

	public Vector2 HiddenDurationRange = new Vector2(3f, 5f);

	public Vector2 StayUpDurationRange = new Vector2(1f, 2f);

	public Vector2 randomRotationRange = new Vector2(-80f, 45f);

	public ParticleSystem HitParticles;

	private float hiddenTimer;

	private float stayUpTimer;

	private Animator[] childAnimators;

	private int currentIndex;

	private void Start()
	{
		childAnimators = new Animator[ItemsContainer.childCount];
		for (int i = 0; i < ItemsContainer.childCount; i++)
		{
			childAnimators[i] = ItemsContainer.GetChild(i).gameObject.GetComponent<Animator>();
		}
		currentIndex = Random.Range(0, ItemsContainer.childCount);
		for (int j = 0; j < ItemsContainer.childCount; j++)
		{
			ItemsContainer.GetChild(j).gameObject.SetActive(j == currentIndex);
		}
		stayUpTimer = 1f;
	}

	private void Update()
	{
		float num = hiddenTimer;
		hiddenTimer -= Time.deltaTime;
		if (num > 0f && hiddenTimer < 0f)
		{
			currentIndex = Random.Range(0, ItemsContainer.childCount);
			for (int i = 0; i < ItemsContainer.childCount; i++)
			{
				ItemsContainer.GetChild(i).gameObject.SetActive(i == currentIndex);
			}
			ItemsContainer.localRotation = Quaternion.Euler(0f, Random.Range(randomRotationRange.x, randomRotationRange.y), 0f);
			HoleAnimator.speed = 1f;
		}
		if (hiddenTimer < 0f)
		{
			stayUpTimer -= Time.deltaTime;
			if (stayUpTimer < 0f)
			{
				HoleAnimator.SetBool("IsUp", value: false);
				SetNewTimes();
			}
			else
			{
				HoleAnimator.SetBool("IsUp", value: true);
			}
		}
	}

	private void SetNewTimes()
	{
		hiddenTimer = Random.Range(HiddenDurationRange.x, HiddenDurationRange.y);
		stayUpTimer = Random.Range(StayUpDurationRange.x, StayUpDurationRange.y);
	}

	public void HasBeenWhacked()
	{
		HoleAnimator.speed = 3f;
		HitParticles.gameObject.SetActive(value: true);
		HoleAnimator.SetBool("IsUp", value: false);
		childAnimators[currentIndex].SetTrigger("Hit");
		SetNewTimes();
	}
}
