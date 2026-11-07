using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200005E")]
	internal class StaticPointVirtualCamera : ICinemachineCamera
	{
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79180", Offset = "0x79180")]
		private string Name__BackingField;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79190", Offset = "0x79190")]
		private int Priority__BackingField;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x791A0", Offset = "0x791A0")]
		private Transform LookAt__BackingField;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x791B0", Offset = "0x791B0")]
		private Transform Follow__BackingField;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x791C0", Offset = "0x791C0")]
		private CameraState State__BackingField;

		[Token(Token = "0x1700008A")]
		public string Name
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x190D0C0", Offset = "0x190D0C0", VA = "0x190D0C0", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79978", Offset = "0x79978")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x190D0C8", Offset = "0x190D0C8", VA = "0x190D0C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79988", Offset = "0x79988")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public int Priority
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x190D0D0", Offset = "0x190D0D0", VA = "0x190D0D0", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79998", Offset = "0x79998")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008C")]
		public Transform LookAt
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x190D0D8", Offset = "0x190D0D8", VA = "0x190D0D8", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x799A8", Offset = "0x799A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public Transform Follow
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x190D0E0", Offset = "0x190D0E0", VA = "0x190D0E0", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x799B8", Offset = "0x799B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public CameraState State
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x190D0E8", Offset = "0x190D0E8", VA = "0x190D0E8", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x799C8", Offset = "0x799C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x190D124", Offset = "0x190D124", VA = "0x190D124")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x799D8", Offset = "0x799D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public GameObject VirtualCameraGameObject
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x190D160", Offset = "0x190D160", VA = "0x190D160", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public bool IsValid
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x190D168", Offset = "0x190D168", VA = "0x190D168", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000091")]
		public ICinemachineCamera ParentCamera
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x190D170", Offset = "0x190D170", VA = "0x190D170", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x190AB08", Offset = "0x190AB08", VA = "0x190AB08")]
		public StaticPointVirtualCamera(CameraState state, string name)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x190D178", Offset = "0x190D178", VA = "0x190D178", Slot = "12")]
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x190D180", Offset = "0x190D180", VA = "0x190D180", Slot = "13")]
		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x190D184", Offset = "0x190D184", VA = "0x190D184", Slot = "14")]
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}
	}
}
