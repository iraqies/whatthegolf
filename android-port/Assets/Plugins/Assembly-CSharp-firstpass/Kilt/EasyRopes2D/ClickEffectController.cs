using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x20000A4")]
	public class ClickEffectController : Singleton<ClickEffectController>
	{
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34B50", Offset = "0x34B50")]
		private static Action<bool> m_OnGlobalPress;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34B60", Offset = "0x34B60")]
		private static Action<Vector2> m_OnGlobalDrag;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34B70", Offset = "0x34B70")]
		private static Action<GameObject> m_OnGlobalDrop;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_pressRadius;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_clickEffect;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_trailEffect;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Camera m_clickEffectCamera;

		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _effectInScene;

		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x40")]
		private GameObject _trailEffectInScene;

		[Token(Token = "0x1700007C")]
		public float PressRadius
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x13600D0", Offset = "0x13600D0", VA = "0x13600D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x13600D8", Offset = "0x13600D8", VA = "0x13600D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public GameObject ClickEffect
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x13600E0", Offset = "0x13600E0", VA = "0x13600E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x13600E8", Offset = "0x13600E8", VA = "0x13600E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public GameObject TrailEffect
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x13600F0", Offset = "0x13600F0", VA = "0x13600F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x13600F8", Offset = "0x13600F8", VA = "0x13600F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public Camera ClickEffectCamera
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x1360100", Offset = "0x1360100", VA = "0x1360100")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000004")]
		public static event Action<bool> OnGlobalPress
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x135FC40", Offset = "0x135FC40", VA = "0x135FC40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38064", Offset = "0x38064")]
			add
			{
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x135FD00", Offset = "0x135FD00", VA = "0x135FD00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38074", Offset = "0x38074")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public static event Action<Vector2> OnGlobalDrag
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x135FDC0", Offset = "0x135FDC0", VA = "0x135FDC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38084", Offset = "0x38084")]
			add
			{
			}
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x135FE84", Offset = "0x135FE84", VA = "0x135FE84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38094", Offset = "0x38094")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public static event Action<GameObject> OnGlobalDrop
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x135FF48", Offset = "0x135FF48", VA = "0x135FF48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x380A4", Offset = "0x380A4")]
			add
			{
			}
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x136000C", Offset = "0x136000C", VA = "0x136000C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x380B4", Offset = "0x380B4")]
			remove
			{
			}
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x13601EC", Offset = "0x13601EC", VA = "0x13601EC", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1360254", Offset = "0x1360254", VA = "0x1360254", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x136031C", Offset = "0x136031C", VA = "0x136031C", Slot = "9")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x13603DC", Offset = "0x13603DC", VA = "0x13603DC", Slot = "10")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x13604E4", Offset = "0x13604E4", VA = "0x13604E4", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x13604F4", Offset = "0x13604F4", VA = "0x13604F4", Slot = "12")]
		protected virtual void OnSceneLoaded(Scene p_scene, LoadSceneMode p_mode)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1360258", Offset = "0x1360258", VA = "0x1360258")]
		protected void RegisterLevelEvents()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1360320", Offset = "0x1360320", VA = "0x1360320")]
		protected void UnregisterLevelEvents()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1360684", Offset = "0x1360684", VA = "0x1360684", Slot = "13")]
		protected virtual void RegistedEvents()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1360804", Offset = "0x1360804", VA = "0x1360804", Slot = "14")]
		protected virtual void UnregisterEvents()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1360978", Offset = "0x1360978", VA = "0x1360978", Slot = "15")]
		protected virtual GameObject FindCloseObjectInRange(Vector2 p_globalPoint, float p_radius)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1360B90", Offset = "0x1360B90", VA = "0x1360B90")]
		protected void ShowEffect()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1360C8C", Offset = "0x1360C8C", VA = "0x1360C8C", Slot = "16")]
		protected virtual void ShowEffect(Vector2 p_point, float p_radius)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x13603E0", Offset = "0x13603E0", VA = "0x13603E0")]
		protected void ShowTrailEffect()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1360E38", Offset = "0x1360E38", VA = "0x1360E38", Slot = "17")]
		protected virtual void ShowTrailEffect(Vector2 p_point)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1361008", Offset = "0x1361008", VA = "0x1361008", Slot = "18")]
		protected virtual float GetNewRadius(Camera p_newCamera, Vector2 p_screenPoint)
		{
			return default;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1361158", Offset = "0x1361158", VA = "0x1361158", Slot = "19")]
		protected virtual void TryUpdateCurrentTouch(Camera p_pressCamera)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x136135C", Offset = "0x136135C", VA = "0x136135C", Slot = "20")]
		protected virtual void HandleOnGlobalPress(bool p_isPressed)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1361634", Offset = "0x1361634", VA = "0x1361634", Slot = "21")]
		protected virtual void HandleOnGlobalDrag(Vector2 p_delta)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x13616C4", Offset = "0x13616C4", VA = "0x13616C4", Slot = "22")]
		protected virtual void HandleOnGlobalDrop(GameObject p_dropObject)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x136174C", Offset = "0x136174C", VA = "0x136174C")]
		public ClickEffectController()
		{
		}
	}
}
