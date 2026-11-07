using Rewired.Platforms.Switch;
using UnityEngine;

public class GyroController : MonoBehaviour
{
	public bool isUpdatingGyro;

	private Transform gyroTransform;

	private Transform gyroLateTransform;

	private Quaternion startOffset;

	private Vector3 lastForwrd;

	private Vector3 offset;

	private bool didInit;

	private static GyroController instance;

	private Quaternion lastAttitude;

	private float lastUpdate;

	private Vector3 tmpVel;

	private static NintendoSwitchInputManager nintendoSwitchInputManager;

	public static GyroController Instance => null;

	public bool IsGyroEnabled()
	{
		return false;
	}

	public bool IsGyroUsable()
	{
		return false;
	}

	public Vector3 GetOffset()
	{
		return default;
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void Init()
	{
	}

	public Transform GetGyroTransform()
	{
		return null;
	}

	public Quaternion GetGyroAttitude()
	{
		return default;
	}

	private Quaternion GetSwitchGyro()
	{
		return default;
	}

	private bool UpdateGyro()
	{
		return false;
	}

	public void Update()
	{
	}
}
