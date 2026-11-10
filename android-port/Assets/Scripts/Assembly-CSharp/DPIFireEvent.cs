using UnityEngine;
using UnityEngine.Events;

public class DPIFireEvent : BaseDailyPrizeInteractions
{
	public UnityEvent Event;

	public float minThreshold;

	public float maxThreshold = 1f;

	public int maxShotOccurences;

	public int startAfterNumberOfOccurences;

	public bool onUnpack;

	public bool onShootWhileLocked;

	public bool onUnpackImmidiate;

	private int shotOccurences;

	public override void OnUnpackImmidiate(Vector3 b)
	{
		if (onUnpackImmidiate)
		{
			base.OnUnpackImmidiate(b);
			Event?.Invoke();
		}
	}

	public override void OnUnpack(Vector3 b)
	{
		if (onUnpack && isInRange(b))
		{
			base.OnUnpack(b);
			Event?.Invoke();
		}
	}

	public override void OnShootWrapped(Vector3 b)
	{
		if (onShootWhileLocked && isInRange(b))
		{
			base.OnShootWrapped(b);
			Event?.Invoke();
		}
	}

	public override void OnShootNotWrapped(Vector3 b)
	{
		shotOccurences++;
		if (!ExecuteOnShoot)
			return;

		int rel = shotOccurences - startAfterNumberOfOccurences;
		if (maxShotOccurences > 0 && rel > maxShotOccurences)
			return;
		if (startAfterNumberOfOccurences != 0 && shotOccurences <= startAfterNumberOfOccurences)
			return;

		if (isInRange(b))
		{
			base.OnShootNotWrapped(b);
			Event?.Invoke();
		}
	}

	public override void OnAimNotWrapped(Vector3 b)
	{
		if (ExecuteOnAim && isInRange(b))
		{
			base.OnAimNotWrapped(b);
			Event?.Invoke();
		}
	}

	private bool isInRange(Vector3 boost)
	{
		float m = boost.magnitude;
		return m >= minThreshold && m <= maxThreshold;
	}
}
