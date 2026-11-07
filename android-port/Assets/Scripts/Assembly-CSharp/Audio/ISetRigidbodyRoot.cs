using UnityEngine;

namespace Audio
{
	public interface ISetRigidbodyRoot
	{
		GameObject GetRoot { get; }

		void SetRoot(GameObject gameObject);
	}
}
