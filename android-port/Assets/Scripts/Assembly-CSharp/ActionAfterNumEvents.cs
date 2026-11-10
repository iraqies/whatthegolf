using UnityEngine;
using UnityEngine.Events;

public class ActionAfterNumEvents : MonoBehaviour
{
	[SerializeField]
	private int NumTicks = 1;

	[SerializeField]
	private UnityEvent m_Event;

	private int ticks;

	public float Progress()
	{
		if (NumTicks <= 0)
		{
			return 1f;
		}
		return Mathf.Clamp01((float)ticks / NumTicks);
	}

	public int TotalTicks()
	{
		return NumTicks;
	}

	public void Tick()
	{
		ticks++;
		if (ticks >= Mathf.Max(1, NumTicks))
		{
			m_Event?.Invoke();
		}
	}
}
