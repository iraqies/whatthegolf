using Il2CppDummyDll;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200006A")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200006B")]
		public class VirtualAxis
		{
			[Token(Token = "0x40001B8")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x347A0", Offset = "0x347A0")]
			private string name__BackingField;

			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x347B0", Offset = "0x347B0")]
			private bool matchWithInputManager__BackingField;

			[Token(Token = "0x17000036")]
			public string name
			{
				[Token(Token = "0x60001BF")]
				[Address(RVA = "0x13392E4", Offset = "0x13392E4", VA = "0x13392E4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37D50", Offset = "0x37D50")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C0")]
				[Address(RVA = "0x13392EC", Offset = "0x13392EC", VA = "0x13392EC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37D60", Offset = "0x37D60")]
				private set
				{
				}
			}

			[Token(Token = "0x17000037")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60001C1")]
				[Address(RVA = "0x13392F4", Offset = "0x13392F4", VA = "0x13392F4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37D70", Offset = "0x37D70")]
				get
				{
					return default;
				}
				[Token(Token = "0x60001C2")]
				[Address(RVA = "0x13392FC", Offset = "0x13392FC", VA = "0x13392FC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37D80", Offset = "0x37D80")]
				private set
				{
				}
			}

			[Token(Token = "0x17000038")]
			public float GetValue
			{
				[Token(Token = "0x60001C7")]
				[Address(RVA = "0x13393F4", Offset = "0x13393F4", VA = "0x13393F4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x1339304", Offset = "0x1339304", VA = "0x1339304")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1339338", Offset = "0x1339338", VA = "0x1339338")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1339374", Offset = "0x1339374", VA = "0x1339374")]
			public void Remove()
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x13393EC", Offset = "0x13393EC", VA = "0x13393EC")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200006C")]
		public class VirtualButton
		{
			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x347C0", Offset = "0x347C0")]
			private string name__BackingField;

			[Token(Token = "0x40001BC")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x347D0", Offset = "0x347D0")]
			private bool matchWithInputManager__BackingField;

			[Token(Token = "0x40001BD")]
			[FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40001BE")]
			[FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40001BF")]
			[FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000039")]
			public string name
			{
				[Token(Token = "0x60001C8")]
				[Address(RVA = "0x13393FC", Offset = "0x13393FC", VA = "0x13393FC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37D90", Offset = "0x37D90")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x1339404", Offset = "0x1339404", VA = "0x1339404")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37DA0", Offset = "0x37DA0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003A")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x133940C", Offset = "0x133940C", VA = "0x133940C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37DB0", Offset = "0x37DB0")]
				get
				{
					return default;
				}
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0x1339414", Offset = "0x1339414", VA = "0x1339414")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37DC0", Offset = "0x37DC0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003B")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x1339500", Offset = "0x1339500", VA = "0x1339500")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x133941C", Offset = "0x133941C", VA = "0x133941C")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x1339458", Offset = "0x1339458", VA = "0x1339458")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x133949C", Offset = "0x133949C", VA = "0x133949C")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x13394D4", Offset = "0x13394D4", VA = "0x13394D4")]
			public void Released()
			{
			}
		}

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x13627CC", Offset = "0x13627CC", VA = "0x13627CC")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1362880", Offset = "0x1362880", VA = "0x1362880")]
		public static bool AxisExists(string name)
		{
			return default;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1362900", Offset = "0x1362900", VA = "0x1362900")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1362980", Offset = "0x1362980", VA = "0x1362980")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1362A00", Offset = "0x1362A00", VA = "0x1362A00")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1362AC4", Offset = "0x1362AC4", VA = "0x1362AC4")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1362B44", Offset = "0x1362B44", VA = "0x1362B44")]
		public static float GetAxis(string name)
		{
			return default;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1362C04", Offset = "0x1362C04", VA = "0x1362C04")]
		private static float GetAxis(string name, bool raw)
		{
			return default;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1362C90", Offset = "0x1362C90", VA = "0x1362C90")]
		public static bool GetButtonDown(string name)
		{
			return default;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1362D14", Offset = "0x1362D14", VA = "0x1362D14")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1362D98", Offset = "0x1362D98", VA = "0x1362D98")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1362E1C", Offset = "0x1362E1C", VA = "0x1362E1C")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1362EA0", Offset = "0x1362EA0", VA = "0x1362EA0")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1362F24", Offset = "0x1362F24", VA = "0x1362F24")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1362FA8", Offset = "0x1362FA8", VA = "0x1362FA8")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1363044", Offset = "0x1363044", VA = "0x1363044")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x13630CC", Offset = "0x13630CC", VA = "0x13630CC")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1363154", Offset = "0x1363154", VA = "0x1363154")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
}
