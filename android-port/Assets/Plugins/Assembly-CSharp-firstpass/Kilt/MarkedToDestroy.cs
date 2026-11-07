using Il2CppDummyDll;
using Kilt.Collections;
using UnityEngine;

namespace Kilt
{
	[Token(Token = "0x200008A")]
	[ExecuteInEditMode]
	public class MarkedToDestroy : MonoBehaviour
	{
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x0")]
		private static ArrayList<MarkedToDestroy> _markedToDestroyInstances;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Object m_target;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_onlyDestroyInEditor;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool m_destroyOnStart;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_timeToDestroy;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_ignoreTimeScale;

		[Token(Token = "0x1700004A")]
		public Object Target
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x13AA400", Offset = "0x13AA400", VA = "0x13AA400")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x13AA408", Offset = "0x13AA408", VA = "0x13AA408")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool OnlyDestroyInEditor
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x13AA410", Offset = "0x13AA410", VA = "0x13AA410")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x13AA418", Offset = "0x13AA418", VA = "0x13AA418")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool DestroyOnStart
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x13AA420", Offset = "0x13AA420", VA = "0x13AA420")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x13AA428", Offset = "0x13AA428", VA = "0x13AA428")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public float TimeToDestroy
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x13AA430", Offset = "0x13AA430", VA = "0x13AA430")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x13AA438", Offset = "0x13AA438", VA = "0x13AA438")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool IgnoreTimeScale
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x13AA440", Offset = "0x13AA440", VA = "0x13AA440")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x13AA448", Offset = "0x13AA448", VA = "0x13AA448")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		protected GameObject GameObjectCastedTarget
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x13AA450", Offset = "0x13AA450", VA = "0x13AA450")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		protected Component ComponentCastedTarget
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x13AA4B4", Offset = "0x13AA4B4", VA = "0x13AA4B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x13AA534", Offset = "0x13AA534", VA = "0x13AA534", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x13AA60C", Offset = "0x13AA60C", VA = "0x13AA60C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x13AAA94", Offset = "0x13AAA94", VA = "0x13AAA94", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x13AAB0C", Offset = "0x13AAB0C", VA = "0x13AAB0C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x13AAB74", Offset = "0x13AAB74", VA = "0x13AAB74", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x13AAC0C", Offset = "0x13AAC0C", VA = "0x13AAC0C", Slot = "9")]
		protected virtual void UpdateTime()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x13AAC68", Offset = "0x13AAC68", VA = "0x13AAC68", Slot = "10")]
		protected virtual void DestroyTarget()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x13AAE6C", Offset = "0x13AAE6C", VA = "0x13AAE6C", Slot = "11")]
		protected virtual void InitAsGameObjectTarget()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x13AA684", Offset = "0x13AA684", VA = "0x13AA684")]
		protected void CheckActivation()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x13AB020", Offset = "0x13AB020", VA = "0x13AB020")]
		private void ReverseCheckActivation()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x13AB430", Offset = "0x13AB430", VA = "0x13AB430")]
		public static bool IsMarked(Object p_object)
		{
			return default;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x13AB4EC", Offset = "0x13AB4EC", VA = "0x13AB4EC")]
		public static MarkedToDestroy GetMark(Object p_object)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x13AB88C", Offset = "0x13AB88C", VA = "0x13AB88C")]
		public static void RemoveMark(Object p_object)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x13ABA38", Offset = "0x13ABA38", VA = "0x13ABA38")]
		public MarkedToDestroy()
		{
		}
	}
}
