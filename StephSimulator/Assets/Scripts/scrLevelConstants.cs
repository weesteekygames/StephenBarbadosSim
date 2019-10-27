using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace levelConstants {
    public class scrLevelConstants : MonoBehaviour
    {
        public static float V_VERTICAL_MOVEMENT_TOP = -0.75f;
        public static float V_VERTICAL_MOVEMENT_BOTTOM = -1.37f;
        public static scrPlayerProperties PLAYER_PROPS = new scrPlayerProperties();

        public scrLevelConstants()
        {
            PLAYER_PROPS.populate();
        }
    }
}
