using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KetchupSplat : MonoBehaviour
{
	[SerializeField]
	private Camera _camera;

	[SerializeField]
	private bool shouldCount = true;

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
	private int numCollisions = 1;

	[SerializeField]
	private float collisionMinDist = 2f;

	private List<Vector2> collisions = new List<Vector2>();

	private bool isDone;

	private bool shouldCheck;

	private float timer;

	private bool HasHit;

	private void Start()
	{
		if (_drawShader != null)
		{
			_drawMaterial = new Material(_drawShader);
			_drawMaterial.SetVector("_Color", Color.white);
			_drawMaterial.SetFloat("_Strength", TrackStrength);
			_drawMaterial.SetFloat("_Size", TrackSize);
		}
		if (TargetPlane != null)
		{
			MeshRenderer component = TargetPlane.GetComponent<MeshRenderer>();
			if (component != null)
			{
				_snowMaterial = component.material;
				_splatMap = new RenderTexture(1024, 1024, 0, RenderTextureFormat.ARGBFloat);
				_snowMaterial.SetTexture("_Splat", _splatMap);
				_snowMaterial.SetColor("_KetchupColor", MainColor);
			}
		}
	}

	private void FixedUpdate()
	{
		if (HasHit && _splatMap != null && _drawMaterial != null)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(_splatMap.width, _splatMap.height, 0, RenderTextureFormat.ARGBFloat);
			Graphics.Blit(_splatMap, temporary);
			Graphics.Blit(temporary, _splatMap, _drawMaterial);
			RenderTexture.ReleaseTemporary(temporary);
		}
	}

	private void Update()
	{
		if (shouldCheck && !isDone && shouldCount && collisions != null && collisions.Count >= numCollisions)
		{
			Complete();
		}
	}

	private void Complete()
	{
		isDone = true;
		ActionAfterNumEvents actionAfterNumEvents = Object.FindObjectOfType<ActionAfterNumEvents>();
		if (actionAfterNumEvents != null)
		{
			actionAfterNumEvents.Tick();
		}
	}

	private void OnDrawGizmos()
	{
		if (isDone)
		{
			Gizmos.DrawSphere(base.transform.position, 3f);
		}
	}

	private void OnParticleCollision(GameObject other)
	{
		if (PSystem == null || TargetPlane == null)
		{
			return;
		}
		List<ParticleCollisionEvent> list = new List<ParticleCollisionEvent>();
		PSystem.GetCollisionEvents(TargetPlane, list);
		foreach (ParticleCollisionEvent e in list)
		{
			if (!Physics.Raycast(e.intersection - Vector3.forward, Vector3.forward, out _hit))
			{
				continue;
			}
			if (_drawMaterial != null)
			{
				Vector2 textureCoord = _hit.textureCoord;
				_drawMaterial.SetVector("_Coordinate", new Vector4(textureCoord.x, textureCoord.y, 0f, 0f));
			}
			shouldCheck = true;
			HasHit = true;
			if (collisions != null && !collisions.Any((Vector2 c) => Vector2.Distance(c, e.intersection) <= collisionMinDist))
			{
				collisions.Add(e.intersection);
			}
		}
	}
}
