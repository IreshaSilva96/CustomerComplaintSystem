using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IAgentTypeInterface
    {
        ICollection<AgentType> GetAllAgentTypes();

        AgentType GetAgentTypeByID(int AgentTypeID);

        void CreateAgentType(AgentType NewAgentType);

        int UpdateAgentType(int AgentTypeID, AgentType AgentTypeObject);

        void DeleteAgentType(int AgentTypeID);
    }
}
