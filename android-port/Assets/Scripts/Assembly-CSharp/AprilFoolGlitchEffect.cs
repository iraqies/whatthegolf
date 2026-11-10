using System.Collections;
using UnityEngine;

public class AprilFoolGlitchEffect : MonoBehaviour
{
	[SerializeField]
	private Transform m_originalVisualsTransform;

	[SerializeField]
	private GameObject[] m_listOfBreadToActivate;

	[SerializeField]
	private GameObject m_breadGlitchGO;

	[SerializeField]
	private float m_breadGlitchScaleMultiplier;

	private MeshRenderer originalRenderer;

	private Vector3 originalPosition;

	private Quaternion originalRotation;

	private void Start()
	{
		if (m_originalVisualsTransform != null && m_originalVisualsTransform.GetComponent<MeshRenderer>() != null)
		{
			originalRenderer = m_originalVisualsTransform.GetComponent<MeshRenderer>();
		}
		if (originalRenderer != null)
		{
			originalRenderer.enabled = true;
		}
		if (m_listOfBreadToActivate != null)
		{
			for (int i = 0; i < m_listOfBreadToActivate.Length; i++)
			{
				if (m_listOfBreadToActivate[i] != null)
				{
					m_listOfBreadToActivate[i].SetActive(value: false);
				}
			}
		}
		StartCoroutine(GlitchRoutine());
	}

	private void ActivateGlitch()
	{
		StartCoroutine(GlitchRoutine());
	}

	private void EnableBread(bool enable)
	{
		if (m_listOfBreadToActivate == null)
		{
			return;
		}
		for (int i = 0; i < m_listOfBreadToActivate.Length; i++)
		{
			if (m_listOfBreadToActivate[i] != null)
			{
				m_listOfBreadToActivate[i].SetActive(enable);
			}
		}
	}

	private IEnumerator GlitchRoutine()
	{
		int glichAmount = 3;
		int glichCount = 0;
		Rigidbody rb = GetComponent<Rigidbody>();
		if (m_originalVisualsTransform != null)
		{
			originalRotation = m_originalVisualsTransform.rotation;
			originalPosition = m_originalVisualsTransform.position;
		}
		if (rb != null)
		{
			rb.isKinematic = true;
		}
		GameObject breadGlitch = ((m_breadGlitchGO != null) ? Object.Instantiate(m_breadGlitchGO, base.transform) : null);
		if (breadGlitch != null)
		{
			breadGlitch.transform.localScale *= m_breadGlitchScaleMultiplier;
		}
		while (glichCount <= glichAmount)
		{
			if (glichCount == glichAmount)
			{
				if (m_originalVisualsTransform != null)
				{
					m_originalVisualsTransform.position = originalPosition;
					m_originalVisualsTransform.rotation = originalRotation;
				}
			}
			else if (m_originalVisualsTransform != null)
			{
				m_originalVisualsTransform.position = originalPosition + Vector3.right + Vector3.forward * Random.Range(-2f, 2f);
				m_originalVisualsTransform.rotation = Quaternion.Euler(Vector3.one * Random.Range(-360f, 360f));
			}
			if (breadGlitch != null && m_originalVisualsTransform != null)
			{
				breadGlitch.transform.localPosition = m_originalVisualsTransform.localPosition;
				breadGlitch.transform.rotation = Quaternion.Euler(Vector3.one * Random.Range(-360f, 360f));
			}
			glichCount++;
			yield return new WaitForSeconds(0.2f);
		}
		if (breadGlitch != null)
		{
			Object.Destroy(breadGlitch);
		}
		if (rb != null)
		{
			rb.isKinematic = false;
		}
		EnableBread(enable: true);
	}

	public AprilFoolGlitchEffect()
	{
		m_breadGlitchScaleMultiplier = 1f;
	}
}
