using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro.EditorUtilities;

public class ShowDialoguePanel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Adeu Dialeg");
            GetComponent<Animator>().SetTrigger("BocadilloIn");
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
