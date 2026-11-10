using Rewired;
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

	public static GyroController Instance
	{
		get
		{
			if (instance == null)
			{
				GameObject go = new GameObject("GyroController");
				go.transform.SetParent(null);
				instance = go.AddComponent<GyroController>();
				instance.Init();
			}
			return instance;
		}
	}

	public bool IsGyroEnabled()
	{
		return Input.gyro.enabled;
	}

	public bool IsGyroUsable()
	{
		return SystemInfo.supportsGyroscope;
	}

	public Vector3 GetOffset()
	{
		if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().platform == 0)
		{
			return new Vector3(offset.y, offset.x, offset.z);
		}
		return offset;
	}

	private void OnApplicationPause(bool pause)
	{
		if (!pause && gyroTransform != null && gyroLateTransform != null)
		{
			gyroLateTransform.forward = gyroTransform.forward;
			offset = Vector3.zero;
			UpdateGyro();
		}
	}

	private void Init()
	{
		Object.DontDestroyOnLoad(base.gameObject);
		base.transform.SetParent(null, true);
		startOffset = Quaternion.identity;
		_ = Input.gyro.enabled;
		gyroTransform = new GameObject("Gyro").transform;
		gyroTransform.SetParent(base.transform, true);
		gyroLateTransform = new GameObject("GyroLate").transform;
		gyroLateTransform.SetParent(base.transform, true);
		GyroHelper.InitGyro();
		didInit = true;
	}

	public Transform GetGyroTransform()
	{
		return gyroTransform;
	}

	public Quaternion GetGyroAttitude()
	{
		return Input.gyro.attitude;
	}

	private Quaternion GetSwitchGyro()
	{
		return Quaternion.identity;
	}

	private bool UpdateGyro()
	{
		if (!didInit || !SystemInfo.supportsGyroscope)
			return false;

		GyroHelper.UpdateEditorRemoteGyroState();
		Quaternion attitude = Input.gyro.attitude;
		if (attitude == lastAttitude)
			return false;

		if (gyroTransform != null)
		{
			gyroTransform.localRotation = attitude;
		}
		lastAttitude = attitude;

		bool useRot = PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useRotatedOverworldAndCameraInLevels;
		if (gyroTransform != null)
		{
			if (useRot)
			{
				gyroTransform.transform.Rotate(0f, 0f, 180f, Space.Self);
				gyroTransform.transform.Rotate(90f, 180f, 0f, Space.World);
			}
			else
			{
				gyroTransform.transform.Rotate(-90f, 0f, 180f, Space.Self);
				gyroTransform.transform.Rotate(0f, 180f, 0f, Space.World);
				Vector3 euler = gyroTransform.transform.eulerAngles;
				gyroTransform.transform.rotation = Quaternion.Euler(-euler.x, euler.y, -euler.z);
			}
			gyroTransform.transform.Rotate(0f, -startOffset.eulerAngles.y, 0f, Space.World);
		}
		return true;
	}

	public void Update()
	{
		if (!didInit)
			return;

		UpdateGyro();
		if (gyroLateTransform != null && gyroTransform != null)
		{
			gyroLateTransform.forward = Vector3.SmoothDamp(gyroLateTransform.forward, gyroTransform.forward, ref tmpVel, 3f);
			offset = gyroLateTransform.forward - gyroTransform.forward;
		}
	}
}
