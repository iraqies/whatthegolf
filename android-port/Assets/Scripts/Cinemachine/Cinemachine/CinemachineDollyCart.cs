using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200001B")]
	[ExecuteAlways]
	public class CinemachineDollyCart : MonoBehaviour
	{
		[Token(Token = "0x200001C")]
		public enum UpdateMethod
		{
			[Token(Token = "0x400008D")]
			Update = 0,
			[Token(Token = "0x400008E")]
			FixedUpdate = 1,
			[Token(Token = "0x400008F")]
			LateUpdate = 2
		}

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		public CinemachinePathBase m_Path;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		public UpdateMethod m_UpdateMethod;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x24")]
		public CinemachinePathBase.PositionUnits m_PositionUnits;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x783C8", Offset = "0x783C8")]
		public float m_Speed;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78400", Offset = "0x78400")]
		public float m_Position;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x18F0A80", Offset = "0x18F0A80", VA = "0x18F0A80")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x18F0C00", Offset = "0x18F0C00", VA = "0x18F0C00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x18F0C68", Offset = "0x18F0C68", VA = "0x18F0C68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x18F0ACC", Offset = "0x18F0ACC", VA = "0x18F0ACC")]
		private void SetCartPosition(float distanceAlongPath)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x18F0CD4", Offset = "0x18F0CD4", VA = "0x18F0CD4")]
		public CinemachineDollyCart()
		{
		}
	}
}
