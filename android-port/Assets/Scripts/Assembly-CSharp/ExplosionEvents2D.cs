using UnityEngine;
using UnityEngine.Events;

public class ExplosionEvents2D : MonoBehaviour
{
	[SerializeField]
	private UnityEvent _onExplode;

	private void Start()
	{
	}

	public void OnExplode(Collider2D obj)
	{
	}
}
