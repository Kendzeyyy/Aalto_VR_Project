using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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

      /*  startMonthValue = "";
        endMonthValue = "";
        yearValue = "";

        apiStartTakenDay = "";
        apiEndTakenDay = "";*/
    }


    void OnTriggerEnter(Collider collider)

        //add this script to colliders and finish years and build final apiqueue string with stringbuilder

    {
        //FlickrValues flickrValues = new FlickrValues();
        FlickrValues flickrValues = gameObject.AddComponent<FlickrValues>();

        Debug.Log("HIT WITH " + collider);
        //if (collider.gameObject.tag == "cube1") changing this
        if (collider.gameObject.tag == "Jan")
        {
            Debug.Log("okok you hit with cube1 aka January!!");
            startMonthValue = "1-1";
            endMonthValue = "1-31";
            SaveDate();

        }
        else if (collider.gameObject.tag == "Feb")
        {
            startMonthValue = "2-1";
            endMonthValue = "2-28";
            SaveDate();
        }
        else if (collider.gameObject.tag == "Mar")
        {
            startMonthValue = "3-1";
            endMonthValue = "3-31";
            SaveDate();
        }
        else if (collider.gameObject.tag == "Apr")
        {
            startMonthValue = "4-1";
            endMonthValue = "4-30";
            SaveDate();
        }
        else if (collider.gameObject.tag == "May")
        {
            startMonthValue = "5-1";
            endMonthValue = "5-31";
            SaveDate();
        }
        else if (collider.gameObject.tag == "Jun")
        {
            startMonthValue = "6-1";
            endMonthValue = "6-30";
            SaveDate();
        }
        else if (collider.gameObject.tag == "Jul")
        {
            startMonthValue = "7-1";
            endMonthValue = "7-31";
            SaveDate();
        }
        else if (collider.gameObject.tag == "Aug")
        {
            startMonthValue = "8-1";
            endMonthValue = "8-31";
            SaveDate();
        }
        else if (collider.gameObject.tag == "Sep")
        {
            startMonthValue = "9-1";
            endMonthValue = "9-30";
            SaveDate();
        }
        else if (collider.gameObject.tag == "Oct")
        {
            startMonthValue = "10-1";
            endMonthValue = "10-31";
            SaveDate();
        }
        else if (collider.gameObject.tag == "Nov")
        {
            startMonthValue = "11-1.";
            endMonthValue = "11-30";
            SaveDate();
        }
        else if (collider.gameObject.tag == "Dec")
        {
            startMonthValue = "12-1";
            endMonthValue = "12-31";
            SaveDate();
        }
        //now for the years
        //else if (collider.gameObject.tag == "Des2012")  temp....
        else if (collider.gameObject.name == "Collider2012")
        {
            yearValue = "2012-";
            SaveYear();
        }
        else if (collider.gameObject.name == "Collider2013")
        {
            yearValue = "2013-";
            SaveYear();
        }
        else if (collider.gameObject.name == "Collider2014")
        {
            yearValue = "2014-";
            SaveYear();
        }
        else if (collider.gameObject.name == "Collider2015")
        {
            yearValue = "2015-";
            SaveYear();
        }
        else if (collider.gameObject.name == "Collider2016")
        {
            yearValue = "2016-";
            SaveYear();
        }
        else if (collider.gameObject.name == "Collider2017")
        {
            yearValue = "2017-";
            SaveYear();
        }
        else if (collider.gameObject.name == "Collider2018")
        {
            yearValue = "2018-";
            SaveYear();
        }
        else if (collider.gameObject.name == "Collider2019")
        {
            yearValue = "2019-";
            SaveYear();
        }

    }

    public void SaveDate()
    {
        TextWriter tw = new StreamWriter("SavedFirstDate.txt");
        TextWriter tw1 = new StreamWriter("SavedLastDate.txt");
        //saving to text files because so easy. sorry for inconvinience. 
        //BinaryFormatter bf = new BinaryFormatter();
        //FileStream file = File.Create(Application.persistentDataPath + "/flickrValues.txt");
        Debug.Log("SAVING VALUES SM EM: " + startMonthValue + endMonthValue);
     
        //FlickrValues values = new FlickrValues();
        FlickrValues values = gameObject.AddComponent<FlickrValues>();
       
        values.startMonthValue = startMonthValue;
        values.endMonthValue = endMonthValue;
        // values.yearValue = yearValue;
        Debug.Log("SAVING VALUES TTOOOO SM EM: " + values.startMonthValue + values.endMonthValue);
        tw.WriteLine(values.startMonthValue);
        tw1.WriteLine(values.endMonthValue);

        //values.apiStartTakenDay = startMonthValue + yearValue;
        //values.apiEndTakenDay = endMonthValue + yearValue;
        //Debug.Log("SAVING VALUES valuesapistart + apiend: " + values.apiStartTakenDay + values.apiEndTakenDay );
        //bf.Serialize(file, values);
        //file.Close();
        tw.Close();
        tw1.Close();
    }
    public void SaveYear()
    {
        //BinaryFormatter bf = new BinaryFormatter();

        TextWriter tw = new StreamWriter("SavedYears.txt");
        //if (!tw.Exists(Application.persistentDataPath + "/flickrValues.txt"))       
        //file = File.Create(Application.persistentDataPath + "/flickrValues.txt");
                
        Debug.Log("SAVING VALUES Y: " + yearValue);
        
        //FlickrValues values = new FlickrValues();
        FlickrValues values = gameObject.AddComponent<FlickrValues>();
        values.yearValue = yearValue;
        tw.WriteLine(values.yearValue);

        //values.apiStartTakenDay = startMonthValue + yearValue;
        //values.apiEndTakenDay = endMonthValue + yearValue;
        //Debug.Log("SAVING VALUES valuesapistart + apiend: " + values.apiStartTakenDay + values.apiEndTakenDay );
        //bf.Serialize(file, values);
        //file.Close();
        tw.Close();
    }

    public void Load()
    {
        /*if (File.Exists(Application.persistentDataPath + "/flickrValues.txt"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/flickrValues.txt", FileMode.Open);
            FlickrValues values = (FlickrValues)bf.Deserialize(file);
            file.Close();
     
        }*/
        FlickrValues values = gameObject.AddComponent<FlickrValues>();
        TextReader tr = new StreamReader("SavedFirstDate.txt");
        TextReader tr1 = new StreamReader("SavedLastDate.txt");
        TextReader tr2 = new StreamReader("SavedYears.txt");
        string a = tr.ReadLine();
        string b = tr1.ReadLine();
        string c = tr2.ReadLine();
   
        Debug.Log("THIS IS LOADING AND READING FROM FILE: ALL " + a + b + c);
        Debug.Log("THIS IS LOADING AND READING FROM FILE   A: " + a );
        Debug.Log("THIS IS LOADING AND READING FROM FILE:  B: " + b);
        Debug.Log("THIS IS LOADING AND READING FROM FILE:  C: " + c);
        tr.Close();
        tr1.Close();
        tr2.Close();
        apiStartTakenDay = c + a;
        apiEndTakenDay = c + b;
       
    }


    // Update is called once per frame
    void Update()
    {

    }
    
}

//[Serializable]
class FlickrValues : MonoBehaviour
{
    public string startMonthValue;
    public string endMonthValue;
    public string yearValue;
    public string apiStartTakenDay;
    public string apiEndTakenDay;

}
