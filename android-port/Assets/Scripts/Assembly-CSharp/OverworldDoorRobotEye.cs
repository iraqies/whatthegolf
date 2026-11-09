using UnityEngine;

public class OverworldDoorRobotEye : MonoBehaviour
{
	public OverworldMainDoorPlate plate;

	public GameObject closed;

	public GameObject open;

	private Vector3 basePosition;

	private void Awake()
	{
		if (open != null)
			basePosition = open.transform.localPosition;
		if (plate != null)
		{
			plate.OnStateChange -= Plate_OnStateChange;
			plate.OnStateChange += Plate_OnStateChange;
		}
		UpdateState();
	}

	private void Plate_OnStateChange(bool isOn, bool isLoad)
	{
		UpdateState();
	}

	private void Plate_OnStateChange(bool isOn)
	{
		UpdateState();
	}

	private void UpdateState()
	{
		bool isOn = plate == null || plate.isOn;
		if (closed != null) closed.SetActive(!isOn);
		if (open != null) open.SetActive(isOn);
	}

	private void Update()
	{
		if (open != null && open.activeSelf && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			Vector3 dir = OverworldBallManager.Instance.Ball.transform.position - transform.position;
			dir.z = 0f;
			if (dir.sqrMagnitude > 0.01f)
			{
				open.transform.localPosition = basePosition + dir.normalized * 0.06f;
			}
		}
	}
}
