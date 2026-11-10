using Chronos;
using UnityEngine;
using UnityEngine.AI;

public class LinkAnimationFieldAndVelocity : MonoBehaviour
{
	public string FieldName;

	public float Mod = 1f;

	public Animator Animator;

	public Rigidbody Rigidbody;

	private Vector3 oldPos;

	private Timeline timeline;

	private bool firstFrame = true;

	private NavMeshAgent navmeshAgent;

	private void Start()
	{
		timeline = GetComponentInParent<Timeline>();
		navmeshAgent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		if (Animator == null)
		{
			return;
		}
		Vector3 vel;
		if (Rigidbody == null || Rigidbody.isKinematic)
		{
			if (navmeshAgent != null)
			{
				vel = navmeshAgent.velocity;
			}
			else
			{
				if (firstFrame)
				{
					oldPos = base.transform.position;
					firstFrame = false;
				}
				float dt = (timeline != null) ? timeline.deltaTime : Time.deltaTime;
				Vector3 pos = base.transform.position;
				vel = ((dt == 0f) ? Vector3.zero : ((pos - oldPos) / dt));
				oldPos = base.transform.position;
			}
		}
		else
		{
			vel = Rigidbody.velocity;
			if (timeline != null && timeline.rigidbody != null)
			{
				vel = timeline.rigidbody.velocity;
			}
		}
		Animator.SetFloat(FieldName, vel.magnitude * Mod);
	}
}
