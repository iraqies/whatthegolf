using System.Collections.Generic;
using Core;
using UnityEngine;

public class RingController : MonoBehaviour
{
	public LobbySpawnPoint.SpawnPointPositions Side;

	public float MoveSpeed = 1f;

	public List<SetMaterialColorToPlayerColor> Ring;

	public SetMaterialColorToPlayerColor Ball;

	public SetMaterialColorToPlayerColor Line;

	public Transform Top;

	public Transform Bottom;

	public GolfGoal goal;

	private Rigidbody rigid;

	private int playerIndex;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		Level.Instance.OnMultiplayerSetup += InstanceOnOnMultiplayerSetup;
	}

	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
		foreach (MultiplayerConfiguration.PlayerInfo player in Level.Instance.GetMultiplayerConfiguration().Players)
		{
			if (player.Side == Side)
			{
				playerIndex = player.InputIndex;
				Ring.ForEach(delegate(SetMaterialColorToPlayerColor r)
				{
					r.UpdateMaterials(player.Avatar.Color);
				});
				Ball.UpdateMaterials(player.Avatar.Color);
				Line.UpdateMaterials(player.Avatar.Color);
			}
		}
	}

	private void FixedUpdate()
	{
		rigid.transform.position = rigid.position + Vector3.up * rigid.angularVelocity.y * MoveSpeed * Time.deltaTime;
		if (rigid.transform.position.y < Bottom.transform.position.y)
		{
			rigid.transform.position = new Vector3(rigid.transform.position.x, Bottom.transform.position.y, rigid.transform.position.z);
		}
		else if (rigid.transform.position.y > Top.transform.position.y - 2f)
		{
			goal.GoalProgress(playerIndex);
			goal.Complete();
		}
	}
}
