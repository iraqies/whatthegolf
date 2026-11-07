using UnityEngine;
using UnityEngine.Events;

public class ActionAfterNumEvents : MonoBehaviour
{
	[SerializeField]
	private int NumTicks;

	[SerializeField]
	private UnityEvent m_Event;

	private int ticks;

	public float Progress()
	{
		return 0f;
	}

	public int TotalTicks()
	{
		return 0;
	}

	public void Tick()
	{
	}
}
