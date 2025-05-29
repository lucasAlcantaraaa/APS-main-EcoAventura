using UnityEngine;


public class Coletavelcs : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ContadorColetaveis.contador++; // Atualiza contador
            Destroy(gameObject); // Remove o coletável
        }
    }
}