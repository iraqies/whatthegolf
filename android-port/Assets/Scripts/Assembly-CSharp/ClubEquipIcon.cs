using UnityEngine;
using UnityEngine.UI;

public class ClubEquipIcon : MonoBehaviour
{
	[SerializeField]
	private Image m_background;

	[SerializeField]
	private SVGImage m_clubImage;

	private RectTransform m_rectTransform;

	private void Start()
	{
		m_rectTransform = GetComponent<RectTransform>();
	}

	public void SetIcon(Sprite clubSprite, Color clubColor)
	{
		if (m_clubImage != null)
		{
			m_clubImage.sprite = clubSprite;
		}
		if (m_background != null)
		{
			m_background.color = clubColor;
		}
	}

	public void SetAsEquipped()
	{
		base.transform.SetAsLastSibling();
		if (m_rectTransform != null)
		{
			m_rectTransform.localPosition = Vector3.zero;
			m_rectTransform.sizeDelta = new Vector2(150f, 150f);
		}
	}

	public void SetAsUnequipped()
	{
		if (m_rectTransform != null)
		{
			m_rectTransform.localPosition = new Vector3(50f, 120f, 0f);
			m_rectTransform.sizeDelta = new Vector2(100f, 100f);
		}
	}
}
