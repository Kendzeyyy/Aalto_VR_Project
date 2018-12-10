using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class MonthYearValues : MonoBehaviour
{


    //this is for the months and years activation using flickr api
    public GameObject theCube1;
    public GameObject theCube2;
    public GameObject theCube3;
    public GameObject theCube4;
    public GameObject theCube5;
    public GameObject theCube6;
    public GameObject theCube7;
    public GameObject theCube8;
    public GameObject theCube9;
    public GameObject theCube10;
    public GameObject theCube11;
    public GameObject theCube12;


    //years
    public GameObject year2012;
    public GameObject year2013;
    public GameObject year2014;
    public GameObject year2015;
    public GameObject year2016;
    public GameObject year2017;
    public GameObject year2018;
    public GameObject year2019;

    //store value for month and year in these variables
    public string startMonthValue;
    public string endMonthValue;
    public string yearValue;


    public string apiStartTakenDay;
    public string apiEndTakenDay;



    // Use this for initialization
    void Start()
    {
        //1 = January, 2 = Feb ... and so on. 
        theCube1 = GameObject.FindWithTag("cube1");
        theCube2 = GameObject.FindWithTag("cube2");
        theCube3 = GameObject.FindWithTag("cube3");
        theCube4 = GameObject.FindWithTag("cube4");
        theCube5 = GameObject.FindWithTag("cube5");
        theCube6 = GameObject.FindWithTag("cube6");
        theCube7 = GameObject.FindWithTag("cube7");
        theCube8 = GameObject.FindWithTag("cube8");
        theCube9 = GameObject.FindWithTag("cube9");
        theCube10 = GameObject.FindWithTag("cube10");
        theCube11 = GameObject.FindWithTag("cube11");
        theCube12 = GameObject.FindWithTag("cube12");


        year2012 = GameObject.Find("2012Collider");
        year2013 = GameObject.Find("2013Collider");
        year2014 = GameObject.Find("2014Collider");
        year2015 = GameObject.Find("2015Collider");
        year2016 = GameObject.Find("2016Collider");
        year2017 = GameObject.Find("2017Collider");
        year2018 = GameObject.Find("2018Collider");
        year2019 = GameObject.Find("2019Collider");

        startMonthValue = "";
        endMonthValue = "";
        yearValue = "";

        apiStartTakenDay = "";
        apiEndTakenDay = "";
    }


    void OnTriggerEnter(Collider collider)


        //add this script to colliders and finish years and build final apiqueue string with stringbuilder

    {
        if (collider.gameObject.tag == "cube1")
        {
            Debug.Log("okok you hit with cube1 aka January!!");
            startMonthValue = "1.1.";
            endMonthValue = "31.1.";

        }
        else if (collider.gameObject.tag == "cube2")
        {
            startMonthValue = "1.2.";
            endMonthValue = "28.2.";
        }
        else if (collider.gameObject.tag == "cube3")
        {
            startMonthValue = "1.3.";
            endMonthValue = "31.3.";
        }
        else if (collider.gameObject.tag == "cube4")
        {
            startMonthValue = "1.4.";
            endMonthValue = "30.4.";
        }
        else if (collider.gameObject.tag == "cube5")
        {
            startMonthValue = "1.5.";
            endMonthValue = "31.5.";
        }
        else if (collider.gameObject.tag == "cube6")
        {
            startMonthValue = "1.6.";
            endMonthValue = "30.6.";
        }
        else if (collider.gameObject.tag == "cube7")
        {
            startMonthValue = "1.7.";
            endMonthValue = "31.7.";
        }
        else if (collider.gameObject.tag == "cube8")
        {
            startMonthValue = "1.8.";
            endMonthValue = "31.8.";
        }
        else if (collider.gameObject.tag == "cube9")
        {
            startMonthValue = "1.9.";
            endMonthValue = "30.9.";
        }
        else if (collider.gameObject.tag == "cube10")
        {
            startMonthValue = "1.10.";
            endMonthValue = "31.10.";
        }
        else if (collider.gameObject.tag == "cube11")
        {
            startMonthValue = "1.11.";
            endMonthValue = "30.11.";
        }
        else if (collider.gameObject.tag == "cube12")
        {
            startMonthValue = "1.12.";
            endMonthValue = "31.12.";
        }
        //now for the years
        else if (collider.gameObject.name == "2012Collider")
        {
            yearValue = "2012";
        }
        else if (collider.gameObject.name == "2013Collider")
        {
            yearValue = "2013";
        }
        else if (collider.gameObject.name == "2014Collider")
        {
            yearValue = "2014";
        }
        else if (collider.gameObject.name == "2015Collider")
        {
            yearValue = "2015";
        }
        else if (collider.gameObject.name == "2016Collider")
        {
            yearValue = "2016";
        }
        else if (collider.gameObject.name == "2017Collider")
        {
            yearValue = "2017";
        }
        else if (collider.gameObject.name == "2018Collider")
        {
            yearValue = "2018";
        }
        else if (collider.gameObject.name == "2019Collider")
        {
            yearValue = "2019";
        }

        apiStartTakenDay = startMonthValue + yearValue;
        apiEndTakenDay = endMonthValue + yearValue;
        Debug.Log("okay so these are the values for flickr api! : apistartday: " + apiStartTakenDay + " and end: " + apiEndTakenDay);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
