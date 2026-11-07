using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x33524", Offset = "0x33524")]
	[ExecuteInEditMode]
	public class CameraInputController : MonoBehaviour
	{
		[Token(Token = "0x200009D")]
		[Flags]
		public enum DrawTypeEnum
		{
			[Token(Token = "0x40002C3")]
			NGUIType = 1,
			[Token(Token = "0x40002C4")]
			MeshRendererType = 2,
			[Token(Token = "0x40002C5")]
			SpriteRendererType = 4
		}

		[Token(Token = "0x200009E")]
		[Flags]
		public enum ColliderTypeEnum
		{
			[Token(Token = "0x40002C7")]
			Raycast2D = 1,
			[Token(Token = "0x40002C8")]
			Raycast3D = 2
		}

		[Token(Token = "0x200009F")]
		public enum ClickNotification
		{
			[Token(Token = "0x40002CA")]
			None = 0,
			[Token(Token = "0x40002CB")]
			Always = 1,
			[Token(Token = "0x40002CC")]
			BasedOnDelta = 2
		}

		[Token(Token = "0x20000A0")]
		public class MouseOrTouch
		{
			[Token(Token = "0x40002CD")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 pos;

			[Token(Token = "0x40002CE")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 delta;

			[Token(Token = "0x40002CF")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 totalDelta;

			[Token(Token = "0x40002D0")]
			[FieldOffset(Offset = "0x28")]
			public Camera pressedCam;

			[Token(Token = "0x40002D1")]
			[FieldOffset(Offset = "0x30")]
			public GameObject current;

			[Token(Token = "0x40002D2")]
			[FieldOffset(Offset = "0x38")]
			public GameObject pressed;

			[Token(Token = "0x40002D3")]
			[FieldOffset(Offset = "0x40")]
			public GameObject dragged;

			[Token(Token = "0x40002D4")]
			[FieldOffset(Offset = "0x48")]
			public float clickTime;

			[Token(Token = "0x40002D5")]
			[FieldOffset(Offset = "0x4C")]
			public ClickNotification clickNotification;

			[Token(Token = "0x40002D6")]
			[FieldOffset(Offset = "0x50")]
			public bool touchBegan;

			[Token(Token = "0x40002D7")]
			[FieldOffset(Offset = "0x51")]
			public bool pressStarted;

			[Token(Token = "0x40002D8")]
			[FieldOffset(Offset = "0x52")]
			public bool dragStarted;

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x1338E6C", Offset = "0x1338E6C", VA = "0x1338E6C")]
			public MouseOrTouch()
			{
			}
		}

		[Token(Token = "0x20000A1")]
		private class Highlighted
		{
			[Token(Token = "0x40002D9")]
			[FieldOffset(Offset = "0x10")]
			public GameObject go;

			[Token(Token = "0x40002DA")]
			[FieldOffset(Offset = "0x18")]
			public int counter;

			[Token(Token = "0x600036E")]
			[Address(RVA = "0x1338E64", Offset = "0x1338E64", VA = "0x1338E64")]
			public Highlighted()
			{
			}
		}

		[Token(Token = "0x20000A2")]
		public delegate void OnCustomInput();

		[Serializable]
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x335BC", Offset = "0x335BC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002DB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002DC")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<RaycastHit2D> _003C_003E9__125_0;

			[Token(Token = "0x40002DD")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<RaycastHit> _003C_003E9__127_0;

			[Token(Token = "0x6000374")]
			[Address(RVA = "0x1338BB4", Offset = "0x1338BB4", VA = "0x1338BB4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x1338BBC", Offset = "0x1338BBC", VA = "0x1338BBC")]
			internal int _003CRaycastToCamera_003Eb__125_0(RaycastHit2D r1, RaycastHit2D r2)
			{
				return default;
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x1338D10", Offset = "0x1338D10", VA = "0x1338D10")]
			internal int _003CRaycastToCamera_003Eb__127_0(RaycastHit r1, RaycastHit r2)
			{
				return default;
			}
		}

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34B10", Offset = "0x34B10")]
		private static Action<bool> m_OnGlobalPress;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34B20", Offset = "0x34B20")]
		private static Action<Vector2> m_OnGlobalDrag;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x34B30", Offset = "0x34B30")]
		private static Action<GameObject> m_OnGlobalDrop;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x18")]
		public bool debug;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x19")]
		public bool useMouse;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x1A")]
		public bool useTouch;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x1B")]
		public bool allowMultiTouch;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x1C")]
		public bool useKeyboard;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x1D")]
		public bool useController;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x1E")]
		public bool stickyPress;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask eventReceiverMask;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x24")]
		public bool clipRaycasts;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x28")]
		public float tooltipDelay;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x2C")]
		public bool stickyTooltip;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x30")]
		public float mouseDragThreshold;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x34")]
		public float mouseClickThreshold;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x38")]
		public float touchDragThreshold;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x3C")]
		public float touchClickThreshold;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x40")]
		public float rangeDistance;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x48")]
		public string scrollAxisName;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x50")]
		public string verticalAxisName;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x58")]
		public string horizontalAxisName;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x60")]
		public KeyCode submitKey0;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x64")]
		public KeyCode submitKey1;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x68")]
		public KeyCode cancelKey0;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x6C")]
		public KeyCode cancelKey1;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x18")]
		public static OnCustomInput onCustomInput;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x20")]
		public static bool showTooltips;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x24")]
		public static Vector2 lastTouchPosition;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x2C")]
		public static RaycastHit lastHit;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x58")]
		public static CameraInputController current;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x60")]
		public static Camera currentCamera;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x68")]
		public static int currentTouchID;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x70")]
		public static MouseOrTouch currentTouch;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x78")]
		public static bool inputHasFocus;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x80")]
		public static GameObject genericEventHandler;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x88")]
		public static GameObject fallThrough;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x90")]
		private static List<Highlighted> mHighlighted;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x98")]
		private static GameObject mSel;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0xA0")]
		private static MouseOrTouch[] mMouse;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0xA8")]
		private static GameObject mHover;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0xB0")]
		private static MouseOrTouch mController;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0xB8")]
		private static float mNextEvent;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0xC0")]
		private static Dictionary<int, MouseOrTouch> mTouches;

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x70")]
		private GameObject mTooltip;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x78")]
		private Camera mCam;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x80")]
		private LayerMask mLayerMask;

		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x84")]
		private float mTooltipTime;

		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x88")]
		private bool mIsEditor;

		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0xC8")]
		public static bool isDragging;

		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0xD0")]
		public static GameObject hoveredObject;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private ColliderTypeEnum m_collisionType;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0xD8")]
		public static RaycastHit2D lastHit2D;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x100")]
		public static RaycastResult lastHitUGUI;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x150")]
		private static List<CameraInputController> s_allCameraInputControllers;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x158")]
		private static RaycastHit2D mEmpty2D;

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x17C")]
		private static RaycastHit mEmpty3D;

		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x1A8")]
		private static RaycastResult mEmptyUGUI;

		[Token(Token = "0x17000068")]
		public Camera cachedCamera
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x130EF1C", Offset = "0x130EF1C", VA = "0x130EF1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public static GameObject selectedObject
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x130EFC8", Offset = "0x130EFC8", VA = "0x130EFC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x130F02C", Offset = "0x130F02C", VA = "0x130F02C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public static int touchCount
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x130FBAC", Offset = "0x130FBAC", VA = "0x130FBAC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006B")]
		public static int dragCount
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x130FEBC", Offset = "0x130FEBC", VA = "0x130FEBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006C")]
		public static Camera mainCamera
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x13101CC", Offset = "0x13101CC", VA = "0x13101CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public static CameraInputController eventHandler
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1310288", Offset = "0x1310288", VA = "0x1310288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public ColliderTypeEnum CollisionType
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x13105E4", Offset = "0x13105E4", VA = "0x13105E4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x13105EC", Offset = "0x13105EC", VA = "0x13105EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		protected static List<CameraInputController> AllCameraInputControllers
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1310464", Offset = "0x1310464", VA = "0x1310464")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x1310600", Offset = "0x1310600", VA = "0x1310600")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		protected static GameObject Sel
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1310698", Offset = "0x1310698", VA = "0x1310698")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1310734", Offset = "0x1310734", VA = "0x1310734")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		protected static MouseOrTouch[] Mouse
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1310810", Offset = "0x1310810", VA = "0x1310810")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1310874", Offset = "0x1310874", VA = "0x1310874")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		protected static GameObject Hover
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x131090C", Offset = "0x131090C", VA = "0x131090C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x1310970", Offset = "0x1310970", VA = "0x1310970")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		protected static MouseOrTouch Controller
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1310A4C", Offset = "0x1310A4C", VA = "0x1310A4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1310AB0", Offset = "0x1310AB0", VA = "0x1310AB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		protected static float NextEvent
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1310B48", Offset = "0x1310B48", VA = "0x1310B48")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x1310BAC", Offset = "0x1310BAC", VA = "0x1310BAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		protected static Dictionary<int, MouseOrTouch> Touches
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x1310C44", Offset = "0x1310C44", VA = "0x1310C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1310CA8", Offset = "0x1310CA8", VA = "0x1310CA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		protected GameObject Tooltip
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x1310D40", Offset = "0x1310D40", VA = "0x1310D40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1310D48", Offset = "0x1310D48", VA = "0x1310D48")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		protected Camera Cam
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1310DD4", Offset = "0x1310DD4", VA = "0x1310DD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x1310DDC", Offset = "0x1310DDC", VA = "0x1310DDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		protected LayerMask LayMask
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x1310E68", Offset = "0x1310E68", VA = "0x1310E68")]
			get
			{
				return default;
			}
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x1310E70", Offset = "0x1310E70", VA = "0x1310E70")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		protected float TooltipTime
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x1310EC0", Offset = "0x1310EC0", VA = "0x1310EC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1310EC8", Offset = "0x1310EC8", VA = "0x1310EC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		protected bool IsEditor
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x1310EE0", Offset = "0x1310EE0", VA = "0x1310EE0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x1310EE8", Offset = "0x1310EE8", VA = "0x1310EE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		protected bool handlesEvents
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x1310EFC", Offset = "0x1310EFC", VA = "0x1310EFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action<bool> OnGlobalPress
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x130E8DC", Offset = "0x130E8DC", VA = "0x130E8DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38004", Offset = "0x38004")]
			add
			{
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x130E9E4", Offset = "0x130E9E4", VA = "0x130E9E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38014", Offset = "0x38014")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action<Vector2> OnGlobalDrag
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x130EAEC", Offset = "0x130EAEC", VA = "0x130EAEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38024", Offset = "0x38024")]
			add
			{
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x130EBF8", Offset = "0x130EBF8", VA = "0x130EBF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38034", Offset = "0x38034")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event Action<GameObject> OnGlobalDrop
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x130ED04", Offset = "0x130ED04", VA = "0x130ED04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38044", Offset = "0x38044")]
			add
			{
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x130EE10", Offset = "0x130EE10", VA = "0x130EE10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38054", Offset = "0x38054")]
			remove
			{
			}
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1310FA4", Offset = "0x1310FA4", VA = "0x1310FA4")]
		private static int CompareFunc(CameraInputController a, CameraInputController b)
		{
			return default;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1311050", Offset = "0x1311050", VA = "0x1311050")]
		protected void UpdateHoveredObject()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1311080", Offset = "0x1311080", VA = "0x1311080", Slot = "4")]
		protected virtual void UpdateHoveredObject(Vector2 p_position)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1311890", Offset = "0x1311890", VA = "0x1311890")]
		public static bool RaycastToCamera(CameraInputController p_camera, Vector3 inPos, out RaycastHit2D hit)
		{
			return default;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1311E88", Offset = "0x1311E88", VA = "0x1311E88")]
		public static bool RaycastToCamera(CameraInputController p_camera, Vector3 inPos, out RaycastHit hit)
		{
			return default;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1312438", Offset = "0x1312438", VA = "0x1312438")]
		public static bool RaycastToCamera(CameraInputController p_camera, Vector3 inPos, out RaycastResult hit)
		{
			return default;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1312C14", Offset = "0x1312C14", VA = "0x1312C14")]
		public static bool Raycast(Vector3 inPos, out RaycastHit2D hit)
		{
			return default;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1312D70", Offset = "0x1312D70", VA = "0x1312D70")]
		public static bool Raycast(Vector3 inPos, out RaycastHit hit)
		{
			return default;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x13115B4", Offset = "0x13115B4", VA = "0x13115B4")]
		public static bool Raycast(Vector3 inPos, out RaycastResult hit)
		{
			return default;
		}

		[Token(Token = "0x6000349")]
		protected static bool UpdateRayCastWithType<T>(ref RaycastResult p_ray)
		{
			return default;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1312ED4", Offset = "0x1312ED4", VA = "0x1312ED4")]
		private static DrawTypeEnum GetDrawOrderHighestDepth(Transform p_root, out int p_depth)
		{
			return default;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x131303C", Offset = "0x131303C", VA = "0x131303C")]
		private static Renderer GetRendererWithHighestDepthInTransform(Transform p_root)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x130F4D0", Offset = "0x130F4D0", VA = "0x130F4D0")]
		public static CameraInputController FindInputControllerForLayer(int layer)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x13131F4", Offset = "0x13131F4", VA = "0x13131F4")]
		private static int GetDirection(KeyCode up, KeyCode down)
		{
			return default;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1313234", Offset = "0x1313234", VA = "0x1313234")]
		private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
		{
			return default;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x13132AC", Offset = "0x13132AC", VA = "0x13132AC")]
		private static int GetDirection(string axis)
		{
			return default;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x13134DC", Offset = "0x13134DC", VA = "0x13134DC")]
		public static bool IsHighlighted(GameObject go)
		{
			return default;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x130F830", Offset = "0x130F830", VA = "0x130F830")]
		protected static void Highlight(GameObject go, bool highlighted)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1313638", Offset = "0x1313638", VA = "0x1313638")]
		public static void CallGlobalPress(bool p_pressed)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1313700", Offset = "0x1313700", VA = "0x1313700")]
		public static void CallGlobalDrag(Vector2 p_delta)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x13137D0", Offset = "0x13137D0", VA = "0x13137D0")]
		public static void CallGlobalDrop(GameObject p_dropObject)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x130F638", Offset = "0x130F638", VA = "0x130F638")]
		public static void Notify(GameObject go, string funcName, object obj, bool safeNotify = false)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1313898", Offset = "0x1313898", VA = "0x1313898")]
		protected static void SafeNotify(GameObject go, string funcName, object obj)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1313B28", Offset = "0x1313B28", VA = "0x1313B28")]
		protected static List<MonoBehaviour> ComponentsToNotify(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1313D9C", Offset = "0x1313D9C", VA = "0x1313D9C")]
		public static MouseOrTouch GetTouch(int id)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1313F3C", Offset = "0x1313F3C", VA = "0x1313F3C")]
		public static void RemoveTouch(int id)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1314008", Offset = "0x1314008", VA = "0x1314008")]
		public static void AddInCorrectDepthPos(CameraInputController p_uiCamera)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1314490", Offset = "0x1314490", VA = "0x1314490")]
		public bool CameraCanInteractWithObject(GameObject p_object)
		{
			return default;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x131455C", Offset = "0x131455C", VA = "0x131455C", Slot = "5")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x13145E0", Offset = "0x13145E0", VA = "0x13145E0", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x131484C", Offset = "0x131484C", VA = "0x131484C", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x13148D8", Offset = "0x13148D8", VA = "0x13148D8", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x13149C0", Offset = "0x13149C0", VA = "0x13149C0", Slot = "9")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1314AF4", Offset = "0x1314AF4", VA = "0x1314AF4", Slot = "10")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x131510C", Offset = "0x131510C", VA = "0x131510C")]
		public void ProcessMouse()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1315F20", Offset = "0x1315F20", VA = "0x1315F20")]
		public void ProcessTouches()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x13164B4", Offset = "0x13164B4", VA = "0x13164B4")]
		public void ProcessOthers()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1316A8C", Offset = "0x1316A8C", VA = "0x1316A8C")]
		public void ProcessTouch(bool pressed, bool unpressed)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1316370", Offset = "0x1316370", VA = "0x1316370")]
		public void ShowTooltip(bool val)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1312800", Offset = "0x1312800", VA = "0x1312800")]
		protected static void FilterResultByLayer(LayerMask p_layerMask, ref List<RaycastResult> p_results)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1317A38", Offset = "0x1317A38", VA = "0x1317A38")]
		protected static string GetHierarchy(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1310550", Offset = "0x1310550", VA = "0x1310550")]
		protected static bool GetActive(GameObject go)
		{
			return default;
		}

		[Token(Token = "0x600036A")]
		protected static T FindInParents<T>(GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1317B80", Offset = "0x1317B80", VA = "0x1317B80")]
		public CameraInputController()
		{
		}
	}
}
