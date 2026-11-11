using UnityEngine;

public class ChangeColorOfObject : MonoBehaviour
{
	[SerializeField]
	private Renderer m_rendererToChange;

	[SerializeField]
	private Color m_activeColor;

	[SerializeField]
	private Color m_inactiveColor;

	private void Start()
	{
		if (m_inactiveColor.a == 0f)
		{
			m_inactiveColor = m_rendererToChange.material.GetColor("_Color");
		}
	}

	public void SetActiveColor()
	{
		m_rendererToChange.material.SetColor("_Color", m_activeColor);
	}

	public void SetInactiveColor()
	{
		m_rendererToChange.material.SetColor("_Color", m_inactiveColor);
	}
}
