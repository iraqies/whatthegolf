using UnityEngine;

namespace MonitorComponents
{
	[ExecuteInEditMode]
	public class MonitorTransform : MonoBehaviour
	{
		public enum Space
		{
			Local = 0,
			World = 1
		}

		public enum ScaleSpace
		{
			Local = 0,
			Lossy = 1
		}

		public bool showPosition;

		public bool showPosition_x;

		public bool showPosition_y;

		public bool showPosition_z;

		public Space positionSpace;

		public ValueAxisMode positionMode;

		public float positionMin;

		public float positionMax;

		public Monitor monitor_position;

		public MonitorInput monitorInput_position_x;

		public MonitorInput monitorInput_position_y;

		public MonitorInput monitorInput_position_z;

		public bool showRotation;

		public bool showRotation_x;

		public bool showRotation_y;

		public bool showRotation_z;

		public Space rotationSpace;

		public ValueAxisMode rotationMode;

		public float rotationMin;

		public float rotationMax;

		public Monitor monitor_rotation;

		public MonitorInput monitorInput_rotation_x;

		public MonitorInput monitorInput_rotation_y;

		public MonitorInput monitorInput_rotation_z;

		public bool showScale;

		public ScaleSpace scaleSpace;

		public bool showScale_x;

		public bool showScale_y;

		public bool showScale_z;

		public ValueAxisMode scaleMode;

		public float scaleMin;

		public float scaleMax;

		public Monitor monitor_scale;

		public MonitorInput monitorInput_scale_x;

		public MonitorInput monitorInput_scale_y;

		public MonitorInput monitorInput_scale_z;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void UpdateMonitors()
		{
		}

		private void UpdatePositionMonitor(bool componentIsActive)
		{
		}

		private void UpdateRotationMonitor(bool componentIsActive)
		{
		}

		private void UpdateScaleMonitor(bool componentIsActive)
		{
		}

		public void Update()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnDestroy()
		{
		}

		private void RemoveMonitors()
		{
		}
	}
}
