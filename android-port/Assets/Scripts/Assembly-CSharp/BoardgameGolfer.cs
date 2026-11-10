using System;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class BoardgameGolfer : MonoBehaviour
{
	[Serializable]
	public struct DiceSideToActionPair
	{
		public Vector3 axis;

		public bool onlyIfShot;

		public UnityEvent callback;
	}

	public List<Transform> targets;

	public List<GameObject> targetTiles;

	public Transform endTarget;

	public Transform bounceTarget;

	public int endTargetIndex;

	private int currentIndex;

	private int nextIndex;

	private int targetIndex;

	public GolfBallController dice;

	private Rigidbody diceRigid;

	private bool hasBeenShot;

	private float timer;

	public float CheckTimer = 0.5f;

	public float SleepThreshold = 1f;

	public float DotThreshold = 0.01f;

	private Vector3 startPosition;

	public List<DiceSideToActionPair> sideToActionMap;

	private Rigidbody rb;

	private Transform t;

	[SerializeField]
	private float moveSpeed = 10f;

	[SerializeField]
	private float moveHeight = 2f;

	[SerializeField]
	private AnimationCurve moveHeightCurve;

	[SerializeField]
	private float rotationSpeed = 90f;

	[SerializeField]
	private float collisionExtraPush = 10f;

	public LayerMask groundLayer;

	private Vector3 startPos;

	private Quaternion startRot;

	[SerializeField]
	private ParticleSystem particleSystem;

	[SerializeField]
	private PropRain hotdogRain;

	private bool disabledByCollision;

	private float startTime;

	[SerializeField]
	private int particleCount = 20;

	[SerializeField]
	private float maxHotdogDestroyAngle = 45f;

	[SerializeField]
	private float maxCollisionDisableAngle = 60f;

	[SerializeField]
	private float rotationCheckerRadius = 2f;

	[SerializeField]
	private Transform rotationCheckerCenter;

	private Collider[] rotationCheckResults = new Collider[10];

	[SerializeField]
	private float respawnYOffset = 2f;

	[SerializeField]
	private BoardgameGolfer other;

	public List<Transform> alternativeTargets;

	private bool reachedNext;

	public int CurrentIndex => currentIndex;

	public int NextIndex => nextIndex;

	public int TargetIndex
	{
		get
		{
			if (targets == null)
			{
				return 0;
			}
			int num = targets.Count - 1;
			if (currentIndex == num && targetIndex >= targets.Count)
			{
				return currentIndex - targetIndex + num;
			}
			if (currentIndex == 0 && targetIndex < 0)
			{
				return -targetIndex;
			}
			return targetIndex;
		}
	}

	private bool isMoving
	{
		get
		{
			if (currentIndex == targetIndex)
			{
				return false;
			}
			return !disabledByCollision;
		}
	}

	private void Start()
	{
		if (dice != null)
		{
			dice.OnShoot += Dice_OnShoot;
			dice.OnReset += Dice_OnReset;
			diceRigid = dice.GetComponent<Rigidbody>();
		}
		rb = GetComponent<Rigidbody>();
		t = base.transform;
		startPos = t.position;
		startRot = t.rotation;
		startTime = Time.time;
	}

	private void Dice_OnShoot(Vector3 dir)
	{
		hasBeenShot = true;
	}

	private void Dice_OnReset()
	{
		hasBeenShot = false;
	}

	public void MovePiece(int value)
	{
		targetIndex += value;
		if (t != null)
		{
			startPosition = t.position;
		}
		disabledByCollision = false;
	}

	public void RainHotdogs(int index)
	{
		if (hotdogRain != null)
		{
			hotdogRain.Raining = true;
		}
	}

	public void StopHotdogs()
	{
		if (hotdogRain != null)
		{
			hotdogRain.Raining = false;
		}
	}

	private void CheckDiceState()
	{
		if (sideToActionMap == null || dice == null)
		{
			return;
		}
		for (int i = 0; i < sideToActionMap.Count; i++)
		{
			DiceSideToActionPair diceSideToActionPair = sideToActionMap[i];
			if (!diceSideToActionPair.onlyIfShot || hasBeenShot)
			{
				Vector3 rhs = dice.transform.TransformDirection(diceSideToActionPair.axis);
				if (Mathf.Abs(Vector3.Dot(Vector3.up, rhs) - 1f) < DotThreshold)
				{
					diceSideToActionPair.callback?.Invoke();
					hasBeenShot = false;
					break;
				}
			}
		}
	}

	private void FixedUpdate()
	{
		if (hasBeenShot && diceRigid != null)
		{
			if (diceRigid.velocity.magnitude <= SleepThreshold)
			{
				timer -= Time.deltaTime;
				if (timer <= 0f)
				{
					CheckDiceState();
					timer = CheckTimer;
				}
			}
			else
			{
				timer = CheckTimer;
			}
		}
		else
		{
			CheckDiceState();
		}
		if (!isMoving)
		{
			return;
		}
		bool flag = false;
		if (rotationCheckerCenter != null && rotationCheckResults != null)
		{
			int num = Physics.OverlapSphereNonAlloc(rotationCheckerCenter.position, rotationCheckerRadius, rotationCheckResults);
			for (int i = 0; i < num; i++)
			{
				if (rotationCheckResults[i] != null && (rotationCheckResults[i].attachedRigidbody == null || rotationCheckResults[i].attachedRigidbody != rb))
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag && t != null && rb != null)
		{
			Quaternion to = Quaternion.LookRotation(Vector3.forward, Vector3.up);
			rb.MoveRotation(Quaternion.RotateTowards(t.rotation, to, Time.deltaTime * rotationSpeed));
		}
		if (targets == null)
		{
			return;
		}
		int num2 = targets.Count - 1;
		if (currentIndex == num2 && targetIndex >= targets.Count)
		{
			targetIndex = currentIndex - targetIndex + num2;
		}
		else if (currentIndex == 0 && targetIndex < 0)
		{
			targetIndex = -targetIndex;
		}
		nextIndex = currentIndex + (int)Mathf.Sign(targetIndex - currentIndex);
		Transform nextNode = GetNextNode();
		if (nextNode == null || t == null || rb == null)
		{
			return;
		}
		Vector3 vector = nextNode.position - t.position;
		float magnitude = vector.magnitude;
		Vector3 position = t.position;
		Vector3 normalized = vector.normalized;
		float num3 = Mathf.Min(moveSpeed * Time.deltaTime, magnitude);
		float num4 = Vector2.Distance(new Vector2(startPosition.x, startPosition.z), new Vector2(nextNode.position.x, nextNode.position.z));
		float magnitude2 = new Vector2(vector.x, vector.z).magnitude;
		float num5 = 0f;
		if (moveHeightCurve != null)
		{
			float time = ((num4 > 0f) ? ((num4 - magnitude2) / num4) : 1f);
			num5 = moveHeightCurve.Evaluate(time);
		}
		float f = startPosition.y + num5 * moveHeight - t.position.y;
		float num6 = Mathf.Sign(f);
		float b = Mathf.Abs(f);
		float num7 = Mathf.Min(moveSpeed * Time.deltaTime, b);
		rb.MovePosition(new Vector3(position.x + normalized.x * num3, t.position.y + num6 * num7, position.z + normalized.z * num3));
	}

	private Transform GetNextNode()
	{
		if (other == null && targets != null)
		{
			if (targetIndex == endTargetIndex)
			{
				targets[endTargetIndex] = endTarget;
			}
			else
			{
				targets[endTargetIndex] = bounceTarget;
			}
		}
		else if (nextIndex == targetIndex && other != null && other.targetTiles != null && targetTiles != null)
		{
			GameObject gameObject = other.targetTiles[other.TargetIndex];
			if (gameObject == targetTiles[TargetIndex] && alternativeTargets != null)
			{
				return alternativeTargets[nextIndex];
			}
		}
		if (targets != null && nextIndex >= 0 && nextIndex < targets.Count)
		{
			return targets[nextIndex];
		}
		return null;
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		if (rotationCheckerCenter != null)
		{
			Gizmos.DrawWireSphere(rotationCheckerCenter.position, rotationCheckerRadius);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (Time.time - startTime < 0.1f || collision == null || collision.collider == null || collision.collider.gameObject == null)
		{
			return;
		}
		if (hotdogRain != null && hotdogRain.Prop != null && collision.collider.gameObject.name.Contains(hotdogRain.Prop.name))
		{
			if (t != null && Vector3.Angle(Vector3.down, collision.transform.position - t.position) < maxHotdogDestroyAngle)
			{
				UnityEngine.Object.Destroy(collision.other.gameObject);
			}
			return;
		}
		int value = groundLayer.value;
		if (value == (value | (1 << collision.gameObject.layer)))
		{
			if (targetTiles != null && nextIndex >= 0 && nextIndex < targetTiles.Count && targetTiles[nextIndex] == collision.gameObject)
			{
				currentIndex = nextIndex;
				if (t != null)
				{
					startPosition = t.position;
				}
				if (particleSystem != null)
				{
					particleSystem.Emit((int)(UnityEngine.Random.Range(0.5f, 1f) * (float)particleCount));
				}
			}
			return;
		}
		if (collision.rigidbody == null || (t != null && Vector3.Angle(Vector3.down, collision.transform.position - t.position) < maxCollisionDisableAngle))
		{
			disabledByCollision = true;
			targetIndex = currentIndex;
			return;
		}
		if (isMoving && rb != null)
		{
			Vector3 vector = (collision.transform.position - rb.position).normalized * collisionExtraPush;
			collision.rigidbody.AddForce(vector, ForceMode.Impulse);
			ContactPoint[] contacts = collision.contacts;
			if (contacts != null && contacts.Length > 0)
			{
				Debug.DrawLine(contacts[0].point, contacts[0].point + vector, Color.red, 1f);
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.tag == "OutOfBounds")
		{
			OutOfBounds();
		}
	}

	public void ResetOnRespawn()
	{
		disabledByCollision = false;
		hasBeenShot = false;
		currentIndex = 0;
		nextIndex = 0;
		targetIndex = 0;
		startPosition = startPos;
	}

	public void OutOfBounds()
	{
		if (t != null)
		{
			t.position = startPos + Vector3.up * respawnYOffset;
			t.rotation = startRot;
		}
		if (rb != null)
		{
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
		}
		disabledByCollision = false;
		hasBeenShot = false;
		currentIndex = 0;
		nextIndex = 0;
		targetIndex = 0;
		startPosition = startPos;
	}
}
