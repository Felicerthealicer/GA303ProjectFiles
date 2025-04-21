using DG.Tweening;
using UnityEngine;

public class UITweenTest : MonoBehaviour
{

    public Transform beegToad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // beegToad.transform.DOMoveX(beegToad.transform.position.x + 500f, 5f, true);
        // beegToad.transform.DOMove(beegToad.transform.position + (Vector3.right * 500f), 5f);
        // beegToad.transform.DORotate(beegToad.transform.rotation.eulerAngles + new Vector3(0f, 0f, 180f), 5f);

        //A sequence is a sequence of tweens that will be done in order, based on appending them or inserting at a certain time.
        Sequence s = DOTween.Sequence();
        //We start off this sequence with an append so it's the first thing that happens.
        //We take the original position and move it to the right.
        s.Append(beegToad.transform.DOMove(beegToad.transform.position + (Vector3.right * 500f), 5f));
        //We need to insert the rotation so that it happens at the same time as the first appended movement in the sequence.
        //By giving it a start time of 0f, we stat it immediately wehen the sequence starts so it happens at the same time.
        s.Insert(0f, beegToad.transform.DORotate(beegToad.transform.rotation.eulerAngles + new Vector3(0f, 0f, 180f), 5f));
        //We append the next partr of the sequence that will happen once the previous Apend ends. 
        //In this case, we move it to the original position, since when we build the sequence, it's using the same value before it was moved.
        //If we subtracted from it now, it would take the original position and move it - 500 instead of going back tot he original position. 
        s.Append(beegToad.transform.DOMove(beegToad.transform.position, 5f));
        //We insert this final rotation at the same time it took for the first append to happen (we set it to 5f), so that it happens at the same time as the second append.move.
        s.Insert(5f, beegToad.transform.DORotate(beegToad.transform.rotation.eulerAngles, 5f));
        //Now we play it (forward :)

        s.PlayForward();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DOTween.KillAll();
            //Kill All will stop all the tweens in their current position.
            DOTween.CompleteAll();
            //CompleteAll will take all current tweens and set themn to their end positions, including all the ones in a sequence.
            DOTween.Complete(beegToad.transform);
            //If we complete or kill a singular one, we need to papss in the object that has a tween on it. 
            // ?? 
        }
    }
}
