using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public string Player;
    private string PlayerHorizontal;
    private string PlayerVertical;
    private string PlayerFire1;
    private string PlayerFire2;
    private string PlayerFire3;
    private string PlayerJump;
    private string PlayerSubmit;
    private string PlayerCancel;
    private string PlayerRightX;
    private string PlayerRightY;
    private string PlayerRightTrigger;
    private string PlayerLeftTrigger;
    private bool FacingRight;
    public void Setvariables() {
        PlayerHorizontal = Player+"Horizontal";
        PlayerVertical = Player + "Vertical";
        PlayerFire1 = Player + "Fire1";
        PlayerFire2 = Player + "Fire2";
        PlayerFire3 = Player + "Fire3";
        PlayerJump = Player + "Jump";
        PlayerSubmit = Player + "Submit";
        PlayerCancel = Player + "Cancel";
        PlayerRightX = Player + "RightX";
        PlayerRightY = Player + "RightY";
        PlayerRightTrigger = Player + "RightTrigger";
        PlayerLeftTrigger = Player + "LeftTrigger";
    }

    public bool GetFacingRight()
    {
        return FacingRight;
    }

    /*public void SetFacingRight(string PlayerHorizontal)
    {
        if (Input.GetAxis(PlayerHorizontal) > 0)
            FacingRight = true;
        if (Input.GetAxis(PlayerHorizontal) < 0)
            FacingRight = false;
    }*/
    public string GetHorizontal()
    {
        return PlayerHorizontal;
    }
    public string GetVertical()
    {
        return PlayerVertical;
    }
    public string GetFire1()
    {
        return PlayerFire1;
    }
    public string GetFire2()
    {
        return PlayerFire2;
    }
    public string GetFire3()
    {
        return PlayerFire3;
    }
    public string GetJump()
    {
        return PlayerJump;
    }
    public string GetSubmit()
    {
        return PlayerSubmit;
    }
    public string GetCancel()
    {
        return PlayerCancel;
    }
    public string GetRightX()
    {
        return PlayerRightX;
    }
    public string GetRightY()
    {
        return PlayerRightY;
    }
    public string GetRightTrigger()
    {
        return PlayerRightTrigger;
    }
    public string GetLeftTrigger()
    {
        return PlayerLeftTrigger;
    }
}
