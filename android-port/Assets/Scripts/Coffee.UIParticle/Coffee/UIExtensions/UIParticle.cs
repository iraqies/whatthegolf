using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[Token(Token = "0x2000002")]
	[ExecuteInEditMode]
	public class UIParticle : MaskableGraphic
	{
		[Serializable]
		[Token(Token = "0x2000003")]
		public class AnimatableProperty : ISerializationCallbackReceiver
		{
			[Token(Token = "0x2000004")]
			public enum ShaderPropertyType
			{
				[Token(Token = "0x4000017")]
				Color = 0,
				[Token(Token = "0x4000018")]
				Vector = 1,
				[Token(Token = "0x4000019")]
				Float = 2,
				[Token(Token = "0x400001A")]
				Range = 3,
				[Token(Token = "0x400001B")]
				Texture = 4
			}

			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string m_Name;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private ShaderPropertyType m_Type;

			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A6BC", Offset = "0x7A6BC")]
			private int id__BackingField;

			[Token(Token = "0x17000008")]
			public int id
			{
				[Token(Token = "0x6000019")]
				[Address(RVA = "0x1914F70", Offset = "0x1914F70", VA = "0x1914F70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A6CC", Offset = "0x7A6CC")]
				get
				{
					return default;
				}
				[Token(Token = "0x600001A")]
				[Address(RVA = "0x1914F78", Offset = "0x1914F78", VA = "0x1914F78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A6DC", Offset = "0x7A6DC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000009")]
			public ShaderPropertyType type
			{
				[Token(Token = "0x600001B")]
				[Address(RVA = "0x1914F80", Offset = "0x1914F80", VA = "0x1914F80")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1914F88", Offset = "0x1914F88", VA = "0x1914F88", Slot = "4")]
			public void OnBeforeSerialize()
			{
			}

			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1914F8C", Offset = "0x1914F8C", VA = "0x1914F8C", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1914FB8", Offset = "0x1914FB8", VA = "0x1914FB8")]
			public AnimatableProperty()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7A61C", Offset = "0x7A61C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<UIParticle> _003C_003E9__46_0;

			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1914EF8", Offset = "0x1914EF8", VA = "0x1914EF8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0x1914F00", Offset = "0x1914F00", VA = "0x1914F00")]
			internal bool _003CSetParent_003Eb__46_0(UIParticle x)
			{
				return default;
			}
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int s_IdMainTex;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<Vector3> s_Vertices;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<UIParticle> s_TempRelatables;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<UIParticle> s_ActiveParticles;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIParticle m_TrailParticle;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private bool m_IsTrail;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private float m_Scale;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool m_IgnoreParent;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private AnimatableProperty[] m_AnimatableProperties;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		private static MaterialPropertyBlock s_Mpb;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0xF8")]
		private Mesh _mesh;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x100")]
		private ParticleSystemRenderer _renderer;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x108")]
		private UIParticle _parent;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x110")]
		private List<UIParticle> _children;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x118")]
		private Matrix4x4 scaleaMatrix;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 _oldPos;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x28")]
		private static ParticleSystem.Particle[] s_Particles;

		[Token(Token = "0x17000001")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x1911D44", Offset = "0x1911D44", VA = "0x1911D44", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public override Material material
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x191203C", Offset = "0x191203C", VA = "0x191203C", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x1912100", Offset = "0x1912100", VA = "0x1912100", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float scale
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x1912270", Offset = "0x1912270", VA = "0x1912270")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1912304", Offset = "0x1912304", VA = "0x1912304")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public bool ignoreParent
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x191230C", Offset = "0x191230C", VA = "0x191230C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1912314", Offset = "0x1912314", VA = "0x1912314")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool isRoot
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1912334", Offset = "0x1912334", VA = "0x1912334")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000006")]
		public override bool raycastTarget
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x19123B4", Offset = "0x19123B4", VA = "0x19123B4", Slot = "24")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x19123BC", Offset = "0x19123BC", VA = "0x19123BC", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public ParticleSystem cachedParticleSystem
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1911F90", Offset = "0x1911F90", VA = "0x1911F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x19123C4", Offset = "0x19123C4", VA = "0x19123C4", Slot = "55")]
		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x19124C4", Offset = "0x19124C4", VA = "0x19124C4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1912BB4", Offset = "0x1912BB4", VA = "0x1912BB4", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x19130B0", Offset = "0x19130B0", VA = "0x19130B0", Slot = "41")]
		protected override void UpdateGeometry()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x19130B4", Offset = "0x19130B4", VA = "0x19130B4", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x19131F4", Offset = "0x19131F4", VA = "0x19131F4", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x19131F8", Offset = "0x19131F8", VA = "0x19131F8")]
		private static void UpdateMeshes()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x191337C", Offset = "0x191337C", VA = "0x191337C")]
		private void UpdateMesh()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1912920", Offset = "0x1912920", VA = "0x1912920")]
		private void CheckTrail()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1912DA8", Offset = "0x1912DA8", VA = "0x1912DA8")]
		private void SetParent(UIParticle newParent)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x19142DC", Offset = "0x19142DC", VA = "0x19142DC")]
		private void UpdateAnimatableMaterialProperties()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x19145D0", Offset = "0x19145D0", VA = "0x19145D0")]
		public UIParticle()
		{
		}
	}
}
