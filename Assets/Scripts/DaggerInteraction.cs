using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaggerInteraction2D : MonoBehaviour
{
    public GameObject dagger;
    public Image daggerUIImage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bruxo"))
        {
            Debug.Log("O Bruxo pegou a adaga!"); // Verifique se esta mensagem aparece no Console

            dagger.SetActive(false);
            daggerUIImage.enabled = true;

            Debug.Log("A imagem da adaga foi ativada!"); // Verifique se esta mensagem aparece no Console
        }
    }
}