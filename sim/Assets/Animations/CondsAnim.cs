using UnityEngine;

public class CondsAnim : MonoBehaviour
{
    public enum Conductors
    {
        Lead,
        Aluminium,
        Iron

    }
    public Conductors currentConductor;
    private GroundPanel groundPanel;
    private Animator leadAnimation;
    private Animator aluminiumAnimation;
    private Animator ironAnimation;

    private void Start()
    {
        leadAnimation = GameObject.Find("Conductor3").GetComponent<Animator>(); // Lead
        aluminiumAnimation = GameObject.Find("Conductor1").GetComponent<Animator>(); // Aluminum
        ironAnimation = GameObject.Find("Conductor2").GetComponent<Animator>(); // Iron
        groundPanel = GameObject.Find("GroundTask").GetComponent<GroundPanel>();
        currentConductor = Conductors.Lead;
        groundPanel.selectedCondText.text = "Свинец";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "Conductor1")
                {
                    leadAnimation.SetInteger("ChosenCond", 1);
                    aluminiumAnimation.SetInteger("ChosenCond", 1);
                    ironAnimation.SetInteger("ChosenCond", 1);
                    currentConductor = Conductors.Aluminium;
                    groundPanel.selectedCondText.text = "Алюминий";
                }
                if (hit.collider.gameObject.name == "Conductor2")
                {
                    leadAnimation.SetInteger("ChosenCond", 2);
                    aluminiumAnimation.SetInteger("ChosenCond", 2);
                    ironAnimation.SetInteger("ChosenCond", 2);
                    currentConductor = Conductors.Iron;
                    groundPanel.selectedCondText.text = "Железо";
                }
                if (hit.collider.gameObject.name == "Conductor3")
                {
                    leadAnimation.SetInteger("ChosenCond", 3);
                    aluminiumAnimation.SetInteger("ChosenCond", 3);
                    ironAnimation.SetInteger("ChosenCond", 3);
                    currentConductor = Conductors.Lead;
                    groundPanel.selectedCondText.text = "Свинец";
                }
            }
        }
    }
}
