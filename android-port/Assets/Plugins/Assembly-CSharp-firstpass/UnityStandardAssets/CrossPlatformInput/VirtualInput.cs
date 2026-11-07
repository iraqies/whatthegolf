using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000078")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x347E0", Offset = "0x347E0")]
		private Vector3 virtualMousePosition__BackingField;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700003C")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x132B8AC", Offset = "0x132B8AC", VA = "0x132B8AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37DD0", Offset = "0x37DD0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x132B8B8", Offset = "0x132B8B8", VA = "0x132B8B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37DE0", Offset = "0x37DE0")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x132B8C4", Offset = "0x132B8C4", VA = "0x132B8C4")]
		public bool AxisExists(string name)
		{
			return default;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x132B928", Offset = "0x132B928", VA = "0x132B928")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x132BA88", Offset = "0x132BA88", VA = "0x132BA88")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x132BBE8", Offset = "0x132BBE8", VA = "0x132BBE8")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x132BC88", Offset = "0x132BC88", VA = "0x132BC88")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x132BD2C", Offset = "0x132BD2C", VA = "0x132BD2C")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x132BD34", Offset = "0x132BD34", VA = "0x132BD34")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x132BD3C", Offset = "0x132BD3C", VA = "0x132BD3C")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x60001F9")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x60001FA")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x60001FB")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x60001FC")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x60001FD")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x60001FE")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x60001FF")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000200")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x132BD44", Offset = "0x132BD44", VA = "0x132BD44")]
		protected VirtualInput()
		{
		}
	}
}
