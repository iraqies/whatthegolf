using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x20000B0")]
	[ExecuteInEditMode]
	public class Rope2D : MonoBehaviour
	{
		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x335EC", Offset = "0x335EC")]
		private sealed class _003CDelayedDestroy_003Ed__230 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rope2D _003C_003E4__this;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float p_initialDelay;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Renderer[] _003Cv_renderers_003E5__2;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float _003Cv_currentTime_003E5__3;

			[Token(Token = "0x170000BB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000497")]
				[Address(RVA = "0x1355C88", Offset = "0x1355C88", VA = "0x1355C88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000BC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000499")]
				[Address(RVA = "0x1355CD0", Offset = "0x1355CD0", VA = "0x1355CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x1355848", Offset = "0x1355848", VA = "0x1355848")]
			[DebuggerHidden]
			public _003CDelayedDestroy_003Ed__230(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1355874", Offset = "0x1355874", VA = "0x1355874", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1355878", Offset = "0x1355878", VA = "0x1355878", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1355C88", Offset = "0x1355C88", VA = "0x1355C88", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1355C90", Offset = "0x1355C90", VA = "0x1355C90", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1355CD0", Offset = "0x1355CD0", VA = "0x1355CD0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<Rope2D> OnRopeDestroyed;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Rope2D> OnRopeCreated;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<Rope2D, int> OnRopeBreak;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<Rope2D, int> OnRopeCut;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<Rope2D, float> OnRopeTensioned;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Rope2D[] s_allRopesInScene;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_objectA;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_objectB;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int m_amountOfNodes;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool m_autoCalculateAmountOfNodes;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject m_customNodePrefab;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_nodeMass;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_nodeDistanceOffSet;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite m_nodeSprite;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Material m_nodeMaterial;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 m_nodeSpriteGlobalSize;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector2 m_nodeLocalScale;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private JointColliderEnum m_jointCollider;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private bool m_userCanCutTheRope;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[SerializeField]
		private bool m_ropeCanBreak;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float m_breakAngle;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float m_ropeMaxSizeMultiplier;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject m_breakEffect;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string m_ropeSortingLayerName;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private int m_ropeDepth;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Material m_ropeMaterial;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool m_useLineRenderer;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AnimationCurve m_lineRendererCurveWidth;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int m_lineRendererEndCapVertices;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private int m_lineRendererCornerVertices;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private bool m_isSpringNode;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float m_springFrequency;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x34DA0", Offset = "0x34DA0")]
		private float m_springDampingValue;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private TensionHelperAddOptionEnum m_tensionHelperAddOption;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x34DF0", Offset = "0x34DF0")]
		private float m_tensionNormalizedTolerance;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private Color m_nonTensionedColor;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private Color m_tensionedColor;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		private bool m_useTensionColors;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		[SerializeField]
		private bool m_maxDistanceOnlyMode;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private RopeBreakActionEnum m_ropeBreakAction;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private float m_destroyTime;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool m_lowMassVariationWhenBroken;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		[SerializeField]
		private bool m_stableFirstAndLastNodes;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		private EditorRopeStyleEnum m_editorRopeStyle;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float m_nodeGravityScale;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private float m_nodeAngularDrag;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float m_nodeLinearDrag;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		private RigidbodyCollisionDetectionTypeEnum m_nodeCollisionDetectionType;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _nonTensionedRopeSize;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[SerializeField]
		private bool _needUpdateLineRenderer;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
		[SerializeField]
		private bool _needUpdateRope;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<GameObject> m_nodes;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private List<GameObject> m_chunks;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private AnchoredJoint2D _tensionHelper;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float _maxTimeToCheckRope;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private float _deltaTimeToCheckRope;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _ropeIsBroken;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private float _maxTimeToUpdateIsRopeIsBroken;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float _timeToUpdateIsRopeIsBroken;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float _nodeDistance;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float _nodeDistanceInGlobalScale;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector2 _nodeSize;

		[Token(Token = "0x1700008C")]
		public static Rope2D[] AllRopesInScene
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x13DF714", Offset = "0x13DF714", VA = "0x13DF714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public bool NeedUpdateRope
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x13DF778", Offset = "0x13DF778", VA = "0x13DF778")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x13DF780", Offset = "0x13DF780", VA = "0x13DF780")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		protected bool NeedUpdateLineRenderer
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x13DF794", Offset = "0x13DF794", VA = "0x13DF794")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x13DF79C", Offset = "0x13DF79C", VA = "0x13DF79C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public RopeBreakActionEnum RopeBreakAction
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x13DF7B0", Offset = "0x13DF7B0", VA = "0x13DF7B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x13DF7B8", Offset = "0x13DF7B8", VA = "0x13DF7B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public float DestroyTime
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x13DF7D0", Offset = "0x13DF7D0", VA = "0x13DF7D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x13DF7D8", Offset = "0x13DF7D8", VA = "0x13DF7D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public bool LowMassVariationWhenBroken
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x13DF7F0", Offset = "0x13DF7F0", VA = "0x13DF7F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x13DF7F8", Offset = "0x13DF7F8", VA = "0x13DF7F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public AnimationCurve LineRendererCurveWidth
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x13DF80C", Offset = "0x13DF80C", VA = "0x13DF80C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x13DF874", Offset = "0x13DF874", VA = "0x13DF874")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public int LineRendererEndCapVertices
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x13DF898", Offset = "0x13DF898", VA = "0x13DF898")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x13DF8A0", Offset = "0x13DF8A0", VA = "0x13DF8A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public int LineRendererCornerVertices
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x13DF8C4", Offset = "0x13DF8C4", VA = "0x13DF8C4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x13DF8CC", Offset = "0x13DF8CC", VA = "0x13DF8CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public virtual bool MaxDistanceOnlyMode
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x13DF8F0", Offset = "0x13DF8F0", VA = "0x13DF8F0", Slot = "4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x13DF8F8", Offset = "0x13DF8F8", VA = "0x13DF8F8", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public virtual GameObject ObjectA
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x13DF944", Offset = "0x13DF944", VA = "0x13DF944", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x13DF94C", Offset = "0x13DF94C", VA = "0x13DF94C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public virtual GameObject ObjectB
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x13DF9E8", Offset = "0x13DF9E8", VA = "0x13DF9E8", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x13DF9F0", Offset = "0x13DF9F0", VA = "0x13DF9F0", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public int AmountOfNodes
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x13DFA8C", Offset = "0x13DFA8C", VA = "0x13DFA8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x13DFA94", Offset = "0x13DFA94", VA = "0x13DFA94")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool AutoCalculateAmountOfNodes
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x13DFAB8", Offset = "0x13DFAB8", VA = "0x13DFAB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x13DFAC0", Offset = "0x13DFAC0", VA = "0x13DFAC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public GameObject CustomNodePrefab
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x13DFAE4", Offset = "0x13DFAE4", VA = "0x13DFAE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x13DFAEC", Offset = "0x13DFAEC", VA = "0x13DFAEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public RigidbodyCollisionDetectionTypeEnum NodeCollisionDetectionType
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x13DFB88", Offset = "0x13DFB88", VA = "0x13DFB88")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x13DFB90", Offset = "0x13DFB90", VA = "0x13DFB90")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public float NodeMass
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x13DFBB4", Offset = "0x13DFBB4", VA = "0x13DFBB4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x13DFBBC", Offset = "0x13DFBBC", VA = "0x13DFBBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public Sprite NodeSprite
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x13DFC10", Offset = "0x13DFC10", VA = "0x13DFC10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x13DFC18", Offset = "0x13DFC18", VA = "0x13DFC18")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public Material RopeMaterial
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x13E00F8", Offset = "0x13E00F8", VA = "0x13E00F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x13E0100", Offset = "0x13E0100", VA = "0x13E0100")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public Vector2 NodeSpriteGlobalSize
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x13E018C", Offset = "0x13E018C", VA = "0x13E018C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x13E0194", Offset = "0x13E0194", VA = "0x13E0194")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public Vector2 NodeLocalScale
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x13E02A4", Offset = "0x13E02A4", VA = "0x13E02A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x13E02AC", Offset = "0x13E02AC", VA = "0x13E02AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public float NodeDistanceOffSet
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x13E0354", Offset = "0x13E0354", VA = "0x13E0354")]
			get
			{
				return default;
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x13E035C", Offset = "0x13E035C", VA = "0x13E035C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public JointColliderEnum JointCollider
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x13E03A0", Offset = "0x13E03A0", VA = "0x13E03A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x13E03A8", Offset = "0x13E03A8", VA = "0x13E03A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public string RopeSortingLayerName
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x13E03CC", Offset = "0x13E03CC", VA = "0x13E03CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x13E03D4", Offset = "0x13E03D4", VA = "0x13E03D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public int RopeDepth
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x13E0438", Offset = "0x13E0438", VA = "0x13E0438")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x13E0440", Offset = "0x13E0440", VA = "0x13E0440")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public Material NodeMaterial
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x13E0490", Offset = "0x13E0490", VA = "0x13E0490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x13E0498", Offset = "0x13E0498", VA = "0x13E0498")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool UseLineRenderer
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x13E0524", Offset = "0x13E0524", VA = "0x13E0524")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x13E052C", Offset = "0x13E052C", VA = "0x13E052C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool UserCanCutTheRope
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x13E07BC", Offset = "0x13E07BC", VA = "0x13E07BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x13E07C4", Offset = "0x13E07C4", VA = "0x13E07C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public bool RopeCanBreak
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x13E07D8", Offset = "0x13E07D8", VA = "0x13E07D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x13E07E0", Offset = "0x13E07E0", VA = "0x13E07E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public float BreakAngle
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x13E07F4", Offset = "0x13E07F4", VA = "0x13E07F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x13E07FC", Offset = "0x13E07FC", VA = "0x13E07FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public float RopeMaxSizeMultiplier
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x13E0824", Offset = "0x13E0824", VA = "0x13E0824")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x13E082C", Offset = "0x13E082C", VA = "0x13E082C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public GameObject BreakEffect
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x13E0844", Offset = "0x13E0844", VA = "0x13E0844")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x13E084C", Offset = "0x13E084C", VA = "0x13E084C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public TensionHelperAddOptionEnum TensionHelperAddOption
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x13E08E8", Offset = "0x13E08E8", VA = "0x13E08E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x13E08F0", Offset = "0x13E08F0", VA = "0x13E08F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public float TensionNormalizedTolerance
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x13E0D7C", Offset = "0x13E0D7C", VA = "0x13E0D7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x13E0D84", Offset = "0x13E0D84", VA = "0x13E0D84")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public Color NonTensionedColor
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x13E0D9C", Offset = "0x13E0D9C", VA = "0x13E0D9C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x13E0DA8", Offset = "0x13E0DA8", VA = "0x13E0DA8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public Color TensionedColor
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x13E0E10", Offset = "0x13E0E10", VA = "0x13E0E10")]
			get
			{
				return default;
			}
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x13E0E1C", Offset = "0x13E0E1C", VA = "0x13E0E1C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool UseTensionColors
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x13E0E84", Offset = "0x13E0E84", VA = "0x13E0E84")]
			get
			{
				return default;
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x13E0E8C", Offset = "0x13E0E8C", VA = "0x13E0E8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool IsSpringNode
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x13E0EA0", Offset = "0x13E0EA0", VA = "0x13E0EA0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x13E0EA8", Offset = "0x13E0EA8", VA = "0x13E0EA8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public float SpringFrequency
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x13E0ECC", Offset = "0x13E0ECC", VA = "0x13E0ECC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x13E0ED4", Offset = "0x13E0ED4", VA = "0x13E0ED4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public float SpringDampingValue
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x13E0EFC", Offset = "0x13E0EFC", VA = "0x13E0EFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x13E0F04", Offset = "0x13E0F04", VA = "0x13E0F04")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public float NodeGravityScale
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x13E0F2C", Offset = "0x13E0F2C", VA = "0x13E0F2C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x13E0F34", Offset = "0x13E0F34", VA = "0x13E0F34")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public float NodeAngularDrag
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x13E0F5C", Offset = "0x13E0F5C", VA = "0x13E0F5C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x13E0F64", Offset = "0x13E0F64", VA = "0x13E0F64")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public float NodeLinearDrag
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x13E0F8C", Offset = "0x13E0F8C", VA = "0x13E0F8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x13E0F94", Offset = "0x13E0F94", VA = "0x13E0F94")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public bool StableFirstAndLastNodes
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x13E0FBC", Offset = "0x13E0FBC", VA = "0x13E0FBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x13E0FC4", Offset = "0x13E0FC4", VA = "0x13E0FC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public EditorRopeStyleEnum EditorRopeStyle
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x13E0FE8", Offset = "0x13E0FE8", VA = "0x13E0FE8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x13E0FF0", Offset = "0x13E0FF0", VA = "0x13E0FF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public List<GameObject> Nodes
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x13E1044", Offset = "0x13E1044", VA = "0x13E1044")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x13E10C0", Offset = "0x13E10C0", VA = "0x13E10C0")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public List<GameObject> Chunks
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x13E10D4", Offset = "0x13E10D4", VA = "0x13E10D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x13E1150", Offset = "0x13E1150", VA = "0x13E1150")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x13E1164", Offset = "0x13E1164", VA = "0x13E1164", Slot = "10")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x13E11A0", Offset = "0x13E11A0", VA = "0x13E11A0", Slot = "11")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x13E1334", Offset = "0x13E1334", VA = "0x13E1334", Slot = "12")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x13E1540", Offset = "0x13E1540", VA = "0x13E1540", Slot = "13")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x13E15B8", Offset = "0x13E15B8", VA = "0x13E15B8", Slot = "14")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x13E25A4", Offset = "0x13E25A4", VA = "0x13E25A4", Slot = "15")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x13E2720", Offset = "0x13E2720", VA = "0x13E2720", Slot = "16")]
		public virtual void UpdateEditorNodes()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x13E2724", Offset = "0x13E2724", VA = "0x13E2724", Slot = "17")]
		public virtual void DrawDebugGizmos()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x13E2728", Offset = "0x13E2728", VA = "0x13E2728")]
		public float GetTensionDelta()
		{
			return default;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x13E290C", Offset = "0x13E290C", VA = "0x13E290C")]
		public bool IsRopeTensioned()
		{
			return default;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x13E2990", Offset = "0x13E2990", VA = "0x13E2990")]
		protected void SetTensionColor(float p_lerpDelta)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x13E0A50", Offset = "0x13E0A50", VA = "0x13E0A50")]
		protected void CheckTension()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x13E31AC", Offset = "0x13E31AC", VA = "0x13E31AC")]
		protected void InsertTensionHelper()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x13E09B8", Offset = "0x13E09B8", VA = "0x13E09B8")]
		protected void DestroyTensionHelper()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x13E34CC", Offset = "0x13E34CC", VA = "0x13E34CC")]
		protected void CorrectNodeDistanceAndRotation(bool p_correctFirstAndLast, bool p_force = false)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x13E4074", Offset = "0x13E4074", VA = "0x13E4074", Slot = "18")]
		public virtual void CreateRope(bool p_clearNodes = true)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x13E67E8", Offset = "0x13E67E8", VA = "0x13E67E8", Slot = "19")]
		protected virtual void ApplyIgnoreRopeCollisionToAllNodes()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x13E6A80", Offset = "0x13E6A80", VA = "0x13E6A80", Slot = "20")]
		public virtual void AddAttachedScriptInPlugguedObjects()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x13E6DE0", Offset = "0x13E6DE0", VA = "0x13E6DE0", Slot = "21")]
		public virtual GameObject CreateNode(GameObject p_modelNode, Vector2 p_position, Quaternion p_rotation, GameObject p_connectedNode, GameObject p_chunk, [Optional] Sprite p_sprite, string p_name = "Node", float p_nodeMass = 0.05f, bool p_generateHingeJoint = true, bool p_isSpringJoint = true, bool p_generateDistanceOrSpringJoint = true)
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x13E769C", Offset = "0x13E769C", VA = "0x13E769C", Slot = "22")]
		public virtual GameObject CreateFirstNode(GameObject p_modelNode, Vector2 p_position, Quaternion p_rotation, GameObject p_chunk, [Optional] Sprite p_sprite)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x13E78D0", Offset = "0x13E78D0", VA = "0x13E78D0", Slot = "23")]
		public virtual GameObject CreateLastNode(GameObject p_modelNode, Vector2 p_position, Quaternion p_rotation, GameObject p_previusNode, GameObject p_chunk, [Optional] Sprite p_sprite)
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x13E7E64", Offset = "0x13E7E64", VA = "0x13E7E64")]
		protected bool BreakIfHaveNullNode()
		{
			return default;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x13E2108", Offset = "0x13E2108", VA = "0x13E2108")]
		protected void CheckIfConnectedObjectsExists()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x13E81D0", Offset = "0x13E81D0", VA = "0x13E81D0")]
		protected List<GameObject> GetConnectedObjects(GameObject p_object)
		{
			return null;
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x13E8484", Offset = "0x13E8484", VA = "0x13E8484")]
		protected bool RopeExceedMaxSize()
		{
			return default;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x13E88C4", Offset = "0x13E88C4", VA = "0x13E88C4")]
		protected bool ChunkExceedMaxSize(GameObject p_chunk)
		{
			return default;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x13E9360", Offset = "0x13E9360", VA = "0x13E9360")]
		protected bool NodeNeedBreak(GameObject p_object)
		{
			return default;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x13E3EB4", Offset = "0x13E3EB4", VA = "0x13E3EB4")]
		protected void ResetDeltaTimeToCheckIfRopeNeedBreak(float p_extraTime = 0f)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x13E9618", Offset = "0x13E9618", VA = "0x13E9618", Slot = "24")]
		protected virtual void CheckIfRopeNeedBreak()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x13E8048", Offset = "0x13E8048", VA = "0x13E8048")]
		protected void BreakNode(GameObject p_node)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x13E9D08", Offset = "0x13E9D08", VA = "0x13E9D08", Slot = "25")]
		protected virtual void BreakNode(int p_nodeIndex)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x13EA898", Offset = "0x13EA898", VA = "0x13EA898", Slot = "26")]
		protected virtual void SetNodesToLowMassVariation()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x13EAB3C", Offset = "0x13EAB3C", VA = "0x13EAB3C", Slot = "27")]
		protected virtual void SetNodesMaxDistanceOnly(bool p_active)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x13EAE2C", Offset = "0x13EAE2C", VA = "0x13EAE2C", Slot = "28")]
		protected virtual void StartRopeBreakAction()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x13EAED0", Offset = "0x13EAED0", VA = "0x13EAED0")]
		protected IEnumerator DelayedDestroy(float p_initialDelay)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x13EAF54", Offset = "0x13EAF54", VA = "0x13EAF54", Slot = "29")]
		protected virtual void StartBreakEffects(GameObject p_node)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x13EB14C", Offset = "0x13EB14C", VA = "0x13EB14C", Slot = "30")]
		public virtual bool CutNode(GameObject p_node, bool p_force = false)
		{
			return default;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x13E16A0", Offset = "0x13E16A0", VA = "0x13E16A0")]
		protected void UpdateRenderersVisibility()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x13E5E04", Offset = "0x13E5E04", VA = "0x13E5E04")]
		protected void StartLineRenderersInitialValues()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x13E18CC", Offset = "0x13E18CC", VA = "0x13E18CC")]
		protected void UpdateLineRenderersNodePosition()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x13E0554", Offset = "0x13E0554", VA = "0x13E0554")]
		protected void UpdateLineRendererVisibility()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x13EB54C", Offset = "0x13EB54C", VA = "0x13EB54C", Slot = "31")]
		public virtual GameObject CreateChunk(string p_name)
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x13EA614", Offset = "0x13EA614", VA = "0x13EA614")]
		public GameObject GetChunkByNodeIndex(int p_index)
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x13E8D30", Offset = "0x13E8D30", VA = "0x13E8D30")]
		public void GetFirstAndLastNodeIndexInChunk(out int p_firstIndex, out int p_lastIndex, GameObject p_chunk)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x13EB448", Offset = "0x13EB448", VA = "0x13EB448")]
		public LineRenderer GetLineRendererComponentByChunk(GameObject p_chunk)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x13E3034", Offset = "0x13E3034", VA = "0x13E3034")]
		public LineRenderer GetLineRendererComponentByChunk(int p_chunkIndex)
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x13EB2CC", Offset = "0x13EB2CC", VA = "0x13EB2CC")]
		public int GetNodesCountInChunk(int p_chunkIndex)
		{
			return default;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x13EB668", Offset = "0x13EB668", VA = "0x13EB668")]
		public int GetNodesCountInChunk(GameObject p_chunk)
		{
			return default;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x13EB930", Offset = "0x13EB930", VA = "0x13EB930", Slot = "32")]
		public virtual AnchoredJoint2D PlugDistanceOrSpringJoint(GameObject p_node1, GameObject p_node2, float p_distance, bool p_isSpringJoint, bool p_forceGenerateRigidbody = true)
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x13EBDA4", Offset = "0x13EBDA4", VA = "0x13EBDA4", Slot = "33")]
		public virtual HingeJoint2D PlugHingeJoint(GameObject p_nodeOwner, GameObject p_connectedObject, bool p_forceGenerateNew = true, bool p_plugInCenter = false, bool p_forceGenerateRigidbody = true)
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x13EC270", Offset = "0x13EC270", VA = "0x13EC270")]
		public List<GameObject> GetPluggedObjectsInRope()
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x13E6298", Offset = "0x13E6298", VA = "0x13E6298")]
		public void SendMessageToAllIndirectObjects(string p_functionToCall = "IndirectRopeDestroyed")
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x13E5578", Offset = "0x13E5578", VA = "0x13E5578")]
		public void DestroyRope()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x13EC334", Offset = "0x13EC334", VA = "0x13EC334")]
		public void RemoveObject()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x13EC388", Offset = "0x13EC388", VA = "0x13EC388")]
		public float GetRopeMass(bool p_multiplyByGravityScale = true)
		{
			return default;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x13EC7AC", Offset = "0x13EC7AC", VA = "0x13EC7AC")]
		public float GetMassAttachedToObject(GameObject p_object, bool p_multiplyByGravityScale = true)
		{
			return default;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x13EC550", Offset = "0x13EC550", VA = "0x13EC550")]
		public float GetChunkMass(GameObject p_chunk, bool p_multiplyByGravityScale = true)
		{
			return default;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x13ECC80", Offset = "0x13ECC80", VA = "0x13ECC80")]
		public void MarkToRecreateRope()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x13E27A8", Offset = "0x13E27A8", VA = "0x13E27A8")]
		public float GetCurrentRopeSize()
		{
			return default;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x13E8830", Offset = "0x13E8830", VA = "0x13E8830")]
		public float GetNonTensionedRopeSize()
		{
			return default;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x13E9028", Offset = "0x13E9028", VA = "0x13E9028")]
		public float GetNonTensionedChunkSize(GameObject p_chunk)
		{
			return default;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x13ECC94", Offset = "0x13ECC94", VA = "0x13ECC94", Slot = "34")]
		public virtual void RecalcAmountOfNodes()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x13E60DC", Offset = "0x13E60DC", VA = "0x13E60DC")]
		private void ActivatePluggedNodes()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x13E6C60", Offset = "0x13E6C60", VA = "0x13E6C60")]
		public GameObject GetAttachedObjectA()
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x13E6D20", Offset = "0x13E6D20", VA = "0x13E6D20")]
		public GameObject GetAttachedObjectB()
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x13E3F00", Offset = "0x13E3F00", VA = "0x13E3F00")]
		public Rigidbody2D GetRigidBody2DFromObject(GameObject p_object, bool p_searchInParent = true)
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x13E2E7C", Offset = "0x13E2E7C", VA = "0x13E2E7C")]
		public bool IsRopeBroken()
		{
			return default;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x13ECDA8", Offset = "0x13ECDA8", VA = "0x13ECDA8")]
		public bool AnyNodeIsBroken()
		{
			return default;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x13ECFD8", Offset = "0x13ECFD8", VA = "0x13ECFD8", Slot = "35")]
		protected virtual void CorrectValues()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x13ECFDC", Offset = "0x13ECFDC", VA = "0x13ECFDC", Slot = "36")]
		protected virtual void UpdateRopePosition()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x13ED1E0", Offset = "0x13ED1E0", VA = "0x13ED1E0", Slot = "37")]
		protected virtual void UpdateRopeSorting()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x13ED42C", Offset = "0x13ED42C", VA = "0x13ED42C", Slot = "38")]
		protected virtual void UpdateNodesSorting()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x13E3EE8", Offset = "0x13E3EE8", VA = "0x13E3EE8")]
		public float GetNodeDistance(bool p_inLocalScale = true)
		{
			return default;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x13E5500", Offset = "0x13E5500", VA = "0x13E5500")]
		public Vector2 GetNodeSize()
		{
			return default;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x13DFCBC", Offset = "0x13DFCBC", VA = "0x13DFCBC")]
		public void UpdateNodeBounds()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x13E5738", Offset = "0x13E5738", VA = "0x13E5738")]
		public void ClearChunks()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x13E5670", Offset = "0x13E5670", VA = "0x13E5670")]
		public void ClearNodes()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x13E1224", Offset = "0x13E1224", VA = "0x13E1224")]
		public static void RegisterRopeInScene(Rope2D p_rope)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x13E142C", Offset = "0x13E142C", VA = "0x13E142C")]
		public static void UnregisterRopeFromScene(Rope2D p_rope)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x13DF7CC", Offset = "0x13DF7CC", VA = "0x13DF7CC")]
		protected void RecordObject()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x13ED7D0", Offset = "0x13ED7D0", VA = "0x13ED7D0")]
		public Rope2D()
		{
		}
	}
}
