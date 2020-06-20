using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IAgentInterface
    {
        ICollection<Agent> GetAllAgents();

        Agent GetAgentByID(int AgentID);

        void CreateAgent(Agent NewAgent);

        int UpdateAgent(int AgentID, Agent AgentObject);

        int ResetPassword(int AgentID);

        int ChangePassword(int AgentID, Agent NewPassword);

        void DeleteAgent(int AgentID);
    }
}
