using UnityEditor;
using UnityEngine;
using UnityEngine.U2D.Animation;

namespace DialogueSystem
{
    [CreateAssetMenu(fileName = "New Speaker", menuName = "Speakers/Speaker", order = 0)]
    public class Speaker : ScriptableObject
    {
        [SerializeField] private string _name;
    }
}


// kind, angry, sad, surprised, neutral