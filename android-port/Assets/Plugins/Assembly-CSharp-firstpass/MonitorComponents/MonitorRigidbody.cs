using UnityEngine;

namespace MonitorComponents
{
	[ExecuteInEditMode]
	public class MonitorRigidbody : MonoBehaviour
	{
		public enum SampleMode
		{
			Update = 0,
			FixedUpdate = 1
		}

		public SampleMode sampleMode;

		public bool showPosition;

		public bool showPosition_x;

		public bool showPosition_y;

		public bool showPosition_z;

		public ValueAxisMode positionMode;

		public float positionMin;

		public float positionMax;

		public Monitor monitor_position;

		private MonitorInput monitorInput_position_x;

		private MonitorInput monitorInput_position_y;

		private MonitorInput monitorInput_position_z;

		public bool showRotation;

		public bool showRotation_x;

		public bool showRotation_y;

		public bool showRotation_z;

		public ValueAxisMode rotationMode;

		public float rotationMin;

		public float rotationMax;

		public Monitor monitor_rotation;

		private MonitorInput monitorInput_rotation_x;

		private MonitorInput monitorInput_rotation_y;

		private MonitorInput monitorInput_rotation_z;

		public bool showVelocity;

		public bool showVelocity_x;

		public bool showVelocity_y;

		public bool showVelocity_z;

		public bool showVelocity_magnitude;

		public ValueAxisMode velocityMode;

		public float velocityMin;

		public float velocityMax;

		public Monitor monitor_velocity;

		private MonitorInput monitorInput_velocity_x;

		private MonitorInput monitorInput_velocity_y;

		private MonitorInput monitorInput_velocity_z;

		private MonitorInput monitorInput_velocity_magnitude;

		public bool showAngularVelocity;

		public bool showAngularVelocity_x;

		public bool showAngularVelocity_y;

		public bool showAngularVelocity_z;

		public bool showAngularVelocity_magnitude;

		public ValueAxisMode angularVelocityMode;

		public float angularVelocityMin;

		public float angularVelocityMax;

		public Monitor monitor_angularVelocity;

		private MonitorInput monitorInput_angularVelocity_x;

		private MonitorInput monitorInput_angularVelocity_y;

		private MonitorInput monitorInput_angularVelocity_z;

		private MonitorInput monitorInput_angularVelocity_magnitude;

		private bool missingRigidbodyWarning;

		private Rigidbody rigidbody;

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

		private void UpdateVelocityMonitor(bool componentIsActive)
		{
		}

		private void UpdateAngularVelocityMonitor(bool componentIsActive)
		{
		}

		public void FixedUpdate()
		{
		}

		public void Update()
		{
		}

		private void Sample()
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

		public void RemoveMonitors()
		{
		}
	}
}
