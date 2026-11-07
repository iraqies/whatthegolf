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
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
