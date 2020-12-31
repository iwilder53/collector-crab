using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class LevelManager : MonoBehaviour
{	
	 public int coins;
	public Text coinText;
	bool hidden;

	public GameObject yourGameObject;
	
    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;

	public LevelGenerator levelGenerator;

	public GameObject crab;

	 float hideTimer;

void Start()
{
 levelGenerator = FindObjectOfType<LevelGenerator>(); 

 if(PlayerPrefs.HasKey("highScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("highScore");
        }



}


void Update()
  {
	/*hidden = Input.GetKey(KeyCode.Space);
	if(hidden == true){
		hide();


	while(hideTimer > 0)
	{ hideTimer -= Time.deltaTime;
	Debug.Log(hideTimer);	
	if(hideTimer <= 0)crab.SetActive(true);
	

	if(coins == 100){
		levelGenerator.RandomUpperLimit = levelGenerator.RandomUpperLimit - 50;
	 Debug.Log(levelGenerator.RandomUpperLimit);
}


				}*/
	

        if(coins > highScoreCount)
        {	
		yourGameObject.SetActive(true);
		 StartCoroutine(RemoveAfterSeconds(3, yourGameObject));
            highScoreCount = coins;
            PlayerPrefs.SetFloat("highScore", highScoreCount);
        }

       highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
	






}


  IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
            yield return new WaitForSeconds(seconds);
            obj.SetActive(false);
        }
public void hide()

{

	crab.SetActive(false);
	
	hideTimer = 2;

}



 public void AddCoins(int numberOfCoins)
    {
    

        coins += numberOfCoins;
        coinText.text = "Score: " + coins;
    }

}
