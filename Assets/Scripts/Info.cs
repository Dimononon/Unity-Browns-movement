using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject info2, empty;
    public void OpenInfo()
    {
        gameObject.SetActive(true);
        empty.GetComponent<MainController>().Activator(false);


    }
    public void CloseInfo()
    {
        gameObject.SetActive(false);
        info2.SetActive(false);
        if (empty.GetComponent<MainController>().gavno) empty.GetComponent<MainController>().Activator(true);
        
    }
    public void OpenInfo2()
    {
        info2.SetActive(true);
        empty.GetComponent<MainController>().Activator(false);
    }
    public void OpenWiki(int x)
    {
        switch (x)
        {
            case 1:
                Application.OpenURL("https://uk.wikipedia.org/wiki/%D0%91%D1%80%D0%BE%D1%83%D0%BD%D1%96%D0%B2%D1%81%D1%8C%D0%BA%D0%B8%D0%B9_%D1%80%D1%83%D1%85");
                break;
            case 2:
                Application.OpenURL("https://uk.wikipedia.org/wiki/%D0%A0%D1%96%D0%B2%D0%BD%D1%8F%D0%BD%D0%BD%D1%8F_%D0%92%D0%B0%D0%BD_%D0%B4%D0%B5%D1%80_%D0%92%D0%B0%D0%B0%D0%BB%D1%8C%D1%81%D0%B0");
                break;
            case 3:
                Application.OpenURL("https://t.me/Dimononon");
                break;
        }
        
    }
}
