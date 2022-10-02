using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private GameObject task;
    private void Start()
    {
        // finds the poster gameobject
        task = GameObject.FindGameObjectWithTag("Task");
    }
    void Update()
    {
        // closes the poster window when it is active
        if(Input.GetKey(KeyCode.E) && task.activeInHierarchy)
        {
            task.SetActive(false);
        }
        else
        { return; }
    }
}
