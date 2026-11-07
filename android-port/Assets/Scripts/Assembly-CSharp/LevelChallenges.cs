using System;
using Malee;
using UnityEngine;

public class LevelChallenges : MonoBehaviour
{
	public enum gameVersion
	{
		Base = 0,
		OL = 1
	}

	[Serializable]
	public class ChallengeList : ReorderableArray<Challenge>
	{
	}

	[SerializeField]
	public ChallengeList Challenges;

	private bool hasFailedLevel;

	public gameVersion failMessages;

	private string[] olFailMessages;

	private static System.Random random;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnChallengeSelected(string id)
	{
	}

	private void Complete(Challenge challenge)
	{
	}

	private void Fail(Challenge challenge)
	{
	}

	public string GenerateId(int length)
	{
		return null;
	}
}
