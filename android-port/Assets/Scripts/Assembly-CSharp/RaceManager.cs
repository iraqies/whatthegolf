using Core;
using UnityEngine;

public class RaceManager : MonoBehaviour
{
	public TrafficLight[] trafficLights;

	public CarDriver[] opponents;

	public GolfBallController player;

	public GolfGoal goal;

	public AudioClip sound1;

	public AudioClip sound2;

	private AudioSource source;

	private bool done;

	private void Start()
	{
		source = GetComponent<AudioSource>();
		if (player != null)
		{
			player.OnAimStart += Player_OnAimStart;
			player.OnCancel += Player_OnCancel;
			player.OnShoot += Player_OnShoot;
		}
		if (goal != null)
		{
			goal.OnGoal += Goal_OnGoal;
		}
	}

	private void Player_OnAimStart()
	{
		if (trafficLights != null)
		{
			for (int i = 0; i < trafficLights.Length; i++)
			{
				if (trafficLights[i] != null)
				{
					trafficLights[i].onLight = TrafficLight.LightId.yellow;
				}
			}
		}
		if (source != null)
		{
			source.clip = sound1;
			source.Play();
		}
	}

	private void Player_OnShoot(Vector3 obj)
	{
		if (trafficLights != null)
		{
			for (int i = 0; i < trafficLights.Length; i++)
			{
				if (trafficLights[i] != null)
				{
					trafficLights[i].onLight = TrafficLight.LightId.green;
				}
			}
		}
		if (source != null)
		{
			source.clip = sound2;
			source.Play();
		}
		if (player != null)
		{
			player.OnAimStart -= Player_OnAimStart;
			player.OnCancel -= Player_OnCancel;
			player.OnShoot -= Player_OnShoot;
		}
		if (opponents == null)
		{
			return;
		}
		for (int j = 0; j < opponents.Length; j++)
		{
			if (opponents[j] != null)
			{
				opponents[j].wait = false;
			}
		}
	}

	private void Player_OnCancel()
	{
		if (trafficLights != null)
		{
			for (int i = 0; i < trafficLights.Length; i++)
			{
				if (trafficLights[i] != null)
				{
					trafficLights[i].onLight = TrafficLight.LightId.red;
				}
			}
		}
		if (source != null)
		{
			source.clip = sound1;
			source.Play();
		}
	}

	public void OpponentTouchedFlag(CarDriver opponent)
	{
		if (!done && Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "");
		}
	}

	private void Goal_OnGoal(string obj)
	{
		done = true;
	}
}
