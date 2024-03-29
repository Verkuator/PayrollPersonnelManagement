﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PayrollPersonnelManagement.context;
using PayrollPersonnelManagement.Infasrtucture.Model;
using System.Collections.Generic;
using System.Linq;

namespace PayrollPersonnelManagement.Infasrtucture.Controlls
{
    public abstract class ModelActions<M, D> 
        where M : class, IModel, new()
        where D : class
    {
        public abstract string Name { get; set; }
        public abstract DbSet<M> DbSet { get; set; }
        protected abstract PayrollPersonnelManagementContext DbContext { get; set; }
        public abstract IMapper Mapper { get; set; }

        public virtual void NewDbContext()
        {
            DbContext.Dispose();
            DbContext = new PayrollPersonnelManagementContext();
        }

        public ModelActions(PayrollPersonnelManagementContext dbContext, DbSet<M> dbSet, IMapper mapper)
        {
            DbContext = dbContext;
            DbSet = dbSet;
            Mapper = mapper;
        }

        public virtual List<M> Get()
        {
            NewDbContext();
            var obj = DbSet.AsNoTracking().Where(c => !c.IsDelete).ToList();
            return obj;
        }

        public virtual M Save(M obj)
        {
            if (obj.Id == 0)
            {
                DbSet.Add(obj);
            }
            else
            {
                DbSet.Update(obj);
            }
            DbContext.SaveChanges();
            NewDbContext();
            return obj;
        }

        public virtual void Delete(M obj)
        {
            obj.IsDelete = true;
            DbSet.Update(obj);
            DbContext.SaveChanges();
            NewDbContext();
        }

        public virtual M MapToModel(D obj)
        {
            var res = Mapper.Map<M>(obj);
            return res;
        }

        public virtual D MapToDto(M obj)
        {
            var res = Mapper.Map<D>(obj);
            return res;
        }

        public virtual ICollection<M> MapToModel(ICollection<D> obj)
        {
            var res = Mapper.Map<ICollection<M>>(obj);
            return res;
        }

        public virtual ICollection<D> MapToDto(ICollection<M> obj)
        {
            var res = Mapper.Map<ICollection<D>>(obj);
            return res;
        }
    }
}
