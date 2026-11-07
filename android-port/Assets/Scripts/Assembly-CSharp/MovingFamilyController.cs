using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class MovingFamilyController : MonoBehaviour
{
	public float moveDuration;

	public List<GolfBallController> familyMemberControllers;

	public List<GameObject> familyMemberParent;

	public List<CinemachineVirtualCamera> cinemachineCameras;

	public List<Transform> familyMemberPositions;

	private int familyIndex;

	private int cameraIndex;

	private int positionIndex;

	private GolfBallController lastController;

	private GolfBallController currentController;

	public UnityEvent onStart;

	public UnityEvent onComplete;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private IEnumerator MoveFamilyMember(GolfBallController controller, float duration)
	{
		return null;
	}
}
