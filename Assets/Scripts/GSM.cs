using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSM : MonoBehaviour
{
    public Vector2 startVelocity;
    public Vector2 rightVelocity;

    void Awake()
    {
        God.GSM = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
