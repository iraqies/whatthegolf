using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class BurgerLayerBounce : MonoBehaviour
{
	[SerializeField]
	private GolfBallController m_controller;

	[SerializeField]
	private List<Transform> m_layersToMove;

	[SerializeField]
	private float m_forceMultiplier;

	[SerializeField]
	private float m_floatSpeed;

	private List<Vector3> m_savedLayerPos;

	private Coroutine m_currentFloatRoutine;

	private void Start()
	{
	}

	private void BurgerShot(Vector3 force)
	{
	}

	private IEnumerator FloatIngredientsLayer(float magnitude)
	{
		return null;
	}

	private void ResetIngredientsPos()
	{
	}
}
