using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class candy : MonoBehaviour
{
    public static float movementSpeed = 0.05f;
    public static float candyypos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        candyypos = transform.position.y;
        if(cat_controller.candy == true){
            if(candyypos > -4){
                transform.Translate(0, -2 * movementSpeed, 0);
            }
            StartCoroutine(candycheck());
        }

        IEnumerator candycheck(){
            yield return new WaitForSeconds(3.0f);
            SceneManager.LoadScene("ending");
        }
    }
}
