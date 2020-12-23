using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Control Data")]
public class ControlData : ScriptableObject
{
    public string controlHoriz = "Horizontal";
    public string controlVert = "Vertical";

    public string lookX  = "Mouse X";
    public string lookY = "Mouse Y";
}
