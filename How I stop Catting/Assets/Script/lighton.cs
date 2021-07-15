using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighton : MonoBehaviour
{
    public Transform other;
    public GameObject light;
    public static bool light_on = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist_shelf = Vector2.Distance(other.position, transform.position);
        if (dist_shelf <= 2){
            if(Input.GetKey(KeyCode.E)){
                light.SetActive(true);
                light_on = true;
            }
        }
    }
}
