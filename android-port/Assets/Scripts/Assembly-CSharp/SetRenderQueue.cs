using UnityEngine;

public class SetRenderQueue : MonoBehaviour
{
	[SerializeField]
	protected int[] m_queues = new int[1] { 3000 };

	protected void Awake()
	{
		Renderer rend = GetComponent<Renderer>();
		if (rend == null || m_queues == null)
		{
			return;
		}
		Material[] materials = rend.materials;
		for (int i = 0; i < materials.Length && i < m_queues.Length; i++)
		{
			if (materials[i] != null)
			{
				materials[i].renderQueue = m_queues[i];
			}
		}
	}
}
