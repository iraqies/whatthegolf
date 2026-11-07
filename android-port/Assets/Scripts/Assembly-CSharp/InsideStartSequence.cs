using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideStartSequence : MonoBehaviour
{
	public List<Rigidbody> Boards;

	public Rigidbody Player;

	public InsideObserver Observer;

	public InsideQueueManager Manager;

	private bool hasRunSequence;

	private void OnTriggerEnter(Collider other)
	{
	}

	private IEnumerator StartSequence()
	{
		return null;
	}
}
