using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class StartConversation : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;

    public GameObject button_E;


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            button_E.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                ConversationManager.Instance.StartConversation(myConversation);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            button_E.SetActive(false);
        }
    }
}
