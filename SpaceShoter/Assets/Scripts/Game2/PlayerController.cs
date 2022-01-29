using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float maxVY, minVY, g = 0.001f;
    private float vy;

    void Update()
    {
        vy = vy - g;
        if(vy < minVY)
            vy = minVY;

        player.GetComponent<Transform>().Translate(0, vy*Time.deltaTime, 0);

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            vy = maxVY;
        }

        if (Mathf.Abs(player.GetComponent<Transform>().position.y) > 5)
            player.GetComponent<Transform>().position = new Vector3(player.GetComponent<Transform>().position.x, -player.GetComponent<Transform>().position.y, player.GetComponent<Transform>().position.z);
    }
}
