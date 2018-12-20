using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Core : MonoBehaviour {

    public GameObject leftIcon;
    public GameObject rightIcon;
    public Text price;
    public Text manname;
    public Image potrait;

    public Man HH;
    public Man BB;

	void Start ()
    {
        HH = new Man(150000000,"Hao Hsuan","HH");
        BB = new Man(150000000, "Boss", "BB");
        leftIcon.SetActive(false);
    }

    public void Switch()
    {
        Sprite sprite = Resources.Load<Sprite>(HH.spritename);

        if (leftIcon.activeInHierarchy)
        {
            leftIcon.SetActive(true);
            rightIcon.SetActive(false);
        }
        else
        {
            leftIcon.SetActive(false);
            rightIcon.SetActive(true);
        }
    }	
    
}

public class Man
{
    public int price;
    public string name;
    public string spritename;

    public Man(int price, string name, string spritename)
    {
        this.price = price;
        this.name = name;
        this.spritename = spritename;
    }
}