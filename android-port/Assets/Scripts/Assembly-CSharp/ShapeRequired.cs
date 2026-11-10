using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShapeRequired : MonoBehaviour
{
	public UnityEvent OnUnlock;

	public UnityEvent OnCorrectShape;

	public UnityEvent OnWrongShape;

	[SerializeField]
	private bool m_checkForShapeOnUpdate;

	[SerializeField]
	private ShapeShifterBehaviour m_shapeShifterToCheck;

	[SerializeField]
	private List<GameObject> m_shapesAccepted;

	private GameObject m_lastShapeEvaluated;

	private void Update()
	{
		if (!m_checkForShapeOnUpdate || m_shapeShifterToCheck == null || m_shapeShifterToCheck.LastCopiedItem == null)
		{
			return;
		}
		GameObject lastCopiedItem = m_shapeShifterToCheck.LastCopiedItem;
		if ((bool)m_lastShapeEvaluated && lastCopiedItem == m_lastShapeEvaluated)
		{
			return;
		}
		if (m_shapesAccepted != null && m_shapesAccepted.Contains(lastCopiedItem))
		{
			OnCorrectShape?.Invoke();
		}
		else
		{
			OnWrongShape?.Invoke();
		}
		m_lastShapeEvaluated = lastCopiedItem;
	}

	public void EvaluateShape(GameObject playerShape)
	{
		if (m_shapesAccepted != null && m_shapesAccepted.Contains(playerShape))
		{
			OnUnlock?.Invoke();
		}
	}
}
