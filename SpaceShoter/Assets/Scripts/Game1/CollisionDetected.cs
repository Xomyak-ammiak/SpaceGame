using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CollisionDetected : MonoBehaviour
{
    public GameObject explosion;
    public GameObject button;
    public GameObject maxScoreText;

    private void Awake()
    {
        PlayerPrefs.SetInt("ToLose", 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Asteroid")
        {
            GameObject newExplosion = Instantiate(explosion) as GameObject;
            newExplosion.transform.position = transform.position;
            newExplosion.SetActive(true);
            GameObject.Find("Rocket").SetActive(false);
            Destroy(newExplosion, 1.5f);
            PlayerPrefs.SetInt("ToLose", 1);
            button.SetActive(true);
            maxScoreText.SetActive(true);
        }
    }
}
