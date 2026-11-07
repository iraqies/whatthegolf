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
	private float Force;

	[SerializeField]
	private GameObject Villain;

	[SerializeField]
	private bool debug;

	[SerializeField]
	private Rigidbody CartWinner;

	[SerializeField]
	private Transform TargetPositionWin;

	[SerializeField]
	private float ForceWin;

	[SerializeField]
	private float cartFlyTime;

	[SerializeField]
	private HotdogGolfer hotdogGolfer;

	[SerializeField]
	private CinemachineVirtualCamera cam;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void SwapCarts()
	{
	}

	private void ShootIntoHole()
	{
	}

	private IEnumerator MakeCartStatic()
	{
		return null;
	}
}
