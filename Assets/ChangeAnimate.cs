using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimate : MonoBehaviour
{
  public void getAnimatorOrcWalk()
    {
        this.GetComponent<Animator>().Play("Orc Walk");
    }
  public void getAnimatorRightTurn()
    {
        this.GetComponent<Animator>().Play("Right Turn");
    }
  public void getAnimatorDrunkWalkBackwards()
    {
        this.GetComponent<Animator>().Play("Drunk Walk Backwards");
    }
    public void getAnimatorCockyHeadTurn()
    {
        this.GetComponent<Animator>().Play("Cocky Head Turn");
    }
    public void getAnimatorDencing()
    {
        this.GetComponent<Animator>().Play("Dancing Twerk");
    }
    public void getAnimatorRumba()
    {
        this.GetComponent<Animator>().Play("Rumba Dancing");
    }
}
