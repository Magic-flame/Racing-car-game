using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Roadcreat : MonoBehaviour {
    public Roadcreat()
    {
        isOnTriggerEnter = false;
    }
    public GameObject Prop;
    bool isOnTriggerEnter;
    static GameObject Road_2, Road_3, Road_4, Road_5, Road_6, Road_7, Road_8, Road_9, Road_10;
    static GameObject end2, end3, end4, end5, end6, end7, end8, end9, end10;
    public int rd;
    public int temporaryRd;
    GameObject[] Road = { Road_2, Road_3, Road_4, Road_5, Road_6, Road_7, Road_8, Road_9, Road_10 };
    GameObject[] end = { end2, end3, end4, end5, end6, end7, end8, end9, end10 };
    string[] num = { "2", "3", "4", "5", "6", "7", "8", "9", "10" };
    GameObject RCC;
    // Use this for initialization
    void Start () {
        create();
        create1();
        Prop = GameObject.Find("Prop");
        RCC = GameObject.Find("RCC");
        Prop.transform.position = new Vector3(0, 0, 0 + 30);
        RCC.transform.position = new Vector3(end[temporaryRd].transform.localPosition.x, 1, end[temporaryRd].transform.localPosition.z);
    }
	
	// Update is called once per frame
	void Update () {

    }
    public void random()
    {
        int r = Random.Range(0, 9);
        Debug.Log(r);
        rd = r;
    }
    public void create()
    {
        random();
        string path = "PartRoad/Road_" + num[rd];
        Road[rd] = Instantiate(Resources.Load(path), new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        end[rd] = GameObject.Find("Road_" + num[rd] + "(Clone)/end");
    }
    public void create1()
    {
        temporaryRd = rd;
        random();
        string path = "PartRoad/Road_" + num[rd];
        Road[rd] = Instantiate(Resources.Load(path), new Vector3(Road[temporaryRd].transform.localPosition.x, 0, Road[temporaryRd].transform.localPosition.z), Quaternion.identity) as GameObject;
        end[rd] = GameObject.Find("Road_" + num[rd] + "(Clone)/end");
        Road[rd].transform.position = new Vector3(Road[temporaryRd].transform.localPosition.x - end[rd].transform.localPosition.x, 0, Road[temporaryRd].transform.localPosition.z - end[rd].transform.localPosition.z);
    }
    public void RoadRefresh()
    {

    }
    void OnTriggerEnter(Collider collider)
    {
        print("发生了碰撞");
        Destroy(Road[temporaryRd]);
        create1();
        Prop.transform.position = new Vector3(Road[temporaryRd].transform.localPosition.x, 0, Road[temporaryRd].transform.localPosition.z + 30);
    }

}
