using UnityEngine;

public class FallingObject : MonoBehaviour
{
	private Rigidbody[] rigidbodies;

	private MeshRenderer meshToHide;

	private SkinnedMeshRenderer skinToHide;

	public GameObject gameObjectToHide;

	public bool addRandomTorque;

	public float torqueAmount;

	private void Awake()
	{
	}

	public Rigidbody[] GetRigidbodies()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
