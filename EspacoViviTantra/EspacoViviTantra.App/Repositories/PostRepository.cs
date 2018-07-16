using System;
using System.Collections.Generic;
using System.Linq;
using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantraApp.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly EspacoViviTantraAppContext _espacoViviTantraAppContext;
        public PostRepository(EspacoViviTantraAppContext espacoViviTantraAppContext)
        {
            _espacoViviTantraAppContext = espacoViviTantraAppContext;
        }
        public List<Post> ListarPosts()
        {
            return _espacoViviTantraAppContext.Posts.ToList();
        }

        public Post ObterPostPorData(DateTime data)
        {
            return _espacoViviTantraAppContext.Posts.FirstOrDefault(p => p.Data == data);
        }

        public Post ObterPostPorId(int id)
        {
            return _espacoViviTantraAppContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void Salvar(Post post)
        {
            _espacoViviTantraAppContext.Posts.Add(post);
            _espacoViviTantraAppContext.SaveChanges();
        }
    }
}