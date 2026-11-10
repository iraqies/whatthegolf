using System.Collections;
using Cinemachine;
using UnityEngine;

public class FlagRunningAwayOverworld : MonoBehaviour
{
	public CinemachinePathBase m_Path;

	public Animator m_Animator;

	public float m_Speed;

	private float m_Position;

	private CinemachinePathBase.PositionUnits m_PositionUnits;

	private int m_pathPointIndex;

	private float m_currentPathIndex;

	private Coroutine m_currentMovement;

	private void Update()
	{
	}

	private void SetCartPosition(float distanceAlongPath)
	{
		if (m_Path != null)
		{
			m_Position = m_Path.StandardizeUnit(distanceAlongPath, m_PositionUnits);
			base.transform.position = m_Path.EvaluatePositionAtUnit(m_Position, m_PositionUnits);
			base.transform.rotation = m_Path.EvaluateOrientationAtUnit(m_Position, m_PositionUnits);
		}
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision != null && (bool)collision.GetComponent<OverworldBall2D>() && m_currentMovement == null)
		{
			m_currentMovement = StartCoroutine(MoveToNextPoint());
		}
	}

	private IEnumerator MoveToNextPoint()
	{
		m_pathPointIndex++;
		float targetIndex = 0f;
		if (m_Path != null)
		{
			targetIndex = m_Path.StandardizeUnit(m_pathPointIndex, m_PositionUnits);
		}
		if (m_Animator != null)
		{
			m_Animator.SetBool("Run", value: true);
		}
		while (m_currentPathIndex < targetIndex && m_Path != null)
		{
			float num = m_Path.StandardizeUnit(m_currentPathIndex, m_PositionUnits);
			base.transform.position = m_Path.EvaluatePositionAtUnit(num + m_Speed * 0.1f, m_PositionUnits);
			m_currentPathIndex += Time.deltaTime * m_Speed;
			m_currentPathIndex = Mathf.Min(m_currentPathIndex, targetIndex);
			yield return new WaitForUpdate();
		}
		if (m_Animator != null)
		{
			m_Animator.SetBool("Run", value: false);
		}
		m_currentMovement = null;
	}
}
