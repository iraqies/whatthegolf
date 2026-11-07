using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Cameras
{
	[Token(Token = "0x20012D5")]
	[Attribute(Name = "RequireComponent", RVA = "0x48A08", Offset = "0x48A08")]
	public sealed class BasicCameraController : BaseCameraController
	{
		[Token(Token = "0x4006579")]
		[FieldOffset(Offset = "0x18")]
		private CinemachineVirtualCamera m_VirtualCamera;

		[Token(Token = "0x17000A00")]
		public override CinemachineVirtualCamera virtualCamera
		{
			[Token(Token = "0x6005758")]
			[Address(RVA = "0x1609714", Offset = "0x1609714", VA = "0x1609714", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005759")]
		[Address(RVA = "0x16097C0", Offset = "0x16097C0", VA = "0x16097C0", Slot = "5")]
		public override void SetActive(bool value)
		{
		}

		[Token(Token = "0x600575A")]
		[Address(RVA = "0x16097F8", Offset = "0x16097F8", VA = "0x16097F8", Slot = "6")]
		public override void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600575B")]
		[Address(RVA = "0x1609864", Offset = "0x1609864", VA = "0x1609864")]
		public BasicCameraController()
		{
		}
	}
}
