using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
   
{
    public float speed;
    private PlayerController playerCntrl;
    private float leftBounds = -10;


    // Start is called before the first frame update
    void Start()
    {
       playerCntrl = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerCntrl.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBounds && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
