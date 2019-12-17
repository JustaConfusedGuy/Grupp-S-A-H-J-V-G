using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class CoinSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject coin;

    float timer = 0;
    Rigidbody2D rb;

    void Start()
    {
        if (gameObject.name != "Text")
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;
        }
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector3(-3, 0, 0);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5 && gameObject.name == "Text")
        {
            Instantiate(coin, new Vector3(15, 0, 0), Quaternion.identity);
            timer = 0;
        }
    }
}
