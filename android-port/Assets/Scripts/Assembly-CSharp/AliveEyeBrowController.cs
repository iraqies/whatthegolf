using UnityEngine;
using UnityEngine.Events;

public class AliveEyeBrowController : MonoBehaviour
{
	public GameObject madEyebrow;

	public GameObject surprisedEyebrow;

	public int hitAmountBeforeMadMin;

	public int hitAmountBeforeMadMax;

	public UnityEvent OnHitNoMad;

	public UnityEvent OnHitMad;

	private bool hasAwakened;

	private int timesHit;

	private int randomHitBeforeMad;

	private void Start()
	{
		randomHitBeforeMad = Random.Range(hitAmountBeforeMadMin, hitAmountBeforeMadMax);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision != null && collision.gameObject != null && collision.gameObject.tag == "Player")
		{
			timesHit++;
			if (!hasAwakened)
			{
				hasAwakened = true;
			}
			if (hasAwakened && timesHit >= 3)
			{
				if (timesHit < randomHitBeforeMad)
				{
					OnHitNoMad?.Invoke();
					if (surprisedEyebrow != null)
						surprisedEyebrow.SetActive(true);
					if (madEyebrow != null)
						madEyebrow.SetActive(false);
				}
				else
				{
					OnHitMad?.Invoke();
					if (madEyebrow != null)
						madEyebrow.SetActive(true);
					if (surprisedEyebrow != null)
						surprisedEyebrow.SetActive(false);
				}
			}
		}
	}
}
