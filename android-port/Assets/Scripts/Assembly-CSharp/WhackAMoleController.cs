using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class WhackAMoleController : GolfBallShooterBase
{
	[SerializeField]
	private Animator hammerAnimator;

	[SerializeField]
	private float moveSpeed = 1f;

	[SerializeField]
	private float rotateSpeed = 10f;

	[SerializeField]
	private float blockTime = 0.5f;

	[SerializeField]
	private WinnableGolfBall leftGolfBall;

	[SerializeField]
	private WinnableGolfBall rightGolfBall;

	[SerializeField]
	private List<GameObject> leftGolfBallObstacles;

	[SerializeField]
	private List<GameObject> rightGolfBallObstacles;

	[SerializeField]
	private ParticleSystem obstacleExplosion;

	private float blockTimer;

	private new Rigidbody rigid;

	private MultiplayerConfiguration.PlayerInfo player;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		if (Level.Instance == null || Level.Instance.GetMultiplayerConfiguration() == null || Level.Instance.GetMultiplayerConfiguration().Players == null)
		{
			return;
		}
		player = Level.Instance.GetMultiplayerConfiguration().Players.FirstOrDefault((MultiplayerConfiguration.PlayerInfo p) => p != null && p.Controllers != null && p.Controllers.Contains(GolfBallController));
		if (player == null || GolfBallController == null)
		{
			return;
		}
		WinnableGolfBall winnableGolfBall = ((player.Side == LobbySpawnPoint.SpawnPointPositions.Left) ? leftGolfBall : rightGolfBall);
		if (winnableGolfBall != null)
		{
			winnableGolfBall.PlayerIndex = GolfBallController.PlayerIndex;
			Rigidbody component = winnableGolfBall.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = false;
			}
			SetMaterialColorToPlayerColor component2 = winnableGolfBall.GetComponent<SetMaterialColorToPlayerColor>();
			if (component2 != null)
			{
				component2.UpdateMaterials(player.Avatar);
			}
		}
		if (player.Side == LobbySpawnPoint.SpawnPointPositions.Left && leftGolfBallObstacles != null)
		{
			leftGolfBallObstacles.ForEach(delegate(GameObject go)
			{
				if (go != null)
				{
					SetMaterialColorToPlayerColor component3 = go.GetComponent<SetMaterialColorToPlayerColor>();
					if (component3 != null)
					{
						component3.UpdateMaterials(player.Avatar);
					}
				}
			});
		}
		else if (player.Side == LobbySpawnPoint.SpawnPointPositions.Right && rightGolfBallObstacles != null)
		{
			rightGolfBallObstacles.ForEach(delegate(GameObject go)
			{
				if (go != null)
				{
					SetMaterialColorToPlayerColor component4 = go.GetComponent<SetMaterialColorToPlayerColor>();
					if (component4 != null)
					{
						component4.UpdateMaterials(player.Avatar);
					}
				}
			});
		}
	}

	private void Update()
	{
		if (blockTimer > 0f)
		{
			blockTimer -= Time.deltaTime;
		}
	}

	public override void OnAimStart()
	{
		if (blockTimer <= 0f && hammerAnimator != null)
		{
			hammerAnimator.SetBool("Charging", true);
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (blockTimer > 0f || rigid == null)
		{
			return;
		}
		if (boost.sqrMagnitude > 0.0001f)
		{
			Quaternion to = Quaternion.LookRotation(boost.normalized);
			rigid.MoveRotation(Quaternion.RotateTowards(rigid.rotation, to, Time.deltaTime * rotateSpeed));
		}
		rigid.MovePosition(rigid.position + boost * Time.deltaTime * moveSpeed);
	}

	public override void OnShoot(Vector3 boost)
	{
		if (hammerAnimator != null)
		{
			hammerAnimator.SetBool("Charging", false);
		}
		if (GolfBallController != null)
		{
			GolfBallController.TimedBlockShot(blockTime);
		}
		blockTimer = blockTime;
	}

	public void HitSomething()
	{
		if (player == null)
		{
			return;
		}
		List<GameObject> list = ((player.Side == LobbySpawnPoint.SpawnPointPositions.Left) ? leftGolfBallObstacles : rightGolfBallObstacles);
		if (list == null)
		{
			return;
		}
		GameObject gameObject = list.FirstOrDefault(delegate(GameObject o)
		{
			if (o == null)
			{
				return false;
			}
			Rigidbody component2 = o.GetComponent<Rigidbody>();
			return component2 != null && component2.isKinematic;
		});
		if (gameObject == null)
		{
			return;
		}
		Rigidbody component = gameObject.GetComponent<Rigidbody>();
		if (component != null)
		{
			component.isKinematic = false;
			component.velocity = Vector3.up * 20f - gameObject.transform.right * 100f;
		}
		if (obstacleExplosion != null)
		{
			obstacleExplosion.transform.position = gameObject.transform.position;
			obstacleExplosion.Play();
		}
	}
}
