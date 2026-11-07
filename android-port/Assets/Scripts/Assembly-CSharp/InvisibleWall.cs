using UnityEngine;

public class InvisibleWall : MonoBehaviour
{
	private Material localMaterial;

	public Color visibleColor;

	public Color invisibleColor;

	private float visibility;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
