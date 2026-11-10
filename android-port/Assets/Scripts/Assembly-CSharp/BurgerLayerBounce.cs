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
		if (m_controller != null)
		{
			m_controller.OnShoot += BurgerShot;
		}
		m_savedLayerPos = new List<Vector3>();
		if (m_layersToMove == null)
		{
			return;
		}
		for (int i = 0; i < m_layersToMove.Count; i++)
		{
			if (m_layersToMove[i] != null)
			{
				m_savedLayerPos.Add(m_layersToMove[i].localPosition);
			}
		}
	}

	private void BurgerShot(Vector3 force)
	{
		if (m_currentFloatRoutine != null)
		{
			StopCoroutine(m_currentFloatRoutine);
		}
		ResetIngredientsPos();
		m_currentFloatRoutine = StartCoroutine(FloatIngredientsLayer(force.magnitude));
	}

	private IEnumerator FloatIngredientsLayer(float magnitude)
	{
		float time = 0.01f;
		bool goingDown = false;
		while (time > 0f)
		{
			for (int i = 0; i < m_layersToMove.Count; i++)
			{
				if (m_layersToMove[i] != null && m_savedLayerPos != null && i < m_savedLayerPos.Count)
				{
					Vector3 b = new Vector3(m_savedLayerPos[i].x, m_savedLayerPos[i].y + magnitude * m_forceMultiplier, m_savedLayerPos[i].z);
					m_layersToMove[i].localPosition = Vector3.Lerp(m_savedLayerPos[i], b, Mathf.Clamp01(time));
				}
				yield return new WaitForEndOfFrame();
			}
			if (time >= magnitude || goingDown)
			{
				goingDown = true;
				time -= m_floatSpeed * Time.deltaTime;
			}
			else
			{
				time += m_floatSpeed * Time.deltaTime;
			}
		}
	}

	private void ResetIngredientsPos()
	{
		if (m_layersToMove == null || m_savedLayerPos == null)
		{
			return;
		}
		for (int i = 0; i < m_layersToMove.Count; i++)
		{
			if (m_layersToMove[i] != null && i < m_savedLayerPos.Count)
			{
				m_layersToMove[i].localPosition = m_savedLayerPos[i];
			}
		}
	}
}
