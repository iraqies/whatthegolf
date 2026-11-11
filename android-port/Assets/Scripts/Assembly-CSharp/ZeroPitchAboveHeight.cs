using Core;
using UnityEngine;

public class ZeroPitchAboveHeight : MonoBehaviour
{
	[SerializeField]
	private LayerMask groundMask;

	[SerializeField]
	private float groundDist = 5f;

	[SerializeField]
	private float pitch = 15f;

	[SerializeField]
	private Vector3 down = Vector3.down;

	[SerializeField]
	private Vector3 checkOffset;

	[SerializeField]
	private float AcceptedNormalUp = 0.5f;

	[SerializeField]
	private AnimationCurve HeightToPitchCurve = AnimationCurve.Linear(0f, 1f, 1f, 0f);

	[SerializeField]
	private bool useLocalDown;

	private GolfBallShooterExperimental shooter;

	private void Start()
	{
		shooter = GetComponent<GolfBallShooterExperimental>();
	}

	private void FixedUpdate()
	{
		if (shooter == null)
		{
			return;
		}
		Vector3 d = useLocalDown ? -transform.up : down;
		float hitDist = HasHitGroundFromPosition(transform.position, d);
		float t = groundDist > 0.01f ? hitDist / groundDist : 0f;
		float eval = HeightToPitchCurve != null && HeightToPitchCurve.length > 0 ? HeightToPitchCurve.Evaluate(t) : (1f - Mathf.Clamp01(t));
		shooter.pitch = eval * pitch;
	}

	private float HasHitGroundFromPosition(Vector3 position, Vector3 d)
	{
		if (Physics.Raycast(position + checkOffset, d, out RaycastHit hit, groundDist, groundMask) && AccecptNormals(hit))
		{
			return hit.distance;
		}
		return groundDist;
	}

	private bool AccecptNormals(RaycastHit hit)
	{
		return Vector3.Dot(hit.normal, -down.normalized) >= AcceptedNormalUp;
	}

	private void OnDrawGizmos()
	{
		Vector3 d = useLocalDown ? -transform.up : down;
		Gizmos.color = Color.green;
		Gizmos.DrawLine(transform.position + checkOffset, transform.position + checkOffset + d * groundDist);
	}
}
