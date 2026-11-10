using System;
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

	private string shapeKey = "Pier_{0}_Shape";

	private string beenUsedKey = "Pier_{0}_BeenUsed";

	private void Awake()
	{
		id = GetComponent<OverworldID>();
		if (SaveGame.ContainsKey(string.Format(beenUsedKey, id)))
		{
			if (FakeSpeedBoat != null)
			{
				FakeSpeedBoat.gameObject.SetActive(false);
			}
			if (FakeBoat != null)
			{
				FakeBoat.gameObject.SetActive(false);
			}
		}
		else
		{
			if (FakeSpeedBoat != null)
			{
				FakeSpeedBoat.gameObject.SetActive(FakeSpeedBoat.StartEnabled);
			}
			if (FakeBoat != null)
			{
				FakeBoat.gameObject.SetActive(FakeBoat.StartEnabled);
			}
		}
	}

	public void Reset()
	{
		SaveGame.ClearValue(string.Format(beenUsedKey, id), false);
		SaveGame.ClearValue(string.Format(shapeKey, id), false);
		if (FakeSpeedBoat != null)
		{
			FakeSpeedBoat.gameObject.SetActive(FakeSpeedBoat.StartEnabled);
		}
		if (FakeBoat != null)
		{
			FakeBoat.gameObject.SetActive(FakeBoat.StartEnabled);
		}
	}

	private IEnumerator Start()
	{
		follower = UnityEngine.Object.FindObjectOfType<OverworldBallFollower>();
		yield return null;
		string key = string.Format(shapeKey, id);
		if (SaveGame.ContainsKey(key) && BoatTransmogrif != null)
		{
			string value = SaveGame.GetValue(key, BoatTransmogrif.targetShape.ToString());
			BoatTransmogrif.targetShape = (Transmogrif.BALLSHAPES)Enum.Parse(typeof(Transmogrif.BALLSHAPES), value);
			FakeBoat fakeBoat = GetFakeBoat();
			if (fakeBoat != null)
			{
				fakeBoat.gameObject.SetActive(true);
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (waitForExit || routineRunning || other == null)
		{
			return;
		}
		OverworldBall2D componentInParent = other.gameObject.GetComponentInParent<OverworldBall2D>();
		if (componentInParent == null)
		{
			return;
		}
		routineRunning = true;
		Transmogriffable componentInParent2 = componentInParent.gameObject.GetComponentInParent<Transmogriffable>();
		if (componentInParent2 == null)
		{
			routineRunning = false;
			return;
		}
		if (componentInParent2.shape == Transmogrif.BALLSHAPES.boat || componentInParent2.shape == Transmogrif.BALLSHAPES.speedboat)
		{
			FakeBoat fakeBoat = GetFakeBoat();
			if (fakeBoat != null && !fakeBoat.gameObject.activeSelf)
			{
				StartCoroutine(DockTransmogrifRoutine(componentInParent, componentInParent2));
			}
			else
			{
				routineRunning = false;
			}
		}
		else if (IsPierOccupied())
		{
			StartCoroutine(TransmogrifRoutine(componentInParent, componentInParent2));
		}
		else
		{
			routineRunning = false;
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (waitForExit && other != null && other.gameObject.GetComponentInParent<OverworldBall2D>() != null)
		{
			waitForExit = false;
		}
	}

	private IEnumerator TransmogrifRoutine(OverworldBall2D player, Transmogriffable transmogriffable)
	{
		if (OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null && OverworldManager2d.Instance.ui.aimMarker != null)
		{
			OverworldManager2d.Instance.ui.aimMarker.Hide();
		}
		SaveGame.SetValue(string.Format(beenUsedKey, id), true, false);
		SaveGame.ClearValue(string.Format(shapeKey, id), false);
		if (player != null)
		{
			if (player.rigidBody != null)
			{
				player.rigidBody.velocity = Vector2.zero;
				player.rigidBody.angularVelocity = 0f;
			}
			if (player.controller != null)
			{
				player.controller.enabled = false;
				player.controller.StopAiming();
			}
		}
		Vector3 startPos = ((player != null) ? player.transform.position : Vector3.zero);
		FakeBoat fakeBoat = GetFakeBoat();
		if (BoatTransmogrif != null && fakeBoat != null)
		{
			BoatTransmogrif.targetPosition = fakeBoat.transform;
		}
		yield return StartCoroutine(pTween.To(1f, delegate(float t)
		{
			if (player != null)
			{
				FakeBoat fakeBoat3 = GetFakeBoat();
				if (fakeBoat3 != null && fakeBoat3.PlayerPosition != null)
				{
					float t2 = Mathf.Clamp01(TweenFunctions.EaseOut(t));
					player.transform.position = Vector3.Lerp(startPos, fakeBoat3.PlayerPosition.position, t2);
				}
			}
		}));
		FakeBoat fakeBoat2 = GetFakeBoat();
		if (fakeBoat2 != null)
		{
			fakeBoat2.gameObject.SetActive(false);
		}
		if (transmogriffable != null)
		{
			transmogriffable.TransmogrifBall(transmogriffable, BoatTransmogrif);
		}
		waitForExit = true;
		routineRunning = false;
	}

	private IEnumerator DockTransmogrifRoutine(OverworldBall2D player, Transmogriffable transmogriffable)
	{
		if (OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null && OverworldManager2d.Instance.ui.aimMarker != null)
		{
			OverworldManager2d.Instance.ui.aimMarker.Hide();
		}
		SaveGame.SetValue(string.Format(beenUsedKey, id), true, false);
		if (transmogriffable != null && BoatTransmogrif != null)
		{
			BoatTransmogrif.targetShape = transmogriffable.shape;
			FakeBoat fakeBoat = GetFakeBoat();
			if (fakeBoat != null)
			{
				BoatTransmogrif.targetPosition = fakeBoat.transform;
			}
			SaveGame.SetValue(string.Format(shapeKey, id), transmogriffable.shape.ToString(), false);
		}
		if (player != null)
		{
			if (player.rigidBody != null)
			{
				player.rigidBody.velocity = Vector2.zero;
				player.rigidBody.angularVelocity = 0f;
			}
			if (player.controller != null)
			{
				player.controller.enabled = false;
				player.controller.StopAiming();
			}
		}
		Vector3 startPos = ((player != null) ? player.transform.position : Vector3.zero);
		Quaternion startRot = ((player != null) ? player.transform.rotation : Quaternion.identity);
		yield return StartCoroutine(pTween.To(1f, delegate(float t)
		{
			if (player != null)
			{
				FakeBoat fakeBoat3 = GetFakeBoat();
				if (fakeBoat3 != null)
				{
					float t2 = Mathf.Clamp01(TweenFunctions.EaseOut(t));
					player.transform.position = Vector3.Lerp(startPos, fakeBoat3.transform.position, t2);
					float t3 = TweenFunctions.EaseOut(t);
					player.transform.rotation = Quaternion.Lerp(startRot, fakeBoat3.transform.rotation, t3);
				}
			}
		}));
		Transform ballSpriteTrans = null;
		if (player != null)
		{
			BoatPlayer componentInParent = player.gameObject.GetComponentInParent<BoatPlayer>();
			if (componentInParent != null && componentInParent.BallSprite != null)
			{
				ballSpriteTrans = componentInParent.BallSprite.transform;
			}
		}
		if (ballSpriteTrans != null)
		{
			startPos = ballSpriteTrans.position;
		}
		if (follower != null && ballSpriteTrans != null)
		{
			follower.SetTarget(ballSpriteTrans);
		}
		yield return StartCoroutine(pTween.To(1f, delegate(float t)
		{
			if (DockPlayerPosition != null && ballSpriteTrans != null)
			{
				float t4 = Mathf.Clamp01(TweenFunctions.EaseOut(t));
				ballSpriteTrans.position = Vector3.Lerp(startPos, DockPlayerPosition.position, t4);
			}
		}));
		FakeBoat fakeBoat2 = GetFakeBoat();
		if (fakeBoat2 != null)
		{
			fakeBoat2.gameObject.SetActive(true);
		}
		if (transmogriffable != null)
		{
			transmogriffable.TransmogrifBall(transmogriffable, BallTransmogrif);
		}
		routineRunning = false;
	}

	private FakeBoat GetFakeBoat()
	{
		if (BoatTransmogrif != null)
		{
			if (BoatTransmogrif.targetShape == Transmogrif.BALLSHAPES.boat)
			{
				return FakeBoat;
			}
			if (BoatTransmogrif.targetShape == Transmogrif.BALLSHAPES.speedboat)
			{
				return FakeSpeedBoat;
			}
		}
		return null;
	}

	public bool IsPierOccupied()
	{
		FakeBoat fakeBoat = GetFakeBoat();
		if (fakeBoat != null)
		{
			return fakeBoat.gameObject.activeSelf;
		}
		return false;
	}
}
