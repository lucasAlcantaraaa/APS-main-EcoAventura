using UnityEngine;

public class BColetavel : MonoBehaviour
{
    public GameObject boss;
    public QuizBoss quizBoss;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            boss.SetActive(true);
            quizBoss.MostrarPergunta();
            Destroy(gameObject);
        }
    }
}