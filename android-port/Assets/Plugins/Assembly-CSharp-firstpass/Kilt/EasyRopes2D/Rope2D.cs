using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[ExecuteInEditMode]
	public class Rope2D : MonoBehaviour
	{
		public Action<Rope2D> OnRopeDestroyed;

		public Action<Rope2D> OnRopeCreated;

		public Action<Rope2D, int> OnRopeBreak;

		public Action<Rope2D, int> OnRopeCut;

		public Action<Rope2D, float> OnRopeTensioned;

		public static Rope2D[] s_allRopesInScene;

		[SerializeField]
		private GameObject m_objectA;

		[SerializeField]
		private GameObject m_objectB;

		[SerializeField]
		private int m_amountOfNodes;

		[SerializeField]
		private bool m_autoCalculateAmountOfNodes;

		[SerializeField]
		private GameObject m_customNodePrefab;

		[SerializeField]
		private float m_nodeMass;

		[SerializeField]
		private float m_nodeDistanceOffSet;

		[SerializeField]
		private Sprite m_nodeSprite;

		[SerializeField]
		private Material m_nodeMaterial;

		[SerializeField]
		private Vector2 m_nodeSpriteGlobalSize;

		[SerializeField]
		private Vector2 m_nodeLocalScale;

		[SerializeField]
		private JointColliderEnum m_jointCollider;

		[SerializeField]
		private bool m_userCanCutTheRope;

		[SerializeField]
		private bool m_ropeCanBreak;

		[SerializeField]
		private float m_breakAngle;

		[SerializeField]
		private float m_ropeMaxSizeMultiplier;

		[SerializeField]
		private GameObject m_breakEffect;

		[SerializeField]
		private string m_ropeSortingLayerName;

		[SerializeField]
		private int m_ropeDepth;

		[SerializeField]
		private Material m_ropeMaterial;

		[SerializeField]
		private bool m_useLineRenderer;

		[SerializeField]
		private AnimationCurve m_lineRendererCurveWidth;

		[SerializeField]
		private int m_lineRendererEndCapVertices;

		[SerializeField]
		private int m_lineRendererCornerVertices;

		[SerializeField]
		private bool m_isSpringNode;

		[SerializeField]
		private float m_springFrequency;

		[SerializeField]
		private float m_springDampingValue;

		[SerializeField]
		private TensionHelperAddOptionEnum m_tensionHelperAddOption;

		[SerializeField]
		private float m_tensionNormalizedTolerance;

		[SerializeField]
		private Color m_nonTensionedColor;

		[SerializeField]
		private Color m_tensionedColor;

		[SerializeField]
		private bool m_useTensionColors;

		[SerializeField]
		private bool m_maxDistanceOnlyMode;

		[SerializeField]
		private RopeBreakActionEnum m_ropeBreakAction;

		[SerializeField]
		private float m_destroyTime;

		[SerializeField]
		private bool m_lowMassVariationWhenBroken;

		[SerializeField]
		private bool m_stableFirstAndLastNodes;

		[SerializeField]
		private EditorRopeStyleEnum m_editorRopeStyle;

		[SerializeField]
		private float m_nodeGravityScale;

		[SerializeField]
		private float m_nodeAngularDrag;

		[SerializeField]
		private float m_nodeLinearDrag;

		[SerializeField]
		private RigidbodyCollisionDetectionTypeEnum m_nodeCollisionDetectionType;

		private float _nonTensionedRopeSize;

		[SerializeField]
		private bool _needUpdateLineRenderer;

		[SerializeField]
		private bool _needUpdateRope;

		[SerializeField]
		private List<GameObject> m_nodes;

		[SerializeField]
		private List<GameObject> m_chunks;

		private AnchoredJoint2D _tensionHelper;

		private float _maxTimeToCheckRope;

		private float _deltaTimeToCheckRope;

		private bool _ropeIsBroken;

		private float _maxTimeToUpdateIsRopeIsBroken;

		private float _timeToUpdateIsRopeIsBroken;

		private float _nodeDistance;

		private float _nodeDistanceInGlobalScale;

		private Vector2 _nodeSize;

		public static Rope2D[] AllRopesInScene => null;

		public bool NeedUpdateRope
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		protected bool NeedUpdateLineRenderer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RopeBreakActionEnum RopeBreakAction
		{
			get
			{
				return RopeBreakActionEnum.Nothing;
			}
			set
			{
			}
		}

		public float DestroyTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool LowMassVariationWhenBroken
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AnimationCurve LineRendererCurveWidth
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int LineRendererEndCapVertices
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int LineRendererCornerVertices
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual bool MaxDistanceOnlyMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual GameObject ObjectA
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual GameObject ObjectB
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int AmountOfNodes
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool AutoCalculateAmountOfNodes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GameObject CustomNodePrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RigidbodyCollisionDetectionTypeEnum NodeCollisionDetectionType
		{
			get
			{
				return RigidbodyCollisionDetectionTypeEnum.Discrete;
			}
			set
			{
			}
		}

		public float NodeMass
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Sprite NodeSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material RopeMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 NodeSpriteGlobalSize
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector2 NodeLocalScale
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public float NodeDistanceOffSet
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public JointColliderEnum JointCollider
		{
			get
			{
				return JointColliderEnum.Circle;
			}
			set
			{
			}
		}

		public string RopeSortingLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int RopeDepth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Material NodeMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseLineRenderer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UserCanCutTheRope
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RopeCanBreak
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float BreakAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RopeMaxSizeMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public GameObject BreakEffect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TensionHelperAddOptionEnum TensionHelperAddOption
		{
			get
			{
				return TensionHelperAddOptionEnum.AddInFirstAndLastNode;
			}
			set
			{
			}
		}

		public float TensionNormalizedTolerance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color NonTensionedColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Color TensionedColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public bool UseTensionColors
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsSpringNode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float SpringFrequency
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SpringDampingValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float NodeGravityScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float NodeAngularDrag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float NodeLinearDrag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool StableFirstAndLastNodes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public EditorRopeStyleEnum EditorRopeStyle
		{
			get
			{
				return EditorRopeStyleEnum.Gizmos;
			}
			set
			{
			}
		}

		public List<GameObject> Nodes
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public List<GameObject> Chunks
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected virtual void OnDrawGizmos()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public virtual void UpdateEditorNodes()
		{
		}

		public virtual void DrawDebugGizmos()
		{
		}

		public float GetTensionDelta()
		{
			return 0f;
		}

		public bool IsRopeTensioned()
		{
			return false;
		}

		protected void SetTensionColor(float p_lerpDelta)
		{
		}

		protected void CheckTension()
		{
		}

		protected void InsertTensionHelper()
		{
		}

		protected void DestroyTensionHelper()
		{
		}

		protected void CorrectNodeDistanceAndRotation(bool p_correctFirstAndLast, bool p_force = false)
		{
		}

		public virtual void CreateRope(bool p_clearNodes = true)
		{
		}

		protected virtual void ApplyIgnoreRopeCollisionToAllNodes()
		{
		}

		public virtual void AddAttachedScriptInPlugguedObjects()
		{
		}

		public virtual GameObject CreateNode(GameObject p_modelNode, Vector2 p_position, Quaternion p_rotation, GameObject p_connectedNode, GameObject p_chunk, Sprite p_sprite = null, string p_name = "Node", float p_nodeMass = 0.05f, bool p_generateHingeJoint = true, bool p_isSpringJoint = true, bool p_generateDistanceOrSpringJoint = true)
		{
			return null;
		}

		public virtual GameObject CreateFirstNode(GameObject p_modelNode, Vector2 p_position, Quaternion p_rotation, GameObject p_chunk, Sprite p_sprite = null)
		{
			return null;
		}

		public virtual GameObject CreateLastNode(GameObject p_modelNode, Vector2 p_position, Quaternion p_rotation, GameObject p_previusNode, GameObject p_chunk, Sprite p_sprite = null)
		{
			return null;
		}

		protected bool BreakIfHaveNullNode()
		{
			return false;
		}

		protected void CheckIfConnectedObjectsExists()
		{
		}

		protected List<GameObject> GetConnectedObjects(GameObject p_object)
		{
			return null;
		}

		protected bool RopeExceedMaxSize()
		{
			return false;
		}

		protected bool ChunkExceedMaxSize(GameObject p_chunk)
		{
			return false;
		}

		protected bool NodeNeedBreak(GameObject p_object)
		{
			return false;
		}

		protected void ResetDeltaTimeToCheckIfRopeNeedBreak(float p_extraTime = 0f)
		{
		}

		protected virtual void CheckIfRopeNeedBreak()
		{
		}

		protected void BreakNode(GameObject p_node)
		{
		}

		protected virtual void BreakNode(int p_nodeIndex)
		{
		}

		protected virtual void SetNodesToLowMassVariation()
		{
		}

		protected virtual void SetNodesMaxDistanceOnly(bool p_active)
		{
		}

		protected virtual void StartRopeBreakAction()
		{
		}

		protected IEnumerator DelayedDestroy(float p_initialDelay)
		{
			return null;
		}

		protected virtual void StartBreakEffects(GameObject p_node)
		{
		}

		public virtual bool CutNode(GameObject p_node, bool p_force = false)
		{
			return false;
		}

		protected void UpdateRenderersVisibility()
		{
		}

		protected void StartLineRenderersInitialValues()
		{
		}

		protected void UpdateLineRenderersNodePosition()
		{
		}

		protected void UpdateLineRendererVisibility()
		{
		}

		public virtual GameObject CreateChunk(string p_name)
		{
			return null;
		}

		public GameObject GetChunkByNodeIndex(int p_index)
		{
			return null;
		}

		public void GetFirstAndLastNodeIndexInChunk(out int p_firstIndex, out int p_lastIndex, GameObject p_chunk)
		{
			p_firstIndex = default;
			p_lastIndex = default;
		}

		public LineRenderer GetLineRendererComponentByChunk(GameObject p_chunk)
		{
			return null;
		}

		public LineRenderer GetLineRendererComponentByChunk(int p_chunkIndex)
		{
			return null;
		}

		public int GetNodesCountInChunk(int p_chunkIndex)
		{
			return 0;
		}

		public int GetNodesCountInChunk(GameObject p_chunk)
		{
			return 0;
		}

		public virtual AnchoredJoint2D PlugDistanceOrSpringJoint(GameObject p_node1, GameObject p_node2, float p_distance, bool p_isSpringJoint, bool p_forceGenerateRigidbody = true)
		{
			return null;
		}

		public virtual HingeJoint2D PlugHingeJoint(GameObject p_nodeOwner, GameObject p_connectedObject, bool p_forceGenerateNew = true, bool p_plugInCenter = false, bool p_forceGenerateRigidbody = true)
		{
			return null;
		}

		public List<GameObject> GetPluggedObjectsInRope()
		{
			return null;
		}

		public void SendMessageToAllIndirectObjects(string p_functionToCall = "IndirectRopeDestroyed")
		{
		}

		public void DestroyRope()
		{
		}

		public void RemoveObject()
		{
		}

		public float GetRopeMass(bool p_multiplyByGravityScale = true)
		{
			return 0f;
		}

		public float GetMassAttachedToObject(GameObject p_object, bool p_multiplyByGravityScale = true)
		{
			return 0f;
		}

		public float GetChunkMass(GameObject p_chunk, bool p_multiplyByGravityScale = true)
		{
			return 0f;
		}

		public void MarkToRecreateRope()
		{
		}

		public float GetCurrentRopeSize()
		{
			return 0f;
		}

		public float GetNonTensionedRopeSize()
		{
			return 0f;
		}

		public float GetNonTensionedChunkSize(GameObject p_chunk)
		{
			return 0f;
		}

		public virtual void RecalcAmountOfNodes()
		{
		}

		private void ActivatePluggedNodes()
		{
		}

		public GameObject GetAttachedObjectA()
		{
			return null;
		}

		public GameObject GetAttachedObjectB()
		{
			return null;
		}

		public Rigidbody2D GetRigidBody2DFromObject(GameObject p_object, bool p_searchInParent = true)
		{
			return null;
		}

		public bool IsRopeBroken()
		{
			return false;
		}

		public bool AnyNodeIsBroken()
		{
			return false;
		}

		protected virtual void CorrectValues()
		{
		}

		protected virtual void UpdateRopePosition()
		{
		}

		protected virtual void UpdateRopeSorting()
		{
		}

		protected virtual void UpdateNodesSorting()
		{
		}

		public float GetNodeDistance(bool p_inLocalScale = true)
		{
			return 0f;
		}

		public Vector2 GetNodeSize()
		{
			return default;
		}

		public void UpdateNodeBounds()
		{
		}

		public void ClearChunks()
		{
		}

		public void ClearNodes()
		{
		}

		public static void RegisterRopeInScene(Rope2D p_rope)
		{
		}

		public static void UnregisterRopeFromScene(Rope2D p_rope)
		{
		}

		protected void RecordObject()
		{
		}
	}
}
