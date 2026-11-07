using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000052")]
	public class CinemachineTransposer : CinemachineComponentBase
	{
		[Token(Token = "0x2000053")]
		public enum BindingMode
		{
			[Token(Token = "0x40001E6")]
			LockToTargetOnAssign = 0,
			[Token(Token = "0x40001E7")]
			LockToTargetWithWorldUp = 1,
			[Token(Token = "0x40001E8")]
			LockToTargetNoRoll = 2,
			[Token(Token = "0x40001E9")]
			LockToTarget = 3,
			[Token(Token = "0x40001EA")]
			WorldSpace = 4,
			[Token(Token = "0x40001EB")]
			SimpleFollowWithWorldUp = 5
		}

		[Token(Token = "0x2000054")]
		public enum AngularDampingMode
		{
			[Token(Token = "0x40001ED")]
			Euler = 0,
			[Token(Token = "0x40001EE")]
			Quaternion = 1
		}

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x50")]
		public BindingMode m_BindingMode;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 m_FollowOffset;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78EA0", Offset = "0x78EA0")]
		public float m_XDamping;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78EB8", Offset = "0x78EB8")]
		public float m_YDamping;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78ED0", Offset = "0x78ED0")]
		public float m_ZDamping;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x6C")]
		public AngularDampingMode m_AngularDampingMode;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78EE8", Offset = "0x78EE8")]
		public float m_PitchDamping;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78F00", Offset = "0x78F00")]
		public float m_YawDamping;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78F18", Offset = "0x78F18")]
		public float m_RollDamping;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78F30", Offset = "0x78F30")]
		public float m_AngularDamping;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78F48", Offset = "0x78F48")]
		private bool HideOffsetInInspector__BackingField;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 m_PreviousTargetPosition;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x90")]
		private Quaternion m_PreviousReferenceOrientation;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0xA0")]
		private Quaternion m_targetOrientationOnAssign;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0xB0")]
		private Transform m_previousTarget;

		[Token(Token = "0x17000066")]
		public bool HideOffsetInInspector
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1904B20", Offset = "0x1904B20", VA = "0x1904B20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79738", Offset = "0x79738")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x1904B28", Offset = "0x1904B28", VA = "0x1904B28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79748", Offset = "0x79748")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public Vector3 EffectiveOffset
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x1904AF8", Offset = "0x1904AF8", VA = "0x1904AF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000068")]
		public override bool IsValid
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x1904B30", Offset = "0x1904B30", VA = "0x1904B30", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000069")]
		public override CinemachineCore.Stage Stage
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x1904BC8", Offset = "0x1904BC8", VA = "0x1904BC8", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006A")]
		protected Vector3 Damping
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x190575C", Offset = "0x190575C", VA = "0x190575C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006B")]
		protected Vector3 AngularDamping
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x190568C", Offset = "0x190568C", VA = "0x190568C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1904AC8", Offset = "0x1904AC8", VA = "0x1904AC8", Slot = "10")]
		protected virtual void OnValidate()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1904BD0", Offset = "0x1904BD0", VA = "0x1904BD0", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1905314", Offset = "0x1905314", VA = "0x1905314", Slot = "9")]
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1904D10", Offset = "0x1904D10", VA = "0x1904D10")]
		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1904E88", Offset = "0x1904E88", VA = "0x1904E88")]
		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1905778", Offset = "0x1905778", VA = "0x1905778", Slot = "11")]
		public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp)
		{
			return default;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x19053F4", Offset = "0x19053F4", VA = "0x19053F4")]
		public Quaternion GetReferenceOrientation(Vector3 worldUp)
		{
			return default;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1905878", Offset = "0x1905878", VA = "0x1905878")]
		public CinemachineTransposer()
		{
		}
	}
}
