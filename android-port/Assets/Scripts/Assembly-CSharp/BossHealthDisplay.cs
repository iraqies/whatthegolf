using System;
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
		int count = Boss.stages.Count;
		FinalBoss boss = Boss;
		boss.OnStageEnding = (Action<BossStage>)Delegate.Combine(boss.OnStageEnding, new Action<BossStage>(OnStageEnding));
		yield return new WaitForSeconds(2f);
		healthPoints = new List<GameObject>(count);
		for (int i = 0; i < count; i++)
		{
			GameObject item = UnityEngine.Object.Instantiate(HealthPointTemplate, base.transform);
			healthPoints.Add(item);
			healthPoints[i].gameObject.SetActive(true);
			yield return new WaitForSeconds(0.2f);
		}
	}

	private void OnStageEnding(BossStage bossStage)
	{
		StartCoroutine(RemoveHealthPoint());
	}

	private IEnumerator RemoveHealthPoint()
	{
		yield return new WaitForSeconds(1f);
		int index = healthPoints.Count - 1;
		for (int i = 0; i < 5; i++)
		{
			healthPoints[index].gameObject.SetActive(!healthPoints[index].gameObject.activeSelf);
			yield return new WaitForSecondsRealtime(0.2f);
		}
		UnityEngine.Object.Destroy(healthPoints[index]);
		healthPoints.RemoveAt(index);
	}
}
