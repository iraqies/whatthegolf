using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace StylizedWater
{
	[Token(Token = "0x20000CC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x336EC", Offset = "0x336EC")]
	public class StylizedWater : MonoBehaviour
	{
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x18")]
		public string[] shaderNames;

		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x20")]
		public int shaderIndex;

		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x30")]
		private Shader DesktopShader;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x38")]
		private Shader MobileAdvancedShader;

		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35078", Offset = "0x35078")]
		public int renderQueue;

		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x44")]
		public bool enableVertexColors;

		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x45")]
		public bool isUnlit;

		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x46")]
		public bool enableGradient;

		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x48")]
		public Gradient colorGradient;

		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x50")]
		public Color waterShallowColor;

		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35098", Offset = "0x35098")]
		public float depth;

		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x64")]
		public Color waterColor;

		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x74")]
		public Color fresnelColor;

		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x84")]
		public float fresnel;

		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x88")]
		public Color rimColor;

		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x350B4", Offset = "0x350B4")]
		public float waveTint;

		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x9C")]
		public bool pixelate;

		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x350CC", Offset = "0x350CC")]
		public float transparency;

		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x350E4", Offset = "0x350E4")]
		public float glossiness;

		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35104", Offset = "0x35104")]
		public float edgeFade;

		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0xB0")]
		public string[] tilingMethodNames;

		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0xB8")]
		public float worldSpaceTiling;

		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3511C", Offset = "0x3511C")]
		public float refractionAmount;

		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0xC0")]
		public bool enableNormalMap;

		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3513C", Offset = "0x3513C")]
		public float normalStrength;

		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0xC8")]
		public bool enableMacroNormals;

		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35154", Offset = "0x35154")]
		public float macroNormalsDistance;

		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35178", Offset = "0x35178")]
		public float normalTiling;

		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0xD4")]
		public int intersectionSolver;

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0xD8")]
		public string[] intersectionSolverNames;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35190", Offset = "0x35190")]
		public float rimSize;

		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x351A8", Offset = "0x351A8")]
		public float rimFalloff;

		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0xE8")]
		public float rimTiling;

		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x351C8", Offset = "0x351C8")]
		public float rimDistortion;

		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0xF0")]
		public bool enableVCIntersection;

		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0xF4")]
		public int foamSolver;

		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0xF8")]
		public string[] foamSolverNames;

		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x351E0", Offset = "0x351E0")]
		public float foamOpacity;

		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x104")]
		public float foamTiling;

		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x351F8", Offset = "0x351F8")]
		public float foamSize;

		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35210", Offset = "0x35210")]
		public float foamDistortion;

		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35228", Offset = "0x35228")]
		public float foamSpeed;

		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35240", Offset = "0x35240")]
		public float waveFoam;

		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35258", Offset = "0x35258")]
		public float reflectionStrength;

		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35270", Offset = "0x35270")]
		public float reflectionFresnel;

		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x120")]
		public bool showReflection;

		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35288", Offset = "0x35288")]
		public float reflectionRefraction;

		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x352A8", Offset = "0x352A8")]
		public float waveSpeed;

		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x352C8", Offset = "0x352C8")]
		public float waveStrength;

		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x352E0", Offset = "0x352E0")]
		public Vector4 waveDirectionXZ;

		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x140")]
		public bool enableSecondaryWaves;

		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x148")]
		public Texture2D customIntersection;

		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x150")]
		public Texture2D customNormal;

		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x158")]
		public Texture2D customHeightmap;

		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x352F8", Offset = "0x352F8")]
		public float tessellation;

		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x168")]
		public string[] intersectionStyleNames;

		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x170")]
		public int intersectionStyle;

		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x178")]
		public string[] waveStyleNames;

		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x180")]
		public int waveStyle;

		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x188")]
		public string[] waveHeightmapNames;

		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x190")]
		public int waveHeightmapStyle;

		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x194")]
		public float waveSize;

		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x198")]
		public bool useCustomIntersection;

		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x199")]
		public bool useCustomNormals;

		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x19A")]
		public bool useCustomHeightmap;

		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x1A0")]
		public Texture2D normals;

		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x1A8")]
		public Texture2D shadermap;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x1B0")]
		public Texture2D colorGradientTex;

		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x1B8")]
		public bool useCompression;

		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x1B9")]
		public bool useReflection;

		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x1BA")]
		public bool useRefractionCam;

		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x1BB")]
		public bool enableReflectionBlur;

		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x1BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35318", Offset = "0x35318")]
		public float reflectionBlurLength;

		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x1C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35330", Offset = "0x35330")]
		public int reflectionBlurPasses;

		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x1C8")]
		private StylizedWaterBlur reflectionBlurRenderer;

		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x1D0")]
		public string[] refractionSolverNames;

		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x1D8")]
		public int refractionSolver;

		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x1E0")]
		public string[] resolutionNames;

		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x1E8")]
		public int reflectionRes;

		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x1EC")]
		public int refractRes;

		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x1F0")]
		public int reflectionTextureSize;

		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x1F4")]
		public int refractTextureSize;

		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x1F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35348", Offset = "0x35348")]
		public float clipPlaneOffset;

		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x1FC")]
		public LayerMask reflectLayers;

		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x200")]
		public LayerMask refractLayers;

		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x208")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x210")]
		private Dictionary<Camera, StylizedWaterBlur> m_BlurRenderers;

		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x218")]
		private Dictionary<Camera, Camera> m_RefractCameras;

		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x220")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x228")]
		private RenderTexture m_RefractTexture;

		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x230")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x234")]
		private int m_OldRefractTextureSize;

		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x238")]
		private bool s_InsideRendering;

		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x239")]
		public bool enableMaskRendering;

		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x240")]
		private StylizedWaterRenderer swsRenderer;

		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x248")]
		private StylizedWaterRenderer.RendererSettings swsRenderSettings;

		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x250")]
		public int swsRendererTextureSize;

		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x254")]
		public LayerMask swsMaskRenderLayers;

		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x0")]
		public static LayerMask s_swsMaskRenderLayers;

		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x258")]
		public Camera renderCam;

		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x260")]
		public Vector4 targetMeshInfo;

		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x270")]
		public int lightingMethod;

		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x278")]
		public string[] lightingMethodNames;

		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x280")]
		public bool enableShadows;

		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x288")]
		private StylizedWaterShadowCaster shadowRenderer;

		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x290")]
		public Light shadowCaster;

		[NonSerialized]
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x298")]
		private MeshRenderer meshRenderer;

		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x2A0")]
		public Material material;

		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x2A8")]
		public bool isMobileAdvanced;

		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x2A9")]
		public bool isMobilePlatform;

		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x2AA")]
		public bool isMobileBasic;

		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x2B0")]
		public string shaderName;

		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x2B8")]
		public bool isWaterLayer;

		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x2B9")]
		public bool hasShaderParams;

		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x2BA")]
		public bool hasMaterial;

		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x2BB")]
		public bool usingSinglePassRendering;

		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x2BC")]
		public bool showLighting;

		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x2BD")]
		public bool showColors;

		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x2BE")]
		public bool showSurface;

		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x2BF")]
		public bool showNormals;

		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x2C0")]
		public bool showIntersection;

		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x2C1")]
		public bool showHighlights;

		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x2C2")]
		public bool showDepth;

		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x2C3")]
		public bool showWaves;

		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x2C4")]
		public bool showAdvanced;

		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x2C5")]
		public bool hideMaterialInspector;

		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x2C6")]
		public bool hideMeshRenderer;

		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x2C7")]
		public bool realtimeEditing;

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x13FD220", Offset = "0x13FD220", VA = "0x13FD220")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x13FD418", Offset = "0x13FD418", VA = "0x13FD418")]
		public void Init()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x13FD2C8", Offset = "0x13FD2C8", VA = "0x13FD2C8")]
		public void GetProperties()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x13FD41C", Offset = "0x13FD41C", VA = "0x13FD41C")]
		private void GetShaderProperties()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x13FDE04", Offset = "0x13FDE04", VA = "0x13FDE04")]
		private void GetShaderType()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x13FDE08", Offset = "0x13FDE08", VA = "0x13FDE08")]
		private void SetShaderType()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x13FD2CC", Offset = "0x13FD2CC", VA = "0x13FD2CC")]
		public void SetProperties()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x13FE390", Offset = "0x13FE390", VA = "0x13FE390")]
		private void SetShaderProperties()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x13FF120", Offset = "0x13FF120", VA = "0x13FF120")]
		public void DisableReflectionCam()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x13FEEEC", Offset = "0x13FEEEC", VA = "0x13FEEEC")]
		public void DisableRefractionCam()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x13FDE0C", Offset = "0x13FDE0C", VA = "0x13FDE0C")]
		private void EnableMaskRendering()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x13FDFAC", Offset = "0x13FDFAC", VA = "0x13FDFAC")]
		private void DisableMaskRendering()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x13FE0AC", Offset = "0x13FE0AC", VA = "0x13FE0AC")]
		private void EnableShadowRendering()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x13FE180", Offset = "0x13FE180", VA = "0x13FE180")]
		private void DisableShadowRendering()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x13FF478", Offset = "0x13FF478", VA = "0x13FF478")]
		public void SetVegetationStudioWaterLevel()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x13FF47C", Offset = "0x13FF47C", VA = "0x13FF47C")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x140064C", Offset = "0x140064C", VA = "0x140064C")]
		public void CreateReflectionTexture()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x14007B8", Offset = "0x14007B8", VA = "0x14007B8")]
		public void CreateRefractionTexture()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x13FFB3C", Offset = "0x13FFB3C", VA = "0x13FFB3C")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractCamera)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1400994", Offset = "0x1400994", VA = "0x1400994")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1400A68", Offset = "0x1400A68", VA = "0x1400A68")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1400A8C", Offset = "0x1400A8C", VA = "0x1400A8C")]
		public StylizedWater()
		{
		}
	}
}
