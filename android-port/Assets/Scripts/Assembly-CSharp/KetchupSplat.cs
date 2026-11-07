using System.Collections.Generic;
using UnityEngine;

public class KetchupSplat : MonoBehaviour
{
	[SerializeField]
	private Camera _camera;

	[SerializeField]
	private bool shouldCount;

	[SerializeField]
	private Shader _drawShader;

	[SerializeField]
	private float TrackStrength;

	[SerializeField]
	private float TrackSize;

	private RenderTexture _splatMap;

	[SerializeField]
	private GameObject TargetPlane;

	private Material _snowMaterial;

	private Material _drawMaterial;

	private RaycastHit _hit;

	[SerializeField]
	private ParticleSystem PSystem;

	[SerializeField]
	private Color MainColor;

	[SerializeField]
	private int numCollisions;

	[SerializeField]
	private float collisionMinDist;

	private List<Vector2> collisions;

	private bool isDone;

	private bool shouldCheck;

	private float timer;

	private bool HasHit;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void Complete()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}
}
