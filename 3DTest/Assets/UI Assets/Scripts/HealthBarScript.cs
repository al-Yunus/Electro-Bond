using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] Image _healthBarFill;
    [SerializeField] Image _healthBarTrailFill;
    [SerializeField] float _traildelay = 0.4f;

    [SerializeField] float _maxHealth = 10f;

    private float _currentHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;

        _healthBarFill.fillAmount = 1f;
        _healthBarTrailFill.fillAmount = 1f;
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            DrainHealth();
        }
    }

    private void DrainHealth()
    {
        _currentHealth -= 1f;
        float ratio = _currentHealth / _maxHealth;

        Sequence sequence = DOTween.Sequence();
        sequence.Append(_healthBarFill.DOFillAmount(ratio, 0.25f))
            .SetEase(Ease.InOutSine);
        sequence.AppendInterval(_traildelay);
        sequence.Append(_healthBarTrailFill.DOFillAmount(ratio, 0.3f))
            .SetEase(Ease.InOutSine);
        sequence.Play();
    }
}
