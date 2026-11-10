using UnityEngine;
using UnityEngine.Events;

public class ExplosionEvents2D : MonoBehaviour
{
	[SerializeField]
	private UnityEvent _onExplode;

	private void Start()
	{
		ExplosionBarrel2D barrel = GetComponent<ExplosionBarrel2D>();
		if (barrel != null)
		{
			barrel.OnExplode -= OnExplode;
			barrel.OnExplode += OnExplode;
		}
	}

	public void OnExplode(Collider2D obj)
	{
		_onExplode?.Invoke();
	}
}
