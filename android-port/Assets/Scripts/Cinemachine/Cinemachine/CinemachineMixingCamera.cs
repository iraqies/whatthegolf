using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000024")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class CinemachineMixingCamera : CinemachineVirtualCameraBase
	{
		[Token(Token = "0x40000BA")]
		public const int MaxCameras = 8;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x5C")]
		public float m_Weight0;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x60")]
		public float m_Weight1;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x64")]
		public float m_Weight2;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x68")]
		public float m_Weight3;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x6C")]
		public float m_Weight4;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x70")]
		public float m_Weight5;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x74")]
		public float m_Weight6;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x78")]
		public float m_Weight7;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x80")]
		private CameraState m_State;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x160")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78670", Offset = "0x78670")]
		private ICinemachineCamera LiveChild__BackingField;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x168")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78680", Offset = "0x78680")]
		private Transform LookAt__BackingField;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x170")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78690", Offset = "0x78690")]
		private Transform Follow__BackingField;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x178")]
		private CinemachineVirtualCameraBase[] m_ChildCameras;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x180")]
		private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap;

		[Token(Token = "0x17000028")]
		private ICinemachineCamera LiveChild
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x18F9FAC", Offset = "0x18F9FAC", VA = "0x18F9FAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79538", Offset = "0x79538")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x18F9FA4", Offset = "0x18F9FA4", VA = "0x18F9FA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79528", Offset = "0x79528")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public override CameraState State
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x18F9FB4", Offset = "0x18F9FB4", VA = "0x18F9FB4", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002A")]
		public override Transform LookAt
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x18F9FF0", Offset = "0x18F9FF0", VA = "0x18F9FF0", Slot = "21")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79548", Offset = "0x79548")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x18F9FF8", Offset = "0x18F9FF8", VA = "0x18F9FF8", Slot = "22")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79558", Offset = "0x79558")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public override Transform Follow
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x18FA000", Offset = "0x18FA000", VA = "0x18FA000", Slot = "23")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79568", Offset = "0x79568")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x18FA008", Offset = "0x18FA008", VA = "0x18FA008", Slot = "24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79578", Offset = "0x79578")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public CinemachineVirtualCameraBase[] ChildCameras
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x18FA25C", Offset = "0x18FA25C", VA = "0x18FA25C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x18F97E0", Offset = "0x18F97E0", VA = "0x18F97E0")]
		public float GetWeight(int index)
		{
			return default;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x18F991C", Offset = "0x18F991C", VA = "0x18F991C")]
		public void SetWeight(int index, float w)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x18F9A60", Offset = "0x18F9A60", VA = "0x18F9A60")]
		public float GetWeight(CinemachineVirtualCameraBase vcam)
		{
			return default;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x18F9E20", Offset = "0x18F9E20", VA = "0x18F9E20")]
		public void SetWeight(CinemachineVirtualCameraBase vcam, float w)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x18FA010", Offset = "0x18FA010", VA = "0x18FA010", Slot = "35")]
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x18FA0E4", Offset = "0x18FA0E4", VA = "0x18FA0E4", Slot = "32")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x18FA11C", Offset = "0x18FA11C", VA = "0x18FA11C")]
		public void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x18FA128", Offset = "0x18FA128", VA = "0x18FA128", Slot = "31")]
		protected override void OnValidate()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x18FA184", Offset = "0x18FA184", VA = "0x18FA184", Slot = "20")]
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x18FA110", Offset = "0x18FA110", VA = "0x18FA110")]
		protected void InvalidateListOfChildren()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x18F9BD8", Offset = "0x18F9BD8", VA = "0x18F9BD8")]
		protected void ValidateListOfChildren()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x18FA280", Offset = "0x18FA280", VA = "0x18FA280", Slot = "28")]
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x18FA3D0", Offset = "0x18FA3D0", VA = "0x18FA3D0", Slot = "27")]
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x18FA6C4", Offset = "0x18FA6C4", VA = "0x18FA6C4")]
		public CinemachineMixingCamera()
		{
		}
	}
}
