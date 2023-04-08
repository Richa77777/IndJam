using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace DialogueSystem
{
    public class DialogueController : MonoBehaviour
    {
        public static DialogueController Instance = null;

        [SerializeField] private TextMeshProUGUI _speakerName;
        [SerializeField] private TextMeshProUGUI _speakerText;
        [SerializeField] private Image _speakerImage;
        [SerializeField] private float _timeBtwnChars = 0.05f;

        private int _currentBranchIndex = 0;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            else if (Instance == this)
            {
                Destroy(gameObject);
            }

            DontDestroyOnLoad(gameObject);
        }

        public void StartDialogue(Dialogue dialogue, int startBranchIndex)
        {
            _currentBranchIndex = startBranchIndex;
            StartCoroutine(DialoguePlay(dialogue));
        }

        private IEnumerator DialoguePlay(Dialogue dialogue)
        {
            Branch currentBranch = dialogue.BranchesGet[_currentBranchIndex];

            for (int i = 0; i < currentBranch.PhrasesGet.Count; i++)
            {
                WriteText(currentBranch.PhrasesGet[i].PhraseTextGet);
                print("a");
                yield return new WaitUntil(Clicked);
            }
        }

        public bool Clicked()
        {
            if (Input.GetMouseButtonUp(0))
            {
                return true;
            }

            return false;
        }

        private IEnumerator WriteText(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                _speakerText.text = text.Substring(0, i);
                yield return new WaitForSeconds(_timeBtwnChars);
            }
        }
    }
}
