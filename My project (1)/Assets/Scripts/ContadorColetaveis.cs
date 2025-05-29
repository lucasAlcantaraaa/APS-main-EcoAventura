using UnityEngine;
using TMPro;

public class ContadorColetaveis : MonoBehaviour
{
    public static int contador = 0;
    public TMP_Text textoContador;
    public int totalColetaveis = 5; // Altere conforme o número total de coletáveis na cena
    public GameObject itemEspecial;

    void Start()
    {
        contador = 0; // Reseta o contador toda vez que a cena iniciar
    }

    void Update()
    {
        textoContador.text = "Coletáveis: " + contador;

        if (contador >= totalColetaveis && itemEspecial != null && !itemEspecial.activeSelf)
        {
            itemEspecial.SetActive(true);
        }
    }
}