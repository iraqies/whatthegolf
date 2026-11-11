using Core;
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
		if (other != null && !(other.gameObject.tag == PlayerPlayerTag) && !(other.gameObject.tag == OpponentPlayerTag))
		{
			CheckTag(other.tag);
		}
	}

	private void CheckTag(string tag)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		LastHitState lastHitState = LastHitState.NONE;
		if (tag == PlayerPlayerTag)
		{
			flag = true;
			lastHitState = LastHitState.PLAYER;
		}
		else if (tag == OpponentPlayerTag)
		{
			flag = true;
			lastHitState = LastHitState.OPPONENT;
		}
		else if (tag == PlayerSideTag)
		{
			flag = true;
			flag2 = true;
			lastHitState = LastHitState.PLAYER_SIDE;
		}
		else if (tag == OppenentSideTag)
		{
			flag = true;
			flag3 = true;
			lastHitState = LastHitState.OPPONENT_SIDE;
		}
		else if (tag == "Ground" || tag == "OutOfBounds")
		{
			flag = true;
			flag4 = true;
			lastHitState = LastHitState.OOB;
		}
		Debug.Log("xx hit " + tag + "  " + this.lastHitState);
		if (!flag)
		{
			return;
		}
		if (flag2 && this.lastHitState == LastHitState.PLAYER_SIDE)
		{
			Loose();
		}
		else if (flag3 && this.lastHitState == LastHitState.OPPONENT_SIDE)
		{
			Win();
		}
		else if (flag4)
		{
			switch (this.lastHitState)
			{
			case LastHitState.PLAYER_SIDE:
			case LastHitState.PLAYER:
				Loose();
				break;
			case LastHitState.OPPONENT_SIDE:
			case LastHitState.OPPONENT:
				Win();
				break;
			}
		}
		this.lastHitState = lastHitState;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other != null && (!(other.gameObject.tag != PlayerPlayerTag) || !(other.gameObject.tag != OpponentPlayerTag)))
		{
			CheckTag(other.gameObject.tag);
		}
	}

	private void Loose()
	{
		if (!gameOver)
		{
			gameOver = true;
			Debug.Log("xx Loose");
			if (Level.Instance != null)
			{
				Level.Instance.Fail(true, true, null, 0f, true, "");
			}
		}
	}

	private void Win()
	{
		if (!gameOver)
		{
			gameOver = true;
			Debug.Log("xx Win");
			if (originalTennisScript != null)
			{
				originalTennisScript.OnPlayerWon();
			}
		}
	}
}
