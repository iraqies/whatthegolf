using System.Collections.Generic;
using UnityEngine;

public class BossBehaviourFollowNodes : BossBehaviour
{
	public BossIslands IslandsCreator;

	public List<Transform> Nodes;

	public float MoveSpeed;

	public float RotateSpeed;

	public float UpAndDownBobSpeed;

	public float UpAndDownBobAmount;

	public float BaseCarHeight;

	public float MaxDistanceFromCar;

	public Transform Player;

	private int currentNodeIndex;

	private float currentCarBaseHeight;

	private float upAndDownBobVal;

	public override Vector3 Position => default;

	public override Quaternion Rotation => default;

	protected override void Awake()
	{
		base.Awake();
	}

	private void OnIslandDestroyed(BossIslandPart bossIslandPart)
	{
	}

	private void NewIslandSpawned(BossIslandPart bossIslandPart)
	{
	}

	public override float GetSpeed()
	{
		return 0f;
	}
}
