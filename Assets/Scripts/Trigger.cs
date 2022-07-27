using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private GameManager manager;
    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="DeadLine")
        {
            manager.GameOver();
            return;
        }
        manager.AddPoint();
        Destroy(other.gameObject);
    }
}
