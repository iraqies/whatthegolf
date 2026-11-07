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
	}

	private void ActivateGlitch()
	{
	}

	private void EnableBread(bool enable)
	{
	}

	private IEnumerator GlitchRoutine()
	{
		return null;
	}
}
