using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    private float speed = 0.2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hispos = target.transform.position;
        Vector3 mypos = transform.position;

        if(Vector3.Distance(hispos, mypos) >= 5.0f)
        {
            Vector3 direction = hispos - mypos;
            transform.position = transform.position + direction * speed;
        }
    }
}
