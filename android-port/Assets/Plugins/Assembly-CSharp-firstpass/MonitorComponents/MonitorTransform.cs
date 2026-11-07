using Il2CppDummyDll;
using UnityEngine;

namespace MonitorComponents
{
	[Token(Token = "0x2000271")]
	[ExecuteInEditMode]
	public class MonitorTransform : MonoBehaviour
	{
		[Token(Token = "0x2000272")]
		public enum Space
		{
			[Token(Token = "0x400105B")]
			Local = 0,
			[Token(Token = "0x400105C")]
			World = 1
		}

		[Token(Token = "0x2000273")]
		public enum ScaleSpace
		{
			[Token(Token = "0x400105E")]
			Local = 0,
			[Token(Token = "0x400105F")]
			Lossy = 1
		}

		[Token(Token = "0x4001036")]
		[FieldOffset(Offset = "0x18")]
		public bool showPosition;

		[Token(Token = "0x4001037")]
		[FieldOffset(Offset = "0x19")]
		public bool showPosition_x;

		[Token(Token = "0x4001038")]
		[FieldOffset(Offset = "0x1A")]
		public bool showPosition_y;

		[Token(Token = "0x4001039")]
		[FieldOffset(Offset = "0x1B")]
		public bool showPosition_z;

		[Token(Token = "0x400103A")]
		[FieldOffset(Offset = "0x1C")]
		public Space positionSpace;

		[Token(Token = "0x400103B")]
		[FieldOffset(Offset = "0x20")]
		public ValueAxisMode positionMode;

		[Token(Token = "0x400103C")]
		[FieldOffset(Offset = "0x24")]
		public float positionMin;

		[Token(Token = "0x400103D")]
		[FieldOffset(Offset = "0x28")]
		public float positionMax;

		[Token(Token = "0x400103E")]
		[FieldOffset(Offset = "0x30")]
		public Monitor monitor_position;

		[Token(Token = "0x400103F")]
		[FieldOffset(Offset = "0x38")]
		public MonitorInput monitorInput_position_x;

		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x40")]
		public MonitorInput monitorInput_position_y;

		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x48")]
		public MonitorInput monitorInput_position_z;

		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x50")]
		public bool showRotation;

		[Token(Token = "0x4001043")]
		[FieldOffset(Offset = "0x51")]
		public bool showRotation_x;

		[Token(Token = "0x4001044")]
		[FieldOffset(Offset = "0x52")]
		public bool showRotation_y;

		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x53")]
		public bool showRotation_z;

		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x54")]
		public Space rotationSpace;

		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x58")]
		public ValueAxisMode rotationMode;

		[Token(Token = "0x4001048")]
		[FieldOffset(Offset = "0x5C")]
		public float rotationMin;

		[Token(Token = "0x4001049")]
		[FieldOffset(Offset = "0x60")]
		public float rotationMax;

		[Token(Token = "0x400104A")]
		[FieldOffset(Offset = "0x68")]
		public Monitor monitor_rotation;

		[Token(Token = "0x400104B")]
		[FieldOffset(Offset = "0x70")]
		public MonitorInput monitorInput_rotation_x;

		[Token(Token = "0x400104C")]
		[FieldOffset(Offset = "0x78")]
		public MonitorInput monitorInput_rotation_y;

		[Token(Token = "0x400104D")]
		[FieldOffset(Offset = "0x80")]
		public MonitorInput monitorInput_rotation_z;

		[Token(Token = "0x400104E")]
		[FieldOffset(Offset = "0x88")]
		public bool showScale;

		[Token(Token = "0x400104F")]
		[FieldOffset(Offset = "0x8C")]
		public ScaleSpace scaleSpace;

		[Token(Token = "0x4001050")]
		[FieldOffset(Offset = "0x90")]
		public bool showScale_x;

		[Token(Token = "0x4001051")]
		[FieldOffset(Offset = "0x91")]
		public bool showScale_y;

		[Token(Token = "0x4001052")]
		[FieldOffset(Offset = "0x92")]
		public bool showScale_z;

		[Token(Token = "0x4001053")]
		[FieldOffset(Offset = "0x94")]
		public ValueAxisMode scaleMode;

		[Token(Token = "0x4001054")]
		[FieldOffset(Offset = "0x98")]
		public float scaleMin;

		[Token(Token = "0x4001055")]
		[FieldOffset(Offset = "0x9C")]
		public float scaleMax;

		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0xA0")]
		public Monitor monitor_scale;

		[Token(Token = "0x4001057")]
		[FieldOffset(Offset = "0xA8")]
		public MonitorInput monitorInput_scale_x;

		[Token(Token = "0x4001058")]
		[FieldOffset(Offset = "0xB0")]
		public MonitorInput monitorInput_scale_y;

		[Token(Token = "0x4001059")]
		[FieldOffset(Offset = "0xB8")]
		public MonitorInput monitorInput_scale_z;

		[Token(Token = "0x6001031")]
		[Address(RVA = "0x13B388C", Offset = "0x13B388C", VA = "0x13B388C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001032")]
		[Address(RVA = "0x13B3914", Offset = "0x13B3914", VA = "0x13B3914")]
		private void Start()
		{
		}

		[Token(Token = "0x6001033")]
		[Address(RVA = "0x13B3918", Offset = "0x13B3918", VA = "0x13B3918")]
		public void UpdateMonitors()
		{
		}

		[Token(Token = "0x6001034")]
		[Address(RVA = "0x13B3988", Offset = "0x13B3988", VA = "0x13B3988")]
		private void UpdatePositionMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6001035")]
		[Address(RVA = "0x13B3E24", Offset = "0x13B3E24", VA = "0x13B3E24")]
		private void UpdateRotationMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6001036")]
		[Address(RVA = "0x13B42C0", Offset = "0x13B42C0", VA = "0x13B42C0")]
		private void UpdateScaleMonitor(bool componentIsActive)
		{
		}

		[Token(Token = "0x6001037")]
		[Address(RVA = "0x13B475C", Offset = "0x13B475C", VA = "0x13B475C")]
		public void Update()
		{
		}

		[Token(Token = "0x6001038")]
		[Address(RVA = "0x13B499C", Offset = "0x13B499C", VA = "0x13B499C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6001039")]
		[Address(RVA = "0x13B49A0", Offset = "0x13B49A0", VA = "0x13B49A0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600103A")]
		[Address(RVA = "0x13B49A4", Offset = "0x13B49A4", VA = "0x13B49A4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600103B")]
		[Address(RVA = "0x13B49A8", Offset = "0x13B49A8", VA = "0x13B49A8")]
		private void RemoveMonitors()
		{
		}

		[Token(Token = "0x600103C")]
		[Address(RVA = "0x13B4ABC", Offset = "0x13B4ABC", VA = "0x13B4ABC")]
		public MonitorTransform()
		{
		}
	}
}
