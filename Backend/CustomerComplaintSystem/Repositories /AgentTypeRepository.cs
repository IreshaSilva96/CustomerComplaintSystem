using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;


namespace CustomerComplaintSystem.Repositories
{
    public class AgentTypeRepository : IAgentTypeInterface
    {
        ApplicationDbContext _applicationDbContext;

        public AgentTypeRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }


        public ICollection<AgentType> GetAllAgentTypes()
        {
            var agentTypes = _applicationDbContext.AgentType.ToList();
            return agentTypes;
        }

        public AgentType GetAgentTypeByID(int AgentTypeID)
        {
            var agentType = _applicationDbContext.AgentType.Where(x => x.AgentTypeID == AgentTypeID).SingleOrDefault();
            return agentType;
        }

        public void CreateAgentType(AgentType NewAgentType)
        {
            _applicationDbContext.AgentType.Add(NewAgentType);
            _applicationDbContext.SaveChanges();
        }

        public int UpdateAgentType(int AgentTypeID, AgentType AgentTypeObject)
        {
            var agentType = _applicationDbContext.AgentType.Where(x => x.AgentTypeID == AgentTypeID).SingleOrDefault();

            if (agentType == null)
            {
                return 0;
            }
            else
            {
                agentType.AgentTypeName = AgentTypeObject.AgentTypeName;
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }

        public void DeleteAgentType(int AgentTypeID)
        {
            var agentType = _applicationDbContext.AgentType.Where(x => x.AgentTypeID == AgentTypeID).SingleOrDefault();

            _applicationDbContext.AgentType.Remove(agentType);
            _applicationDbContext.SaveChanges();
        }
    }
}
