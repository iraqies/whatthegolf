using Il2CppDummyDll;
using UnityEngine;

namespace MonitorComponents
{
	[Token(Token = "0x200026D")]
	[ExecuteInEditMode]
	public class MonitorRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200026E")]
		public enum SampleMode
		{
			[Token(Token = "0x400100F")]
			Update = 0,
			[Token(Token = "0x4001010")]
			FixedUpdate = 1
		}

		[Token(Token = "0x4000FDB")]
		[FieldOffset(Offset = "0x18")]
		public SampleMode sampleMode;

		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0x1C")]
		public bool showPosition;

		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x1D")]
		public bool showPosition_x;

		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x1E")]
		public bool showPosition_y;

		[Token(Token = "0x4000FDF")]
		[FieldOffset(Offset = "0x1F")]
		public bool showPosition_z;

		[Token(Token = "0x4000FE0")]
		[FieldOffset(Offset = "0x20")]
		public ValueAxisMode positionMode;

		[Token(Token = "0x4000FE1")]
		[FieldOffset(Offset = "0x24")]
		public float positionMin;

		[Token(Token = "0x4000FE2")]
		[FieldOffset(Offset = "0x28")]
		public float positionMax;

		[Token(Token = "0x4000FE3")]
		[FieldOffset(Offset = "0x30")]
		public Monitor monitor_position;

		[Token(Token = "0x4000FE4")]
		[FieldOffset(Offset = "0x38")]
		private MonitorInput monitorInput_position_x;

		[Token(Token = "0x4000FE5")]
		[FieldOffset(Offset = "0x40")]
		private MonitorInput monitorInput_position_y;

		[Token(Token = "0x4000FE6")]
		[FieldOffset(Offset = "0x48")]
		private MonitorInput monitorInput_position_z;

		[Token(Token = "0x4000FE7")]
		[FieldOffset(Offset = "0x50")]
		public bool showRotation;

		[Token(Token = "0x4000FE8")]
		[FieldOffset(Offset = "0x51")]
		public bool showRotation_x;

		[Token(Token = "0x4000FE9")]
		[FieldOffset(Offset = "0x52")]
		public bool showRotation_y;

		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0x53")]
		public bool showRotation_z;

		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0x54")]
		public ValueAxisMode rotationMode;

		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0x58")]
		public float rotationMin;

		[Token(Token = "0x4000FED")]
		[FieldOffset(Offset = "0x5C")]
		public float rotationMax;

		[Token(Token = "0x4000FEE")]
		[FieldOffset(Offset = "0x60")]
		public Monitor monitor_rotation;

		[Token(Token = "0x4000FEF")]
		[FieldOffset(Offset = "0x68")]
		private MonitorInput monitorInput_rotation_x;

		[Token(Token = "0x4000FF0")]
		[FieldOffset(Offset = "0x70")]
		private MonitorInput monitorInput_rotation_y;

		[Token(Token = "0x4000FF1")]
		[FieldOffset(Offset = "0x78")]
		private MonitorInput monitorInput_rotation_z;

		[Token(Token = "0x4000FF2")]
		[FieldOffset(Offset = "0x80")]
		public bool showVelocity;

		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0x81")]
		public bool showVelocity_x;

		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x82")]
		public bool showVelocity_y;

		[Token(Token = "0x4000FF5")]
		[FieldOffset(Offset = "0x83")]
		public bool showVelocity_z;

		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x84")]
		public bool showVelocity_magnitude;

		[Token(Token = "0x4000FF7")]
		[FieldOffset(Offset = "0x88")]
		public ValueAxisMode velocityMode;

		[Token(Token = "0x4000FF8")]
		[FieldOffset(Offset = "0x8C")]
		public float velocityMin;

		[Token(Token = "0x4000FF9")]
		[FieldOffset(Offset = "0x90")]
		public float velocityMax;

		[Token(Token = "0x4000FFA")]
		[FieldOffset(Offset = "0x98")]
		public Monitor monitor_velocity;

		[Token(Token = "0x4000FFB")]
		[FieldOffset(Offset = "0xA0")]
		private MonitorInput monitorInput_velocity_x;

		[Token(Token = "0x4000FFC")]
		[FieldOffset(Offset = "0xA8")]
		private MonitorInput monitorInput_velocity_y;

		[Token(Token = "0x4000FFD")]
		[FieldOffset(Offset = "0xB0")]
		private MonitorInput monitorInput_velocity_z;

		[Token(Token = "0x4000FFE")]
		[FieldOffset(Offset = "0xB8")]
		private MonitorInput monitorInput_velocity_magnitude;

		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0xC0")]
		public bool showAngularVelocity;

		[Token(Token = "0x4001000")]
		[FieldOffset(Offset = "0xC1")]
		public bool showAngularVelocity_x;

		[Token(Token = "0x4001001")]
		[FieldOffset(Offset = "0xC2")]
		public bool showAngularVelocity_y;

		[Token(Token = "0x4001002")]
		[FieldOffset(Offset = "0xC3")]
		public bool showAngularVelocity_z;

		[Token(Token = "0x4001003")]
		[FieldOffset(Offset = "0xC4")]
		public bool showAngularVelocity_magnitude;

		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0xC8")]
		public ValueAxisMode angularVelocityMode;

		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0xCC")]
		public float angularVelocityMin;

		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0xD0")]
		public float angularVelocityMax;

		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0xD8")]
		public Monitor monitor_angularVelocity;

		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0xE0")]
		private MonitorInput monitorInput_angularVelocity_x;

		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0xE8")]
		private MonitorInput monitorInput_angularVelocity_y;

		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0xF0")]
		private MonitorInput monitorInput_angularVelocity_z;

		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0xF8")]
		private MonitorInput monitorInput_angularVelocity_magnitude;

		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0x100")]
		private bool missingRigidbodyWarning;

		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0x108")]
		private Rigidbody rigidbody;

		[Token(Token = "0x6001013")]
		[Address(RVA = "0x13B0CC0", Offset = "0x13B0CC0", VA = "0x13B0CC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001014")]
		[Address(RVA = "0x13B0D48", Offset = "0x13B0D48", VA = "0x13B0D48")]
		private void Start()
		{
		}

		[Token(Token = "0x6001015")]
		[Address(RVA = "0x13B0E60", Offset = "0x13B0E60", VA = "0x13B0E60")]
		public void UpdateMonitors()
		{
		}

		[Token(Token = "0x6001016")]
		[Address(RVA = "0x13B0EDC", Offset = "0x13B0EDC", VA = "0x13B0EDC")]
		private void UpdatePositionMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6001017")]
		[Address(RVA = "0x13B12FC", Offset = "0x13B12FC", VA = "0x13B12FC")]
		private void UpdateRotationMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6001018")]
		[Address(RVA = "0x13B171C", Offset = "0x13B171C", VA = "0x13B171C")]
		private void UpdateVelocityMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6001019")]
		[Address(RVA = "0x13B1C30", Offset = "0x13B1C30", VA = "0x13B1C30")]
		private void UpdateAngularVelocityMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x600101A")]
		[Address(RVA = "0x13B2144", Offset = "0x13B2144", VA = "0x13B2144")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x600101B")]
		[Address(RVA = "0x13B250C", Offset = "0x13B250C", VA = "0x13B250C")]
		public void Update()
		{
		}

		[Token(Token = "0x600101C")]
		[Address(RVA = "0x13B2188", Offset = "0x13B2188", VA = "0x13B2188")]
		private void Sample()
		{
		}

		[Token(Token = "0x600101D")]
		[Address(RVA = "0x13B254C", Offset = "0x13B254C", VA = "0x13B254C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600101E")]
		[Address(RVA = "0x13B2550", Offset = "0x13B2550", VA = "0x13B2550")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600101F")]
		[Address(RVA = "0x13B2554", Offset = "0x13B2554", VA = "0x13B2554")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6001020")]
		[Address(RVA = "0x13B2558", Offset = "0x13B2558", VA = "0x13B2558")]
		public void RemoveMonitors()
		{
		}

		[Token(Token = "0x6001021")]
		[Address(RVA = "0x13B26B4", Offset = "0x13B26B4", VA = "0x13B26B4")]
		public MonitorRigidbody()
		{
		}
	}
}
