using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    internal interface IGamerManager<T> 
    {
        public void update(T entity);
        public void delete(T entity);
        public void add(T entity);
    }
}
    