using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObjects
{
    public int SizePool;
    private GameObject[] coins;

    public PoolObjects(int size, GameObject prefab)
	{
        SizePool = size;

        coins = new GameObject[SizePool];
        for (int i = 0; i < SizePool; ++i)
        {
            coins[i] = GameObject.Instantiate(prefab);
            coins[i].SetActive(false);
        }
    }

    public GameObject GetObject()
	{
        for (int i = 0; i < SizePool; ++i)
        {
            var coin = coins[i];
            if ( !coin.activeSelf )
			{
                return coin;
                break;
            }
            
        }
        return null;
    }
}
