using UnityEngine;

public class InvisibleCullingObject : MonoBehaviour
{
	public delegate void OnVisibleDelegate();

	public OnVisibleDelegate OnVisible;

	public OnVisibleDelegate OnInvisible;

	private void OnBecameVisible()
	{
	}

	private void OnBecameInvisible()
	{
	}
}
