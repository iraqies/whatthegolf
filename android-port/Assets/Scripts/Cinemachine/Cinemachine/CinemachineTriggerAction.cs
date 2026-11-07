using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Cinemachine
{
	[Token(Token = "0x200007C")]
	public class CinemachineTriggerAction : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		public struct ActionSettings
		{
			[Token(Token = "0x200007E")]
			public enum Mode
			{
				[Token(Token = "0x40002C7")]
				Custom = 0,
				[Token(Token = "0x40002C8")]
				PriorityBoost = 1,
				[Token(Token = "0x40002C9")]
				Activate = 2,
				[Token(Token = "0x40002CA")]
				Deactivate = 3,
				[Token(Token = "0x40002CB")]
				Enable = 4,
				[Token(Token = "0x40002CC")]
				Disable = 5,
				[Token(Token = "0x40002CD")]
				Play = 6,
				[Token(Token = "0x40002CE")]
				Stop = 7
			}

			[Serializable]
			[Token(Token = "0x200007F")]
			public class TriggerEvent : UnityEvent
			{
				[Token(Token = "0x600030A")]
				[Address(RVA = "0x1911A6C", Offset = "0x1911A6C", VA = "0x1911A6C")]
				public TriggerEvent()
				{
				}
			}

			[Token(Token = "0x2000080")]
			public enum TimeMode
			{
				[Token(Token = "0x40002D0")]
				FromStart = 0,
				[Token(Token = "0x40002D1")]
				FromEnd = 1,
				[Token(Token = "0x40002D2")]
				BeforeNow = 2,
				[Token(Token = "0x40002D3")]
				AfterNow = 3
			}

			[Token(Token = "0x40002C0")]
			[FieldOffset(Offset = "0x0")]
			public Mode m_Action;

			[Token(Token = "0x40002C1")]
			[FieldOffset(Offset = "0x8")]
			public UnityEngine.Object m_Target;

			[Token(Token = "0x40002C2")]
			[FieldOffset(Offset = "0x10")]
			public int m_BoostAmount;

			[Token(Token = "0x40002C3")]
			[FieldOffset(Offset = "0x14")]
			public float m_StartTime;

			[Token(Token = "0x40002C4")]
			[FieldOffset(Offset = "0x18")]
			public TimeMode m_Mode;

			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0x20")]
			public TriggerEvent m_Event;

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x1906460", Offset = "0x1906460", VA = "0x1906460")]
			public ActionSettings(Mode action)
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x1905A58", Offset = "0x1905A58", VA = "0x1905A58")]
			public void Invoke()
			{
			}
		}

		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask m_LayerMask;

		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x20")]
		public string m_WithTag;

		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x28")]
		public string m_WithoutTag;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x30")]
		public int m_SkipFirst;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x34")]
		public bool m_Repeating;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x38")]
		public ActionSettings m_OnObjectEnter;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x60")]
		public ActionSettings m_OnObjectExit;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x88")]
		private HashSet<GameObject> m_ActiveTriggerObjects;

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1905904", Offset = "0x1905904", VA = "0x1905904")]
		private bool Filter(GameObject other)
		{
			return default;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x19059B0", Offset = "0x19059B0", VA = "0x19059B0")]
		private void InternalDoTriggerEnter(GameObject other)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1906028", Offset = "0x1906028", VA = "0x1906028")]
		private void InternalDoTriggerExit(GameObject other)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x19060E0", Offset = "0x19060E0", VA = "0x19060E0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1906118", Offset = "0x1906118", VA = "0x1906118")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1906150", Offset = "0x1906150", VA = "0x1906150")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1906188", Offset = "0x1906188", VA = "0x1906188")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x19061C0", Offset = "0x19061C0", VA = "0x19061C0")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x19061F8", Offset = "0x19061F8", VA = "0x19061F8")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1906230", Offset = "0x1906230", VA = "0x1906230")]
		private void OnCollisionEnter2D(Collision2D other)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1906268", Offset = "0x1906268", VA = "0x1906268")]
		private void OnCollisionExit2D(Collision2D other)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x19062A0", Offset = "0x19062A0", VA = "0x19062A0")]
		public CinemachineTriggerAction()
		{
		}
	}
}
