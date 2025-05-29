using UnityEngine;
using UnityEngine.SceneManagement;

public class BombaReiniciaFase : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que colidiu tem a tag "Player"
        if (other.CompareTag("Player"))
        {
            // Reinicia a fase atual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}