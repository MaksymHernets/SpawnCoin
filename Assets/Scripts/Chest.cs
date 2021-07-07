using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
	public delegate void GotMoney(GameObject gameObject);
	public event GotMoney EventGotMoney;

	private void OnTriggerEnter(Collider other)
	{
		EventGotMoney?.Invoke(other.gameObject);
	}
}
