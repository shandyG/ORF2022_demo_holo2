using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHumanBody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Camera.main.gameObject.transform.position;
        this.transform.rotation = Camera.main.gameObject.transform.rotation;
    }
}
