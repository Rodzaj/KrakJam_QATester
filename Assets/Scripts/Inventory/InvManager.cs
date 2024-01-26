using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvManager : MonoBehaviour
{
    public static Dictionary<InvItem, int> Inv;
    public static InvItem SelectedItem;

    // Start is called before the first frame update
    void Start()
    {
        //Set default inventory items
        Inv = new()
        {
            { InvItem.DoorFixCode, 1 },
            { InvItem.HoleFixCode, 1 },
            { InvItem.BarrierCrates, 2 }
        };
        SelectedItem = InvItem.BarrierCrates;
    }

    //public static void Clicked(ClickableObject ObjectType)
    public static void Clicked(object clickedObject)
    {
        switch (clickedObject)
        {
            case ClickableObject.Door:
                if (SelectedItem == InvItem.BarrierCrates)
                {

                }
                else if (SelectedItem == InvItem.DoorFixCode)
                {

                }

                break;
            case ClickableObject.Hole:

                break;
            case ClickableObject.Catapult:

                break;
        }
    }
}
