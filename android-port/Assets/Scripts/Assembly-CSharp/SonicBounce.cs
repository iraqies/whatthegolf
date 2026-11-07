using UnityEngine;
using UnityEngine.UI;

public class SonicBounce : MonoBehaviour
{
	private Text countTxt;

	private int startCount;

	public int bounceCount;

	private Renderer rend;

	public Color noBounce;

	public Color bounce;

	public Color hit;

	private float cooldown;

	private float requiredCool;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void Update()
	{
	}

	public void Reset()
	{
	}
}
