using System.Collections;
using Core;
using UnityEngine;

public class ArrowShootRagdoll : MonoBehaviour
{
	public GameObject ragdoll;

	public GolfBallController ragdollController;

	public GolfBallController archerController;

	private IEnumerator Start()
	{
		return null;
	}

	private void Controller_OnPreShoot(Vector3 boost)
	{
	}
}
