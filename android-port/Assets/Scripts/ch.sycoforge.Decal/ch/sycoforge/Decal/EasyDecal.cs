using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	[Serializable]
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	public class EasyDecal : DecalBase
	{
		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B71C", Offset = "0x20B71C")]
		private sealed class _003CProcessFadeOut_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0x10")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000D5")]
			[FieldOffset(Offset = "0x18")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000D6")]
			[FieldOffset(Offset = "0x20")]
			public EasyDecal _003C_003E4__this;

			[Token(Token = "0x40000D7")]
			[FieldOffset(Offset = "0x28")]
			public float _003Ct_003E5__1;

			[Token(Token = "0x17000050")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600015C")]
				[Address(RVA = "0x2C7104C", Offset = "0x2C7104C", VA = "0x2C7104C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000051")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600015F")]
				[Address(RVA = "0x2C71098", Offset = "0x2C71098", VA = "0x2C71098", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2C70ED4", Offset = "0x2C70ED4", VA = "0x2C70ED4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600015C")]
			[Address(RVA = "0x2C7104C", Offset = "0x2C7104C", VA = "0x2C7104C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600015D")]
			[Address(RVA = "0x2C71054", Offset = "0x2C71054", VA = "0x2C71054", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2C71094", Offset = "0x2C71094", VA = "0x2C71094", Slot = "5")]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2C71098", Offset = "0x2C71098", VA = "0x2C71098", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000160")]
			[Address(RVA = "0x2C710A0", Offset = "0x2C710A0", VA = "0x2C710A0")]
			[DebuggerHidden]
			public _003CProcessFadeOut_003Ed__0(int _003C_003E1__state)
			{
			}
		}

		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B72C", Offset = "0x20B72C")]
		private sealed class _003CProcessFadeIn_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D8")]
			[FieldOffset(Offset = "0x10")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000D9")]
			[FieldOffset(Offset = "0x18")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000DA")]
			[FieldOffset(Offset = "0x20")]
			public EasyDecal _003C_003E4__this;

			[Token(Token = "0x40000DB")]
			[FieldOffset(Offset = "0x28")]
			public float _003Ct_003E5__4;

			[Token(Token = "0x17000052")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000162")]
				[Address(RVA = "0x2C70E54", Offset = "0x2C70E54", VA = "0x2C70E54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000053")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000165")]
				[Address(RVA = "0x2C70EA0", Offset = "0x2C70EA0", VA = "0x2C70EA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2C70D5C", Offset = "0x2C70D5C", VA = "0x2C70D5C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2C70E54", Offset = "0x2C70E54", VA = "0x2C70E54", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2C70E5C", Offset = "0x2C70E5C", VA = "0x2C70E5C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000164")]
			[Address(RVA = "0x2C70E9C", Offset = "0x2C70E9C", VA = "0x2C70E9C", Slot = "5")]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2C70EA0", Offset = "0x2C70EA0", VA = "0x2C70EA0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2C70EA8", Offset = "0x2C70EA8", VA = "0x2C70EA8")]
			[DebuggerHidden]
			public _003CProcessFadeIn_003Ed__3(int _003C_003E1__state)
			{
			}
		}

		[Token(Token = "0x400008E")]
		public const int MaxQuality = 6;

		[Token(Token = "0x400008F")]
		internal const string CHILD_NAME = "PROC_PLANE";

		[Token(Token = "0x4000090")]
		internal const string SKINNED_CHILD_NAME = "SKINNED_PROC_PLANE";

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x0")]
		private static Camera renderCamera;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x178")]
		public LayerMask Mask;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x17C")]
		private int id;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x180")]
		internal bool evenID;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x188")]
		private Action<EasyDecal> OnFadedOut_;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x190")]
		private Action<EasyDecal> OnFadedIn_;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x198")]
		private Action<EasyDecal> OnFadeOutStarted_;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x1A0")]
		private Action<EasyDecal, Mesh> OnProjectionFinished_;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x1A8")]
		private Action<EasyDecal> OnAtlasIndexChanged_;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x1B0")]
		private Action<EasyDecal> OnSourceChanged_;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private GameObject projectionTarget;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private ProjectionMode mode;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x1C4")]
		[SerializeField]
		private SourceMode source;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private AspectMode aspectCorrectionMode;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x1CC")]
		[SerializeField]
		private LookupMode recursiveMode;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x1D0")]
		private GameObject receiver;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x1D8")]
		private GameObject meshContainer;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x1E0")]
		private GameObject skinnedMeshContainer;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private SkinQuality skinningQuality;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		internal Material material;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private DecalTextureAtlas atlas;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private int atlasRegionIndex;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x204")]
		[SerializeField]
		private float maxDistance;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private float projectionDistance;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x20C")]
		[SerializeField]
		private bool smoothNormals;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private float normalSmoothFactor;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x214")]
		[SerializeField]
		private float normalSmoothThreshold;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		internal int resolution;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x21C")]
		[SerializeField]
		private bool multiMeshEnabled;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x21D")]
		[SerializeField]
		private bool cullInvisible;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x21E")]
		[SerializeField]
		private bool cullUnreachable;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x21F")]
		[SerializeField]
		private bool showVertices;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private bool showDir;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x221")]
		[SerializeField]
		private bool showNormals;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x222")]
		[SerializeField]
		private bool enableVertexColorFade;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x223")]
		[SerializeField]
		private bool onlyColliders;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x224")]
		[SerializeField]
		private bool tangents;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x225")]
		[SerializeField]
		private bool calculateNormals;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private MeshChannelMode normalChannelMode;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x22C")]
		[SerializeField]
		private MeshChannelMode tangentChannelMode;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private bool recursiceLookup;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x231")]
		[SerializeField]
		private bool randomIndexEnabled;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x234")]
		[SerializeField]
		private int recursiceLookupSteps;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x238")]
		private List<IMeshProcessor> meshProcessors;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		private bool autoDestroy;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x244")]
		[SerializeField]
		private OpacityMode opacityMode;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		private bool fadeOnly;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x249")]
		[SerializeField]
		private bool useLightProbes;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x24C")]
		[SerializeField]
		private float lifetime;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		private float fadeoutTime;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x254")]
		private float creationTime;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		private AnimationCurve fadeoutCurve;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x260")]
		[SerializeField]
		private float surfaceRotation;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x264")]
		[SerializeField]
		private int quality;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x268")]
		private float alpha;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x26C")]
		private int creationFrameNumber;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x270")]
		private int bakeInFrameNumber;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x274")]
		private bool needUVRecreation;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x275")]
		private bool needGeometryRecreation;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		private Mesh sharedMesh;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		private int instanceID;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x284")]
		internal bool projectBake;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x8")]
		public static StaticProxyCollection ProxyCollection;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x10")]
		public static bool HideMesh;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x18")]
		public static InstantiationDelegate Instantiation;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x288")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BBDC", Offset = "0x20BBDC")]
		private float CurrentFadeoutTime__BackingField;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x28C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BBEC", Offset = "0x20BBEC")]
		private Vector3 InverseProjectionDirection__BackingField;

		[Token(Token = "0x1700001D")]
		public static Camera RenderCamera
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x2C626F8", Offset = "0x2C626F8", VA = "0x2C626F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2C627D8", Offset = "0x2C627D8", VA = "0x2C627D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public int ID
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2C62848", Offset = "0x2C62848", VA = "0x2C62848")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2C5E538", Offset = "0x2C5E538", VA = "0x2C5E538")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public SkinQuality SkinningQuality
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2C62850", Offset = "0x2C62850", VA = "0x2C62850")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x2C62858", Offset = "0x2C62858", VA = "0x2C62858")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Mesh SharedMesh
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x2C5D76C", Offset = "0x2C5D76C", VA = "0x2C5D76C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public bool IsVisible
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x2C62860", Offset = "0x2C62860", VA = "0x2C62860")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000022")]
		public int Quality
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x2C62878", Offset = "0x2C62878", VA = "0x2C62878")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x2C62880", Offset = "0x2C62880", VA = "0x2C62880")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool MultiMeshEnabled
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x2C62954", Offset = "0x2C62954", VA = "0x2C62954")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x2C6295C", Offset = "0x2C6295C", VA = "0x2C6295C")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public bool CullInvisibles
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x2C5858C", Offset = "0x2C5858C", VA = "0x2C5858C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x2C62964", Offset = "0x2C62964", VA = "0x2C62964")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool CullUnreachable
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2C6296C", Offset = "0x2C6296C", VA = "0x2C6296C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2C62974", Offset = "0x2C62974", VA = "0x2C62974")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public GameObject Receiver
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2C6297C", Offset = "0x2C6297C", VA = "0x2C6297C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2C62984", Offset = "0x2C62984", VA = "0x2C62984")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public bool CalculateTangents
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x2C6298C", Offset = "0x2C6298C", VA = "0x2C6298C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x2C62994", Offset = "0x2C62994", VA = "0x2C62994")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public MeshChannelMode TangentChannelMode
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x2C6299C", Offset = "0x2C6299C", VA = "0x2C6299C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2C629A4", Offset = "0x2C629A4", VA = "0x2C629A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public bool CalculateNormals
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x2C629AC", Offset = "0x2C629AC", VA = "0x2C629AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2C629B4", Offset = "0x2C629B4", VA = "0x2C629B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public MeshChannelMode NormalChannelMode
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2C629BC", Offset = "0x2C629BC", VA = "0x2C629BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2C629C4", Offset = "0x2C629C4", VA = "0x2C629C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool ShowDir
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2C629CC", Offset = "0x2C629CC", VA = "0x2C629CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2C629D4", Offset = "0x2C629D4", VA = "0x2C629D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool ShowVertices
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x2C629DC", Offset = "0x2C629DC", VA = "0x2C629DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x2C629E4", Offset = "0x2C629E4", VA = "0x2C629E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool ShowNormals
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x2C629EC", Offset = "0x2C629EC", VA = "0x2C629EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2C629F4", Offset = "0x2C629F4", VA = "0x2C629F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public float MaxDistance
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2C629FC", Offset = "0x2C629FC", VA = "0x2C629FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x2C62A04", Offset = "0x2C62A04", VA = "0x2C62A04")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public float ProjectionDistance
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x2C62A0C", Offset = "0x2C62A0C", VA = "0x2C62A0C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x2C62A14", Offset = "0x2C62A14", VA = "0x2C62A14")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool SmoothNormals
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x2C62A1C", Offset = "0x2C62A1C", VA = "0x2C62A1C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2C62A24", Offset = "0x2C62A24", VA = "0x2C62A24")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public float NormalSmoothFactor
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x2C62A2C", Offset = "0x2C62A2C", VA = "0x2C62A2C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2C62A34", Offset = "0x2C62A34", VA = "0x2C62A34")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public float NormalSmoothThreshold
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x2C62A3C", Offset = "0x2C62A3C", VA = "0x2C62A3C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x2C62A44", Offset = "0x2C62A44", VA = "0x2C62A44")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool DontDestroy
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x2C62A4C", Offset = "0x2C62A4C", VA = "0x2C62A4C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x2C62A54", Offset = "0x2C62A54", VA = "0x2C62A54")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool FadeOut
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x2C62A5C", Offset = "0x2C62A5C", VA = "0x2C62A5C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x2C62A64", Offset = "0x2C62A64", VA = "0x2C62A64")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public OpacityMode OpacityMode
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x2C62A6C", Offset = "0x2C62A6C", VA = "0x2C62A6C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x2C62A74", Offset = "0x2C62A74", VA = "0x2C62A74")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public float Lifetime
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2C62A7C", Offset = "0x2C62A7C", VA = "0x2C62A7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x2C62A84", Offset = "0x2C62A84", VA = "0x2C62A84")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public float RemainingLifetime
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2C62A8C", Offset = "0x2C62A8C", VA = "0x2C62A8C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000038")]
		public float CurrentFadeoutTime
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2C62AD8", Offset = "0x2C62AD8", VA = "0x2C62AD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BD8C", Offset = "0x20BD8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x2C62AE0", Offset = "0x2C62AE0", VA = "0x2C62AE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BD9C", Offset = "0x20BD9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public float FadeoutTime
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2C62AE8", Offset = "0x2C62AE8", VA = "0x2C62AE8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2C62AF0", Offset = "0x2C62AF0", VA = "0x2C62AF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public AnimationCurve FadeoutCurve
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x2C62AF8", Offset = "0x2C62AF8", VA = "0x2C62AF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x2C62B00", Offset = "0x2C62B00", VA = "0x2C62B00")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Vector3 InverseProjectionDirection
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2C62B08", Offset = "0x2C62B08", VA = "0x2C62B08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BDAC", Offset = "0x20BDAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x2C62B18", Offset = "0x2C62B18", VA = "0x2C62B18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BDBC", Offset = "0x20BDBC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public float SurfaceRotation
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x2C62B28", Offset = "0x2C62B28", VA = "0x2C62B28")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x2C62B30", Offset = "0x2C62B30", VA = "0x2C62B30")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public Material DecalMaterial
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x2C62B38", Offset = "0x2C62B38", VA = "0x2C62B38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x2C62B40", Offset = "0x2C62B40", VA = "0x2C62B40")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public DecalTextureAtlas Atlas
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x2C62C20", Offset = "0x2C62C20", VA = "0x2C62C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x2C62C28", Offset = "0x2C62C28", VA = "0x2C62C28")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public int AtlasRegionIndex
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x2C62D50", Offset = "0x2C62D50", VA = "0x2C62D50")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x2C62D58", Offset = "0x2C62D58", VA = "0x2C62D58")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public GameObject MeshContainer
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x2C62C04", Offset = "0x2C62C04", VA = "0x2C62C04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public ProjectionMode Mode
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x2C63154", Offset = "0x2C63154", VA = "0x2C63154")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x2C6315C", Offset = "0x2C6315C", VA = "0x2C6315C")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public SourceMode Source
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x2C63164", Offset = "0x2C63164", VA = "0x2C63164")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x2C6316C", Offset = "0x2C6316C", VA = "0x2C6316C")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public AspectMode AspectCorrectionMode
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x2C63268", Offset = "0x2C63268", VA = "0x2C63268")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x2C63270", Offset = "0x2C63270", VA = "0x2C63270")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public LookupMode RecursiveMode
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2C58674", Offset = "0x2C58674", VA = "0x2C58674")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x2C63278", Offset = "0x2C63278", VA = "0x2C63278")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public float Alpha
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2C63280", Offset = "0x2C63280", VA = "0x2C63280")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2C63288", Offset = "0x2C63288", VA = "0x2C63288")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x20BEA4", Offset = "0x20BEA4")]
		public bool IsFadingOut
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2C633C4", Offset = "0x2C633C4", VA = "0x2C633C4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000047")]
		public bool IsFading
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2C633D8", Offset = "0x2C633D8", VA = "0x2C633D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000048")]
		public bool OnlyColliders
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2C57578", Offset = "0x2C57578", VA = "0x2C57578")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x2C633EC", Offset = "0x2C633EC", VA = "0x2C633EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public bool EnableVertexColorBleed
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x2C633F4", Offset = "0x2C633F4", VA = "0x2C633F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2C633FC", Offset = "0x2C633FC", VA = "0x2C633FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool RecursiveLookup
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x2C5866C", Offset = "0x2C5866C", VA = "0x2C5866C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x2C63404", Offset = "0x2C63404", VA = "0x2C63404")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool RandomIndexEnabled
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x2C6340C", Offset = "0x2C6340C", VA = "0x2C6340C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2C63414", Offset = "0x2C63414", VA = "0x2C63414")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public int RecursiveLookupSteps
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x2C58584", Offset = "0x2C58584", VA = "0x2C58584")]
			get
			{
				return default;
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x2C6341C", Offset = "0x2C6341C", VA = "0x2C6341C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public List<IMeshProcessor> MeshProcessors
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x2C63424", Offset = "0x2C63424", VA = "0x2C63424")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x2C6342C", Offset = "0x2C6342C", VA = "0x2C6342C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool UseLightProbes
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x2C63434", Offset = "0x2C63434", VA = "0x2C63434")]
			get
			{
				return default;
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x2C6343C", Offset = "0x2C6343C", VA = "0x2C6343C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public GameObject ProjectionTarget
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2C567BC", Offset = "0x2C567BC", VA = "0x2C567BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x2C63444", Offset = "0x2C63444", VA = "0x2C63444")]
			set
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<EasyDecal> OnFadedOut
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2C620C8", Offset = "0x2C620C8", VA = "0x2C620C8")]
			add
			{
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x2C6214C", Offset = "0x2C6214C", VA = "0x2C6214C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event Action<EasyDecal> OnFadedIn
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2C621D0", Offset = "0x2C621D0", VA = "0x2C621D0")]
			add
			{
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2C62254", Offset = "0x2C62254", VA = "0x2C62254")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event Action<EasyDecal> OnFadeOutStarted
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x2C622D8", Offset = "0x2C622D8", VA = "0x2C622D8")]
			add
			{
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x2C6235C", Offset = "0x2C6235C", VA = "0x2C6235C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action<EasyDecal, Mesh> OnProjectionFinished
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2C623E0", Offset = "0x2C623E0", VA = "0x2C623E0")]
			add
			{
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2C62464", Offset = "0x2C62464", VA = "0x2C62464")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action<EasyDecal> OnAtlasIndexChanged
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2C624E8", Offset = "0x2C624E8", VA = "0x2C624E8")]
			add
			{
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x2C6256C", Offset = "0x2C6256C", VA = "0x2C6256C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action<EasyDecal> OnSourceChanged
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2C625F0", Offset = "0x2C625F0", VA = "0x2C625F0")]
			add
			{
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2C62674", Offset = "0x2C62674", VA = "0x2C62674")]
			remove
			{
			}
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2C6344C", Offset = "0x2C6344C", VA = "0x2C6344C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2C63458", Offset = "0x2C63458", VA = "0x2C63458")]
		public void Reset(bool unbake)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2C63460", Offset = "0x2C63460", VA = "0x2C63460")]
		public void Reset(bool unbake, bool recreate)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2C63B74", Offset = "0x2C63B74", VA = "0x2C63B74", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2C63CDC", Offset = "0x2C63CDC", VA = "0x2C63CDC", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2C63ED4", Offset = "0x2C63ED4", VA = "0x2C63ED4", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2C640D4", Offset = "0x2C640D4", VA = "0x2C640D4", Slot = "6")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2C640D8", Offset = "0x2C640D8", VA = "0x2C640D8", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2C63AF4", Offset = "0x2C63AF4", VA = "0x2C63AF4")]
		public void StartFade()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2C636BC", Offset = "0x2C636BC", VA = "0x2C636BC")]
		public void CancelFade()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2C63FDC", Offset = "0x2C63FDC", VA = "0x2C63FDC")]
		public void SelectRandom()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2C62F4C", Offset = "0x2C62F4C", VA = "0x2C62F4C")]
		public void CorrectAspect()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2C642F8", Offset = "0x2C642F8", VA = "0x2C642F8")]
		private void StartFadeOut()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2C64300", Offset = "0x2C64300", VA = "0x2C64300")]
		public void StartFade(FadingMode mode = FadingMode.Out)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2C645D0", Offset = "0x2C645D0", VA = "0x2C645D0")]
		private IEnumerator ProcessFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2C64644", Offset = "0x2C64644", VA = "0x2C64644")]
		private IEnumerator ProcessFadeIn()
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2C646B8", Offset = "0x2C646B8", VA = "0x2C646B8")]
		public Vector3[] GetBoundingVertices()
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2C5868C", Offset = "0x2C5868C", VA = "0x2C5868C")]
		public Bounds GetBounds()
		{
			return default;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2C64BBC", Offset = "0x2C64BBC", VA = "0x2C64BBC", Slot = "18")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2C64EB4", Offset = "0x2C64EB4", VA = "0x2C64EB4")]
		public void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2C64ED0", Offset = "0x2C64ED0", VA = "0x2C64ED0", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2C65000", Offset = "0x2C65000", VA = "0x2C65000", Slot = "10")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2C65414", Offset = "0x2C65414", VA = "0x2C65414", Slot = "15")]
		protected override void InitalizeProjector()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2C65908", Offset = "0x2C65908", VA = "0x2C65908")]
		private void Log(string msg)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2C65994", Offset = "0x2C65994", VA = "0x2C65994", Slot = "11")]
		protected override void OnChangedTechnique()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2C65A6C", Offset = "0x2C65A6C", VA = "0x2C65A6C", Slot = "19")]
		protected virtual void OnChangedAtlasIndex()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2C65A7C", Offset = "0x2C65A7C", VA = "0x2C65A7C", Slot = "20")]
		protected virtual void OnChangedSource()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2C65AB8", Offset = "0x2C65AB8", VA = "0x2C65AB8", Slot = "21")]
		protected virtual void OnChangedAlpha()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2C65AD0", Offset = "0x2C65AD0", VA = "0x2C65AD0", Slot = "14")]
		protected override void OnChangedBakeStatus()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2C65AE8", Offset = "0x2C65AE8", VA = "0x2C65AE8", Slot = "17")]
		protected override void AskForGeometryRecreation()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2C65AF4", Offset = "0x2C65AF4", VA = "0x2C65AF4", Slot = "16")]
		protected override void AskForUVRecreation()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2C65024", Offset = "0x2C65024", VA = "0x2C65024")]
		private void CreateDecalGameObject()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2C65F4C", Offset = "0x2C65F4C", VA = "0x2C65F4C")]
		private void SetChildTransform(GameObject child)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2C63718", Offset = "0x2C63718", VA = "0x2C63718")]
		private void ResetMesh()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2C6574C", Offset = "0x2C6574C", VA = "0x2C6574C")]
		private Mesh FindSharedMesh()
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2C65E88", Offset = "0x2C65E88", VA = "0x2C65E88")]
		private GameObject Search(string name)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2C56EEC", Offset = "0x2C56EEC", VA = "0x2C56EEC")]
		internal void AddDynamicMesh(DynamicMesh dynamicMesh, bool isStatic = false)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2C63AA8", Offset = "0x2C63AA8", VA = "0x2C63AA8")]
		private void ConvertAndAssign(DynamicMesh dynamicMesh, bool forceRecreation)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2C66328", Offset = "0x2C66328", VA = "0x2C66328")]
		private void AssignSharedMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2C66094", Offset = "0x2C66094", VA = "0x2C66094")]
		private void PostProcessMesh(DynamicMesh mesh)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2C678D4", Offset = "0x2C678D4", VA = "0x2C678D4")]
		public void PostProcessMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2C65B94", Offset = "0x2C65B94", VA = "0x2C65B94")]
		internal void TransformUV(DynamicMesh dynamicMesh)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2C64D0C", Offset = "0x2C64D0C", VA = "0x2C64D0C")]
		private void DrawMeshGeometryGizmos(Vector3[] vertices, Vector3[] normals)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2C678D8", Offset = "0x2C678D8", VA = "0x2C678D8")]
		private void ResetPlanes()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2C678DC", Offset = "0x2C678DC", VA = "0x2C678DC")]
		protected void UpdateDecal()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2C678FC", Offset = "0x2C678FC", VA = "0x2C678FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x20BDCC", Offset = "0x20BDCC")]
		protected void ProjectBake()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2C6795C", Offset = "0x2C6795C", VA = "0x2C6795C")]
		public void LateUnbake()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2C63C7C", Offset = "0x2C63C7C", VA = "0x2C63C7C")]
		public void LateBake()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2C679B4", Offset = "0x2C679B4", VA = "0x2C679B4")]
		public void LateBake(uint frames)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2C67A58", Offset = "0x2C67A58", VA = "0x2C67A58")]
		internal Color GetFadeoutColor()
		{
			return default;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2C662B4", Offset = "0x2C662B4", VA = "0x2C662B4")]
		private void CallOnProjectionFinished(Mesh mesh)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2C64558", Offset = "0x2C64558", VA = "0x2C64558")]
		private void CallOnFadeOutStarted()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2C67A98", Offset = "0x2C67A98", VA = "0x2C67A98")]
		private void CallOnFadedOut()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2C67AF8", Offset = "0x2C67AF8", VA = "0x2C67AF8")]
		private void CallOnFadedIn()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2C62ED8", Offset = "0x2C62ED8", VA = "0x2C62ED8")]
		private void CallOnAtlasIndexChanged()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2C631F4", Offset = "0x2C631F4", VA = "0x2C631F4")]
		private void CallOnSourceChanged()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2C633B4", Offset = "0x2C633B4", VA = "0x2C633B4")]
		private void CallOnAlphaChanged()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2C67B58", Offset = "0x2C67B58", VA = "0x2C67B58")]
		public static EasyDecal Clone(EasyDecal decal)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2C67DB0", Offset = "0x2C67DB0", VA = "0x2C67DB0")]
		public static void CopyProperties(EasyDecal from, EasyDecal to)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2C6800C", Offset = "0x2C6800C", VA = "0x2C6800C")]
		public static void SetStaticProxyCollection(StaticProxyCollection proxyCollection)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2C6807C", Offset = "0x2C6807C", VA = "0x2C6807C")]
		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 forward, Vector3 up)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2C686C0", Offset = "0x2C686C0", VA = "0x2C686C0")]
		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2C687FC", Offset = "0x2C687FC", VA = "0x2C687FC")]
		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2C68968", Offset = "0x2C68968", VA = "0x2C68968")]
		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal, float rotation)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2C68AAC", Offset = "0x2C68AAC", VA = "0x2C68AAC")]
		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal, float rotation, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2C68C18", Offset = "0x2C68C18", VA = "0x2C68C18")]
		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2C68D48", Offset = "0x2C68D48", VA = "0x2C68D48")]
		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Vector3 normal)
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2C68E30", Offset = "0x2C68E30", VA = "0x2C68E30")]
		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Vector3 normal, float rotation)
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2C68F6C", Offset = "0x2C68F6C", VA = "0x2C68F6C")]
		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Ray ray)
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2C681EC", Offset = "0x2C681EC", VA = "0x2C681EC")]
		private static EasyDecal ProjectInternal(GameObject decalPrefab, GameObject parent, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2C6955C", Offset = "0x2C6955C", VA = "0x2C6955C")]
		private static List<EasyDecal> SearchChildren(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2C69060", Offset = "0x2C69060", VA = "0x2C69060")]
		private static bool ContainsLayer(LayerMask mask, int layer)
		{
			return default;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2C69920", Offset = "0x2C69920", VA = "0x2C69920")]
		public EasyDecal()
		{
		}
	}
}
