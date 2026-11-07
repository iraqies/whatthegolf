using Core;
using UnityEngine;
using UnityEngine.Events;

public class ExplodableCliffLivingThings : MonoBehaviour, IExplodable
{
	[SerializeField]
	private UnityEvent _OnExplode;

	public void OnExplode()
	{
	}
}
