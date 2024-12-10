using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script serves as a template for all the pickup items in the game.
/// 
/// </summary>

[CreateAssetMenu(fileName = "New Pickup Item", menuName = "Pickup Item")] 
public class PickupItems : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;

}
