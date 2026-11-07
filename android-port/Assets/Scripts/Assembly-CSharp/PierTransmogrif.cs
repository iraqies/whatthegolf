using System.Collections;
using UnityEngine;

public class PierTransmogrif : MonoBehaviour
{
	public Transmogrif BoatTransmogrif;

	public Transmogrif BallTransmogrif;

	public FakeBoat FakeBoat;

	public FakeBoat FakeSpeedBoat;

	public Transform DockPlayerPosition;

	private bool waitForExit;

	private bool routineRunning;

	private OverworldBallFollower follower;

	private OverworldID id;

	private string shapeKey;

	private string beenUsedKey;

	private void Awake()
	{
	}

	public void Reset()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private IEnumerator TransmogrifRoutine(OverworldBall2D player, Transmogriffable transmogriffable)
	{
		return null;
	}

	private IEnumerator DockTransmogrifRoutine(OverworldBall2D player, Transmogriffable transmogriffable)
	{
		return null;
	}

	private FakeBoat GetFakeBoat()
	{
		return null;
	}

	public bool IsPierOccupied()
	{
		return false;
	}
}
