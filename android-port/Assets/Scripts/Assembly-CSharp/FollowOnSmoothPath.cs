using Cinemachine;
using UnityEngine;

public class FollowOnSmoothPath : MonoBehaviour
{
	public CinemachineSmoothPath path;

	public Transform followTarget;

	public float maxRangeFromPath;

	private void FixedUpdate()
	{
	}
}
