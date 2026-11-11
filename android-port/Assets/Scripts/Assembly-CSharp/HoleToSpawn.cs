using UnityEngine;

public class HoleToSpawn : MonoBehaviour
{
	public Animator animator;

	public string tagToLookFor;

	public float timeToKeepOpen = 1f;

	private bool isOpen;

	private bool shouldOpen;

	private float time;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag(tagToLookFor))
		{
			shouldOpen = true;
			time = Time.time;
		}
	}

	private void Update()
	{
		if (isOpen && shouldOpen && Time.time - time <= timeToKeepOpen)
		{
			animator.speed = 0f;
			shouldOpen = false;
		}
		if (animator.speed == 0f && Time.time - time > timeToKeepOpen)
		{
			animator.speed = 1f;
		}
	}

	public void IsOpen()
	{
		isOpen = true;
	}

	public void Closing()
	{
		isOpen = false;
	}
}
