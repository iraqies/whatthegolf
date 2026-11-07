using UnityEngine;

public class FailChallengeOnTouch : MonoBehaviour
{
	public bool CheckLayerMask;

	public LayerMask LayerMask;

	public bool CheckTags;

	public string[] Tags;

	public Challenge challenge;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnTriggerEnter(Collider other)
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
