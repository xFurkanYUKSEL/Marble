using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private byte total;
    private byte counter = 0;
    private GameObject door;
    [SerializeField]
    private Text uiText;
    private Rigidbody player;
    private void Start()
    {
        total = (byte)GameObject.FindGameObjectsWithTag("Point").Length;
        door = GameObject.Find("Door");
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        Debug.Log("Total :"+total);
        Debug.Log(door.name+" found.");
        Debug.Log(door.gameObject.transform.position);
        Debug.Log(player.name+" found.");
        Debug.Log(player.gameObject.transform.position);
    }
    internal void AddPoint()
    {
        counter++;
        if (counter == total - 1)
        {
            door.GetComponent<OpenTheDoor>().Door();
        }
        else if (counter == total)
        {
            uiText.text = "VICTORY";
            player.isKinematic = true;
        }
    }
    internal void GameOver()
    {
            uiText.text = "GAME OVER";
            SceneManager.LoadScene("Marble");
    }
}
