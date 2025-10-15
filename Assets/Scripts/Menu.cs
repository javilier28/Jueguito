using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void Jugar(){ SceneManager.LoadScene("Nivel1"); }
    public void Creditos(){ SceneManager.LoadScene("Creditos"); }
    public void Salir(){ Application.Quit(); }  
}
