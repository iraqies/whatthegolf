using System;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviourFollowNodes : BossBehaviour
{
	public BossIslands IslandsCreator;

	public List<Transform> Nodes;

	public float MoveSpeed = 1f;

	public float RotateSpeed = 1f;

	public float UpAndDownBobSpeed = 1f;

	public float UpAndDownBobAmount;

	public float BaseCarHeight;

	public float MaxDistanceFromCar = 300f;

	public Transform Player;

	private int currentNodeIndex;

	private float currentCarBaseHeight;

	private float upAndDownBobVal;

	public override Vector3 Position
	{
		get
		{
			if (Vector3.Distance(BossRigidbody.position, Nodes[currentNodeIndex].position) < 5f)
			{
				currentNodeIndex = Mathf.Clamp(currentNodeIndex + 1, 0, Nodes.Count - 1);
			}
			Vector3 result = Vector3.MoveTowards(BossRigidbody.position, Nodes[currentNodeIndex].position, Time.deltaTime * MoveSpeed);
			if (Vector3.Distance(BossRigidbody.position, Player.position) > MaxDistanceFromCar)
			{
				result = BossRigidbody.position;
			}
			currentCarBaseHeight = Mathf.MoveTowards(currentCarBaseHeight, BaseCarHeight, Time.deltaTime);
			upAndDownBobVal += Time.deltaTime * UpAndDownBobSpeed;
			result.y = currentCarBaseHeight + UpAndDownBobAmount * Mathf.Sin(upAndDownBobVal);
			return result;
		}
	}

	public override Quaternion Rotation
	{
		get
		{
			Vector3 normalized = (Nodes[currentNodeIndex].position - BossRigidbody.position).normalized;
			if (normalized == Vector3.zero)
			{
				return BossRigidbody.rotation;
			}
			return Quaternion.RotateTowards(BossRigidbody.rotation, Quaternion.LookRotation(normalized, Vector3.up), RotateSpeed * Time.deltaTime);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		BossIslands islandsCreator = IslandsCreator;
		islandsCreator.OnNewIslandSpawned = (Action<BossIslandPart>)Delegate.Combine(islandsCreator.OnNewIslandSpawned, new Action<BossIslandPart>(NewIslandSpawned));
		BossIslands islandsCreator2 = IslandsCreator;
		islandsCreator2.OnIslandDestroyed = (Action<BossIslandPart>)Delegate.Combine(islandsCreator2.OnIslandDestroyed, new Action<BossIslandPart>(OnIslandDestroyed));
		List<BossIslandPart> spawnedParts = IslandsCreator.GetSpawnedParts();
		if (spawnedParts == null || spawnedParts.Count <= 0)
		{
			return;
		}
		foreach (BossIslandPart item in spawnedParts)
		{
			Nodes.AddRange(item.DriveNodes);
		}
	}

	private void OnIslandDestroyed(BossIslandPart bossIslandPart)
	{
		if (bossIslandPart.DriveNodes.Count <= 0)
		{
			return;
		}
		foreach (Transform driveNode in bossIslandPart.DriveNodes)
		{
			Nodes.Remove(driveNode);
		}
		currentNodeIndex -= bossIslandPart.DriveNodes.Count;
	}

	private void NewIslandSpawned(BossIslandPart bossIslandPart)
	{
		if (bossIslandPart.DriveNodes.Count > 0)
		{
			Nodes.AddRange(bossIslandPart.DriveNodes);
		}
	}

	public override float GetSpeed()
	{
		return MoveSpeed;
	}
}
