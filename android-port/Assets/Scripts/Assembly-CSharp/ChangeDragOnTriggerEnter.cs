using UnityEngine;

public class ChangeDragOnTriggerEnter : MonoBehaviour
{
	public Transform FallingObjectsContainer;

	public float NewDrag;

	private Rigidbody[] rigidbodies;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
