using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MonitorComponents
{
	[Token(Token = "0x2000266")]
	public class Monitor
	{
		[Token(Token = "0x2000267")]
		private class MonitorEventComparer : IComparer<MonitorEvent>
		{
			[Token(Token = "0x6000FEC")]
			[Address(RVA = "0x134FA64", Offset = "0x134FA64", VA = "0x134FA64", Slot = "4")]
			public int Compare(MonitorEvent a, MonitorEvent b)
			{
				return default;
			}

			[Token(Token = "0x6000FED")]
			[Address(RVA = "0x134FA8C", Offset = "0x134FA8C", VA = "0x134FA8C")]
			public MonitorEventComparer()
			{
			}
		}

		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x10")]
		private string name;

		[Token(Token = "0x4000FB0")]
		[FieldOffset(Offset = "0x18")]
		private ValueAxisMode mode;

		[Token(Token = "0x4000FB1")]
		[FieldOffset(Offset = "0x1C")]
		public float latestTime;

		[Token(Token = "0x4000FB2")]
		[FieldOffset(Offset = "0x20")]
		private float min;

		[Token(Token = "0x4000FB3")]
		[FieldOffset(Offset = "0x24")]
		private float max;

		[Token(Token = "0x4000FB4")]
		[FieldOffset(Offset = "0x28")]
		public List<MonitorInput> inputs;

		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x30")]
		public List<MonitorEvent> events;

		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x38")]
		private MonitorEventComparer monitorEventComparer;

		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x40")]
		private GameObject gameObject;

		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x48")]
		private MonitorEvent lookupEvent;

		[Token(Token = "0x170001EC")]
		public float Min
		{
			[Token(Token = "0x6000FE5")]
			[Address(RVA = "0x13AEA48", Offset = "0x13AEA48", VA = "0x13AEA48")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000FE6")]
			[Address(RVA = "0x13AEA50", Offset = "0x13AEA50", VA = "0x13AEA50")]
			set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public float Max
		{
			[Token(Token = "0x6000FE7")]
			[Address(RVA = "0x13AEA58", Offset = "0x13AEA58", VA = "0x13AEA58")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000FE8")]
			[Address(RVA = "0x13AEA60", Offset = "0x13AEA60", VA = "0x13AEA60")]
			set
			{
			}
		}

		[Token(Token = "0x170001EE")]
		public string Name
		{
			[Token(Token = "0x6000FE9")]
			[Address(RVA = "0x13AEA68", Offset = "0x13AEA68", VA = "0x13AEA68")]
			set
			{
			}
		}

		[Token(Token = "0x170001EF")]
		public ValueAxisMode Mode
		{
			[Token(Token = "0x6000FEA")]
			[Address(RVA = "0x13AEA70", Offset = "0x13AEA70", VA = "0x13AEA70")]
			set
			{
			}
		}

		[Token(Token = "0x170001F0")]
		public GameObject GameObject
		{
			[Token(Token = "0x6000FEB")]
			[Address(RVA = "0x13AEA78", Offset = "0x13AEA78", VA = "0x13AEA78")]
			set
			{
			}
		}

		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x13AE4CC", Offset = "0x13AE4CC", VA = "0x13AE4CC")]
		public Monitor(string name)
		{
		}

		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x13AE7B0", Offset = "0x13AE7B0", VA = "0x13AE7B0")]
		public void Resize(float value, float time)
		{
		}

		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x13AE810", Offset = "0x13AE810", VA = "0x13AE810")]
		public void Add(MonitorInput monitorInput)
		{
		}

		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x13AE874", Offset = "0x13AE874", VA = "0x13AE874")]
		public void Add(MonitorEvent monitorEvent)
		{
		}

		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x13AE90C", Offset = "0x13AE90C", VA = "0x13AE90C")]
		public void MoveForward(float time)
		{
		}

		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x13AE914", Offset = "0x13AE914", VA = "0x13AE914")]
		public void Remove(MonitorInput monitorInput)
		{
		}

		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x13AE978", Offset = "0x13AE978", VA = "0x13AE978")]
		public void Close()
		{
		}
	}
}
