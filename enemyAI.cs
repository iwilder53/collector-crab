using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
	

{
	public float speed = 0.05f;
	public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacement =Player.position - transform.position;
	displacement = displacement.normalized;
	
	if (Vector2.Distance(Player.position,transform.position)>1.0f)
	{
		transform.position += (displacement * speed * Time.deltaTime);
	
}	

		
		

    }
}
