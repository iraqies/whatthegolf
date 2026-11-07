using Chronos;
using UnityEngine;
using UnityEngine.AI;

public class LinkAnimationFieldAndVelocity : MonoBehaviour
{
	public string FieldName;

	public float Mod;

	public Animator Animator;

	public Rigidbody Rigidbody;

	private Vector3 oldPos;

	private Timeline timeline;

	private bool firstFrame;

	private NavMeshAgent navmeshAgent;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
