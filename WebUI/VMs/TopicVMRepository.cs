using BLL.RepositoryPattern.RepositoryBase;
using BLL.RepositoryPattern.RepositoryConcrete;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.VMs
{
    public class TopicVMRepository:BaseRepository<TopicVM>
    {
        TopicRepository tr;

        public List<TopicVM> ListTopics()
        {
            return db.Topics.Where(x => x.DataStatus != MODEL.Enums.Status.Deleted).Select(x => new TopicVM
            {
                ID = x.ID,
                Body = x.Body,


            }).ToList();
        }

        public List<TopicVM> Add(Topic item)
        {
            tr.Add(item);
            return ListTopics();
        }
    }
}