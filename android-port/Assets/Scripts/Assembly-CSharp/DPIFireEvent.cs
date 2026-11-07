using UnityEngine;
using UnityEngine.Events;

public class DPIFireEvent : BaseDailyPrizeInteractions
{
	public UnityEvent Event;

	public float minThreshold;

	public float maxThreshold;

	public int maxShotOccurences;

	public int startAfterNumberOfOccurences;

	public bool onUnpack;

	public bool onShootWhileLocked;

	public bool onUnpackImmidiate;

	private int shotOccurences;

	public override void OnUnpackImmidiate(Vector3 b)
	{
	}

	public override void OnUnpack(Vector3 b)
	{
	}

	public override void OnShootWrapped(Vector3 b)
	{
	}

	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	public override void OnAimNotWrapped(Vector3 b)
	{
	}

	private bool isInRange(Vector3 boost)
	{
		return false;
	}
}
