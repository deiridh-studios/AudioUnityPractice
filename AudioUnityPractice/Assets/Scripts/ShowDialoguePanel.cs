using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro.EditorUtilities;

public class ShowDialoguePanel : MonoBehaviour
{
    public AudioClip audioEffectIn;
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Adeu Dialeg");
            GetComponent<Animator>().SetTrigger("BocadilloIn");

            if (audioEffectIn != null)
            {
                audioSource.PlayOneShot(audioEffectIn);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Adeu Dialeg");
            GetComponent<Animator>().SetTrigger("BocadilloOut");
        }
    }
}
