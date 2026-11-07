using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShapeShifterBehaviour : MonoBehaviour
{
	[SerializeField]
	private float m_shapeShiftCooldown;

	[SerializeField]
	private Transform m_shapeTransform;

	[SerializeField]
	private List<string> m_acceptedTag;

	[SerializeField]
	private bool m_rotateUpOnShapeshift;

	public UnityEvent OnTransform;

	private GameObject m_lastCopiedGameObject;

	private Coroutine m_cooldownRoutine;

	private bool m_isOnCooldown;

	public GameObject LastCopiedItem => null;

	private bool IsShapeShiftAllowed(string collisionTag)
	{
		return false;
	}

	private bool WasNotCopiedBefore(GameObject touchedObject)
	{
		return false;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void ShapeShift(GameObject touchedObject)
	{
	}

	private void CleanUpCopiedObject()
	{
	}

	private IEnumerator Cooldown()
	{
		return null;
	}
}
