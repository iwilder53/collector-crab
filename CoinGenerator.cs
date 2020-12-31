using UnityEngine;
using System.Collections;

public class CoinGenerator : MonoBehaviour
{

    public ObjectPooler coinPool;

    public float distanceBetweenCoins;
	float RandomDistance;

    public void SpawnCoins(Vector3 startPosition)
    {

	RandomDistance=Random.Range(0,distanceBetweenCoins);
        var coin1 = coinPool.GetPooledObject();
        coin1.transform.position = new Vector3(startPosition.x + RandomDistance, startPosition.y, startPosition.z);

        coin1.SetActive(true);

            }
}