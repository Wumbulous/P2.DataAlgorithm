using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
   void Update()
   {
	   BackUp(); //BackUp method called every frame
   }
   void BackUp()
   {
	   if(Input.GetKeyDown(KeyCode.Escape)) //If player presses exc key return to main menu
	   {
		   SceneManager.LoadScene("Main Menu");
	   }

   }
}