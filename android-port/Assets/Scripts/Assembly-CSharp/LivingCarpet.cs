using UnityEngine;

public class LivingCarpet : MonoBehaviour
{
	[SerializeField]
	private HingeJoint _joint;

	[SerializeField]
	private float _targetVel;

	[SerializeField]
	private float _forceStrengh;

	[SerializeField]
	private float _timeDown;

	[SerializeField]
	private Transform _forceDir;

	private bool move;

	private double time;

	private void OnDrawGizmos()
	{
	}

	private void Start()
	{
	}

	private void CollisionEnterTrigger(Rigidbody obj)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Update()
	{
	}
}
