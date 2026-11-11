using System.Collections.Generic;
using Core;
using UnityEngine;

public class BossPlayerFollowNodesTowardsGoal : MonoBehaviour
{
	public BossIslands IslandsCreator;

	public Rigidbody PlayerRigid;

	[SerializeField]
	private List<Transform> nodes = new List<Transform>();

	public AnimationCurve MoveSpeed = AnimationCurve.Linear(0f, 10f, 1f, 20f);

	public float RotateSpeed = 10f;

	public float MoveSpeedIncreaseSpeed = 0.5f;

	public Transform Goal;

	public float DeathTimer = 1.5f;

	public float minDistance = 2.5f;

	private float moveTimer;

	private void Start()
	{
		if (IslandsCreator != null)
		{
			IslandsCreator.OnNewIslandSpawned += NewIslandSpawned;
		}
		if (nodes == null)
		{
			nodes = new List<Transform>();
		}
		if (Goal != null)
		{
			nodes.Add(Goal);
		}
	}

	private void NewIslandSpawned(BossIslandPart bossIslandPart)
	{
		if (bossIslandPart == null || bossIslandPart.DriveNodes == null)
		{
			return;
		}
		if (Goal != null)
		{
			nodes.Remove(Goal);
		}
		for (int i = 0; i < bossIslandPart.DriveNodes.Count; i++)
		{
			if (bossIslandPart.DriveNodes[i] != null)
			{
				nodes.Add(bossIslandPart.DriveNodes[i]);
			}
		}
		if (Goal != null)
		{
			nodes.Add(Goal);
		}
	}

	private void FixedUpdate()
	{
		if (PlayerRigid == null || nodes == null || nodes.Count == 0 || nodes[0] == null)
		{
			return;
		}
		moveTimer = Mathf.Clamp01(moveTimer + Time.fixedDeltaTime * MoveSpeedIncreaseSpeed);
		Vector3 targetPos = nodes[0].position;
		Vector3 curPos = PlayerRigid.position;
		Vector3 toTarget = new Vector3(targetPos.x - curPos.x, 0f, targetPos.z - curPos.z);
		if (toTarget.sqrMagnitude > 0.0001f)
		{
			Quaternion targetRot = Quaternion.LookRotation(toTarget.normalized, Vector3.up);
			PlayerRigid.MoveRotation(Quaternion.Slerp(PlayerRigid.rotation, targetRot, Time.fixedDeltaTime * RotateSpeed));
		}
		float spd = MoveSpeed != null && MoveSpeed.length > 0 ? MoveSpeed.Evaluate(moveTimer) : 15f;
		Vector3 moveStep = (targetPos - curPos).normalized * (spd * Time.fixedDeltaTime);
		PlayerRigid.MovePosition(curPos + moveStep);
		if (Vector3.Distance(PlayerRigid.position, nodes[0].position) < minDistance && nodes.Count > 1)
		{
			nodes.RemoveAt(0);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other != null && other.gameObject != null && other.gameObject.CompareTag("Obstacle"))
		{
			moveTimer = 0f;
		}
	}

	private void OnTriggerStay(Collider other)
	{
		if (other != null && other.CompareTag("DeathTrigger"))
		{
			DeathTimer -= Time.deltaTime;
			if (DeathTimer <= 0f && Level.Instance != null)
			{
				GolfBallController ctrl = GetComponentInParent<GolfBallController>();
				Level.Instance.Fail(true, true, ctrl, 0f, true, "DeathTrigger");
			}
		}
	}
}
