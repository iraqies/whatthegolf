using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bridge : MonoBehaviour
{
	public float length;

	public List<OverworldGoal> requireGoals;

	public int requireCount;

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
	}

	private void Goal_OnUpdateData(OverworldGoal obj)
	{
	}

	private void UpdateLockStatus(bool instant)
	{
	}

	private void Unlock(bool instant)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void Make()
	{
	}
}
