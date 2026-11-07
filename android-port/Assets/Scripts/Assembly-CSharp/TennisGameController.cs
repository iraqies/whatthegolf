using TennisGolf;
using UnityEngine;

public class TennisGameController : MonoBehaviour
{
	private enum LastHitState
	{
		NONE = 0,
		PLAYER_SIDE = 1,
		OPPONENT_SIDE = 2,
		PLAYER = 3,
		OPPONENT = 4,
		OOB = 5
	}

	private LastHitState lastHitState;

	[SerializeField]
	private string PlayerPlayerTag;

	[SerializeField]
	private string OpponentPlayerTag;

	[SerializeField]
	private string PlayerSideTag;

	[SerializeField]
	private string OppenentSideTag;

	[SerializeField]
	private TennisPlayer originalTennisScript;

	private bool gameOver;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void CheckTag(string tag)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void Loose()
	{
	}

	private void Win()
	{
	}
}
