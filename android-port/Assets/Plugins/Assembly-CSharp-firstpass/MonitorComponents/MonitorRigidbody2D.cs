using UnityEngine;

namespace MonitorComponents
{
	[ExecuteInEditMode]
	public class MonitorRigidbody2D : MonoBehaviour
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

		public ValueAxisMode positionMode;

		public float positionMin;

		public float positionMax;

		public Monitor monitor_position;

		private MonitorInput monitorInput_position_x;

		private MonitorInput monitorInput_position_y;

		public bool showRotation;

		public bool rotationClamp;

		public ValueAxisMode rotationMode;

		public float rotationMin;

		public float rotationMax;

		public Monitor monitor_rotation;

		private MonitorInput monitorInput_rotation;

		public bool showVelocity;

		public bool showVelocity_x;

		public bool showVelocity_y;

		public ValueAxisMode velocityMode;

		public float velocityMin;

		public float velocityMax;

		public Monitor monitor_velocity;

		private MonitorInput monitorInput_velocity_x;

		private MonitorInput monitorInput_velocity_y;

		public bool showAngularVelocity;

		public ValueAxisMode angularVelocityMode;

		public float angularVelocityMin;

		public float angularVelocityMax;

		public Monitor monitor_angularVelocity;

		private MonitorInput monitorInput_angularVelocity;

		private bool missingRigidbodyWarning;

		private Rigidbody2D rigidbody2D;

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
