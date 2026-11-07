using UnityEngine;
using UnityEngine.Events;

public class ChallengeTriggerGeneric : ChallengeTriggerBase
{
	public bool CheckLayerMask;

	public LayerMask LayerMask;

	public bool CheckTags;

	public string[] Tags;

	public UnityEvent TriggerEnter;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private bool ValidIncomingObject(GameObject obj)
	{
		return false;
	}
}
