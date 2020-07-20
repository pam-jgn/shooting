using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public static class Utils
{
    public static Vector2 m_moveLimit = new Vector2(4.7f, 3.4f);

    public static Vector3 ClampPosition(Vector3 position)
    {
        return new Vector3
            (
                Mathf.Clamp(position.x, -m_moveLimit.x, m_moveLimit.x),
                Mathf.Clamp(position.y, -m_moveLimit.y, m_moveLimit.y),
                0
            );
    }
}
