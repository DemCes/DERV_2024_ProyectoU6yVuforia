using UnityEngine;
using Vuforia;

public class AnimacionUnicaAlDetectar : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    public Renderer characterRenderer;
    private bool isTracking = false;

    void Start()
    {
        var observer = GetComponent<ObserverBehaviour>();
        if (observer)
        {
            observer.OnTargetStatusChanged += OnObserverStatusChanged;
        }

        characterRenderer.enabled = false;
        audioSource.Stop();
    }

    void OnObserverStatusChanged(ObserverBehaviour observer, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED && !isTracking)
        {
            isTracking = true;
            characterRenderer.enabled = true;
            animator.SetTrigger("Detectado");
            audioSource.Play();
        }
        else if (targetStatus.Status != Status.TRACKED && isTracking)
        {
            isTracking = false;
            animator.SetTrigger("Perdido");
            characterRenderer.enabled = false;
            audioSource.Stop();
        }
    }
}
