using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1B93FC", Offset = "0x1B93FC")]
	[ExecuteAlways]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1B93FC", Offset = "0x1B93FC")]
	[DisallowMultipleComponent]
	public class TextMeshProUGUI : TMP_Text, ILayoutElement
	{
		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B94B8", Offset = "0x1B94B8")]
		private sealed class _003CDelayedGraphicRebuild_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000573")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000574")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000575")]
			[FieldOffset(Offset = "0x20")]
			public TextMeshProUGUI _003C_003E4__this;

			[Token(Token = "0x1700014B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600053A")]
				[Address(RVA = "0x2AE062C", Offset = "0x2AE062C", VA = "0x2AE062C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700014C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600053C")]
				[Address(RVA = "0x2AE0674", Offset = "0x2AE0674", VA = "0x2AE0674", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x2AE053C", Offset = "0x2AE053C", VA = "0x2AE053C")]
			[DebuggerHidden]
			public _003CDelayedGraphicRebuild_003Ed__89(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x2AE0568", Offset = "0x2AE0568", VA = "0x2AE0568", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x2AE056C", Offset = "0x2AE056C", VA = "0x2AE056C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x2AE062C", Offset = "0x2AE062C", VA = "0x2AE062C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0x2AE0634", Offset = "0x2AE0634", VA = "0x2AE0634", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0x2AE0674", Offset = "0x2AE0674", VA = "0x2AE0674", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B94C8", Offset = "0x1B94C8")]
		private sealed class _003CDelayedMaterialRebuild_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000576")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000577")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000578")]
			[FieldOffset(Offset = "0x20")]
			public TextMeshProUGUI _003C_003E4__this;

			[Token(Token = "0x1700014D")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0x2AE0774", Offset = "0x2AE0774", VA = "0x2AE0774", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700014E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000542")]
				[Address(RVA = "0x2AE07BC", Offset = "0x2AE07BC", VA = "0x2AE07BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600053D")]
			[Address(RVA = "0x2AE067C", Offset = "0x2AE067C", VA = "0x2AE067C")]
			[DebuggerHidden]
			public _003CDelayedMaterialRebuild_003Ed__90(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0x2AE06A8", Offset = "0x2AE06A8", VA = "0x2AE06A8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0x2AE06AC", Offset = "0x2AE06AC", VA = "0x2AE06AC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000540")]
			[Address(RVA = "0x2AE0774", Offset = "0x2AE0774", VA = "0x2AE0774", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x2AE077C", Offset = "0x2AE077C", VA = "0x2AE077C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0x2AE07BC", Offset = "0x2AE07BC", VA = "0x2AE07BC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x6C0")]
		[SerializeField]
		private bool m_hasFontAssetChanged;

		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x6C8")]
		protected TMP_SubMeshUI[] m_subTextObjects;

		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x6D0")]
		private float m_previousLossyScaleY;

		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x6D8")]
		private Vector3[] m_RectTransformCorners;

		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x6E0")]
		private CanvasRenderer m_canvasRenderer;

		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x6E8")]
		private Canvas m_canvas;

		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x6F0")]
		private float m_CanvasScaleFactor;

		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x6F4")]
		private bool m_isFirstAllocation;

		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x6F8")]
		private int m_max_characters;

		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x700")]
		[SerializeField]
		private Material m_baseMaterial;

		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x708")]
		private bool m_isScrollRegionSet;

		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x70C")]
		[SerializeField]
		private Vector4 m_maskOffset;

		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x71C")]
		private Matrix4x4 m_EnvMapMatrix;

		[NonSerialized]
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x75C")]
		private bool m_isRegisteredForEvents;

		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker k_GenerateTextMarker;

		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker k_SetArraySizesMarker;

		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker k_GenerateTextPhaseIMarker;

		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker k_ParseMarkupTextMarker;

		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker k_CharacterLookupMarker;

		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker k_HandleGPOSFeaturesMarker;

		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker k_CalculateVerticesPositionMarker;

		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x38")]
		private static ProfilerMarker k_ComputeTextMetricsMarker;

		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x40")]
		private static ProfilerMarker k_HandleVisibleCharacterMarker;

		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x48")]
		private static ProfilerMarker k_HandleWhiteSpacesMarker;

		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x50")]
		private static ProfilerMarker k_HandleHorizontalLineBreakingMarker;

		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x58")]
		private static ProfilerMarker k_HandleVerticalLineBreakingMarker;

		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x60")]
		private static ProfilerMarker k_SaveGlyphVertexDataMarker;

		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x68")]
		private static ProfilerMarker k_ComputeCharacterAdvanceMarker;

		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x70")]
		private static ProfilerMarker k_HandleCarriageReturnMarker;

		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x78")]
		private static ProfilerMarker k_HandleLineTerminationMarker;

		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x80")]
		private static ProfilerMarker k_SavePageInfoMarker;

		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x88")]
		private static ProfilerMarker k_SaveProcessingStatesMarker;

		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x90")]
		private static ProfilerMarker k_GenerateTextPhaseIIMarker;

		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x98")]
		private static ProfilerMarker k_GenerateTextPhaseIIIMarker;

		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x75D")]
		private bool m_isRebuildingLayout;

		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x760")]
		private Coroutine m_DelayedGraphicRebuild;

		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x768")]
		private Coroutine m_DelayedMaterialRebuild;

		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x770")]
		private Rect m_ClipRect;

		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x780")]
		private bool m_ValidRect;

		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x788")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA5F8", Offset = "0x1BA5F8")]
		private new Action<TMP_TextInfo> m_OnPreRenderText;

		[Token(Token = "0x17000146")]
		public override Material materialForRendering
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x2ADC790", Offset = "0x2ADC790", VA = "0x2ADC790", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000147")]
		public override bool autoSizeTextContainer
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x2ADC818", Offset = "0x2ADC818", VA = "0x2ADC818", Slot = "71")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x2ADC820", Offset = "0x2ADC820", VA = "0x2ADC820", Slot = "72")]
			set
			{
			}
		}

		[Token(Token = "0x17000148")]
		public override Mesh mesh
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x2ADC8C8", Offset = "0x2ADC8C8", VA = "0x2ADC8C8", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000149")]
		public new CanvasRenderer canvasRenderer
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x2ADC8D0", Offset = "0x2ADC8D0", VA = "0x2ADC8D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014A")]
		public Vector4 maskOffset
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x2ADD0FC", Offset = "0x2ADD0FC", VA = "0x2ADD0FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x2ADD110", Offset = "0x2ADD110", VA = "0x2ADD110")]
			set
			{
			}
		}

		[Token(Token = "0x14000005")]
		public override event Action<TMP_TextInfo> OnPreRenderText
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x2ADDB0C", Offset = "0x2ADDB0C", VA = "0x2ADDB0C", Slot = "74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA8D8", Offset = "0x1BA8D8")]
			add
			{
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x2ADDBB0", Offset = "0x2ADDBB0", VA = "0x2ADDBB0", Slot = "75")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA8E8", Offset = "0x1BA8E8")]
			remove
			{
			}
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2ACDBF0", Offset = "0x2ACDBF0", VA = "0x2ACDBF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2ACDFA4", Offset = "0x2ACDFA4", VA = "0x2ACDFA4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2ACE280", Offset = "0x2ACE280", VA = "0x2ACE280", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2ACE46C", Offset = "0x2ACE46C", VA = "0x2ACE46C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2ACE624", Offset = "0x2ACE624", VA = "0x2ACE624", Slot = "85")]
		protected override void LoadFontAsset()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2ACE0F4", Offset = "0x2ACE0F4", VA = "0x2ACE0F4")]
		private Canvas GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2ACECA4", Offset = "0x2ACECA4", VA = "0x2ACECA4")]
		private void UpdateEnvMapMatrix()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2ACEEF0", Offset = "0x2ACEEF0", VA = "0x2ACEEF0")]
		private void EnableMasking()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2ACF4FC", Offset = "0x2ACF4FC", VA = "0x2ACF4FC")]
		private void DisableMasking()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2ACF0E0", Offset = "0x2ACF0E0", VA = "0x2ACF0E0")]
		private void UpdateMask()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2ACF500", Offset = "0x2ACF500", VA = "0x2ACF500", Slot = "87")]
		protected override Material GetMaterial(Material mat)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2ACF65C", Offset = "0x2ACF65C", VA = "0x2ACF65C", Slot = "90")]
		protected override Material[] GetMaterials(Material[] mats)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2ACF7FC", Offset = "0x2ACF7FC", VA = "0x2ACF7FC", Slot = "86")]
		protected override void SetSharedMaterial(Material mat)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2ACF840", Offset = "0x2ACF840", VA = "0x2ACF840", Slot = "88")]
		protected override Material[] GetSharedMaterials()
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2ACF9C8", Offset = "0x2ACF9C8", VA = "0x2ACF9C8", Slot = "89")]
		protected override void SetSharedMaterials(Material[] materials)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2ACFE54", Offset = "0x2ACFE54", VA = "0x2ACFE54", Slot = "94")]
		protected override void SetOutlineThickness(float thickness)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2AD005C", Offset = "0x2AD005C", VA = "0x2AD005C", Slot = "92")]
		protected override void SetFaceColor(Color32 color)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2AD017C", Offset = "0x2AD017C", VA = "0x2AD017C", Slot = "93")]
		protected override void SetOutlineColor(Color32 color)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2AD029C", Offset = "0x2AD029C", VA = "0x2AD029C", Slot = "95")]
		protected override void SetShaderDepth()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2AD0428", Offset = "0x2AD0428", VA = "0x2AD0428", Slot = "96")]
		protected override void SetCulling()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2AD0780", Offset = "0x2AD0780", VA = "0x2AD0780")]
		private void SetPerspectiveCorrection()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2AD0840", Offset = "0x2AD0840", VA = "0x2AD0840")]
		private void SetMeshArrays(int size)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2AD08B8", Offset = "0x2AD08B8", VA = "0x2AD08B8", Slot = "108")]
		internal override int SetArraySizes(UnicodeChar[] unicodeChars)
		{
			return default;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2AD2740", Offset = "0x2AD2740", VA = "0x2AD2740", Slot = "113")]
		public override void ComputeMarginSize()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2AD2878", Offset = "0x2AD2878", VA = "0x2AD2878", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2AD28BC", Offset = "0x2AD28BC", VA = "0x2AD28BC", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2AD2A04", Offset = "0x2AD2A04", VA = "0x2AD2A04", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2AD2A54", Offset = "0x2AD2A54", VA = "0x2AD2A54", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2AD2D9C", Offset = "0x2AD2D9C", VA = "0x2AD2D9C", Slot = "126")]
		internal override void InternalUpdate()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2AD3078", Offset = "0x2AD3078", VA = "0x2AD3078")]
		private void OnPreRenderCanvas()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2AD3340", Offset = "0x2AD3340", VA = "0x2AD3340", Slot = "136")]
		protected virtual void GenerateTextMesh()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2ADBF84", Offset = "0x2ADBF84", VA = "0x2ADBF84", Slot = "100")]
		protected override Vector3[] GetTextContainerLocalCorners()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2ADC034", Offset = "0x2ADC034", VA = "0x2ADC034", Slot = "121")]
		protected override void SetActiveSubMeshes(bool state)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2ADC168", Offset = "0x2ADC168", VA = "0x2ADC168", Slot = "122")]
		protected override void DestroySubMeshObjects()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2ADC280", Offset = "0x2ADC280", VA = "0x2ADC280", Slot = "110")]
		protected override Bounds GetCompoundBounds()
		{
			return default;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2ADC56C", Offset = "0x2ADC56C", VA = "0x2ADC56C", Slot = "111")]
		internal override Rect GetCanvasSpaceClippingRect()
		{
			return default;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2AD2E54", Offset = "0x2AD2E54", VA = "0x2AD2E54")]
		private void UpdateSDFScale(float scaleDelta)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2ADC97C", Offset = "0x2ADC97C", VA = "0x2ADC97C", Slot = "127")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x2ADC980", Offset = "0x2ADC980", VA = "0x2ADC980", Slot = "128")]
		public void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x2ADC984", Offset = "0x2ADC984", VA = "0x2ADC984", Slot = "28")]
		public override void SetVerticesDirty()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2ADCA88", Offset = "0x2ADCA88", VA = "0x2ADCA88", Slot = "27")]
		public override void SetLayoutDirty()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x2ADCB90", Offset = "0x2ADCB90", VA = "0x2ADCB90", Slot = "29")]
		public override void SetMaterialDirty()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2ADCC9C", Offset = "0x2ADCC9C", VA = "0x2ADCC9C", Slot = "26")]
		public override void SetAllDirty()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2ADCCEC", Offset = "0x2ADCCEC", VA = "0x2ADCCEC")]
		private IEnumerator DelayedGraphicRebuild()
		{
			return null;
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2ADCD60", Offset = "0x2ADCD60", VA = "0x2ADCD60")]
		private IEnumerator DelayedMaterialRebuild()
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2ADCDD4", Offset = "0x2ADCDD4", VA = "0x2ADCDD4", Slot = "37")]
		public override void Rebuild(CanvasUpdate update)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2AD2C9C", Offset = "0x2AD2C9C", VA = "0x2AD2C9C")]
		private void UpdateSubObjectPivot()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2ADCED0", Offset = "0x2ADCED0", VA = "0x2ADCED0", Slot = "55")]
		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x2ADCFE8", Offset = "0x2ADCFE8", VA = "0x2ADCFE8", Slot = "40")]
		protected override void UpdateMaterial()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2ADD148", Offset = "0x2ADD148", VA = "0x2ADD148", Slot = "59")]
		public override void RecalculateClipping()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x2ADD150", Offset = "0x2ADD150", VA = "0x2ADD150", Slot = "56")]
		public override void Cull(Rect clipRect, bool validRect)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2ADD398", Offset = "0x2ADD398", VA = "0x2ADD398", Slot = "97")]
		internal override void UpdateCulling()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x2ADD588", Offset = "0x2ADD588", VA = "0x2ADD588", Slot = "105")]
		public override void UpdateMeshPadding()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2ADD6A0", Offset = "0x2ADD6A0", VA = "0x2ADD6A0", Slot = "106")]
		protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2ADD788", Offset = "0x2ADD788", VA = "0x2ADD788", Slot = "107")]
		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2ADD838", Offset = "0x2ADD838", VA = "0x2ADD838", Slot = "101")]
		public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2ADD8F4", Offset = "0x2ADD8F4", VA = "0x2ADD8F4", Slot = "112")]
		public override TMP_TextInfo GetTextInfo(string text)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2ADD9F0", Offset = "0x2ADD9F0", VA = "0x2ADD9F0", Slot = "123")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2ADDC54", Offset = "0x2ADDC54", VA = "0x2ADDC54", Slot = "102")]
		public override void UpdateGeometry(Mesh mesh, int index)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2ADDCE0", Offset = "0x2ADDCE0", VA = "0x2ADDCE0", Slot = "103")]
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x2ADDED8", Offset = "0x2ADDED8", VA = "0x2ADDED8", Slot = "104")]
		public override void UpdateVertexData()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x2ADE0C8", Offset = "0x2ADE0C8", VA = "0x2ADE0C8")]
		public void UpdateFontAsset()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2ADE0D8", Offset = "0x2ADE0D8", VA = "0x2ADE0D8")]
		public TextMeshProUGUI()
		{
		}
	}
}
