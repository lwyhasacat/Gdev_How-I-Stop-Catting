using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movetodesk : MonoBehaviour
{
    public Transform foodTransform;
    public static float movementSpeed = 0.05f;
    public static bool foodontable = false;
    public static float foodypos;
    public GameObject foodimg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foodypos = transform.position.y;
    
        if(description_food_cab.movecatfood == true && foodypos < -0.2){
            //transform.position.x = description_food_cab.xpos;
            transform.Translate(0, movementSpeed, 0);
            foodimg.SetActive(false);
        }
        if(foodypos < -0.2 && foodypos > -0.3){
            foodontable = true;
        }
        if(foodypos >= -0.2){
            transform.position = new Vector3 (description_food_cab.xpos, transform.position.y, transform.position.z);
        }
    }
}
