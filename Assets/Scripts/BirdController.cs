using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    GameObject obj;
    public float flyPower;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        EndGame();
    }
    void EndGame()
    {
        Debug.Log("End Game");
    }
}
