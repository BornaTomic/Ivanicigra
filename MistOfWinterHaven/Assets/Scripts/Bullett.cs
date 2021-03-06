using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullett : MonoBehaviour
{
    public POV povB;
    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy2", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (povB == POV.gore)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else if (povB == POV.dolje)
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        else if (povB == POV.desno)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (povB == POV.lijevo)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
    void Destroy2()
    {
        Destroy(gameObject);
    }
}
