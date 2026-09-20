using UnityEngine;
using UnityEngine.AI;

namespace Core.FSM
{
    public class BlacksmithState : BaseState
    {
        private GameObject forge;

        public BlacksmithState(MeshRenderer renderer, NavMeshAgent agent) : base(renderer, agent)
        {
        }

        public override void Enter()
        {
            base.Enter();
            Debug.Log("BlacksmithState.Enter()");

            meshRenderer.material.color = Color.red;

            forge = GameObject.FindWithTag("Forge");

            if (forge != null)
            {
                agent.SetDestination(forge.transform.position);
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
            forge = null;
        }
    }
}