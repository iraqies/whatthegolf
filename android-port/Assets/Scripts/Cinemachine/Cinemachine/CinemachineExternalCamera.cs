using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200001D")]
	[Attribute(Name = "RequireComponent", RVA = "0x7803C", Offset = "0x7803C")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class CinemachineExternalCamera : CinemachineVirtualCameraBase
	{
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x60")]
		public Transform m_LookAt;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x68")]
		private Camera m_Camera;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x70")]
		private CameraState m_State;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78438", Offset = "0x78438")]
		private Transform Follow__BackingField;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x158")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78448", Offset = "0x78448")]
		public BlendHint m_BlendHint;

		[Token(Token = "0x1700001F")]
		public override CameraState State
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x18F0E68", Offset = "0x18F0E68", VA = "0x18F0E68", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000020")]
		public override Transform LookAt
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x18F0EA4", Offset = "0x18F0EA4", VA = "0x18F0EA4", Slot = "21")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x18F0EAC", Offset = "0x18F0EAC", VA = "0x18F0EAC", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public override Transform Follow
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x18F0EB4", Offset = "0x18F0EB4", VA = "0x18F0EB4", Slot = "23")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x794E8", Offset = "0x794E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x18F0EBC", Offset = "0x18F0EBC", VA = "0x18F0EBC", Slot = "24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x794F8", Offset = "0x794F8")]
			set
			{
			}
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x18F0EC4", Offset = "0x18F0EC4", VA = "0x18F0EC4", Slot = "27")]
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x18F1290", Offset = "0x18F1290", VA = "0x18F1290")]
		public CinemachineExternalCamera()
		{
		}
	}
}
