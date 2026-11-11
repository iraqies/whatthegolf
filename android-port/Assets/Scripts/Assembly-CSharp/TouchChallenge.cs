using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class TouchChallenge : Challenge
{
	public List<GameObject> objectsToDeactivate;

	private TiltChallengeSFX SFX;

	public GameObject touchTarget;

	private ChallengeTouchObject[] _challengeTouchObjects;

	public ObjectDestroyTrigger objectDestroyTrigger;

	private List<ChallengeTouchObject> touchingObjects = new List<ChallengeTouchObject>();

	public bool attachTouchObject;

	protected override void Activate()
	{
		_challengeTouchObjects = UnityEngine.Object.FindObjectsOfType<ChallengeTouchObject>();
		if (_challengeTouchObjects != null)
		{
			for (int i = 0; i < _challengeTouchObjects.Length; i++)
			{
				ChallengeTouchObject challengeTouchObject = _challengeTouchObjects[i];
				if (challengeTouchObject != null)
				{
					challengeTouchObject.SetTouchTarget(touchTarget);
					challengeTouchObject.onToughTarget = (Action<ChallengeTouchObject>)Delegate.Combine(challengeTouchObject.onToughTarget, new Action<ChallengeTouchObject>(OnToughTarget));
				}
			}
		}
		if (objectsToDeactivate != null)
		{
			foreach (GameObject item in objectsToDeactivate)
			{
				if (item != null)
				{
					item.SetActive(false);
				}
			}
		}
		if (objectDestroyTrigger != null)
		{
			objectDestroyTrigger.onDestroyObject = (Action<GameObject>)Delegate.Combine(objectDestroyTrigger.onDestroyObject, new Action<GameObject>(OnDestroyObject));
		}
		SFX = GetComponentInChildren<TiltChallengeSFX>();
	}

	private void OnDestroyObject(GameObject obj)
	{
		if (obj != null && (bool)obj.GetComponent<ChallengeTouchObject>())
		{
			Fail();
		}
	}

	private void OnToughTarget(ChallengeTouchObject obj)
	{
		if (touchingObjects == null || touchingObjects.Contains(obj))
		{
			return;
		}
		touchingObjects.Add(obj);
		if (attachTouchObject && obj != null && touchTarget != null)
		{
			SpringJoint springJoint = obj.gameObject.AddComponent<SpringJoint>();
			springJoint.connectedBody = touchTarget.GetComponent<Rigidbody>();
			springJoint.autoConfigureConnectedAnchor = false;
			springJoint.anchor = Vector3.zero;
			springJoint.connectedAnchor = Vector3.zero;
			springJoint.enableCollision = true;
			springJoint.spring = 200f;
		}
		CheckTouches();
	}

	private IEnumerator WaitAndComplete()
	{
		yield return new WaitForSeconds(1f);
		Complete();
	}

	private void CheckTouches()
	{
		if (touchingObjects != null && _challengeTouchObjects != null && touchingObjects.Count == _challengeTouchObjects.Length)
		{
			StartCoroutine(WaitAndComplete());
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		MonoBehaviour.print("OnLevelComplete!");
	}
}
