using System.Collections;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class MovingDayChallenge : Challenge
{
	public List<GolfBallController> objectsToGetInCollider;

	public GolfBallController HouseController;

	public GameObject colliderContainer;

	public FollowTransform follower;

	public GameObject ramp;

	public Transform truck;

	public CBFollow cameraFollow;

	private List<GolfBallController> objectsLeft;

	private RigidbodyCollisionInfo colInfo;

	private GolfBallController controller;

	private int triggerCount;

	private bool lastPhase;

	protected override void Activate()
	{
		if (HouseController != null)
			HouseController.enabled = false;
		cameraFollow = FindObjectOfType<CBFollow>();
		objectsLeft = new List<GolfBallController>();
		if (objectsToGetInCollider != null)
		{
			foreach (GolfBallController item in objectsToGetInCollider)
			{
				if (item != null)
					objectsLeft.Add(item);
			}
		}

		if (cameraFollow != null && follower != null)
		{
			cameraFollow.FollowTarget = follower.transform;
		}

		if (colliderContainer != null)
		{
			colInfo = colliderContainer.GetComponentInChildren<RigidbodyCollisionInfo>();
			if (colInfo == null)
				colInfo = colliderContainer.AddComponent<RigidbodyCollisionInfo>();
			colInfo.OnTrigger3D += OnTrigger;
		}

		if (objectsToGetInCollider != null && objectsToGetInCollider.Count > 0)
		{
			for (int i = 0; i < objectsToGetInCollider.Count; i++)
			{
				if (objectsToGetInCollider[i] != null)
					objectsToGetInCollider[i].enabled = false;
			}
			if (objectsToGetInCollider[0] != null)
				objectsToGetInCollider[0].enabled = true;
		}

		StartCoroutine(StartChallenge());

		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null && objectsLeft != null)
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(objectsLeft.Count, StrokeCounter.CounterTypes.CardsAppearing, true, 0);
		}
		controller = FindObjectOfType<GolfBallController>();
	}

	private void OnTrigger(Collider other)
	{
		if (other == null || other.attachedRigidbody == null) return;
		GolfBallController hitCtrl = other.attachedRigidbody.GetComponent<GolfBallController>();
		if (hitCtrl == null || objectsLeft == null || !objectsLeft.Contains(hitCtrl)) return;

		triggerCount++;
		hitCtrl.CancelShooting();
		hitCtrl.enabled = false;
		hitCtrl.StopAiming();
		if (truck != null)
			hitCtrl.transform.parent = truck;
		objectsLeft.Remove(hitCtrl);

		if (objectsLeft.Count >= 1)
		{
			StartCoroutine(EnableNextObject());
		}

		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.CountStroke(controller, triggerCount);
		}
	}

	private IEnumerator StartChallenge()
	{
		while (objectsLeft != null && objectsLeft.Count > 0)
		{
			yield return null;
		}

		if (follower != null && ramp != null)
			follower.Target = ramp.transform;

		float duration = 1f;
		float timer = 1f;
		Quaternion rot = ramp != null ? ramp.transform.localRotation : Quaternion.identity;
		Quaternion targetRot = Quaternion.Euler(120f, 0f, 0f);
		while (timer > 0f)
		{
			if (ramp != null)
				ramp.transform.localRotation = Quaternion.Lerp(rot, targetRot, 1f - timer / duration);
			timer -= Time.deltaTime;
			yield return null;
		}

		duration = 2f;
		timer = 2f;
		if (follower != null && HouseController != null)
			follower.Target = HouseController.transform;

		CBFollow cb = CustomCameraBehaviour as CBFollow ?? cameraFollow;
		Vector3 startCameraRotation = Vector3.zero;
		Vector3 targetCameraRotation = new Vector3(17f, 24f, 0f);
		float elevation = 0f;
		float houseElevation = 20f;
		if (cb != null)
		{
			startCameraRotation = cb.rotation;
			elevation = cb.elevation;
			houseElevation = elevation + 20f;
		}

		while (timer >= 0f)
		{
			float t = 1f - timer / duration;
			if (cb != null)
			{
				cb.elevation = Mathf.Lerp(elevation, houseElevation, t);
				cb.rotation = Vector3.Lerp(startCameraRotation, targetCameraRotation, Mathf.Clamp01(t));
			}
			timer -= Time.deltaTime;
			yield return null;
		}

		if (objectsToGetInCollider != null)
		{
			foreach (GolfBallController item in objectsToGetInCollider)
			{
				if (item != null && item.gameObject != null)
					Destroy(item.gameObject);
			}
		}

		if (truck != null)
		{
			Animator anim = truck.GetComponent<Animator>();
			if (anim != null)
				anim.SetTrigger("Drive");
		}

		if (HouseController != null)
			HouseController.enabled = true;
		lastPhase = true;
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		if (lastPhase)
			Complete();
		else
			Fail();
	}

	private IEnumerator EnableNextObject()
	{
		if (objectsLeft != null && objectsLeft.Count > 0 && objectsLeft[0] != null)
		{
			if (follower != null)
				follower.Target = objectsLeft[0].transform;
			yield return new WaitForSeconds(0.5f);
			if (objectsLeft != null && objectsLeft.Count > 0 && objectsLeft[0] != null)
				objectsLeft[0].enabled = true;
		}
	}
}
