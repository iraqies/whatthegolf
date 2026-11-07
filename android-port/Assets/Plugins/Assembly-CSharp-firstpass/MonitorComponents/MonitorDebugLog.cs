using Il2CppDummyDll;
using UnityEngine;

namespace MonitorComponents
{
	[Token(Token = "0x200026B")]
	[ExecuteInEditMode]
	public class MonitorDebugLog : MonoBehaviour
	{
		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0x18")]
		public string filterPrefix;

		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0x20")]
		private Monitor monitor;

		[Token(Token = "0x6001004")]
		[Address(RVA = "0x13B07BC", Offset = "0x13B07BC", VA = "0x13B07BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001005")]
		[Address(RVA = "0x13B0844", Offset = "0x13B0844", VA = "0x13B0844")]
		private void Start()
		{
		}

		[Token(Token = "0x6001006")]
		[Address(RVA = "0x13B08FC", Offset = "0x13B08FC", VA = "0x13B08FC")]
		public void UpdateMonitors()
		{
		}

		[Token(Token = "0x6001007")]
		[Address(RVA = "0x13B0A8C", Offset = "0x13B0A8C", VA = "0x13B0A8C")]
		public void Update()
		{
		}

		[Token(Token = "0x6001008")]
		[Address(RVA = "0x13B0ACC", Offset = "0x13B0ACC", VA = "0x13B0ACC")]
		private void LogCallback(string logString, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x6001009")]
		[Address(RVA = "0x13B0BAC", Offset = "0x13B0BAC", VA = "0x13B0BAC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600100A")]
		[Address(RVA = "0x13B0BB0", Offset = "0x13B0BB0", VA = "0x13B0BB0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600100B")]
		[Address(RVA = "0x13B0BB4", Offset = "0x13B0BB4", VA = "0x13B0BB4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600100C")]
		[Address(RVA = "0x13B0C30", Offset = "0x13B0C30", VA = "0x13B0C30")]
		private void RemoveMonitor()
		{
		}

		[Token(Token = "0x600100D")]
		[Address(RVA = "0x13B0CAC", Offset = "0x13B0CAC", VA = "0x13B0CAC")]
		public MonitorDebugLog()
		{
		}
	}
}
