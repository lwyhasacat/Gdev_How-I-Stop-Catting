using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public static float movementS = 0.03f;
    public Transform personTransform;
    private bool left = false;
    private bool right = false;

    public GameObject textbox;
    public Text text;
    private bool hint = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hint == false){
            textbox.SetActive(true);
            text.text = "Press E key to explore!";
            StartCoroutine(hint_count());
        }

        IEnumerator hint_count(){
            yield return new WaitForSeconds(4.0f);
            text.text = "";
            textbox.SetActive(false);
            hint = true;
        }
    }

    void FixedUpdate(){
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-1 * movementS, 0, 0);
            GetComponent<Animator>().Play("humanwalkingleft");
            right = false;
            left = true;
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(movementS, 0, 0);
            GetComponent<Animator>().Play("human_walking");
            left = false;
            right = true;
        }
        else{
            if(left){
                GetComponent<Animator>().Play("leftstand");
            }
            else if(right){
                GetComponent<Animator>().Play("rightstand");
            }

        }
    }
}
