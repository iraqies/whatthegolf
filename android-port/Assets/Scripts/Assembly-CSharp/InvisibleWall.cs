using UnityEngine;

public class InvisibleWall : MonoBehaviour
{
	private Material localMaterial;

	public Color visibleColor;

	public Color invisibleColor;

	private float visibility;

	private void Start()
	{
		Renderer rend = GetComponent<Renderer>();
		if (rend != null)
		{
			localMaterial = rend.material;
			if (localMaterial != null)
				localMaterial.color = invisibleColor;
		}
		visibility = 0f;
	}

	private void Update()
	{
		visibility = Mathf.MoveTowards(visibility, 0f, Time.deltaTime);
		if (localMaterial != null)
			localMaterial.color = visibility > 0f ? visibleColor : invisibleColor;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		visibility = 0.3f;
	}
}
