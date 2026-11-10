using UnityEngine;
using UnityEngine.UI;

public class SonicBounce : MonoBehaviour
{
	private Text countTxt;

	private int startCount;

	public int bounceCount = 1;

	private Renderer rend;

	public Color noBounce;

	public Color bounce;

	public Color hit;

	private float cooldown;

	private float requiredCool = 0.5f;

	private void Start()
	{
		countTxt = GetComponentInChildren<Text>();
		startCount = bounceCount;
		if (countTxt != null)
			countTxt.text = bounceCount.ToString();
		rend = GetComponent<Renderer>();
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.collider == null)
			return;
		if (other.collider.CompareTag("Player") && bounceCount >= 1 && cooldown > requiredCool)
		{
			cooldown = 0f;
			bounceCount--;
			if (rend != null && rend.material != null)
				rend.material.color = hit;
		}
	}

	private void Update()
	{
		cooldown += Time.unscaledDeltaTime;
		if (countTxt != null)
			countTxt.text = bounceCount.ToString();
		if (bounceCount > 0)
		{
			tag = "Bouncer";
			if (rend != null && rend.material != null)
				rend.material.color = Color.Lerp(rend.material.color, bounce, Time.deltaTime * 5f);
		}
		else
		{
			tag = "Obstacle";
			if (rend != null && rend.material != null)
				rend.material.color = Color.Lerp(rend.material.color, noBounce, Time.deltaTime * 5f);
		}
	}

	public void Reset()
	{
		bounceCount = startCount;
	}
}
