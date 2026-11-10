using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChestManager : GolfBehaviour
{
	public Transmogrif grif;

	public Transform tropheeCenter;

	public OverworldCameraSettings cameraForOpeningChest;

	public OverworldCameraSettings CameraSettingsForTeleport;

	public bool isAlwaysTeleportingBall;

	public List<ChestTrophee> allChestsTrophees;

	public OverworldTriggerCameraBlender winAreaBlender;

	private bool previousBallState;

	public int OpenedChests
	{
		get
		{
			if (allChestsTrophees == null)
			{
				return 0;
			}
			return allChestsTrophees.Count((ChestTrophee c) => c != null && c.IsUnlocked());
		}
	}

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		allChestsTrophees = GetComponentsInChildren<ChestTrophee>().ToList();
	}

	private void Start()
	{
		if (allChestsTrophees == null)
		{
			return;
		}
		foreach (ChestTrophee c in allChestsTrophees)
		{
			if (c == null)
			{
				continue;
			}
			if (c.HasChest())
			{
				c.OnPreChestOpen += delegate(Chest chest)
				{
					Chest_OnChestPreOpen(c, chest);
				};
				c.Init();
			}
			else
			{
				Debug.LogWarning("ChestTrophee missing chest: " + c.name, c.gameObject);
			}
		}
	}

	private void Chest_OnChestPreOpen(ChestTrophee trophee, Chest chest)
	{
		if (chest != null)
		{
			chest.OnPostChestOpen += delegate(Chest c)
			{
				Chest_OnPostChestOpenFirst(trophee, c);
			};
		}
		StartCoroutine(pTween.To(0.3f, delegate(float t)
		{
			if (cameraForOpeningChest != null)
			{
				cameraForOpeningChest.SetValue(t);
			}
		}).Then(delegate
		{
			if (CameraSettingsForTeleport != null)
			{
				CameraSettingsForTeleport.SetValue(1f);
			}
		}));
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.ball != null)
		{
			OverworldBall2D ball = OverworldBallManager.Instance.ball;
			if (ball.controller != null)
			{
				ball.controller.CancelShooting();
			}
			ball.StopAndSleep();
			if (ball.controller != null)
			{
				previousBallState = ball.controller.enabled;
				ball.controller.enabled = false;
			}
		}
		if (ObjectsContainer.Instance != null)
		{
			ObjectsContainer.Instance.DisableObjectsCheck(true);
		}
	}

	private void Chest_OnPostChestOpenFirst(ChestTrophee trophee, Chest chest)
	{
		StartCoroutine(OnOpenChestPost(trophee, chest));
	}

	private IEnumerator OnOpenChestPost(ChestTrophee trophee, Chest chest)
	{
		if (winAreaBlender != null)
		{
			winAreaBlender.dontBlend = true;
		}
		bool isFirstChest = OpenedChests == 1;
		OverworldBall2D ball = ((OverworldBallManager.Instance != null) ? OverworldBallManager.Instance.ball : null);
		if (ball != null)
		{
			ball.SetColliders(false);
		}
		Vector3 targetPos = Vector3.zero;
		if (ball != null && trophee != null)
		{
			float z = ball.transform.position.z;
			targetPos = trophee.transform.position + trophee.TeleportOffset;
			targetPos.z = z;
		}
		OverworldBallFollower follower = ((OverworldBallManager.Instance != null) ? OverworldBallManager.Instance.ballProxy : null);
		if (follower != null)
		{
			follower.isFollowing = false;
		}
		if (winAreaBlender != null)
		{
			winAreaBlender.BlendInWithoutSettings();
		}
		if (CameraSettingsForTeleport != null)
		{
			CameraSettingsForTeleport.SetValue(1f);
		}
		if (follower != null && trophee != null)
		{
			follower.transform.position = targetPos + Vector3.up * 2f - trophee.TeleportOffset;
		}
		yield return null;
		if (trophee != null)
		{
			trophee.Chest_OnChestOpen(chest);
		}
		yield return new WaitForSeconds(2f);
		if (isFirstChest)
		{
			if (grif != null && ball != null)
			{
				Transmogriffable component = ball.GetComponent<Transmogriffable>();
				if (component != null)
				{
					component.TransmogrifBall(component, grif);
					if (OverworldBallManager.Instance != null)
					{
						ball = OverworldBallManager.Instance.ball;
					}
				}
			}
			Vector3 startPos = ((trophee != null) ? (trophee.transform.position + Vector3.up * 2.5f) : targetPos);
			if (ball != null)
			{
				if (ball.rigidBody != null)
				{
					ball.rigidBody.velocity = Vector2.zero;
					ball.rigidBody.angularVelocity = 0f;
				}
				if (ball.rigid != null)
				{
					ball.rigid.velocity = Vector2.zero;
					ball.rigid.angularVelocity = 0f;
				}
			}
			yield return StartCoroutine(pTween.To(0.7f, delegate(float t)
			{
				float num = Mathf.Clamp01(TweenFunctions.EaseOutBounce(0f, 1f, t));
				Vector3 position = Vector3.Lerp(startPos, targetPos, num);
				if (ball != null)
				{
					if (ball.rigidBody != null)
					{
						ball.rigidBody.MovePosition(position);
					}
					ball.transform.position = position;
				}
			}));
		}
		yield return new WaitForSeconds(0.5f);
		if (ball != null && follower != null)
		{
			follower.transform.position = ball.transform.position;
		}
		if (previousBallState && ball != null)
		{
			ball.StartAndWakeup();
			if (ball.controller != null)
			{
				ball.controller.enabled = true;
			}
			ball.enabled = true;
			ball.SetColliders(true);
		}
		if (winAreaBlender != null)
		{
			winAreaBlender.dontBlend = false;
		}
		if (isFirstChest)
		{
			yield return StartCoroutine(pTween.To(0.2f, delegate(float t)
			{
				if (CameraSettingsForTeleport != null)
				{
					CameraSettingsForTeleport.SetValue(1f - TweenFunctions.EaseOut(t));
				}
			}));
			yield return StartCoroutine(pTween.To(0.4f, delegate(float t)
			{
				if (winAreaBlender != null && winAreaBlender.CameraSettings != null)
				{
					winAreaBlender.CameraSettings.SetValue(t);
				}
			}));
		}
		else
		{
			if (winAreaBlender != null)
			{
				winAreaBlender.BlendOutWithoutSettings();
			}
			yield return StartCoroutine(pTween.To(0.3f, delegate(float t)
			{
				if (CameraSettingsForTeleport != null)
				{
					CameraSettingsForTeleport.SetValue(1f - TweenFunctions.EaseOut(t));
				}
			}));
		}
		if (winAreaBlender != null)
		{
			winAreaBlender.dontBlend = false;
		}
		if (ObjectsContainer.Instance != null)
		{
			ObjectsContainer.Instance.DisableObjectsCheck(false);
		}
		if (follower != null)
		{
			follower.isFollowing = true;
		}
	}
}
