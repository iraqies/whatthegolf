using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[Token(Token = "0x20000C0")]
	public class GridInformation : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x20000C1")]
		internal struct GridInformationValue
		{
			[Token(Token = "0x40003B4")]
			[FieldOffset(Offset = "0x0")]
			public GridInformationType type;

			[Token(Token = "0x40003B5")]
			[FieldOffset(Offset = "0x8")]
			public object data;
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		internal struct GridInformationKey
		{
			[Token(Token = "0x40003B6")]
			[FieldOffset(Offset = "0x0")]
			public Vector3Int position;

			[Token(Token = "0x40003B7")]
			[FieldOffset(Offset = "0x10")]
			public string name;
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33654", Offset = "0x33654")]
		private sealed class _003C_003Ec__DisplayClass35_0
		{
			[Token(Token = "0x40003B8")]
			[FieldOffset(Offset = "0x10")]
			public string propertyName;

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x133AD40", Offset = "0x133AD40", VA = "0x133AD40")]
			public _003C_003Ec__DisplayClass35_0()
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x133AD48", Offset = "0x133AD48", VA = "0x133AD48")]
			internal bool _003CGetAllPositions_003Eb__0(GridInformationKey x)
			{
				return default;
			}
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33664", Offset = "0x33664")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40003B9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40003BA")]
			[FieldOffset(Offset = "0x8")]
			public static Func<GridInformationKey, Vector3Int> _003C_003E9__35_1;

			[Token(Token = "0x600050C")]
			[Address(RVA = "0x133AD2C", Offset = "0x133AD2C", VA = "0x133AD2C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0x133AD34", Offset = "0x133AD34", VA = "0x133AD34")]
			internal Vector3Int _003CGetAllPositions_003Eb__35_1(GridInformationKey x)
			{
				return default;
			}
		}

		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<GridInformationKey, GridInformationValue> m_PositionProperties;

		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GridInformationKey> m_PositionIntKeys;

		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<int> m_PositionIntValues;

		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GridInformationKey> m_PositionStringKeys;

		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<string> m_PositionStringValues;

		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GridInformationKey> m_PositionFloatKeys;

		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<float> m_PositionFloatValues;

		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<GridInformationKey> m_PositionDoubleKeys;

		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<double> m_PositionDoubleValues;

		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GridInformationKey> m_PositionObjectKeys;

		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<Object> m_PositionObjectValues;

		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<GridInformationKey> m_PositionColorKeys;

		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<Color> m_PositionColorValues;

		[Token(Token = "0x170000C8")]
		internal Dictionary<GridInformationKey, GridInformationValue> PositionProperties
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x137879C", Offset = "0x137879C", VA = "0x137879C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x13787A4", Offset = "0x13787A4", VA = "0x13787A4", Slot = "4")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1378F64", Offset = "0x1378F64", VA = "0x1378F64", Slot = "5")]
		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		[Token(Token = "0x60004F7")]
		public bool SetPositionProperty<T>(Vector3Int position, string name, T positionProperty)
		{
			return default;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x13796F0", Offset = "0x13796F0", VA = "0x13796F0")]
		public bool SetPositionProperty(Vector3Int position, string name, int positionProperty)
		{
			return default;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x13798B4", Offset = "0x13798B4", VA = "0x13798B4")]
		public bool SetPositionProperty(Vector3Int position, string name, string positionProperty)
		{
			return default;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x13798C4", Offset = "0x13798C4", VA = "0x13798C4")]
		public bool SetPositionProperty(Vector3Int position, string name, float positionProperty)
		{
			return default;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1379964", Offset = "0x1379964", VA = "0x1379964")]
		public bool SetPositionProperty(Vector3Int position, string name, double positionProperty)
		{
			return default;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1379A04", Offset = "0x1379A04", VA = "0x1379A04")]
		public bool SetPositionProperty(Vector3Int position, string name, Object positionProperty)
		{
			return default;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1379A14", Offset = "0x1379A14", VA = "0x1379A14")]
		public bool SetPositionProperty(Vector3Int position, string name, Color positionProperty)
		{
			return default;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1379790", Offset = "0x1379790", VA = "0x1379790")]
		private bool SetPositionProperty(Vector3Int position, string name, GridInformationType dataType, object positionProperty)
		{
			return default;
		}

		[Token(Token = "0x60004FF")]
		public T GetPositionProperty<T>(Vector3Int position, string name, T defaultValue) where T : Object
		{
			return null;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1379ACC", Offset = "0x1379ACC", VA = "0x1379ACC")]
		public int GetPositionProperty(Vector3Int position, string name, int defaultValue)
		{
			return default;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1379BFC", Offset = "0x1379BFC", VA = "0x1379BFC")]
		public string GetPositionProperty(Vector3Int position, string name, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1379D28", Offset = "0x1379D28", VA = "0x1379D28")]
		public float GetPositionProperty(Vector3Int position, string name, float defaultValue)
		{
			return default;
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1379E64", Offset = "0x1379E64", VA = "0x1379E64")]
		public double GetPositionProperty(Vector3Int position, string name, double defaultValue)
		{
			return default;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1379FA0", Offset = "0x1379FA0", VA = "0x1379FA0")]
		public Color GetPositionProperty(Vector3Int position, string name, Color defaultValue)
		{
			return default;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x137A100", Offset = "0x137A100", VA = "0x137A100")]
		public bool ErasePositionProperty(Vector3Int position, string name)
		{
			return default;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x137A18C", Offset = "0x137A18C", VA = "0x137A18C", Slot = "6")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x137A1E0", Offset = "0x137A1E0", VA = "0x137A1E0")]
		public Vector3Int[] GetAllPositions(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x137A43C", Offset = "0x137A43C", VA = "0x137A43C")]
		public GridInformation()
		{
		}
	}
}
