using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200005F")]
	internal class BlendSourceVirtualCamera : ICinemachineCamera
	{
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x791D0", Offset = "0x791D0")]
		private CinemachineBlend Blend__BackingField;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x791E0", Offset = "0x791E0")]
		private int Priority__BackingField;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x791F0", Offset = "0x791F0")]
		private Transform LookAt__BackingField;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79200", Offset = "0x79200")]
		private Transform Follow__BackingField;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79210", Offset = "0x79210")]
		private CameraState State__BackingField;

		[Token(Token = "0x17000092")]
		public CinemachineBlend Blend
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x18DEA44", Offset = "0x18DEA44", VA = "0x18DEA44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x799E8", Offset = "0x799E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x18DEA4C", Offset = "0x18DEA4C", VA = "0x18DEA4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x799F8", Offset = "0x799F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public string Name
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x18DEA54", Offset = "0x18DEA54", VA = "0x18DEA54", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public int Priority
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x18DEA98", Offset = "0x18DEA98", VA = "0x18DEA98", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A08", Offset = "0x79A08")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000095")]
		public Transform LookAt
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x18DEAA0", Offset = "0x18DEAA0", VA = "0x18DEAA0", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A18", Offset = "0x79A18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public Transform Follow
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x18DEAA8", Offset = "0x18DEAA8", VA = "0x18DEAA8", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A28", Offset = "0x79A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public CameraState State
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x18DEAB0", Offset = "0x18DEAB0", VA = "0x18DEAB0", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A38", Offset = "0x79A38")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x18DEAEC", Offset = "0x18DEAEC", VA = "0x18DEAEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A48", Offset = "0x79A48")]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public GameObject VirtualCameraGameObject
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x18DEB28", Offset = "0x18DEB28", VA = "0x18DEB28", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public bool IsValid
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x18DEB30", Offset = "0x18DEB30", VA = "0x18DEB30", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009A")]
		public ICinemachineCamera ParentCamera
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x18DEC90", Offset = "0x18DEC90", VA = "0x18DEC90", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x18DEA18", Offset = "0x18DEA18", VA = "0x18DEA18")]
		public BlendSourceVirtualCamera(CinemachineBlend blend)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x18DEC98", Offset = "0x18DEC98", VA = "0x18DEC98", Slot = "12")]
		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x18DECCC", Offset = "0x18DECCC", VA = "0x18DECCC", Slot = "13")]
		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x18DF454", Offset = "0x18DF454", VA = "0x18DF454", Slot = "14")]
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}
	}
}
