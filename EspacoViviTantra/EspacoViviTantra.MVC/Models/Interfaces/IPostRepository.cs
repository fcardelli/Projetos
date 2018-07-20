using System;
using System.Collections.Generic;
using EspacoViviTantra.MVC.Models;

namespace EspacoViviTantra.MVC.Domain.Interfaces
{
    public interface IPostRepository
    {
        void Salvar(Post post);
        List<Post> ListarPosts();
        Post ObterPostPorData(DateTime data);
        Post ObterPostPorId(int id);

    }
}