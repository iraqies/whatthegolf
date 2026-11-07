using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode]
	public class UIParticle : MaskableGraphic
	{
		[Serializable]
		public class AnimatableProperty : ISerializationCallbackReceiver
		{
			public enum ShaderPropertyType
			{
				Color = 0,
				Vector = 1,
				Float = 2,
				Range = 3,
				Texture = 4
			}

			[SerializeField]
			private string m_Name;

			[SerializeField]
			private ShaderPropertyType m_Type;

			public int id { get; private set; }

			public ShaderPropertyType type => ShaderPropertyType.Color;

			public void OnBeforeSerialize()
			{
			}

			public void OnAfterDeserialize()
			{
			}
		}

		private static readonly int s_IdMainTex;

		private static readonly List<Vector3> s_Vertices;

		private static readonly List<UIParticle> s_TempRelatables;

		private static readonly List<UIParticle> s_ActiveParticles;

		[SerializeField]
		private ParticleSystem m_ParticleSystem;

		[SerializeField]
		private UIParticle m_TrailParticle;

		[SerializeField]
		private bool m_IsTrail;

		[SerializeField]
		private float m_Scale;

		[SerializeField]
		private bool m_IgnoreParent;

		[SerializeField]
		private AnimatableProperty[] m_AnimatableProperties;

		private static MaterialPropertyBlock s_Mpb;

		private Mesh _mesh;

		private ParticleSystemRenderer _renderer;

		private UIParticle _parent;

		private List<UIParticle> _children;

		private Matrix4x4 scaleaMatrix;

		private Vector3 _oldPos;

		private static ParticleSystem.Particle[] s_Particles;

		public override Texture mainTexture => null;

		public override Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ignoreParent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isRoot => false;

		public override bool raycastTarget
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ParticleSystem cachedParticleSystem => null;

		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void UpdateGeometry()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		private static void UpdateMeshes()
		{
		}

		private void UpdateMesh()
		{
		}

		private void CheckTrail()
		{
		}

		private void SetParent(UIParticle newParent)
		{
		}

		private void UpdateAnimatableMaterialProperties()
		{
		}
	}
}
