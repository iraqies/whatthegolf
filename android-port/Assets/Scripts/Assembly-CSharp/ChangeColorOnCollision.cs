using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
	public Renderer RendererToChange;

	public Color Color;

	public LayerMask HitLayer;

	private void OnCollisionEnter(Collision other)
	{
	}
}
