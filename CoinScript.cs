using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class CoinScript : MonoBehaviour
{
    private LevelManager gameLevelManager;
    public int coinValue;
   private AudioSource source;
	public int Damage;
	 private crabmovement gameplayer;
	public float rotateSpeed = 50f;
    // Use this for initialization
    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
	        gameplayer = FindObjectOfType<crabmovement>(); 

       source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
	//transform.Rotate(Vector2.left * rotateSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           //source.Play();
		Debug.Log("started");

           gameLevelManager.AddCoins(coinValue);
            gameObject.SetActive(false);
		
		

        }
	
	if(other.tag == "Ground")
        {
           // source.Play();
       gameplayer.removeHealth(Damage);
            gameObject.SetActive(false);
		
	
	

		}

	 
    }
}