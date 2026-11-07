using UnityEngine;

public class FleeingNPC : MonoBehaviour
{
	public bool isFleeDirectionFixed;

	public Vector3 FleeDirection;

	public float FleeSpeed;

	public bool canOnlyFleeOnce;

	public float FleeThreshold;

	public Animator Animator;

	private Rigidbody _rigidbody;

	private bool canFlee;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
