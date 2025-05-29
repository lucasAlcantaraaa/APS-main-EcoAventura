using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosionEffect; // Prefab de explosão
    public GameObject gameOverPanel;   // Referência ao painel de Game Over

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Explode(other.gameObject);
        }
    }

    void Explode(GameObject player)
    {
        // Criar explosão
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }

        // "Matar" o jogador
        Destroy(player);  // Remove o player da cena

        // Ativar painel de Game Over
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }

        // Opcional: destruir a bomba após explodir
        Destroy(gameObject);
    }
}
