using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MonitorComponents
{
	[Token(Token = "0x2000269")]
	[ExecuteInEditMode]
	public class MonitorComponent : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200026A")]
		public class MonitorInputField
		{
			[Token(Token = "0x4000FCD")]
			[FieldOffset(Offset = "0x10")]
			public string[] field;

			[Token(Token = "0x4000FCE")]
			[FieldOffset(Offset = "0x18")]
			public Color color;

			[Token(Token = "0x4000FCF")]
			[FieldOffset(Offset = "0x28")]
			public string fieldTypeName;

			[Token(Token = "0x4000FD0")]
			[FieldOffset(Offset = "0x30")]
			public MonitorInput monitorInput;

			[Token(Token = "0x6001003")]
			[Address(RVA = "0x134FA94", Offset = "0x134FA94", VA = "0x134FA94")]
			public MonitorInputField()
			{
			}
		}

		[Token(Token = "0x4000FC6")]
		[FieldOffset(Offset = "0x18")]
		public Component component;

		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x20")]
		public List<MonitorInputField> monitorInputFields;

		[Token(Token = "0x4000FC8")]
		[FieldOffset(Offset = "0x28")]
		private List<MonitorInputField> oldMonitorInputFields;

		[Token(Token = "0x4000FC9")]
		[FieldOffset(Offset = "0x30")]
		public Monitor monitor;

		[Token(Token = "0x4000FCA")]
		[FieldOffset(Offset = "0x38")]
		public ValueAxisMode mode;

		[Token(Token = "0x4000FCB")]
		[FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x13AF7E4", Offset = "0x13AF7E4", VA = "0x13AF7E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x13AF86C", Offset = "0x13AF86C", VA = "0x13AF86C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x13AF870", Offset = "0x13AF870", VA = "0x13AF870")]
		public void UpdateMonitors()
		{
		}

		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x13AFF20", Offset = "0x13AFF20", VA = "0x13AFF20")]
		public void Update()
		{
		}

		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x13B0610", Offset = "0x13B0610", VA = "0x13B0610")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x13B0614", Offset = "0x13B0614", VA = "0x13B0614")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6001000")]
		[Address(RVA = "0x13B0618", Offset = "0x13B0618", VA = "0x13B0618")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6001001")]
		[Address(RVA = "0x13B0694", Offset = "0x13B0694", VA = "0x13B0694")]
		private void RemoveMonitor()
		{
		}

		[Token(Token = "0x6001002")]
		[Address(RVA = "0x13B0710", Offset = "0x13B0710", VA = "0x13B0710")]
		public MonitorComponent()
		{
		}
	}
}
