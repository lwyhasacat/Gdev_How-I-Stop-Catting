using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class description_food_cab : MonoBehaviour
{
    public static bool cat_food = false;
    public static bool movecatfood = false;
    public static float xpos;

    public Transform other;
    public GameObject textbox;
    public GameObject foodimg;
    private bool check = false;
    
    //private bool epressed = false;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(catfood.cat_food == true){
            float dist = Vector2.Distance(other.position, transform.position);
            if(dist <= 0.5 && check == false){
                if(Input.GetKey(KeyCode.E)){
                    textbox.SetActive(true);
                    text.text = "He doesn't like to eat on the ground...";
                    StartCoroutine(textdesp());
                    xpos = transform.position.x;
                    check = true;
                }
            }
        }

        IEnumerator textdesp(){
            yield return new WaitForSeconds(4.0f);
            text.text = "The table is too high for me though. Lemme try this...";
            StartCoroutine(trythis());
        }

        IEnumerator trythis(){
            yield return new WaitForSeconds(4.0f);
            text.text = "";
            textbox.SetActive(false);
            movecatfood = true;
        }
    }
}
