using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public sealed class HealthView : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _text;

        [SerializeField]
        private Image _progress;

        public void SetValue(string text)
        {
            _text.text = text;
        }

        public void SetProgress(float progress)
        {
            _progress.fillAmount = progress;
        }
    }
}