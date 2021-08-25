using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Repositories
{
    public interface IEntityRepository
    {
        void Add(Entity entity);
        void Delete(Entity entity);
        bool SaveAll();
        List<Entity> GetAllEntities();
        Entity GetById(int Id);
        void UpdateEntity(Entity entity);
    }
}
