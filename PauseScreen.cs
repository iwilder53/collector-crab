using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
	public LevelManager gameLevelManager;
	public PauseMenu PauseMenuScreen;


    // Start is called before the first frame update
    void Start()
    {
         FindObjectOfType<LevelManager>() ;   }

    // Update is called once per frame
    void Update()
    {
        
    }


  public void ResumeGame()
    {
        FindObjectOfType<PauseMenu>().RestartGame();

    }

  public void QuitGame()
 {
     Debug.Log("QUIT!");
     Application.Quit();
 }


 public void RestartGame()
{
	
	 gameLevelManager.coins = 0;
	
        gameLevelManager.coinText.text = "Score: " + gameLevelManager.coins;	



	 FindObjectOfType<PauseMenu>().RestartGame();



}





}
