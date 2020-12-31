using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour

{	


	public GameObject PauseMenuScreen;
	public GameObject DeathMenuScreen;
	public GameObject pooler;
    // Start is called before the first frame update
    void Start()
    {
        
    }



	
    // Update is called once per frame
    void Update()
    {
        
    }






 public void PauseGame()
    {
              Time.timeScale = 0f;
			pooler.SetActive(false);

		PauseMenuScreen.SetActive(true);
    }
	public void RestartGame()
    {
              Time.timeScale = 1f;
		PauseMenuScreen.SetActive(false);
		DeathMenuScreen.SetActive(false);
				pooler.SetActive(true);

    }

}
