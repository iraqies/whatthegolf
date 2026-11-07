using UnityEngine;
using UnityEngine.Events;

public class FlagHitCheck : MonoBehaviour
{
	public GlobalBool globalBoolScript;

	public UnityEvent OnHit;

	private void OnCollisionEnter(Collision collision)
	{
	}
}
