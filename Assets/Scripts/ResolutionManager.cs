using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    public int Width;
    public int Height;


    public void setwidth(int newwidth){
        Width=newwidth;
    }

    public void setheight(int newhight){
        Height=newhight;
    }

    public void SetRes(){
        //720 x 480 pixels res 480p
        // 1280 x 720 pixels res HD
        // 1920 x 1080 pixels res FullHDRes
        // 2560 x 1440 pixels res QHD
        Screen.SetResolution (Width,Height,false);
    }
    public void Quit(){
        Application.Quit();    
    }
    
}
