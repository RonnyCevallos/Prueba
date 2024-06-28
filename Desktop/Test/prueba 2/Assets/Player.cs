using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mivimientoHorizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        transform.Translate(new Vector3(mivimientoHorizontal, velocidad, 0));
    }
}
