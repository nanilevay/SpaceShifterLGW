using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    public TimelineController timeline;

    private GameObject[] lights;
    private GameObject[] redLights;

    private Animator anim;

  //  [SerializeField]
  //  private GameObject alarmSound;

    private AudioSource audioSource;

    //public PasswordChecker Checker;

    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();

        lights = GameObject.FindGameObjectsWithTag("Lights");

        redLights = GameObject.FindGameObjectsWithTag("EmergencyLight");

        AlarmLightON();

        SwitchOffLight();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            SwitchONLight();
        }
    }

    private void SwitchONLight()
    {
       // if(!Checker.notSolved)
        //{
         //   Checker.GetComponent<PuzzleComponents>().IsActive = true;

         //   for (int i = 0; i < lights.Length; i++)
           // {
             //   lights[i].GetComponent<Light>().enabled = true;
            //}

            AlarmLightOFF();
       // }

        
    }

    private void SwitchOffLight() 
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].GetComponent<Light>().enabled = false;
        }
    }

    private void AlarmLightON()
    {
        //audioSource = alarmSound.GetComponent<AudioSource>();

        //audioSource.Play();

        for (int i = 0; i < redLights.Length; i++)
        {
            redLights[i].GetComponent<Light>().enabled = true;

            anim = redLights[i].GetComponent<Animator>();
            anim.SetBool("IsActive", true);
        }
    }

    private void AlarmLightOFF() 
    {
        //for (int i = 0; i < redLights.Length; i++)
        //{
        //    redLights[i].GetComponent<Light>().enabled = false;

        //    anim = redLights[i].GetComponent<Animator>();
        //    anim.SetBool("IsActive", false);
        //}
        timeline.ActivateTimeline();
        //audioSource = alarmSound.GetComponent<AudioSource>();
        //audioSource.Stop();
    }
}
