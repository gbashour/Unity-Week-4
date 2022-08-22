using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    public int random;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        random = Random.Range(150,251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.tag.Equals("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag.Equals("Blue") && (i >= 150 && i <=250))
        {
            rend.enabled = false;
        }
    }
}
