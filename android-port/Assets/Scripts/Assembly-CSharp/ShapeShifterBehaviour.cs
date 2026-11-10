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

	public GameObject LastCopiedItem => m_lastCopiedGameObject;

	private bool IsShapeShiftAllowed(string collisionTag)
	{
		if (m_acceptedTag != null)
		{
			return m_acceptedTag.Contains(collisionTag);
		}
		return false;
	}

	private bool WasNotCopiedBefore(GameObject touchedObject)
	{
		return m_lastCopiedGameObject != touchedObject;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision != null && collision.transform != null && m_acceptedTag != null && m_acceptedTag.Contains(collision.transform.tag) && m_lastCopiedGameObject != collision.transform.gameObject && !m_isOnCooldown)
		{
			OnTransform?.Invoke();
			m_lastCopiedGameObject = collision.transform.gameObject;
			ShapeShift(collision.transform.gameObject);
			m_cooldownRoutine = StartCoroutine(Cooldown());
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null)
		{
			ShapeRequired component = other.GetComponent<ShapeRequired>();
			if (component != null)
			{
				component.EvaluateShape(m_lastCopiedGameObject);
			}
		}
	}

	public void ShapeShift(GameObject touchedObject)
	{
		if (m_shapeTransform == null || touchedObject == null)
		{
			return;
		}
		if (m_shapeTransform.childCount > 0)
		{
			Object.Destroy(m_shapeTransform.GetChild(0).gameObject);
		}
		GameObject gameObject = Object.Instantiate(touchedObject, m_shapeTransform);
		if (gameObject != null)
		{
			gameObject.transform.localPosition = Vector3.zero;
		}
		if (m_rotateUpOnShapeshift)
		{
			base.transform.up = Vector3.up;
		}
		CleanUpCopiedObject();
	}

	private void CleanUpCopiedObject()
	{
		if (m_shapeTransform == null)
		{
			return;
		}
		List<MonoBehaviour> list = new List<MonoBehaviour>(m_shapeTransform.GetComponentsInChildren<MonoBehaviour>());
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
			{
				Object.Destroy(list[i]);
			}
		}
	}

	private IEnumerator Cooldown()
	{
		m_isOnCooldown = true;
		yield return new WaitForSeconds(m_shapeShiftCooldown);
		m_isOnCooldown = false;
	}
}
