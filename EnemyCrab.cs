using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCrab : MonoBehaviour
{ 	 private crabmovement gameplayer;
   		 public int Damage;   
   private AudioSource source;


 // Start is called before the first frame update
    void Start()
    {
        gameplayer = FindObjectOfType<crabmovement>(); 
	source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           //source.Play();
           gameplayer.removeHealth(Damage);
            gameObject.SetActive(false);}
	if(other.tag == "Ground")
        {
           // source.Play();
         //  gameLevelManager.AddCoins(coinValue);
            gameObject.SetActive(false);
		
	
	

		}
		
}

}
