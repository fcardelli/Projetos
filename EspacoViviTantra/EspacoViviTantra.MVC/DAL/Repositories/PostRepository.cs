using System;
using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.MVC.DAL.Contexts;
using EspacoViviTantra.MVC.Models;
using EspacoViviTantra.MVC.Domain.Interfaces;

namespace EspacoViviTantra.MVC.DAL.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly EspacoViviTantraContext _espacoViviTantraContext;
        public PostRepository(EspacoViviTantraContext espacoViviTantraContext)
        {
            _espacoViviTantraContext = espacoViviTantraContext;
        }
        public List<Post> ListarPosts()
        {
            return _espacoViviTantraContext.Posts.ToList();
        }

        public Post ObterPostPorData(DateTime data)
        {
            return _espacoViviTantraContext.Posts.FirstOrDefault(p => p.Data == data);
        }

        public Post ObterPostPorId(int id)
        {
            return _espacoViviTantraContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void Salvar(Post post)
        {
            _espacoViviTantraContext.Posts.Add(post);
            _espacoViviTantraContext.SaveChanges();
        }
    }
}