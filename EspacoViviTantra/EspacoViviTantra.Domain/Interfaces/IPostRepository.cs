using System.Collections.Generic;
using EspacoViviTantra.Domain.Models;

namespace EspacoViviTantra.Domain.Interfaces
{
    public interface IPostRepository
    {
        void Salvar(Post post);
        List<Post> ListarPosts();
        Post ObterPostPorData(string data);
        Post ObterPostPorId(int id);

    }
}