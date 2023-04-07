using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem
{
    public class Dialogue : MonoBehaviour
    {
        [SerializeField] private List<Branch> _branches = new List<Branch>();

        public List<Branch> BranchesGet => _branches;

        private void Start()
        {
            StartThisDialogue(0);
        }

        public void StartThisDialogue(int startBranchIndex)
        {
            DialogueController.Instance.StartDialogue(this, startBranchIndex);
        }
    }

    [System.Serializable]
    public class Branch
    {
        [SerializeField] private string _branchName;

        [Space(7.5f)]

        [SerializeField] private List<Phrase> _phrases = new List<Phrase>();

        public List<Phrase> PhrasesGet => _phrases;
    }

    [System.Serializable]
    public class Phrase
    {
        [SerializeField] private Speaker _speaker;
        [SerializeField] private string _phraseText;

        public Speaker SpeakerGet => _speaker;
        public string PhraseTextGet => _phraseText;
    }
}
