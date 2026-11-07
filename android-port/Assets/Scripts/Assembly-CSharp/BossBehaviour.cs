using System.Collections;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
	public BossStage BossStage;

	public Rigidbody BossRigidbody;

	public virtual Vector3 Position => default;

	public virtual Quaternion Rotation => default;

	public virtual IEnumerator EndRoutine()
	{
		return null;
	}

	protected virtual void Awake()
	{
	}

	private IEnumerator DelayedEnd()
	{
		return null;
	}

	private void FixedUpdate()
	{
	}

	public virtual float GetSpeed()
	{
		return 0f;
	}
}
