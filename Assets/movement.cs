using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{public float speed;

[SerializeField] private GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         if(Input.GetKey(KeyCode.D)){
              go.transform.Translate(Vector2.right * speed * Time.deltaTime);}
        
         if(Input.GetKey(KeyCode.A)){
              go.transform.Translate(Vector2.left * speed * Time.deltaTime);}
        
         if(Input.GetKey(KeyCode.W)){
             go.transform.Translate(Vector2.up * speed * Time.deltaTime);}

         if(Input.GetKey(KeyCode.S)){
             go.transform.Translate(Vector2.down * speed * Time.deltaTime);}

    }
}
