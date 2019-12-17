using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class CoinSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject coin;

    static int textNum = 1;
    float timer = 0;
    Rigidbody2D rb;

    
    public static Text myText;

    void Start()
    {

        myText = GameObject.Find("Text").GetComponent<Text>();
        GetComponent<Rigidbody2D>().gravityScale = 0;
        

        if (gameObject.name == "Text")
        {
            myText = GetComponent<Text>();
        }
        rb = GetComponent<Rigidbody2D>();

        if (gameObject.name != "Text")
        {
            rb.velocity = new Vector3(-3, 0, 0);
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2 && gameObject.name == "Text")
        {
            Instantiate(coin, new Vector3(15, 0, 0), Quaternion.identity);
            timer = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        myText.color = Color.white;
        myText.gameObject.GetComponent<RectTransform>().localPosition = new Vector3(-346, 136, 0);
        myText.text = textNum.ToString();
        textNum++;
    }
}
