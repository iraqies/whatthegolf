using Core;
using UnityEngine;

public class ParChallenge : Challenge
{
	public int ScoreToBeat;

	public Rigidbody controllerRigid;

	public GolfBallController SpecificController;

	public bool FindAdditionalControllers;

	public bool BlockShootingAfterLastShot;

	public bool AutoFail;

	public float AutoFailThreshold;

	public float AutoFailTimer;

	public bool DoDelayedFailOnAllShotsUsed;

	public float Delay;

	private AutoFailBase m_customAutoFail;

	private GolfBallController controller;

	private GolfBallController[] additionalControllers;

	private bool checkVelocity;

	private float m_failTimer;

	private float m_startFailCheckTime;

	private int strokeCount;

	private Vector3 _lastPosition;

	private Vector3 _movementDelta;

	public bool IsLastShotOrPast { get; private set; }

	protected override void Activate()
	{
		ExitLevelOnComplete = false;
		controller = SpecificController != null ? SpecificController : FindObjectOfType<GolfBallController>();
		m_customAutoFail = GetComponent<AutoFailBase>();
		if (m_customAutoFail != null)
		{
			m_customAutoFail.OnFail += Fail;
			m_customAutoFail.Init();
		}
		if (controller != null)
		{
			controller.OnPlayerHasShot += OnShoot;
			if (controllerRigid == null)
				controllerRigid = controller.GetComponent<Rigidbody>();
		}
		if (FindAdditionalControllers)
		{
			additionalControllers = gameObject.GetComponentsInChildren<GolfBallController>(true);
			if (additionalControllers != null)
			{
				for (int i = 0; i < additionalControllers.Length; i++)
				{
					if (additionalControllers[i] != null && additionalControllers[i] != controller)
						additionalControllers[i].OnPlayerHasShot += OnShoot;
				}
			}
		}
		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(ScoreToBeat, StrokeCounter.CounterTypes.CardsAppearing, true);
		}
		strokeCount = 0;
	}

	public override string GetDescription()
	{
		string key = !string.IsNullOrEmpty(DescriptionLocalizationId) ? DescriptionLocalizationId : "ID_CHALLENGE_DESC_PAR";
		string fmt = Localization.Instance != null ? Localization.Instance.GetString(key) : key;
		try
		{
			return string.Format(fmt, ScoreToBeat);
		}
		catch
		{
			return fmt;
		}
	}

	public override string GetWinMessageID()
	{
		return !string.IsNullOrEmpty(WinMessageLocalizationId) ? WinMessageLocalizationId : "ID_WIN_MESSAGE_CHALLENGE";
	}

	private void OnShoot(GolfBallController ctrl, int strokes)
	{
		if (FindAdditionalControllers && ctrl != null && (!ctrl.enabled || !ctrl.gameObject.activeInHierarchy))
			return;
		strokeCount++;
		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			LevelManager.Instance.InGameMenu.CountStroke(ctrl, strokes);
		if (strokeCount == ScoreToBeat)
		{
			IsLastShotOrPast = true;
			if (BlockShootingAfterLastShot && ctrl != null)
				ctrl.BlockShooting = true;
			if (m_customAutoFail != null && m_customAutoFail.enabled)
			{
				m_customAutoFail.CheckAutoFail = true;
				return;
			}
			if (AutoFail)
			{
				checkVelocity = true;
				m_startFailCheckTime = Time.time;
			}
			if (DoDelayedFailOnAllShotsUsed)
			{
				StartCoroutine(pTween.To(Delay, _ => { }).Then(Fail));
			}
		}
		else if (strokeCount > ScoreToBeat)
		{
			IsLastShotOrPast = true;
			Fail();
		}
	}

	protected override void ChallengeUpdate()
	{
		if (!checkVelocity || Time.time <= m_startFailCheckTime + 0.2f)
			return;
		Vector3 vel = Vector3.zero;
		if (controllerRigid == null && controller != null)
		{
			_movementDelta = controller.transform.position - _lastPosition;
			_lastPosition = controller.transform.position;
			if (Time.deltaTime > 1e-5f)
				vel = _movementDelta / Time.deltaTime;
		}
		else if (controllerRigid != null)
		{
			vel = controllerRigid.velocity;
		}
		MovementFailCheck(vel);
	}

	private void MovementFailCheck(Vector3 movement)
	{
		if (movement.magnitude > AutoFailThreshold)
		{
			m_failTimer = 0f;
			return;
		}
		m_failTimer += Time.deltaTime;
		if (m_failTimer >= AutoFailTimer)
		{
			Fail();
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		if (controller != null && controller.NumberOfStrokes > ScoreToBeat)
		{
			Fail();
			return;
		}
		if (completedState != null)
		{
			completedState.Message = GetWinMessageID();
			completedState.Delay = 2f;
		}
		Complete();
	}
}
