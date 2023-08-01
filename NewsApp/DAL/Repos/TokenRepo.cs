using DAL.EF.Models;
using DAL.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo : Repo, IRepo<Token, int, Token>
    {
        public Token Create(Token obj)
        {
            db.Tokens.Add(obj);
            if(db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(int id)
        {
            throw new NotImplementedException();
        }

        public Token Update(Token obj)
        {
            throw new NotImplementedException();
        }
    }
}
