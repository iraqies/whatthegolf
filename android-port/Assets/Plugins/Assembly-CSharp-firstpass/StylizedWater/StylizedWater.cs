using System;
using System.Collections.Generic;
using UnityEngine;

namespace StylizedWater
{
	[ExecuteInEditMode]
	public class StylizedWater : MonoBehaviour
	{
		public string[] shaderNames;

		public int shaderIndex;

		public Shader shader;

		private Shader DesktopShader;

		private Shader MobileAdvancedShader;

		public int renderQueue;

		public bool enableVertexColors;

		public bool isUnlit;

		public bool enableGradient;

		public Gradient colorGradient;

		public Color waterShallowColor;

		public float depth;

		public Color waterColor;

		public Color fresnelColor;

		public float fresnel;

		public Color rimColor;

		public float waveTint;

		public bool pixelate;

		public float transparency;

		public float glossiness;

		public float edgeFade;

		public string[] tilingMethodNames;

		public float worldSpaceTiling;

		public float refractionAmount;

		public bool enableNormalMap;

		public float normalStrength;

		public bool enableMacroNormals;

		public float macroNormalsDistance;

		public float normalTiling;

		public int intersectionSolver;

		public string[] intersectionSolverNames;

		public float rimSize;

		public float rimFalloff;

		public float rimTiling;

		public float rimDistortion;

		public bool enableVCIntersection;

		public int foamSolver;

		public string[] foamSolverNames;

		public float foamOpacity;

		public float foamTiling;

		public float foamSize;

		public float foamDistortion;

		public float foamSpeed;

		public float waveFoam;

		public float reflectionStrength;

		public float reflectionFresnel;

		public bool showReflection;

		public float reflectionRefraction;

		public float waveSpeed;

		public float waveStrength;

		public Vector4 waveDirectionXZ;

		public bool enableSecondaryWaves;

		public Texture2D customIntersection;

		public Texture2D customNormal;

		public Texture2D customHeightmap;

		public float tessellation;

		public string[] intersectionStyleNames;

		public int intersectionStyle;

		public string[] waveStyleNames;

		public int waveStyle;

		public string[] waveHeightmapNames;

		public int waveHeightmapStyle;

		public float waveSize;

		public bool useCustomIntersection;

		public bool useCustomNormals;

		public bool useCustomHeightmap;

		public Texture2D normals;

		public Texture2D shadermap;

		public Texture2D colorGradientTex;

		public bool useCompression;

		public bool useReflection;

		public bool useRefractionCam;

		public bool enableReflectionBlur;

		public float reflectionBlurLength;

		public int reflectionBlurPasses;

		private StylizedWaterBlur reflectionBlurRenderer;

		public string[] refractionSolverNames;

		public int refractionSolver;

		public string[] resolutionNames;

		public int reflectionRes;

		public int refractRes;

		public int reflectionTextureSize;

		public int refractTextureSize;

		public float clipPlaneOffset;

		public LayerMask reflectLayers;

		public LayerMask refractLayers;

		private Dictionary<Camera, Camera> m_ReflectionCameras;

		private Dictionary<Camera, StylizedWaterBlur> m_BlurRenderers;

		private Dictionary<Camera, Camera> m_RefractCameras;

		private RenderTexture m_ReflectionTexture;

		private RenderTexture m_RefractTexture;

		private int m_OldReflectionTextureSize;

		private int m_OldRefractTextureSize;

		private bool s_InsideRendering;

		public bool enableMaskRendering;

		private StylizedWaterRenderer swsRenderer;

		private StylizedWaterRenderer.RendererSettings swsRenderSettings;

		public int swsRendererTextureSize;

		public LayerMask swsMaskRenderLayers;

		public static LayerMask s_swsMaskRenderLayers;

		public Camera renderCam;

		public Vector4 targetMeshInfo;

		public int lightingMethod;

		public string[] lightingMethodNames;

		public bool enableShadows;

		private StylizedWaterShadowCaster shadowRenderer;

		public Light shadowCaster;

		[NonSerialized]
		private MeshRenderer meshRenderer;

		public Material material;

		public bool isMobileAdvanced;

		public bool isMobilePlatform;

		public bool isMobileBasic;

		public string shaderName;

		public bool isWaterLayer;

		public bool hasShaderParams;

		public bool hasMaterial;

		public bool usingSinglePassRendering;

		public bool showLighting;

		public bool showColors;

		public bool showSurface;

		public bool showNormals;

		public bool showIntersection;

		public bool showHighlights;

		public bool showDepth;

		public bool showWaves;

		public bool showAdvanced;

		public bool hideMaterialInspector;

		public bool hideMeshRenderer;

		public bool realtimeEditing;

		public void OnEnable()
		{
		}

		public void Init()
		{
		}

		public void GetProperties()
		{
		}

		private void GetShaderProperties()
		{
		}

		private void GetShaderType()
		{
		}

		private void SetShaderType()
		{
		}

		public void SetProperties()
		{
		}

		private void SetShaderProperties()
		{
		}

		public void DisableReflectionCam()
		{
		}

		public void DisableRefractionCam()
		{
		}

		private void EnableMaskRendering()
		{
		}

		private void DisableMaskRendering()
		{
		}

		private void EnableShadowRendering()
		{
		}

		private void DisableShadowRendering()
		{
		}

		public void SetVegetationStudioWaterLevel()
		{
		}

		public void OnWillRenderObject()
		{
		}

		public void CreateReflectionTexture()
		{
		}

		public void CreateRefractionTexture()
		{
		}

		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractCamera)
		{
			reflectionCamera = null;
			refractCamera = null;
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
