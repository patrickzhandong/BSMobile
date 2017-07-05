using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClientController : MonoBehaviour {
    private RaycastHit2D hit;
    public Component texts;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

        if (Input.GetButtonDown("Fire1"))
        {
            hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);
            if (hit)
            {
                Vector2 pos = hit.transform.position;
                Debug.Log(pos);
                Text ThisText = GameObject.FindWithTag("hint").GetComponent<Text>();
                ThisText.text += pos;

            }
        }
    }
}
