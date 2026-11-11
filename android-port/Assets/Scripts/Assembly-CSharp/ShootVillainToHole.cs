using System.Collections;
using Cinemachine;
using UnityEngine;

public class ShootVillainToHole : MonoBehaviour
{
	[SerializeField]
	private Transform TargetPosition;

	[SerializeField]
	private Rigidbody Cart;

	[SerializeField]
	private GameObject AttachedRigid;

	[SerializeField]
	private float Force = 25f;

	[SerializeField]
	private GameObject Villain;

	[SerializeField]
	private bool debug;

	[SerializeField]
	private Rigidbody CartWinner;

	[SerializeField]
	private Transform TargetPositionWin;

	[SerializeField]
	private float ForceWin = 30f;

	[SerializeField]
	private float cartFlyTime = 1.5f;

	[SerializeField]
	private HotdogGolfer hotdogGolfer;

	[SerializeField]
	private CinemachineVirtualCamera cam;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.gameObject != null && other.gameObject.CompareTag("GolfBall"))
		{
			ShootIntoHole();
		}
	}

	public void SwapCarts()
	{
		if (Cart != null)
		{
			Cart.gameObject.SetActive(false);
		}
		if (CartWinner != null)
		{
			CartWinner.gameObject.SetActive(true);
			CartWinner.isKinematic = false;
			CartWinner.useGravity = true;
			if (TargetPositionWin != null)
			{
				Vector3 dir = (TargetPositionWin.position - CartWinner.transform.position).normalized;
				CartWinner.AddForce(dir * ForceWin, ForceMode.Impulse);
				CartWinner.AddTorque(dir * ForceWin, ForceMode.Impulse);
			}
		}
		if (AttachedRigid != null)
		{
			AttachedRigid.SetActive(false);
		}
		if (hotdogGolfer != null)
		{
			hotdogGolfer.SetToFreeRunning();
		}
		StartCoroutine(MakeCartStatic());
	}

	private void ShootIntoHole()
	{
		if (Cart == null)
		{
			return;
		}
		if (Villain != null)
		{
			Villain.transform.SetParent(Cart.transform);
		}
		Cart.constraints = RigidbodyConstraints.None;
		Cart.angularDrag = 0.05f;
		Cart.drag = 0.05f;
		if (TargetPosition != null)
		{
			Vector3 dir = (TargetPosition.position - Cart.transform.position).normalized;
			Cart.AddForce(dir * Force, ForceMode.Impulse);
			Cart.AddTorque(dir * Force, ForceMode.Impulse);
		}
	}

	private IEnumerator MakeCartStatic()
	{
		yield return new WaitForSeconds(cartFlyTime);
		if (CartWinner != null)
		{
			CartWinner.mass = 1000f;
		}
	}
}
