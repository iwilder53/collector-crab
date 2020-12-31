using UnityEngine;
using UnityEngine.UI;




public class Player  : MonoBehaviour
{	
	public Text healthText;
	public int health;

    public static float distanceTraveled;

    void Update()
    {
        transform.Translate(5f * Time.deltaTime, 0f, 0f);
        distanceTraveled = transform.localPosition.x;


		




    }
 public void removeHealth(int Damage)
    {
    

        health -= Damage;
        healthText.text = "Health : " + health;
    }


}
