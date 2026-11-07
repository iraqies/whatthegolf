using Core;
using UnityEngine;

public class ZeroPitchAboveHeight : MonoBehaviour
{
	[SerializeField]
	private LayerMask groundMask;

	[SerializeField]
	private float groundDist;

	[SerializeField]
	private float pitch;

	[SerializeField]
	private Vector3 down;

	[SerializeField]
	private Vector3 checkOffset;

	[SerializeField]
	private float AcceptedNormalUp;

	[SerializeField]
	private AnimationCurve HeightToPitchCurve;

	[SerializeField]
	private bool useLocalDown;

	private GolfBallShooterExperimental shooter;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private float HasHitGroundFromPosition(Vector3 position, Vector3 d)
	{
		return 0f;
	}

	private bool AccecptNormals(RaycastHit hit)
	{
		return false;
	}

	private void OnDrawGizmos()
	{
	}
}
