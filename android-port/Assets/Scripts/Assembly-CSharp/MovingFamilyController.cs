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
		onStart?.Invoke();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null)
		{
			return;
		}
		GolfBallController component = other.GetComponent<GolfBallController>();
		if (component == null)
		{
			return;
		}
		currentController = component;
		if (!(currentController != lastController))
		{
			return;
		}
		lastController = currentController;
		currentController.CancelShooting();
		currentController.StopAiming();
		currentController.transform.root.parent = base.transform;
		StartCoroutine(MoveFamilyMember(currentController, moveDuration));
		currentController.enabled = false;
		if (currentController.name == "Soccerboy")
		{
			Rigidbody[] componentsInChildren = currentController.transform.root.GetComponentsInChildren<Rigidbody>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i] != null)
				{
					Object.Destroy(componentsInChildren[i]);
				}
			}
			ToggleGenericRagdoll component2 = currentController.GetComponent<ToggleGenericRagdoll>();
			if (component2 != null && component2.Rigidbodies != null)
			{
				for (int j = 0; j < component2.Rigidbodies.Count; j++)
				{
					if (component2.Rigidbodies[j] != null)
					{
						Object.Destroy(component2.Rigidbodies[j]);
					}
				}
			}
		}
		else
		{
			Rigidbody component3 = currentController.GetComponent<Rigidbody>();
			if (component3 != null)
			{
				Object.Destroy(component3);
			}
		}
		if (familyMemberControllers != null && familyIndex < familyMemberControllers.Count - 1)
		{
			familyIndex++;
			cameraIndex++;
			if (familyMemberControllers[familyIndex] != null)
			{
				familyMemberControllers[familyIndex].enabled = true;
			}
			if (cinemachineCameras != null && cameraIndex < cinemachineCameras.Count && cinemachineCameras[cameraIndex] != null)
			{
				cinemachineCameras[cameraIndex].Priority = 10;
			}
			if (familyIndex == 4)
			{
				onComplete?.Invoke();
			}
		}
	}

	private IEnumerator MoveFamilyMember(GolfBallController controller, float duration)
	{
		float elapsed = 0f;
		while (elapsed < duration)
		{
			if (controller != null && familyMemberPositions != null && positionIndex < familyMemberPositions.Count && familyMemberPositions[positionIndex] != null)
			{
				controller.transform.position = Vector3.Lerp(controller.transform.position, familyMemberPositions[positionIndex].position, Mathf.Clamp01(elapsed));
				controller.transform.rotation = Quaternion.Lerp(controller.transform.rotation, familyMemberPositions[positionIndex].rotation, elapsed);
			}
			elapsed += Time.fixedDeltaTime * 2f;
			yield return null;
		}
		if (controller != null)
		{
			controller.transform.position = Vector3.zero;
		}
		if (familyMemberParent != null && familyMemberPositions != null && positionIndex < familyMemberParent.Count && positionIndex < familyMemberPositions.Count && familyMemberParent[positionIndex] != null && familyMemberPositions[positionIndex] != null)
		{
			familyMemberParent[positionIndex].transform.position = familyMemberPositions[positionIndex].position;
			familyMemberParent[positionIndex].transform.Rotate(0f, -30f, 0f);
			Animator component = familyMemberParent[positionIndex].GetComponent<Animator>();
			if (component != null)
			{
				component.enabled = true;
			}
		}
		positionIndex++;
	}

	public MovingFamilyController()
	{
		moveDuration = 5f;
		familyMemberControllers = new List<GolfBallController>();
		familyMemberParent = new List<GameObject>();
		cinemachineCameras = new List<CinemachineVirtualCamera>();
		familyMemberPositions = new List<Transform>();
	}
}
