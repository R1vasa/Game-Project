using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
   public void Retty(){
    SceneManager.LoadScene("Retry");
   }
   public void Exit(){
    SceneManager.LoadScene("Exit");
   }
}
