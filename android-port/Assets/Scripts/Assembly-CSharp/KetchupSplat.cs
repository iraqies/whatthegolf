using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000361")]
public class KetchupSplat : MonoBehaviour
{
	[Token(Token = "0x2000362")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F2DC", Offset = "0x3F2DC")]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x40012A6")]
		[FieldOffset(Offset = "0x10")]
		public ParticleCollisionEvent collision;

		[Token(Token = "0x40012A7")]
		[FieldOffset(Offset = "0x38")]
		public KetchupSplat _003C_003E4__this;

		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x17CCDFC", Offset = "0x17CCDFC", VA = "0x17CCDFC")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x17CCE04", Offset = "0x17CCE04", VA = "0x17CCE04")]
		internal bool _003COnParticleCollision_003Eb__0(Vector2 c)
		{
			return default;
		}
	}

	[Token(Token = "0x4001293")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera _camera;

	[Token(Token = "0x4001294")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool shouldCount;

	[Token(Token = "0x4001295")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Shader _drawShader;

	[Token(Token = "0x4001296")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float TrackStrength;

	[Token(Token = "0x4001297")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float TrackSize;

	[Token(Token = "0x4001298")]
	[FieldOffset(Offset = "0x38")]
	private RenderTexture _splatMap;

	[Token(Token = "0x4001299")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject TargetPlane;

	[Token(Token = "0x400129A")]
	[FieldOffset(Offset = "0x48")]
	private Material _snowMaterial;

	[Token(Token = "0x400129B")]
	[FieldOffset(Offset = "0x50")]
	private Material _drawMaterial;

	[Token(Token = "0x400129C")]
	[FieldOffset(Offset = "0x58")]
	private RaycastHit _hit;

	[Token(Token = "0x400129D")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private ParticleSystem PSystem;

	[Token(Token = "0x400129E")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Color MainColor;

	[Token(Token = "0x400129F")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private int numCollisions;

	[Token(Token = "0x40012A0")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float collisionMinDist;

	[Token(Token = "0x40012A1")]
	[FieldOffset(Offset = "0xA8")]
	private List<Vector2> collisions;

	[Token(Token = "0x40012A2")]
	[FieldOffset(Offset = "0xB0")]
	private bool isDone;

	[Token(Token = "0x40012A3")]
	[FieldOffset(Offset = "0xB1")]
	private bool shouldCheck;

	[Token(Token = "0x40012A4")]
	[FieldOffset(Offset = "0xB4")]
	private float timer;

	[Token(Token = "0x40012A5")]
	[FieldOffset(Offset = "0xB8")]
	private bool HasHit;

	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0x14FDCE0", Offset = "0x14FDCE0", VA = "0x14FDCE0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0x14FDEA8", Offset = "0x14FDEA8", VA = "0x14FDEA8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x14FDFAC", Offset = "0x14FDFAC", VA = "0x14FDFAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x14FE088", Offset = "0x14FE088", VA = "0x14FE088")]
	private void Complete()
	{
	}

	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0x14FE11C", Offset = "0x14FE11C", VA = "0x14FE11C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x14FE160", Offset = "0x14FE160", VA = "0x14FE160")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x14FE548", Offset = "0x14FE548", VA = "0x14FE548")]
	public KetchupSplat()
	{
	}
}
