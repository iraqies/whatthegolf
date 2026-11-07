using System.Collections;
using Audio;
using UnityEngine;

public class MarioEndFlag : MonoBehaviour
{
	public float FlagMoveSpeed;

	public ScheduleHarmonics harmonicsOnEnd;

	private float baseVolume;

	private float bonusVolume;

	private float increaseOverTime;

	private Rigidbody player;

	private bool isDone;

	private Vector3 debugStart;

	private void Awake()
	{
	}

	public void DebugReset()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private IEnumerator MovePlayerAndFlagDown(Rigidbody player)
	{
		return null;
	}
}
