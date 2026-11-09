using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UIParticles : MaskableGraphic
{
	public Texture particleTexture;

	public Sprite particleSprite;

	private Transform _transform;

	private ParticleSystem _particleSystem;

	private ParticleSystem.Particle[] _particles;

	private UIVertex[] _quad;

	private Vector4 _uv;

	private ParticleSystem.TextureSheetAnimationModule _textureSheetAnimation;

	private int _textureSheetAnimationFrames;

	private Vector2 _textureSheedAnimationFrameSize;

	public override Texture mainTexture => null;

	protected bool Initialize()
	{
		return false;
	}

	protected override void Awake()
	{
		base.Awake();
	}

	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	private void Update()
	{
	}
}
