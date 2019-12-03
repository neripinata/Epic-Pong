using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra_Dos : MonoBehaviour


{
    public float speedy = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float diagonal = Input.GetAxis("Horizontal ") * speedy;
        diagonal *= Time.deltaTime;
        transform.Translate(0, diagonal, 0);
    }
}
