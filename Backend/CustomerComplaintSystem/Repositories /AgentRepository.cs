using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class AgentRepository : IAgentInterface
    {
        ApplicationDbContext _applicationDbContext;

        public AgentRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }

        

        public ICollection<Agent> GetAllAgents()
        {
            var agents = _applicationDbContext.Agent.ToList();
            return agents;
        }


        public Agent GetAgentByID(int AgentID)
        {
            var agent = _applicationDbContext.Agent.Where(x => x.AgentID == AgentID).SingleOrDefault();
            return agent;
        }


        public int ResetPassword(int AgentID)
        {
            var agent = (from _Agent in _applicationDbContext.Agent
                         join _Employee in _applicationDbContext.Employee
                         on _Agent.EmployeeID equals _Employee.EmployeeID
                         where _Agent.AgentID == AgentID
                         select _Agent).SingleOrDefault();

            if (agent == null)
            {
                return 0;
            }
            else
            {
                agent.Password = "Agent123";
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }


        public int ChangePassword(int AgentID, Agent newPassword)
        {
            var agent = _applicationDbContext.Agent.Where(x => x.AgentID == AgentID).SingleOrDefault();

            if (agent == null)
            {
                return 0;
            }
            else
            {
                agent.Password = newPassword.Password;
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }


        public void CreateAgent(Agent NewAgent)
        {
            _applicationDbContext.Agent.Add(NewAgent);
            _applicationDbContext.SaveChanges();
        }


        public int UpdateAgent(int AgentID, Agent AgentObject)
        {
            var agent = _applicationDbContext.Agent.Where(x => x.AgentID == AgentID).SingleOrDefault();

            if (agent == null)
            {
                return 0;
            }
            else
            {
                agent.AgentUserName = AgentObject.AgentUserName;
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }


        public void DeleteAgent(int AgentID)
        {
            var agent = _applicationDbContext.Agent.Where(x => x.AgentID == AgentID).SingleOrDefault();

            _applicationDbContext.Agent.Remove(agent);
            _applicationDbContext.SaveChanges();
        }

        
    }
}
