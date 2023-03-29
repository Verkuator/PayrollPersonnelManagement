using PayrollPersonnelManagement.Common;
using PayrollPersonnelManagement.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public class PostControll
    {
        private readonly PayrollPersonnelManagementContext _dbContext;

        public PostControll(PayrollPersonnelManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Post> GetPostsList()
        {
            var postsList = _dbContext.Posts.ToList();
            return postsList;
        }

        public void AddPost(Post post)
        {
            _dbContext.Add(post);
            _dbContext.SaveChanges();
        }

        public void UpdatePost(Post post)
        {
            _dbContext.Update(post);
            _dbContext.SaveChanges();
        }

        public void RemovePost(Post post)
        {
            _dbContext.Remove(post);
            _dbContext.SaveChanges();
        }
    }
}
