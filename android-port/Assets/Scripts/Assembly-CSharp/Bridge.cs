using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Bridge : MonoBehaviour
{
	public float length;

	public List<OverworldGoal> requireGoals;

	public int requireCount = 1;

	public GameObject leftStartPillar;

	public GameObject rightStartPillar;

	public GameObject leftEndPillar;

	public GameObject rightEndPillar;

	public GameObject plank;

	public BoxCollider boxCollider;

	public GameObject pivot;

	public TextMeshPro text;

	public GameObject Sign;

	private bool isUnlocked;

	private void Start()
	{
		if (pivot != null)
		{
			pivot.transform.localRotation = Quaternion.Euler(300f, 270f, 0f);
		}
		UpdateLockStatus(true);
		if (requireGoals == null)
		{
			return;
		}
		foreach (OverworldGoal requireGoal in requireGoals)
		{
			if (requireGoal != null)
			{
				requireGoal.OnUpdateData += Goal_OnUpdateData;
			}
		}
	}

	private void Goal_OnUpdateData(OverworldGoal obj)
	{
		UpdateLockStatus(false);
	}

	private void UpdateLockStatus(bool instant)
	{
		int num = 0;
		if (requireGoals != null)
		{
			foreach (OverworldGoal requireGoal in requireGoals)
			{
				if (requireGoal != null && requireGoal.IsCompleted())
				{
					num++;
				}
			}
		}
		if (num >= requireCount)
		{
			Unlock(instant);
		}
		if (text != null)
		{
			text.SetLocalizedText((requireCount - num).ToString());
		}
	}

	private void Unlock(bool instant)
	{
		if (!isUnlocked)
		{
			isUnlocked = true;
			if (Sign != null)
			{
				Sign.SetActive(false);
			}
			if (pivot != null)
			{
				pivot.transform.localRotation = Quaternion.Euler(0f, 270f, 0f);
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawLine(base.transform.position, base.transform.position - base.transform.right * length);
	}

	public void Make()
	{
		if (pivot != null)
		{
			pivot.transform.localRotation = Quaternion.Euler(0f, 270f, 0f);
			foreach (Transform item in pivot.GetComponentsInChildren<Transform>().ToList())
			{
				if (item != null && item.name.Contains("plank"))
				{
					Object.DestroyImmediate(item.gameObject);
				}
			}
		}
		int num = Mathf.CeilToInt(length / 7f);
		for (int i = 0; i < num; i++)
		{
			if (plank != null)
			{
				Vector3 position = plank.transform.position - base.transform.right * ((float)(i + 1) * 7f);
				GameObject gameObject = Object.Instantiate(plank, position, plank.transform.rotation, plank.transform.parent);
				if (gameObject != null)
				{
					gameObject.transform.position = position;
					gameObject.name = "plank";
				}
			}
		}
		if (leftEndPillar != null && leftStartPillar != null)
		{
			leftEndPillar.transform.position = leftStartPillar.transform.position - base.transform.right * length;
		}
		if (rightEndPillar != null && rightStartPillar != null)
		{
			rightEndPillar.transform.position = rightStartPillar.transform.position - base.transform.right * length;
		}
		if (boxCollider != null)
		{
			boxCollider.transform.localScale = new Vector3(31f, 1f, length);
			if (pivot != null)
			{
				boxCollider.transform.position = pivot.transform.position - base.transform.right * length * 0.5f - Vector3.up * 0.51f;
			}
		}
	}
}
