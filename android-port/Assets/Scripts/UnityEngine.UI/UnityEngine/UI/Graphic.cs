using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000018")]
	[ExecuteAlways]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F617C", Offset = "0x1F617C")]
	[DisallowMultipleComponent]
	public abstract class Graphic : UIBehaviour, ICanvasElement
	{
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x0")]
		protected static Material s_DefaultUI;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x8")]
		protected static Texture2D s_WhiteTexture;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F72F4", Offset = "0x1F72F4")]
		protected Material m_Material;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color m_Color;

		[NonSerialized]
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x30")]
		protected bool m_SkipLayoutUpdate;

		[NonSerialized]
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x31")]
		protected bool m_SkipMaterialUpdate;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool m_RaycastTarget;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x33")]
		private bool m_RaycastTargetCache;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector4 m_RaycastPadding;

		[NonSerialized]
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x48")]
		private RectTransform m_RectTransform;

		[NonSerialized]
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x50")]
		private CanvasRenderer m_CanvasRenderer;

		[NonSerialized]
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x58")]
		private Canvas m_Canvas;

		[NonSerialized]
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x60")]
		private bool m_VertsDirty;

		[NonSerialized]
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x61")]
		private bool m_MaterialDirty;

		[NonSerialized]
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x68")]
		protected UnityAction m_OnDirtyLayoutCallback;

		[NonSerialized]
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x70")]
		protected UnityAction m_OnDirtyVertsCallback;

		[NonSerialized]
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x78")]
		protected UnityAction m_OnDirtyMaterialCallback;

		[NonSerialized]
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x10")]
		protected static Mesh s_Mesh;

		[NonSerialized]
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x18")]
		private static readonly VertexHelper s_VertexHelper;

		[NonSerialized]
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x80")]
		protected Mesh m_CachedMesh;

		[NonSerialized]
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x88")]
		protected Vector2[] m_CachedUvs;

		[NonSerialized]
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x90")]
		private readonly TweenRunner<ColorTween> m_ColorTweenRunner;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F7370", Offset = "0x1F7370")]
		private bool useLegacyMeshGeneration__BackingField;

		[Token(Token = "0x17000033")]
		public static Material defaultGraphicMaterial
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x2C04E8C", Offset = "0x2C04E8C", VA = "0x2C04E8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public virtual Color color
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2C04F94", Offset = "0x2C04F94", VA = "0x2C04F94", Slot = "22")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2C04FA0", Offset = "0x2C04FA0", VA = "0x2C04FA0", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public virtual bool raycastTarget
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2C04FE8", Offset = "0x2C04FE8", VA = "0x2C04FE8", Slot = "24")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2C04FF0", Offset = "0x2C04FF0", VA = "0x2C04FF0", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Vector4 raycastPadding
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x2C055F4", Offset = "0x2C055F4", VA = "0x2C055F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x2C05600", Offset = "0x2C05600", VA = "0x2C05600")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		protected bool useLegacyMeshGeneration
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x2C0560C", Offset = "0x2C0560C", VA = "0x2C0560C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F87EC", Offset = "0x1F87EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2C05614", Offset = "0x2C05614", VA = "0x2C05614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F87FC", Offset = "0x1F87FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public int depth
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2C06560", Offset = "0x2C06560", VA = "0x2C06560")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000039")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2C059FC", Offset = "0x2C059FC", VA = "0x2C059FC", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public Canvas canvas
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x2C051A4", Offset = "0x2C051A4", VA = "0x2C051A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public CanvasRenderer canvasRenderer
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x2C06580", Offset = "0x2C06580", VA = "0x2C06580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public virtual Material defaultMaterial
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x2C06618", Offset = "0x2C06618", VA = "0x2C06618", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public virtual Material material
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2C06670", Offset = "0x2C06670", VA = "0x2C06670", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x2C06718", Offset = "0x2C06718", VA = "0x2C06718", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public virtual Material materialForRendering
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2C067C4", Offset = "0x2C067C4", VA = "0x2C067C4", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public virtual Texture mainTexture
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x2C06A20", Offset = "0x2C06A20", VA = "0x2C06A20", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		protected static Mesh workerMesh
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2C07FB8", Offset = "0x2C07FB8", VA = "0x2C07FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2C0561C", Offset = "0x2C0561C", VA = "0x2C0561C")]
		protected Graphic()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2C056DC", Offset = "0x2C056DC", VA = "0x2C056DC", Slot = "26")]
		public virtual void SetAllDirty()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2C0591C", Offset = "0x2C0591C", VA = "0x2C0591C", Slot = "27")]
		public virtual void SetLayoutDirty()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2C05A5C", Offset = "0x2C05A5C", VA = "0x2C05A5C", Slot = "28")]
		public virtual void SetVerticesDirty()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2C05B44", Offset = "0x2C05B44", VA = "0x2C05B44", Slot = "29")]
		public virtual void SetMaterialDirty()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2C05760", Offset = "0x2C05760", VA = "0x2C05760")]
		public void SetRaycastDirty()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2C05C2C", Offset = "0x2C05C2C", VA = "0x2C05C2C", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2C05D2C", Offset = "0x2C05D2C", VA = "0x2C05D2C", Slot = "11")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2C06068", Offset = "0x2C06068", VA = "0x2C06068", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2C06198", Offset = "0x2C06198", VA = "0x2C06198")]
		private void CacheCanvas()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2C06A84", Offset = "0x2C06A84", VA = "0x2C06A84", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2C06C3C", Offset = "0x2C06C3C", VA = "0x2C06C3C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2C06FEC", Offset = "0x2C06FEC", VA = "0x2C06FEC", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2C07180", Offset = "0x2C07180", VA = "0x2C07180", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2C0734C", Offset = "0x2C0734C", VA = "0x2C0734C", Slot = "36")]
		public virtual void OnCullingChanged()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2C07434", Offset = "0x2C07434", VA = "0x2C07434", Slot = "37")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2C07530", Offset = "0x2C07530", VA = "0x2C07530", Slot = "38")]
		public virtual void LayoutComplete()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2C07534", Offset = "0x2C07534", VA = "0x2C07534", Slot = "39")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2C07538", Offset = "0x2C07538", VA = "0x2C07538", Slot = "40")]
		protected virtual void UpdateMaterial()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2C075F4", Offset = "0x2C075F4", VA = "0x2C075F4", Slot = "41")]
		protected virtual void UpdateGeometry()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2C07AC4", Offset = "0x2C07AC4", VA = "0x2C07AC4")]
		private void DoMeshGeneration()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2C07608", Offset = "0x2C07608", VA = "0x2C07608")]
		private void DoLegacyMeshGeneration()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2C0811C", Offset = "0x2C0811C", VA = "0x2C0811C", Slot = "42")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1F880C", Offset = "0x1F880C")]
		protected virtual void OnPopulateMesh(Mesh m)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2C081D0", Offset = "0x2C081D0", VA = "0x2C081D0", Slot = "43")]
		protected virtual void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2C087D0", Offset = "0x2C087D0", VA = "0x2C087D0", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2C087E0", Offset = "0x2C087E0", VA = "0x2C087E0", Slot = "44")]
		public virtual void SetNativeSize()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2C087E4", Offset = "0x2C087E4", VA = "0x2C087E4", Slot = "45")]
		public virtual bool Raycast(Vector2 sp, Camera eventCamera)
		{
			return default;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2C08CBC", Offset = "0x2C08CBC", VA = "0x2C08CBC")]
		public Vector2 PixelAdjustPoint(Vector2 point)
		{
			return default;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2C08448", Offset = "0x2C08448", VA = "0x2C08448")]
		public Rect GetPixelAdjustedRect()
		{
			return default;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2C08FD8", Offset = "0x2C08FD8", VA = "0x2C08FD8", Slot = "46")]
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2C08FEC", Offset = "0x2C08FEC", VA = "0x2C08FEC", Slot = "47")]
		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2C09288", Offset = "0x2C09288", VA = "0x2C09288")]
		private static Color CreateColorFromAlpha(float alpha)
		{
			return default;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2C092B0", Offset = "0x2C092B0", VA = "0x2C092B0", Slot = "48")]
		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2C09354", Offset = "0x2C09354", VA = "0x2C09354")]
		public void RegisterDirtyLayoutCallback(UnityAction action)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2C093D8", Offset = "0x2C093D8", VA = "0x2C093D8")]
		public void UnregisterDirtyLayoutCallback(UnityAction action)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2C0945C", Offset = "0x2C0945C", VA = "0x2C0945C")]
		public void RegisterDirtyVerticesCallback(UnityAction action)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2C094E0", Offset = "0x2C094E0", VA = "0x2C094E0")]
		public void UnregisterDirtyVerticesCallback(UnityAction action)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2C09564", Offset = "0x2C09564", VA = "0x2C09564")]
		public void RegisterDirtyMaterialCallback(UnityAction action)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2C095E8", Offset = "0x2C095E8", VA = "0x2C095E8")]
		public void UnregisterDirtyMaterialCallback(UnityAction action)
		{
		}

		[SpecialName]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2C096F4", Offset = "0x2C096F4", VA = "0x2C096F4", Slot = "18")]
		private Transform UnityEngine_002EUI_002EICanvasElement_002Eget_transform()
		{
			return null;
		}
	}
}
