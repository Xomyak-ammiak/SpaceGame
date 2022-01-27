using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosion;
    public float speed = 50f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);

    }

    void Update()
    {
        if (transform.position.x < screenBounds.x * -1.2f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Asteroid")
        {
            GameObject newExplosion = Instantiate(explosion) as GameObject;
            newExplosion.transform.position = transform.position;
            newExplosion.SetActive(true);
            Destroy(newExplosion, 1.5f);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
