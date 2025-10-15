using UnityEngine;
using UnityEngine.SceneManagement;

public class FallReset : MonoBehaviour
{
    public float deathY = -10f;     
    public string level1Name = "Nivel1"; 

    void Update()
    {
        if (transform.position.y < deathY)
            SceneManager.LoadScene(level1Name);
    }
}

