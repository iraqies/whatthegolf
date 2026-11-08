using UnityEngine;

public class InvisibleCullingObject : MonoBehaviour
{
	public delegate void OnVisibleDelegate();

	public OnVisibleDelegate OnVisible;
	public OnVisibleDelegate OnInvisible;

	private void OnBecameVisible()
	{
		OnVisible?.Invoke();
	}

	private void OnBecameInvisible()
	{
		OnInvisible?.Invoke();
	}
}
