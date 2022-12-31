using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    protected static GameManager _GM { get { return GameManager.INSTANCE; } }
    protected static SceneController _SC { get { return SceneController.INSTANCE; } }
    protected static PlayerController _PC { get { return PlayerController.INSTANCE; } }
    //protected static EnemyManager _EM { get { return EnemyManager.INSTANCE; } }
    //protected static UIManager _UI { get { return UIManager.INSTANCE; } }

    protected static PauseController _PA { get { return PauseController.INSTANCE; } }


    /// <summary>
    /// Shuffles a list using Unity's Random
    /// </summary>
    /// <typeparam name="T">The data type</typeparam>
    /// <param name="_list">The list to shuffle</param>
    /// <returns></returns>
    public static List<T> ShuffleList<T>(List<T> _list)
    {
        for (int i = 0; i < _list.Count; i++)
        {
            T temp = _list[i];
            int randomIndex = UnityEngine.Random.Range(i, _list.Count);
            _list[i] = _list[randomIndex];
            _list[randomIndex] = temp;
        }
        return _list;
    }
}
