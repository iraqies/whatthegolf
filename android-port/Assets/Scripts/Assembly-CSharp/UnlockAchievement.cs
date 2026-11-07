using System.Collections;
using UnityEngine;

public class UnlockAchievement : MonoBehaviour
{
	public enum UnlockMethod
	{
		None = 0,
		Goal = 1,
		Start = 2,
		Trigger = 3,
		Collision = 4,
		Trigger2D = 5
	}

	public float progress;

	[SerializeField]
	private AchievementData m_AchievementData;

	[SerializeField]
	private UnlockMethod m_UnlockMethod;

	[SerializeField]
	private bool m_IsUnlocked;

	private GolfGoal m_Goal;

	private float nextTryUnlockTime;

	public bool IsUnlocked => false;

	private bool hasValidId => false;

	private string getPlatformId => null;

	private string saveUnlockId => null;

	public void Init()
	{
	}

	private void OnEnable()
	{
	}

	public void SetData(AchievementData a)
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	public void ManualUnlock()
	{
	}

	public void SetProgress(float progress)
	{
	}

	private void OnGoal()
	{
	}

	private void SetUnlocked()
	{
	}

	private void UnlockAchivement_Internal()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
