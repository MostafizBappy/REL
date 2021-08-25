using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Repositories
{
     public class EntityRepository : IEntityRepository
    {
        private readonly dbCIDEntities _context;
        public EntityRepository(dbCIDEntities context)
        {
            _context = context;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public List<Entity> GetAllEntities()
        {
            return _context.Entities.Where(x => (x.ActiveDeactive != null && x.ActiveDeactive == 1) && (x.eName != "" || x.eName != null)).OrderBy(x => x.eName).ToList();
        }

        public void Add(Entity entity)
        {
            _context.Entities.Add(entity);
        }

        public void Delete(Entity entity)
        {
            _context.Entities.Remove(entity);
        }

        public Entity GetById(int Id)
        {
            return _context.Entities.FirstOrDefault(x => x.EID == Id);
        }

        public void UpdateEntity(Entity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            SaveAll();
        }
    }
}
