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
	protected float lookAwaySpeed = -1f;

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

	private Vector3 lastKnownPlayerPos = Vector3.zero;

	private bool hadLostLineOfSight;

	protected virtual void Start()
	{
		if (lookAwaySpeed == -1f)
		{
			lookAwaySpeed = lookAtSpeed;
		}
		if (transformsLookingAt != null)
		{
			defaultRotations = new Quaternion[transformsLookingAt.Length];
			for (int i = 0; i < transformsLookingAt.Length; i++)
			{
				if (transformsLookingAt[i] != null)
				{
					defaultRotations[i] = transformsLookingAt[i].localRotation;
				}
			}
		}
	}

	protected virtual void OnCollisionEnter(Collision collision)
	{
		if (collision != null && collision.other != null && collision.other.CompareTag("Player"))
		{
			if (!detectCollisionOnlyInsideTrigger || player != null)
			{
				OnCollision?.Invoke(collision.other.transform);
			}
		}
	}

	protected virtual void OnTriggerEnter(Collider other)
	{
		if (other == null || !other.CompareTag("Player"))
		{
			return;
		}
		player = other.transform;
		RaycastHit hitInfo;
		bool flag = Physics.Linecast(base.transform.position, player.position, out hitInfo);
		if ((flag && needLineOfSightToDetect && hitInfo.collider != null && hitInfo.collider.CompareTag("Player")) || !needLineOfSightToDetect)
		{
			OnDetection?.Invoke(player);
		}
	}

	protected virtual void OnTriggerExit(Collider other)
	{
		if (other != null && other.CompareTag("Player"))
		{
			player = null;
		}
	}

	protected virtual void Update()
	{
		if ((bool)player)
		{
			TryLookingAtPlayer();
		}
		else
		{
			LookAround();
		}
	}

	protected virtual void TryLookingAtPlayer()
	{
		RaycastHit hitInfo;
		if (!Physics.Linecast(base.transform.position, player.position, out hitInfo))
		{
			MoveFovAround(true);
			LookAround();
			return;
		}
		Vector3 vector = lastKnownPlayerPos;
		if (hitInfo.collider != null && hitInfo.collider.CompareTag("Player"))
		{
			lastKnownPlayerPos = player.transform.position;
			if (vector != lastKnownPlayerPos && hadLostLineOfSight)
			{
				OnRestoredLineOfSight?.Invoke(player.transform);
			}
			hadLostLineOfSight = false;
			MoveFovAround(false);
			LookAtPlayer();
			return;
		}
		if (vector != Vector3.zero && lookAtTargetBehind != null)
		{
			if (lastKnownPlayerPos.z - lookAtTargetBehind.position.z < 0f)
			{
				LookAround();
			}
			else
			{
				LookAtPlayer();
			}
		}
		hadLostLineOfSight = true;
		OnLostLineOfSight?.Invoke(lastKnownPlayerPos);
		MoveFovAround(true);
	}

	protected virtual void LookAround()
	{
		if (transformsLookingAt == null)
		{
			return;
		}
		if (resetBackToDefault)
		{
			for (int i = 0; i < transformsLookingAt.Length; i++)
			{
				Transform transform = transformsLookingAt[i];
				if (transform != null && defaultRotations != null && i < defaultRotations.Length)
				{
					transform.localRotation = Quaternion.Slerp(transform.localRotation, defaultRotations[i], lookAwaySpeed * Time.deltaTime);
				}
			}
			return;
		}
		for (int j = 0; j < transformsLookingAt.Length; j++)
		{
			Transform transform2 = transformsLookingAt[j];
			if (transform2 != null)
			{
				Quaternion b = ((lastKnownPlayerPos != Vector3.zero) ? Quaternion.LookRotation(transform2.position - lastKnownPlayerPos) : defaultRotations[j]);
				transform2.rotation = Quaternion.Slerp(transform2.rotation, b, lookAwaySpeed * Time.deltaTime);
			}
		}
	}

	private void MoveFovAround(bool reset = false)
	{
		if (!FOVtransform)
		{
			return;
		}
		if (!reset && (bool)player)
		{
			Quaternion b = Quaternion.LookRotation(player.position - FOVtransform.position);
			FOVtransform.rotation = Quaternion.Lerp(FOVtransform.rotation, b, lookAtSpeed * Time.deltaTime);
		}
		else if ((bool)player || !player)
		{
			FOVtransform.localRotation = Quaternion.Lerp(FOVtransform.localRotation, Quaternion.identity, lookAtSpeed * Time.deltaTime);
		}
	}

	protected virtual void LookAtPlayer()
	{
		if (player == null)
		{
			return;
		}
		OnFollowPlayer?.Invoke(player.transform);
		Vector3 position = player.position;
		if (lookAtTargetBehind != null && player.transform.position.z - lookAtTargetBehind.position.z >= 0f)
		{
			position.z = lookAtTargetBehind.position.z;
		}
		if (transformsLookingAt == null)
		{
			return;
		}
		for (int i = 0; i < transformsLookingAt.Length; i++)
		{
			position.y = (ignoreY ? base.transform.position.y : player.position.y);
			Transform transform = transformsLookingAt[i];
			if (transform != null)
			{
				Quaternion b = Quaternion.LookRotation(position - transform.position);
				transform.rotation = Quaternion.Lerp(transform.rotation, b, lookAtSpeed * Time.deltaTime);
			}
		}
	}
}
