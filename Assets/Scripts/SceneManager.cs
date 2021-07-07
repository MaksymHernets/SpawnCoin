using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public Coin prefabGameObjectCoin;
    public CounterUI counterUI;
    public Transform PointSpawnCoin;
    public Chest chest;

    public int StartCoin = 30;

    private PoolObjects poolObjects;

	private void Start()
	{
        counterUI.Set(StartCoin);

        poolObjects = new PoolObjects(20, prefabGameObjectCoin.gameObject);

        chest.EventGotMoney += Chest_EventGotMoney;
    }

	private void Chest_EventGotMoney(GameObject gameObject)
	{
        if ( gameObject.TryGetComponent<Coin>(out prefabGameObjectCoin) ) 
		{
            prefabGameObjectCoin.rigidbody.isKinematic = true;
            prefabGameObjectCoin.rigidbody.isKinematic = false;
            gameObject.SetActive(false);
        }
    }

	public void ButtonSpawn_Click()
    {
        var coin = poolObjects.GetObject();
        if ( coin != null)
		{
            if ( counterUI.Uncrement() == 0 )
			{
                counterUI.Set(StartCoin);
            }
            coin.transform.localPosition = PointSpawnCoin.transform.localPosition;
            coin.SetActive(true);
        }
    }
}
