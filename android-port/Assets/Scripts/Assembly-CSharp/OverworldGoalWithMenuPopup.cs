using UnityEngine;

public class OverworldGoalWithMenuPopup : OverworldGoal
{
	public GameObject ObjectToActivateOnHit;

	public override void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && collision.transform != null && collision.transform.CompareTag("Player"))
		{
			if (ObjectToActivateOnHit != null)
				ObjectToActivateOnHit.SetActive(true);
		}
	}
}
