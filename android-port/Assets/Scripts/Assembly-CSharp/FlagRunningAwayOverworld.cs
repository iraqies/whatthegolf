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
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
	}

	private IEnumerator MoveToNextPoint()
	{
		return null;
	}
}
