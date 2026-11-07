using Il2CppDummyDll;
using UnityEngine;

namespace MonitorComponents
{
	[Token(Token = "0x200026F")]
	[ExecuteInEditMode]
	public class MonitorRigidbody2D : MonoBehaviour
	{
		[Token(Token = "0x2000270")]
		public enum SampleMode
		{
			[Token(Token = "0x4001034")]
			Update = 0,
			[Token(Token = "0x4001035")]
			FixedUpdate = 1
		}

		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x18")]
		public SampleMode sampleMode;

		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x1C")]
		public bool showPosition;

		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x1D")]
		public bool showPosition_x;

		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x1E")]
		public bool showPosition_y;

		[Token(Token = "0x4001015")]
		[FieldOffset(Offset = "0x20")]
		public ValueAxisMode positionMode;

		[Token(Token = "0x4001016")]
		[FieldOffset(Offset = "0x24")]
		public float positionMin;

		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x28")]
		public float positionMax;

		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x30")]
		public Monitor monitor_position;

		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x38")]
		private MonitorInput monitorInput_position_x;

		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x40")]
		private MonitorInput monitorInput_position_y;

		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x48")]
		public bool showRotation;

		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x49")]
		public bool rotationClamp;

		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0x4C")]
		public ValueAxisMode rotationMode;

		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0x50")]
		public float rotationMin;

		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x54")]
		public float rotationMax;

		[Token(Token = "0x4001020")]
		[FieldOffset(Offset = "0x58")]
		public Monitor monitor_rotation;

		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x60")]
		private MonitorInput monitorInput_rotation;

		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0x68")]
		public bool showVelocity;

		[Token(Token = "0x4001023")]
		[FieldOffset(Offset = "0x69")]
		public bool showVelocity_x;

		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x6A")]
		public bool showVelocity_y;

		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x6C")]
		public ValueAxisMode velocityMode;

		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x70")]
		public float velocityMin;

		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x74")]
		public float velocityMax;

		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x78")]
		public Monitor monitor_velocity;

		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0x80")]
		private MonitorInput monitorInput_velocity_x;

		[Token(Token = "0x400102A")]
		[FieldOffset(Offset = "0x88")]
		private MonitorInput monitorInput_velocity_y;

		[Token(Token = "0x400102B")]
		[FieldOffset(Offset = "0x90")]
		public bool showAngularVelocity;

		[Token(Token = "0x400102C")]
		[FieldOffset(Offset = "0x94")]
		public ValueAxisMode angularVelocityMode;

		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x98")]
		public float angularVelocityMin;

		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x9C")]
		public float angularVelocityMax;

		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0xA0")]
		public Monitor monitor_angularVelocity;

		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0xA8")]
		private MonitorInput monitorInput_angularVelocity;

		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0xB0")]
		private bool missingRigidbodyWarning;

		[Token(Token = "0x4001032")]
		[FieldOffset(Offset = "0xB8")]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x6001022")]
		[Address(RVA = "0x13B2714", Offset = "0x13B2714", VA = "0x13B2714")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001023")]
		[Address(RVA = "0x13B279C", Offset = "0x13B279C", VA = "0x13B279C")]
		private void Start()
		{
		}

		[Token(Token = "0x6001024")]
		[Address(RVA = "0x13B28B4", Offset = "0x13B28B4", VA = "0x13B28B4")]
		public void UpdateMonitors()
		{
		}

		[Token(Token = "0x6001025")]
		[Address(RVA = "0x13B2930", Offset = "0x13B2930", VA = "0x13B2930")]
		private void UpdatePositionMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6001026")]
		[Address(RVA = "0x13B2C5C", Offset = "0x13B2C5C", VA = "0x13B2C5C")]
		private void UpdateRotationMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6001027")]
		[Address(RVA = "0x13B2E78", Offset = "0x13B2E78", VA = "0x13B2E78")]
		private void UpdateVelocityMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6001028")]
		[Address(RVA = "0x13B31A4", Offset = "0x13B31A4", VA = "0x13B31A4")]
		private void UpdateAngularVelocityMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6001029")]
		[Address(RVA = "0x13B33C8", Offset = "0x13B33C8", VA = "0x13B33C8")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x600102A")]
		[Address(RVA = "0x13B3694", Offset = "0x13B3694", VA = "0x13B3694")]
		public void Update()
		{
		}

		[Token(Token = "0x600102B")]
		[Address(RVA = "0x13B340C", Offset = "0x13B340C", VA = "0x13B340C")]
		private void Sample()
		{
		}

		[Token(Token = "0x600102C")]
		[Address(RVA = "0x13B36D4", Offset = "0x13B36D4", VA = "0x13B36D4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600102D")]
		[Address(RVA = "0x13B36D8", Offset = "0x13B36D8", VA = "0x13B36D8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600102E")]
		[Address(RVA = "0x13B36DC", Offset = "0x13B36DC", VA = "0x13B36DC")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600102F")]
		[Address(RVA = "0x13B36E0", Offset = "0x13B36E0", VA = "0x13B36E0")]
		public void RemoveMonitors()
		{
		}

		[Token(Token = "0x6001030")]
		[Address(RVA = "0x13B383C", Offset = "0x13B383C", VA = "0x13B383C")]
		public MonitorRigidbody2D()
		{
		}
	}
}
