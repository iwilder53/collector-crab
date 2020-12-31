using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
	
    public GameObject thePlatform;
    public Transform generationPoint;
    public float DistanceBetween;

    private float platformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;
    public ObjectPooler[] theObjectPools;

    //public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformWidths;

    private float minHeight;
    public Transform maxHeightPoint;
    private float maxHeight;
    public float maxHeightChange;
    private float heightChange;


    // Start is called before the first frame update
    void Start()
    {
         platformWidths = new float[theObjectPools.Length];

      
        minHeight = transform.position.x;
        maxHeight = maxHeightPoint.position.x;    }

    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.y < generationPoint.position.x)
        {
            DistanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            platformSelector = Random.Range(0, theObjectPools.Length);
            heightChange = transform.position.x + Random.Range(maxHeightChange, -maxHeightChange);

            if (heightChange > maxHeight)
            {

                heightChange = maxHeight;

            }
            else if (heightChange < minHeight)
            {
                heightChange = minHeight;

            }
            transform.position = new Vector3(transform.position.x , heightChange + DistanceBetween, transform.position.z);


            // Instantiate(/*thePlatform*/thePlatforms[platformSelector], transform.position, transform.rotation);

            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);


            transform.position = new Vector3(transform.position.x , transform.position.y , transform.position.z); 
    }
}
}