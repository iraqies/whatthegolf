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
	}

	public void EvaluateShape(GameObject playerShape)
	{
	}
}
