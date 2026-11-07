using UnityEngine;

public class Cat : MonoBehaviour
{
	public string CatId;

	[SerializeField]
	public Collectable collectable;

	[SerializeField]
	private TipObject tipObject;
}
