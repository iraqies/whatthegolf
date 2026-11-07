using Core;
using UnityEngine;
using UnityEngine.Events;

public class ExplosionEvents : MonoBehaviour, IExplodable
{
	public UnityEvent OnExplosion;

	public void OnExplode()
	{
	}
}
