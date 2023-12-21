using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerGO : MonoBehaviour
{
    private string message = "Secret";
    private ListenerGO listenerGO;

    private void Start()
    {
        listenerGO = GameObject.Find("ListenerGO").GetComponent<ListenerGO>();
    }

    public void SendMessageToListener()
    {
        listenerGO.GetMessageAndPrint(message);
    }
}
