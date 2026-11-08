using UnityEngine;

public class OutOfBoundsFailChallenge : MonoBehaviour
{
	public Challenge ChallengeToFail;

	private void OnTriggerEnter(Collider other)
	{
		if (other == null) return;
		if (other.CompareTag("OutOfBounds") || other.CompareTag("OutOfBoundsReload") || other.CompareTag("OutOfBoundsReset"))
		{
			if (ChallengeToFail != null)
				ChallengeToFail.Fail();
		}
	}
}
