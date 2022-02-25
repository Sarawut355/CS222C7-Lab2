using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void getBrown()
    {
        GetComponent<Renderer>().material.color = new Color(58f / 255f, 12f / 255f, 12f / 255f);
    }
    public void getGreen()
    {
        GetComponent<Renderer>().material.color = new Color(0f / 255f, 56f / 255f, 0f / 255f);
    }
    public void getYello()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    public void getBlack()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
    public void getEnter1()
    {
        GetComponent<Renderer>().material.color = new Color(255f / 255f, 0f / 255f, 226f / 255f);
    }
    public void getEnter2()
    {
        GetComponent<Renderer>().material.color = new Color(0f / 255f, 195f / 255f, 255f / 255f);
    }
}