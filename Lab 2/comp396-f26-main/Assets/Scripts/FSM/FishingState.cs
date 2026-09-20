using UnityEngine;
using UnityEngine.AI;

namespace Core.FSM
{
    public class FishingState : BaseState
    {
        private GameObject fishingSpot;

        public FishingState(MeshRenderer renderer, NavMeshAgent agent) : base(renderer, agent)
        {
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("FishingState.Enter()");

            meshRenderer.material.color = Color.blue;

            fishingSpot = GameObject.FindWithTag("FishingSpot");

            if (fishingSpot != null)
            {
                agent.SetDestination(fishingSpot.transform.position);
                agent.isStopped = false;
            }
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Exit()
        {
            base.Exit();
            fishingSpot = null;
        }
    }
}