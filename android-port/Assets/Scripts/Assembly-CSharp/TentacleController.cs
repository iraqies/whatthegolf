using System.Collections;
using RootMotion.FinalIK;
using UnityEngine;

public class TentacleController : MonoBehaviour
{
	public enum TentacleStatesEnum
	{
		Hidden = 0,
		Appearing = 1,
		Idle = 2,
		Obstacle = 3,
		Blocking = 4,
		Sinking = 5
	}

	public CCDIK Tentacle;

	public float BlockRange;

	public Vector2 BaseWeightRange;

	private IEnumerator currentStateRoutine;

	[SerializeField]
	private TentacleStatesEnum state;

	private void Start()
	{
	}

	public void SetState(TentacleStatesEnum newState)
	{
	}

	public TentacleStatesEnum GetState()
	{
		return TentacleStatesEnum.Hidden;
	}

	private IEnumerator TentacleRoutine()
	{
		return null;
	}

	private IEnumerator GetNextState()
	{
		return null;
	}

	private IEnumerator AppearingState()
	{
		return null;
	}

	private IEnumerator ObstacleRoutine()
	{
		return null;
	}

	private IEnumerator IdleState()
	{
		return null;
	}

	private IEnumerator HiddenState()
	{
		return null;
	}

	private IEnumerator BlockingState()
	{
		return null;
	}

	private IEnumerator SinkState()
	{
		return null;
	}
}
