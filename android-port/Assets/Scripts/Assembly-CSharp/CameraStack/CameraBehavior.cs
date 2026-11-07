using System;
using Cinemachine;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001113")]
	public abstract class CameraBehavior : MonoBehaviour
	{
		[Token(Token = "0x4005A66")]
		[FieldOffset(Offset = "0x18")]
		public string PlatformName;

		[NonSerialized]
		[Token(Token = "0x4005A67")]
		[FieldOffset(Offset = "0x20")]
		public Camera[] cameras;

		[Token(Token = "0x4005A68")]
		[FieldOffset(Offset = "0x28")]
		public bool IsAttachedToCameraManager;

		[Token(Token = "0x4005A69")]
		[FieldOffset(Offset = "0x30")]
		private CinemachineVirtualCamera[] virtualCameras;

		[Token(Token = "0x1700081B")]
		public Camera[] Cameras
		{
			[Token(Token = "0x6004CBF")]
			[Address(RVA = "0x17DA480", Offset = "0x17DA480", VA = "0x17DA480")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CC0")]
			[Address(RVA = "0x17E42D4", Offset = "0x17E42D4", VA = "0x17E42D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700081C")]
		public CinemachineVirtualCamera[] VirtualCameras
		{
			[Token(Token = "0x6004CC1")]
			[Address(RVA = "0x17E42DC", Offset = "0x17E42DC", VA = "0x17E42DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CC2")]
			[Address(RVA = "0x17E4380", Offset = "0x17E4380", VA = "0x17E4380")]
			set
			{
			}
		}

		[Token(Token = "0x1700081D")]
		protected GolfBallController Ball
		{
			[Token(Token = "0x6004CC4")]
			[Address(RVA = "0x17DAC18", Offset = "0x17DAC18", VA = "0x17DAC18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700081E")]
		public Vector3 Position
		{
			[Token(Token = "0x6004CC5")]
			[Address(RVA = "0x17DA858", Offset = "0x17DA858", VA = "0x17DA858")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700081F")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6004CC6")]
			[Address(RVA = "0x17E4390", Offset = "0x17E4390", VA = "0x17E4390")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004CC3")]
		[Address(RVA = "0x17E4388", Offset = "0x17E4388", VA = "0x17E4388")]
		public void ResetCameras()
		{
		}

		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0x17E439C", Offset = "0x17E439C", VA = "0x17E439C", Slot = "4")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0x17E43A0", Offset = "0x17E43A0", VA = "0x17E43A0", Slot = "5")]
		public virtual void Cleanup()
		{
		}

		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0x17E0048", Offset = "0x17E0048", VA = "0x17E0048", Slot = "6")]
		public virtual void PreUpdate()
		{
		}

		[Token(Token = "0x6004CCA")]
		public abstract Quaternion CalculateRotation();

		[Token(Token = "0x6004CCB")]
		protected abstract Vector3 CalculatePosition();

		[Token(Token = "0x6004CCC")]
		[Address(RVA = "0x17DA568", Offset = "0x17DA568", VA = "0x17DA568", Slot = "9")]
		public virtual void OutOfBounds()
		{
		}

		[Token(Token = "0x6004CCD")]
		[Address(RVA = "0x17E43A4", Offset = "0x17E43A4", VA = "0x17E43A4", Slot = "10")]
		public virtual void GoalComplete()
		{
		}

		[Token(Token = "0x6004CCE")]
		[Address(RVA = "0x17DBD64", Offset = "0x17DBD64", VA = "0x17DBD64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004CCF")]
		[Address(RVA = "0x17E43A8", Offset = "0x17E43A8", VA = "0x17E43A8")]
		protected CameraBehavior()
		{
		}
	}
}
