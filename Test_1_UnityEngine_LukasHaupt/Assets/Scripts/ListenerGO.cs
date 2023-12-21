using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerGO : MonoBehaviour
{
    public void GetMessageAndPrint(string message)
    {
        Debug.Log("Message received: " + message);
    }
}
