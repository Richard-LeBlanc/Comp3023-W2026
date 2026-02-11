using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   // Start Button
   // Load the next scene available to me
   public void StartGame(){
        SceneManager.LoadScene("Level 1");
   }

//    // Exit Button   
//    // Exit the application
//     public void ExitGame(){
//           Application.quit();
//     }
}
