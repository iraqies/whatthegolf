using System.Collections;
using Core;
using UnityEngine;

public class OverworldIsland : MonoBehaviour
{
	public Collider2D IslandExitCollider;

	public Collider2D WaveTrigger;

	public Collider2D DockTrigger;

	public GameObject PlayerPrefab;

	public float DockDistance = 3f;

	public float ExitDistance;

	public Transform IslandExit;

	public float WaveForce = 10f;

	public Transform DockPosition;

	public Transform BoatParkingTransform;

	private BoatPlayer boat;

	private Rigidbody2D ballOnIsland;

	private GolfBallController ballOnIslandController;

	private bool pushPlayerTowardsIsland;

	private bool playerCanLeave;

	private OverworldBallFollower follower;

	private bool routineRunning;

	private float baseBallDrag;

	private void Awake()
	{
		GameObject gameObject = GameObject.Find("BallFollower");
		if (gameObject != null)
		{
			follower = gameObject.GetComponent<OverworldBallFollower>();
		}
		if (follower == null)
		{
			follower = Object.FindObjectOfType<OverworldBallFollower>();
		}
	}

	public void OnPierTriggerEnter(Collider2D other)
	{
		if (other == null)
		{
			return;
		}
		BoatPlayer componentInParent = other.gameObject.GetComponentInParent<BoatPlayer>();
		if (componentInParent != null && ballOnIsland == null)
		{
			if (IslandExit != null)
			{
				IslandExit.transform.position = componentInParent.transform.position;
			}
			boat = componentInParent;
			componentInParent.Dock();
			StartCoroutine(DockRoutine());
		}
		else if (!routineRunning && ballOnIsland != null && other.attachedRigidbody == ballOnIsland)
		{
			pushPlayerTowardsIsland = false;
			StartCoroutine(BoardBoatRoutine());
		}
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		if (boat != null && other != null && other.attachedRigidbody == ballOnIsland)
		{
			pushPlayerTowardsIsland = false;
			if (ballOnIslandController != null)
			{
				ballOnIslandController.isRolling = false;
			}
			if (ballOnIsland != null)
			{
				ballOnIsland.drag = baseBallDrag;
			}
		}
	}

	public void OnTriggerExit2D(Collider2D other)
	{
		if (boat != null && other != null && other.attachedRigidbody == ballOnIsland)
		{
			pushPlayerTowardsIsland = true;
			if (ballOnIslandController != null)
			{
				ballOnIslandController.isRolling = true;
			}
		}
	}

	private IEnumerator DockRoutine()
	{
		routineRunning = true;
		Vector3 startPos = ((boat != null) ? boat.transform.position : Vector3.zero);
		Quaternion startRot = ((boat != null) ? boat.transform.rotation : Quaternion.identity);
		if (boat != null && boat.BallSprite != null && follower != null)
		{
			follower.SetTarget(boat.BallSprite.transform);
		}
		if (OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null && OverworldManager2d.Instance.ui.aimMarker != null)
		{
			OverworldManager2d.Instance.ui.aimMarker.Hide();
		}
		yield return StartCoroutine(pTween.To(1f, delegate(float t)
		{
			if (boat != null && BoatParkingTransform != null)
			{
				float t2 = Mathf.Clamp01(TweenFunctions.EaseOut(t));
				boat.transform.position = Vector3.Lerp(startPos, BoatParkingTransform.position, t2);
				float t3 = TweenFunctions.EaseOut(t);
				boat.transform.rotation = Quaternion.Lerp(startRot, BoatParkingTransform.rotation, t3);
			}
		}));
		playerCanLeave = false;
		yield return new WaitForSecondsRealtime(0.5f);
		if (boat != null && boat.BallSprite != null)
		{
			startPos = boat.BallSprite.transform.position;
		}
		Vector3 targetDockPos = ((DockPosition != null) ? DockPosition.position : startPos);
		yield return StartCoroutine(pTween.To(1f, delegate(float t)
		{
			if (boat != null && boat.BallSprite != null)
			{
				float t4 = Mathf.Clamp01(TweenFunctions.SmoothStep(t));
				boat.BallSprite.transform.position = Vector3.Lerp(startPos, targetDockPos, t4);
			}
		}));
		if (boat != null && boat.BallSprite != null)
		{
			boat.BallSprite.gameObject.SetActive(false);
			Vector3 position = boat.BallSprite.transform.position;
			Quaternion rotation = boat.BallSprite.transform.rotation;
			if (PlayerPrefab != null)
			{
				GameObject gameObject = Object.Instantiate(PlayerPrefab, position, rotation);
				ballOnIsland = gameObject.GetComponentInParent<Rigidbody2D>();
				if (ballOnIsland != null)
				{
					baseBallDrag = ballOnIsland.drag;
					ballOnIslandController = ballOnIsland.gameObject.GetComponentInParent<GolfBallController>();
					if (follower != null)
					{
						follower.SetTarget(ballOnIsland.transform);
					}
				}
			}
		}
		if (IslandExitCollider != null)
		{
			IslandExitCollider.isTrigger = true;
		}
		if (WaveTrigger != null)
		{
			WaveTrigger.gameObject.SetActive(true);
		}
		routineRunning = false;
		if (OverworldManager2d.Instance != null && ballOnIsland != null)
		{
			OverworldBall2D component = ballOnIsland.GetComponent<OverworldBall2D>();
			OverworldManager2d.Instance.RegisterBall(component, Transmogrif.BALLSHAPES.ball);
			if (OverworldManager2d.Instance.ui != null && OverworldManager2d.Instance.ui.aimMarker != null)
			{
				OverworldManager2d.Instance.ui.aimMarker.UnsubscribeToController();
				OverworldManager2d.Instance.ui.aimMarker.SubscribeToController(ballOnIslandController);
			}
		}
		if (OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnNewBall += InstanceOnOnNewBall;
		}
		if (ballOnIsland != null)
		{
			ObjectsContainer.SetIslandBall(ballOnIsland.gameObject);
		}
	}

	private void InstanceOnOnNewBall(Transmogrif.BALLSHAPES obj)
	{
		DestroyBallOnIsland();
		if (IslandExitCollider != null)
		{
			IslandExitCollider.isTrigger = false;
		}
	}

	private IEnumerator BoardBoatRoutine()
	{
		routineRunning = true;
		Vector3 startPos = ((ballOnIsland != null) ? ballOnIsland.transform.position : Vector3.zero);
		Vector3 boatPlayerPos = ((boat != null) ? boat.GetBoatPlayerPosition() : startPos);
		if (boat != null && boat.BallSprite != null)
		{
			boat.BallSprite.gameObject.SetActive(true);
			boat.BallSprite.transform.position = startPos;
		}
		if (OverworldManager2d.Instance != null && boat != null)
		{
			OverworldBall2D component = boat.GetComponent<OverworldBall2D>();
			OverworldManager2d.Instance.RegisterBall(component, Transmogrif.BALLSHAPES.boat);
		}
		DestroyBallOnIsland();
		if (boat != null && follower != null)
		{
			follower.SetTarget(boat.transform);
		}
		yield return StartCoroutine(pTween.To(1f, delegate(float t)
		{
			if (boat != null && boat.BallSprite != null)
			{
				float t2 = Mathf.Clamp01(TweenFunctions.SmoothStep(t));
				boat.BallSprite.transform.position = Vector3.Lerp(startPos, boatPlayerPos, t2);
			}
		}));
		yield return new WaitForSecondsRealtime(0.5f);
		Vector3 boatStartPos = ((boat != null) ? boat.transform.position : Vector3.zero);
		Vector3 boatEndPos = ((boat != null) ? (boatStartPos + boat.transform.right * 2f) : Vector3.zero);
		Quaternion boatStartRot = ((boat != null) ? boat.transform.rotation : Quaternion.identity);
		Vector3 normalized = (boatStartPos - boatEndPos).normalized;
		float num = Mathf.Atan2(normalized.y, normalized.x) * 57.29578f;
		Quaternion boatEndRot = Quaternion.AngleAxis(num + 90f, Vector3.forward);
		yield return StartCoroutine(pTween.To(1f, delegate(float t)
		{
			if (boat != null)
			{
				float t3 = Mathf.Clamp01(TweenFunctions.EaseIn(t));
				boat.transform.position = Vector3.Lerp(boatStartPos, boatEndPos, t3);
				float t4 = TweenFunctions.EaseIn(t);
				boat.transform.rotation = Quaternion.Lerp(boatStartRot, boatEndRot, t4);
			}
		}));
		if (OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null && OverworldManager2d.Instance.ui.aimMarker != null && boat != null)
		{
			OverworldManager2d.Instance.ui.aimMarker.SubscribeToController(boat.Controller);
		}
		if (boat != null)
		{
			boat.Undock();
		}
		if (WaveTrigger != null)
		{
			WaveTrigger.gameObject.SetActive(false);
		}
		if (boat != null)
		{
			boat.transform.rotation = boatEndRot;
		}
		yield return null;
		if (boat != null)
		{
			boat.transform.rotation = boatEndRot;
			if (boat.Rigid != null)
			{
				boat.Rigid.angularVelocity = 0f;
				Vector3 up = boat.transform.up;
				boat.Rigid.velocity = new Vector2(up.x * 2f, up.y * 2f);
			}
		}
		boat = null;
		if (IslandExitCollider != null)
		{
			IslandExitCollider.isTrigger = false;
		}
		routineRunning = false;
	}

	private void FixedUpdate()
	{
		if (pushPlayerTowardsIsland && ballOnIsland != null && IslandExitCollider != null)
		{
			Vector2 vector = IslandExitCollider.ClosestPoint(ballOnIsland.position);
			Vector2 vector2 = vector - ballOnIsland.position;
			float num = Mathf.Max(2f, vector2.magnitude);
			ballOnIsland.drag = num + baseBallDrag;
			ballOnIsland.AddForce(vector2.normalized * WaveForce * num);
			if (ballOnIslandController != null)
			{
				ballOnIslandController.isRolling = true;
			}
		}
	}

	private void OnDisable()
	{
		if (ballOnIsland != null)
		{
			ballOnIsland.gameObject.SetActive(false);
		}
	}

	private void OnEnable()
	{
		if (ballOnIsland != null)
		{
			ballOnIsland.gameObject.SetActive(true);
		}
	}

	public void DestroyBallOnIsland()
	{
		if (ballOnIsland != null)
		{
			if (OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null && OverworldManager2d.Instance.ui.aimMarker != null)
			{
				OverworldManager2d.Instance.ui.aimMarker.UnsubscribeToController();
			}
			GolfBallController component = ballOnIsland.GetComponent<GolfBallController>();
			if (component != null)
			{
				component.StopAiming();
			}
			Object.Destroy(ballOnIsland.gameObject);
			ObjectsContainer.SetIslandBall(null);
		}
		if (OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnNewBall -= InstanceOnOnNewBall;
		}
	}

	public void ToogleBallOnIsland(bool state)
	{
		if (ballOnIsland != null && ballOnIslandController != null)
		{
			ballOnIslandController.enabled = state;
		}
	}
}
