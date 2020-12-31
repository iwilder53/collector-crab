using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{	
	public float RandomUpperLimit;
	public CoinGenerator coinGenerator;
    public float randomCoinThreshold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Random.Range(0f, RandomUpperLimit) < randomCoinThreshold)
            {
                coinGenerator.SpawnCoins(new Vector3(transform.position.x, transform.position.y + 2f, -2f));
            }
       

    }
}
