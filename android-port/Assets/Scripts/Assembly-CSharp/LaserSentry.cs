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

	public float MaxTrackDitsance;

	public float laserDelay;

	public float movementThreshold;

	public float targetingSpeed;

	public float speed;

	public float shootExplosionRadius;

	public Color colorOne;

	public Color colorTwo;

	public float colorOneTime;

	public float colorTwoTime;

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

	private int dir;

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

	public bool pushAwayFromSpotlightCenter;

	public float shotExplosionForceScale;

	[SerializeField]
	private bool dontScaleCollider;

	private void Start()
	{
	}

	private Vector3 GetPos()
	{
		return default;
	}

	private void Update()
	{
	}

	private Vector3 UpdateFixedPosition()
	{
		return default;
	}

	private void FixedUpdate()
	{
	}

	private void UpdateObjectsInViewcone()
	{
	}

	private void Shoot(Rigidbody rigid)
	{
	}

	private IEnumerator ShootLaser(Rigidbody rigid)
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnDrawGizmos()
	{
	}

	public static Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		return default;
	}

	public static Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point)
	{
		return default;
	}

	public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		return 0;
	}
}
