using WebApplication1.Models;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;
using OrganizationScores = WebApplication1.Models.OrganizationScores;

namespace WebApplication1.Repository
{
    public class OrganizationScoresRepository
    {
        private readonly WebApplication1Context context;

        
        public OrganizationScoresRepository(WebApplication1Context context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationScores> GetScore()
        {
            return context.organizationScores.OrderBy(x => x.Scores);
        }

        public int? SaveScore(OrganizationScores entity)
        {
            if (entity.id == null)
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
            return entity.id;
        }

        public OrganizationScores GetOrganizationScoresById(int? id)
        {
            return context.organizationScores.Single(x => x.id == id);
        }

        public void Delete(OrganizationScores model)
        {
            context.organizationScores.Remove(model);
            context.SaveChanges();
        }
    }
}
