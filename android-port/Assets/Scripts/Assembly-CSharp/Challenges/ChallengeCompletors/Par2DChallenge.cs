using Core;
using UnityEngine;

namespace Challenges.ChallengeCompletors
{
	public class Par2DChallenge : Challenge
	{
		public int ScoreToBeat;

		public bool AutoFail = true;

		public float AutoFailThreshold = 0.5f;

		public float AutoFailTimer = 0.1f;

		private GolfBallController controller;

		public Rigidbody2D controllerRigid;

		private bool checkVelocity;

		private float m_failTimer;

		protected override void Activate()
		{
			ExitLevelOnComplete = false;
			controller = Object.FindObjectOfType<GolfBallController>();
			if (controller != null)
			{
				if (controllerRigid == null)
				{
					controllerRigid = controller.GetComponent<Rigidbody2D>();
				}
				controllerRigid = controller.GetComponent<Rigidbody2D>();
				controller.OnShoot += OnShoot;
				controller.OnPlayerHasShot += OnHasShot;
			}
			if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			{
				LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(ScoreToBeat, StrokeCounter.CounterTypes.CardsAppearing, true);
			}
		}

		public override string GetDescription()
		{
			string id = (string.IsNullOrEmpty(DescriptionLocalizationId) ? "ID_CHALLENGE_PAR" : DescriptionLocalizationId);
			if (Localization.Instance != null)
			{
				return string.Format(Localization.Instance.GetString(id), ScoreToBeat);
			}
			return id;
		}

		public override string GetWinMessageID()
		{
			if (!string.IsNullOrEmpty(WinMessageLocalizationId))
			{
				return WinMessageLocalizationId;
			}
			return "ID_CHALLENGE_PAR_COMPLETION";
		}

		private void OnHasShot(GolfBallController controller, int strokes)
		{
			if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			{
				LevelManager.Instance.InGameMenu.CountStroke(controller, strokes);
			}
		}

		private void OnShoot(Vector3 v)
		{
			if (controller == null)
			{
				return;
			}
			int num = controller.NumberOfStrokes + 1;
			if (num > ScoreToBeat)
			{
				Fail();
			}
			else if (num == ScoreToBeat)
			{
				checkVelocity = true;
			}
		}

		protected override void ChallengeUpdate()
		{
			if (!checkVelocity || !AutoFail || controllerRigid == null)
			{
				return;
			}
			if (controllerRigid.velocity.magnitude > AutoFailThreshold)
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
			if (completedState == null)
			{
				return;
			}
			if (completedState.NumberOfStrokes > ScoreToBeat)
			{
				Fail();
				return;
			}
			completedState.Message = "ID_EMPTY_STRING";
			completedState.Delay = 2f;
			completedState.ShowCrown = true;
			Complete();
		}
	}
}
