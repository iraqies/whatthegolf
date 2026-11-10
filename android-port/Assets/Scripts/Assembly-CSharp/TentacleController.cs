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

	public float BlockRange = 5f;

	public Vector2 BaseWeightRange = new Vector2(0.1f, 0.9f);

	private IEnumerator currentStateRoutine;

	[SerializeField]
	private TentacleStatesEnum state;

	private void Start()
	{
		StartCoroutine(TentacleRoutine());
	}

	public void SetState(TentacleStatesEnum newState)
	{
		state = newState;
		currentStateRoutine = GetNextState();
	}

	public TentacleStatesEnum GetState()
	{
		return state;
	}

	private IEnumerator TentacleRoutine()
	{
		currentStateRoutine = GetNextState();
		while (true)
		{
			if (currentStateRoutine != null)
			{
				yield return StartCoroutine(currentStateRoutine);
			}
			else
			{
				yield return null;
			}
			currentStateRoutine = GetNextState();
		}
	}

	private IEnumerator GetNextState()
	{
		return state switch
		{
			TentacleStatesEnum.Hidden => HiddenState(),
			TentacleStatesEnum.Appearing => AppearingState(),
			TentacleStatesEnum.Idle => IdleState(),
			TentacleStatesEnum.Obstacle => ObstacleRoutine(),
			TentacleStatesEnum.Blocking => BlockingState(),
			TentacleStatesEnum.Sinking => SinkState(),
			_ => IdleState(),
		};
	}

	private IEnumerator AppearingState()
	{
		float t = 0f;
		while (t < 1f)
		{
			t += Time.deltaTime;
			if (Tentacle != null && Tentacle.solver != null)
			{
				Tentacle.solver.IKPositionWeight = Mathf.Lerp(0f, BaseWeightRange.y, t);
			}
			yield return null;
		}
		state = TentacleStatesEnum.Idle;
	}

	private IEnumerator ObstacleRoutine()
	{
		float timer = 0f;
		while (state == TentacleStatesEnum.Obstacle)
		{
			timer += Time.deltaTime;
			if (Tentacle != null && Tentacle.solver != null)
			{
				Tentacle.solver.IKPositionWeight = Mathf.Lerp(BaseWeightRange.x, BaseWeightRange.y, (Mathf.Sin(timer * 2f) + 1f) * 0.5f);
			}
			yield return null;
		}
	}

	private IEnumerator IdleState()
	{
		float timer = 0f;
		while (state == TentacleStatesEnum.Idle)
		{
			timer += Time.deltaTime;
			if (Tentacle != null && Tentacle.solver != null)
			{
				Tentacle.solver.IKPositionWeight = Mathf.Lerp(BaseWeightRange.x, BaseWeightRange.y, (Mathf.Sin(timer * 1.5f) + 1f) * 0.5f);
			}
			yield return null;
		}
	}

	private IEnumerator HiddenState()
	{
		if (Tentacle != null && Tentacle.solver != null)
		{
			Tentacle.solver.IKPositionWeight = 0f;
		}
		while (state == TentacleStatesEnum.Hidden)
		{
			yield return null;
		}
	}

	private IEnumerator BlockingState()
	{
		if (Tentacle != null && Tentacle.solver != null)
		{
			Tentacle.solver.IKPositionWeight = 1f;
		}
		while (state == TentacleStatesEnum.Blocking)
		{
			yield return null;
		}
	}

	private IEnumerator SinkState()
	{
		float t = 0f;
		while (t < 1f)
		{
			t += Time.deltaTime;
			if (Tentacle != null && Tentacle.solver != null)
			{
				Tentacle.solver.IKPositionWeight = Mathf.Lerp(BaseWeightRange.y, 0f, t);
			}
			yield return null;
		}
		state = TentacleStatesEnum.Hidden;
	}
}
