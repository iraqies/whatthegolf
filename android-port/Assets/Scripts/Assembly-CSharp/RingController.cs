using System.Collections.Generic;
using UnityEngine;

public class RingController : MonoBehaviour
{
	public LobbySpawnPoint.SpawnPointPositions Side;

	public float MoveSpeed;

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
	}

	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
	}

	private void FixedUpdate()
	{
	}
}
