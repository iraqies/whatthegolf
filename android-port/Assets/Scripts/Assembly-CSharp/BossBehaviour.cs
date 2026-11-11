using System.Collections;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
	public BossStage BossStage;

	public Rigidbody BossRigidbody;

	public virtual Vector3 Position => BossRigidbody != null ? BossRigidbody.position : transform.position;

	public virtual Quaternion Rotation => BossRigidbody != null ? BossRigidbody.rotation : transform.rotation;

	public virtual IEnumerator EndRoutine()
	{
		yield break;
	}

	protected virtual void Awake()
	{
		if (BossStage != null)
		{
			BossStage.OnChallengeEnd += () => StartCoroutine(DelayedEnd());
		}
	}

	private IEnumerator DelayedEnd()
	{
		yield return StartCoroutine(EndRoutine());
	}

	private void FixedUpdate()
	{
		if (BossRigidbody != null)
		{
			BossRigidbody.MovePosition(Position);
			BossRigidbody.MoveRotation(Rotation);
		}
	}

	public virtual float GetSpeed()
	{
		return 0f;
	}
}
