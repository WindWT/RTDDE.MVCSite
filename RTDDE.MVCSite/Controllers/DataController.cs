using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RTDDE.Provider.MasterData;
using RTDDE.Provider;

namespace RTDDE.MVCSite.Controllers
{
    public class DataController : ApiController
    {
        public List<QuestMaster> GetQuest()
        {
            return DAL.ToList<QuestMaster>("Select * From Quest_Master");
        }
    }
}
