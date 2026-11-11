using UnityEngine;
using UnityEngine.Events;

public class OnCatapultedByCarpet : MonoBehaviour
{
	[SerializeField]
	private UnityEvent _onCatapulted;

	public void Catapult()
	{
		_onCatapulted?.Invoke();
	}
}
