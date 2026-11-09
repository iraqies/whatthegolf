using UnityEngine;

public class MenuGoalPin : MonoBehaviour
{
	public GameObject next;

	private Vector3 nextStart;

	private GolfGoal pin;

	private bool didEnable;

	private void Start()
	{
		pin = GetComponent<GolfGoal>() ?? GetComponentInChildren<GolfGoal>();
		if (pin != null)
		{
			pin.OnGoal -= Pin_OnGoal;
			pin.OnGoal += Pin_OnGoal;
		}
		if (next != null)
		{
			nextStart = next.transform.position;
			next.SetActive(false);
		}
	}

	private void Pin_OnGoal(string obj)
	{
		if (didEnable || next == null) return;
		didEnable = true;
		next.transform.position = nextStart;
		next.SetActive(true);
	}
}
