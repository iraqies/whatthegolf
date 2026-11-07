using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthDisplay : MonoBehaviour
{
	public GameObject HealthPointTemplate;

	public FinalBoss Boss;

	private List<GameObject> healthPoints;

	private IEnumerator Start()
	{
		return null;
	}

	private void OnStageEnding(BossStage bossStage)
	{
	}

	private IEnumerator RemoveHealthPoint()
	{
		return null;
	}
}
