using UnityEngine;

public class LevelGate : MonoBehaviour
{
	public float OpenY = 5f;

	public float CloseY;

	public float Speed = 5f;

	public bool IsOpen;

	public int RequriedTurnOns = 1;

	private float targetY;

	private Rigidbody rigid;

	private int currentOns;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		targetY = IsOpen ? OpenY : CloseY;
	}

	public void Toggle()
	{
		IsOpen = !IsOpen;
		targetY = IsOpen ? OpenY : CloseY;
	}

	public void TurnOn()
	{
		currentOns++;
		if (currentOns >= RequriedTurnOns)
		{
			IsOpen = true;
			targetY = OpenY;
		}
	}

	public void TurnOff()
	{
		currentOns--;
		if (currentOns < RequriedTurnOns)
		{
			IsOpen = false;
			targetY = CloseY;
		}
	}

	private void Update()
	{
		Vector3 pos = transform.position;
		if (Mathf.Abs(pos.y - targetY) > 0.001f)
		{
			pos.y = Mathf.MoveTowards(pos.y, targetY, Time.deltaTime * Speed);
			if (rigid != null)
			{
				rigid.MovePosition(pos);
			}
			else
			{
				transform.position = pos;
			}
		}
	}
}
