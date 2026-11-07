using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Kilt.EasyRopes2D
{
	[ExecuteInEditMode]
	public class CameraInputController : MonoBehaviour
	{
		[Flags]
		public enum DrawTypeEnum
		{
			NGUIType = 1,
			MeshRendererType = 2,
			SpriteRendererType = 4
		}

		[Flags]
		public enum ColliderTypeEnum
		{
			Raycast2D = 1,
			Raycast3D = 2
		}

		public enum ClickNotification
		{
			None = 0,
			Always = 1,
			BasedOnDelta = 2
		}

		public class MouseOrTouch
		{
			public Vector2 pos;

			public Vector2 delta;

			public Vector2 totalDelta;

			public Camera pressedCam;

			public GameObject current;

			public GameObject pressed;

			public GameObject dragged;

			public float clickTime;

			public ClickNotification clickNotification;

			public bool touchBegan;

			public bool pressStarted;

			public bool dragStarted;
		}

		private class Highlighted
		{
			public GameObject go;

			public int counter;
		}

		public delegate void OnCustomInput();

		[CompilerGenerated]
		private static Action<bool> m_OnGlobalPress;

		[CompilerGenerated]
		private static Action<Vector2> m_OnGlobalDrag;

		[CompilerGenerated]
		private static Action<GameObject> m_OnGlobalDrop;

		public bool debug;

		public bool useMouse;

		public bool useTouch;

		public bool allowMultiTouch;

		public bool useKeyboard;

		public bool useController;

		public bool stickyPress;

		public LayerMask eventReceiverMask;

		public bool clipRaycasts;

		public float tooltipDelay;

		public bool stickyTooltip;

		public float mouseDragThreshold;

		public float mouseClickThreshold;

		public float touchDragThreshold;

		public float touchClickThreshold;

		public float rangeDistance;

		public string scrollAxisName;

		public string verticalAxisName;

		public string horizontalAxisName;

		public KeyCode submitKey0;

		public KeyCode submitKey1;

		public KeyCode cancelKey0;

		public KeyCode cancelKey1;

		public static OnCustomInput onCustomInput;

		public static bool showTooltips;

		public static Vector2 lastTouchPosition;

		public static RaycastHit lastHit;

		public static CameraInputController current;

		public static Camera currentCamera;

		public static int currentTouchID;

		public static MouseOrTouch currentTouch;

		public static bool inputHasFocus;

		public static GameObject genericEventHandler;

		public static GameObject fallThrough;

		private static List<Highlighted> mHighlighted;

		private static GameObject mSel;

		private static MouseOrTouch[] mMouse;

		private static GameObject mHover;

		private static MouseOrTouch mController;

		private static float mNextEvent;

		private static Dictionary<int, MouseOrTouch> mTouches;

		private GameObject mTooltip;

		private Camera mCam;

		private LayerMask mLayerMask;

		private float mTooltipTime;

		private bool mIsEditor;

		public static bool isDragging;

		public static GameObject hoveredObject;

		[SerializeField]
		private ColliderTypeEnum m_collisionType;

		public static RaycastHit2D lastHit2D;

		public static RaycastResult lastHitUGUI;

		private static List<CameraInputController> s_allCameraInputControllers;

		private static RaycastHit2D mEmpty2D;

		private static RaycastHit mEmpty3D;

		private static RaycastResult mEmptyUGUI;

		public Camera cachedCamera => null;

		public static GameObject selectedObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int touchCount => 0;

		public static int dragCount => 0;

		public static Camera mainCamera => null;

		public static CameraInputController eventHandler => null;

		public ColliderTypeEnum CollisionType
		{
			get
			{
				return (ColliderTypeEnum)0;
			}
			set
			{
			}
		}

		protected static List<CameraInputController> AllCameraInputControllers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected static GameObject Sel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected static MouseOrTouch[] Mouse
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected static GameObject Hover
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected static MouseOrTouch Controller
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected static float NextEvent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected static Dictionary<int, MouseOrTouch> Touches
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected GameObject Tooltip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected Camera Cam
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected LayerMask LayMask
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		protected float TooltipTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected bool IsEditor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected bool handlesEvents => false;

		public static event Action<bool> OnGlobalPress
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<Vector2> OnGlobalDrag
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<GameObject> OnGlobalDrop
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private static int CompareFunc(CameraInputController a, CameraInputController b)
		{
			return 0;
		}

		protected void UpdateHoveredObject()
		{
		}

		protected virtual void UpdateHoveredObject(Vector2 p_position)
		{
		}

		public static bool RaycastToCamera(CameraInputController p_camera, Vector3 inPos, out RaycastHit2D hit)
		{
			hit = default;
			return false;
		}

		public static bool RaycastToCamera(CameraInputController p_camera, Vector3 inPos, out RaycastHit hit)
		{
			hit = default;
			return false;
		}

		public static bool RaycastToCamera(CameraInputController p_camera, Vector3 inPos, out RaycastResult hit)
		{
			hit = default;
			return false;
		}

		public static bool Raycast(Vector3 inPos, out RaycastHit2D hit)
		{
			hit = default;
			return false;
		}

		public static bool Raycast(Vector3 inPos, out RaycastHit hit)
		{
			hit = default;
			return false;
		}

		public static bool Raycast(Vector3 inPos, out RaycastResult hit)
		{
			hit = default;
			return false;
		}

		protected static bool UpdateRayCastWithType<T>(ref RaycastResult p_ray)
		{
			return false;
		}

		private static DrawTypeEnum GetDrawOrderHighestDepth(Transform p_root, out int p_depth)
		{
			p_depth = default;
			return (DrawTypeEnum)0;
		}

		private static Renderer GetRendererWithHighestDepthInTransform(Transform p_root)
		{
			return null;
		}

		public static CameraInputController FindInputControllerForLayer(int layer)
		{
			return null;
		}

		private static int GetDirection(KeyCode up, KeyCode down)
		{
			return 0;
		}

		private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
		{
			return 0;
		}

		private static int GetDirection(string axis)
		{
			return 0;
		}

		public static bool IsHighlighted(GameObject go)
		{
			return false;
		}

		protected static void Highlight(GameObject go, bool highlighted)
		{
		}

		public static void CallGlobalPress(bool p_pressed)
		{
		}

		public static void CallGlobalDrag(Vector2 p_delta)
		{
		}

		public static void CallGlobalDrop(GameObject p_dropObject)
		{
		}

		public static void Notify(GameObject go, string funcName, object obj, bool safeNotify = false)
		{
		}

		protected static void SafeNotify(GameObject go, string funcName, object obj)
		{
		}

		protected static List<MonoBehaviour> ComponentsToNotify(GameObject go)
		{
			return null;
		}

		public static MouseOrTouch GetTouch(int id)
		{
			return null;
		}

		public static void RemoveTouch(int id)
		{
		}

		public static void AddInCorrectDepthPos(CameraInputController p_uiCamera)
		{
		}

		public bool CameraCanInteractWithObject(GameObject p_object)
		{
			return false;
		}

		protected virtual void OnApplicationQuit()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void Update()
		{
		}

		public void ProcessMouse()
		{
		}

		public void ProcessTouches()
		{
		}

		public void ProcessOthers()
		{
		}

		public void ProcessTouch(bool pressed, bool unpressed)
		{
		}

		public void ShowTooltip(bool val)
		{
		}

		protected static void FilterResultByLayer(LayerMask p_layerMask, ref List<RaycastResult> p_results)
		{
		}

		protected static string GetHierarchy(GameObject obj)
		{
			return null;
		}

		protected static bool GetActive(GameObject go)
		{
			return false;
		}

		protected static T FindInParents<T>(GameObject go) where T : Component
		{
			return null;
		}
	}
}
