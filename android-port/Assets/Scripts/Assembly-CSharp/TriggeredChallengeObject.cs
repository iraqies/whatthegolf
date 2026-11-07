using Audio;
using UnityEngine;

public class TriggeredChallengeObject : ChallengeTriggerBase
{
	public string triggerTag;

	public bool useAttachedRigid;

	public AudioEventAsset sfxEventOnTrigger;

	public void Init()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
