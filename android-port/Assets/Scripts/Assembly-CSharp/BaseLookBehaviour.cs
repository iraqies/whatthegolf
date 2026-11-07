using UnityEngine;
using UnityEngine.Events;

public class BaseLookBehaviour : MonoBehaviour
{
	[SerializeField]
	protected Transform[] transformsLookingAt;

	[SerializeField]
	protected Transform lookAtTargetBehind;

	[SerializeField]
	protected Transform FOVtransform;

	[SerializeField]
	protected float lookAtSpeed;

	[SerializeField]
	protected float lookAwaySpeed;

	[SerializeField]
	protected bool resetBackToDefault;

	[SerializeField]
	protected bool detectCollisionOnlyInsideTrigger;

	[SerializeField]
	protected bool ignoreY;

	[SerializeField]
	protected bool needLineOfSightToDetect;

	public UnityEvent<Transform> OnDetection;

	public UnityEvent<Transform> OnCollision;

	public UnityEvent<Transform> OnFollowPlayer;

	public UnityEvent<Vector3> OnLostLineOfSight;

	public UnityEvent<Transform> OnRestoredLineOfSight;

	private Transform player;

	private Quaternion[] defaultRotations;

	private Vector3 lastKnownPlayerPos;

	private bool hadLostLineOfSight;

	protected virtual void Start()
	{
	}

	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	protected virtual void OnTriggerEnter(Collider other)
	{
	}

	protected virtual void OnTriggerExit(Collider other)
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void TryLookingAtPlayer()
	{
	}

	protected virtual void LookAround()
	{
	}

	private void MoveFovAround(bool reset = false)
	{
	}

	protected virtual void LookAtPlayer()
	{
	}
}
