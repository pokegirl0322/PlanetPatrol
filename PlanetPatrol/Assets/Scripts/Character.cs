using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 2.0f;
    public GameObject character;

    void Update () {
		transform.position += Vector3.right * speed * Time.deltaTime;
	}
}
