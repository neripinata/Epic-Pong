using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Barra_Dos : MonoBehaviour


{

    private GameObject ball;
    private Vector2 ballPos;
    public float speedy = 10f;
    public Vector2 posicionBarra;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        posicionBarra = transform.position;
    }

    void Move()
    {
        if (!ball)
        {
            ball = GameObject.FindGameObjectWithTag("ball");
        }
        if (transform.position.y > 3.5)
        {
            speedy = -40f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }

        if (ball.GetComponent<Ball>().posicion.y > 0 && ball.GetComponent<Ball>().posicion.x > 0 && ball.GetComponent<Ball>().posicion.x < 5)
        {
            speedy = 12f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y > 0 && ball.GetComponent<Ball>().posicion.x > 5 && ball.GetComponent<Ball>().posicion.x < 6)
        {
            speedy = 4f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y > 0 && ball.GetComponent<Ball>().posicion.x > 6 && ball.GetComponent<Ball>().posicion.x < 7)
        {
            speedy = 12f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y > 0 && ball.GetComponent<Ball>().posicion.x > 7)
        {
            speedy = 16f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y > 0 && ball.GetComponent<Ball>().posicion.x < -6)
        {
            speedy = -12f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y > 0 && ball.GetComponent<Ball>().posicion.x < 0)
        {
            speedy = -4f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y < 0 && ball.GetComponent<Ball>().posicion.x > 0 && ball.GetComponent<Ball>().posicion.x < 5)
        {
            speedy = -4f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y < 0 && ball.GetComponent<Ball>().posicion.x > 5 && ball.GetComponent<Ball>().posicion.x < 6)
        {
            speedy = -6f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y < 0 && ball.GetComponent<Ball>().posicion.x > 6 && ball.GetComponent<Ball>().posicion.x < 7)
        {
            speedy = -14f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y < 0 && ball.GetComponent<Ball>().posicion.x > 7)
        {
            speedy = -32f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y < 0 && ball.GetComponent<Ball>().posicion.x < -6)
        {
            speedy = 14f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }
        if (ball.GetComponent<Ball>().posicion.y < 0 && ball.GetComponent<Ball>().posicion.x < 0)
        {
            speedy = 4f;
            speedy *= Time.deltaTime;
            transform.Translate(0, speedy, 0);
        }





    }
}