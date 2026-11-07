using Cinemachine;
using UnityEngine;

public class RunningTrackDollyCamController : MonoBehaviour
{
	[SerializeField]
	private CinemachineVirtualCamera primaryPathCam;

	[SerializeField]
	private CinemachineVirtualCamera offPathCam;

	[SerializeField]
	private Transform followTarget;

	[SerializeField]
	private DollyPathTrigger runnerTrigger;

	[SerializeField]
	private CinemachineSmoothPath primaryPath;

	[SerializeField]
	private Animator cameraStateAnimator;

	private CinemachineSmoothPath currentPath;

	private CinemachineTrackedDolly offPathCamDolly;

	private float pathDistance;

	private Vector3 pathPosition;

	private void Awake()
	{
	}

	private void RunnerTrigger_OnDollyPathEnter(SecondaryDollyPath obj)
	{
	}

	private void RunnerTrigger_OnDollyPathExit(SecondaryDollyPath obj)
	{
	}
}
