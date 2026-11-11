using UnityEngine;

public class PaperBoyHouse : MonoBehaviour
{
	private PaperBoyHouses houses;

	public ParticleSystem ConfettiSystem;

	private Animator anim;

	private void Awake()
	{
		anim = GetComponent<Animator>();
		houses = GetComponentInParent<PaperBoyHouses>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.gameObject != null && other.gameObject.tag == "Player" && houses != null)
		{
			houses.DeliverMail(this);
		}
	}

	private void DeliverMail()
	{
		if (houses != null)
		{
			houses.DeliverMail(this);
		}
	}

	public void PlayEffects()
	{
		if (ConfettiSystem != null)
		{
			ConfettiSystem.Play();
		}
		if (anim != null)
		{
			anim.SetTrigger("Delivered");
		}
	}
}
