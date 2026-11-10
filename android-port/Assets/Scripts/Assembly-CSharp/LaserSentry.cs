using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class LaserSentry : MonoBehaviour
{
	private enum States
	{
		Seeking = 0,
		WarmingUp = 1,
		Shooting = 2
	}

	[SerializeField]
	private UnityEvent _OnStartShoot;

	[SerializeField]
	private UnityEvent _OnStopShoot;

	public Transform connectedAim;

	public Vector3 spotlightOffset;

	public Renderer connectedLaser;

	public ParticleSystem particles;

	public IntroLoopOutro detectedLoop;

	public RandomAudioClips detectedBeep;

	public RandomAudioClips shootClips;

	public Transform mesh;

	public float MaxTrackDitsance = 20f;

	public float laserDelay = 0.75f;

	public float movementThreshold = 0.05f;

	public float targetingSpeed = 8f;

	public float speed = 4f;

	public float shootExplosionRadius = 4f;

	public Color colorOne = Color.yellow;

	public Color colorTwo = Color.red;

	public float colorOneTime = 0.25f;

	public float colorTwoTime = 0.25f;

	public List<string> BlacklistSearchTags;

	public MeshRenderer coneRenderer;

	public MeshRenderer groundCircleRenderer;

	private Material coneMaterial;

	private Material groundCircleMaterial;

	private float colorTime;

	private bool colorOneActive;

	private Rigidbody rigidB;

	private int curIndex;

	public List<Transform> CurvePoints;

	private Dictionary<Rigidbody, float> objectsInViewconeData;

	private Collider col;

	private List<Rigidbody> objectsInViewcone;

	private int dir = 1;

	private Vector3 currentTarget;

	private float currentSpeed;

	private Vector3 baseScale;

	private Vector3 baseColliderScale;

	private float smoothedMovement;

	private float freezeTime;

	private Vector3 startPosition;

	private States state;

	private States previousState;

	public bool ignorePlayerIfNotAiming;

	public bool pushAwayFromSpotlightCenter = true;

	public float shotExplosionForceScale = 1f;

	[SerializeField]
	private bool dontScaleCollider;

	private void Start()
	{
		rigidB = GetComponent<Rigidbody>();
		col = GetComponent<Collider>();
		objectsInViewconeData = new Dictionary<Rigidbody, float>();
		objectsInViewcone = new List<Rigidbody>();
		startPosition = transform.position;
		currentSpeed = speed;
		if (mesh != null)
		{
			baseScale = mesh.localScale;
		}
		if (col != null)
		{
			baseColliderScale = col.transform.localScale;
		}
		if (connectedLaser != null)
		{
			connectedLaser.enabled = false;
		}
		if (coneRenderer != null)
		{
			coneMaterial = coneRenderer.material;
			coneMaterial.SetColor("_Color", colorOne);
		}
		if (groundCircleRenderer != null)
		{
			groundCircleMaterial = groundCircleRenderer.material;
			groundCircleMaterial.SetColor("_Color", colorOne);
		}
		if (CurvePoints != null && CurvePoints.Count > 0 && CurvePoints[0] != null)
		{
			currentTarget = CurvePoints[0].position;
		}
		else
		{
			currentTarget = startPosition;
		}
		freezeTime = Time.time + 0.2f;
	}

	private Vector3 GetPos()
	{
		return rigidB != null ? rigidB.position : transform.position;
	}

	private void Update()
	{
		if (connectedAim != null)
		{
			Vector3 diff = (GetPos() + spotlightOffset) - connectedAim.position;
			if (diff.sqrMagnitude > 0.0001f)
			{
				connectedAim.rotation = Quaternion.LookRotation(diff.normalized, Vector3.up);
			}
		}
		if (state == States.Seeking)
		{
			if (coneMaterial != null)
			{
				coneMaterial.SetColor("_Color", colorOne);
			}
			if (groundCircleMaterial != null)
			{
				groundCircleMaterial.SetColor("_Color", colorOne);
			}
		}
		else
		{
			colorTime -= Time.deltaTime;
			if (colorTime <= 0f)
			{
				colorOneActive = !colorOneActive;
				colorTime = colorOneActive ? colorOneTime : colorTwoTime;
				Color c = colorOneActive ? colorOne : colorTwo;
				if (coneMaterial != null)
				{
					coneMaterial.SetColor("_Color", c);
				}
				if (groundCircleMaterial != null)
				{
					groundCircleMaterial.SetColor("_Color", c);
				}
			}
		}
	}

	private Vector3 UpdateFixedPosition()
	{
		if (CurvePoints == null || CurvePoints.Count == 0)
		{
			return startPosition;
		}
		Transform targetTrans = CurvePoints[Mathf.Clamp(curIndex, 0, CurvePoints.Count - 1)];
		if (targetTrans == null)
		{
			return GetPos();
		}
		Vector3 pos = GetPos();
		Vector3 next = Vector3.MoveTowards(pos, targetTrans.position, currentSpeed * Time.fixedDeltaTime);
		if (Vector3.Distance(next, targetTrans.position) < 0.1f && CurvePoints.Count > 1)
		{
			curIndex += dir;
			if (curIndex >= CurvePoints.Count)
			{
				dir = -1;
				curIndex = CurvePoints.Count - 2;
			}
			else if (curIndex < 0)
			{
				dir = 1;
				curIndex = 1;
			}
		}
		return next;
	}

	private void FixedUpdate()
	{
		if (Time.time < freezeTime)
		{
			return;
		}
		UpdateObjectsInViewcone();
		if (state == States.Seeking)
		{
			Vector3 nextPos = UpdateFixedPosition();
			if (rigidB != null)
			{
				rigidB.MovePosition(nextPos);
			}
			else
			{
				transform.position = nextPos;
			}
		}
	}

	private void UpdateObjectsInViewcone()
	{
		if (objectsInViewcone == null)
		{
			return;
		}
		for (int i = objectsInViewcone.Count - 1; i >= 0; i--)
		{
			Rigidbody rb = objectsInViewcone[i];
			if (rb == null || !rb.gameObject.activeInHierarchy)
			{
				objectsInViewcone.RemoveAt(i);
				if (objectsInViewconeData != null)
				{
					objectsInViewconeData.Remove(rb);
				}
				continue;
			}
			if (rb.velocity.magnitude >= movementThreshold)
			{
				if (!objectsInViewconeData.ContainsKey(rb))
				{
					objectsInViewconeData[rb] = 0f;
				}
				objectsInViewconeData[rb] += Time.fixedDeltaTime;
				Vector3 targetPos = new Vector3(rb.position.x, GetPos().y, rb.position.z);
				Vector3 nextPos = Vector3.MoveTowards(GetPos(), targetPos, targetingSpeed * Time.fixedDeltaTime);
				if (rigidB != null)
				{
					rigidB.MovePosition(nextPos);
				}
				else
				{
					transform.position = nextPos;
				}
				if (state == States.Seeking)
				{
					state = States.WarmingUp;
					if (detectedBeep != null)
					{
						AudioManager.PlaySFX(detectedBeep, transform.position);
					}
					StartCoroutine(ShootLaser(rb));
				}
			}
		}
	}

	private void Shoot(Rigidbody rigid)
	{
		if (rigid == null)
		{
			return;
		}
		if (particles != null)
		{
			particles.transform.position = rigid.position;
			particles.Play();
		}
		if (shootClips != null)
		{
			AudioManager.PlaySFX(shootClips, rigid.position);
		}
		Vector3 explosionCenter = pushAwayFromSpotlightCenter ? GetPos() : rigid.position + Vector3.down * 0.5f;
		rigid.AddExplosionForce(15f * Mathf.Max(0.25f, shotExplosionForceScale), explosionCenter, Mathf.Max(1f, shootExplosionRadius), 1.5f, ForceMode.VelocityChange);
	}

	private IEnumerator ShootLaser(Rigidbody rigid)
	{
		_OnStartShoot?.Invoke();
		yield return new WaitForSeconds(Mathf.Max(0.1f, laserDelay));
		state = States.Shooting;
		if (connectedLaser != null)
		{
			connectedLaser.enabled = true;
		}
		Shoot(rigid);
		yield return new WaitForSeconds(0.2f);
		if (connectedLaser != null)
		{
			connectedLaser.enabled = false;
		}
		_OnStopShoot?.Invoke();
		state = States.Seeking;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.attachedRigidbody == null)
		{
			return;
		}
		if (BlacklistSearchTags != null && BlacklistSearchTags.Contains(other.tag))
		{
			return;
		}
		Rigidbody rb = other.attachedRigidbody;
		if (!objectsInViewcone.Contains(rb))
		{
			objectsInViewcone.Add(rb);
			objectsInViewconeData[rb] = 0f;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == null || other.attachedRigidbody == null)
		{
			return;
		}
		Rigidbody rb = other.attachedRigidbody;
		objectsInViewcone.Remove(rb);
		objectsInViewconeData.Remove(rb);
	}

	private void OnDrawGizmos()
	{
	}

	public static Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		Vector3 vector = linePoint2 - linePoint1;
		Vector3 projectedPoint = ProjectPointOnLine(linePoint1, vector.normalized, point);
		return PointOnWhichSideOfLineSegment(linePoint1, linePoint2, projectedPoint) switch
		{
			0 => projectedPoint,
			1 => linePoint1,
			2 => linePoint2,
			_ => Vector3.zero,
		};
	}

	public static Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point)
	{
		Vector3 rhs = point - linePoint;
		float d = Vector3.Dot(lineVec, rhs);
		return linePoint + lineVec * d;
	}

	public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		Vector3 rhs = linePoint2 - linePoint1;
		Vector3 lhs = point - linePoint1;
		float num = Vector3.Dot(lhs, rhs);
		if (num > 0f)
		{
			if (lhs.magnitude <= rhs.magnitude)
			{
				return 0;
			}
			return 2;
		}
		return 1;
	}
}
