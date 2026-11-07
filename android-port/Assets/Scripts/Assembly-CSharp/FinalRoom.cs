using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class FinalRoom : GolfBehaviour
{
	public OverworldGoal goal;

	public GameObject evilContainer;

	public SpriteMask mask;

	public List<Transform> exitPath;

	public ConfettiSpawner confetti;

	public OverworldMusicData triumpOverworldMusicData;

	public OverworldMusic overworldMusicManager;

	public float ballMoveSpeed;

	public float shootoutSpeed;

	private bool completed;

	public UnlockAchievement bossAchievement;

	private void Start()
	{
	}

	private void Goal_Completed_OnUpdateData(OverworldGoal obj)
	{
	}

	private void Goal_OnUpdateData(OverworldGoal flag)
	{
	}

	private IEnumerator EndRoutine()
	{
		return null;
	}

	private void SetCompletedState()
	{
	}
}
