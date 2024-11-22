using UnityEngine;
using UnityEngine.SceneManagement;
public class GAmeOvScreen : MonoBehaviour
{
    public void Retrybutton(){
        SceneManager.LoadScene("Retry");
    }
    public void ExitbutTon(){
        SceneManager.LoadScene("Exit");
    }
}
