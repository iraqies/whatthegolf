using System.Collections;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ShareToImgur : MonoBehaviour
{
	private void Start()
	{
	}

	private IEnumerator AppScreenshotUpload()
	{
		return null;
	}

	public bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return false;
	}
}
