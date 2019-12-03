using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float velocity_x;
    public float velocity_y = -0.1f;
    bool direction;
    public Rigidbody2D rb;
    int time = 0;
    int cache_time = 0;
    public Sprite Triangle;
    public Sprite Square;
    public Sprite Hexagon;
    public Vector2 posicion;




    //To indicate if the ball has to start going to the right or to the left
    float GiveDirection()
    {
        float direccion = Random.Range(0.0f, 5.0f);
        if (direccion > 2.5)
        {
            velocity_x = 0.1f;
            return velocity_x;
        }
        else
        {
            velocity_x = -0.1f;
            return velocity_x;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GiveDirection();

        



    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity_x, velocity_y, 0);
        //transform.Rotate(0, 0, 2);

        if(time>600)
        {
            if (velocity_x > 0)
            {
                velocity_x += 0.1f;
            }
            if (velocity_x < 0)
            {
                velocity_x -= 0.1f;
            }
            cache_time = cache_time + time;
            time = 0;
        }

        if (cache_time < 599)
        {
            this.GetComponent<SpriteRenderer>().sprite = Triangle;

        }
        if (cache_time > 600 && cache_time < 1200)
        {
            this.GetComponent<SpriteRenderer>().sprite = Square;

        }
        
        if (cache_time > 1200 )
        {
            this.GetComponent<SpriteRenderer>().sprite = Hexagon;

        }

        time += 1;

        posicion = transform.position;

        Debug.Log(velocity_x);
        Debug.Log(cache_time);
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Border")
        {
            velocity_y = -velocity_y;
        }
        if (col.gameObject.tag == "Barra")
        {
            velocity_x = -velocity_x;
        }
        if (col.gameObject.tag == "lose")
        {
            SceneManager.LoadScene("Lose");
        }
        if (col.gameObject.tag == "win")
        {
            SceneManager.LoadScene("Level02");
        }
        if (col.gameObject.tag == "GANAR")
        {
            SceneManager.LoadScene("Win");
        }
        if (col.gameObject.tag == "Level3")
        {
            SceneManager.LoadScene("Level03");
        }



    }


}
